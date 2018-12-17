Public Class FormSalida
    Public viaje As EL.Viaje
    Dim datosChofer As New BLL.Chofer()
    Dim datosViaje As New BLL.Viaje()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        viaje.Chofer = viaje.ChoferEstimado ' datosChofer.GetById(BLL.Login.UsuarioConectado.Id)
        viaje.FechaSalida = Now
        viaje.Estado.Id = 1
        datosViaje.Guardar(viaje)
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