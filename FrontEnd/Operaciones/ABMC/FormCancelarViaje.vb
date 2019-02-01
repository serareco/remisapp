Public Class FormCancelarViaje
    Public viaje As EL.Viaje
    Dim datosViaje As New BLL.Viaje()
    Private Sub FormCancelarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConfirmarCancelar_Click(sender As Object, e As EventArgs) Handles BtnConfirmarCancelar.Click
        viaje.Comentarios = TxtComentarios.Text
        viaje.Estado.Id = 4
        datosViaje.Guardar(viaje)
        MessageBox.Show("Los datos se modificaron correctamente")
        FormViajes.ActualizarLista()
        Me.Close()
    End Sub
End Class