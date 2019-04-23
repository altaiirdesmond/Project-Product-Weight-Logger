Imports System.IO.Ports
Imports ProjectOyster.Forms
Imports ProjectOyster.Helpers
Imports ProjectOyster.Models

Namespace UserControls
    Public Class Extraction
        Inherits UserControl

        Private Delegate Sub NotifyDelegate()   ' References the method
        Private _notify As NotifyDelegate       ' Responsible for invoking the referenced method
        Private _isExtracting As Boolean
        Private Shared _instance As Extraction
        Private _savedDatas as List(Of Oyster)

        Public Shared Property MicroController As MicroController
        Public Shared Property Weight As String
        Public Shared Property User As String

        ' Singleton
        Public Shared ReadOnly Property Instance as Extraction
            Get
                If _instance Is Nothing
                    _instance = New Extraction()
                End If

                Return _instance
            End Get
        End Property

        Private Sub Extraction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _savedDatas = New List(Of Oyster)

            MicroController.InitializePort()

            ' Listen for events
            AddHandler MicroController.SerialPort.DataReceived, AddressOf DataRecievedHandler

            CheckExtractStatus.Start()

            ' Start extraction upon load
            Extract()
        End Sub

        Private Sub ButtonStopDetach_Click(sender As Object, e As EventArgs) Handles ButtonStopDetach.Click
            If _isExtracting <> True Then
                Return
            End If

            ButtonContinue.Visible = True

            MicroController.WriteToPort("stop detach")

            _isExtracting = False

            Invoke(Sub() TextBoxCurrentStatus.Text = "Detaching stopped")
            Invoke(Sub() LabelCurrentWeight.Text = "0g")
        End Sub

        Private Sub ButtonForceStop_Click(sender As Object, e As EventArgs) Handles ButtonForceStop.Click
            If _isExtracting <> True Then
                Return
            End If

            ButtonContinue.Visible = True

            MicroController.WriteToPort("relay off")

            _isExtracting = False

            Invoke(Sub() TextBoxCurrentStatus.Text = "Force stopped")
            Invoke(Sub() LabelCurrentWeight.Text = "0g")
        End Sub

        Public Sub DataRecievedHandler(sender As Object, e As SerialDataReceivedEventArgs)
            _notify = New NotifyDelegate(AddressOf Listener)
            
            HandleData()
        End Sub

        Public Sub Listener()
            ButtonContinue.Visible = True
        End Sub

        Private Sub Extract()
            ' Will not continue unless fields are properly filled
            If Weight = String.Empty Or User = String.Empty Then
                MessageBox.Show("Invalid input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return
            End If

            For Each c In Weight.ToCharArray()
                If c = "." Then
                    Continue For
                End If

                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Invalid input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            Next

            MicroController.WriteToPort("extract_" + Weight)

            Invoke(Sub() TextBoxCurrentStatus.Text = "Extracting")
            Invoke(Sub() LabelCurrentWeight.Text = "0g")

            _isExtracting = True
        End Sub

        ' This will parse the data from serial port while extracting
        Private Sub HandleData()
            Dim data = MicroController.SerialPort.ReadLine()

            If data.Contains("extracting:") Then

                Dim currentWeight = Convert.ToDouble(data.Substring(11))

                Invoke(Sub() LabelCurrentWeight.Text = currentWeight.ToString() + "g")

                If currentWeight < Convert.ToDouble(Weight) Then
                    Return
                End If
                
                Dim oysterData As New Oyster
                With oysterData
                    .Time = Date.Now
                    .Weight = Weight
                    .User = User
                End With

                ' Save to database
                SqliteDataAccess.AddOyster(oysterData)

                Invoke(Sub() TextBoxCurrentStatus.Text = "Idle")
                Invoke(Sub() LabelCurrentWeight.Text = "0g")

                ' Invoke notify which has the address of Listener method
                Invoke(_notify)
            ElseIf data.Contains("Resetting...OK") Then
                _isExtracting = False
            End If
        End Sub

        Private Sub CheckExtractStatus_Tick(sender As Object, e As EventArgs) Handles CheckExtractStatus.Tick
            ' Control button behaviours
            If _isExtracting <> True Then
                ButtonStopDetach.Enabled = False
                ButtonForceStop.Enabled = True

                ButtonDone.Enabled = True
                ButtonContinue.Visible = True
            Else
                ButtonStopDetach.Enabled = True
                ButtonForceStop.Enabled = True

                ButtonDone.Enabled = False
                ButtonContinue.Visible = False
            End If
        End Sub

        Private Sub ButtonDone_Click(sender As Object, e As EventArgs) Handles ButtonDone.Click
            For Each oysterData In _savedDatas
                SqliteDataAccess.AddOyster(oysterData)
            Next

            MsgBox("Saved to database", MessageBoxButtons.OK, "Saved")

            MicroController.WriteToPort("relay off")

            MicroController.ClosePort()
            UserInput.ShellForm.Close()
        End Sub

        Private Sub ButtonContinue_Click(sender As Object, e As EventArgs) Handles ButtonContinue.Click
            Extract()
        End Sub
    End Class
End Namespace