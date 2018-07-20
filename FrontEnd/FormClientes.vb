Imports BackEnd
Public Class FormClientes
    Private cliente As Cliente = Nothing
    Public Sub ActualizarLista()
        TxtNombre.Text() = ""
        TxtApellido.Text() = ""
        TxtDomicilio.Text() = ""
        TxtEmail.Text() = ""
        TxtTelefono.Text() = ""
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = New Cliente().MostrarLista()
        cliente = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim cliente As New Cliente()
        If cliente Is Nothing Then
            cliente = New Cliente()
        End If
        cliente.Nombre = TxtNombre.Text()
        cliente.Apellido = TxtApellido.Text()
        cliente.Domicilio = TxtDomicilio.Text()
        cliente.Email = TxtEmail.Text()
        cliente.Telefono = TxtTelefono.Text()
        cliente.Guardar()
        ActualizarLista()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If (cliente IsNot Nothing) Then
            TxtNombre.Text() = cliente.Nombre
            TxtApellido.Text() = cliente.Apellido
            TxtDomicilio.Text() = cliente.Domicilio
            TxtEmail.Text() = cliente.Email
            TxtTelefono.Text() = cliente.Telefono
        End If
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        cliente = Nothing
        cliente = New Cliente With {
            .Id = dgvClientes.Rows(e.RowIndex).Cells(0).Value
        }
        cliente.GetById(cliente.Id)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If cliente IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas dar de baja este Cliente?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                cliente.Quitar()
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
End Class