Namespace UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Input
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Input))
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.TextBoxWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxBackground = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBackground,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ButtonOk
        '
        Me.ButtonOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonOk.FlatAppearance.BorderSize = 0
        Me.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOk.Font = New System.Drawing.Font("Century Gothic", 15!, System.Drawing.FontStyle.Bold)
        Me.ButtonOk.ForeColor = System.Drawing.Color.White
        Me.ButtonOk.Location = New System.Drawing.Point(366, 369)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(265, 70)
        Me.ButtonOk.TabIndex = 21
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = false
        '
        'TextBoxWeight
        '
        Me.TextBoxWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.TextBoxWeight.Location = New System.Drawing.Point(685, 229)
        Me.TextBoxWeight.Name = "TextBoxWeight"
        Me.TextBoxWeight.Size = New System.Drawing.Size(183, 38)
        Me.TextBoxWeight.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(478, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 34)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Input weight:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.TextBoxUsername.Location = New System.Drawing.Point(247, 229)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(183, 38)
        Me.TextBoxUsername.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 34)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(395, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 34)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "INSERT INPUT"
        '
        'PictureBoxBackground
        '
        Me.PictureBoxBackground.Image = CType(resources.GetObject("PictureBoxBackground.Image"),System.Drawing.Image)
        Me.PictureBoxBackground.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxBackground.Name = "PictureBoxBackground"
        Me.PictureBoxBackground.Size = New System.Drawing.Size(1020, 605)
        Me.PictureBoxBackground.TabIndex = 22
        Me.PictureBoxBackground.TabStop = false
        '
        'Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.TextBoxWeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxBackground)
        Me.Name = "Input"
        Me.Size = New System.Drawing.Size(1020, 605)
        CType(Me.PictureBoxBackground,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents ButtonOk As Button
        Friend WithEvents TextBoxWeight As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents TextBoxUsername As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents PictureBoxBackground As PictureBox
    End Class
End Namespace