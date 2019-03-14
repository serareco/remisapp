Public Class FormConfirmarViaje
    Public viaje As EL.Viaje
    Dim choferService As New BLL.Chofer()
    Dim viajeService As New BLL.Viaje()
    Dim beneficioService As New BLL.Beneficio()
    Dim valorKM As Decimal = New BLL.Parametro().GetValueByKey("KM_VALOR")

    Private Sub FormConfirmarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            viajeService.SetBeneficios(viaje)
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
                LblAvisoDemora.Text = "No hay choferes disponibles para la hora solicitada."
            End If
            viaje.Ahorro = viaje.PrecioEstimado * viajeService.PorcDescBeneficios(viaje)
            If viaje.Beneficios.Count > 0 Then
                viaje.PrecioEstimado = viaje.PrecioEstimado - viaje.Ahorro
                viaje.Beneficios = beneficioService.Verificar(viaje.Socio.Id)
                LblBeneficios.Text = "El usuario tiene beneficios!. "
                If viaje.Ahorro > 0 Then
                    LblBeneficios.Text += "Si confirma, está ahorrando " + viaje.Ahorro.ToString()
                End If
            End If

                Try
                viajeService.ConsultarAPI(viaje)
            Catch ex As Exception
                Throw ex
            End Try

            TxtOrigen.Text = viaje.Origen
            TxtDestino.Text = viaje.Destino
            TxtHoraSalida.Text = viaje.FechaSalidaEstimada.ToShortDateString + " " + viaje.FechaSalidaEstimada.ToShortTimeString
            TxtKilometrosRecorrer.Text = viaje.KmEstimados
            TxtValor.Text = viaje.PrecioEstimado
            TxtDuracionEstimada.Text = viaje.DuracionEstimada
        Catch ex As Exception
            TxtOrigen.Text = viaje.Origen
            TxtDestino.Text = viaje.Destino
            TxtHoraSalida.Text = viaje.FechaSalidaEstimada.ToShortDateString + " " + viaje.FechaSalidaEstimada.ToShortTimeString
            TxtKilometrosRecorrer.Enabled = True
            TxtValor.Enabled = True
            TxtDuracionEstimada.Enabled = True
            TxtValor.Enabled = True
            LblException.Text = ex.Message
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        viaje.ChoferEstimado = choferService.GetById(cbbChofer.SelectedValue)
        viaje.DuracionEstimada = TxtDuracionEstimada.Text
        viaje.FechaArriboEstimado = viaje.FechaSalidaEstimada.AddMinutes(viaje.DuracionEstimada)
        viaje.PrecioEstimado = TxtValor.Text
        viaje.KmEstimados = TxtKilometrosRecorrer.Text
        viajeService.Guardar(viaje)
        MessageBox.Show("El nuevo viaje fue cargado correctamente.")
        FormViajes.ActualizarLista()
        Me.Close()
    End Sub

    Private Sub TxtValor_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged
        If viaje.Beneficios.Count > 0 Then
            If TxtValor.Text().Trim = "" Then
                TxtValor.Text() = 0
            Else
                viaje.Ahorro = TxtValor.Text() * viajeService.PorcDescBeneficios(viaje)
                viaje.PrecioEstimado = viaje.PrecioEstimado - viaje.Ahorro
            End If
            LblBeneficios.Text = "El usuario tiene beneficios!. "
            If viaje.Ahorro > 0 Then
                LblBeneficios.Text += "Si confirma, está ahorrando " + viaje.Ahorro.ToString()
            End If
        Else
            viaje.PrecioEstimado = TxtValor.Text()
        End If
    End Sub

    Private Sub TxtKilometrosRecorrer_TextChanged(sender As Object, e As EventArgs) Handles TxtKilometrosRecorrer.TextChanged
        If TxtKilometrosRecorrer.Text().Trim = "" Then
            TxtKilometrosRecorrer.Text() = 0
        Else
            TxtValor.Text = TxtKilometrosRecorrer.Text() * valorKM
        End If
    End Sub
End Class