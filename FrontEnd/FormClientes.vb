Public Class FormClientes
    Dim cliente As EL.Cliente
    Dim datosCliente As New BLL.Cliente()
    Public Sub actualizarlista()
        TxtNombre.Text() = ""
        TxtApellido.Text() = ""
        TxtDomicilio.Text() = ""
        TxtEmail.Text() = ""
        TxtTelefono.Text() = ""
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = datosCliente.MostrarLista()
        cliente = Nothing
    End Sub

    Private Sub btnguardar_click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If cliente Is Nothing Then
            cliente = New EL.Cliente()
        End If
        cliente.Nombre = TxtNombre.Text()
        cliente.Apellido = TxtApellido.Text()
        cliente.Domicilio = TxtDomicilio.Text()
        cliente.Email = TxtEmail.Text()
        cliente.Telefono = TxtTelefono.Text()
        datosCliente.Guardar(cliente)
        actualizarlista()
    End Sub

    Private Sub btncancelar_click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formclientes_load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()
    End Sub

    Private Sub btnmodificar_click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If (cliente IsNot Nothing) Then
            TxtNombre.Text() = cliente.nombre
            TxtApellido.Text() = cliente.apellido
            TxtDomicilio.Text() = cliente.domicilio
            TxtEmail.Text() = cliente.email
            TxtTelefono.Text() = cliente.telefono
        End If
    End Sub

    Private Sub dgvclientes_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        cliente = Nothing
        cliente = New EL.Cliente With {
            .Id = dgvClientes.Rows(e.RowIndex).Cells(0).Value
        }
        cliente = datosCliente.GetById(cliente.Id)
    End Sub

    Private Sub btneliminar_click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If cliente IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("estas seguro que deseas dar de baja este cliente?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosCliente.Quitar(cliente)
                actualizarlista()
            End If
        End If
    End Sub

    Private Sub btnlimpiar_click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        actualizarlista()
    End Sub
End Class