<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ChartOysterSummary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChartOysterSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartOysterSummary
        '
        ChartArea1.Name = "My data"
        Me.ChartOysterSummary.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartOysterSummary.Legends.Add(Legend1)
        Me.ChartOysterSummary.Location = New System.Drawing.Point(0, 0)
        Me.ChartOysterSummary.Name = "ChartOysterSummary"
        Series1.ChartArea = "My data"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartOysterSummary.Series.Add(Series1)
        Me.ChartOysterSummary.Size = New System.Drawing.Size(604, 395)
        Me.ChartOysterSummary.TabIndex = 0
        Me.ChartOysterSummary.Text = "Oyster toll"
        '
        'GraphUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChartOysterSummary)
        Me.Name = "GraphUC"
        Me.Size = New System.Drawing.Size(604, 395)
        CType(Me.ChartOysterSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartOysterSummary As DataVisualization.Charting.Chart
End Class
