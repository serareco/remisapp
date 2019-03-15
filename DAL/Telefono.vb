Public Class Telefono
    Public Function GetById(pId As Int16) As EL.Telefono
        Dim con As New Conexion
        Dim telefono As New EL.Telefono()
        Dim tipoTelefonoService As New TipoTelefono()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Telefono a where id_telefono = " & pId)
        con.adp.Fill(datatable)
        telefono.Id = datatable.Rows(0).ItemArray(0).ToString()
        telefono.TipoTelefono = tipoTelefonoService.GetById(datatable.Rows(0).ItemArray(2).ToString())
        telefono.CodigoPais = datatable.Rows(0).ItemArray(3).ToString()
        telefono.CodigoArea = datatable.Rows(0).ItemArray(4).ToString()
        telefono.Numero = datatable.Rows(0).ItemArray(5).ToString()
        Return telefono
    End Function

    Public Sub GetById(ByRef pTelefono As EL.Telefono)
        Dim con As New Conexion
        Dim tipoTelefonoService As New TipoTelefono()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Telefono a where id_telefono = " & pTelefono.Id)
        con.adp.Fill(datatable)
        pTelefono.Id = datatable.Rows(0).ItemArray(0).ToString()
        pTelefono.TipoTelefono = tipoTelefonoService.GetById(datatable.Rows(0).ItemArray(2).ToString())
        pTelefono.CodigoPais = datatable.Rows(0).ItemArray(3).ToString()
        pTelefono.CodigoArea = datatable.Rows(0).ItemArray(4).ToString()
        pTelefono.Numero = datatable.Rows(0).ItemArray(5).ToString()
    End Sub

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

    Public Sub GetByPersonaId(pId As Int16, ByRef pTelefono As EL.Telefono)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select id_telefono from dbo.Telefono a where id_persona = " & pId)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            pTelefono.Id = datatable.Rows(index).ItemArray(0).ToString()
            GetById(pTelefono)
        Next
    End Sub

End Class
