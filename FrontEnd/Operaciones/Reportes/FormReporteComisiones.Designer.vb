<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteComisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteComisiones))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.DgvComisionesChoferes = New System.Windows.Forms.DataGridView()
        CType(Me.DgvComisionesChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 325)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'DgvComisionesChoferes
        '
        Me.DgvComisionesChoferes.AllowUserToAddRows = False
        Me.DgvComisionesChoferes.AllowUserToDeleteRows = False
        Me.DgvComisionesChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComisionesChoferes.Location = New System.Drawing.Point(12, 12)
        Me.DgvComisionesChoferes.Name = "DgvComisionesChoferes"
        Me.DgvComisionesChoferes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvComisionesChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvComisionesChoferes.Size = New System.Drawing.Size(986, 307)
        Me.DgvComisionesChoferes.TabIndex = 2
        '
        'FormReporteComisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.DgvComisionesChoferes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReporteComisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Comision - Chofer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvComisionesChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents DgvComisionesChoferes As DataGridView
End Class
