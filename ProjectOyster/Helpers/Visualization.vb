Imports System.Windows.Forms.DataVisualization.Charting
Imports ProjectOyster.Models

Namespace Helpers
    Public Class Visualization

        Private _chart As Chart

        Public Sub Populate(entireSummary As List(Of Oyster))
            For Each item In entireSummary
                GetChart().Series(0).Points.AddXY(item.Time, item.Weight)
            Next
        End Sub

        Public Sub Populate(summary As List(Of KeyValuePair(Of String, Decimal)))
            For Each item In summary
                GetChart().Series(0).Points.AddXY(item.Key, item.Value)
            Next
        End Sub

        Public Sub SetChart(chart As Chart, maximum As Integer)
            _chart = chart

            _chart.Series.Clear()

            _chart.Series.Add(0)
            _chart.Series(0).ChartType = SeriesChartType.FastLine
            _chart.Series(0).Name = "Weight"

            _chart.ChartAreas(0).AxisX.Title = "Time"
            _chart.ChartAreas(0).AxisY.Title = "Units: g"
            _chart.ChartAreas(0).AxisX.Minimum = 0
            _chart.ChartAreas(0).AxisX.Maximum = maximum
        End Sub

        Public Function GetChart() As Chart
            Return _chart
        End Function
    End Class
End Namespace