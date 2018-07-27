Public Class Viaje
    Public Function MostrarEnCurso()
        Return New DAL.Viaje().MostrarEnCurso()
    End Function

    Public Function MostrarHistorico()
        Return New DAL.Viaje().MostrarHistorico()
    End Function

    Public Function GetById(pId As Int16) As EL.Viaje
        Dim viaje As New EL.Viaje()
        Dim datatable As DataTable = New DAL.Viaje().GetById(pId)
        If (datatable.Rows.Count > 0) Then
            viaje.Id = datatable.Rows(0).ItemArray(0).ToString()
            viaje.Origen = datatable.Rows(0).ItemArray(1).ToString()
            viaje.Destino = datatable.Rows(0).ItemArray(2).ToString()
            viaje.FechaSalida = datatable.Rows(0).ItemArray(3).ToString()
            If (datatable.Rows(0).ItemArray(4).ToString() <> "") Then
                viaje.FechaArribo = datatable.Rows(0).ItemArray(4).ToString()
            End If
            If (datatable.Rows(0).ItemArray(5).ToString() <> "") Then
                viaje.KmRecorridos = datatable.Rows(0).ItemArray(5).ToString()
            End If
            viaje.Comentarios = datatable.Rows(0).ItemArray(6).ToString()
            If (datatable.Rows(0).ItemArray(7).ToString() <> "") Then
                viaje.Cliente = New Cliente().GetById(datatable.Rows(0).ItemArray(7).ToString())
            End If
            If (datatable.Rows(0).ItemArray(8).ToString() = "S") Then
                viaje.IdaYVuelta = True
            Else
                viaje.IdaYVuelta = False
            End If
            If (datatable.Rows(0).ItemArray(9).ToString() <> "") Then
                viaje.Chofer = New Chofer().GetById(datatable.Rows(0).ItemArray(9).ToString())
            End If
            viaje.Estado = New EstadoViaje().GetById(datatable.Rows(0).ItemArray(10).ToString())
            If (datatable.Rows(0).ItemArray(11).ToString() <> "") Then
                viaje.Precio = datatable.Rows(0).ItemArray(11).ToString()
            End If
        End If
        Return viaje
    End Function

    Public Sub Guardar(viaje As EL.Viaje)
        Dim e As New DAL.Viaje()
        e.Guardar(viaje)
    End Sub

End Class
