Imports System.Data.Odbc
Module Module1
    Public precio As New Integer
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public sql As String
    Public x As Integer
    Public proveedor As String
    Public producto As String
    Public stock As Integer
    Public precioN As Integer
    Public Function conectar()
        Try
            cnn = New OdbcConnection("dsn=chino")
            cnn.Open()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Falla de la conexión con la Base de Datos", , "Sin conexión")
        End Try
        Return 0
    End Function

    Public Sub Proc(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If x = 0 Then
            rs = cmd.ExecuteReader()
            x = 1

        Else

            rs1 = cmd.ExecuteReader()

        End If

        cmd.Dispose()

    End Sub
End Module
