<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Extraction
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
        Me.ButtonExtract = New System.Windows.Forms.Button()
        Me.TextBoxWeight = New System.Windows.Forms.TextBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonExtract
        '
        Me.ButtonExtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonExtract.FlatAppearance.BorderSize = 0
        Me.ButtonExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExtract.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.ButtonExtract.Location = New System.Drawing.Point(77, 118)
        Me.ButtonExtract.Name = "ButtonExtract"
        Me.ButtonExtract.Size = New System.Drawing.Size(161, 43)
        Me.ButtonExtract.TabIndex = 1
        Me.ButtonExtract.Text = "EXTRACT"
        Me.ButtonExtract.UseVisualStyleBackColor = False
        '
        'TextBoxWeight
        '
        Me.TextBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxWeight.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.TextBoxWeight.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBoxWeight.Location = New System.Drawing.Point(70, 50)
        Me.TextBoxWeight.Name = "TextBoxWeight"
        Me.TextBoxWeight.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxWeight.TabIndex = 2
        Me.TextBoxWeight.Text = "Weight"
        Me.TextBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.LabelStatus.Location = New System.Drawing.Point(12, 219)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(71, 16)
        Me.LabelStatus.TabIndex = 3
        Me.LabelStatus.Text = "Extracting..."
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 244)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.TextBoxWeight)
        Me.Controls.Add(Me.ButtonExtract)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExtract As Button
    Friend WithEvents TextBoxWeight As TextBox
    Friend WithEvents LabelStatus As Label
End Class
