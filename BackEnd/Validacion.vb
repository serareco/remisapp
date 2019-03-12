Imports System.Text.RegularExpressions
Public Module Validacion
    Public Function FormatoEmail(pTexto As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(pTexto)
    End Function
    Public Function FormatoNumeros(pTexto As String) As Boolean
        Static numbersExpression As New Regex("[^\\d,\\d]")
        Return numbersExpression.IsMatch(pTexto)
    End Function
    Public Function RangoNumeros(pValor As String, pRangoInferior As Decimal, pRangoSuperior As Decimal) As Boolean
        If FormatoNumeros(pValor) Then
            Return CType(pValor, Decimal) >= pRangoInferior And CType(pValor, Decimal) <= pRangoSuperior
        Else
            Return False
        End If
    End Function
    Public Function DatoObligatorioVacio(pValor As String, pValorNull As Object) As Boolean
        Return pValor = pValorNull
    End Function
    Public Function ValoresIguales(pTexto As String, pTexto2 As String) As Boolean
        Return pTexto = pTexto2
    End Function
End Module
