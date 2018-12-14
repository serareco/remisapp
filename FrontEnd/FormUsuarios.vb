Public Class FormUsuarios
    Dim usuario As EL.Usuario
    Dim datosUsuario As New BLL.Usuario()
    Dim datosPermiso As New BLL.Permiso()
    Dim datosTipoTelefono As New BLL.TipoTelefono()

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
        TxtEmail.Clear()
        TxtNumeroTel.Clear()
        TxtCodArea.Clear()
        TxtCodPais.Clear()
        TxtCalle.Clear()
        TxtNumero.Clear()
        TxtPiso.Clear()
        TxtDpto.Clear()
        TxtCP.Clear()
        TxtLocalidad.Clear()
        TxtProvincia.Clear()

        CbbTiposTelefono.DataSource = New BindingSource With {
            .DataSource = datosTipoTelefono.Listar()
        }
        CbbTiposTelefono.DisplayMember = "Descripcion"
        CbbTiposTelefono.ValueMember = "Id"

        ClbRoles.DataSource = New BindingSource With {
            .DataSource = datosPermiso.Listar()
        }
        ClbRoles.DisplayMember = "Descripcion"
        ClbRoles.ValueMember = "Id"

        dgvUsuarios.AutoGenerateColumns = False
        dgvUsuarios.AutoSize = True
        dgvUsuarios.Columns.Clear()
        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = datosUsuario.Listar()
        dgvUsuarios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Id",
                    .Name = "Id"
        })
        dgvUsuarios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Usuario",
                    .Name = "Usuario"
        })
        dgvUsuarios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Apellido",
                    .Name = "Apellido"
        })
        dgvUsuarios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Nombre",
                    .Name = "Nombre"
        })
        dgvUsuarios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "NroDocumento",
                    .Name = "Nro. Documento"
        })
        dgvUsuarios.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Email",
            .Name = "E-Mail"
        })

        usuario = Nothing
        BtnBlanqueoPss.Enabled = False
        CleanCheckList()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""

        If usuario Is Nothing Then
            usuario = New EL.Usuario()
            usuario.Usuario = TxtNroDocumento.Text()
            usuario.Password = TxtNroDocumento.Text()
        End If

        If (Not (BLL.Validacion.FormatoEmail(TxtEmail.Text()))) Then
            msjValidaciones += "Formato de e-mail incorrecto" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(TxtNroDocumento.Text()))) Then
            msjValidaciones += "El Nro. Documento solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(TxtNumeroTel.Text()))) Then
            msjValidaciones += "El Nro. Teléfono solo admite números" + vbLf
            erroresValidaciones = True
        End If

        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            usuario.FechaNacimiento = dtpFechaNacimiento.Value()
            usuario.NroDocumento = TxtNroDocumento.Text()
            usuario.Nombre = TxtNombre.Text()
            usuario.Apellido = TxtApellido.Text()
            usuario.Domicilio = New EL.Domicilio() With {
                .Calle = TxtCalle.Text(),
                .Nro = TxtNumero.Text(),
                .Localidad = TxtLocalidad.Text(),
                .Provincia = TxtProvincia.Text(),
                .CP = TxtCP.Text()
            }
            If TxtDpto.Text <> "" Then
                usuario.Domicilio.Dpto = TxtDpto.Text()
            End If
            If TxtPiso.Text <> "" Then
                usuario.Domicilio.Piso = TxtPiso.Text()
            End If
            usuario.Telefono = New EL.Telefono() With {
                .Numero = TxtNumeroTel.Text(),
                .CodigoArea = TxtCodArea.Text(),
                .CodigoPais = TxtCodPais.Text()
            }
            usuario.Telefono.TipoTelefono.Id = CbbTiposTelefono.SelectedValue
            usuario.Email = TxtEmail.Text()
            usuario.Permisos = New List(Of EL.Permiso)
            For Each itemChecked As Object In ClbRoles.CheckedItems
                Dim permiso As New EL.Permiso With {
                .Id = CType(itemChecked, EL.Permiso).Id,
                .Descripcion = CType(itemChecked, EL.Permiso).Descripcion
                }
                usuario.Permisos.Add(permiso)
            Next
            Try
                datosUsuario.Guardar(usuario)
                MessageBox.Show("Los cambios fueron guardados correctamente.")
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al guardar los cambios. Error: " + ex.Message)
            End Try
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
                If usuario.Domicilio.Piso = 0 Then
                    TxtPiso.Clear()
                End If
                TxtDpto.Text = usuario.Domicilio.Dpto
                TxtLocalidad.Text = usuario.Domicilio.Localidad
                TxtCP.Text = usuario.Domicilio.CP
                TxtProvincia.Text = usuario.Domicilio.Provincia
            Else
                TxtCalle.Clear()
                TxtNumero.Clear()
                TxtPiso.Clear()
                TxtDpto.Clear()
                TxtCP.Clear()
                TxtLocalidad.Clear()
                TxtProvincia.Clear()
            End If
            TxtNombre.Text = usuario.Nombre
            TxtApellido.Text = usuario.Apellido
            TxtNroDocumento.Text = usuario.NroDocumento
            If usuario.Telefono IsNot Nothing Then
                TxtNumeroTel.Text = usuario.Telefono.Numero
                TxtCodArea.Text = usuario.Telefono.CodigoArea
                TxtCodPais.Text = usuario.Telefono.CodigoPais
                CbbTiposTelefono.SelectedValue = usuario.Telefono.TipoTelefono.Id
            Else
                TxtNumeroTel.Clear()
                TxtCodArea.Clear()
                TxtCodPais.Clear()
            End If
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
            BtnBlanqueoPss.Enabled = True
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
        usuario = datosUsuario.GetById(dgvUsuarios.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.ValueChanged
        dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub BtnBlanqueoPss_Click(sender As Object, e As EventArgs) Handles BtnBlanqueoPss.Click
        If usuario IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas blanquear la clave de este usuario?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosUsuario.BlanquearClave(usuario)
                ActualizarLista()
            End If
        End If
    End Sub
End Class