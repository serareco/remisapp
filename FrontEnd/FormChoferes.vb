Public Class FormChoferes
    Dim chofer As EL.Chofer
    Dim datosChofer As New BLL.Chofer()
    Dim datosAuto As New BLL.Auto()
    Dim datosComision As New BLL.Comision()

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Public Sub ActualizarLista()
        cbbComision.DataSource = datosComision.MostrarVigentes()
        cbbComision.DisplayMember = "descripcion"
        cbbComision.ValueMember = "id_comision"

        cbbAutos.DataSource = datosAuto.MostrarDisponibles()
        cbbAutos.DisplayMember = "descripcion"
        cbbAutos.ValueMember = "id_auto"
        TxtNombre.Text() = ""
        TxtApellido.Text() = ""
        TxtDomicilio.Text() = ""
        TxtNroDocumento.Text() = ""
        TxtEmail.Text() = ""
        'dtpFechaNacimiento.Value() = DateAndTime.Now()
        'dtpFechaVencimientoRegistro.Value() = DateAndTime.Now()
        TxtTelefono.Text() = ""
        dgvChoferes.DataSource = Nothing
        dgvChoferes.DataSource = datosChofer.Mostrar()
        chofer = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If chofer Is Nothing Then
            chofer = New EL.Chofer()
        End If
        chofer.Nombre = TxtNombre.Text()
        chofer.Apellido = TxtApellido.Text()
        chofer.Domicilio = TxtDomicilio.Text()
        chofer.NroDocumento = TxtNroDocumento.Text()
        chofer.Email = TxtEmail.Text()
        chofer.FechaNacimiento = dtpFechaNacimiento.Value()
        chofer.FechaVencimiento = dtpFechaVencimientoRegistro.Value()
        chofer.Telefono = TxtTelefono.Text()
        chofer.Auto = datosAuto.GetById(cbbAutos.SelectedValue)
        chofer.Comision = datosComision.GetById(cbbComision.SelectedValue)
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
            TxtDomicilio.Text() = chofer.Domicilio
            TxtNroDocumento.Text() = chofer.NroDocumento
            TxtEmail.Text() = chofer.Email
            dtpFechaNacimiento.Value() = chofer.FechaNacimiento
            dtpFechaVencimientoRegistro.Value() = chofer.FechaVencimiento
            TxtTelefono.Text() = chofer.Telefono
            cbbAutos.SelectedValue() = chofer.Auto.Id
            cbbComision.SelectedValue() = chofer.Comision.Id
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
End Class