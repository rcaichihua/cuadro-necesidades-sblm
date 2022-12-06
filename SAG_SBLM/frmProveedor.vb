Public Class frmProveedor
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Tipo_Documento As New DataTable
    Private Sub frmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Tipo_Documento = Datos.LLenar_Combo_Solo("select * from Tipo_Documento_Identificacion", Me.cbTipoDocumento, "Descripcion_Tipo_Documento")
        Call Me.Botones(True)
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub Botones(ByVal Estado As Boolean)
        Me.gbDatos.Enabled = Not Estado
        btnNuevo.Enabled = Estado
        btnGuardar.Enabled = Not Estado
        btnCancelar.Enabled = Not Estado
        btnBuscar.Enabled = Estado
        btnSalir.Enabled = Estado
        Me.btnGuardar.Text = "&Guardar"
    End Sub
    Private Sub Limpieza()
        Me.txtRUC_Proveedor.Text = ""
        Me.txtCodigoProveedor.Text = ""
        Me.txtRazon_Social.Text = ""
        Me.txtDomicilio.Text = ""
        Me.txtCodigoUgibeo.Text = ""
        Me.txtUbigeo.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtFax.Text = ""
        Me.txtCelular.Text = ""
        Me.txtCorreo.Text = ""
        Me.txtObservaciones.Text = ""
        Me.chkActivo.Checked = False
        Me.txtCCI.Text = ""
        Me.txtDetracciones.Text = ""
        Me.cbTipoDocumento.SelectedIndex = -1
        Me.txtDescripcionTipoDocumento.Text = ""
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call Me.Limpieza()
        Call Me.Botones(False)
        Me.cbTipoDocumento.SelectedIndex = 1
        Me.txtRUC_Proveedor.Focus()
        Me.chkActivo.Checked = True
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call Me.Limpieza()
        Variable_Codigo_Proveedor = ""
        Call Me.Botones(True)
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim Formulario As New frmBuscar_Proveedor
        Formulario.ShowDialog()
        If Variable_Codigo_Proveedor.Trim.Length > 0 Then
            Call Me.Botones(False)
            Datos.Cargar_Proveedor(Variable_Codigo_Proveedor, Me.txtCodigoProveedor, Me.txtRUC_Proveedor, Me.txtRazon_Social, Me.txtDomicilio, Me.txtCodigoUgibeo, Me.txtUbigeo, Me.txtTelefono, Me.txtCelular, Me.txtFax, Me.txtCorreo, Me.txtObservaciones, Me.chkActivo, Me.txtCCI, Me.txtDetracciones, , Me.cbTipoDocumento)
            Me.btnGuardar.Text = "&Modificar"
        End If
    End Sub
    Private Sub btnBuscarUbigeo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarUbigeo.Click
        Dim Formulario As New frmBuscar_Ubigeo
        Formulario.ShowDialog()
        If Variable_Codigo_Ubigeo.Trim.Length > 0 Then
            Datos.Cargar_Ubigeo(Variable_Codigo_Ubigeo, Me.txtCodigoUgibeo, Me.txtUbigeo)
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.btnGuardar.Text = "&Guardar" Then
            If Me.txtRUC_Proveedor.Text.Trim.Length > 0 Then
                If Me.txtRazon_Social.Text.Trim.Length > 0 Then
                    If Me.txtDomicilio.Text.Trim.Length > 0 Then
                        If Me.txtCodigoUgibeo.Text.Trim.Length > 0 Then
                            If Me.txtRUC_Proveedor.Text.Trim.Length = Datos.Caracteres_Tipo_Documento(Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString) Then
                                If Datos.Caracteres_Tipo_Documento(Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString) = 11 Then
                                    If Datos.VerificaRuc(Me.txtRUC_Proveedor.Text.Trim) = True Then
                                        If Datos.Verificar_Duplicidad_RUC_Proveedor(Me.txtRUC_Proveedor.Text.Trim, True) = True Then
                                            Dim Numero As String = Datos.Generar_Codigo_Proveedor
                                            Datos.Nuevo_Proveedor(Numero, Me.txtRUC_Proveedor.Text, Me.txtRazon_Social.Text, Me.txtDomicilio.Text, Me.txtCodigoUgibeo.Text, Me.txtTelefono.Text, Me.txtCelular.Text, Me.txtFax.Text, Me.txtCorreo.Text, Me.txtObservaciones.Text, Me.chkActivo.Checked, Me.txtCCI.Text, Me.txtDetracciones.Text, Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString)
                                            Call Limpieza()
                                            Call Botones(True)
                                        Else
                                            MessageBox.Show("El Número de Documento Ingresado ya se encuentra Registrado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                            Me.txtRUC_Proveedor.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("El Número de RUC ingresado es Inválido, por favor verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtRUC_Proveedor.Focus()
                                    End If
                                Else
                                    If Datos.Verificar_Duplicidad_RUC_Proveedor(Me.txtRUC_Proveedor.Text.Trim, True) = True Then
                                        Dim Numero As String = Datos.Generar_Codigo_Proveedor
                                        Datos.Nuevo_Proveedor(Numero, Me.txtRUC_Proveedor.Text, Me.txtRazon_Social.Text, Me.txtDomicilio.Text, Me.txtCodigoUgibeo.Text, Me.txtTelefono.Text, Me.txtCelular.Text, Me.txtFax.Text, Me.txtCorreo.Text, Me.txtObservaciones.Text, Me.chkActivo.Checked, Me.txtCCI.Text, Me.txtDetracciones.Text, Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString)
                                        Call Limpieza()
                                        Call Botones(True)
                                    Else
                                        MessageBox.Show("El Número de Documento Ingresado ya se encuentra Registrado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtRUC_Proveedor.Focus()
                                    End If
                                End If
                            Else
                                MessageBox.Show("El Número de RUC ingresado Debe contener 11 Digitos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtRUC_Proveedor.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar el Ubigeo del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.btnBuscarUbigeo.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes ingresar el Domicilio del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtDomicilio.Focus()
                    End If
                Else
                    MessageBox.Show("Debes ingresar la Razón Social del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtRazon_Social.Focus()
                End If
            Else
                MessageBox.Show("Debes ingresar el RUC del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtRUC_Proveedor.Focus()
            End If
        Else
            If Me.txtRUC_Proveedor.Text.Trim.Length > 0 Then
                If Me.txtRazon_Social.Text.Trim.Length > 0 Then
                    If Me.txtDomicilio.Text.Trim.Length > 0 Then
                        If Me.txtCodigoUgibeo.Text.Trim.Length > 0 Then
                            If Me.txtRUC_Proveedor.Text.Trim.Length = Datos.Caracteres_Tipo_Documento(Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString) Then
                                If Datos.Caracteres_Tipo_Documento(Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString) = 11 Then
                                    If Datos.VerificaRuc(Me.txtRUC_Proveedor.Text.Trim) = True Then
                                        Dim Numero As String = Me.txtCodigoProveedor.Text
                                        If Datos.Verificar_Duplicidad_RUC_Proveedor(Me.txtRUC_Proveedor.Text.Trim, False, Numero) = True Then
                                            Datos.Modificar_Proveedor(Numero, Me.txtRUC_Proveedor.Text, Me.txtRazon_Social.Text, Me.txtDomicilio.Text, Me.txtCodigoUgibeo.Text, Me.txtTelefono.Text, Me.txtCelular.Text, Me.txtFax.Text, Me.txtCorreo.Text, Me.txtObservaciones.Text, Me.chkActivo.Checked, Me.txtCCI.Text, Me.txtDetracciones.Text, Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString)
                                            Call Limpieza()
                                            Call Botones(True)
                                        Else
                                            MessageBox.Show("El Número de Documento ingresado se encuentra asignado a Otro Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                            Me.txtRUC_Proveedor.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("El Número de RUC ingresado es Inválido, por favor verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtRUC_Proveedor.Focus()
                                    End If
                                Else
                                    Dim Numero As String = Me.txtCodigoProveedor.Text
                                    If Datos.Verificar_Duplicidad_RUC_Proveedor(Me.txtRUC_Proveedor.Text.Trim, False, Numero) = True Then
                                        Datos.Modificar_Proveedor(Numero, Me.txtRUC_Proveedor.Text, Me.txtRazon_Social.Text, Me.txtDomicilio.Text, Me.txtCodigoUgibeo.Text, Me.txtTelefono.Text, Me.txtCelular.Text, Me.txtFax.Text, Me.txtCorreo.Text, Me.txtObservaciones.Text, Me.chkActivo.Checked, Me.txtCCI.Text, Me.txtDetracciones.Text, Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString)
                                        Call Limpieza()
                                        Call Botones(True)
                                    Else
                                        MessageBox.Show("El Número de Documento ingresado se encuentra asignado a Otro Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtRUC_Proveedor.Focus()
                                    End If
                                End If
                            Else
                                MessageBox.Show("El Número de RUC ingresado Debe contener 11 Digitos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtRUC_Proveedor.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar el Ubigeo del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.btnBuscarUbigeo.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes ingresar el Domicilio del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtDomicilio.Focus()
                    End If
                Else
                    MessageBox.Show("Debes ingresar la Razón Social del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtRazon_Social.Focus()
                End If
            Else
                MessageBox.Show("Debes ingresar el RUC del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtRUC_Proveedor.Focus()
            End If
        End If
    End Sub
    Private Sub txtRUC_Proveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC_Proveedor.KeyPress
        If InStr(1, "0123456789" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtCCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCCI.KeyPress
        If InStr(1, "0123456789" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtDetracciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetracciones.KeyPress
        If InStr(1, "0123456789" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cbTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoDocumento.SelectedIndexChanged
        If Me.cbTipoDocumento.Items.Count > 0 Then
            If Me.cbTipoDocumento.Text.Trim.Length > 0 Then
                Me.txtDescripcionTipoDocumento.Text = Datos.Obtener_Descripcion_Documento_Identificacion(Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString)
                Me.txtRUC_Proveedor.MaxLength = Datos.Caracteres_Tipo_Documento(Tipo_Documento.Rows(Me.cbTipoDocumento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString)
                Me.txtRUC_Proveedor.Focus()
            Else
                Return
            End If
        Else
            Me.txtDescripcionTipoDocumento.Text = String.Empty
            Me.txtRUC_Proveedor.MaxLength = 11
        End If
    End Sub
End Class