Public Class Telefono
    Public Function GetById(pId As Int16) As EL.Telefono
        Dim con As New Conexion
        Dim telefono As New EL.Telefono()
        Dim tipoTelefono As New TipoTelefono()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Telefono a where id_telefono = " & pId)
        con.adp.Fill(datatable)
        telefono.Id = datatable.Rows(0).ItemArray(0).ToString()
        tipoTelefono.GetById(datatable.Rows(0).ItemArray(2).ToString(), telefono.TipoTelefono)
        telefono.CodigoPais = datatable.Rows(0).ItemArray(3).ToString()
        telefono.CodigoArea = datatable.Rows(0).ItemArray(4).ToString()
        telefono.Numero = datatable.Rows(0).ItemArray(5).ToString()
        Return telefono
    End Function

    Public Function GetByPersonaId(pId As Int16) As List(Of EL.Telefono)
        Dim con As New Conexion
        Dim telefonos As New List(Of EL.Telefono)
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select id_telefono from dbo.Telefono a where id_persona = " & pId)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            telefonos.Add(New Telefono().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return telefonos
    End Function
End Class
