Public Class Turno
    Dim turnoDAL As New DAL.Turno()
    Public Function Listar() As List(Of EL.Turno)
        Return turnoDAL.Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Turno
        Return turnoDAL.GetById(pId)
    End Function

    Public Sub Guardar(turno As EL.Turno)
        turnoDAL.Guardar(turno, Login.UsuarioConectado)
    End Sub

    Public Sub Quitar(turno As EL.Turno)
        turnoDAL.Quitar(turno, Login.UsuarioConectado)
    End Sub

End Class
