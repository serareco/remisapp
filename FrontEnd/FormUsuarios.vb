Imports BackEnd
Public Class FormUsuarios
    Public Sub ActualizarLista()
        TxtUsuario.Text() = ""
        TxtPassword.Text() = ""
        TxtRepetirPassword.Text() = ""
        'dtpFechaNacimiento.Value()
        TxtNroDocumento.Text() = ""
        TxtNombre.Text() = ""
        TxtApellido.Text() = ""
        TxtDomicilio.Text() = ""
        TxtEmail.Text() = ""
        TxtTelefono.Text() = ""
        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = New Usuario().MostrarLista()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim usuario As New Usuario()
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (Not (Validacion.FormatoEmail(TxtEmail.Text()))) Then
            msjValidaciones += "Formato de e-mail incorrecto" + vbLf
            erroresValidaciones = True
        End If
        If (Not (Validacion.FormatoNumeros(TxtNroDocumento.Text()))) Then
            msjValidaciones += "El Nro. Documento solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If (Not (Validacion.FormatoNumeros(TxtTelefono.Text()))) Then
            msjValidaciones += "El Nro. Teléfono solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            usuario.Usuario = TxtUsuario.Text()
            usuario.Password = TxtPassword.Text()
            usuario.FechaNacimiento = dtpFechaNacimiento.Value()
            usuario.NroDocumento = TxtNroDocumento.Text()
            usuario.Nombre = TxtNombre.Text()
            usuario.Apellido = TxtApellido.Text()
            usuario.Domicilio = TxtDomicilio.Text()
            usuario.Email = TxtEmail.Text()
            usuario.Telefono = TxtTelefono.Text()
            usuario.Guardar()
            ActualizarLista()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub
End Class