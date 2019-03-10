Public Class Login

    Private defUsername As String = "Username"
    Private defPass As String = "Password"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxUsername.Text = defUsername
        TextBoxPassword.Text = defPass
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If (SqliteDataAccess.GetUserCount(TextBoxUsername.Text, TextBoxPassword.Text) = 0) Then
            MessageBox.Show("Invalid user", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim mm As Menu = New Menu()

        If SqliteDataAccess.IsAdmin(TextBoxUsername.Text, TextBoxPassword.Text) = False Then
            ' Set different view for normal user
            mm.SetGraphic(176, 81)
        End If

        mm.Show()
        Hide()
    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave
        If TextBoxUsername.Text = String.Empty Then
            TextBoxUsername.Text = defUsername
        End If
    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        If TextBoxPassword.Text = String.Empty Then
            TextBoxPassword.Text = defPass
        End If
    End Sub

    Private Sub TextBoxUsername_Click(sender As Object, e As EventArgs) Handles TextBoxUsername.Click
        If TextBoxUsername.Text = defUsername Then
            TextBoxUsername.Text = String.Empty
        End If
    End Sub

    Private Sub TextBoxPassword_Click(sender As Object, e As EventArgs) Handles TextBoxPassword.Click
        If TextBoxPassword.Text = defPass Then
            TextBoxPassword.Text = String.Empty
        End If
    End Sub

    Private Sub ButtonLogin_MouseEnter(sender As Object, e As EventArgs) Handles ButtonLogin.MouseEnter
        ButtonLogin.BackColor = Color.FromArgb(219, 109, 22)
        ButtonLogin.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonLogin_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLogin.MouseLeave
        ButtonLogin.BackColor = Color.FromArgb(255, 255, 255)
        ButtonLogin.ForeColor = Color.FromArgb(219, 109, 22)
    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub
End Class