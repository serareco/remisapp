Public Class FormUsuarios
    Dim usuario As EL.Usuario
    Dim datosUsuario As New BLL.Usuario()
    Dim datosRol As New BLL.Rol()

    Private Sub CleanCheckList()
        ClbRoles.ClearSelected()
        For index = 0 To ClbRoles.Items.Count - 1
            ClbRoles.SetItemChecked(index, False)
        Next
    End Sub

    Private Sub ActualizarLista()
        TxtPassword.Visible = True
        TxtRepetirPassword.Visible = True
        TxtUsuario.Text = ""
        TxtPassword.Text = ""
        TxtRepetirPassword.Text = ""
        'dtpFechaNacimiento.Value()
        TxtNroDocumento.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtDomicilio.Text = ""
        TxtEmail.Text = ""
        TxtTelefono.Text = ""
        ClbRoles.DataSource = datosRol.Listar()
        ClbRoles.DisplayMember = "descripcion"
        ClbRoles.ValueMember = "id_rol"
        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = datosUsuario.MostrarLista()
        usuario = Nothing
        CleanCheckList()
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
            CleanCheckList()
            ClbRoles.ClearSelected()
            TxtNombre.Text = usuario.Nombre
            TxtApellido.Text = usuario.Apellido
            TxtDomicilio.Text = usuario.Domicilio
            TxtNroDocumento.Text = usuario.NroDocumento
            TxtTelefono.Text = usuario.Telefono
            TxtEmail.Text = usuario.Email
            dtpFechaNacimiento.Value = usuario.FechaNacimiento
            Dim index As Int16 = 0
            Dim listIndexs = New List(Of Int16)
            For Each item As Object In ClbRoles.Items
                For Each rol As EL.Rol In usuario.Roles
                    If (item.Row.ItemArray(0) = rol.Id) Then
                        listIndexs.Add(index)
                    End If
                Next
                index = index + 1
            Next

            For Each i As Int16 In listIndexs
                ClbRoles.SetItemChecked(i, True)
            Next

            'Dim i As Integer = 0
            'Dim j As Integer = 0
            'For Each rol As EL.Rol In usuario.Roles
            ' 'MessageBox.Show(rol.Descripcion)
            ' i += 1
            'j = 0
            'For Each item As Object In ClbRoles.Items
            'j += 1
            'If (item.Row.ItemArray(0) = rol.Id) Then
            'ClbRoles.SetItemChecked(j, True)
            'End If
            '   Next
            '  Next

            TxtUsuario.Text = usuario.Usuario
            TxtPassword.Visible = False
            TxtRepetirPassword.Visible = False
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