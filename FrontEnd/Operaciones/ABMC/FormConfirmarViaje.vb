Public Class FormConfirmarViaje
    Public viaje As EL.Viaje
    Dim datosChofer As New BLL.Chofer()
    Dim datosViaje As New BLL.Viaje()
    Private Sub FormConfirmarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datosViaje.ConsultarAPI(viaje)
        datosViaje.SetBeneficios(viaje)
        viaje.PrecioEstimado = viaje.PrecioEstimado - viaje.PrecioEstimado * datosViaje.PorcDescBeneficios(viaje)
        LblAvisoDemora.Text = ""
        Dim listaChoferesDisponible As New List(Of EL.Chofer)()
        listaChoferesDisponible = datosChofer.ListarDisponibles(viaje.FechaSalidaEstimada)
        If listaChoferesDisponible.Count > 0 Then
            cbbChofer.DataSource = Nothing
            cbbChofer.DataSource = listaChoferesDisponible
            cbbChofer.DisplayMember = "Nombre"
            cbbChofer.ValueMember = "Id"
        Else
            LblAvisoDemora.Text = "No hay choferes disponibles. Próximo en volver en " + " minutos."
        End If
        TxtOrigen.Text = viaje.Origen
        TxtDestino.Text = viaje.Destino
        TxtHoraSalida.Text = viaje.FechaSalidaEstimada.ToShortDateString + " " + viaje.FechaSalidaEstimada.ToShortTimeString
        TxtKilometrosRecorrer.Text = viaje.KmEstimados
        TxtValor.Text = viaje.PrecioEstimado
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        viaje.ChoferEstimado = datosChofer.GetById(cbbChofer.SelectedValue)
        viaje.FechaArriboEstimado = viaje.FechaSalidaEstimada.AddMinutes(viaje.DuracionEstimada)
        datosViaje.Guardar(viaje)
        MessageBox.Show("El nuevo viaje fue cargado correctamente.")
        FormViajes.ActualizarLista()
        Me.Close()
    End Sub
End Class