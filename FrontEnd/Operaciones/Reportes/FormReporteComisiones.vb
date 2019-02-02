Public Class FormReporteComisiones
    Dim datosChofer As New BLL.Chofer
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormReporteComisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvComisionesChoferes.AutoGenerateColumns = False
        DgvComisionesChoferes.Columns.Clear()
        DgvComisionesChoferes.DataSource = Nothing
        DgvComisionesChoferes.DataSource = datosChofer.Listar()
        DgvComisionesChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Id",
                    .Name = "Id"
        })
        DgvComisionesChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Apellido",
                    .Name = "Apellido"
        })
        DgvComisionesChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Nombre",
                    .Name = "Nombre"
        })
        DgvComisionesChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Comision",
                    .Name = "Comision"
        })

    End Sub
End Class