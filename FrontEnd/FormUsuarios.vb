Imports BackEnd
Public Class FormUsuarios
    Private usuario As Usuario
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
        usuario = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If usuario Is Nothing Then
            usuario = New Usuario()
        End If
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If usuario IsNot Nothing Then
            TxtNombre.Text() = usuario.Nombre
            TxtApellido.Text() = usuario.Apellido
            TxtDomicilio.Text() = usuario.Domicilio
            TxtNroDocumento.Text() = usuario.NroDocumento
            TxtTelefono.Text() = usuario.Telefono
            TxtEmail.Text() = usuario.Email
            dtpFechaNacimiento.Value() = usuario.FechaNacimiento
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If usuario IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este usuario?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                usuario.Quitar()
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        usuario = Nothing
        usuario = New Usuario With {
            .Usuario = dgvUsuarios.Rows(e.RowIndex).Cells(0).Value
        }
        usuario.GetByUsuario(usuario.Usuario)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

End Class