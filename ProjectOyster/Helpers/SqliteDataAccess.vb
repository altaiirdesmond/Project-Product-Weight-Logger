Imports System.Data.SQLite
Imports Dapper

Public Class SqliteDataAccess

    Public Shared Sub AddOyster(oyster As Oyster)
        Using cnn As IDbConnection = New SQLiteConnection(LoadConnectionString())
            Try
                cnn.Execute("INSERT INTO Oyster VALUES(@Time, @Weight)", oyster)
                MsgBox("added to database!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Shared Function GetAll() As List(Of Oyster)
        Using cnn As IDbConnection = New SQLiteConnection(LoadConnectionString())
            Return cnn.Query(Of Oyster)("SELECT * FROM Oyster").ToList()
        End Using
    End Function

    Public Shared Function GetUserCount(username As String, password As String) As Integer
        Using cnn As IDbConnection = New SQLiteConnection(LoadConnectionString())
            Return cnn.Query(Of User)("SELECT * FROM User WHERE Username=@username AND Password=@password", New With {
                username,
                password
            }).ToList().Count
        End Using
    End Function

    Public Shared Function IsAdmin(username As String, password As String) As Boolean
        Dim _isAdmin As Boolean = False
        Using cnn As IDbConnection = New SQLiteConnection(LoadConnectionString())
            For Each user In cnn.Query(Of User)("SELECT Admin FROM User WHERE Username=@username AND Password=@password", New With {
                username,
                password
            }).ToList().Take(1)
                If user.Admin = 1 Then
                    _isAdmin = True
                End If
            Next
        End Using

        Return _isAdmin
    End Function

    Private Shared Function LoadConnectionString() As String
        Return Configuration.ConfigurationManager.ConnectionStrings("Default").ConnectionString
    End Function
End Class