Public Class FormConsultaPuntosChofer
    Dim choferService As New BLL.Chofer()
    Dim accionService As New BLL.Accion()
    Dim reporteService As New BLL.Reporte()

    Private Sub CleanCheckList()
        ClbAccion.ClearSelected()
        For index = 0 To ClbAccion.Items.Count - 1
            ClbAccion.SetItemChecked(index, False)
        Next
    End Sub

    Private Sub ActualizarLista()
        cbbChofer.DataSource = Nothing
        cbbChofer.DataSource = choferService.Listar
        cbbChofer.DisplayMember = "Nombre"
        cbbChofer.ValueMember = "Id"

        ClbAccion.DataSource = New BindingSource With {
            .DataSource = accionService.Listar()
        }
        ClbAccion.DisplayMember = "Descripcion"
        ClbAccion.ValueMember = "Id"

        ChkActivo.Checked = False
        ChkVigente.Checked = False
    End Sub

    Private Sub FormConsultaPuntosChofer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        reporteService.Parametros = New List(Of Object)
        reporteService.Parametros.Add(cbbChofer.SelectedValue)
        reporteService.Parametros.Add(dtpFechaDesde.Value)
        reporteService.Parametros.Add(dtpFechaHasta.Value)
        reporteService.Parametros.Add(ChkActivo.Checked)
        reporteService.Parametros.Add(ChkVigente.Checked)


    End Sub
End Class