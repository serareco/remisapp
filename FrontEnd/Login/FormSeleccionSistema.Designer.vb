<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeleccionSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSeleccionSistema))
        Me.RbtnSeleccionSistemaATM = New System.Windows.Forms.RadioButton()
        Me.RbtnSeleccionSistemaOp = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnStarApp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RbtnSeleccionSistemaATM
        '
        Me.RbtnSeleccionSistemaATM.AutoSize = True
        Me.RbtnSeleccionSistemaATM.Location = New System.Drawing.Point(187, 65)
        Me.RbtnSeleccionSistemaATM.Name = "RbtnSeleccionSistemaATM"
        Me.RbtnSeleccionSistemaATM.Size = New System.Drawing.Size(48, 17)
        Me.RbtnSeleccionSistemaATM.TabIndex = 0
        Me.RbtnSeleccionSistemaATM.TabStop = True
        Me.RbtnSeleccionSistemaATM.Text = "ATM"
        Me.RbtnSeleccionSistemaATM.UseVisualStyleBackColor = True
        '
        'RbtnSeleccionSistemaOp
        '
        Me.RbtnSeleccionSistemaOp.AutoSize = True
        Me.RbtnSeleccionSistemaOp.Location = New System.Drawing.Point(187, 88)
        Me.RbtnSeleccionSistemaOp.Name = "RbtnSeleccionSistemaOp"
        Me.RbtnSeleccionSistemaOp.Size = New System.Drawing.Size(85, 17)
        Me.RbtnSeleccionSistemaOp.TabIndex = 1
        Me.RbtnSeleccionSistemaOp.TabStop = True
        Me.RbtnSeleccionSistemaOp.Text = "Operaciones"
        Me.RbtnSeleccionSistemaOp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione la opción de inicio"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BtnStarApp
        '
        Me.BtnStarApp.Location = New System.Drawing.Point(166, 135)
        Me.BtnStarApp.Name = "BtnStarApp"
        Me.BtnStarApp.Size = New System.Drawing.Size(166, 23)
        Me.BtnStarApp.TabIndex = 4
        Me.BtnStarApp.Text = "Iniciar"
        Me.BtnStarApp.UseVisualStyleBackColor = True
        '
        'FormSeleccionSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(347, 196)
        Me.Controls.Add(Me.BtnStarApp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbtnSeleccionSistemaOp)
        Me.Controls.Add(Me.RbtnSeleccionSistemaATM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSeleccionSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir opción de inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RbtnSeleccionSistemaATM As RadioButton
    Friend WithEvents RbtnSeleccionSistemaOp As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnStarApp As Button
End Class
