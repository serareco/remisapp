Public Class FormConfirmarViaje
    Public viaje As EL.Viaje
    Dim datosViaje As New BLL.Viaje()
    Private Sub FormConfirmarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datosViaje.ConsultarAPI(viaje)
        TxtOrigen.Text = viaje.Origen
        TxtDestino.Text = viaje.Destino
        TxtHoraSalida.Text = viaje.FechaSalida.ToShortDateString + " " + viaje.FechaSalida.ToShortTimeString
        TxtKilometrosRecorrer.Text = viaje.KmARecorrer
        TxtValor.Text = viaje.PrecioEstimado
        TxtChofer.Text = viaje.ChoferAsignado.Apellido + ", " + viaje.ChoferAsignado.Nombre
        TxtVehiculo.Text = viaje.ChoferAsignado.Auto.Modelo.Marca.Descripcion + " - " + viaje.ChoferAsignado.Auto.Modelo.Descripcion
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class