Public Class Rol
    Public Function Listar() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        select id_rol,descripcion
        from Roles 
        where estado = 'A' ")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function GetById(pId As String) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from dbo.roles where id_rol = '" + pId + "'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

End Class
