Public Class FormBeneficios
    Dim promocion As EL.Beneficio
    Dim datosPromocion As New BLL.Beneficio()

    Public Sub ActualizarLista()
        txtDescripcion.Text() = ""
        txtDescuento.Text() = ""
        dtpVigenciaDesde.Value() = DateTime.Now
        'dtpVigenciaHasta.Value() = Nothing
        dgvPromociones.DataSource = Nothing
        dgvPromociones.DataSource = datosPromocion.Mostrar()
        promocion = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If promocion Is Nothing Then
            promocion = New EL.Beneficio()
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
            promocion.Descuento = txtDescuento.Text
            promocion.Descripcion = txtDescripcion.Text
            promocion.VigenciaDesde = dtpVigenciaDesde.Value
            promocion.VigenciaHasta = dtpVigenciaHasta.Value
            datosPromocion.Guardar(promocion)
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
        If promocion IsNot Nothing Then
            txtDescripcion.Text() = promocion.Descripcion
            txtDescuento.Text() = promocion.Descuento
            dtpVigenciaDesde.Text() = promocion.VigenciaDesde
            dtpVigenciaHasta.Text() = promocion.VigenciaHasta
        End If
    End Sub

        Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If promocion IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar esta comisión?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosPromocion.Quitar(promocion)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvComisiones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromociones.CellClick
        promocion = Nothing
        promocion = New EL.Beneficio With {
                .Id = dgvPromociones.Rows(e.RowIndex).Cells(0).Value
            }
        promocion = datosPromocion.GetById(promocion.Id)
    End Sub


End Class