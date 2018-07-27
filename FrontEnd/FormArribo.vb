Public Class FormArribo
    Public viaje As EL.Viaje
    Dim datosViaje As New BLL.Viaje()
    Dim datosEstadoViaje As New BLL.EstadoViaje()

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (Not (BLL.Validacion.FormatoNumeros(TxtKilometrosRecorridos.Text()))) Then
            msjValidaciones += "Los Kilómetros solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(TxtPrecio.Text()))) Then
            msjValidaciones += "El Precio solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            viaje.KmRecorridos = TxtKilometrosRecorridos.Text()
            viaje.Precio = TxtPrecio.Text()
            viaje.Comentarios = TxtComentarios.Text()
            viaje.FechaArribo = dtpFechaArribo.Value()
            viaje.Estado = datosEstadoViaje.GetById(cbbTipoEstadoViaje.SelectedValue)
            datosViaje.Guardar(viaje)
            MessageBox.Show("Datos guardado correctamente", "Viajes")
            FormViajes.ActualizarLista()
            Me.Close()
        End If

    End Sub

    Private Sub FormArribo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbTipoEstadoViaje.DataSource = Nothing
        cbbTipoEstadoViaje.DataSource = datosEstadoViaje.MostrarFin()
        cbbTipoEstadoViaje.DisplayMember = "descripcion"
        cbbTipoEstadoViaje.ValueMember = "id_estado"
    End Sub

End Class