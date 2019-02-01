Public Class EstadoViaje
    Public Function MostrarAlta() As List(Of EL.EstadoViaje)
        Return New DAL.EstadoViaje().Listar("A")
    End Function

    Public Function MostrarFin() As List(Of EL.EstadoViaje)
        Return New DAL.EstadoViaje().Listar("F")
    End Function

    Public Function GetById(pId As Int16) As EL.EstadoViaje
        Return New DAL.EstadoViaje().GetById(pId)
    End Function
End Class