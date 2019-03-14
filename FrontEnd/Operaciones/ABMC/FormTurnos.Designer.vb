<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTurnos))
        Me.dgvTurnos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.gbxTurnos = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtHorarioFin = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtHorarioInicio = New System.Windows.Forms.TextBox()
        Me.TxtTurno = New System.Windows.Forms.TextBox()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbxTurnos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AllowUserToAddRows = False
        Me.dgvTurnos.AllowUserToDeleteRows = False
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Location = New System.Drawing.Point(7, 19)
        Me.dgvTurnos.MultiSelect = False
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.ReadOnly = True
        Me.dgvTurnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurnos.Size = New System.Drawing.Size(613, 249)
        Me.dgvTurnos.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.dgvTurnos)
        Me.GroupBox2.Location = New System.Drawing.Point(369, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 318)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Turnos"
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
        'gbxTurnos
        '
        Me.gbxTurnos.Controls.Add(Me.Label5)
        Me.gbxTurnos.Controls.Add(Me.TxtHorarioFin)
        Me.gbxTurnos.Controls.Add(Me.BtnLimpiar)
        Me.gbxTurnos.Controls.Add(Me.Label4)
        Me.gbxTurnos.Controls.Add(Me.Label3)
        Me.gbxTurnos.Controls.Add(Me.BtnCancelar)
        Me.gbxTurnos.Controls.Add(Me.BtnGuardar)
        Me.gbxTurnos.Controls.Add(Me.TxtHorarioInicio)
        Me.gbxTurnos.Controls.Add(Me.TxtTurno)
        Me.gbxTurnos.Location = New System.Drawing.Point(9, 21)
        Me.gbxTurnos.Name = "gbxTurnos"
        Me.gbxTurnos.Size = New System.Drawing.Size(354, 318)
        Me.gbxTurnos.TabIndex = 11
        Me.gbxTurnos.TabStop = False
        Me.gbxTurnos.Text = "Nueva Turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Horario Fin"
        '
        'TxtHorarioFin
        '
        Me.TxtHorarioFin.Location = New System.Drawing.Point(121, 111)
        Me.TxtHorarioFin.Name = "TxtHorarioFin"
        Me.TxtHorarioFin.Size = New System.Drawing.Size(217, 20)
        Me.TxtHorarioFin.TabIndex = 19
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
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Horario Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Turno"
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
        'TxtHorarioInicio
        '
        Me.TxtHorarioInicio.Location = New System.Drawing.Point(121, 85)
        Me.TxtHorarioInicio.Name = "TxtHorarioInicio"
        Me.TxtHorarioInicio.Size = New System.Drawing.Size(217, 20)
        Me.TxtHorarioInicio.TabIndex = 3
        '
        'TxtTurno
        '
        Me.TxtTurno.Location = New System.Drawing.Point(121, 57)
        Me.TxtTurno.Name = "TxtTurno"
        Me.TxtTurno.Size = New System.Drawing.Size(217, 20)
        Me.TxtTurno.TabIndex = 2
        '
        'FormTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxTurnos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTurnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbxTurnos.ResumeLayout(False)
        Me.gbxTurnos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTurnos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents gbxTurnos As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtHorarioInicio As TextBox
    Friend WithEvents TxtTurno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtHorarioFin As TextBox
End Class
