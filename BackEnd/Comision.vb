Public Class Comision
    Dim comisionDAL As New DAL.Comision()
    Public Function Listar() As List(Of EL.Comision)
        Return comisionDAL.Listar("D")
    End Function

    Public Function ListarVigentes() As List(Of EL.Comision)
        Return comisionDAL.Listar("V")
    End Function

    Public Function GetById(pId As Int16) As EL.Comision
        Return comisionDAL.GetById(pId)
    End Function

    Public Function GetDefault() As EL.Comision
        Return comisionDAL.GetDefault()
    End Function

    Public Sub Guardar(comision As EL.Comision)
        comisionDAL.Guardar(comision, Login.UsuarioConectado)
    End Sub

    Public Sub Quitar(comision As EL.Comision)
        comisionDAL.Quitar(comision, Login.UsuarioConectado)
    End Sub
End Class
