Imports System.Windows.Forms.DataVisualization.Charting

Public Class GraphUC
    Public Sub Visualize()
        ChartOysterSummary.Series.Clear()
        ChartOysterSummary.Series.Add("My data")
        ChartOysterSummary.ChartAreas("My data").AxisX.Minimum = 0
        ChartOysterSummary.ChartAreas("My data").AxisX.Maximum = SqliteDataAccess.GetAll().Count

        For Each item In SqliteDataAccess.GetAll()
            ChartOysterSummary.Series("My data").Points.AddXY(item.Time, item.Weight)
        Next
    End Sub

    Private Sub GraphUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visualize()
    End Sub
End Class
