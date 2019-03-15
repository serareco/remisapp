Public Class EstadoViaje
    Dim estadoViajeDAL As New DAL.EstadoViaje()
    Public Function MostrarAlta() As List(Of EL.EstadoViaje)
        Return estadoViajeDAL.Listar("A")
    End Function

    Public Function MostrarFin() As List(Of EL.EstadoViaje)
        Return estadoViajeDAL.Listar("F")
    End Function

    Public Function GetById(pId As Int16) As EL.EstadoViaje
        Return estadoViajeDAL.GetById(pId)
    End Function
End Class