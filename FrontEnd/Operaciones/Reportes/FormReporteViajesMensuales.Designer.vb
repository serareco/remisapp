<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteViajesMensuales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteViajesMensuales))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.DgvViajesMensuales = New System.Windows.Forms.DataGridView()
        CType(Me.DgvViajesMensuales, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DgvViajesMensuales
        '
        Me.DgvViajesMensuales.AllowUserToAddRows = False
        Me.DgvViajesMensuales.AllowUserToDeleteRows = False
        Me.DgvViajesMensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvViajesMensuales.Location = New System.Drawing.Point(12, 12)
        Me.DgvViajesMensuales.Name = "DgvViajesMensuales"
        Me.DgvViajesMensuales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvViajesMensuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvViajesMensuales.Size = New System.Drawing.Size(986, 307)
        Me.DgvViajesMensuales.TabIndex = 2
        '
        'FormReporteViajesMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.DgvViajesMensuales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReporteViajesMensuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Viajes Mensuales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvViajesMensuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents DgvViajesMensuales As DataGridView
End Class
