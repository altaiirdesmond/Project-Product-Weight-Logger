Imports ProjectOyster.Helpers

Namespace Forms
    Public Class Login

        Public Property Valid As Boolean

        Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
            Valid = UserValid()

            If Valid <> True Then
                Return
            End If

            Close()
        End Sub

        Private Function UserValid() As Boolean

            If (SqliteDataAccess.GetUserCount(TextBoxUsername.Text, TextBoxPassword.Text) = 0) Then
                MessageBox.Show("Invalid user", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Return True
        End Function

        Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
            Close()
        End Sub
    End Class
End Namespace