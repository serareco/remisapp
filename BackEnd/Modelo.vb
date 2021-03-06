﻿Public Class Modelo
    Dim modeloDAL As New DAL.Modelo()
    Public Function GetById(pId As Int16) As EL.Modelo
        Dim modelo As New EL.Modelo()
        modeloDAL.GetById(pId, modelo)
        Return modelo
    End Function
    Public Function Listar() As List(Of EL.Modelo)
        Return modeloDAL.Listar()
    End Function
    Public Function Listar(pIdMarca As Int16)
        Return modeloDAL.Listar(pIdMarca)
    End Function
End Class
