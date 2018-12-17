Public Class FrmLogin
    Public MostrarSalida As Boolean
    Public MostrarArribo As Boolean
    Private Sub Ingresar()
        Dim datosLogin As New EL.Login()
        datosLogin.Usuario = New EL.Usuario() With {.Usuario = TxtUsuario.Text(), .Password = TxtPassword.Text()}
        If (BLL.Login.Login(datosLogin.Usuario)) Then
            LblMsjValidacion.Text() = ""
            If (MostrarSalida Or MostrarArribo) And Not BLL.Login.EsChofer() Then
                LblMsjValidacion.Text() = "No puede informar la salida del servicio." + vbCrLf + "El usuario no es Chofer."
                TxtUsuario.Text() = ""
                TxtPassword.Text() = ""
            ElseIf MostrarSalida And BLL.Login.EsChofer() Then
                FormSalida.Show()
                Me.Close()
            ElseIf MostrarArribo And BLL.Login.EsChofer() Then
                FormArribo.Show()
                Me.Close()
            ElseIf ChkChangePss.Checked Then
                FormCambiarPassword.Show()
                Me.Close()
            ElseIf BLL.Login.EsChofer() Then
                FormPrincipalChoferes.Show()
                Me.Close()
            ElseIf Not (MostrarSalida Or MostrarArribo) Then
                FormPrincipal.Show()
                Me.Close()
            End If
        Else
            LblMsjValidacion.Text() = "Usuario/Password incorrecto."
            TxtUsuario.Text() = ""
            TxtPassword.Text() = ""
        End If
    End Sub
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Ingresar()
    End Sub

    Private Sub TxtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyUp
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Ingresar()
        End If
    End Sub

    Private Sub TxtUsuario_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyUp
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Ingresar()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (MostrarSalida Or MostrarArribo) Then
            ChkChangePss.Enabled = False
        End If
    End Sub
End Class
