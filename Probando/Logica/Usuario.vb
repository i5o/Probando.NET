Imports MySql.Data.MySqlClient

Public Class Usuario
    Public Shared Sub Login(frm As frmLogin)
        ' Se encarga de comprobar los datos ingresados del usuario, con los de la DB

        Dim continuar As Boolean = PersistenciaUsuario.Login(frm.txtUsuario.Text, frm.txtContrasenia.Text)
        If Not continuar Then
            MsgBox("Datos incorrectos", MsgBoxStyle.Information)
            Return
        End If

        Dim ventana As New frmPrograma()
        frm.Limpiar()
        frm.Hide()
        AddHandler ventana.FormClosed, AddressOf frm.Show
        ventana.Show()
    End Sub

    Public Shared Sub Registro(frm As frmRegistro)
        ' Se encarga de registrar al usuario en DB

        Dim mensaje As String = PersistenciaUsuario.Add(frm.txtUsuario.Text, frm.txtContrasenia.Text)
        MsgBox(mensaje, MsgBoxStyle.Information)
    End Sub
End Class