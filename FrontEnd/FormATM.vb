Public Class FormATM
    Dim servicios As New BLL.Chofer()

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

    Private Sub FormATM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDataGridviews()
        ActualizarInformacion.Start()
    End Sub

    Private Sub ActualizarInformacion_Tick(sender As Object, e As EventArgs) Handles ActualizarInformacion.Tick
        ActualizarDataGridviews()
    End Sub

End Class