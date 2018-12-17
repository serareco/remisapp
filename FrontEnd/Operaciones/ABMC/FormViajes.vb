Public Class FormViajes
    Dim viaje As EL.Viaje
    Dim datosViaje As New BLL.Viaje()
    Dim datosEstadoViaje As New BLL.EstadoViaje()
    Dim datosSocio As New BLL.Socio()
    Dim datosPromocion As New BLL.Beneficio()
    ' Cuando se ingresa a esta opción del menú, el sistema debe sugerir chofer (seleccionar automaticamente, pero sin confirmar)
    ' Tener en cuenta que tiene que estar disponible:
    ' Es decir q no esté con un viaje en curso.
    ' Que pertenezca al turno que corresponde (según el momento de la reserva)
    ' VER LA FORMA DE SUGERIR EL VALOR DEL PRECIO, EL TIEMPO DE DEMORA, ETC.
    Public Sub ActualizarLista()
        dtpFechaSalida.Enabled = Not ChbSalidaInmediata.Checked
        ChbSalidaInmediata.Checked = True
        cbbCliente.DataSource = Nothing
        cbbCliente.DataSource = New BindingSource With {
            .DataSource = datosSocio.Listar()
        }
        cbbCliente.DisplayMember = "Nombre"
        cbbCliente.ValueMember = "Id"

        txtOrigen.Clear()
        txtDestino.Clear()

        dgvViajes.DataSource = Nothing
        dgvViajes.DataSource = datosViaje.Listar()
        viaje = Nothing
        BtnCancelarViaje.Enabled = False
    End Sub

    Private Sub FormViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If viaje Is Nothing Then
            viaje = New EL.Viaje()
        End If
        viaje.Origen = txtOrigen.Text()
        viaje.Destino = txtDestino.Text()
        If ChbSalidaInmediata.Checked Then
            viaje.FechaSalidaEstimada = Now
            viaje.Estado.Id = 3
        Else
            viaje.FechaSalidaEstimada = dtpFechaSalida.Value
            viaje.Estado.Id = 2
        End If
        viaje.IdaYVuelta = ChbIdayVuelta.Checked
        viaje.Socio = datosSocio.GetById(cbbCliente.SelectedValue)
        FormConfirmarViaje.viaje = viaje
        FormConfirmarViaje.Show()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub dgvViajes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViajes.CellClick
        viaje = Nothing
        viaje = New EL.Viaje With {
            .Id = dgvViajes.Rows(e.RowIndex).Cells(0).Value
        }
        viaje = datosViaje.GetById(viaje.Id)
        BtnCancelarViaje.Enabled = True
    End Sub

    Private Sub ChbSalidaInmediata_CheckedChanged(sender As Object, e As EventArgs) Handles ChbSalidaInmediata.CheckedChanged
        dtpFechaSalida.Enabled = Not ChbSalidaInmediata.Checked
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
End Class