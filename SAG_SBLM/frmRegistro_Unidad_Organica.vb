Public Class frmRegistro_Unidad_Organica
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Public Editar As Boolean = False
    Public Codigo_Unidad_Organica As String = ""
    Dim Separador As Char
    Private Sub frmRegistro_Unidad_Organica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If Editar = True Then
            Me.txtAño.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Año_Ejecucion").ToString
            Me.txtCodigo.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Codigo_Unidad_Organica").ToString
            Me.txtAbreviatura.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Abreviatura").ToString
            Me.txtNombre.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Nombre_Unidad_Organica").ToString

            If Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Caja_Chica") Is DBNull.Value Then
                Me.chkCaja.Checked = False
            Else
                Me.chkCaja.Checked = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Caja_Chica")
            End If
            If chkCaja.Checked = True Then
                Me.txtCodigoPartida.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Codigo_Partida").ToString
                Me.txtResolucion.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Resolucion_Caja").ToString
                Me.txtMonto.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Monto_Caja").ToString
                Me.txtCodigoProveedor01.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Codigo_Proveedor_01").ToString
                Datos.Cargar_Proveedor(Me.txtCodigoProveedor01.Text, , , Me.txtProveedor01)
                Me.txtCodigoProveedor02.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Codigo_Proveedor_02").ToString
                Datos.Cargar_Proveedor(Me.txtCodigoProveedor02.Text, , , Me.txtProveedor02)
                Me.txtCorrelativo.Text = Datos.Cargar_Unidad_Organica(My.Settings.Año_Ejecucion, Codigo_Unidad_Organica).Item("Correlativo_Cuenta").ToString
            Else
                Call Me.Limpieza()
            End If
        End If
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Limpieza()
        Me.txtCodigoPartida.Text = ""
        Me.txtResolucion.Text = ""
        Me.txtMonto.Text = ""
        Me.txtCorrelativo.Text = ""
        Me.txtCodigoProveedor01.Text = ""
        Me.txtCodigoProveedor02.Text = ""
        Me.txtProveedor01.Text = ""
        Me.txtProveedor02.Text = ""
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub chkCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCaja.CheckedChanged
        Me.gbCajaChica.Enabled = chkCaja.Checked
        Call Me.Limpieza()
    End Sub
    Private Sub btnBuscarTitular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTitular.Click
        Dim Formulario As New frmBuscar_Proveedor
        Formulario.ShowDialog()
        If Variable_Codigo_Proveedor.Trim.Length > 0 Then
            Datos.Cargar_Proveedor(Variable_Codigo_Proveedor, Me.txtCodigoProveedor01, , Me.txtProveedor01)
        Else
            Me.txtProveedor01.Text = ""
            Me.txtCodigoProveedor01.Text = ""
        End If
    End Sub
    Private Sub txtBuscarSuplente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarSuplente.Click
        Dim Formulario As New frmBuscar_Proveedor
        Formulario.ShowDialog()
        If Variable_Codigo_Proveedor.Trim.Length > 0 Then
            Datos.Cargar_Proveedor(Variable_Codigo_Proveedor, Me.txtCodigoProveedor02, , Me.txtProveedor02)
        Else
            Me.txtProveedor02.Text = ""
            Me.txtCodigoProveedor02.Text = ""
        End If
    End Sub
    Private Sub txtMonto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Enter
        txtMonto.SelectionStart = 0
        txtMonto.SelectionLength = txtMonto.Text.Length
    End Sub
    Private Sub txtMonto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.GotFocus
        txtMonto.SelectionStart = 0
        txtMonto.SelectionLength = txtMonto.Text.Length
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If txtMonto.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            Call Me.txtMonto_Leave(sender, e)
            Me.txtCorrelativo.Focus()
        End If
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        If Me.txtMonto.Text.Trim.Length > 0 Then
            Me.txtMonto.Text = FormatNumber(txtMonto.Text, 2, , , TriState.True)
        Else
            Me.txtMonto.Text = "0.00"
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Editar = False Then
            If Me.chkCaja.Checked = True Then
                If Me.txtNombre.Text.Trim.Length > 0 Then
                    If Me.txtAbreviatura.Text.Trim.Length > 0 Then
                        If Me.txtCodigoPartida.Text.Trim.Length > 0 Then
                            If Me.txtResolucion.Text.Trim.Length > 0 Then
                                If Convert.ToDouble(Me.txtMonto.Text.Trim) > 0 Then
                                    If Me.txtCorrelativo.Text.Trim.Length > 0 Then
                                        If Me.txtCodigoProveedor01.Text.Trim.Length > 0 Then
                                            If Me.txtCodigoProveedor02.Text.Trim.Length > 0 Then
                                                Dim Numero As String = Datos.Generar_Codigo_Unidad_Organica(My.Settings.Año_Ejecucion)
                                                Datos.Nueva_Unidad_Organica_Detallada(My.Settings.Año_Ejecucion, Numero, Me.txtNombre.Text.Trim, Me.txtAbreviatura.Text.Trim, Me.chkCaja.Checked, Me.txtCodigoPartida.Text.Trim, Me.txtResolucion.Text.Trim, Convert.ToDouble(Me.txtMonto.Text.Trim), Me.txtCodigoProveedor01.Text.Trim, Me.txtCodigoProveedor02.Text.Trim, Me.txtCorrelativo.Text.Trim)
                                                Me.Close()
                                            Else
                                                MessageBox.Show("Debes Seleccionar el Titular Suplente para Caja Chica Según lo Indicado en la Resolución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                Me.txtBuscarSuplente.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes Seleccionar el Titular para Caja Chica Según lo Indicado en la Resolución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                            Me.btnBuscarTitular.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes Ingresar el Número de Correlativo de Caja para as Cuentas Contables", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtCorrelativo.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes Ingresar el Monto de Apertura Mensual de Caja Chica de Acuerdo a la Resolución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    Me.txtMonto.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes Ingresar el Número Resolución de Apertura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtResolucion.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes Ingresar el Código de Partida Presupuestal de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtCodigoPartida.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes Ingresar la Abreviatura para Identificación del Centro de Costos de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtAbreviatura.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar el Nombre de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtNombre.Focus()
                End If
            Else
                If Me.txtNombre.Text.Trim.Length > 0 Then
                    If Me.txtAbreviatura.Text.Trim.Length > 0 Then
                        Dim Numero As String = Datos.Generar_Codigo_Unidad_Organica(My.Settings.Año_Ejecucion)
                        Datos.Nueva_Unidad_Organica_Basica(My.Settings.Año_Ejecucion, Numero, Me.txtNombre.Text.Trim, Me.txtAbreviatura.Text.Trim)
                        Me.Close()
                    Else
                        MessageBox.Show("Debes Ingresar la Abreviatura para Identificación del Centro de Costos de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtAbreviatura.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar el Nombre de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtNombre.Focus()
                End If
            End If
        Else
            If Me.chkCaja.Checked = True Then
                If Me.txtNombre.Text.Trim.Length > 0 Then
                    If Me.txtAbreviatura.Text.Trim.Length > 0 Then
                        If Me.txtCodigoPartida.Text.Trim.Length > 0 Then
                            If Me.txtResolucion.Text.Trim.Length > 0 Then
                                If Convert.ToDouble(Me.txtMonto.Text.Trim) > 0 Then
                                    If Me.txtCorrelativo.Text.Trim.Length > 0 Then
                                        If Me.txtCodigoProveedor01.Text.Trim.Length > 0 Then
                                            If Me.txtCodigoProveedor02.Text.Trim.Length > 0 Then
                                                Datos.Modificar_Unidad_Organica_Detallada(My.Settings.Año_Ejecucion, Me.Codigo_Unidad_Organica, Me.txtNombre.Text.Trim, Me.txtAbreviatura.Text.Trim, Me.chkCaja.Checked, Me.txtCodigoPartida.Text.Trim, Me.txtResolucion.Text.Trim, Convert.ToDouble(Me.txtMonto.Text.Trim), Me.txtCodigoProveedor01.Text.Trim, Me.txtCodigoProveedor02.Text.Trim, Me.txtCorrelativo.Text.Trim)
                                                Me.Close()
                                            Else
                                                MessageBox.Show("Debes Seleccionar el Titular Suplente para Caja Chica Según lo Indicado en la Resolución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                Me.txtBuscarSuplente.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes Seleccionar el Titular para Caja Chica Según lo Indicado en la Resolución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                            Me.btnBuscarTitular.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes Ingresar el Número de Correlativo de Caja para as Cuentas Contables", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtCorrelativo.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes Ingresar el Monto de Apertura Mensual de Caja Chica de Acuerdo a la Resolución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    Me.txtMonto.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes Ingresar el Número Resolución de Apertura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtResolucion.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes Ingresar el Código de Partida Presupuestal de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtCodigoPartida.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes Ingresar la Abreviatura para Identificación del Centro de Costos de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtAbreviatura.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar el Nombre de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtNombre.Focus()
                End If
            Else
                If Me.txtNombre.Text.Trim.Length > 0 Then
                    If Me.txtAbreviatura.Text.Trim.Length > 0 Then
                        Datos.Modificar_Unidad_Organica_Basica(My.Settings.Año_Ejecucion, Me.Codigo_Unidad_Organica, Me.txtNombre.Text.Trim, Me.txtAbreviatura.Text.Trim)
                        Me.Close()
                    Else
                        MessageBox.Show("Debes Ingresar la Abreviatura para Identificación del Centro de Costos de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtAbreviatura.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar el Nombre de la Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtNombre.Focus()
                End If
            End If
        End If
    End Sub
End Class