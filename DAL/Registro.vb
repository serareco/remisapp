Public Class Registro
    Public Function GetByChoferId(pId As String) As EL.Registro
        Dim registro As New EL.Registro()
        GetById(pId, registro)
        Return registro
    End Function

    Public Sub GetById(pId As Int16, ByRef pRegistro As EL.Registro)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select fecha_vencimiento,categoria from dbo.Registro where id_persona = " & pId)
        con.adp.Fill(datatable)
        pRegistro.FechaVencimiento = datatable.Rows(0).ItemArray(0).ToString()
        pRegistro.Categoria = datatable.Rows(0).ItemArray(1).ToString()
    End Sub
End Class
