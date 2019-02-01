Public Class FormSeleccionSistema
    Private Sub BtnStarApp_Click(sender As Object, e As EventArgs) Handles BtnStarApp.Click
        If RbtnSeleccionSistemaATM.Checked Then
            FormATM.Show()
        ElseIf RbtnSeleccionSistemaOp.Checked Then
            FrmLogin.Show()
        End If
        Me.Close()
    End Sub
End Class
