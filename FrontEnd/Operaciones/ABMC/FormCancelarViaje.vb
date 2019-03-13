Public Class FormCancelarViaje
    Public viaje As EL.Viaje
    Public formOrigen As Form
    Dim viajeService As New BLL.Viaje()
    Private Sub FormCancelarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConfirmarCancelar_Click(sender As Object, e As EventArgs) Handles BtnConfirmarCancelar.Click
        viaje.Comentarios = TxtComentarios.Text
        viaje.Estado.Id = 4
        viajeService.Guardar(viaje)
        MessageBox.Show("Los datos se modificaron correctamente")
        If formOrigen.GetType = FormViajes.GetType Then
            FormViajes.ActualizarLista()
        End If
        Me.Close()
    End Sub
End Class