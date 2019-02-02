Public Class Socio
    Public Function GetById(pId As Int16) As EL.Socio
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from dbo.Socio where id_persona = " & pId)
        con.adp.Fill(datatable)
        If (datatable.Rows.Count > 0) Then
            Dim socio As New EL.Socio(New Persona().GetById(pId))
            socio.NroSocio = datatable.Rows(0).ItemArray(1).ToString()
            socio.FechaAsociado = datatable.Rows(0).ItemArray(2).ToString()
            Return socio
        Else
            Return Nothing
        End If

    End Function

    Public Function Listar() As List(Of EL.Socio)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim socios As New List(Of EL.Socio)
        con.EjecutarConsulta("select id_persona from dbo.Socio where estado = 'A'")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            socios.Add(New Socio().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return socios
    End Function

    Public Sub Guardar(socio As EL.Socio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", socio.Id))
        con.EjecutarStoredProcedure("dbo.GuardarSocio", parametros)
    End Sub

    Public Sub Quitar(socio As EL.Socio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", socio.Id))
        con.EjecutarStoredProcedure("dbo.QuitarSocio", parametros)
    End Sub

End Class
