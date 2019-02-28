Imports System.IO.Ports

Public Class SerialPortMenu

    Private mcu As MicroController

    Public ReadOnly Property MicroControllerSetup() As MicroController
        Get
            Return mcu
        End Get
    End Property

    Private Sub SerialPortMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mcu = New MicroController()
        For Each ports In mcu.GetPort()
            ComboBoxPorts.Items.Add(ports)
        Next
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        mcu.Port = ComboBoxPorts.Text
        Me.Close()
    End Sub
End Class