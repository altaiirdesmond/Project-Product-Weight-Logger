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

        Private Function GetCurrentMonth(currentDate As Date) As Integer
            Dim nMonth = Date.ParseExact(currentDate, "d/M/yyyy", Nothing).Month

            Return nMonth
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
            Dim currentWeekOfMonth = GetWeekNumberOfMonth(Date.ParseExact(dt, "d/M/yyyy", Nothing))

            For Each data As Oyster In SqliteDataAccess.GetAll()
                ' Increment index
                i += 1

                ' Sum all of the weight in current week iteration
                currentWeekSum += data.Weight

                ' Check if current week number has changed
                If currentWeekOfMonth <> GetWeekNumberOfMonth(Date.ParseExact(
                    data.Time.Split(" ")(0),
                    "d/M/yyyy",
                    Nothing)) Then

                    ' Compute for the average
                    Dim currentWeekAvg = currentWeekSum / i
                
                    weeklySummary.Add(New KeyValuePair(Of String, Decimal)(data.Time.Split(" ")(0) + " of #" + currentWeekOfMonth.ToString() + " week", currentWeekAvg))

                    ' Reset value
                    currentWeekSum = 0
                    i = 0
                    ' Set new week of the month
                    currentWeekOfMonth = GetWeekNumberOfMonth(Date.ParseExact(
                        data.Time.Split(" ")(0),
                        "d/M/yyyy",
                        Nothing))
                End If
            Next

            ' resulting average per week
            Return weeklySummary
        End Function

        Public Function GetMonthlySummary() As List(Of KeyValuePair(Of String, Decimal))

            ' DATE FORMAT: 5/18/2010 4:47 PM

            Dim monthlySummary = New List(Of KeyValuePair(Of String, Decimal))

            ' Index
            Dim i = 0

            ' Instance
            Dim currentMonthlySum As Decimal

            Dim sqliteData = SqliteDataAccess.GetAll().First()
            Dim dt = sqliteData.Time.Split(" ")(0)
            Dim currentMonth = GetCurrentMonth(Date.ParseExact(dt, "d/M/yyyy", Nothing))

            For Each data As Oyster In SqliteDataAccess.GetAll()

                i += 1

                currentMonthlySum += data.Weight

                If currentMonth <> GetCurrentMonth(Date.ParseExact(
                    data.Time.Split(" ")(0),
                    "d/M/yyyy",
                    Nothing))

                    ' Compute for the average
                    Dim currentMonthAvg = currentMonthlySum / i

                    monthlySummary.Add(New KeyValuePair(Of String, Decimal)(data.Time.Split(" ")(0) + " of #" + currentMonth.ToString() + " month", currentMonthAvg))

                    ' Reset
                    currentMonthlySum = 0
                    i = 0

                    ' Set new week of the month
                    currentMonth = GetCurrentMonth(Date.ParseExact(
                        data.Time.Split(" ")(0),
                        "d/M/yyyy",
                        Nothing))
                End If
            Next

            Return monthlySummary
        End Function
    End Class
End Namespace