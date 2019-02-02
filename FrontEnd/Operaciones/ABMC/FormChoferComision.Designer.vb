<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChoferComision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChoferComision))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.dgvChoferes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabComisiones = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbbComisiones = New System.Windows.Forms.ComboBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtComisionActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabComisiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.dgvChoferes)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 326)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Choferes"
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(6, 297)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 23)
        Me.BtnModificar.TabIndex = 13
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'dgvChoferes
        '
        Me.dgvChoferes.AllowUserToAddRows = False
        Me.dgvChoferes.AllowUserToDeleteRows = False
        Me.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChoferes.Location = New System.Drawing.Point(7, 19)
        Me.dgvChoferes.MultiSelect = False
        Me.dgvChoferes.Name = "dgvChoferes"
        Me.dgvChoferes.ReadOnly = True
        Me.dgvChoferes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChoferes.Size = New System.Drawing.Size(613, 270)
        Me.dgvChoferes.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 326)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comisión - Chofer"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabComisiones)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 272)
        Me.TabControl1.TabIndex = 15
        '
        'TabComisiones
        '
        Me.TabComisiones.Controls.Add(Me.Label2)
        Me.TabComisiones.Controls.Add(Me.TxtComisionActual)
        Me.TabComisiones.Controls.Add(Me.Label1)
        Me.TabComisiones.Controls.Add(Me.CbbComisiones)
        Me.TabComisiones.Location = New System.Drawing.Point(4, 22)
        Me.TabComisiones.Name = "TabComisiones"
        Me.TabComisiones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabComisiones.Size = New System.Drawing.Size(334, 246)
        Me.TabComisiones.TabIndex = 0
        Me.TabComisiones.Text = "Comision"
        Me.TabComisiones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comision"
        '
        'CbbComisiones
        '
        Me.CbbComisiones.FormattingEnabled = True
        Me.CbbComisiones.Location = New System.Drawing.Point(127, 88)
        Me.CbbComisiones.Name = "CbbComisiones"
        Me.CbbComisiones.Size = New System.Drawing.Size(185, 21)
        Me.CbbComisiones.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(247, 296)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 47
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(137, 297)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(20, 297)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 23)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtComisionActual
        '
        Me.TxtComisionActual.Enabled = False
        Me.TxtComisionActual.Location = New System.Drawing.Point(127, 46)
        Me.TxtComisionActual.Name = "TxtComisionActual"
        Me.TxtComisionActual.Size = New System.Drawing.Size(185, 20)
        Me.TxtComisionActual.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comision Actual"
        '
        'FormChoferComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormChoferComision"
        Me.Text = "Comisión - Chofer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabComisiones.ResumeLayout(False)
        Me.TabComisiones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents dgvChoferes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabComisiones As TabPage
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CbbComisiones As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtComisionActual As TextBox
End Class
