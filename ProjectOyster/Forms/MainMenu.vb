Imports System.IO.Ports

Public Class MainMenu
    Private WithEvents mcu As MicroController
    Private Delegate Sub NotifyDelegate()
    Private Notify As NotifyDelegate

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spm As SerialPortMenu = New SerialPortMenu()
        spm.ShowDialog() ' This will interrupt the code until closed

        mcu = spm.MicroControllerSetup
        mcu.InitializePort()

        AddHandler mcu.SerialPort.DataReceived, AddressOf DataReceivedHandler
    End Sub

    Private Sub ButtonExtract_Click(sender As Object, e As EventArgs) Handles ButtonExtract.Click

    End Sub

    ' Event handler
    Public Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Notify = New NotifyDelegate(AddressOf T)

        Invoke(Notify)
    End Sub

    Public Sub T()
        MsgBox(mcu.Data)
    End Sub
End Class