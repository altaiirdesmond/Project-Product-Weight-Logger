Namespace Forms

    Public Class MainMenu
        Public Shared Property MainMenuShell As Form

        Private Sub ButtonGraph_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
            Dim login = New Login
            login.ShowDialog()

            If login.Valid <> True Then
                Return
            End If

            Hide()

            Dim summary = New Summary()
            If summary.ShowDialog() = DialogResult.Abort Then
                Close()

                Return
            End If

            Show()
        End Sub

        Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
            Hide()

            Dim userInput = New UserInput
            userInput.ShowDialog()

            Show()
        End Sub

        Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            MainMenuShell = Me

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