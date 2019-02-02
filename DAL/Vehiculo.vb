Public Class Vehiculo
    Public Function Listar() As List(Of EL.Vehiculo)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim autos As New List(Of EL.Vehiculo)
        con.EjecutarConsulta("Select a.id_vehiculo
                                From dbo.Vehiculo a
                               Where a.estado = 'A'")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            autos.Add(New Vehiculo().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return autos
    End Function
    Public Function GetById(pId As Int16) As EL.Vehiculo
        Dim con As New Conexion
        Dim auto As New EL.Vehiculo()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Vehiculo a where id_vehiculo = " & pId)
        con.adp.Fill(datatable)

        auto.Id = datatable.Rows(0).ItemArray(0).ToString()
        auto.Modelo = New Modelo().GetById(datatable.Rows(0).ItemArray(1).ToString())
        auto.AnioFabricacion = datatable.Rows(0).ItemArray(2).ToString()
        auto.Patente = datatable.Rows(0).ItemArray(3).ToString()
        auto.Motor = datatable.Rows(0).ItemArray(4).ToString()
        auto.Chasis = datatable.Rows(0).ItemArray(5).ToString()
        Return auto
    End Function
    Public Sub Guardar(auto As EL.Vehiculo)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_vehiculo", auto.Id))
        parametros.Add(New SqlClient.SqlParameter("@id_modelo", auto.Modelo.Id))
        parametros.Add(New SqlClient.SqlParameter("@Anio_Fabricacion", auto.AnioFabricacion))
        parametros.Add(New SqlClient.SqlParameter("@Patente", auto.Patente))
        parametros.Add(New SqlClient.SqlParameter("@Chasis", auto.Chasis))
        parametros.Add(New SqlClient.SqlParameter("@Motor", auto.Motor))
        parametros.Add(New SqlClient.SqlParameter("@Fecha_Vencimiento_VTV", auto.Motor))
        con.EjecutarStoredProcedure("dbo.GuardarVehiculo", parametros)
    End Sub
    Public Sub Quitar(auto As EL.Vehiculo)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_vehiculo", auto.Id))
        con.EjecutarStoredProcedure("dbo.QuitarVehiculo", parametros)
    End Sub
End Class
