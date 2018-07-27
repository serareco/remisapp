Public Module Login
    Public Function Login(pDatosLogin As EL.Login) As Boolean
        Return New DAL.Login().Login(pDatosLogin)
    End Function

End Module
