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

    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from tipos_estado_viaje where id_estado = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

End Class
