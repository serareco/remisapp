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
            usuario.Domicilio = DataTable.Rows(0).ItemArray(3).ToString()
            usuario.Email = DataTable.Rows(0).ItemArray(4).ToString()
            usuario.Telefono = DataTable.Rows(0).ItemArray(5).ToString()
            usuario.NroDocumento = DataTable.Rows(0).ItemArray(6).ToString()
            usuario.FechaNacimiento = DataTable.Rows(0).ItemArray(7).ToString()
        End If
        Return usuario
    End Function

End Class
