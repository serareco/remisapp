Public Class Modelo
    Public Function GetById(pId As Int16) As EL.Modelo
        Return New DAL.Modelo().GetById(pId)
    End Function
    Public Function Listar() As List(Of EL.Modelo)
        Return New DAL.Modelo().Listar()
    End Function
    Public Function Listar(pIdMarca As Int16)
        Return New DAL.Modelo().Listar(pIdMarca)
    End Function
End Class
