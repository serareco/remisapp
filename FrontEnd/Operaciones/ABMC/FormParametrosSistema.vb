Public Class FormParametrosSistema
    Dim parametro As EL.Parametro
    Dim parametrosService As New BLL.Parametro()

    Public Sub ActualizarLista()
        txtNombreParametro.Text() = ""
        txtValorParametro.Text() = ""
        dtpVigenciaDesde.Value() = DateTime.Now

        dtpVigenciaHasta.CustomFormat = " "
        dtpVigenciaHasta.Format = DateTimePickerFormat.Custom

        dgvParametros.DataSource = Nothing
        dgvParametros.DataSource = New BindingSource With {
            .DataSource = parametrosService.Listar()
        }
        parametro = Nothing
    End Sub

    Private Sub FormParametrosSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub dtpVigenciaHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpVigenciaHasta.ValueChanged
        dtpVigenciaHasta.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If parametro Is Nothing Then
            parametro = New EL.Parametro()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""

        If (BLL.Validacion.DatoObligatorioVacio(txtValorParametro.Text, "")) Then
            msjValidaciones += "Debe ingresar el nombre del parámetro del sistema" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(txtNombreParametro.Text, "")) Then
            msjValidaciones += "Debe ingresar el valor del parámetro del sistema" + vbLf
            erroresValidaciones = True
        End If

        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            parametro.Clave = txtNombreParametro.Text
            parametro.Valor = txtValorParametro.Text
            parametro.VigenciaDesde = dtpVigenciaDesde.Value
            If dtpVigenciaHasta.CustomFormat <> " " Then
                parametro.VigenciaHasta = dtpVigenciaHasta.Value
            End If
            Try
                parametrosService.Guardar(parametro)
                MessageBox.Show("Los cambios fueron guardados correctamente.")
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al guardar los cambios. Error: " + ex.Message)
            End Try
            ActualizarLista()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If parametro IsNot Nothing Then
            txtNombreParametro.Text() = parametro.Clave
            txtValorParametro.Text() = parametro.Valor
            dtpVigenciaDesde.Value() = parametro.VigenciaDesde
            If parametro.VigenciaHasta <> DateTime.MinValue Then
                dtpVigenciaHasta.Value() = parametro.VigenciaHasta
            End If
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If parametro IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este parámetro?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                parametrosService.Quitar(parametro)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvParametros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametros.CellClick
        parametro = Nothing
        parametro = New EL.Parametro With {
            .Id = dgvParametros.Rows(e.RowIndex).Cells(0).Value
        }
        parametro = parametrosService.GetById(parametro.Id)
    End Sub


End Class