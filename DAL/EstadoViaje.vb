Public Class EstadoViaje
    Public Function MostrarAlta() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_estado,'Seleccione una opción' descripcion union         
        select id_estado,descripcion from Tipos_Estado_Viaje where grupo = 'Alta'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarFin() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_estado,'Seleccione una opción' descripcion union         
        select id_estado,descripcion from Tipos_Estado_Viaje where grupo = 'Fin'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function GetById(pId As Int16) As EL.EstadoViaje
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim estadoViaje As New EL.EstadoViaje()
        con.EjecutarConsulta("select * from dbo.Tipo_estado_viaje where id_estado = " & pId)
        con.adp.Fill(datatable)
        estadoViaje.Id = datatable.Rows(0).ItemArray(0).ToString()
        estadoViaje.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        Return estadoViaje
    End Function

End Class
