Public Class Auto
    Public Function Listar() As List(Of EL.Auto)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim autos As New List(Of EL.Auto)
        con.EjecutarConsulta("Select a.id_auto
                                From dbo.Autos a
                               Where a.estado = 'A'")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            autos.Add(New Auto().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return autos
    End Function

    Public Function GetById(pId As Int16) As EL.Auto
        Dim con As New Conexion
        Dim auto As New EL.Auto()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from Autos a where a.estado = 'A' and id_auto = " & pId)
        con.adp.Fill(datatable)

        auto.Id = datatable.Rows(0).ItemArray(0).ToString()
        auto.Modelo = New Modelo().GetById(datatable.Rows(0).ItemArray(1).ToString())
        auto.AnioFabricacion = datatable.Rows(0).ItemArray(2).ToString()
        auto.Patente = datatable.Rows(0).ItemArray(3).ToString()
        auto.Motor = datatable.Rows(0).ItemArray(4).ToString()
        auto.Chasis = datatable.Rows(0).ItemArray(5).ToString()
        Return auto
    End Function

    Public Sub Guardar(auto As EL.Auto)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Id_Auto", auto.Id))
        parametros.Add(New SqlClient.SqlParameter("@Id_Modelo", auto.Modelo.Id))
        parametros.Add(New SqlClient.SqlParameter("@Anio_Fabricacion", auto.AnioFabricacion))
        parametros.Add(New SqlClient.SqlParameter("@Patente", auto.Patente))
        parametros.Add(New SqlClient.SqlParameter("@Chasis", auto.Chasis))
        parametros.Add(New SqlClient.SqlParameter("@Motor", auto.Motor))

        con.EjecutarStoredProcedure("dbo.GuardarAuto", parametros)
    End Sub

    Public Sub Quitar(auto As EL.Auto)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_auto", auto.Id))
        con.EjecutarStoredProcedure("dbo.QuitarAuto", parametros)
        'TODO: TIENE CHOFER ASOCIADO!
    End Sub
End Class
