Public Class frmCompromisos_X_Devengar
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Dim Tipo_Documento As New DataTable
    Private Sub frmCompromisos_X_Devengar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Tipo_Documento = Datos.LLenar_Combo_Solo("Select * From Tipo_Documento Where Codigo_Tipo_Documento In('08','09','22','23','19','31','34','41')", Me.cbTipo_Documento, "Nombre_Tipo_Documento")
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Numero_Expediente = ""
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Expediente"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Nro. " & Me.cbTipo_Documento.Text.Trim
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Columns(0).Width = 50
        Me.DataGridView1.Columns(1).Width = 50
        Me.DataGridView1.Columns(2).Width = 80
        Me.DataGridView1.Columns(3).Width = 95
        Me.DataGridView1.Columns(4).Width = 300
        Me.DataGridView1.Columns(5).Width = 70
        Me.DataGridView1.Columns(6).Width = 70
        Me.DataGridView1.Columns(7).Width = 85
        Me.DataGridView1.Columns(8).Width = 85
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Expediente = Me.DataGridView1.CurrentRow.Cells(1).Value
        Else
            Variable_Numero_Expediente = ""
        End If
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Monto" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Saldo" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Nro. de Documento"
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese la Razón Social / Nombre:"
    End Sub
    Private Sub cbTipo_Documento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo_Documento.SelectedIndexChanged
        If cbTipo_Documento.Items.Count > 0 Then
            If cbTipo_Documento.Text.Trim.Length > 0 Then
                Me.gbFiltros.Enabled = True
                Me.RadioButton1.Checked = False
                Me.RadioButton2.Checked = False
                Me.RadioButton3.Checked = False
                Me.RadioButton4.Checked = False
                Me.RadioButton2.Text = "Por Número de Documento"
                Me.txtDatos.Text = ""
                Call Me.Conectar_Data()
            Else
                Me.RadioButton1.Checked = False
                Me.RadioButton2.Checked = False
                Me.RadioButton3.Checked = False
                Me.RadioButton4.Checked = False
                Me.txtDatos.Text = ""
                Me.gbFiltros.Enabled = False
                Me.RadioButton2.Text = "Por Número de Documento"
            End If
            Select Case Tipo_Documento.Rows(Me.cbTipo_Documento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString
                Case "08"
                    Me.RadioButton2.Text = "Por Número de O./C."
                Case "09"
                    Me.RadioButton2.Text = "Por Número de O./S."
                Case "19"
                    Me.RadioButton2.Text = "Por Número de Planilla"
                Case "22"
                    Me.RadioButton2.Text = "Por Número de Caja Apertura"
                Case "23"
                    Me.RadioButton2.Text = "Por Número de Caja Reembolso"
                Case "31"
                    Me.RadioButton2.Text = "Por Número de Pago."
                Case "34"
                    Me.RadioButton2.Text = "Por Número de Encargo"
                Case Else
                    Me.RadioButton2.Text = "Por Número de Documento"
            End Select
        End If
    End Sub
    Private Sub Conectar_Data()
        If cbTipo_Documento.Items.Count > 0 Then
            If cbTipo_Documento.Text.Trim.Length > 0 Then
                Select Case Tipo_Documento.Rows(Me.cbTipo_Documento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString
                    Case "08"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Convert(VarChar(10),FechaEmision,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Expediente as [Exp.], Monto_Total As Monto,Saldo From Lista_Ordenes_Compra_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Codigo_Estado_Orden ='03' And Saldo > 0 "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                    Case "09"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Convert(VarChar(10),FechaEmision,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Expediente as [Exp.], Monto_Total As Monto,Saldo From Lista_Ordenes_Servicio_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Codigo_Estado_Orden ='03' And Saldo > 0 "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                    Case "22"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero +'-' + convert(varchar(1),numero_rendicion) As Numero , Convert(VarChar(10),FechaApertura,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Expediente as [Exp.], Monto As Monto,Saldo From Lista_Caja_Chica_SBLM_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Saldo > 0 And Codigo_Estado_Caja ='02' And Codigo_Tipo_Caja ='01' "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                    Case "23"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero +'-' + convert(varchar(1),numero_rendicion) As Numero , Convert(VarChar(10),FechaApertura,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Expediente as [Exp.], Monto As Monto,Saldo From Lista_Caja_Chica_SBLM_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Saldo > 0 And Codigo_Estado_Caja ='02' And Codigo_Tipo_Caja ='02' "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                    Case "19"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Convert(VarChar(10),FechaEmision,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Compromiso as [Exp.],Monto_Planilla As Monto,Saldo From Lista_Planillas_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Saldo > 0 And Codigo_Estado_Planilla ='03' "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                    Case "31"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Convert(VarChar(10),FechaEmision,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Expediente as [Exp.], Monto As Monto,Saldo From Lista_Pagos_Varios_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Saldo > 0 And Codigo_Estado_Pago ='03' "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                    Case "34"
                        B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Convert(VarChar(10),FechaEmision,103) As Emision,RUC_Proveedor As 'RUC/DNI/CE',Razon_Social as Nombre,Certificado As [C.C.P.],Expediente as [Exp.], Monto As Monto,Saldo From Lista_Encargo_Interno_Basica "
                        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Saldo > 0 And Codigo_Estado_Encargo ='03' "
                        B_Busqueda_O = " Order By Año_Ejecucion,Numero"
                        Call Me.Filtrar()
                End Select
            End If
        End If

    End Sub
    Sub Filtrar()
        If cbTipo_Documento.Items.Count > 0 Then
            If cbTipo_Documento.Text.Trim.Length > 0 Then
                Select Case Tipo_Documento.Rows(Me.cbTipo_Documento.SelectedIndex).Item("Codigo_Tipo_Documento").ToString
                    Case "08"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Expediente Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                    Case "09"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Expediente Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                    Case "19"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Compromiso Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                    Case "22"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Expediente Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                    Case "23"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Expediente Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                    Case "31"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Expediente Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                    Case "34"
                        If Me.txtDatos.Text.Length > 0 Then
                            Dim S As String = ""
                            If Me.RadioButton1.Checked = True Then
                                S = " And Expediente Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton2.Checked = True Then
                                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton3.Checked = True Then
                                S = " And RUC_Proveedor Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            If Me.RadioButton4.Checked = True Then
                                S = " And Razon_Social Like '%" & Me.txtDatos.Text.Trim & "%'"
                            End If
                            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
                            Call Me.Dimensionar()
                        Else
                            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                            Call Me.Dimensionar()
                        End If
                End Select
            End If
        End If
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.DataGridView1.DataSource = DT
        If DT.Rows.Count > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & DT.Rows.Count
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
        End If
    End Sub
    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        If Me.txtDatos.Text.Trim.Length > 0 Then
            Call Me.Filtrar()
        Else
            Call Me.Filtrar()
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.RowCount > 0 Then
            Datos.Exportar_Grilla_Compromisos_X_Devengar(Me.DataGridView1)
        Else
            MessageBox.Show("No hay Nada para Exportar, asegúrese de haber seleccionado las opciones correctas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If
    End Sub
End Class