Public Class Menu
    Private Sub ButtonExtraction_Click(sender As Object, e As EventArgs) Handles ButtonExtraction.Click
        Dim ex As Extraction = New Extraction
        ex.ShowDialog()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonGraph_Click(sender As Object, e As EventArgs) Handles ButtonGraph.Click
        Dim sm As Summary = New Summary()
        sm.ShowDialog()
    End Sub
End Class