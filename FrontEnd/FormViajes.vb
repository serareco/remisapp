Imports BackEnd
Public Class FormViajes
    Private _idClickCell As Int16
    Public Sub ActualizarLista()
        cbbChofer.DataSource = Nothing
        cbbChofer.DataSource = New Chofer().MostrarDisponibles()
        cbbChofer.DisplayMember = "descripcion"
        cbbChofer.ValueMember = "id_chofer"
        cbbTipoEstadoViaje.DataSource = Nothing
        cbbTipoEstadoViaje.DataSource = New EstadoViaje().MostrarAlta()
        cbbTipoEstadoViaje.DisplayMember = "descripcion"
        cbbTipoEstadoViaje.ValueMember = "id_estado"
        cbbCliente.DataSource = Nothing
        cbbCliente.DataSource = New Cliente().Mostrar()
        cbbCliente.DisplayMember = "descripcion"
        cbbCliente.ValueMember = "id_cliente"
        txtOrigen.Text() = ""
        txtDestino.Text() = ""
        dgvViajes.DataSource = Nothing
        dgvViajes.DataSource = New Viaje().MostrarEnCurso()
    End Sub

    Private Sub FormViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim viaje As New Viaje()
        viaje.Origen = txtOrigen.Text()
        viaje.Destino = txtDestino.Text()
        viaje.FechaSalida = dtpFechaSalida.Value
        If cbbIdaYVuelta.SelectedValue = "S" Then
            viaje.IdaYVuelta = True
        Else
            viaje.IdaYVuelta = False
        End If
        viaje.Chofer = New Chofer()
        viaje.Chofer.GetById(cbbChofer.SelectedValue)
        viaje.Cliente = New Cliente
        viaje.Cliente.GetById(cbbCliente.SelectedValue)
        viaje.Estado = New EstadoViaje
        viaje.Estado.GetById(cbbTipoEstadoViaje.SelectedValue)
        viaje.Guardar()
        ActualizarLista()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnNotificarArribo_Click(sender As Object, e As EventArgs) Handles BtnNotificarArribo.Click
        FormArribo.viaje = New Viaje
        FormArribo.viaje.GetById(_idClickCell) 'le paso el id del viaje que sale de la grid.
        FormArribo.Show()
    End Sub

    Private Sub dgvViajes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViajes.CellClick
        _idClickCell = dgvViajes.Rows(e.RowIndex).Cells(0).Value
    End Sub

End Class