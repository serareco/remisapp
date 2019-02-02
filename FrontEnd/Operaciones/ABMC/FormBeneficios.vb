Public Class FormBeneficios
    Dim beneficio As EL.Beneficio
    Dim datosBeneficio As New BLL.Beneficio()

    Public Sub ActualizarLista()
        txtDescripcion.Clear()
        txtDescuento.Clear()
        TxtTotalSemanal.Clear()
        TxtViajesSemanal.Clear()

        dtpVigenciaDesde.CustomFormat = "dd/MM/yyyy"
        dtpVigenciaDesde.Format = DateTimePickerFormat.Custom

        dtpVigenciaHasta.CustomFormat = " "
        dtpVigenciaHasta.Format = DateTimePickerFormat.Custom

        dgvPromociones.DataSource = Nothing
        dgvPromociones.DataSource = New BindingSource With {
            .DataSource = datosBeneficio.Listar()
        }

        beneficio = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If beneficio Is Nothing Then
            beneficio = New EL.Beneficio()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (BLL.Validacion.DatoObligatorioVacio(txtDescripcion.Text, "")) Then
            msjValidaciones += "Debe ingresar una descripción para identificar la nueva comisión" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(txtDescuento.Text, "") Or BLL.Validacion.DatoObligatorioVacio(txtDescuento.Text, "0")) Then
            msjValidaciones += "Debe ingresar el porcentaje de la comision" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(txtDescuento.Text))) Then
            msjValidaciones += "El valor del porcentaje tiene que ser numérico" + vbLf
            erroresValidaciones = True
        End If

        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            beneficio.Descuento = txtDescuento.Text
            beneficio.Descripcion = txtDescripcion.Text
            beneficio.VigenciaDesde = dtpVigenciaDesde.Value
            If dtpVigenciaHasta.CustomFormat <> " " Then
                beneficio.VigenciaHasta = dtpVigenciaHasta.Value
            End If
            beneficio.TotalAcumulado = TxtTotalSemanal.Text
            beneficio.CantidadViajes = TxtViajesSemanal.Text
            Try
                datosBeneficio.Guardar(beneficio)
                MessageBox.Show("Beneficio guardado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el beneficio. Error: " + ex.Message)
            End Try

            ActualizarLista()
        End If
    End Sub

    Private Sub FormComisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If beneficio IsNot Nothing Then
            txtDescripcion.Text = beneficio.Descripcion
            txtDescuento.Text = beneficio.Descuento
            dtpVigenciaDesde.Text = beneficio.VigenciaDesde
            If beneficio.VigenciaHasta <> Date.MinValue Then
                dtpVigenciaHasta.Text = beneficio.VigenciaHasta
            End If
            TxtTotalSemanal.Text = beneficio.TotalAcumulado
            TxtViajesSemanal.Text = beneficio.CantidadViajes
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If beneficio IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este beneficio?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosBeneficio.Quitar(beneficio)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvComisiones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromociones.CellClick
        beneficio = Nothing
        beneficio = New EL.Beneficio With {
                .Id = dgvPromociones.Rows(e.RowIndex).Cells(0).Value
            }
        beneficio = datosBeneficio.GetById(beneficio.Id)
    End Sub

    Private Sub dtpVigenciaHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpVigenciaHasta.ValueChanged
        dtpVigenciaHasta.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
End Class