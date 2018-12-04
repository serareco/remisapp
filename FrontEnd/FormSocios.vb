Public Class FormSocios
    Dim socio As EL.Socio
    Dim datosSocio As New BLL.Socio()
    Public Sub actualizarlista()
        TxtNombre.Clear()
        TxtApellido.Clear()
        'TxtDomicilio.Clear()
        TxtEmail.Clear()
        TxtTelefono.Clear()
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = New BindingSource With {
            .DataSource = datosSocio.Listar()
        }
        socio = Nothing
    End Sub

    Private Sub btnguardar_click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If socio Is Nothing Then
            socio = New EL.Socio()
        End If
        socio.Nombre = TxtNombre.Text()
        socio.Apellido = TxtApellido.Text()
        socio.Domicilio = New EL.Domicilio() With {
            .Calle = TxtCalle.Text(),
            .Nro = TxtNumero.Text(),
            .Piso = TxtPiso.Text,
            .Dpto = TxtDpto.Text(),
            .Localidad = TxtLocalidad.Text(),
            .Provincia = TxtProvincia.Text(),
            .CP = TxtCP.Text()
            }
        socio.Email = TxtEmail.Text()
        socio.Telefono = TxtTelefono.Text()
        socio.FechaNacimiento = dtpFechaNacimiento.Value()
        datosSocio.Guardar(socio)
        actualizarlista()
    End Sub

    Private Sub btncancelar_click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formclientes_load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()
    End Sub

    Private Sub btnmodificar_click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If (socio IsNot Nothing) Then
            TxtNombre.Text() = socio.Nombre
            TxtApellido.Text() = socio.Apellido
            TxtCalle.Text() = socio.Domicilio.Calle
            TxtLocalidad.Text() = socio.Domicilio.Localidad
            TxtNumero.Text() = socio.Domicilio.Nro
            TxtPiso.Text() = socio.Domicilio.Piso
            TxtProvincia.Text() = socio.Domicilio.Provincia
            TxtCP.Text() = socio.Domicilio.CP
            TxtEmail.Text() = socio.Email
            TxtTelefono.Text() = socio.Telefono
        End If
    End Sub

    Private Sub dgvclientes_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        socio = Nothing
        socio = New EL.Socio With {
            .Id = dgvClientes.Rows(e.RowIndex).Cells(0).Value
        }
        socio = datosSocio.GetById(socio.Id)
    End Sub

    Private Sub btneliminar_click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If socio IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("estas seguro que deseas dar de baja este cliente?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosSocio.Quitar(socio)
                actualizarlista()
            End If
        End If
    End Sub

    Private Sub btnlimpiar_click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        actualizarlista()
    End Sub
End Class