Public Class Chofer
    Dim choferDAL As New DAL.Chofer()

    Public Function Listar() As List(Of EL.Chofer)
        Return choferDAL.Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Chofer
        Return choferDAL.GetById(pId)
    End Function

    Public Sub Guardar(chofer As EL.Chofer)
        Dim registrarUsuario As Boolean = (chofer.Id <= 0)
        Dim p As New Persona()
        p.Guardar(chofer)
        choferDAL.Guardar(chofer)
        If registrarUsuario Then
            Dim usuarioService As New Usuario()
            chofer.Usuario = chofer.NroDocumento
            chofer.Password = chofer.NroDocumento
            chofer.Permisos = New List(Of EL.Permiso)
            chofer.Permisos.Add(New Permiso().GetById("C"))
            usuarioService.Guardar(chofer)
        End If
    End Sub

    Public Sub Quitar(chofer As EL.Chofer)
        choferDAL.Quitar(chofer)
    End Sub

    Public Function ListarEnCondiciones() As List(Of EL.Chofer)
        Return choferDAL.ListarEnCondiciones()
    End Function

    Public Function ListarDisponibles(pFechaHora As DateTime) As List(Of EL.Chofer)
        Return choferDAL.ListarDisponibles(pFechaHora)
    End Function

    Public Sub TomarViaje(pViaje As EL.Viaje, pChofer As EL.Chofer)
        Dim viajeService As New Viaje()
        pViaje.Chofer = pChofer
        pViaje.FechaSalida = Now
        viajeService.RegistrarSalida(pViaje, pChofer)
    End Sub

End Class
