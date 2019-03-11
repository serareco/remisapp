Imports System.Windows.Forms

Public Class FormPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Private Sub OpcionViajesCurso_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpcionViajesCurso.Click
        FormViajes.MdiParent = Me
        FormViajes.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub OpcionConsultaHistorico_Click(sender As Object, e As EventArgs) Handles OpcionConsultaHistorico.Click
        FormViajesHistorico.MdiParent = Me
        FormViajesHistorico.Show()
    End Sub

    Private Sub OpcionAutos_Click(sender As Object, e As EventArgs) Handles OpcionAutos.Click
        FormVehiculos.MdiParent = Me
        FormVehiculos.Show()
    End Sub

    Private Sub OpcionChoferes_Click(sender As Object, e As EventArgs) Handles OpcionChoferes.Click
        FormChoferes.MdiParent = Me
        FormChoferes.Show()
    End Sub

    Private Sub OpcionSocios_Click(sender As Object, e As EventArgs) Handles OpcionSocios.Click
        FormSocios.MdiParent = Me
        FormSocios.Show()
    End Sub

    Private Sub OpcionUsuarios_Click(sender As Object, e As EventArgs) Handles OpcionUsuarios.Click
        FormUsuarios.MdiParent = Me
        FormUsuarios.Show()
    End Sub

    Private Sub OpcionComisiones_Click(sender As Object, e As EventArgs) Handles OpcionComisiones.Click
        FormComisiones.MdiParent = Me
        FormComisiones.Show()
    End Sub

    Private Sub OpcionBeneficios_Click(sender As Object, e As EventArgs) Handles OpcionBeneficios.Click
        FormBeneficios.MdiParent = Me
        FormBeneficios.Show()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MenuABMC.Visible = False
        Me.MenuViajes.Visible = False
        Me.MenuReportes.Visible = False
        Me.MenuConsultas.Visible = False

        Me.OpcionChoferes.Visible = False
        Me.OpcionComisiones.Visible = False
        Me.OpcionBeneficios.Visible = False
        Me.OpcionUsuarios.Visible = False
        Me.OpcionAutos.Visible = False
        Me.OpcionViajesCurso.Visible = False
        Me.OpcionSocios.Visible = False
        Me.OpcionReportesViajes.Visible = False
        Me.OpcionChoferComision.Visible = False
        Me.OpcionReporteComisionChoferes.Visible = False
        Me.OpcionParametrosSistema.Visible = False
        Me.OpcionViajesPendientes.Visible = False
        Me.OpcionViajesRealizados.Visible = False
        Me.OpcionComisionesChofer.Visible = False
        Me.OpcionPuntajeChoferes.Visible = False

        If BLL.Login.EsAdministrador() Then
            Me.MenuABMC.Visible = True
            Me.OpcionUsuarios.Visible = True
        End If

        If BLL.Login.EsResponsable() Then
            Me.MenuABMC.Visible = True
            Me.OpcionChoferes.Visible = True
            Me.OpcionBeneficios.Visible = True
            Me.OpcionAutos.Visible = True
        End If

        If BLL.Login.EsOperador() Then
            Me.MenuViajes.Visible = True
            Me.MenuABMC.Visible = True
            Me.OpcionSocios.Visible = True
            Me.OpcionViajesCurso.Visible = True
            Me.OpcionConsultaHistorico.Visible = True
        End If

        If BLL.Login.EsGerente() Then
            Me.MenuViajes.Visible = True
            Me.MenuABMC.Visible = True
            Me.MenuReportes.Visible = True
            Me.OpcionChoferComision.Visible = True
            Me.OpcionComisiones.Visible = True
            Me.OpcionConsultaHistorico.Visible = True
            Me.OpcionReporteComisionChoferes.Visible = True
            Me.OpcionReportesViajes.Visible = True
            Me.OpcionParametrosSistema.Visible = True
            Me.OpcionPuntajeChoferes.Visible = True
        End If

        If BLL.Login.EsChofer() Then
            Me.MenuConsultas.Visible = True
            Me.OpcionViajesPendientes.Visible = True
            Me.OpcionViajesRealizados.Visible = True
            Me.OpcionComisionesChofer.Visible = True
        End If

        LogInformation.Text() = BLL.Login.GetInforamcionUsuario()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        BLL.Login.Disconnect()
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub OpcionChoferComision_Click(sender As Object, e As EventArgs) Handles OpcionChoferComision.Click
        FormChoferComision.MdiParent = Me
        FormChoferComision.Show()
    End Sub

    Private Sub OpcionReportesViajes_Click(sender As Object, e As EventArgs) Handles OpcionReportesViajes.Click
        FormReporteViajesMensuales.MdiParent = Me
        FormReporteViajesMensuales.Show()
    End Sub

    Private Sub OpcionReporteComisionChoferes_Click(sender As Object, e As EventArgs) Handles OpcionReporteComisionChoferes.Click
        FormReporteComisiones.MdiParent = Me
        FormReporteComisiones.Show()
    End Sub

    Private Sub OpcionParametrosSistema_Click(sender As Object, e As EventArgs) Handles OpcionParametrosSistema.Click
        FormParametrosSistema.MdiParent = Me
        FormParametrosSistema.Show()
    End Sub

    Private Sub OpcionPuntajeChoferes_Click(sender As Object, e As EventArgs) Handles OpcionPuntajeChoferes.Click
        FormConsultaPuntosChofer.MdiParent = Me
        FormConsultaPuntosChofer.Show()
    End Sub
End Class
