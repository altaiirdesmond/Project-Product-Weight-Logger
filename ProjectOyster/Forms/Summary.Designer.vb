<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartSummary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChartSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartSummary
        '
        Me.ChartSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ChartArea1.Name = "ChartArea1"
        Me.ChartSummary.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartSummary.Legends.Add(Legend1)
        Me.ChartSummary.Location = New System.Drawing.Point(0, 0)
        Me.ChartSummary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChartSummary.Name = "ChartSummary"
        Me.ChartSummary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartSummary.Series.Add(Series1)
        Me.ChartSummary.Size = New System.Drawing.Size(916, 505)
        Me.ChartSummary.TabIndex = 0
        Me.ChartSummary.Text = "Chart1"
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 502)
        Me.Controls.Add(Me.ChartSummary)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph"
        CType(Me.ChartSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartSummary As DataVisualization.Charting.Chart
End Class
