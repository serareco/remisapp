Imports BackEnd
Public Class FormAutos
    Private auto As Auto
    Public Sub ActualizarLista()
        cbbMarca.DataSource = Nothing
        cbbModelo.DataSource = Nothing
        cbbMarca.DataSource = New Auto().MostrarMarcas()
        cbbMarca.DisplayMember = "descripcion"
        cbbMarca.ValueMember = "id_marca"
        txtAnioFabricacion.Text() = ""
        txtPatente.Text() = ""
        txtChasis.Text() = ""
        txtMotor.Text() = ""
        dgvAutos.DataSource = Nothing
        dgvAutos.DataSource = New Auto().Mostrar()
        auto = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If auto Is Nothing Then
            auto = New Auto()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (Not (Validacion.FormatoNumeros(txtAnioFabricacion.Text()))) Then
            msjValidaciones += "El año de fabricación solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If (Not (Validacion.RangoNumeros(txtAnioFabricacion.Text(), 1994, CType(Date.Now.Date.ToString("yyyy"), Decimal)))) Then
            msjValidaciones += "Año de fabricación inválido. No está dentro de [1994-" + Date.Now.Date.ToString("yyyy") + "]" + vbLf
            erroresValidaciones = True
        End If
        If (Validacion.DatoObligatorioVacio(cbbMarca.SelectedValue, "0")) Then
            msjValidaciones += "Debe seleccionar una Marca" + vbLf
            erroresValidaciones = True
        End If
        If (Validacion.DatoObligatorioVacio(cbbModelo.SelectedValue, "0")) Then
            msjValidaciones += "Debe seleccionar un Modelo" + vbLf
            erroresValidaciones = True
        End If
        If (Validacion.DatoObligatorioVacio(txtChasis.Text, "")) Then
            msjValidaciones += "El Chasis es Obligatorio" + vbLf
            erroresValidaciones = True
        End If
        If (Validacion.DatoObligatorioVacio(txtMotor.Text, "")) Then
            msjValidaciones += "El Motor es Obligatorio" + vbLf
            erroresValidaciones = True
        End If
        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            auto.Marca = cbbMarca.SelectedValue
            auto.Modelo = cbbModelo.SelectedValue
            auto.AnioFabricacion = txtAnioFabricacion.Text
            auto.Patente = txtPatente.Text
            auto.Chasis = txtChasis.Text
            auto.Motor = txtMotor.Text
            auto.Guardar()
            ActualizarLista()
        End If
    End Sub

    Private Sub cbbMarca_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbMarca.SelectedValueChanged
        cbbModelo.DataSource = Nothing
        cbbModelo.DataSource = New Auto().MostrarModelos(cbbMarca.SelectedIndex)
        cbbModelo.DisplayMember = "descripcion"
        cbbModelo.ValueMember = "id_modelo"
    End Sub

    Private Sub FormAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If auto IsNot Nothing Then
            txtAnioFabricacion.Text() = auto.AnioFabricacion
            txtChasis.Text() = auto.Chasis
            txtMotor.Text() = auto.Motor
            txtPatente.Text() = auto.Patente
            cbbMarca.SelectedValue() = auto.Marca
            cbbModelo.SelectedValue() = auto.Modelo
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If auto IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este auto?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                auto.Quitar()
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dgvAutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutos.CellClick
        auto = Nothing
        auto = New Auto With {
            .Id = dgvAutos.Rows(e.RowIndex).Cells(0).Value
        }
        auto.GetById(auto.Id)
    End Sub
End Class