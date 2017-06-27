Imports MySql.Data.MySqlClient

Public Class PersistenciaUsuario

    Public Shared Function Login(Usuario As String, Contraseña As String) As Boolean
        ' Crea una conexion
        ' Ejecuta una sentencia
        ' Y devuelve verdadero/falso en caso de que los datos sean correctos/falsos
        Dim logueado As Boolean = False
        Dim conexion As New Conexion()

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = "SELECT * FROM `Usuario` WHERE NombreUsuario=@Ci AND Contrasenia=@Contrasenia;"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@Ci", Usuario)
                .Parameters.AddWithValue("@Contrasenia", Contraseña)
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                logueado = True
            End While
            reader.Close()
        End Using

        conexion.Close()
        Return logueado
    End Function

    Public Shared Function Add(Usuario As String, Contraseña As String) As String
        Dim mensaje = "Su usuario ha sido creado correctamente. Ya puede loguearse"
        Dim conexion As New Conexion()
        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = "INSERT INTO `Usuario` VALUES (@NombreUsuario, @Contrasenia, NULL, NULL);"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@NombreUsuario", Usuario)
                .Parameters.AddWithValue("@Contrasenia", Contraseña)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
                conexion.Close()
                mensaje = "Error al crear el usuario"
            End Try
            conexion.Close()
        End Using

        Return mensaje
    End Function
End Class
