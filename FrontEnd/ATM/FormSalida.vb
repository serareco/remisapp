Public Class FormSalida
    Public viaje As EL.Viaje
    Dim choferService As New BLL.Chofer()
    Dim viajeService As New BLL.Viaje()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim chofer As EL.Chofer = choferService.GetById(BLL.Login.UsuarioConectado.Id)
        choferService.TomarViaje(viaje, chofer)
        MessageBox.Show("Se ha registrado la salida del vehículo.")
        FormATM.ActualizarInformacion()
        Me.Close()
    End Sub

    Private Sub FormSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtKilometrosRecorridos.Text = viaje.KmEstimados
        TxtPrecio.Text = viaje.PrecioEstimado
        TxtKilometrosRecorridos.Enabled = False
        TxtPrecio.Enabled = False
    End Sub
End Class