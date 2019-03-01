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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.ButtonExtraction = New System.Windows.Forms.Button()
        Me.ButtonGraph = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonExtraction
        '
        Me.ButtonExtraction.BackColor = System.Drawing.SystemColors.Window
        Me.ButtonExtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExtraction.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.ButtonExtraction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ButtonExtraction.Location = New System.Drawing.Point(65, 81)
        Me.ButtonExtraction.Name = "ButtonExtraction"
        Me.ButtonExtraction.Size = New System.Drawing.Size(162, 50)
        Me.ButtonExtraction.TabIndex = 0
        Me.ButtonExtraction.Text = "Extraction"
        Me.ButtonExtraction.UseVisualStyleBackColor = False
        '
        'ButtonGraph
        '
        Me.ButtonGraph.BackColor = System.Drawing.SystemColors.Window
        Me.ButtonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGraph.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.ButtonGraph.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ButtonGraph.Location = New System.Drawing.Point(288, 81)
        Me.ButtonGraph.Name = "ButtonGraph"
        Me.ButtonGraph.Size = New System.Drawing.Size(162, 50)
        Me.ButtonGraph.TabIndex = 1
        Me.ButtonGraph.Text = "Graph"
        Me.ButtonGraph.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 191)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(390, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu"
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Window
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ButtonClose.Location = New System.Drawing.Point(1, 162)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(69, 28)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(514, 191)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGraph)
        Me.Controls.Add(Me.ButtonExtraction)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonExtraction As Button
    Friend WithEvents ButtonGraph As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClose As Button
End Class
