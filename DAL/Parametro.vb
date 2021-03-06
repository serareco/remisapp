﻿Public Class Parametro
    Public Function GetById(pId As Int16) As EL.Parametro
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Parametro where id_parametro = " & pId)
        con.adp.Fill(datatable)
        Dim parametro As New EL.Parametro()
        parametro.Id = datatable.Rows(0).ItemArray(0).ToString()
        parametro.Clave = datatable.Rows(0).ItemArray(1).ToString()
        parametro.Valor = datatable.Rows(0).ItemArray(2).ToString()
        parametro.VigenciaDesde = datatable.Rows(0).ItemArray(3).ToString()
        If Not datatable.Rows(0).ItemArray(4).ToString() = "" Then
            parametro.VigenciaHasta = datatable.Rows(0).ItemArray(4).ToString()
        End If
        Return parametro
    End Function

    Public Function GetValueByKey(pclave As String) As String
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("Select valor From dbo.Parametro Where clave = '" & pclave + "' and estado = 'A' and GETDATE() >= vigencia_desde  and  (GETDATE() <= vigencia_hasta or vigencia_hasta IS NULL)")
        con.adp.Fill(datatable)
        Return datatable.Rows(0).ItemArray(0).ToString()
    End Function

    Public Function Listar(Optional pTipoConsulta As Char = "D") As List(Of EL.Parametro)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim parametros As New List(Of EL.Parametro)
        If pTipoConsulta = "V" Then
            con.EjecutarConsulta("select * From dbo.Parametro where estado IN ('A') and (vigencia_hasta >= GETDATE() Or vigencia_hasta IS NULL) ")
        ElseIf pTipoConsulta = "D" Then
            con.EjecutarConsulta("select * From dbo.Parametro where estado IN ('A') ")
        End If
        con.adp.Fill(datatable)

        For index = 0 To datatable.Rows.Count - 1
            parametros.Add(New Parametro().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return parametros
    End Function

    Public Sub Guardar(parametro As EL.Parametro, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametrosSQL As New List(Of SqlClient.SqlParameter)
        parametrosSQL.Add(New SqlClient.SqlParameter("@id_parametro", parametro.Id))
        parametrosSQL.Add(New SqlClient.SqlParameter("@clave", parametro.Clave))
        parametrosSQL.Add(New SqlClient.SqlParameter("@valor", parametro.Valor))
        parametrosSQL.Add(New SqlClient.SqlParameter("@vigencia_desde", parametro.VigenciaDesde))
        If parametro.VigenciaHasta <> DateTime.MinValue Then
            parametrosSQL.Add(New SqlClient.SqlParameter("@vigencia_hasta", parametro.VigenciaHasta))
        End If
        parametrosSQL.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.GuardarParametro", parametrosSQL)
    End Sub

    Public Sub Quitar(parametro As EL.Parametro, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametrosSQL As New List(Of SqlClient.SqlParameter)
        parametrosSQL.Add(New SqlClient.SqlParameter("@id_parametro", parametro.Id))
        parametrosSQL.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.QuitarParametro", parametrosSQL)
    End Sub
End Class
