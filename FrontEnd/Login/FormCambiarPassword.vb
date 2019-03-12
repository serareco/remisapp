Public Class FormCambiarPassword
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Not BLL.Validacion.ValoresIguales(TxtConfirmaPassword.Text, TxtPassword.Text) Then
            MessageBox.Show("Las contraseñas son diferentes. Vuelva a intentar.")
        ElseIf BLL.Validacion.ValoresIguales(TxtPassword.Text, BLL.UsuarioConectado.NroDocumento) Then
            MessageBox.Show("La contraseña no puede ser el nro de documento registrado. Vuelva a intentar.")
        Else
            BLL.Login.ActualizarPassword(TxtPassword.Text)
            MessageBox.Show("La contraseña se modificó correctamente.")
            FormPrincipal.Show()
            Me.Close()
        End If

    End Sub
End Class