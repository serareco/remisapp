Public Class Registro
    Public Function GetById(pId As Int16) As EL.Registro
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select fecha_vencimiento,categoria from dbo.Registro where id_persona = " & pId)
        con.adp.Fill(datatable)
        Dim registro As New EL.Registro()
        registro.FechaVencimiento = datatable.Rows(0).ItemArray(0).ToString()
        registro.Categoria = datatable.Rows(0).ItemArray(1).ToString()
        Return registro
    End Function
End Class
