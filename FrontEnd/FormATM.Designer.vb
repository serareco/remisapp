<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormATM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormATM))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblOrigenSalir = New System.Windows.Forms.Label()
        Me.LblDestinoSalir = New System.Windows.Forms.Label()
        Me.LblChoferSalir = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblHorarioLlegar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblOrigenLlegar = New System.Windows.Forms.Label()
        Me.LblDestinoLlegar = New System.Windows.Forms.Label()
        Me.LblChoferLlegar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvServiciosPendientes = New System.Windows.Forms.DataGridView()
        Me.DgvServiciosEnCurso = New System.Windows.Forms.DataGridView()
        Me.ActualizarInformacion = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvServiciosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvServiciosEnCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DgvServiciosPendientes, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DgvServiciosEnCurso, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(907, 485)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Servicios EN CURSO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblOrigenSalir)
        Me.GroupBox1.Controls.Add(Me.LblDestinoSalir)
        Me.GroupBox1.Controls.Add(Me.LblChoferSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(657, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 213)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Próximos en salir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hoy, 12:35"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Origen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Destino"
        '
        'LblOrigenSalir
        '
        Me.LblOrigenSalir.AutoSize = True
        Me.LblOrigenSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrigenSalir.Location = New System.Drawing.Point(7, 153)
        Me.LblOrigenSalir.Name = "LblOrigenSalir"
        Me.LblOrigenSalir.Size = New System.Drawing.Size(103, 18)
        Me.LblOrigenSalir.TabIndex = 2
        Me.LblOrigenSalir.Text = "Cisnero 2022"
        '
        'LblDestinoSalir
        '
        Me.LblDestinoSalir.AutoSize = True
        Me.LblDestinoSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDestinoSalir.Location = New System.Drawing.Point(7, 102)
        Me.LblDestinoSalir.Name = "LblDestinoSalir"
        Me.LblDestinoSalir.Size = New System.Drawing.Size(120, 18)
        Me.LblDestinoSalir.TabIndex = 1
        Me.LblDestinoSalir.Text = "Plaza San Justo"
        '
        'LblChoferSalir
        '
        Me.LblChoferSalir.AutoSize = True
        Me.LblChoferSalir.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChoferSalir.Location = New System.Drawing.Point(6, 26)
        Me.LblChoferSalir.Name = "LblChoferSalir"
        Me.LblChoferSalir.Size = New System.Drawing.Size(215, 22)
        Me.LblChoferSalir.TabIndex = 0
        Me.LblChoferSalir.Text = "Areco, Sergio Valentín"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblHorarioLlegar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LblOrigenLlegar)
        Me.GroupBox2.Controls.Add(Me.LblDestinoLlegar)
        Me.GroupBox2.Controls.Add(Me.LblChoferLlegar)
        Me.GroupBox2.Location = New System.Drawing.Point(657, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 206)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Próximos en llegar"
        '
        'LblHorarioLlegar
        '
        Me.LblHorarioLlegar.AutoSize = True
        Me.LblHorarioLlegar.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHorarioLlegar.Location = New System.Drawing.Point(6, 51)
        Me.LblHorarioLlegar.Name = "LblHorarioLlegar"
        Me.LblHorarioLlegar.Size = New System.Drawing.Size(106, 22)
        Me.LblHorarioLlegar.TabIndex = 11
        Me.LblHorarioLlegar.Text = "Hoy, 12:35"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Origen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Destino"
        '
        'LblOrigenLlegar
        '
        Me.LblOrigenLlegar.AutoSize = True
        Me.LblOrigenLlegar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrigenLlegar.Location = New System.Drawing.Point(7, 143)
        Me.LblOrigenLlegar.Name = "LblOrigenLlegar"
        Me.LblOrigenLlegar.Size = New System.Drawing.Size(103, 18)
        Me.LblOrigenLlegar.TabIndex = 8
        Me.LblOrigenLlegar.Text = "Cisnero 2022"
        '
        'LblDestinoLlegar
        '
        Me.LblDestinoLlegar.AutoSize = True
        Me.LblDestinoLlegar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDestinoLlegar.Location = New System.Drawing.Point(7, 92)
        Me.LblDestinoLlegar.Name = "LblDestinoLlegar"
        Me.LblDestinoLlegar.Size = New System.Drawing.Size(120, 18)
        Me.LblDestinoLlegar.TabIndex = 7
        Me.LblDestinoLlegar.Text = "Plaza San Justo"
        '
        'LblChoferLlegar
        '
        Me.LblChoferLlegar.AutoSize = True
        Me.LblChoferLlegar.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChoferLlegar.Location = New System.Drawing.Point(6, 16)
        Me.LblChoferLlegar.Name = "LblChoferLlegar"
        Me.LblChoferLlegar.Size = New System.Drawing.Size(215, 22)
        Me.LblChoferLlegar.TabIndex = 6
        Me.LblChoferLlegar.Text = "Areco, Sergio Valentín"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servicios PENDIENTES"
        '
        'DgvServiciosPendientes
        '
        Me.DgvServiciosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvServiciosPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvServiciosPendientes.Location = New System.Drawing.Point(3, 32)
        Me.DgvServiciosPendientes.Name = "DgvServiciosPendientes"
        Me.DgvServiciosPendientes.Size = New System.Drawing.Size(648, 213)
        Me.DgvServiciosPendientes.TabIndex = 4
        '
        'DgvServiciosEnCurso
        '
        Me.DgvServiciosEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvServiciosEnCurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvServiciosEnCurso.Location = New System.Drawing.Point(3, 280)
        Me.DgvServiciosEnCurso.Name = "DgvServiciosEnCurso"
        Me.DgvServiciosEnCurso.Size = New System.Drawing.Size(648, 206)
        Me.DgvServiciosEnCurso.TabIndex = 5
        '
        'ActualizarInformacion
        '
        Me.ActualizarInformacion.Interval = 10000
        '
        'FormATM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(931, 509)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormATM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remisapp - ATM Control"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvServiciosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvServiciosEnCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblOrigenSalir As Label
    Friend WithEvents LblDestinoSalir As Label
    Friend WithEvents LblChoferSalir As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblHorarioLlegar As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblOrigenLlegar As Label
    Friend WithEvents LblDestinoLlegar As Label
    Friend WithEvents LblChoferLlegar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvServiciosPendientes As DataGridView
    Friend WithEvents DgvServiciosEnCurso As DataGridView
    Friend WithEvents ActualizarInformacion As Timer
End Class
