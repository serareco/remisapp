﻿Public Class Login
    Public Sub New()
        Usuario = New Usuario()
    End Sub

    Private _usuario As Usuario
    Public Property Usuario() As Usuario
        Get
            Return _usuario
        End Get
        Set(ByVal value As Usuario)
            _usuario = value
        End Set
    End Property
    Private _primerIngreso As Boolean
    Public Property PrimerIngreso() As Boolean
        Get
            Return _primerIngreso
        End Get
        Set(ByVal value As Boolean)
            _primerIngreso = value
        End Set
    End Property
    Private _ultimoIngreso As DateTime
    Public Property UltimoIngreso() As DateTime
        Get
            Return _ultimoIngreso
        End Get
        Set(ByVal value As Date)
            _ultimoIngreso = value
        End Set
    End Property
End Class
