Public Class Domicilio
    Public Function GetById(pId As Int16) As EL.Domicilio
        Dim con As New Conexion
        Dim domicilio As New EL.Domicilio()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Domicilio a where id_domicilio = " & pId)
        con.adp.Fill(datatable)
        domicilio.Id = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.Calle = datatable.Rows(0).ItemArray(2).ToString()
        domicilio.Nro = datatable.Rows(0).ItemArray(3).ToString()
        domicilio.Dpto = datatable.Rows(0).ItemArray(4).ToString()
        domicilio.Piso = datatable.Rows(0).ItemArray(5).ToString()
        domicilio.CP = datatable.Rows(0).ItemArray(6).ToString()
        domicilio.Localidad = datatable.Rows(0).ItemArray(7).ToString()
        domicilio.Provincia = datatable.Rows(0).ItemArray(8).ToString()
        Return domicilio
    End Function

    Public Function GetByPersonaId(pId As Int16) As List(Of EL.Domicilio)
        Dim con As New Conexion
        Dim domicilios As New List(Of EL.Domicilio)
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Domicilio a where id_persona = " & pId)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            domicilios.Add(New Domicilio().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return domicilios
    End Function
End Class
