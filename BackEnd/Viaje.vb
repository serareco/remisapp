Public Class Viaje
    Public Function MostrarEnCurso()
        Return New DAL.Viaje().MostrarEnCurso()
    End Function

    Public Function GetProximoViajePendiente() As EL.Viaje
        Return New EL.Viaje()
    End Function

    Public Function GetProximoViajeVuelta() As EL.Viaje
        Return New EL.Viaje()
    End Function

    Public Function Listar() As List(Of EL.Viaje)
        Return New DAL.Viaje().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Viaje
        Return New DAL.Viaje().GetById(pId)
    End Function

    Public Function MostrarHistorico()
        Return New DAL.Viaje().MostrarHistorico()
    End Function

    Public Sub Guardar(viaje As EL.Viaje)
        Dim e As New DAL.Viaje()
        e.Guardar(viaje)
    End Sub

    Public Sub ConsultarAPI(ByRef viaje As EL.Viaje)
        Dim request As New MapService.MapServiceRequest()
        request.From = viaje.Origen
        request.Dest = viaje.Destino

        Dim response As MapService.MapServiceResponse = request.SendRequest()

        viaje.KmRecorridos = response.Distance

    End Sub

End Class
