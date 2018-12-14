Public Class FormChoferes
    Dim chofer As EL.Chofer
    Dim datosChofer As New BLL.Chofer()
    Dim datosAuto As New BLL.Vehiculo()
    Dim datosComision As New BLL.Comision()

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

        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtNroDocumento.Clear()
        TxtEmail.Clear()
        TxtTelefono.Clear()

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
        dgvChoferes.DataSource = New BindingSource With {
            .DataSource = datosChofer.Listar()
        }
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

        chofer.NroDocumento = TxtNroDocumento.Text()
        chofer.Email = TxtEmail.Text()
        chofer.FechaNacimiento = dtpFechaNacimiento.Value()
        chofer.Registro = New EL.Registro() With {
        .Categoria = cbbCategorias.SelectedItem,
        .FechaVencimiento = dtpFechaVencimientoRegistro.Value()
        }
        chofer.Telefono = TxtTelefono.Text()
        chofer.Auto = datosAuto.GetById(cbbAutos.SelectedValue)
        chofer.Comision = datosComision.GetDefault()
        datosChofer.Guardar(chofer)
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
            TxtCalle.Text() = chofer.Domicilio.Calle
            TxtLocalidad.Text() = chofer.Domicilio.Localidad
            TxtNumero.Text() = chofer.Domicilio.Nro
            TxtPiso.Text() = chofer.Domicilio.Piso
            TxtProvincia.Text() = chofer.Domicilio.Provincia
            TxtCP.Text() = chofer.Domicilio.CP
            TxtNroDocumento.Text() = chofer.NroDocumento
            TxtEmail.Text() = chofer.Email
            dtpFechaNacimiento.Value() = chofer.FechaNacimiento
            dtpFechaVencimientoRegistro.Value() = chofer.Registro.FechaVencimiento
            TxtTelefono.Text() = chofer.Telefono
            cbbAutos.SelectedValue() = chofer.Auto.Id
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dtpFechaVencimientoRegistro_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaVencimientoRegistro.ValueChanged
        dtpFechaVencimientoRegistro.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class