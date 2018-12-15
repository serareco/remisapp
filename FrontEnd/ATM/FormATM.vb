Public Class FormATM
    Dim servicios As New BLL.Viaje()
    Dim viajeSeleccionado As New EL.Viaje()

    Private Sub ActualizarDataGridviews()
        DgvServiciosEnCurso.DataSource = Nothing
        DgvServiciosEnCurso.DataSource = New BindingSource With {
            .DataSource = servicios.Listar()
        }
        DgvServiciosPendientes.DataSource = Nothing
        DgvServiciosPendientes.DataSource = New BindingSource With {
            .DataSource = servicios.Listar()
        }
    End Sub

    Public Sub ActualizarProximosSalir()
        Dim proximoViajeASalir = servicios.GetProximoViajePendiente()
        LblChoferSalir.Text = proximoViajeASalir.Chofer.Apellido + ", " + proximoViajeASalir.Chofer.Nombre
        LblDestinoSalir.Text = proximoViajeASalir.Destino
        LblOrigenSalir.Text = proximoViajeASalir.Origen
        LblHorarioSalir.Text = proximoViajeASalir.FechaSalida
    End Sub

    Public Sub ActualizarProximosLlegar()
        Dim proximoViajePorLlegar = servicios.GetProximoViajeVuelta()
        LblChoferLlegar.Text = proximoViajePorLlegar.Chofer.Apellido + ", " + proximoViajePorLlegar.Chofer.Nombre
        LblDestinoLlegar.Text = proximoViajePorLlegar.Destino
        LblOrigenLlegar.Text = proximoViajePorLlegar.Origen
        LblHorarioLlegar.Text = proximoViajePorLlegar.FechaArribo
    End Sub

    Public Sub ActualizarInformacion()
        ActualizarProximosSalir()
        ActualizarProximosLlegar()
        ActualizarDataGridviews()
    End Sub

    Private Sub FormATM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarInformacion()
        TimerActualizarInformacion.Start()
    End Sub

    Private Sub ActualizarInformacion_Tick(sender As Object, e As EventArgs) Handles TimerActualizarInformacion.Tick
        ActualizarDataGridviews()
    End Sub

End Class