Imports System.Windows.Forms.DataVisualization.Charting

Public Class Visualization
    Public Property Chart() As Chart

    Public Sub Populate(list As List(Of Oyster))
        Chart.Series.Clear()

        Chart.Series.Add(0)
        Chart.Series(0).ChartType = SeriesChartType.FastLine
        Chart.Series(0).Name = "Weight"

        Chart.ChartAreas(0).AxisX.Title = "Time"
        Chart.ChartAreas(0).AxisY.Title = "Kg"
        Chart.ChartAreas(0).AxisX.Minimum = 0
        Chart.ChartAreas(0).AxisX.Maximum = SqliteDataAccess.GetAll().Count

        ' Populate the chart
        For Each item In list
            Chart.Series(0).Points.AddXY(item.Time, item.Weight)
        Next
    End Sub
End Class
