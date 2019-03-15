Public Class Marca
    Dim marcaDAL As New DAL.Marca()
    Public Function GetById(pId As Int16) As EL.Marca
        Return marcaDAL.GetById(pId)
    End Function

    Public Function Listar() As List(Of EL.Marca)
        Return marcaDAL.Listar()
    End Function
End Class
