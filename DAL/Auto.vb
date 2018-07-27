Public Class Auto

    Public Function Mostrar() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("
        Select a.id_auto, am.descripcion Marca,amo.descripcion Modelo,a.Patente,a.Anio_Fabricacion,a.Chasis,a.Motor
         From dbo.Autos a inner join Autos_Modelos amo 
         on a.id_Modelo = amo.id_modelo 
         Inner Join Autos_Marcas am on 
         amo.id_Marca = am.id_marca and amo.id_marca = am.id_marca
        Where a.estado = 'A'")

        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarDisponibles() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("
Select 0 id_auto,'Seleccione una opción' descripcion union
select a.id_auto, a.Patente +' - '+ am.descripcion + ' ' + amo.descripcion descripcion
 From dbo.Autos a inner join Autos_Modelos amo 
 on a.id_Modelo = amo.id_modelo 
 Inner Join Autos_Marcas am on 
 amo.id_Marca = am.id_marca and amo.id_marca = am.id_marca 
Where a.estado = 'A' ")

        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarMarcas() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("Select 0 id_marca,'Seleccione una opción' descripcion union Select * From dbo.Autos_Marcas")
        con.adp.Fill(datatable)
        Return datatable
    End Function
    Public Function MostrarModelos(pIdMarca As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("Select 0 id_marca, 0 id_modelo, 'Seleccione una opción' descripcion union Select * From dbo.Autos_Modelos where id_marca = " & pIdMarca.ToString())
        con.adp.Fill(datatable)
        Return datatable
    End Function
    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from Autos where id_auto = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function
    Public Sub Guardar(auto As EL.Auto)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Id_Auto", auto.Id))
        parametros.Add(New SqlClient.SqlParameter("@Id_Marca", auto.Marca))
        parametros.Add(New SqlClient.SqlParameter("@Id_Modelo", auto.Modelo))
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
