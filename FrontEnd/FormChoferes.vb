Imports BackEnd
Public Class FormChoferes
    Private chofer As Chofer

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Public Sub ActualizarLista()
        cbbAutos.DataSource = New Auto().MostrarDisponibles()
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
        dgvChoferes.DataSource = New Chofer().Mostrar()
        chofer = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim chofer As New Chofer()
        If chofer Is Nothing Then
            chofer = New Chofer()
        End If
        chofer.Nombre = TxtNombre.Text()
        chofer.Apellido = TxtApellido.Text()
        chofer.Domicilio = TxtDomicilio.Text()
        chofer.NroDocumento = TxtNroDocumento.Text()
        chofer.Email = TxtEmail.Text()
        chofer.FechaNacimiento = dtpFechaNacimiento.Value()
        chofer.FechaVencimiento = dtpFechaVencimientoRegistro.Value()
        chofer.Telefono = TxtTelefono.Text()
        chofer.Auto = New Auto()
        chofer.Auto.GetById(cbbAutos.SelectedValue)
        chofer.Guardar()
        ActualizarLista()
    End Sub

    Private Sub FormChoferes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbAutos.DataSource = New Auto().MostrarDisponibles()
        cbbAutos.DisplayMember = "descripcion"
        cbbAutos.ValueMember = "id_auto"
        ActualizarLista()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If chofer IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este chofer?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                chofer.Quitar()
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvChoferes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChoferes.CellClick
        chofer = Nothing
        chofer = New Chofer With {
            .Id = dgvChoferes.Rows(e.RowIndex).Cells(0).Value
        }
        chofer.GetById(chofer.Id)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If chofer.Id > 0 Then
            'Dim chofer As Chofer = New Chofer()
            TxtNombre.Text() = chofer.Nombre
            TxtApellido.Text() = chofer.Apellido
            TxtDomicilio.Text() = chofer.Domicilio
            TxtNroDocumento.Text() = chofer.NroDocumento
            TxtEmail.Text() = chofer.Email
            dtpFechaNacimiento.Value() = chofer.FechaNacimiento
            dtpFechaVencimientoRegistro.Value() = chofer.FechaVencimiento
            TxtTelefono.Text() = chofer.Telefono
            cbbAutos.SelectedValue() = chofer.Auto.Id
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
End Class