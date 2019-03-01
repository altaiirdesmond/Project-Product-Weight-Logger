Public Class Summary
    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vs As Visualization = New Visualization()
        vs.Chart = ChartSummary
        vs.Populate(SqliteDataAccess.GetAll())
    End Sub
End Class