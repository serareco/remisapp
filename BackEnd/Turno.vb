Public Class Turno
    Public Function Listar() As List(Of EL.Turno)
        Return New DAL.Turno().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Turno
        Return New DAL.Turno().GetById(pId)
    End Function
End Class
