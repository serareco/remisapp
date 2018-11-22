Public Class Domicilio
    Public Function GetById(pId As Int16) As EL.Domicilio
        Dim con As New Conexion
        Dim domicilio As New EL.Domicilio()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Domicilio a where id_persona = " & pId)
        con.adp.Fill(datatable)

        domicilio.Calle = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.Nro = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.Piso = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.CP = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.Localidad = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.Provincia = datatable.Rows(0).ItemArray(0).ToString()
        domicilio.Dpto = datatable.Rows(0).ItemArray(0).ToString()
        Return domicilio
    End Function
End Class
