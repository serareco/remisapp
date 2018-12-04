Public Class FormViajes
    Dim viaje As EL.Viaje
    Dim datosViaje As New BLL.Viaje()
    Dim datosChofer As New BLL.Chofer()
    Dim datosEstadoViaje As New BLL.EstadoViaje()
    Dim datosSocio As New BLL.Socio()
    Dim datosPromocion As New BLL.Beneficio()
    ' Cuando se ingresa a esta opción del menú, el sistema debe sugerir (seleccionar automaticamente, pero sin confirmar):
    '
    'Chofer y Beneficios (en el blur del combo del cliente)
    '
    ' VER LA FORMA DE SUGERIR EL VALOR DEL PRECIO, EL TIEMPO DE DEMORA, ETC.
    '
    '
    '
    '
    '
    Public Sub ActualizarLista()
        cbbChofer.DataSource = Nothing
        'cbbChofer.DataSource = datosChofer.MostrarDisponibles()
        cbbChofer.DisplayMember = "descripcion"
        cbbChofer.ValueMember = "id_chofer"
        cbbTipoEstadoViaje.DataSource = Nothing
        cbbTipoEstadoViaje.DataSource = datosEstadoViaje.MostrarAlta()
        cbbTipoEstadoViaje.DisplayMember = "descripcion"
        cbbTipoEstadoViaje.ValueMember = "id_estado"

        cbbCliente.DataSource = Nothing
        cbbCliente.DataSource = New BindingSource With {
            .DataSource = datosSocio.Listar()
        }
        cbbCliente.DisplayMember = "Nombre"
        cbbCliente.ValueMember = "Id"

        clbPromociones.DataSource = datosPromocion.MostrarVigentes()
        clbPromociones.ValueMember = "id_promocion"
        clbPromociones.DisplayMember = "descripcion"
        txtOrigen.Text() = ""
        txtDestino.Text() = ""
        dgvViajes.DataSource = Nothing
        dgvViajes.DataSource = datosViaje.MostrarEnCurso()
        viaje = Nothing
        BtnCancelarViaje.Enabled = False
        BtnNotificarArribo.Enabled = False
        BtnNotificarSalida.Enabled = False
    End Sub

    Private Sub FormViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If viaje Is Nothing Then
            viaje = New EL.Viaje()
        End If
        viaje.Origen = txtOrigen.Text()
        viaje.Destino = txtDestino.Text()
        viaje.FechaSalida = dtpFechaSalida.Value
        If cbbIdaYVuelta.SelectedValue = "S" Then
            viaje.IdaYVuelta = True
        Else
            viaje.IdaYVuelta = False
        End If
        viaje.Chofer = datosChofer.GetById(cbbChofer.SelectedValue)
        viaje.Socio = datosSocio.GetById(cbbCliente.SelectedValue)
        viaje.Estado = datosEstadoViaje.GetById(cbbTipoEstadoViaje.SelectedValue)
        viaje.Promociones = New List(Of EL.Beneficio)
        For Each itemChecked As Object In clbPromociones.CheckedItems
            Dim promocion As New EL.Beneficio With {
        .Id = CType(itemChecked, DataRowView).Row.ItemArray(0),
        .Descripcion = CType(itemChecked, DataRowView).Row.ItemArray(1)
              }
            viaje.Promociones.Add(promocion)
        Next
        datosViaje.Guardar(viaje)
        ActualizarLista()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnNotificarArribo_Click(sender As Object, e As EventArgs) Handles BtnNotificarArribo.Click
        If viaje IsNot Nothing Then
            FormArribo.viaje = viaje
            FormArribo.Show()
        End If
    End Sub

    Private Sub dgvViajes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViajes.CellClick
        viaje = Nothing
        viaje = New EL.Viaje With {
            .Id = dgvViajes.Rows(e.RowIndex).Cells(0).Value
        }
        viaje = datosViaje.GetById(viaje.Id)
        BtnCancelarViaje.Enabled = True
        BtnNotificarArribo.Enabled = True
        BtnNotificarSalida.Enabled = True
    End Sub

End Class