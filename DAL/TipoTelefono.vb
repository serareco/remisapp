Public Class TipoTelefono
    Public Sub GetById(pId As Int16, ByRef tipoTelefono As EL.TipoTelefono)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Tipo_telefono a where id_tipo_telefono = " & pId)
        con.adp.Fill(datatable)
        tipoTelefono.Id = datatable.Rows(0).ItemArray(0).ToString()
        tipoTelefono.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
    End Sub

    Public Function GetById(pId As String) As EL.TipoTelefono
        Dim tipoTelefono As New EL.TipoTelefono()
        GetById(pId, tipoTelefono)
        Return tipoTelefono
    End Function

    Public Function Listar() As List(Of EL.TipoTelefono)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim tiposTelefono As New List(Of EL.TipoTelefono)
        con.EjecutarConsulta("
        select * from dbo.Tipo_telefono")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            tiposTelefono.Add(New TipoTelefono().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return tiposTelefono
    End Function
End Class