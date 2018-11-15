Public Class Marca
    Public Function GetById(pId As Int16) As EL.Marca
        Return New DAL.Marca().GetById(pId)
    End Function

    Public Function Listar() As List(Of EL.Marca)
        Return New DAL.Marca().Listar()
    End Function
End Class
