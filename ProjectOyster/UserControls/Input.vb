Imports ProjectOyster.Forms

Namespace UserControls
    Public Class Input
        Inherits UserControl

        Private Shared _instance As Input

        ' Singleton
        Public Shared ReadOnly Property Instance as Input
        Get
            If _instance Is Nothing
                _instance = New Input()
            End If

            Return _instance
        End Get
        End Property

        Private Sub ButtonExtract_Click(sender As Object, e As EventArgs) Handles ButtonExtract.Click, ButtonExtract.Click
            If TextBoxWeight.Text Is String.Empty Or TextBoxUsername.Text Is String.Empty
                MsgBox("Invalid input", MsgBoxStyle.OkOnly, "Invalid")

                Return
            End If

            Extraction.Weight = TextBoxWeight.Text
            Extraction.User = TextBoxUsername.Text

            If Not UserInput.ShellPanel.Contains(Extraction.Instance)
                UserInput.ShellPanel.Controls.Add(Extraction.Instance)

                Extraction.Instance.Dock = DockStyle.Fill
                Extraction.Instance.BringToFront()
            Else
                Extraction.Instance.BringToFront()
            End If

            UserInput.BackButton.Visible = False
        End Sub

        Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim position = PointToScreen(Label1.Location)
            position = PictureBoxBackground.PointToClient(position)
            Label1.Parent = PictureBoxBackground
            Label1.Location = position
            Label1.BackColor = Color.Transparent

            position = PointToScreen(Label2.Location)
            position = PictureBoxBackground.PointToClient(position)
            Label2.Parent = PictureBoxBackground
            Label2.Location = position
            Label2.BackColor = Color.Transparent

            position = PointToScreen(Label3.Location)
            position = PictureBoxBackground.PointToClient(position)
            Label3.Parent = PictureBoxBackground
            Label3.Location = position
            Label3.BackColor = Color.Transparent
        End Sub
    End Class
End Namespace