Public Class FormChoferes
    Dim chofer As EL.Chofer
    Dim choferService As New BLL.Chofer()
    Dim autoService As New BLL.Vehiculo()
    Dim comisionService As New BLL.Comision()
    Dim turnoService As New BLL.Turno()
    Dim tipoTelefonoService As New BLL.TipoTelefono()

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CleanCheckList()
        ClbTurnos.ClearSelected()
        For index = 0 To ClbTurnos.Items.Count - 1
            ClbTurnos.SetItemChecked(index, False)
        Next
    End Sub

    Public Sub ActualizarLista()
        cbbAutos.DataSource = Nothing
        cbbAutos.DataSource = New BindingSource With {
            .DataSource = autoService.Listar()
        }
        cbbAutos.DisplayMember = "Patente"
        cbbAutos.ValueMember = "Id"

        ClbTurnos.DataSource = New BindingSource With {
            .DataSource = turnoService.Listar()
        }
        ClbTurnos.DisplayMember = "Descripcion"
        ClbTurnos.ValueMember = "Id"

        CbbTiposTelefono.DataSource = New BindingSource With {
            .DataSource = tipoTelefonoService.Listar()
        }
        CbbTiposTelefono.DisplayMember = "Descripcion"
        CbbTiposTelefono.ValueMember = "Id"

        TxtNroDocumento.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtEmail.Clear()
        TxtNumeroTel.Clear()
        TxtCodArea.Text = 11
        TxtCodPais.Text = 54
        TxtCalle.Clear()
        TxtNumero.Clear()
        TxtPiso.Clear()
        TxtDpto.Clear()
        TxtCP.Clear()
        TxtLocalidad.Clear()
        TxtProvincia.Clear()

        dtpFechaVencimientoRegistro.CustomFormat = " "
        dtpFechaVencimientoRegistro.Format = DateTimePickerFormat.Custom
        dtpFechaVencimientoRegistro.MinDate = Now

        dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy"
        dtpFechaNacimiento.Format = DateTimePickerFormat.Custom

        dtpFechaNacimiento.MaxDate = Now.AddYears(-18)

        dgvChoferes.DataSource = Nothing
        dgvChoferes.AutoGenerateColumns = False
        dgvChoferes.Columns.Clear()
        dgvChoferes.DataSource = choferService.Listar()

        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                .DataPropertyName = "Id",
                .Name = "Id"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Apellido",
                    .Name = "Apellido"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Nombre",
                    .Name = "Nombre"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "NroDocumento",
                    .Name = "Nro. Documento"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Auto",
                    .Name = "Auto"
        })
        chofer = Nothing
        CleanCheckList()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If chofer Is Nothing Then
            chofer = New EL.Chofer()
        End If
        chofer.Nombre = TxtNombre.Text()
        chofer.Apellido = TxtApellido.Text()
        chofer.Domicilio = New EL.Domicilio() With {
            .Calle = TxtCalle.Text(),
            .Nro = TxtNumero.Text(),
            .Localidad = TxtLocalidad.Text(),
            .Provincia = TxtProvincia.Text(),
            .CP = TxtCP.Text()
            }
        If TxtPiso.Text() <> "" Then
            chofer.Domicilio.Piso = TxtPiso.Text()
        End If
        If TxtDpto.Text() <> "" Then
            chofer.Domicilio.Dpto = TxtDpto.Text()
        End If
        chofer.Telefono = New EL.Telefono() With {
                .Numero = TxtNumeroTel.Text(),
                .CodigoArea = TxtCodArea.Text(),
                .CodigoPais = TxtCodPais.Text()
            }
        chofer.Telefono.TipoTelefono.Id = CbbTiposTelefono.SelectedValue
        chofer.NroDocumento = TxtNroDocumento.Text()
        chofer.Email = TxtEmail.Text()
        chofer.FechaNacimiento = dtpFechaNacimiento.Value()
        chofer.Registro.Categoria = cbbCategorias.SelectedItem
        chofer.Registro.FechaVencimiento = dtpFechaVencimientoRegistro.Value()
        chofer.Auto = autoService.GetById(cbbAutos.SelectedValue)
        chofer.Comision = comisionService.GetDefault()
        chofer.Turnos.Clear()
        For Each itemChecked As Object In ClbTurnos.CheckedItems
            chofer.Turnos.Add(turnoService.GetById(CType(itemChecked, EL.Turno).Id))
        Next
        Try
            choferService.Guardar(chofer)
            MessageBox.Show("Los cambios fueron guardados correctamente.")
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al guardar los cambios. Error: " + ex.Message)
        End Try
        ActualizarLista()
    End Sub

    Private Sub FormChoferes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If chofer IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este chofer?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                choferService.Quitar(chofer)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvChoferes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChoferes.CellClick
        chofer = Nothing
        chofer = New EL.Chofer With {
            .Id = dgvChoferes.Rows(e.RowIndex).Cells(0).Value
        }
        chofer = choferService.GetById(chofer.Id)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If chofer IsNot Nothing Then
            CleanCheckList()
            TxtNombre.Text() = chofer.Nombre
            TxtApellido.Text() = chofer.Apellido
            TxtNroDocumento.Text() = chofer.NroDocumento
            TxtEmail.Text() = chofer.Email
            dtpFechaNacimiento.Value() = chofer.FechaNacimiento
            If chofer.Domicilio IsNot Nothing Then
                TxtCalle.Text = chofer.Domicilio.Calle
                TxtNumero.Text = chofer.Domicilio.Nro
                If chofer.Domicilio.Piso = 0 Then
                    TxtPiso.Clear()
                End If
                TxtDpto.Text = chofer.Domicilio.Dpto
                TxtLocalidad.Text = chofer.Domicilio.Localidad
                TxtCP.Text = chofer.Domicilio.CP
                TxtProvincia.Text = chofer.Domicilio.Provincia
            Else
                TxtCalle.Clear()
                TxtNumero.Clear()
                TxtPiso.Clear()
                TxtDpto.Clear()
                TxtCP.Clear()
                TxtLocalidad.Clear()
                TxtProvincia.Clear()
            End If
            If chofer.Telefono IsNot Nothing Then
                TxtNumeroTel.Text = chofer.Telefono.Numero
                TxtCodArea.Text = chofer.Telefono.CodigoArea
                TxtCodPais.Text = chofer.Telefono.CodigoPais
                CbbTiposTelefono.SelectedValue = chofer.Telefono.TipoTelefono.Id
            Else
                TxtNumeroTel.Clear()
                TxtCodArea.Clear()
                TxtCodPais.Clear()
            End If
            cbbCategorias.SelectedItem = chofer.Registro.Categoria
            dtpFechaVencimientoRegistro.Value = chofer.Registro.FechaVencimiento
            cbbAutos.SelectedValue = chofer.Auto.Id
            Dim index As Int16 = 0
            Dim listIndexs = New List(Of Int16)
            For Each item As Object In ClbTurnos.Items
                For Each turno As EL.Turno In chofer.Turnos
                    If (item.Id = turno.Id) Then
                        listIndexs.Add(index)
                    End If
                Next
                index = index + 1
            Next
            For Each i As Int16 In listIndexs
                ClbTurnos.SetItemChecked(i, True)
            Next
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dtpFechaVencimientoRegistro_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaVencimientoRegistro.ValueChanged
        dtpFechaVencimientoRegistro.CustomFormat = "dd/MM/yyyy"
    End Sub

End Class