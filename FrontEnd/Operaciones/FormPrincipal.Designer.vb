<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuViajes = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionViajesCurso = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionConsultaHistorico = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuABMC = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionAutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionChoferes = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionSocios = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionComisiones = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionBeneficios = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionChoferComision = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionParametrosSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionReportesViajes = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionReporteComisionChoferes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.LogInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuViajes, Me.MenuABMC, Me.MenuReportes, Me.MenuVentana})
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.MdiWindowListItem = Me.MenuVentana
        Me.MenuStrip.Name = "MenuStrip"
        '
        'MenuViajes
        '
        Me.MenuViajes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionViajesCurso, Me.OpcionConsultaHistorico})
        resources.ApplyResources(Me.MenuViajes, "MenuViajes")
        Me.MenuViajes.Name = "MenuViajes"
        '
        'OpcionViajesCurso
        '
        Me.OpcionViajesCurso.Name = "OpcionViajesCurso"
        resources.ApplyResources(Me.OpcionViajesCurso, "OpcionViajesCurso")
        '
        'OpcionConsultaHistorico
        '
        Me.OpcionConsultaHistorico.Name = "OpcionConsultaHistorico"
        resources.ApplyResources(Me.OpcionConsultaHistorico, "OpcionConsultaHistorico")
        '
        'MenuABMC
        '
        Me.MenuABMC.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionAutos, Me.OpcionChoferes, Me.OpcionSocios, Me.OpcionUsuarios, Me.OpcionComisiones, Me.OpcionBeneficios, Me.OpcionChoferComision, Me.OpcionParametrosSistema})
        Me.MenuABMC.Name = "MenuABMC"
        resources.ApplyResources(Me.MenuABMC, "MenuABMC")
        '
        'OpcionAutos
        '
        Me.OpcionAutos.Name = "OpcionAutos"
        resources.ApplyResources(Me.OpcionAutos, "OpcionAutos")
        '
        'OpcionChoferes
        '
        Me.OpcionChoferes.Name = "OpcionChoferes"
        resources.ApplyResources(Me.OpcionChoferes, "OpcionChoferes")
        '
        'OpcionSocios
        '
        Me.OpcionSocios.Name = "OpcionSocios"
        resources.ApplyResources(Me.OpcionSocios, "OpcionSocios")
        '
        'OpcionUsuarios
        '
        Me.OpcionUsuarios.Name = "OpcionUsuarios"
        resources.ApplyResources(Me.OpcionUsuarios, "OpcionUsuarios")
        '
        'OpcionComisiones
        '
        Me.OpcionComisiones.Name = "OpcionComisiones"
        resources.ApplyResources(Me.OpcionComisiones, "OpcionComisiones")
        '
        'OpcionBeneficios
        '
        Me.OpcionBeneficios.Name = "OpcionBeneficios"
        resources.ApplyResources(Me.OpcionBeneficios, "OpcionBeneficios")
        '
        'OpcionChoferComision
        '
        Me.OpcionChoferComision.Name = "OpcionChoferComision"
        resources.ApplyResources(Me.OpcionChoferComision, "OpcionChoferComision")
        '
        'OpcionParametrosSistema
        '
        Me.OpcionParametrosSistema.Name = "OpcionParametrosSistema"
        resources.ApplyResources(Me.OpcionParametrosSistema, "OpcionParametrosSistema")
        '
        'MenuReportes
        '
        Me.MenuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionReportesViajes, Me.OpcionReporteComisionChoferes})
        Me.MenuReportes.Name = "MenuReportes"
        resources.ApplyResources(Me.MenuReportes, "MenuReportes")
        '
        'OpcionReportesViajes
        '
        Me.OpcionReportesViajes.Name = "OpcionReportesViajes"
        resources.ApplyResources(Me.OpcionReportesViajes, "OpcionReportesViajes")
        '
        'OpcionReporteComisionChoferes
        '
        Me.OpcionReporteComisionChoferes.Name = "OpcionReporteComisionChoferes"
        resources.ApplyResources(Me.OpcionReporteComisionChoferes, "OpcionReporteComisionChoferes")
        '
        'MenuVentana
        '
        Me.MenuVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.MenuVentana.Name = "MenuVentana"
        resources.ApplyResources(Me.MenuVentana, "MenuVentana")
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        resources.ApplyResources(Me.CascadeToolStripMenuItem, "CascadeToolStripMenuItem")
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        resources.ApplyResources(Me.TileVerticalToolStripMenuItem, "TileVerticalToolStripMenuItem")
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        resources.ApplyResources(Me.TileHorizontalToolStripMenuItem, "TileHorizontalToolStripMenuItem")
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        resources.ApplyResources(Me.CloseAllToolStripMenuItem, "CloseAllToolStripMenuItem")
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInformation, Me.ToolStripDropDownButton1})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        '
        'LogInformation
        '
        Me.LogInformation.Name = "LogInformation"
        resources.ApplyResources(Me.LogInformation, "LogInformation")
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        resources.ApplyResources(Me.ToolStripDropDownButton1, "ToolStripDropDownButton1")
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        resources.ApplyResources(Me.CerrarSesionToolStripMenuItem, "CerrarSesionToolStripMenuItem")
        '
        'FormPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionAutos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents LogInformation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents OpcionViajesCurso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuViajes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuABMC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionConsultaHistorico As ToolStripMenuItem
    Friend WithEvents OpcionChoferes As ToolStripMenuItem
    Friend WithEvents OpcionSocios As ToolStripMenuItem
    Friend WithEvents OpcionUsuarios As ToolStripMenuItem
    Friend WithEvents OpcionComisiones As ToolStripMenuItem
    Friend WithEvents OpcionBeneficios As ToolStripMenuItem
    Friend WithEvents MenuReportes As ToolStripMenuItem
    Friend WithEvents OpcionReportesViajes As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionChoferComision As ToolStripMenuItem
    Friend WithEvents OpcionReporteComisionChoferes As ToolStripMenuItem
    Friend WithEvents OpcionParametrosSistema As ToolStripMenuItem
End Class
