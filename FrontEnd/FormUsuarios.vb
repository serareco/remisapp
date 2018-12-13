Public Class FormUsuarios
    Dim usuario As EL.Usuario
    Dim datosUsuario As New BLL.Usuario()
    Dim datosPermiso As New BLL.Permiso()

    Private Sub CleanCheckList()
        ClbRoles.ClearSelected()
        For index = 0 To ClbRoles.Items.Count - 1
            ClbRoles.SetItemChecked(index, False)
        Next
    End Sub

    Private Sub ActualizarLista()
        dtpFechaNacimiento.CustomFormat = " "
        dtpFechaNacimiento.Format = DateTimePickerFormat.Custom

        TxtUsuario.Clear()
        TxtNroDocumento.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        'TxtDomicilio.Clear()
        TxtEmail.Clear()
        TxtTelefono.Clear()

        ClbRoles.DataSource = New BindingSource With {
            .DataSource = datosPermiso.Listar()
        }
        ClbRoles.DisplayMember = "Descripcion"
        ClbRoles.ValueMember = "Id"

        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = New BindingSource With {
            .DataSource = datosUsuario.Listar()
        }
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
            usuario.Usuario = TxtNroDocumento.Text()
            usuario.Password = TxtNroDocumento.Text()
            usuario.FechaNacimiento = dtpFechaNacimiento.Value()
            usuario.NroDocumento = TxtNroDocumento.Text()
            usuario.Nombre = TxtNombre.Text()
            usuario.Apellido = TxtApellido.Text()
            usuario.Domicilio = New EL.Domicilio() With {
                .Calle = TxtCalle.Text(),
                .Nro = TxtNumero.Text(),
                .Dpto = TxtDpto.Text(),
                .Piso = TxtPiso.Text(),
                .Localidad = TxtLocalidad.Text(),
                .Provincia = TxtProvincia.Text(),
                .CP = TxtCP.Text()
            }
            usuario.Email = TxtEmail.Text()
            usuario.Telefono = TxtTelefono.Text()
            usuario.Permisos = New List(Of EL.Permiso)
            For Each itemChecked As Object In ClbRoles.CheckedItems
                Dim permiso As New EL.Permiso With {
                .Id = CType(itemChecked, EL.Permiso).Id,
                .Descripcion = CType(itemChecked, EL.Permiso).Descripcion
                }
                usuario.Permisos.Add(permiso)
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

            If usuario.Domicilio IsNot Nothing Then
                TxtCalle.Text = usuario.Domicilio.Calle
                TxtNumero.Text = usuario.Domicilio.Nro
                TxtPiso.Text = usuario.Domicilio.Piso
                TxtDpto.Text = usuario.Domicilio.Dpto
                TxtLocalidad.Text = usuario.Domicilio.Localidad
                TxtCP.Text = usuario.Domicilio.CP
                TxtProvincia.Text = usuario.Domicilio.Provincia
            End If

            TxtNombre.Text = usuario.Nombre
            TxtApellido.Text = usuario.Apellido
            TxtNroDocumento.Text = usuario.NroDocumento
            TxtTelefono.Text = usuario.Telefono
            TxtEmail.Text = usuario.Email
            dtpFechaNacimiento.Value = usuario.FechaNacimiento
            Dim index As Int16 = 0
            Dim listIndexs = New List(Of Int16)
            For Each item As Object In ClbRoles.Items
                For Each permiso As EL.Permiso In usuario.Permisos
                    If (item.Id = permiso.Id) Then
                        listIndexs.Add(index)
                    End If
                Next
                index = index + 1
            Next

            For Each i As Int16 In listIndexs
                ClbRoles.SetItemChecked(i, True)
            Next

            TxtUsuario.Text = usuario.Usuario
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
        usuario = datosUsuario.GetById(dgvUsuarios.Rows(e.RowIndex).Cells(2).Value)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.ValueChanged
        dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub BtnBlanqueoPss_Click(sender As Object, e As EventArgs) Handles BtnBlanqueoPss.Click

    End Sub
End Class