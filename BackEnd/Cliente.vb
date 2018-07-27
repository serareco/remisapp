Public Class Cliente

    Public Function GetById(pId As Int16) As EL.Cliente
        Dim datatable As DataTable = New DAL.Cliente().GetById(pId)
        Dim cliente As New EL.Cliente()
        If (datatable.Rows.Count > 0) Then
            cliente.Id = datatable.Rows(0).ItemArray(0).ToString()
            cliente.NroCliente = datatable.Rows(0).ItemArray(1).ToString()
            cliente.Nombre = datatable.Rows(0).ItemArray(2).ToString()
            cliente.Apellido = datatable.Rows(0).ItemArray(3).ToString()
            cliente.Domicilio = datatable.Rows(0).ItemArray(4).ToString()
            cliente.Email = datatable.Rows(0).ItemArray(5).ToString()
            cliente.Telefono = datatable.Rows(0).ItemArray(6).ToString()
        End If
        Return cliente
    End Function

    Public Function Mostrar() As DataTable
        Return New DAL.Cliente().Mostrar()
    End Function

    Public Function MostrarLista()
        Return New DAL.Cliente().MostrarLista()
    End Function

    Public Sub Guardar(cliente As EL.Cliente)
        Dim e As New DAL.Cliente()
        e.Guardar(cliente)
    End Sub

    Public Sub Quitar(cliente As EL.Cliente)
        Dim e As New DAL.Cliente()
        e.Quitar(cliente)
    End Sub

End Class
