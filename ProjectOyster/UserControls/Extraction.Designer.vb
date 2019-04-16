Namespace UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Extraction
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxCurrentStatus = New System.Windows.Forms.TextBox()
        Me.LabelCurrentWeight = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonForceStop = New System.Windows.Forms.Button()
        Me.ButtonStopDetach = New System.Windows.Forms.Button()
        Me.CheckExtractStatus = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonDone = New System.Windows.Forms.Button()
        Me.ButtonContinue = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98,Byte),Integer), CType(CType(189,Byte),Integer), CType(CType(221,Byte),Integer))
        Me.Panel1.Controls.Add(Me.TextBoxCurrentStatus)
        Me.Panel1.Controls.Add(Me.LabelCurrentWeight)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 194)
        Me.Panel1.TabIndex = 16
        '
        'TextBoxCurrentStatus
        '
        Me.TextBoxCurrentStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(98,Byte),Integer), CType(CType(189,Byte),Integer), CType(CType(221,Byte),Integer))
        Me.TextBoxCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCurrentStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCurrentStatus.ForeColor = System.Drawing.Color.White
        Me.TextBoxCurrentStatus.Location = New System.Drawing.Point(147, 50)
        Me.TextBoxCurrentStatus.Name = "TextBoxCurrentStatus"
        Me.TextBoxCurrentStatus.ReadOnly = true
        Me.TextBoxCurrentStatus.Size = New System.Drawing.Size(310, 35)
        Me.TextBoxCurrentStatus.TabIndex = 11
        Me.TextBoxCurrentStatus.TabStop = false
        Me.TextBoxCurrentStatus.Text = "Idle"
        Me.TextBoxCurrentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCurrentWeight
        '
        Me.LabelCurrentWeight.AutoSize = true
        Me.LabelCurrentWeight.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentWeight.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelCurrentWeight.ForeColor = System.Drawing.Color.White
        Me.LabelCurrentWeight.Location = New System.Drawing.Point(630, 51)
        Me.LabelCurrentWeight.Name = "LabelCurrentWeight"
        Me.LabelCurrentWeight.Size = New System.Drawing.Size(48, 34)
        Me.LabelCurrentWeight.TabIndex = 10
        Me.LabelCurrentWeight.Text = "0g"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(568, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 34)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Current weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(207, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current status"
        '
        'ButtonForceStop
        '
        Me.ButtonForceStop.BackColor = System.Drawing.Color.White
        Me.ButtonForceStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonForceStop.Font = New System.Drawing.Font("Century Gothic", 15!)
        Me.ButtonForceStop.ForeColor = System.Drawing.Color.Red
        Me.ButtonForceStop.Location = New System.Drawing.Point(646, 59)
        Me.ButtonForceStop.Name = "ButtonForceStop"
        Me.ButtonForceStop.Size = New System.Drawing.Size(201, 43)
        Me.ButtonForceStop.TabIndex = 20
        Me.ButtonForceStop.Text = "Force stop"
        Me.ButtonForceStop.UseVisualStyleBackColor = false
        '
        'ButtonStopDetach
        '
        Me.ButtonStopDetach.BackColor = System.Drawing.Color.White
        Me.ButtonStopDetach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStopDetach.Font = New System.Drawing.Font("Century Gothic", 15!)
        Me.ButtonStopDetach.ForeColor = System.Drawing.Color.Black
        Me.ButtonStopDetach.Location = New System.Drawing.Point(397, 59)
        Me.ButtonStopDetach.Name = "ButtonStopDetach"
        Me.ButtonStopDetach.Size = New System.Drawing.Size(201, 43)
        Me.ButtonStopDetach.TabIndex = 19
        Me.ButtonStopDetach.TabStop = false
        Me.ButtonStopDetach.Text = "Stop detaching"
        Me.ButtonStopDetach.UseVisualStyleBackColor = false
        '
        'CheckExtractStatus
        '
        '
        'ButtonDone
        '
        Me.ButtonDone.BackColor = System.Drawing.Color.White
        Me.ButtonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDone.Font = New System.Drawing.Font("Century Gothic", 15!)
        Me.ButtonDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonDone.Location = New System.Drawing.Point(147, 59)
        Me.ButtonDone.Name = "ButtonDone"
        Me.ButtonDone.Size = New System.Drawing.Size(201, 43)
        Me.ButtonDone.TabIndex = 21
        Me.ButtonDone.TabStop = false
        Me.ButtonDone.Text = "Done"
        Me.ButtonDone.UseVisualStyleBackColor = false
        '
        'ButtonContinue
        '
        Me.ButtonContinue.BackColor = System.Drawing.Color.White
        Me.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonContinue.Font = New System.Drawing.Font("Century Gothic", 15!)
        Me.ButtonContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(157,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.ButtonContinue.Location = New System.Drawing.Point(397, 135)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(201, 43)
        Me.ButtonContinue.TabIndex = 22
        Me.ButtonContinue.TabStop = false
        Me.ButtonContinue.Text = "Continue"
        Me.ButtonContinue.UseVisualStyleBackColor = false
        Me.ButtonContinue.Visible = false
        '
        'Extraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonContinue)
        Me.Controls.Add(Me.ButtonDone)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonForceStop)
        Me.Controls.Add(Me.ButtonStopDetach)
        Me.Name = "Extraction"
        Me.Size = New System.Drawing.Size(1018, 603)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents TextBoxCurrentStatus As TextBox
        Friend WithEvents LabelCurrentWeight As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents ButtonForceStop As Button
        Friend WithEvents ButtonStopDetach As Button
        Friend WithEvents CheckExtractStatus As Timer
        Friend WithEvents ButtonDone As Button
        Friend WithEvents ButtonContinue As Button
    End Class
End Namespace