Public Class FormUsuarios
    Dim usuario As EL.Usuario
    Dim datosUsuario As New BLL.Usuario()
    Dim datosRol As New BLL.Rol()

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
        ClbRoles.DataSource = datosRol.Listar()
        ClbRoles.DisplayMember = "descripcion"
        ClbRoles.ValueMember = "id_rol"
        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = datosUsuario.MostrarLista()
        usuario = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If usuario Is Nothing Then
            usuario = New EL.Usuario()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (Not (BLL.Validacion.FormatoEmail(TxtEmail.Text()))) Then
            msjValidaciones += "Formato de e-mail incorrecto" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(TxtNroDocumento.Text()))) Then
            msjValidaciones += "El Nro. Documento solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(TxtTelefono.Text()))) Then
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
            usuario.Roles = New List(Of EL.Rol)
            For Each itemChecked As Object In ClbRoles.CheckedItems
                Dim rol As New EL.Rol With {
                .Id = CType(itemChecked, DataRowView).Row.ItemArray(0),
                .Descripcion = CType(itemChecked, DataRowView).Row.ItemArray(1)
                }
                usuario.Roles.Add(rol)
            Next
            datosUsuario.Guardar(usuario)
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

            'For Each item As Object In ClbRoles.Items
            '   For Each rol As EL.Rol In usuario.Roles
            '       If (item.Row.ItemArray(0) = rol.Id) Then
            '           ClbRoles.SelectedItem = item
            '       End If
            '   Next
            'Next

            'Dim i As Integer = 0
            'Dim j As Integer = 0
            'For Each rol As EL.Rol In usuario.Roles
            '   i += 1
            '   j = 0
            '   For Each item As Object In ClbRoles.Items
            '       j += 1
            '       If (item.Row.ItemArray(0) = rol.Id) Then
            '           ClbRoles.SetItemChecked(j, True)
            '       End If
            '   Next
            'Next

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If usuario IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este usuario?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosUsuario.Quitar(usuario)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        usuario = Nothing
        usuario = New EL.Usuario With {
            .Usuario = dgvUsuarios.Rows(e.RowIndex).Cells(0).Value
        }
        usuario = datosUsuario.GetByUsuario(usuario.Usuario)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

End Class