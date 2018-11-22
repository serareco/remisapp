Public Class Usuario
    Public Function MostrarLista() As DataTable
        Return New DAL.Usuario().MostrarLista()
    End Function

    Public Sub Guardar(usuario As EL.Usuario)
        Dim e As New DAL.Usuario()
        e.Guardar(usuario)
    End Sub

    Public Sub Quitar(usuario As EL.Usuario)
        Dim e As New DAL.Usuario()
        e.Quitar(usuario)
    End Sub

    Public Function GetByUsuario(pUsuario As String) As EL.Usuario
        Dim usuario As New EL.Usuario
        Dim datatable As DataTable = New DAL.Usuario().GetByUsuario(pUsuario)
        If (DataTable.Rows.Count > 0) Then
            usuario.Usuario = DataTable.Rows(0).ItemArray(0).ToString()
            usuario.Nombre = DataTable.Rows(0).ItemArray(1).ToString()
            usuario.Apellido = DataTable.Rows(0).ItemArray(2).ToString()
            usuario.Domicilio = New DAL.Domicilio().GetById(usuario.Id)
            usuario.Email = datatable.Rows(0).ItemArray(4).ToString()
            usuario.Telefono = DataTable.Rows(0).ItemArray(5).ToString()
            usuario.NroDocumento = DataTable.Rows(0).ItemArray(6).ToString()
            usuario.FechaNacimiento = DataTable.Rows(0).ItemArray(7).ToString()
        End If
        Dim datatableRoles As DataTable = New DAL.Usuario().GetRolesByUsuario(pUsuario)
        If (datatableRoles.Rows.Count > 0) Then
            usuario.Permisos = New List(Of EL.Permiso)
            For Each row As DataRow In datatableRoles.Rows
                usuario.Permisos.Add(New Permiso().GetById(row.ItemArray(1)))
            Next
        End If
        Return usuario
    End Function

End Class
