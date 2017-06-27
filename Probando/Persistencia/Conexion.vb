Imports MySql.Data.MySqlClient

Public Class Conexion
    Friend Conn As MySqlConnection
    Dim server, user, passwd, db As String

    Public Sub New()
        Try
            ' En caso de que las fuera a importar desde el registro de Windows:
            ' server = GetSetting("Probando", "BaseDeDatos", "IP").ToString()
            ' user = GetSetting("Probando", "BaseDeDatos", "Usuario").ToString()
            ' passwd = GetSetting("Probando", "BaseDeDatos", "Contraseña").ToString()
            ' db = GetSetting("Probando", "BaseDeDatos", "DB").ToString()

            server = "localhost"
            user = "root"
            passwd = "root"
            db = "Probando"
            Dim servidor_sentencia As String = "server=" & server & ";uid=" & user & ";password=" & passwd & ";database=" & db
            Conn = New MySqlConnection(servidor_sentencia)
            Conn.Open()
        Catch ex As Exception
            ' En caso de que la conexion falle, muestra un error, y el programa falla :D:D
            MsgBox("Error al establecer la conexión con el servidor.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Close()
        ' Cierra la conexión
        Conn.Dispose()
    End Sub
End Class

