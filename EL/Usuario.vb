﻿Public Class Usuario
    Inherits Persona
    Public Sub New()
    End Sub
    Public Sub New(personBase As Persona)
        Id = personBase.Id
        Nombre = personBase.Nombre
        NroDocumento = personBase.NroDocumento
        FechaNacimiento = personBase.FechaNacimiento
        Apellido = personBase.Apellido
        Email = personBase.Email
        Telefono = personBase.Telefono
        Domicilio = personBase.Domicilio
    End Sub

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Private _permisos As List(Of Permiso)
    Public Property Permisos() As List(Of Permiso)
        Get
            Return _permisos
        End Get
        Set(ByVal value As List(Of Permiso))
            _permisos = value
        End Set
    End Property

End Class
