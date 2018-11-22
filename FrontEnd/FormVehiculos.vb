Public Class FormVehiculos
    Dim auto As EL.Vehiculo
    Dim datosAuto As New BLL.Vehiculo()
    Dim datosMarcas As New BLL.Marca()
    Dim datosModelos As New BLL.Modelo()

    Public Sub ActualizarLista()
        txtAnioFabricacion.Clear()
        txtPatente.Clear()
        txtChasis.Clear()
        txtMotor.Clear()

        cbbMarca.DataSource = Nothing
        cbbModelo.DataSource = Nothing
        dgvAutos.DataSource = Nothing

        auto = Nothing

        cbbMarca.DataSource = New BindingSource With {
            .DataSource = datosMarcas.Listar()
        }
        cbbMarca.DisplayMember = "Descripcion"
        cbbMarca.ValueMember = "Id"

        dgvAutos.DataSource = New BindingSource With {
            .DataSource = datosAuto.Listar()
        }
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If auto Is Nothing Then
            auto = New EL.Vehiculo()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (Not (BLL.Validacion.FormatoNumeros(txtAnioFabricacion.Text()))) Then
            msjValidaciones += "El año de fabricación solo admite números" + vbLf
            erroresValidaciones = True
        End If
        If (Not (BLL.Validacion.RangoNumeros(txtAnioFabricacion.Text(), 1994, CType(Date.Now.Date.ToString("yyyy"), Decimal)))) Then
            msjValidaciones += "Año de fabricación inválido. No está dentro de [1994-" + Date.Now.Date.ToString("yyyy") + "]" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(cbbMarca.SelectedValue, "0")) Then
            msjValidaciones += "Debe seleccionar una Marca" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(cbbModelo.SelectedValue, "0")) Then
            msjValidaciones += "Debe seleccionar un Modelo" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(txtChasis.Text, "")) Then
            msjValidaciones += "El Chasis es Obligatorio" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(txtMotor.Text, "")) Then
            msjValidaciones += "El Motor es Obligatorio" + vbLf
            erroresValidaciones = True
        End If
        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            auto.Modelo = datosModelos.GetById(cbbModelo.SelectedValue)
            auto.AnioFabricacion = txtAnioFabricacion.Text
            auto.Patente = txtPatente.Text
            auto.Chasis = txtChasis.Text
            auto.Motor = txtMotor.Text
            datosAuto.Guardar(auto)
            ActualizarLista()
        End If
    End Sub

    Private Sub cbbMarca_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbMarca.SelectedValueChanged
        cbbModelo.DataSource = Nothing
        Dim valueIdSelected As Int16
        If TypeOf cbbMarca.SelectedValue Is EL.Marca Then
            valueIdSelected = cbbMarca.SelectedValue.Id
        Else
            valueIdSelected = cbbMarca.SelectedValue
        End If
        cbbModelo.DataSource = New BindingSource With {
                .DataSource = datosModelos.Listar(valueIdSelected)
            }
        cbbModelo.DisplayMember = "Descripcion"
        cbbModelo.ValueMember = "Id"
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
            cbbMarca.SelectedValue() = auto.Modelo.Marca.Id
            cbbModelo.SelectedValue() = auto.Modelo.Id
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If auto IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este auto?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosAuto.Quitar(auto)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub

    Private Sub dgvAutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutos.CellClick
        auto = Nothing
        auto = New EL.Vehiculo With {
            .Id = dgvAutos.Rows(e.RowIndex).Cells(0).Value
        }
        auto = datosAuto.GetById(auto.Id)
    End Sub
End Class