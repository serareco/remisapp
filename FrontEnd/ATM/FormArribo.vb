Public Class FormArribo
    Public viaje As EL.Viaje

    Dim viajeService As New BLL.Viaje()
    Dim estadosViajeService As New BLL.EstadoViaje()

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
        If ((BLL.Validacion.DatoObligatorioVacio(cbbTipoEstadoViaje.SelectedValue, "0"))) Then
            msjValidaciones += "Debe elegir un estado final del viaje" + vbLf
            erroresValidaciones = True
        End If
        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            viaje.KmRecorridos = TxtKilometrosRecorridos.Text()
            viaje.Precio = TxtPrecio.Text()
            If TxtEspera.Text() <> "" Then
                viaje.Precio += TxtEspera.Text() * 4  'valor minuto. parametro
            End If
            viaje.FechaArribo = dtpFechaArribo.Value()
            viaje.Duracion = (viaje.FechaArribo.Subtract(viaje.FechaSalida)).TotalMinutes
            viaje.Estado = estadosViajeService.GetById(cbbTipoEstadoViaje.SelectedValue)
            viajeService.RegistrarArribo(viaje)
            If viaje.Estado.Id = 4 Then
                FormCancelarViaje.formOrigen = Me
                FormCancelarViaje.viaje = viaje
                FormCancelarViaje.Show()
            Else
                MessageBox.Show("Datos guardado correctamente", "Viajes")
                FormATM.ActualizarInformacion()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub FormArribo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbTipoEstadoViaje.DataSource = Nothing
        cbbTipoEstadoViaje.DataSource = estadosViajeService.MostrarFin()
        cbbTipoEstadoViaje.DisplayMember = "descripcion"
        cbbTipoEstadoViaje.ValueMember = "id"
        TxtKilometrosRecorridos.Text = viaje.KmEstimados
        TxtPrecio.Text = viaje.PrecioEstimado
        dtpFechaArribo.Value = Now
    End Sub

End Class