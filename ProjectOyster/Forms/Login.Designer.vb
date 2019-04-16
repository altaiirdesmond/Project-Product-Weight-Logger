Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Login
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
            Me.ButtonLogin = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBoxPassword = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TextBoxUsername = New System.Windows.Forms.TextBox()
            Me.ButtonExit = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'ButtonLogin
            '
            Me.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.ButtonLogin.FlatAppearance.BorderSize = 0
            Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ButtonLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
            Me.ButtonLogin.ForeColor = System.Drawing.Color.White
            Me.ButtonLogin.Location = New System.Drawing.Point(123, 138)
            Me.ButtonLogin.Name = "ButtonLogin"
            Me.ButtonLogin.Size = New System.Drawing.Size(135, 33)
            Me.ButtonLogin.TabIndex = 16
            Me.ButtonLogin.Text = "Login"
            Me.ButtonLogin.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(41, 86)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(91, 24)
            Me.Label1.TabIndex = 15
            Me.Label1.Text = "password"
            '
            'TextBoxPassword
            '
            Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
            Me.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.TextBoxPassword.Location = New System.Drawing.Point(161, 84)
            Me.TextBoxPassword.Name = "TextBoxPassword"
            Me.TextBoxPassword.Size = New System.Drawing.Size(146, 26)
            Me.TextBoxPassword.TabIndex = 14
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(41, 42)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(100, 24)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "user name"
            '
            'TextBoxUsername
            '
            Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
            Me.TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.TextBoxUsername.Location = New System.Drawing.Point(161, 40)
            Me.TextBoxUsername.Name = "TextBoxUsername"
            Me.TextBoxUsername.Size = New System.Drawing.Size(146, 26)
            Me.TextBoxUsername.TabIndex = 12
            '
            'ButtonExit
            '
            Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
            Me.ButtonExit.BackgroundImage = CType(resources.GetObject("ButtonExit.BackgroundImage"), System.Drawing.Image)
            Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ButtonExit.FlatAppearance.BorderSize = 0
            Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ButtonExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
            Me.ButtonExit.ForeColor = System.Drawing.Color.White
            Me.ButtonExit.Location = New System.Drawing.Point(347, 7)
            Me.ButtonExit.Name = "ButtonExit"
            Me.ButtonExit.Size = New System.Drawing.Size(17, 19)
            Me.ButtonExit.TabIndex = 17
            Me.ButtonExit.UseVisualStyleBackColor = False
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(376, 204)
            Me.Controls.Add(Me.ButtonExit)
            Me.Controls.Add(Me.ButtonLogin)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextBoxPassword)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TextBoxUsername)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Login"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents ButtonLogin As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents TextBoxPassword As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TextBoxUsername As TextBox
        Friend WithEvents ButtonExit As Button
    End Class
End Namespace