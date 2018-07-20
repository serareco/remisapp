Imports BackEnd
Public Class FrmLogin
    Private Sub Ingresar()
        '
        'PARA LAS PRUEBAS:
        'Usuario: serareco
        'Contraseña: test123
        '
        Login.Usuario = TxtUsuario.Text()
        Login.Password = TxtPassword.Text()

        If (Login.Login) Then
            LblMsjValidacion.Text() = ""
            FormPrincipal.Show()
            Me.Close()
        Else
            LblMsjValidacion.Text() = "Usuario/Password incorrecto."
            TxtUsuario.Text() = ""
            TxtPassword.Text() = ""
        End If
    End Sub
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Ingresar()
    End Sub

    Private Sub TxtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyUp
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Ingresar()
        End If
    End Sub

    Private Sub TxtUsuario_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyUp
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Ingresar()
        End If
    End Sub
End Class
