Imports System.IO.Ports

Public Class Extraction

    Private defString As String = "weight"

    Public Property MicroController() As MicroController

    Private Delegate Sub NotifyDelegate() ' References the method
    Private Notify As NotifyDelegate ' Responsible for invoking the referenced method

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Microcontroller has been setup on SerialPortMenu so we only need to initialize here
        MicroController.InitializePort()

        TextBoxWeight.Text = defString
        LabelStatus.Text = String.Empty

        AddHandler MicroController.SerialPort.DataReceived, AddressOf DataReceivedHandler ' Listen for events
    End Sub

    Private Sub ButtonExtract_Click(sender As Object, e As EventArgs) Handles ButtonExtract.Click
        If (TextBoxWeight.Text = String.Empty) Then
            MessageBox.Show("Invalid input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        For Each c In TextBoxWeight.Text.ToCharArray()
            If c = "." Then
                Continue For
            End If

            If Not Char.IsDigit(c) Then
                MessageBox.Show("Invalid input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Next

        MicroController.WriteToPort("extract")

        Invoke(Sub() LabelStatus.Text = "Extracting...")
    End Sub

    ' Event handler
    Public Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Notify = New NotifyDelegate(AddressOf Listener)

        If MicroController.SerialPort.ReadLine().Contains("finish") Then
            Invoke(Sub() LabelStatus.Text = "Finished extracting")

            Dim oyster As New Oyster
            With oyster
                .Weight = Convert.ToDouble(TextBoxWeight.Text)
                .Time = Date.Now
            End With
            SqliteDataAccess.AddOyster(oyster)

            Invoke(Sub() LabelStatus.Text = "...")
        End If

        Invoke(Notify)
    End Sub

    Public Sub Listener()
        Close()
    End Sub

    Private Sub TextBoxWeight_Click(sender As Object, e As EventArgs) Handles TextBoxWeight.Click
        If TextBoxWeight.Text = defString Then
            TextBoxWeight.Text = String.Empty
        End If
    End Sub

    Private Sub TextBoxWeight_Leave(sender As Object, e As EventArgs) Handles TextBoxWeight.Leave
        If TextBoxWeight.Text = String.Empty Then
            TextBoxWeight.Text = defString
        End If
    End Sub
End Class