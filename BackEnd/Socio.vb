Public Class Socio
    Public Function GetById(pId As Int16) As EL.Socio
        Return New DAL.Socio().GetById(pId)
    End Function

    Public Function Listar() As List(Of EL.Socio)
        Return New DAL.Socio().Listar()
    End Function

    Public Sub Guardar(cliente As EL.Socio)
        Dim p As New Persona()
        p.Guardar(cliente)
        Dim e As New DAL.Socio()
        e.Guardar(cliente)

    End Sub

    Public Sub Quitar(cliente As EL.Socio)
        Dim e As New DAL.Socio()
        e.Quitar(cliente)
    End Sub

End Class
