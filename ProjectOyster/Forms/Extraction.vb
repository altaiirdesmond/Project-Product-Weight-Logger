Imports System.IO.Ports

Public Class Extraction
    Private mcu As MicroController

    Private Delegate Sub NotifyDelegate() ' References the method
    Private Notify As NotifyDelegate ' Responsible for invoking the referenced method

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spm As SerialPortMenu = New SerialPortMenu()
        spm.ShowDialog() ' This will interrupt the code until closed

        mcu = spm.MicroControllerSetup
        mcu.InitializePort()

        AddHandler mcu.SerialPort.DataReceived, AddressOf DataReceivedHandler ' Listen for events
    End Sub

    Private Sub ButtonExtract_Click(sender As Object, e As EventArgs) Handles ButtonExtract.Click
        mcu.WriteToPort("extract")
    End Sub

    ' Event handler
    Public Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Notify = New NotifyDelegate(AddressOf Listener)

        If mcu.SerialPort.ReadLine().Contains("finish") Then
            Invoke(Sub() LabelStatus.Text = "Finished extracting")

            Dim oyster As New Oyster
            With oyster
                .Weight = Convert.ToDouble(TextBoxWeight.Text)
                .Time = Date.Now
            End With
            SqliteDataAccess.AddOyster(oyster)
        End If

        Invoke(Notify)
    End Sub

    Public Sub Listener()
        'MsgBox(mcu.Data)
        'If mcu.Data = "finish" Then
        '    Dim oyster As New Oyster
        '    With oyster
        '        .Weight = Convert.ToDouble(TextBoxWeight.Text)
        '        .Time = Date.Now
        '    End With
        '    SqliteDataAccess.AddOyster(oyster)
        '    'Invoke(Sub() LabelStatus.Text = "Finished extracting")
        'End If
    End Sub
End Class