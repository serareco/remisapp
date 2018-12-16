Public Class FormChoferes
    Dim chofer As EL.Chofer
    Dim datosChofer As New BLL.Chofer()
    Dim datosAuto As New BLL.Vehiculo()
    Dim datosComision As New BLL.Comision()
    Dim datosTurno As New BLL.Turno()
    Dim datosTipoTelefono As New BLL.TipoTelefono()

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Public Sub ActualizarLista()
        cbbAutos.DataSource = Nothing
        cbbAutos.DataSource = New BindingSource With {
            .DataSource = datosAuto.Listar()
        }
        cbbAutos.DisplayMember = "Patente"
        cbbAutos.ValueMember = "Id"

        CbbTurnos.DataSource = Nothing
        CbbTurnos.DataSource = New BindingSource With {
            .DataSource = datosTurno.Listar()
        }
        CbbTurnos.DisplayMember = "Descripcion"
        CbbTurnos.ValueMember = "Id"

        CbbTiposTelefono.DataSource = New BindingSource With {
            .DataSource = datosTipoTelefono.Listar()
        }
        CbbTiposTelefono.DisplayMember = "Descripcion"
        CbbTiposTelefono.ValueMember = "Id"

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

        dtpFechaVencimientoRegistro.CustomFormat = " "
        dtpFechaVencimientoRegistro.Format = DateTimePickerFormat.Custom

        dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy"
        dtpFechaNacimiento.Format = DateTimePickerFormat.Custom

        dgvChoferes.DataSource = Nothing
        dgvChoferes.AutoGenerateColumns = False
        dgvChoferes.AutoSize = True
        dgvChoferes.Columns.Clear()
        dgvChoferes.DataSource = datosChofer.Listar()

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
        chofer.Auto = datosAuto.GetById(cbbAutos.SelectedValue)
        chofer.Comision = datosComision.GetDefault()
        chofer.Turnos.Add(datosTurno.GetById(CbbTurnos.SelectedValue))

        Try
            datosChofer.Guardar(chofer)
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
                datosChofer.Quitar(chofer)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvChoferes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChoferes.CellClick
        chofer = Nothing
        chofer = New EL.Chofer With {
            .Id = dgvChoferes.Rows(e.RowIndex).Cells(0).Value
        }
        chofer = datosChofer.GetById(chofer.Id)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If chofer IsNot Nothing Then
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
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dtpFechaVencimientoRegistro_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaVencimientoRegistro.ValueChanged
        dtpFechaVencimientoRegistro.CustomFormat = "dd/MM/yyyy"
    End Sub

End Class