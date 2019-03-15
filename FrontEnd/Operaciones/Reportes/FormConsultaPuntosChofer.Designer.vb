<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaPuntosChofer
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
        Me.dgvPuntajeChoferes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbxFiltro = New System.Windows.Forms.GroupBox()
        Me.ChkVigente = New System.Windows.Forms.CheckBox()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbChofer = New System.Windows.Forms.ComboBox()
        Me.ClbAccion = New System.Windows.Forms.CheckedListBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        CType(Me.dgvPuntajeChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbxFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPuntajeChoferes
        '
        Me.dgvPuntajeChoferes.AllowUserToAddRows = False
        Me.dgvPuntajeChoferes.AllowUserToDeleteRows = False
        Me.dgvPuntajeChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPuntajeChoferes.Location = New System.Drawing.Point(7, 19)
        Me.dgvPuntajeChoferes.MultiSelect = False
        Me.dgvPuntajeChoferes.Name = "dgvPuntajeChoferes"
        Me.dgvPuntajeChoferes.ReadOnly = True
        Me.dgvPuntajeChoferes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPuntajeChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPuntajeChoferes.Size = New System.Drawing.Size(613, 279)
        Me.dgvPuntajeChoferes.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvPuntajeChoferes)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 318)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Puntaje de Choferes"
        '
        'gbxFiltro
        '
        Me.gbxFiltro.Controls.Add(Me.ChkVigente)
        Me.gbxFiltro.Controls.Add(Me.ChkActivo)
        Me.gbxFiltro.Controls.Add(Me.Label5)
        Me.gbxFiltro.Controls.Add(Me.cbbChofer)
        Me.gbxFiltro.Controls.Add(Me.ClbAccion)
        Me.gbxFiltro.Controls.Add(Me.dtpFechaHasta)
        Me.gbxFiltro.Controls.Add(Me.dtpFechaDesde)
        Me.gbxFiltro.Controls.Add(Me.BtnLimpiar)
        Me.gbxFiltro.Controls.Add(Me.Label4)
        Me.gbxFiltro.Controls.Add(Me.Label3)
        Me.gbxFiltro.Controls.Add(Me.Label2)
        Me.gbxFiltro.Controls.Add(Me.Label1)
        Me.gbxFiltro.Controls.Add(Me.BtnCerrar)
        Me.gbxFiltro.Controls.Add(Me.BtnConsultar)
        Me.gbxFiltro.Location = New System.Drawing.Point(12, 21)
        Me.gbxFiltro.Name = "gbxFiltro"
        Me.gbxFiltro.Size = New System.Drawing.Size(354, 318)
        Me.gbxFiltro.TabIndex = 13
        Me.gbxFiltro.TabStop = False
        Me.gbxFiltro.Text = "Filtros"
        '
        'ChkVigente
        '
        Me.ChkVigente.AutoSize = True
        Me.ChkVigente.Location = New System.Drawing.Point(271, 99)
        Me.ChkVigente.Name = "ChkVigente"
        Me.ChkVigente.Size = New System.Drawing.Size(62, 17)
        Me.ChkVigente.TabIndex = 45
        Me.ChkVigente.Text = "Vigente"
        Me.ChkVigente.UseVisualStyleBackColor = True
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.Location = New System.Drawing.Point(123, 99)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChkActivo.TabIndex = 44
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Estado"
        '
        'cbbChofer
        '
        Me.cbbChofer.FormattingEnabled = True
        Me.cbbChofer.Location = New System.Drawing.Point(123, 19)
        Me.cbbChofer.Name = "cbbChofer"
        Me.cbbChofer.Size = New System.Drawing.Size(210, 21)
        Me.cbbChofer.TabIndex = 42
        '
        'ClbAccion
        '
        Me.ClbAccion.FormattingEnabled = True
        Me.ClbAccion.Location = New System.Drawing.Point(123, 122)
        Me.ClbAccion.Name = "ClbAccion"
        Me.ClbAccion.Size = New System.Drawing.Size(210, 124)
        Me.ClbAccion.TabIndex = 12
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(123, 73)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaHasta.TabIndex = 5
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(123, 46)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaDesde.TabIndex = 4
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(258, 275)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 10
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Chofer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Acciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha desde"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(143, 275)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCerrar.TabIndex = 9
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(22, 275)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(97, 23)
        Me.BtnConsultar.TabIndex = 8
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'FormConsultaPuntosChofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxFiltro)
        Me.Name = "FormConsultaPuntosChofer"
        Me.Text = "Consulta de puntaje de choferes"
        CType(Me.dgvPuntajeChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbxFiltro.ResumeLayout(False)
        Me.gbxFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPuntajeChoferes As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbxFiltro As GroupBox
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents ClbAccion As CheckedListBox
    Friend WithEvents cbbChofer As ComboBox
    Friend WithEvents ChkVigente As CheckBox
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents Label5 As Label
End Class
