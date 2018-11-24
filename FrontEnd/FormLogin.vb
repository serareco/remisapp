Public Class FrmLogin
    Private Sub Ingresar()
        Dim datosLogin As New EL.Login()
        '
        'PARA LAS PRUEBAS:
        'Usuario: serareco
        'Contraseña: test123
        '
        datosLogin.Usuario = New EL.Usuario() With {.Usuario = TxtUsuario.Text(), .Password = TxtPassword.Text()}

        If (BLL.Login.Login(datosLogin.Usuario)) Then
            LblMsjValidacion.Text() = ""
            If ChkChangePss.Checked Then
                FormCambiarPassword.Show()
            ElseIf BLL.Login.EsChofer() Then
                ' TODO: Mostrar el menu para el chofer
                FormPrincipalChoferes.Show()
            Else
                FormPrincipal.Show()
            End If
            ' Mostrar menu para personal de oficina
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
