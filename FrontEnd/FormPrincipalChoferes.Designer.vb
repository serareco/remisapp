<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipalChoferes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ViajesRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajesRealizadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajesPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComisionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajesRealizadosToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ViajesRealizadosToolStripMenuItem
        '
        Me.ViajesRealizadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajesRealizadosToolStripMenuItem1, Me.ViajesPendientesToolStripMenuItem, Me.ComisionesToolStripMenuItem})
        Me.ViajesRealizadosToolStripMenuItem.Name = "ViajesRealizadosToolStripMenuItem"
        Me.ViajesRealizadosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ViajesRealizadosToolStripMenuItem.Text = "Consultas"
        '
        'ViajesRealizadosToolStripMenuItem1
        '
        Me.ViajesRealizadosToolStripMenuItem1.Name = "ViajesRealizadosToolStripMenuItem1"
        Me.ViajesRealizadosToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ViajesRealizadosToolStripMenuItem1.Text = "Viajes Realizados"
        '
        'ViajesPendientesToolStripMenuItem
        '
        Me.ViajesPendientesToolStripMenuItem.Name = "ViajesPendientesToolStripMenuItem"
        Me.ViajesPendientesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViajesPendientesToolStripMenuItem.Text = "Viajes Pendientes"
        '
        'ComisionesToolStripMenuItem
        '
        Me.ComisionesToolStripMenuItem.Name = "ComisionesToolStripMenuItem"
        Me.ComisionesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ComisionesToolStripMenuItem.Text = "Comisiones"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'FormPrincipalChoferes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormPrincipalChoferes"
        Me.Text = "FormPrincipalChoferes"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViajesRealizadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViajesRealizadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViajesPendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComisionesToolStripMenuItem As ToolStripMenuItem
End Class
