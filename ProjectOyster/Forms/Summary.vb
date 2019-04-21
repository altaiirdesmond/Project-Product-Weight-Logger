Imports ProjectOyster.Helpers

Namespace Forms
    Public Class Summary
        Private _vs As Visualization
        Private _close As Boolean

        Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _vs = New Visualization()
            _vs.SetChart(ChartSummary, SqliteDataAccess.GetAll().Count)
            _vs.Populate(SqliteDataAccess.GetAll())
        End Sub

        Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
            MicroController.Instance.ClosePort()

            If MsgBox("Do you want to log out?", MsgBoxStyle.YesNo, "Logout?") = MsgBoxResult.No Then
                _close = False
            End If

            Close()
        End Sub

        Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
            _close = True
            Close()
        End Sub

        Private Sub ButtonDaily_Click(sender As Object, e As EventArgs) Handles ButtonDaily.Click
            _vs = New Visualization()
            _vs.SetChart(ChartSummary, SqliteDataAccess.GetAll().Count)
            _vs.Populate(SqliteDataAccess.GetAll())
        End Sub

        Private Sub ButtonWeekly_Click(sender As Object, e As EventArgs) Handles ButtonWeekly.Click
            Dim report = New Report
            _vs = New Visualization()
            _vs.SetChart(ChartSummary, report.GetWeeklySummary().Count)
            _vs.Populate(report.GetWeeklySummary())
        End Sub

        Private Sub ButtonMonthly_Click(sender As Object, e As EventArgs) Handles ButtonMonthly.Click

        End Sub

        Private Sub Summary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not _close 
                _close ^= _close
                e.Cancel = True
            End If
        End Sub
    End Class
End Namespace