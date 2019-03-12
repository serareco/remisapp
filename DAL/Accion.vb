Imports EL

Public Class Accion

    Public Function Listar() As List(Of EL.Accion)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim acciones As New List(Of EL.Accion)
        con.EjecutarConsulta("select * From dbo.Accion where estado IN ('A') and (vigencia_hasta >= GETDATE() Or vigencia_hasta IS NULL) ")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            acciones.Add(New Accion().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return acciones
    End Function

    Public Function GetById(pId As Short) As EL.Accion
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Accion where id_accion = " & pId)
        con.adp.Fill(datatable)
        Dim accion As New EL.Accion()
        accion.Id = datatable.Rows(0).ItemArray(0).ToString()
        accion.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        accion.Puntos = datatable.Rows(0).ItemArray(2).ToString()
        accion.VigenciaDesde = datatable.Rows(0).ItemArray(3).ToString()
        If Not datatable.Rows(0).ItemArray(4).ToString() = "" Then
            accion.VigenciaHasta = datatable.Rows(0).ItemArray(4).ToString()
        End If
        Return accion
    End Function

    Public Sub Guardar(pAccion As EL.Accion, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_accion", pAccion.Id))
        parametros.Add(New SqlClient.SqlParameter("@puntaje", pAccion.Puntos))
        parametros.Add(New SqlClient.SqlParameter("@descripcion", pAccion.Descripcion))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_desde", pAccion.VigenciaDesde))
        If pAccion.VigenciaHasta <> DateTime.MinValue Then
            parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", pAccion.VigenciaHasta))
        End If
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.GuardarAccion", parametros)
    End Sub

    Public Sub Guardar(pChofer As EL.Chofer, pAccion As EL.Accion)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_accion", pAccion.Id))
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", pChofer.Id))
        con.EjecutarStoredProcedure("dbo.GuardarChoferAccion", parametros)
    End Sub

    Public Sub Quitar(pAccion As EL.Accion, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_accion", pAccion.Id))
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.QuitarAccion", parametros)
    End Sub

End Class
