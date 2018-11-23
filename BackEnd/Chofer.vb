Public Class Chofer
    Public Function Listar() As List(Of EL.Chofer)
        Return New DAL.Chofer().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Chofer
        Return New DAL.Chofer().GetById(pId)
    End Function

    Public Sub Guardar(chofer As EL.Chofer)
        Dim registrarUsuario As Boolean = (chofer.Id <= 0)

        Dim p As New Persona()
        p.Guardar(chofer)

        Dim e As New DAL.Chofer()
        e.Guardar(chofer)

        If registrarUsuario Then
            Dim u As New DAL.Usuario()
            chofer.Usuario = chofer.NroDocumento
            chofer.Password = chofer.NroDocumento
            chofer.Permisos = New List(Of EL.Permiso)
            chofer.Permisos.Add(New Permiso().GetById("C"))
            u.Guardar(chofer)
        End If

    End Sub

    Public Sub Quitar(chofer As EL.Chofer)
        Dim e As New DAL.Chofer()
        e.Quitar(chofer)
    End Sub

End Class
