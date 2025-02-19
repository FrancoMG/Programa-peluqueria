Imports System.Data.Odbc
Imports System.Security.Cryptography

Module Module1
    Public conexion As OdbcConnection
    Public rs As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public cmd As OdbcCommand
    Public switch As Integer = 1
    Public sql As String
    Public Clienta As String


    Public Sub ejecutar(ByVal consulta As String)

        cmd = New OdbcCommand(consulta, conexion)
        cmd.CommandType = CommandType.Text

        If Switch = 1 Then
            rs = cmd.ExecuteReader

        ElseIf Switch = 2 Then
            rs2 = cmd.ExecuteReader

        End If

        cmd.Dispose()

    End Sub

End Module
