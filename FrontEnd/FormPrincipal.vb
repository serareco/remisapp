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

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        FormViajes.MdiParent = Me
        FormViajes.Show()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
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

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        FormViajesHistorico.MdiParent = Me
        FormViajesHistorico.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        FormVehiculos.MdiParent = Me
        FormVehiculos.Show()
    End Sub

    Private Sub ChoferesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChoferesToolStripMenuItem.Click
        FormChoferes.MdiParent = Me
        FormChoferes.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FormSocios.MdiParent = Me
        FormSocios.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FormUsuarios.MdiParent = Me
        FormUsuarios.Show()
    End Sub

    Private Sub ComisionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisionesToolStripMenuItem.Click
        FormComisiones.MdiParent = Me
        FormComisiones.Show()
    End Sub

    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesToolStripMenuItem.Click
        FormBeneficios.MdiParent = Me
        FormBeneficios.Show()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ChoferesToolStripMenuItem.Visible = False
        Me.ComisionesToolStripMenuItem.Visible = False
        Me.PromocionesToolStripMenuItem.Visible = False
        Me.UsuariosToolStripMenuItem.Visible = False
        Me.OptionsToolStripMenuItem.Visible = False ' Autos
        Me.ReportesToolStripMenuItem.Visible = False
        Me.ExitToolStripMenuItem.Visible = False 'nuevo viaje
        Me.ToolsMenu.Visible = False ' ABMC
        Me.FileMenu.Visible = False ' Viajes
        Me.ClientesToolStripMenuItem.Visible = False

        If BLL.Login.EsResponsable() Then
            Me.ToolsMenu.Visible = True ' ABMC
            Me.FileMenu.Visible = True
            Me.ChoferesToolStripMenuItem.Visible = True
            Me.ComisionesToolStripMenuItem.Visible = True
            Me.PromocionesToolStripMenuItem.Visible = True
            Me.UsuariosToolStripMenuItem.Visible = True
            Me.OptionsToolStripMenuItem.Visible = True
            Me.ReportesToolStripMenuItem.Visible = True
        End If

        If BLL.Login.EsOperador() Then
            'Rol Operador
            Me.FileMenu.Visible = True
            Me.ToolsMenu.Visible = True ' ABMC
            Me.ClientesToolStripMenuItem.Visible = True
            Me.ExitToolStripMenuItem.Visible = True 'nuevo viaje
            Me.HistóricoToolStripMenuItem.Visible = True ' historico
        End If

        If BLL.Login.EsGerente() Then
            'Rol Gerente
            Me.FileMenu.Visible = True
            Me.ToolsMenu.Visible = True ' ABMC
            Me.ClientesToolStripMenuItem.Visible = True
            Me.ExitToolStripMenuItem.Visible = True 'nuevo viaje
            Me.HistóricoToolStripMenuItem.Visible = True ' historico
        End If
        LogInformation.Text() = BLL.Login.GetInforamcionUsuario()
    End Sub

End Class
