Imports EL

Public Class Viaje
    Dim viajeDAL As New DAL.Viaje()
    Dim accionService As New Accion()
    Public Function GetProximoViajePendiente() As EL.Viaje
        Return viajeDAL.GetProximoViajePendiente()
    End Function

    Public Function GetProximoViajeVuelta() As EL.Viaje
        Return viajeDAL.GetProximoViajeVuelta
    End Function

    Public Function ListarMensual() As List(Of EL.Viaje)
        Return viajeDAL.Listar("M")
    End Function

    Public Sub RegistrarSalida(viaje As EL.Viaje, chofer As EL.Chofer)
        viaje.Chofer = chofer
        viaje.FechaSalida = Now
        viaje.FechaArriboEstimado = viaje.FechaSalida.AddMinutes(viaje.DuracionEstimada)
        viaje.Estado.Id = 1
        If viaje.Chofer.Id <> viaje.ChoferEstimado.Id Then
            ' TODO: ENUMERATOR - Tomar viaje de otro
            accionService.Guardar(chofer, accionService.GetById(2))
        ElseIf viaje.FechaSalida > viaje.FechaSalidaEstimada Then
            ' TODO: ENUMERATOR - Salir tarde
            accionService.Guardar(chofer, accionService.GetById(6))
        ElseIf viaje.FechaSalida <= viaje.FechaSalidaEstimada Then
            ' TODO: ENUMERATOR - Salir temprano
            accionService.Guardar(chofer, accionService.GetById(3))
        End If
        viajeDAL.Guardar(viaje)
    End Sub

    Public Sub RegistrarArribo(viaje As EL.Viaje)
        If viaje.FechaArribo < viaje.FechaArriboEstimado Then
            ' TODO: ENUMERATOR - Llegar tarde
            accionService.Guardar(viaje.Chofer, accionService.GetById(5))
        ElseIf viaje.FechaArribo <= viaje.FechaArriboEstimado Then
            ' TODO: ENUMERATOR - Llegar temprano
            accionService.Guardar(viaje.Chofer, accionService.GetById(4))
        ElseIf viaje.Estado.Id = 4 Then
            ' TODO: ENUMERATOR - Llegar temprano
            accionService.Guardar(viaje.Chofer, accionService.GetById(7))
        End If
        viajeDAL.Guardar(viaje)
    End Sub

    Public Function ListarEnCurso() As List(Of EL.Viaje)
        Return viajeDAL.Listar("C")
    End Function

    Public Function ListarPendientes() As List(Of EL.Viaje)
        Return viajeDAL.Listar("P")
    End Function

    Public Function ListarHistorico() As List(Of EL.Viaje)
        Return viajeDAL.Listar("H")
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
