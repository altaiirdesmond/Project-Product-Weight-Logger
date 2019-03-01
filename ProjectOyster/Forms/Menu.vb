Public Class Menu
    Private Sub ButtonExtraction_Click(sender As Object, e As EventArgs) Handles ButtonExtraction.Click
        Hide()
        Dim sp As SerialPortMenu = New SerialPortMenu()
        If sp.ShowDialog().Equals(DialogResult.Cancel) Then
            Return
        End If

        Dim ex As Extraction = New Extraction
        ' Prepare MicroController
        ex.MicroController = sp.MicroControllerSetup
        ex.ShowDialog()
        sp.MicroControllerSetup.ClosePort()
        Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonGraph_Click(sender As Object, e As EventArgs) Handles ButtonGraph.Click
        Dim sm As Summary = New Summary()
        sm.ShowDialog()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub
End Class