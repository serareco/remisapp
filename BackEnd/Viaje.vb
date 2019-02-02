Public Class Viaje
    Public Function GetProximoViajePendiente() As EL.Viaje
        Return New DAL.Viaje().GetProximoViajePendiente()
    End Function

    Public Function GetProximoViajeVuelta() As EL.Viaje
        Return New DAL.Viaje().GetProximoViajeVuelta
    End Function

    Public Function ListarMensual() As List(Of EL.Viaje)
        Return New DAL.Viaje().Listar("M")
    End Function

    Public Function ListarEnCurso() As List(Of EL.Viaje)
        Return New DAL.Viaje().Listar("C")
    End Function

    Public Function ListarPendientes() As List(Of EL.Viaje)
        Return New DAL.Viaje().Listar("P")
    End Function

    Public Function ListarHistorico() As List(Of EL.Viaje)
        Return New DAL.Viaje().Listar("H")
    End Function

    Public Function Listar() As List(Of EL.Viaje)
        Return New DAL.Viaje().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Viaje
        Return New DAL.Viaje().GetById(pId)
    End Function

    Public Sub Guardar(viaje As EL.Viaje)
        Dim e As New DAL.Viaje()
        e.Guardar(viaje)
    End Sub
    Public Sub SetBeneficios(ByRef pViaje As EL.Viaje)
        pViaje.Beneficios = New Beneficio().Verificar(pViaje.Socio.Id)
    End Sub
    Public Function PorcDescBeneficios(pViaje As EL.Viaje) As Decimal
        Dim totalDescuentos As Decimal = 0
        For Each beneficio As EL.Beneficio In pViaje.Beneficios
            totalDescuentos += beneficio.Descuento
        Next
        Return totalDescuentos / 100
    End Function
    Public Sub ConsultarAPI(ByRef viaje As EL.Viaje)
        Dim request As New MapService.MapServiceRequest()
        request.From = viaje.Origen
        request.Dest = viaje.Destino

        Dim response As MapService.MapServiceResponse = request.SendRequest()
        viaje.DuracionEstimada = response.Time
        viaje.KmEstimados = response.Distance
        viaje.PrecioEstimado = viaje.KmEstimados * 26 'Deberia salir de los parámetros el valor
    End Sub

End Class
