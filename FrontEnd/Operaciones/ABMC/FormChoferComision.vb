Public Class FormChoferComision
    Dim chofer As EL.Chofer
    Dim datosChofer As New BLL.Chofer()
    Dim datosComisiones As New BLL.Comision()

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Public Sub ActualizarLista()
        CbbComisiones.DataSource = Nothing
        CbbComisiones.DataSource = New BindingSource With {
            .DataSource = datosComisiones.ListarVigentes()
        }
        CbbComisiones.DisplayMember = "Descripcion"
        CbbComisiones.ValueMember = "Id"

        TxtComisionActual.Clear()

        dgvChoferes.DataSource = Nothing
        dgvChoferes.AutoGenerateColumns = False
        dgvChoferes.Columns.Clear()
        dgvChoferes.DataSource = datosChofer.Listar()
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                .DataPropertyName = "Id",
                .Name = "Id"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Apellido",
                    .Name = "Apellido"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Nombre",
                    .Name = "Nombre"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "NroDocumento",
                    .Name = "Nro. Documento"
        })
        dgvChoferes.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Auto",
                    .Name = "Auto"
        })
        chofer = Nothing
    End Sub

    Private Sub FormChoferComision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
    Private Sub dgvChoferes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChoferes.CellClick
        chofer = Nothing
        chofer = New EL.Chofer With {
            .Id = dgvChoferes.Rows(e.RowIndex).Cells(0).Value
        }
        chofer = datosChofer.GetById(chofer.Id)
        TxtComisionActual.Text = chofer.Comision.ToString

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        chofer.Comision = datosComisiones.GetById(CbbComisiones.SelectedValue)
        datosChofer.Guardar(chofer)
        ActualizarLista()
        MessageBox.Show("Los datos se han modificado correctamente.")
    End Sub
End Class