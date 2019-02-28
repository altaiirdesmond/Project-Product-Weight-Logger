Imports System.IO.Ports

Public Class MicroController

    Public Property SerialPort() As SerialPort
    Private Shared _data As String

    ' Access this for serial data capture
    Public ReadOnly Property Data() As String
        Get
            Return SerialPort.ReadLine()
        End Get
    End Property

    Public ReadOnly Property IsOpen() As Boolean
        Get
            Return SerialPort.IsOpen
        End Get
    End Property

    Public Property Port() As String

#Region "Singleton"
    ' This is a singleton pattern
    ' to avoid multiple instance of this class

    Public Shared ReadOnly Property Instance As MicroController
        Get
            Static INST As MicroController = New MicroController
            Return INST
        End Get
    End Property


    Public Sub New()
        SerialPort = New SerialPort()
    End Sub
#End Region

    Public Sub InitializePort()
        If Not SerialPort.IsOpen Then
            SerialPort.PortName = Port
            SerialPort.BaudRate = 9600
            SerialPort.Open()
        End If
    End Sub

    Public Sub ClosePort()
        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If
    End Sub

    Public Function GetPort() As String()
        Return SerialPort.GetPortNames()
    End Function
End Class


