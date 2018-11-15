Public Class Cliente

    Public Function GetById(pId As Int16) As EL.Cliente
        Return New DAL.Cliente().GetById(pId)
    End Function

    Public Function Listar() As List(Of EL.Cliente)
        Return New DAL.Cliente().Listar()
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
