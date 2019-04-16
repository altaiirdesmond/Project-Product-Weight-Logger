Imports ProjectOyster.UserControls

Namespace Forms
    Public Class UserInput
        Public Shared Property BackButton as Button
        Public Shared Property ShellPanel As Panel
        Public Shared Property ShellForm as Form

        Private Sub UserInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BackButton = ButtonBack
            ShellPanel = PanelContainer
            ShellForm = Me

            If Not ShellPanel.Controls.Contains(Input.Instance)
                ' Add Input usercontrol
                ShellPanel.Controls.Add(Input.Instance)
                Input.Instance.Dock = DockStyle.Fill
                Input.Instance.BringToFront()
            Else
                Input.Instance.BringToFront()
            End If
        End Sub

        Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
            Close()
        End Sub
    End Class
End Namespace