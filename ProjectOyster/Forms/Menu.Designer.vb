<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.ButtonExtraction = New System.Windows.Forms.Button()
        Me.ButtonGraph = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonExtraction
        '
        Me.ButtonExtraction.Location = New System.Drawing.Point(45, 67)
        Me.ButtonExtraction.Name = "ButtonExtraction"
        Me.ButtonExtraction.Size = New System.Drawing.Size(162, 50)
        Me.ButtonExtraction.TabIndex = 0
        Me.ButtonExtraction.Text = "Extraction"
        Me.ButtonExtraction.UseVisualStyleBackColor = True
        '
        'ButtonGraph
        '
        Me.ButtonGraph.Location = New System.Drawing.Point(297, 67)
        Me.ButtonGraph.Name = "ButtonGraph"
        Me.ButtonGraph.Size = New System.Drawing.Size(162, 50)
        Me.ButtonGraph.TabIndex = 1
        Me.ButtonGraph.Text = "Graph"
        Me.ButtonGraph.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 179)
        Me.Controls.Add(Me.ButtonGraph)
        Me.Controls.Add(Me.ButtonExtraction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonExtraction As Button
    Friend WithEvents ButtonGraph As Button
End Class
