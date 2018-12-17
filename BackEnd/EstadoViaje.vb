Public Class EstadoViaje
    Public Function MostrarAlta() As DataTable
        Return New DAL.EstadoViaje().MostrarAlta()
    End Function

    Public Function MostrarFin() As DataTable
        Return New DAL.EstadoViaje().MostrarFin()
    End Function

    Public Function GetById(pId As Int16) As EL.EstadoViaje
        Return New DAL.EstadoViaje().GetById(pId)
    End Function
End Class
