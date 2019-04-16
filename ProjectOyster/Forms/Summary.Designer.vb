Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Summary
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonDaily = New System.Windows.Forms.Button()
        Me.ButtonWeekly = New System.Windows.Forms.Button()
        Me.ButtonMonthly = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChartSummary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ButtonBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ChartSummary,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.White
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonExit.Location = New System.Drawing.Point(884, 528)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(106, 37)
        Me.ButtonExit.TabIndex = 1
        Me.ButtonExit.Text = "Log out"
        Me.ButtonExit.UseVisualStyleBackColor = false
        '
        'ButtonDaily
        '
        Me.ButtonDaily.BackColor = System.Drawing.Color.White
        Me.ButtonDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonDaily.Location = New System.Drawing.Point(884, 166)
        Me.ButtonDaily.Name = "ButtonDaily"
        Me.ButtonDaily.Size = New System.Drawing.Size(106, 37)
        Me.ButtonDaily.TabIndex = 2
        Me.ButtonDaily.Text = "Daily"
        Me.ButtonDaily.UseVisualStyleBackColor = false
        '
        'ButtonWeekly
        '
        Me.ButtonWeekly.BackColor = System.Drawing.Color.White
        Me.ButtonWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWeekly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonWeekly.Location = New System.Drawing.Point(884, 222)
        Me.ButtonWeekly.Name = "ButtonWeekly"
        Me.ButtonWeekly.Size = New System.Drawing.Size(106, 37)
        Me.ButtonWeekly.TabIndex = 3
        Me.ButtonWeekly.Text = "Weekly"
        Me.ButtonWeekly.UseVisualStyleBackColor = false
        '
        'ButtonMonthly
        '
        Me.ButtonMonthly.BackColor = System.Drawing.Color.White
        Me.ButtonMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonMonthly.Location = New System.Drawing.Point(884, 281)
        Me.ButtonMonthly.Name = "ButtonMonthly"
        Me.ButtonMonthly.Size = New System.Drawing.Size(106, 37)
        Me.ButtonMonthly.TabIndex = 4
        Me.ButtonMonthly.Text = "Monthly"
        Me.ButtonMonthly.UseVisualStyleBackColor = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(886, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(907, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Admin"
        '
        'ChartSummary
        '
        Me.ChartSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ChartArea1.Name = "ChartArea1"
        Me.ChartSummary.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartSummary.Legends.Add(Legend1)
        Me.ChartSummary.Location = New System.Drawing.Point(0, 0)
        Me.ChartSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.ChartSummary.Name = "ChartSummary"
        Me.ChartSummary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ChartSummary.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartSummary.Series.Add(Series1)
        Me.ChartSummary.Size = New System.Drawing.Size(851, 603)
        Me.ChartSummary.TabIndex = 0
        Me.ChartSummary.Text = "Chart1"
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.White
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonBack.Location = New System.Drawing.Point(884, 469)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(106, 37)
        Me.ButtonBack.TabIndex = 9
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = false
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 603)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ChartSummary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonMonthly)
        Me.Controls.Add(Me.ButtonWeekly)
        Me.Controls.Add(Me.ButtonDaily)
        Me.Controls.Add(Me.ButtonExit)
        Me.Font = New System.Drawing.Font("Century Gothic", 10!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ChartSummary,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents ButtonExit As Button
        Friend WithEvents ButtonDaily As Button
        Friend WithEvents ButtonWeekly As Button
        Friend WithEvents ButtonMonthly As Button
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label4 As Label
        Friend WithEvents ChartSummary As DataVisualization.Charting.Chart
        Friend WithEvents ButtonBack As Button
    End Class
End Namespace