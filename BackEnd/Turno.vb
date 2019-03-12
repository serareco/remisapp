Public Class Turno
    Dim turnoDAL As New DAL.Turno()
    Public Function Listar() As List(Of EL.Turno)
        Return turnoDAL.Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Turno
        Return turnoDAL.GetById(pId)
    End Function
End Class
