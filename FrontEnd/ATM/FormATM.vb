Public Class FormATM
    Dim servicios As New BLL.Viaje()
    Dim viajeSeleccionado As New EL.Viaje()
    Dim viaje As New EL.Viaje()
    Private Sub ActualizarDataGridviews()
        DgvServiciosEnCurso.DataSource = Nothing
        DgvServiciosEnCurso.DataSource = New BindingSource With {
            .DataSource = servicios.ListarEnCurso()
        }

        DgvServiciosPendientes.AutoGenerateColumns = False
        DgvServiciosPendientes.AutoSize = True
        DgvServiciosPendientes.Columns.Clear()
        DgvServiciosPendientes.DataSource = servicios.ListarPendientes()
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Id",
                    .Name = "ID"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Origen",
                    .Name = "Origen"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Destino",
            .Name = "Destino"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaSalidaEstimada",
            .Name = "Fecha Salida"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaArriboEstimado",
            .Name = "Fecha Arribo"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Estado",
            .Name = "Estado"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "ChoferEstimado",
            .Name = "Chofer Asignado"
        })

    End Sub

    Public Sub ActualizarProximosSalir()
        Dim proximoViajeASalir = servicios.GetProximoViajePendiente()
        LblChoferSalir.Text = proximoViajeASalir.ChoferEstimado.Apellido + ", " + proximoViajeASalir.ChoferEstimado.Nombre
        LblDestinoSalir.Text = proximoViajeASalir.Destino
        LblOrigenSalir.Text = proximoViajeASalir.Origen
        LblHorarioSalir.Text = proximoViajeASalir.FechaSalidaEstimada.ToShortDateString + " " + proximoViajeASalir.FechaSalidaEstimada.ToShortTimeString
    End Sub

    Public Sub ActualizarProximosLlegar()
        Dim proximoViajePorLlegar = servicios.GetProximoViajeVuelta()
        LblChoferLlegar.Text = proximoViajePorLlegar.Chofer.Apellido + ", " + proximoViajePorLlegar.Chofer.Nombre
        LblDestinoLlegar.Text = proximoViajePorLlegar.Destino
        LblOrigenLlegar.Text = proximoViajePorLlegar.Origen
        proximoViajePorLlegar.FechaSalidaEstimada = proximoViajePorLlegar.FechaSalida.AddMinutes(proximoViajePorLlegar.DuracionEstimada)
        LblHorarioLlegar.Text = proximoViajePorLlegar.FechaSalidaEstimada.ToShortDateString + " " + proximoViajePorLlegar.FechaSalidaEstimada.ToShortTimeString
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

    Private Sub DgvServiciosPendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvServiciosPendientes.CellDoubleClick
        viaje = Nothing
        FormSalida.viaje = servicios.GetById(DgvServiciosPendientes.Rows(e.RowIndex).Cells(0).Value)
        FormSalida.Show()
    End Sub
End Class