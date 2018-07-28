Public Class FormComisiones
    Dim comision As EL.Comision
    Dim datosComision As New BLL.Comision()

    Public Sub ActualizarLista()
        txtDescripcion.Text() = ""
        txtPorcentaje.Text() = ""
        dtpVigenciaDesde.Value() = DateTime.Now
        'dtpVigenciaHasta.Value() = Nothing
        dgvComisiones.DataSource = Nothing
        dgvComisiones.DataSource = datosComision.Mostrar()
        comision = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If comision Is Nothing Then
            comision = New EL.Comision()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (BLL.Validacion.DatoObligatorioVacio(txtDescripcion.Text, "")) Then
            msjValidaciones += "Debe ingresar una descripción para identificar la nueva comisión" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(txtPorcentaje.Text, "") Or BLL.Validacion.DatoObligatorioVacio(txtPorcentaje.Text, "0")) Then
            msjValidaciones += "Debe ingresar el porcentaje de la comision" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.FormatoNumeros(txtPorcentaje.Text))) Then
            msjValidaciones += "El valor del porcentaje tiene que ser numérico" + vbLf
            erroresValidaciones = True
        End If

        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            comision.Porcentaje = txtPorcentaje.Text
            comision.Descripcion = txtDescripcion.Text
            comision.VigenciaDesde = dtpVigenciaDesde.Value
            comision.VigenciaHasta = dtpVigenciaHasta.Value
            datosComision.Guardar(comision)
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
        If comision IsNot Nothing Then
            txtDescripcion.Text() = comision.Descripcion
            txtPorcentaje.Text() = comision.Porcentaje
            dtpVigenciaDesde.Text() = comision.VigenciaDesde
            dtpVigenciaHasta.Text() = comision.VigenciaHasta
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If comision IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar esta comisión?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosComision.Quitar(comision)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvComisiones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComisiones.CellClick
        comision = Nothing
        comision = New EL.Comision With {
            .Id = dgvComisiones.Rows(e.RowIndex).Cells(0).Value
        }
        comision = datosComision.GetById(comision.Id)
    End Sub

End Class