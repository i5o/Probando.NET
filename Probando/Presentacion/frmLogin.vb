Public Class frmLogin

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Usuario.Login(Me)
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        ' Crea a frmRegistro y lo muestra
        Me.Hide()
        Dim registro As frmRegistro = New frmRegistro()
        Limpiar()
        AddHandler registro.FormClosed, AddressOf Me.Show
        registro.ShowDialog(Me)
    End Sub

    Sub Limpiar()
        Me.txtContrasenia.Clear()
        Me.txtUsuario.Clear()
    End Sub
End Class
