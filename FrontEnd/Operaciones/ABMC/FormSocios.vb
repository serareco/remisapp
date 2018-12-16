Public Class FormSocios
    Dim socio As EL.Socio
    Dim datosSocio As New BLL.Socio()
    Dim datosTipoTelefono As New BLL.TipoTelefono()

    Public Sub ActualizarLista()
        TxtNroDocumento.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtEmail.Clear()
        TxtNumeroTel.Clear()
        TxtCodArea.Clear()
        TxtCodPais.Clear()
        TxtCalle.Clear()
        TxtNumero.Clear()
        TxtPiso.Clear()
        TxtDpto.Clear()
        TxtCP.Clear()
        TxtLocalidad.Clear()
        TxtProvincia.Clear()

        CbbTiposTelefono.DataSource = New BindingSource With {
            .DataSource = datosTipoTelefono.Listar()
        }
        CbbTiposTelefono.DisplayMember = "Descripcion"
        CbbTiposTelefono.ValueMember = "Id"

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
        socio.Telefono = New EL.Telefono() With {
                .Numero = TxtNumeroTel.Text(),
                .CodigoArea = TxtCodArea.Text(),
                .CodigoPais = TxtCodPais.Text()
            }
        socio.Telefono.TipoTelefono.Id = CbbTiposTelefono.SelectedValue
        socio.Email = TxtEmail.Text()
        socio.FechaNacimiento = dtpFechaNacimiento.Value()
        Try
            datosSocio.Guardar(socio)
            MessageBox.Show("Los cambios fueron guardados correctamente.")
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al guardar los cambios. Error: " + ex.Message)
        End Try
        ActualizarLista()
    End Sub

    Private Sub btncancelar_click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formclientes_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub btnmodificar_click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If (socio IsNot Nothing) Then
            TxtNombre.Text = socio.Nombre
            TxtApellido.Text = socio.Apellido
            TxtNroDocumento.Text = socio.NroDocumento
            TxtEmail.Text = socio.Email
            dtpFechaNacimiento.Value = socio.FechaNacimiento
            If socio.Domicilio IsNot Nothing Then
                TxtCalle.Text = socio.Domicilio.Calle
                TxtNumero.Text = socio.Domicilio.Nro
                If socio.Domicilio.Piso = 0 Then
                    TxtPiso.Clear()
                End If
                TxtDpto.Text = socio.Domicilio.Dpto
                TxtLocalidad.Text = socio.Domicilio.Localidad
                TxtCP.Text = socio.Domicilio.CP
                TxtProvincia.Text = socio.Domicilio.Provincia
            Else
                TxtCalle.Clear()
                TxtNumero.Clear()
                TxtPiso.Clear()
                TxtDpto.Clear()
                TxtCP.Clear()
                TxtLocalidad.Clear()
                TxtProvincia.Clear()
            End If
            If socio.Telefono IsNot Nothing Then
                TxtNumeroTel.Text = socio.Telefono.Numero
                TxtCodArea.Text = socio.Telefono.CodigoArea
                TxtCodPais.Text = socio.Telefono.CodigoPais
                CbbTiposTelefono.SelectedValue = socio.Telefono.TipoTelefono.Id
            Else
                TxtNumeroTel.Clear()
                TxtCodArea.Clear()
                TxtCodPais.Clear()
            End If
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
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub btnlimpiar_click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ActualizarLista()
    End Sub
End Class