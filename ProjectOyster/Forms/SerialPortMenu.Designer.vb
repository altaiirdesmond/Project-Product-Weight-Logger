Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SerialPortMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialPortMenu))
        Me.ComboBoxPorts = New System.Windows.Forms.ComboBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ComboBoxPorts
        '
        Me.ComboBoxPorts.BackColor = System.Drawing.Color.White
        Me.ComboBoxPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPorts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!)
        Me.ComboBoxPorts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.ComboBoxPorts.FormattingEnabled = true
        Me.ComboBoxPorts.Location = New System.Drawing.Point(88, 43)
        Me.ComboBoxPorts.Name = "ComboBoxPorts"
        Me.ComboBoxPorts.Size = New System.Drawing.Size(132, 24)
        Me.ComboBoxPorts.TabIndex = 0
        Me.ComboBoxPorts.Text = "Ports"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.White
        Me.ButtonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Century Gothic", 10!)
        Me.ButtonConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.ButtonConnect.Location = New System.Drawing.Point(32, 107)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(95, 33)
        Me.ButtonConnect.TabIndex = 1
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = false
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.White
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Century Gothic", 10!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.ButtonCancel.Location = New System.Drawing.Point(162, 107)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(95, 33)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = false
        '
        'SerialPortMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(295, 180)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.ComboBoxPorts)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SerialPortMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SerialPortMenu"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents ComboBoxPorts As ComboBox
        Friend WithEvents ButtonConnect As Button
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents ButtonCancel As Button
    End Class
End Namespace