Public Class Chofer
    Public Function Listar() As List(Of EL.Chofer)
        Return New DAL.Chofer().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Chofer
        Return New DAL.Chofer().GetById(pId)
    End Function

    Public Sub Guardar(chofer As EL.Chofer)
        Dim e As New DAL.Chofer()
        Dim u As New EL.Usuario()
        Dim au As New DAL.Usuario()
        e.Guardar(chofer)
        u.Usuario = chofer.NroDocumento
        u.Password = chofer.NroDocumento
        u.Telefono = chofer.Telefono
        u.Nombre = chofer.Nombre
        u.Apellido = chofer.Apellido
        u.NroDocumento = chofer.NroDocumento
        u.FechaNacimiento = chofer.FechaNacimiento
        u.Domicilio = chofer.Domicilio
        u.Email = chofer.Email
        u.Permisos = New List(Of EL.Permiso)
        u.Permisos.Add(New BLL.Permiso().GetById("C"))
        au.Guardar(u)
    End Sub

    Public Sub Quitar(chofer As EL.Chofer)
        Dim e As New DAL.Chofer()
        e.Quitar(chofer)
    End Sub

End Class
