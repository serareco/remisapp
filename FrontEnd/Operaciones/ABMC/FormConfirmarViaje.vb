Public Class FormConfirmarViaje
    Public viaje As EL.Viaje
    Dim choferService As New BLL.Chofer()
    Dim viajeService As New BLL.Viaje()
    Dim beneficioService As New BLL.Beneficio()

    Private Sub FormConfirmarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viajeService.ConsultarAPI(viaje)
        viajeService.SetBeneficios(viaje)
        Dim valorDescuento As Decimal = viaje.PrecioEstimado * viajeService.PorcDescBeneficios(viaje)
        viaje.PrecioEstimado = viaje.PrecioEstimado - valorDescuento
        LblAvisoDemora.Text = ""
        Dim listaChoferesDisponible As New List(Of EL.Chofer)()
        listaChoferesDisponible = choferService.ListarDisponibles(viaje.FechaSalidaEstimada)
        If listaChoferesDisponible.Count > 0 Then
            cbbChofer.DataSource = Nothing
            cbbChofer.DataSource = listaChoferesDisponible
            cbbChofer.DisplayMember = "Nombre"
            cbbChofer.ValueMember = "Id"
            LblAvisoDemora.Text = "El chofer: '" + listaChoferesDisponible(0).Apellido + ", " + listaChoferesDisponible(0).Nombre + "'es el que tiene mejor puntaje."
        Else
            LblAvisoDemora.Text = "No hay choferes disponibles. Próximo en volver en " + " minutos."
        End If
        TxtOrigen.Text = viaje.Origen
        TxtDestino.Text = viaje.Destino
        TxtHoraSalida.Text = viaje.FechaSalidaEstimada.ToShortDateString + " " + viaje.FechaSalidaEstimada.ToShortTimeString
        TxtKilometrosRecorrer.Text = viaje.KmEstimados
        TxtValor.Text = viaje.PrecioEstimado

        viaje.Beneficios = beneficioService.Verificar(viaje.Socio.Id)

        If valorDescuento > 0 Then
            LblBeneficios.Text = "El usuario tiene beneficios! Si confirma, está ahorrando " + valorDescuento.ToString()
        End If

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        viaje.ChoferEstimado = choferService.GetById(cbbChofer.SelectedValue)
        viaje.FechaArriboEstimado = viaje.FechaSalidaEstimada.AddMinutes(viaje.DuracionEstimada)
        viajeService.Guardar(viaje)
        MessageBox.Show("El nuevo viaje fue cargado correctamente.")
        FormViajes.ActualizarLista()
        Me.Close()
    End Sub
End Class