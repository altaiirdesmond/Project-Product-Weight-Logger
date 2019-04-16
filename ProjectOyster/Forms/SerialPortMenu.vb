Imports ProjectOyster.Helpers

Namespace Forms

    Public Class SerialPortMenu
        Private _mcu As MicroController

        Public ReadOnly Property MicroControllerSetup() As MicroController
            Get
                Return _mcu
            End Get
        End Property

        Private Sub SerialPortMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _mcu = New MicroController()
            For Each ports In _mcu.GetPort()
                ComboBoxPorts.Items.Add(ports)
            Next
        End Sub

        ' Pick a port
        Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
            If ComboBoxPorts.Text = String.Empty Or ComboBoxPorts.Text = "Ports" Then
                Return
            End If

            _mcu.Port = ComboBoxPorts.Text
        End Sub
    End Class
End Namespace