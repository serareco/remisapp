Public Class FormReporteViajesMensuales
    Dim datosViajes As New BLL.Viaje
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormReporteViajesMensuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvViajesMensuales.AutoGenerateColumns = False
        DgvViajesMensuales.Columns.Clear()
        DgvViajesMensuales.DataSource = Nothing
        DgvViajesMensuales.DataSource = datosViajes.ListarMensual()
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Id",
                    .Name = "ID"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Origen",
                    .Name = "Origen"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Destino",
            .Name = "Destino"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaSalidaEstimada",
            .Name = "Fecha Salida Estimada"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaArriboEstimado",
            .Name = "Fecha Arribo Estimada"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Estado",
            .Name = "Estado"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "ChoferEstimado",
            .Name = "Chofer Asignado"
        })
        DgvViajesMensuales.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "DuracionEstimada",
            .Name = "Duracion"
        })

    End Sub
End Class