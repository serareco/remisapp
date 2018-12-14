Public Class FormSocios
    Dim socio As EL.Socio
    Dim datosSocio As New BLL.Socio()
    Public Sub actualizarlista()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtNroDocumento.Clear()
        TxtEmail.Clear()
        TxtTelefono.Clear()
        dgvSocios.AutoGenerateColumns = False
        dgvSocios.AutoSize = True
        dgvSocios.Columns.Clear()
        dgvSocios.DataSource = Nothing
        dgvSocios.DataSource = datosSocio.Listar()
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Id",
                    .Name = "Id"
        })
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "NroSocio",
                    .Name = "Nro. Socio"
        })
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Apellido",
                    .Name = "Apellido"
        })
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "Nombre",
                    .Name = "Nombre"
        })
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = "NroDocumento",
                    .Name = "Nro. Documento"
        })
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Email",
            .Name = "E-Mail"
        })
        dgvSocios.Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "FechaAsociado",
            .Name = "Fecha Asociado"
        })
        socio = Nothing
    End Sub

    Private Sub btnguardar_click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If socio Is Nothing Then
            socio = New EL.Socio()
        End If
        socio.Nombre = TxtNombre.Text()
        socio.Apellido = TxtApellido.Text()
        socio.NroDocumento = TxtNroDocumento.Text()
        socio.Domicilio = New EL.Domicilio() With {
            .Calle = TxtCalle.Text(),
            .Nro = TxtNumero.Text(),
            .Localidad = TxtLocalidad.Text(),
            .Provincia = TxtProvincia.Text(),
            .CP = TxtCP.Text()
            }
        If TxtPiso.Text() <> "" Then
            socio.Domicilio.Piso = TxtPiso.Text()
        End If
        If TxtDpto.Text() <> "" Then
            socio.Domicilio.Dpto = TxtDpto.Text()
        End If
        socio.Email = TxtEmail.Text()
        socio.Telefono = TxtTelefono.Text()
        socio.FechaNacimiento = dtpFechaNacimiento.Value()
        datosSocio.Guardar(socio)
        actualizarlista()
    End Sub

    Private Sub btncancelar_click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formclientes_load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()
    End Sub

    Private Sub btnmodificar_click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If (socio IsNot Nothing) Then
            TxtNombre.Text = socio.Nombre
            TxtApellido.Text = socio.Apellido
            TxtNroDocumento.Text = socio.NroDocumento
            TxtCalle.Text = socio.Domicilio.Calle
            TxtLocalidad.Text = socio.Domicilio.Localidad
            TxtNumero.Text = socio.Domicilio.Nro
            TxtPiso.Text = socio.Domicilio.Piso
            TxtProvincia.Text = socio.Domicilio.Provincia
            TxtCP.Text = socio.Domicilio.CP
            TxtEmail.Text = socio.Email
            TxtTelefono.Text = socio.Telefono
            dtpFechaNacimiento.Value = socio.FechaNacimiento
        End If
    End Sub

    Private Sub dgvclientes_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocios.CellClick
        socio = Nothing
        If (e.RowIndex >= 0) Then
            socio = New EL.Socio With {
                .Id = dgvSocios.Rows(e.RowIndex).Cells(0).Value
            }
            socio = datosSocio.GetById(socio.Id)
        End If

    End Sub

    Private Sub btneliminar_click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If socio IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("estas seguro que deseas dar de baja este socio?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                datosSocio.Quitar(socio)
                actualizarlista()
            End If
        End If
    End Sub

    Private Sub btnlimpiar_click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        actualizarlista()
    End Sub
End Class