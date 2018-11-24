<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComisiones))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.dgvComisiones = New System.Windows.Forms.DataGridView()
        Me.gbxComisiones = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dtpVigenciaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpVigenciaDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxComisiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.dgvComisiones)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 318)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Comisiones"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(115, 275)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 23)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(7, 275)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 23)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'dgvComisiones
        '
        Me.dgvComisiones.AllowUserToAddRows = False
        Me.dgvComisiones.AllowUserToDeleteRows = False
        Me.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComisiones.Location = New System.Drawing.Point(7, 19)
        Me.dgvComisiones.MultiSelect = False
        Me.dgvComisiones.Name = "dgvComisiones"
        Me.dgvComisiones.ReadOnly = True
        Me.dgvComisiones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComisiones.Size = New System.Drawing.Size(613, 249)
        Me.dgvComisiones.TabIndex = 9
        '
        'gbxComisiones
        '
        Me.gbxComisiones.Controls.Add(Me.CheckBox1)
        Me.gbxComisiones.Controls.Add(Me.dtpVigenciaHasta)
        Me.gbxComisiones.Controls.Add(Me.dtpVigenciaDesde)
        Me.gbxComisiones.Controls.Add(Me.BtnLimpiar)
        Me.gbxComisiones.Controls.Add(Me.Label4)
        Me.gbxComisiones.Controls.Add(Me.Label3)
        Me.gbxComisiones.Controls.Add(Me.Label2)
        Me.gbxComisiones.Controls.Add(Me.Label1)
        Me.gbxComisiones.Controls.Add(Me.BtnCancelar)
        Me.gbxComisiones.Controls.Add(Me.BtnGuardar)
        Me.gbxComisiones.Controls.Add(Me.txtDescripcion)
        Me.gbxComisiones.Controls.Add(Me.txtPorcentaje)
        Me.gbxComisiones.Location = New System.Drawing.Point(12, 20)
        Me.gbxComisiones.Name = "gbxComisiones"
        Me.gbxComisiones.Size = New System.Drawing.Size(354, 318)
        Me.gbxComisiones.TabIndex = 9
        Me.gbxComisiones.TabStop = False
        Me.gbxComisiones.Text = "Nueva Comisión"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(121, 165)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Comisión por defecto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtpVigenciaHasta
        '
        Me.dtpVigenciaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVigenciaHasta.Location = New System.Drawing.Point(121, 139)
        Me.dtpVigenciaHasta.Name = "dtpVigenciaHasta"
        Me.dtpVigenciaHasta.Size = New System.Drawing.Size(217, 20)
        Me.dtpVigenciaHasta.TabIndex = 18
        '
        'dtpVigenciaDesde
        '
        Me.dtpVigenciaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVigenciaDesde.Location = New System.Drawing.Point(121, 112)
        Me.dtpVigenciaDesde.Name = "dtpVigenciaDesde"
        Me.dtpVigenciaDesde.Size = New System.Drawing.Size(217, 20)
        Me.dtpVigenciaDesde.TabIndex = 17
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(263, 275)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Porcentaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fin Vigencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inicio Vigencia"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(148, 275)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(27, 275)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(121, 85)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(217, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(121, 57)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(217, 20)
        Me.txtPorcentaje.TabIndex = 2
        '
        'FormComisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 358)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxComisiones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormComisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comisiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxComisiones.ResumeLayout(False)
        Me.gbxComisiones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents dgvComisiones As DataGridView
    Friend WithEvents gbxComisiones As GroupBox
    Friend WithEvents dtpVigenciaHasta As DateTimePicker
    Friend WithEvents dtpVigenciaDesde As DateTimePicker
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
