Public Class EstadoViaje
    Public Function Listar(Optional pTipoEstado = "D") As List(Of EL.EstadoViaje)
        Dim con As New Conexion
        Dim estados As New List(Of EL.EstadoViaje)()
        Dim datatable As New DataTable
        If pTipoEstado = "D" Then
            con.EjecutarConsulta(" Select 0 id_estado,'Seleccione una opción' descripcion 
                                    union 
                                   Select id_estado,descripcion from Tipo_Estado_Viaje")
        ElseIf pTipoEstado = "A" Then
            con.EjecutarConsulta(" Select 0 id_estado,'Seleccione una opción' descripcion 
                                    union 
                                   Select id_estado,descripcion from Tipo_Estado_Viaje where grupo = 'Alta'")
        ElseIf pTipoEstado = "F" Then
            con.EjecutarConsulta(" Select 0 id_estado,'Seleccione una opción' descripcion 
                                    union 
                                   Select id_estado,descripcion from Tipo_Estado_Viaje where grupo = 'Fin'")
        End If
        con.adp.Fill(datatable)

        For index = 0 To datatable.Rows.Count - 1
            If index = 0 Then
                estados.Add(New EL.EstadoViaje() With {
                    .Id = datatable.Rows(index).ItemArray(0).ToString(),
                    .Descripcion = datatable.Rows(index).ItemArray(1).ToString()
                })
            Else
                estados.Add(New EstadoViaje().GetById(datatable.Rows(index).ItemArray(0).ToString()))
            End If
        Next
        Return estados
    End Function

    Public Function GetById(pId As Int16) As EL.EstadoViaje
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim estadoViaje As New EL.EstadoViaje()
        con.EjecutarConsulta("Select id_estado,descripcion  from dbo.Tipo_estado_viaje where id_estado = " & pId)
        con.adp.Fill(datatable)
        estadoViaje.Id = datatable.Rows(0).ItemArray(0).ToString()
        estadoViaje.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        Return estadoViaje
    End Function

End Class
