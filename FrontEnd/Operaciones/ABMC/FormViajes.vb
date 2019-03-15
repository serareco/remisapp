Public Class FormViajes
    Dim viaje As EL.Viaje
    Dim viajeService As New BLL.Viaje()
    Dim estadoViajeService As New BLL.EstadoViaje()
    Dim socioService As New BLL.Socio()
    Dim beneficioService As New BLL.Beneficio()

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
            .DataSource = socioService.Listar()
        }
        cbbCliente.DisplayMember = "Nombre"
        cbbCliente.ValueMember = "Id"

        txtOrigen.Clear()
        txtDestino.Clear()

        dgvViajes.DataSource = Nothing
        dgvViajes.DataSource = viajeService.ListarVigentes()
        viaje = Nothing
        BtnCancelarViaje.Enabled = False
    End Sub

    Private Sub FormViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        viaje = New EL.Viaje()
        viaje.Origen = txtOrigen.Text()
        viaje.Destino = txtDestino.Text()
        If ChbSalidaInmediata.Checked Then
            viaje.FechaSalidaEstimada = Now
            viaje.Estado = estadoViajeService.GetById(3)
        Else
            viaje.FechaSalidaEstimada = dtpFechaSalida.Value
            viaje.Estado = estadoViajeService.GetById(2)
        End If
        viaje.IdaYVuelta = ChbIdayVuelta.Checked
        viaje.Socio = socioService.GetById(cbbCliente.SelectedValue)
        FormConfirmarViaje.viaje = viaje
        FormConfirmarViaje.Show()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub dgvViajes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViajes.CellClick
        If e.RowIndex >= 0 Then
            viaje = Nothing
            viaje = New EL.Viaje With {
                    .Id = dgvViajes.Rows(e.RowIndex).Cells(0).Value
                }
            viaje = viajeService.GetById(viaje.Id)
            If viaje.Estado.Id <> 4 And viaje.Estado.Id <> 5 Then
                BtnCancelarViaje.Enabled = True
                LblAvisoViaje.Text = ""
            Else
                BtnCancelarViaje.Enabled = False
                LblAvisoViaje.Text = "Viaje finalizado. No se puede cancelar."
            End If
        End If
    End Sub
    Private Sub ChbSalidaInmediata_CheckedChanged(sender As Object, e As EventArgs) Handles ChbSalidaInmediata.CheckedChanged
        dtpFechaSalida.Enabled = Not ChbSalidaInmediata.Checked
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
    Private Sub BtnCancelarViaje_Click(sender As Object, e As EventArgs) Handles BtnCancelarViaje.Click
        If viaje IsNot Nothing Then
            FormCancelarViaje.viaje = viaje
            FormCancelarViaje.formOrigen = Me
            FormCancelarViaje.Show()
        End If
    End Sub
End Class