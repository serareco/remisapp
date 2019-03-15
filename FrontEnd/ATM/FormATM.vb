Public Class FormATM
    Dim viajeService As New BLL.Viaje()
    Dim viajeSeleccionado As New EL.Viaje()
    Dim viaje As New EL.Viaje()
    Private Sub ActualizarDataGridviews()
        DgvServiciosPendientes.AutoGenerateColumns = False
        DgvServiciosPendientes.AutoSize = True
        DgvServiciosPendientes.Columns.Clear()
        DgvServiciosPendientes.DataSource = viajeService.ListarPendientes()
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
            .Name = "Fecha Salida Estimada"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaArriboEstimado",
            .Name = "Fecha Arribo Estimada"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Estado",
            .Name = "Estado"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "ChoferEstimado",
            .Name = "Chofer Asignado"
        })
        DgvServiciosPendientes.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "DuracionEstimada",
            .Name = "Duracion"
        })

        DgvServiciosEnCurso.AutoGenerateColumns = False
        DgvServiciosEnCurso.AutoSize = True
        DgvServiciosEnCurso.Columns.Clear()
        DgvServiciosEnCurso.DataSource = viajeService.ListarEnCurso()
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Id",
                    .Name = "ID"
        })
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Origen",
                    .Name = "Origen"
        })
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Destino",
            .Name = "Destino"
        })
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaSalida",
            .Name = "Fecha Salida"
        })
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaArriboEstimado",
            .Name = "Fecha Arribo"
        })
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Estado",
            .Name = "Estado"
        })
        DgvServiciosEnCurso.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Chofer",
            .Name = "Chofer"
        })

    End Sub

    Public Sub ActualizarProximosSalir()
        Dim proximoViajeASalir = viajeService.GetProximoViajePendiente()
        If proximoViajeASalir.FechaSalidaEstimada <> Date.MinValue Then
            LblChoferSalir.Text = proximoViajeASalir.ChoferEstimado.Apellido + ", " + proximoViajeASalir.ChoferEstimado.Nombre
            LblDestinoSalir.Text = proximoViajeASalir.Destino
            LblOrigenSalir.Text = proximoViajeASalir.Origen
            LblHorarioSalir.Text = proximoViajeASalir.FechaSalidaEstimada.ToShortDateString + " " + proximoViajeASalir.FechaSalidaEstimada.ToShortTimeString
        Else
            LblChoferSalir.Text = ""
            LblDestinoSalir.Text = ""
            LblOrigenSalir.Text = ""
            LblHorarioSalir.Text = ""
        End If
    End Sub

    Public Sub ActualizarProximosLlegar()
        Dim proximoViajePorLlegar = viajeService.GetProximoViajeVuelta()
        If proximoViajePorLlegar.FechaSalida <> Date.MinValue Then
            LblChoferLlegar.Text = proximoViajePorLlegar.Chofer.Apellido + ", " + proximoViajePorLlegar.Chofer.Nombre
            LblDestinoLlegar.Text = proximoViajePorLlegar.Destino
            LblOrigenLlegar.Text = proximoViajePorLlegar.Origen
            proximoViajePorLlegar.FechaSalidaEstimada = proximoViajePorLlegar.FechaSalida.AddMinutes(proximoViajePorLlegar.DuracionEstimada)
            LblHorarioLlegar.Text = proximoViajePorLlegar.FechaArriboEstimado.ToShortDateString + " " + proximoViajePorLlegar.FechaArriboEstimado.ToShortTimeString
        Else
            LblChoferLlegar.Text = ""
            LblDestinoLlegar.Text = ""
            LblOrigenLlegar.Text = ""
            LblHorarioLlegar.Text = ""
        End If
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
        ActualizarInformacion()
    End Sub

    Private Sub DgvServiciosPendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvServiciosPendientes.CellDoubleClick
        If e.RowIndex >= 0 Then
            viaje = Nothing
            FormSalida.viaje = viajeService.GetById(DgvServiciosPendientes.Rows(e.RowIndex).Cells(0).Value)
            FrmLogin.MostrarSalida = True
            FrmLogin.Show()
        End If
    End Sub

    Private Sub DgvServiciosEnCurso_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvServiciosEnCurso.CellDoubleClick
        If e.RowIndex >= 0 Then
            viaje = Nothing
            FormArribo.viaje = viajeService.GetById(DgvServiciosEnCurso.Rows(e.RowIndex).Cells(0).Value)
            FrmLogin.MostrarArribo = True
            FrmLogin.Show()
        End If
    End Sub
End Class