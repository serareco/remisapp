﻿Imports BackEnd
Public Class FormViajesHistorico
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormViajesHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvViajes.DataSource = Nothing
        dgvViajes.DataSource = New Viaje().MostrarHistorico()
    End Sub
End Class