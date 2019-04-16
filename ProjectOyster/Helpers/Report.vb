Imports System.Globalization
Imports ProjectOyster.Models

Namespace Helpers
    Public Class Report
        Private Function GetWeekNumberOfMonth(currentDate As Date) As Integer
            currentDate = currentDate.Date
            Dim firstMonthDay = New DateTime(currentDate.Year, currentDate.Month, 1)
            Dim firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) Mod 7)
            If firstMonthMonday > currentDate Then
                firstMonthDay = firstMonthDay.AddMonths(-1)
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) Mod 7)
            End If

            Return (currentDate - firstMonthMonday).Days / 7 + 1
        End Function

        Public Function GetWeeklySummary() As List(Of KeyValuePair(Of String, Decimal))
            ' DATE FORMAT: 5/18/2010 4:47 PM

            Dim weeklySummary = New List(Of KeyValuePair(Of String, Decimal))

            ' Index
            Dim i = 0

            ' Instance
            Dim currentWeekSum As Decimal

            ' Get the first month and week found in the first row of database
            Dim sqliteData = SqliteDataAccess.GetAll().First()
            Dim dt = sqliteData.Time.Split(" ")(0)
            Dim currentWeekOfMonth = GetWeekNumber(Date.ParseExact(dt, "yyyy/M/d", Nothing))

            For Each data As Oyster In SqliteDataAccess.GetAll()
                ' Increment index
                i += 1

                ' Sum all of the weight in current week iteration
                currentWeekSum += data.Weight

                ' Check if current week number has changed
                If currentWeekOfMonth <> GetWeekNumber(Date.ParseExact(
                    data.Time.Split(" ")(0),
                    "yyyy/M/d",
                    Nothing)) Then

                    ' Compute for the average
                    Dim currentWeekAvg = currentWeekSum / i
                    weeklySummary.Add(New KeyValuePair(Of String, Decimal)(data.Time.Split(" ")(0) + " of #" + currentWeekOfMonth.ToString() + " week", currentWeekAvg))

                    ' Reset value
                    currentWeekSum = 0
                    ' Set new week of the month
                    currentWeekOfMonth = GetWeekNumberOfMonth(Date.ParseExact(
                        data.Time.Split(" ")(0),
                        "yyyy/M/d",
                        Nothing))
                End If
            Next

            ' resulting average per week
            Return weeklySummary
        End Function


        Function GetWeekNumber(d As Date) As Integer
            Dim d2 = d

            Dim wd = 0

            While d2.DayOfWeek <> CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek

                wd += 1

                d2 = d2.AddDays(-1)

            End While


            Dim m = d.Month

            Dim w = 0

            Do

                w += 1

                d = d.AddDays(-7)

            Loop While d.AddDays(-wd + 6).Month = m

            Return w
        End Function
    End Class
End Namespace