Public Class EstadoViaje
    Public Function MostrarAlta() As DataTable
        Return New DAL.EstadoViaje().MostrarAlta()
    End Function

    Public Function MostrarFin() As DataTable
        Return New DAL.EstadoViaje().MostrarFin()
    End Function

    Public Function GetById(pId As Int16) As EL.EstadoViaje
        Dim estadoViaje As New EL.EstadoViaje()
        Dim datatable As DataTable = New DAL.EstadoViaje().GetById(pId)
        estadoViaje.Id = datatable.Rows(0).ItemArray(0).ToString()
        estadoViaje.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        Return estadoViaje
    End Function
End Class
