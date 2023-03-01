Public Class frmRegistro_Requerimiento_Servicios
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Unidad_Organica As New DataTable
    Dim Fuente_Financiaminto As New DataTable
    Dim Rubro As New DataTable
    Dim Secuencia_Funcional As New DataTable
    Dim Actividad As New DataTable
    Dim Grupo As New DataTable
    Public Editar As Boolean = False
    Public ValidarRequerimientoServicioSaldos As Boolean = True
    Dim Separador As Char
    Private Sub frmRegistro_Requerimiento_Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Call ReiniciarCampos()
        If Editar = False Then
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")
            Call Me.Dimensionar()
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Else
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")
            Call Me.Dimensionar()
            Datos.Cargar_Requerimiento_Servicio_Para_Modificacion(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Me.dgvRequerimientoServicios, Me.cbUnidadOrganica, Me.txtJustificacion)
            Me.cbUnidadOrganica.Enabled = False
            Call Me.Total()
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub cbFF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFF.SelectedIndexChanged
        Me.cbRubro.DataSource = Nothing
        If Me.cbFF.Text.Trim.Length > 0 Then
            Rubro = Datos.LLenar_Combo_Solo("Select * From Lista_Rubros Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF='" & Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF") & "'", Me.cbRubro, "Rubro")
            Call Asigna_Item_Segun_Filtro()
            'Call Me.Evaluar_Saldos()
        Else
            Me.cbRubro.DataSource = Nothing
            Call Asigna_Item_Segun_Filtro()
            'Call Me.Evaluar_Saldos()
        End If
    End Sub
    Private Sub cbUnidadOrganica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidadOrganica.SelectedIndexChanged
        Try 
            Me.cbSecuenciaFuncional.DataSource = Nothing
            Me.cbActividad.DataSource = Nothing
            If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
                Secuencia_Funcional = Datos.LLenar_Combo_Solo("Select * From Lista_Secuencias Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbSecuenciaFuncional, "Codigo_Secuencia_Funcional")
                Me.cbSecuenciaFuncional.SelectedIndex = 0
                Call Asigna_Item_Segun_Filtro()
            Else
                Me.cbSecuenciaFuncional.DataSource = Nothing
                Call Asigna_Item_Segun_Filtro()
            End If
        Catch ex As Exception
            'Sin errores
        End Try
    End Sub
    Private Sub cbSecuenciaFuncional_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSecuenciaFuncional.SelectedIndexChanged
        Try
            Me.cbActividad.DataSource = Nothing
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
             Call Asigna_Item_Segun_Filtro()
            'Call Me.Evaluar_Saldos()
            If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                Actividad = Datos.LLenar_Combo_Solo("Select * From Lista_Actividades Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Secuencia_Funcional='" & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional") & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbActividad, "Actividad")
                'Call Me.Evaluar_Saldos()
                Call Asigna_Item_Segun_Filtro()
                Me.cbActividad.SelectedIndex = 0
            Else
                'Call Me.Evaluar_Saldos()
                Call Asigna_Item_Segun_Filtro()
                Me.cbActividad.DataSource = Nothing
            End If
        Else
            'Call Me.Evaluar_Saldos()
            Call Asigna_Item_Segun_Filtro()
            Me.cbActividad.DataSource = Nothing
        End If
        Catch ex As Exception
            'Sin errores
        End Try
        
    End Sub
    Private Sub Dimensionar()
        Me.dgvRequerimientoServicios.Rows.Clear()
        Me.dgvRequerimientoServicios.Columns.Clear()
        Me.dgvRequerimientoServicios.Columns.Add("Año", "Año")
        Me.dgvRequerimientoServicios.Columns.Add("FF", "FF")
        Me.dgvRequerimientoServicios.Columns.Add("R", "R")
        Me.dgvRequerimientoServicios.Columns.Add("TT", "TT")
        Me.dgvRequerimientoServicios.Columns.Add("G", "G")
        Me.dgvRequerimientoServicios.Columns.Add("SG", "SG")
        Me.dgvRequerimientoServicios.Columns.Add("SGD", "SGD")
        Me.dgvRequerimientoServicios.Columns.Add("E", "E")
        Me.dgvRequerimientoServicios.Columns.Add("ED", "ED")
        Me.dgvRequerimientoServicios.Columns.Add("Clasificador", "Clasificador")
        Me.dgvRequerimientoServicios.Columns.Add("Meta", "Meta")
        Me.dgvRequerimientoServicios.Columns.Add("UO", "UO")
        Me.dgvRequerimientoServicios.Columns.Add("CA", "CA")
        Me.dgvRequerimientoServicios.Columns.Add("Codigo_Grupo", "Codigo_Grupo")
        Me.dgvRequerimientoServicios.Columns.Add("Codigo_Clase", "Codigo_Clase")
        Me.dgvRequerimientoServicios.Columns.Add("Codigo_Familia", "Codigo_Familia")
        Me.dgvRequerimientoServicios.Columns.Add("Codigo_Item", "Codigo_Item")
        Me.dgvRequerimientoServicios.Columns.Add("Codigo", "Codigo")
        Me.dgvRequerimientoServicios.Columns.Add("Item", "Item")
        Me.dgvRequerimientoServicios.Columns.Add("Codigo_Unidad_Medida", "Codigo_Unidad_Medida")
        Me.dgvRequerimientoServicios.Columns.Add("Unidad", "Unidad")
        Me.dgvRequerimientoServicios.Columns.Add("Cantidad", "Cantidad")
        Me.dgvRequerimientoServicios.Columns.Add("Costo", "Costo")
        Me.dgvRequerimientoServicios.Columns.Add("Cadena", "Cadena")
        Me.dgvRequerimientoServicios.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvRequerimientoServicios.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.dgvRequerimientoServicios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(0).Width = 55
        Me.dgvRequerimientoServicios.Columns(1).Width = 40
        Me.dgvRequerimientoServicios.Columns(2).Width = 40
        Me.dgvRequerimientoServicios.Columns(3).Width = 0
        Me.dgvRequerimientoServicios.Columns(4).Width = 0
        Me.dgvRequerimientoServicios.Columns(5).Width = 0
        Me.dgvRequerimientoServicios.Columns(6).Width = 0
        Me.dgvRequerimientoServicios.Columns(7).Width = 0
        Me.dgvRequerimientoServicios.Columns(8).Width = 0
        Me.dgvRequerimientoServicios.Columns(9).Width = 95
        Me.dgvRequerimientoServicios.Columns(10).Width = 65
        Me.dgvRequerimientoServicios.Columns(11).Width = 45
        Me.dgvRequerimientoServicios.Columns(12).Width = 45
        Me.dgvRequerimientoServicios.Columns(13).Width = 0
        Me.dgvRequerimientoServicios.Columns(14).Width = 0
        Me.dgvRequerimientoServicios.Columns(15).Width = 0
        Me.dgvRequerimientoServicios.Columns(16).Width = 0
        Me.dgvRequerimientoServicios.Columns(17).Width = 110
        Me.dgvRequerimientoServicios.Columns(18).Width = 280
        Me.dgvRequerimientoServicios.Columns(19).Width = 0
        Me.dgvRequerimientoServicios.Columns(22).Width = 100
        Me.dgvRequerimientoServicios.Columns(3).Visible = False
        Me.dgvRequerimientoServicios.Columns(4).Visible = False
        Me.dgvRequerimientoServicios.Columns(5).Visible = False
        Me.dgvRequerimientoServicios.Columns(6).Visible = False
        Me.dgvRequerimientoServicios.Columns(7).Visible = False
        Me.dgvRequerimientoServicios.Columns(8).Visible = False
        Me.dgvRequerimientoServicios.Columns(13).Visible = False
        Me.dgvRequerimientoServicios.Columns(14).Visible = False
        Me.dgvRequerimientoServicios.Columns(15).Visible = False
        Me.dgvRequerimientoServicios.Columns(16).Visible = False
        Me.dgvRequerimientoServicios.Columns(19).Visible = False
        Me.dgvRequerimientoServicios.Columns(23).Visible = False
        Me.dgvRequerimientoServicios.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoServicios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoServicios.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoServicios.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequerimientoServicios.ColumnHeadersHeight = 25
        Me.dgvRequerimientoServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Dim Boton1 As New DataGridViewButtonColumn
        With Boton1
            .Name = "btnEditar"
            .HeaderText = "Editar"
            .Text = "Editar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 24
        End With
        dgvRequerimientoServicios.Columns.Add(Boton1)
        dgvRequerimientoServicios.Columns(24).Width = 100
        Dim Boton2 As New DataGridViewButtonColumn
        With Boton2
            .Name = "btnEliminar"
            .HeaderText = "Eliminar"
            .Text = "Eliminar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 25
        End With
        dgvRequerimientoServicios.Columns.Add(Boton2)
        dgvRequerimientoServicios.Columns(25).Width = 100
        Dim Boton3 As New DataGridViewButtonColumn
        With Boton3
            .Name = "btnLimpiar"
            .HeaderText = "Limpiar"
            .Text = "Limpiar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 26
        End With
        dgvRequerimientoServicios.Columns.Add(Boton3)
        dgvRequerimientoServicios.Columns(26).Width = 100
    End Sub
    Private Function ValidarSaldos() As Boolean
        ValidarSaldos = False
        If ValidarRequerimientoServicioSaldos Then
            If Convert.ToDecimal(txtCantidad.Text)*Convert.ToDecimal(txtCosto.Text)<=Convert.ToDecimal(txtSaldoMes.Text)
                ValidarSaldos=False
            Else
                MessageBox.Show("El monto asignado supera el saldo del mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                ValidarSaldos = True
            End If
        End If
        Return ValidarSaldos
    End Function
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
            If Me.cbFF.Text.Trim.Length > 0 Then
                If Me.cbRubro.Text.Trim.Length > 0 Then
                    If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                        If Me.cbActividad.Text.Trim.Length > 0 Then
                            If Me.txtTipoTransaccion.Text.Trim.Length > 0 Then
                                If Convert.ToDouble(Me.txtTipoTransaccion.Text.Trim) > 0 Then
                                    If Me.txtItem.Text.Trim.Length > 0 Then
                                        If Me.txtCantidad.Text.Trim.Length > 0 Then
                                            If Me.txtCosto.Text.Trim.Length > 0 Then
                                                If Convert.ToDouble(Me.txtCantidad.Text.Trim) > 0 Then
                                                    If Datos.Verificar_Duplicidad_Grid_Requerimiento(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.dgvRequerimientoServicios) = True Then
                                                        If ValidarSaldos() Then return
                                                        Me.dgvRequerimientoServicios.Rows.Add()
                                                        dgvRequerimientoServicios.Item(0, dgvRequerimientoServicios.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                                                        dgvRequerimientoServicios.Item(1, dgvRequerimientoServicios.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                                                        dgvRequerimientoServicios.Item(2, dgvRequerimientoServicios.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                                                        dgvRequerimientoServicios.Item(3, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim
                                                        dgvRequerimientoServicios.Item(4, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtGenerica.Text.Trim
                                                        dgvRequerimientoServicios.Item(5, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtSubGenerica.Text.Trim
                                                        dgvRequerimientoServicios.Item(6, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtSubGenericaDetalle.Text.Trim
                                                        dgvRequerimientoServicios.Item(7, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtEspecifica.Text.Trim
                                                        dgvRequerimientoServicios.Item(8, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtEspecificaDetalle.Text.Trim
                                                        dgvRequerimientoServicios.Item(9, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim.Trim & "." & Me.txtGenerica.Text.Trim & "." & Me.txtSubGenerica.Text.Trim & "." & Me.txtSubGenericaDetalle.Text.Trim & "." & Me.txtEspecifica.Text.Trim & "." & Me.txtEspecificaDetalle.Text.Trim
                                                        dgvRequerimientoServicios.Item(10, dgvRequerimientoServicios.Rows.Count - 1).Value = Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString
                                                        dgvRequerimientoServicios.Item(11, dgvRequerimientoServicios.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                                                        dgvRequerimientoServicios.Item(12, dgvRequerimientoServicios.Rows.Count - 1).Value = Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                        dgvRequerimientoServicios.Item(13, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim
                                                        dgvRequerimientoServicios.Item(14, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtCodigoClase.Text.Trim
                                                        dgvRequerimientoServicios.Item(15, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtCodigoFamilia.Text.Trim
                                                        dgvRequerimientoServicios.Item(16, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtCodigoItem.Text.Trim
                                                        dgvRequerimientoServicios.Item(17, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                        dgvRequerimientoServicios.Item(18, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtItem.Text
                                                        dgvRequerimientoServicios.Item(19, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                        dgvRequerimientoServicios.Item(20, dgvRequerimientoServicios.Rows.Count - 1).Value = Me.txtUnidadMedida.Text
                                                        dgvRequerimientoServicios.Item(21, dgvRequerimientoServicios.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                        dgvRequerimientoServicios.Item(22, dgvRequerimientoServicios.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00")
                                                        dgvRequerimientoServicios.Item(23, dgvRequerimientoServicios.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                        Call ReiniciarCampos()
                                                        Me.cbUnidadOrganica.Enabled = False
                                                        Me.btnBuscarItems.Focus()
                                                        ValidarRequerimientoServicioSaldos = True
                                                    Else
                                                        MessageBox.Show("Ya exite en el Detalle el Item del Catalogo con la misma FF,RB,Meta,Actividad y Unidad Orgánica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                    End If
                                                Else
                                                    MessageBox.Show("La Cantidad debe ser Mayor a Cero (0)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                                    Me.txtCantidad.Focus()
                                                End If
                                            Else
                                                MessageBox.Show("Debes Ingresar el Costo Referencial", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                                Me.txtCosto.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes Ingresar la Cantidad/Importe de Items a solicitar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                            Me.txtItem.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes seleccionar un Item del Catalogo para el detalle del requerimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                        Me.btnBuscarItems.Focus()
                                    End If
                                Else
                                    MessageBox.Show("El Clasificador ingresado no es correcto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                    Me.btnBuscarItems.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar un Item y el Clasificador Presupuestario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                Me.btnBuscarItems.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar la Actividad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            Me.cbActividad.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar la Meta y/o Secuencia Funcional Presupuestaria", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        Me.cbSecuenciaFuncional.Focus()
                    End If
                Else
                    MessageBox.Show("Debes seleccionar el Rubro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    Me.cbRubro.Focus()
                End If
            Else
                MessageBox.Show("Debes seleccionar la Fuente de Financiamiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                Me.cbFF.Focus()
            End If
        Else
            MessageBox.Show("Debes seleccionar la Unidad Organica que Emite el Requerimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            Me.cbUnidadOrganica.Focus()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRequerimientoServicios.CellContentClick
        If dgvRequerimientoServicios.Columns(e.ColumnIndex).Name = "btnEliminar" Then
            Me.dgvRequerimientoServicios.Rows.Remove(Me.dgvRequerimientoServicios.CurrentRow)
            If Me.dgvRequerimientoServicios.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
        End If
        If dgvRequerimientoServicios.Columns(e.ColumnIndex).Name = "btnEditar" Then
            Datos.Llenar_Componentes(Me.dgvRequerimientoServicios.CurrentRow.Cells(3).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(4).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(5).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(6).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(7).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(8).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(1).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(2).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(11).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(10).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(12).Value)
            Me.txtTipoTransaccion.Text = Variable_Tipo_Transaccion
            Me.txtGenerica.Text = Variable_Generica
            Me.txtSubGenerica.Text = Variable_SubGenerica
            Me.txtSubGenericaDetalle.Text = Variable_SubGenerica_Detalle
            Me.txtEspecifica.Text = Variable_Especifica
            Me.txtEspecificaDetalle.Text = Variable_Especifica_Detalle
            Me.cbUnidadOrganica.Text = Variable_Unidad_Organica
            Me.cbSecuenciaFuncional.Text = Variable_Secuencia_Funcional
            Me.cbActividad.Text = Variable_Actividad
            Me.cbFF.Text = Variable_FF
            Me.cbRubro.Text = Variable_Rubro
            Datos.Mostrar_Data_Item_Catalogo(Me.dgvRequerimientoServicios.CurrentRow.Cells(13).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(14).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(15).Value, Me.dgvRequerimientoServicios.CurrentRow.Cells(16).Value, 2, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            Me.txtCantidad.Text = Format(Convert.ToDouble(Me.dgvRequerimientoServicios.CurrentRow.Cells(21).Value), "###,###,#.00")
            Me.txtCosto.Text = Format(Convert.ToDouble(Me.dgvRequerimientoServicios.CurrentRow.Cells(22).Value), "###,###,#.00")
            Me.dgvRequerimientoServicios.Rows.Remove(Me.dgvRequerimientoServicios.CurrentRow)
            If Me.dgvRequerimientoServicios.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            Call Verifica_Existencia_Item("Grilla")
            Call Evalua_Saldo_del_Mes()
            Call Evalua_Saldo_del_Mes_Acumulado()
            'if Me.dgvRequerimientoServicios.CurrentRow IsNot Nothing Then
            '    Me.txtCosto.Text = Format(Convert.ToDouble(Me.dgvRequerimientoServicios.CurrentRow.Cells(22).Value), "###,###,#.00")
            'End If
        End If
        If dgvRequerimientoServicios.Columns(e.ColumnIndex).Name = "btnLimpiar" Then
            Me.dgvRequerimientoServicios.Rows.Clear()
            Me.cbUnidadOrganica.Enabled = True
            If Me.dgvRequerimientoServicios.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            If txtCodigoGrupo.Text.Length>0 Then
                'Call Verifica_Existencia_Item()
                Call Evalua_Saldo_del_Mes()
                Call Evalua_Saldo_del_Mes_Acumulado()
            End If
        End If
    End Sub
    Private Sub ReiniciarCampos()
        Me.txtCodigoGrupo.Text = ""
        Me.txtGrupo.Text = ""
        Me.txtCodigoClase.Text = ""
        Me.txtClase.Text = ""
        Me.txtCodigoFamilia.Text = ""
        Me.txtFamilia.Text = ""
        Me.txtCodigoItem.Text = ""
        Me.txtItem.Text = ""
        Me.txtCodigoUnidadMedida.Text = ""
        Me.txtUnidadMedida.Text = ""
        Me.txtTipoTransaccion.Text = ""
        Me.txtGenerica.Text = ""
        Me.txtSubGenerica.Text = ""
        Me.txtSubGenericaDetalle.Text = ""
        Me.txtEspecifica.Text = ""
        Me.txtEspecificaDetalle.Text = ""
        Me.txtSaldo.Text = "0.00"
        Me.txtCantidad.Text = "0.00"
        Me.txtCosto.Text = "0.00"
        txtSaldoMes.Text="0.00"
        txtSaldoTotalCN.Text="0.00"
        Variable_Codigo_Catalogo = ""
        Variable_Codigo_Grupo = ""
        Variable_Codigo_Clase = ""
        Variable_Codigo_Familia = ""
        Variable_Codigo_Item = ""
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRequerimientoServicios.CellFormatting
        If Me.dgvRequerimientoServicios.Columns(e.ColumnIndex).Name = "Monto" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
    End Sub
    Private Sub txtCantidad_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Enter
        txtCantidad.SelectionStart = 0
        txtCantidad.SelectionLength = txtCantidad.Text.Length
    End Sub
    Private Sub txtCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.SelectionStart = 0
        txtCantidad.SelectionLength = txtCantidad.Text.Length
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If txtCantidad.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            Call Me.txtCantidad_Leave(sender, e)
            Me.txtCosto.Focus()
        End If
    End Sub
    Private Sub txtCantidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        If Me.txtCantidad.Text.Trim.Length > 0 Then
            Me.txtCantidad.Text = FormatNumber(txtCantidad.Text, 2, , , TriState.True)
        Else
            Me.txtCantidad.Text = "0.00"
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Editar = False Then
            If Me.dgvRequerimientoServicios.RowCount > 0 Then
                If Me.txtJustificacion.Text.Trim.Length > 0 Then
                    Dim Numero As String = Datos.Generar_Numero_Requerimiento_Servicios(My.Settings.Año_Ejecucion)
                    Datos.Nuevo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Numero, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Me.txtJustificacion.Text.Trim, Today.Date, My.Settings.Usuario, "01", Me.Total)
                    
                    For Recorrido As Integer = 0 To Me.dgvRequerimientoServicios.RowCount - 1
                        Datos.Nuevo_Detalle_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Numero, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(1).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(2).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(3).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(4).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(5).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(6).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(7).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(8).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(10).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(11).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(12).Value, "02", Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(13).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(14).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(15).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(16).Value, Convert.ToDouble(Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(21).Value), Convert.ToDouble(Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(22).Value))
                    Next
                    Me.Close()
                Else
                    MessageBox.Show("Debes ingresar la Justificación del Requerimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtJustificacion.Focus()
                End If
            Else
                MessageBox.Show("Debes ingresar el detalle del Requerimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.btnBuscarItems.Focus()
            End If
        Else
            If Me.dgvRequerimientoServicios.RowCount > 0 Then
                If Me.txtJustificacion.Text.Trim.Length > 0 Then
                    Datos.Eliminar_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, False,My.Settings.Usuario)
                    Datos.Modificar_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Me.txtJustificacion.Text.Trim, Me.Total)
                    
                    For Recorrido As Integer = 0 To Me.dgvRequerimientoServicios.RowCount - 1
                        Datos.Nuevo_Detalle_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(1).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(2).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(3).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(4).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(5).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(6).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(7).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(8).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(10).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(11).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(12).Value, "02", Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(13).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(14).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(15).Value, Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(16).Value, Convert.ToDouble(Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(21).Value), Convert.ToDouble(Me.dgvRequerimientoServicios.Rows(Recorrido).Cells(22).Value))
                    Next
                    'Dim Correlativo As String = Datos.Generar_Numero_Correlativo_Certificado(My.Settings.Año_Ejecucion, Variable_Numero_Certificacion)
                    'For Recorrido As Integer = 0 To Me.DataGridView1.RowCount - 1
                    '    Datos.Nuevo_Detalle_Certificado_Movimiento(Correlativo, "01", Me.DataGridView1.Rows(Recorrido).Cells(0).Value, Variable_Numero_Certificacion, Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells(1).Value), Me.DataGridView1.Rows(Recorrido).Cells(2).Value, Me.DataGridView1.Rows(Recorrido).Cells(3).Value, Me.DataGridView1.Rows(Recorrido).Cells(4).Value, Me.DataGridView1.Rows(Recorrido).Cells(5).Value, Me.DataGridView1.Rows(Recorrido).Cells(6).Value, Me.DataGridView1.Rows(Recorrido).Cells(7).Value, Me.DataGridView1.Rows(Recorrido).Cells(8).Value, Me.DataGridView1.Rows(Recorrido).Cells(10).Value, Me.DataGridView1.Rows(Recorrido).Cells(11).Value, Me.DataGridView1.Rows(Recorrido).Cells(12).Value, Variable_Numero_Certificacion, Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells(13).Value), "01")
                    'Next
                    Me.Close()
                Else
                    MessageBox.Show("Debes ingresar la Justificación del Requerimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtJustificacion.Focus()
                End If
            Else
                MessageBox.Show("Debes ingresar el detalle del Requerimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.btnBuscarItems.Focus()
            End If
        End If
    End Sub
    Private Function Total() As Double
        Total = 0
        
        If Me.dgvRequerimientoServicios.RowCount > 0 Then
            For Recorrido As Integer = 0 To dgvRequerimientoServicios.RowCount - 1
                Total = Total + (Convert.ToDouble(Me.dgvRequerimientoServicios.Rows(Recorrido).Cells("Cantidad").Value) * Convert.ToDouble(Me.dgvRequerimientoServicios.Rows(Recorrido).Cells("Costo").Value))
            Next
        Else
            Total = 0
        End If
        Return Total
    End Function
    Private Sub Evaluar_Saldos()
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
            If Me.cbFF.Text.Trim.Length > 0 Then
                If Me.cbRubro.Text.Trim.Length > 0 Then
                    If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                        If Me.cbActividad.Text.Trim.Length > 0 Then
                            If Me.txtTipoTransaccion.Text.Trim.Length > 0 Then
                                If Me.txtGenerica.Text.Trim.Length > 0 Then
                                    If Me.txtSubGenerica.Text.Trim.Length > 0 Then
                                        If Me.txtSubGenericaDetalle.Text.Trim.Length > 0 Then
                                            If Me.txtEspecifica.Text.Trim.Length > 0 Then
                                                If Me.txtEspecificaDetalle.Text.Trim.Length > 0 Then
                                                    Me.txtSaldo.Text = Format(Datos.Saldo(Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString), Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString, Me.txtTipoTransaccion.Text.Trim, Me.txtGenerica.Text.Trim, Me.txtSubGenerica.Text.Trim, Me.txtSubGenericaDetalle.Text.Trim, Me.txtEspecifica.Text.Trim, Me.txtEspecificaDetalle.Text.Trim, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
                                                End If
                                            Else
                                                Me.txtSaldo.Text = ""
                                            End If
                                        Else
                                            Me.txtSaldo.Text = ""
                                        End If
                                    Else
                                        Me.txtSaldo.Text = ""
                                    End If
                                Else
                                    Me.txtSaldo.Text = ""
                                End If
                            Else
                                Me.txtSaldo.Text = ""
                            End If
                        Else
                            Me.txtSaldo.Text = ""
                        End If
                    Else
                        Me.txtSaldo.Text = ""
                    End If
                Else
                    Me.txtSaldo.Text = ""
                End If
            Else
                Me.txtSaldo.Text = ""
            End If
        Else
            Me.txtSaldo.Text = ""
        End If
    End Sub
    Private Sub cbRubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRubro.SelectedIndexChanged
        If Me.cbRubro.Text.Trim.Length > 0 Then Call Asigna_Item_Segun_Filtro()
    End Sub
    Private Sub cbActividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbActividad.SelectedIndexChanged
        If cbActividad.Text.Trim.Length > 0 Then Call Asigna_Item_Segun_Filtro()
    End Sub
    Private Sub btnBuscarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarItems.Click
        if cbFF.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar una Fuente de financiamiento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        if cbRubro.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar un Rubro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
        Formulario.Operacion = 2
        Formulario.Tipo_Catalogo = "02"
        Formulario.ShowDialog()
        Call Asigna_Item_Segun_Filtro()
    End Sub
    Private sub Asigna_Item_Segun_Filtro()
        If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
            Datos.Mostrar_Data_Item_Catalogo(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, 2, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            Call Verifica_Existencia_Item("Buscar")
        Else
            Me.txtCodigoGrupo.Text = ""
            Me.txtGrupo.Text = ""
            Me.txtCodigoClase.Text = ""
            Me.txtClase.Text = ""
            Me.txtCodigoFamilia.Text = ""
            Me.txtFamilia.Text = ""
            Me.txtCodigoItem.Text = ""
            Me.txtItem.Text = ""
            Me.txtCodigoUnidadMedida.Text = ""
            Me.txtUnidadMedida.Text = ""
            Me.txtTipoTransaccion.Text = ""
            Me.txtGenerica.Text = ""
            Me.txtSubGenerica.Text = ""
            Me.txtSubGenericaDetalle.Text = ""
            Me.txtEspecifica.Text = ""
            Me.txtEspecificaDetalle.Text = ""

            txtCantidad.Text="0.00"
            txtSaldoMes.Text="0.00"
            txtSaldo.Text= "0.00"
            txtSaldoTotalCN.Text="0.00"
            txtCosto.Text="0.00"
        End If
    End sub
    Private sub Verifica_Existencia_Item(origen As String)
        Try
            If origen = "Buscar"
                if (Datos.Verifica_Si_Existe_en_CN_AM(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia,
                                             Variable_Codigo_Item, 2,
                                             Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString))
                
                    txtCosto.Text = Format(Datos.Precio_ref_CN(txtCodigoGrupo.Text, txtCodigoClase.Text, txtCodigoFamilia.Text, txtCodigoItem.Text, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
                    txtCantidad.Focus()
                    Call Evalua_Saldo_del_Mes()
                    Call Evalua_Saldo_del_Mes_Acumulado()
                    ValidarRequerimientoServicioSaldos = True
                Else
                   If MessageBox.Show("El Item Seleccionado no se ha encontrado en el Cuadro de Necesidades de la Unidad Organica Seleccionada." + 
                                      Environment.NewLine+"¿Desea Agregarlo de todas Formas?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                        Me.txtCodigoGrupo.Text = ""
                        Me.txtGrupo.Text = ""
                        Me.txtCodigoClase.Text = ""
                        Me.txtClase.Text = ""
                        Me.txtCodigoFamilia.Text = ""
                        Me.txtFamilia.Text = ""
                        Me.txtCodigoItem.Text = ""
                        Me.txtItem.Text = ""
                        Me.txtCodigoUnidadMedida.Text = ""
                        Me.txtUnidadMedida.Text = ""
                        Me.txtTipoTransaccion.Text = ""
                        Me.txtGenerica.Text = ""
                        Me.txtSubGenerica.Text = ""
                        Me.txtSubGenericaDetalle.Text = ""
                        Me.txtEspecifica.Text = ""
                        Me.txtEspecificaDetalle.Text = ""

                        Variable_Codigo_Catalogo = ""
                        Variable_Codigo_Grupo = ""
                        Variable_Codigo_Clase = ""
                        Variable_Codigo_Familia = ""
                        Variable_Codigo_Item = ""

                        txtCantidad.Text="0.00"
                        txtSaldoMes.Text="0.00"
                        txtSaldo.Text= "0.00"
                        txtSaldoTotalCN.Text="0.00"
                        txtCosto.Text="0.00"
                        'txtCosto.ReadOnly=True
                        ValidarRequerimientoServicioSaldos=True
                    Else
                        txtCantidad.Text="0.00"
                        txtSaldoMes.Text="0.00"
                        txtSaldo.Text="0.00"
                        txtSaldoTotalCN.Text="0.00"
                        txtCosto.Text="0.00"
                        txtCantidad.focus()
                        ValidarRequerimientoServicioSaldos=False
                   End If
                End If
            Else
                if (Datos.Verifica_Si_Existe_en_CN_AM(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia,
                                             Variable_Codigo_Item, 2,
                                             Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString))
                
                    ValidarRequerimientoServicioSaldos = True
                Else
                    ValidarRequerimientoServicioSaldos = False
                End If
            End If
            
        Catch ex As Exception
            'Sin errores
        End Try
    End sub
    Private Sub Evalua_Saldo_del_Mes()
        Me.txtSaldoMes.Text = Format(Datos.Evalua_Saldo_del_Mes(Obtiene_Mes_Actual(),Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString), 
                                                                Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,Variable_Codigo_Grupo, Variable_Codigo_Clase, 
                                                                Variable_Codigo_Familia, Variable_Codigo_Item, 
                                                                Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, 
                                                                Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, 
                                                                Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, 
                                                                My.Settings.Año_Ejecucion.ToString)-
                                                                Saldo_Grilla(Me.txtCodigoGrupo.Text.Trim,
                                                                    Me.txtCodigoClase.Text.Trim,
                                                                    Me.txtCodigoFamilia.Text.Trim,
                                                                    Me.txtCodigoItem.Text.Trim,
                                                                    Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                                                    Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                                                    Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
    End Sub
    Private Sub Evalua_Saldo_del_Mes_Acumulado()
        Dim acululado_Mes as Decimal

        For i as integer = 1 To 12
            acululado_Mes = acululado_Mes + Datos.Evalua_Saldo_del_Mes(i,Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString), Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString)
        Next

        Me.txtSaldoTotalCN.Text = Format(acululado_Mes - Saldo_Grilla(Me.txtCodigoGrupo.Text.Trim,
                                                                    Me.txtCodigoClase.Text.Trim,
                                                                    Me.txtCodigoFamilia.Text.Trim,
                                                                    Me.txtCodigoItem.Text.Trim,
                                                                    Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                                                    Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                                                    Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
    End Sub
    Private Function Saldo_Grilla(ByVal Codigo_Grupo As Integer, ByVal Codigo_Clase As String, ByVal Codigo_Familia As String, ByVal Codigo_Item As String,
                                 ByVal Meta As String, ByVal UO As String, ByVal CA As String, ByVal Año_Ejecucion As String) As Double
         Dim total_Item As Double
        Dim Acumulado As Double

        total_Item = 0

        For Each row As DataGridViewRow In dgvRequerimientoServicios.Rows
            'if (row.Cells("Codigo_Grupo").Value = Codigo_Grupo And row.Cells("Codigo_Clase").Value = Codigo_Clase And
            '        row.Cells("Codigo_Familia").Value = Codigo_Familia And row.Cells("Codigo_Item").Value = Codigo_Item And 
            '        row.Cells("Meta").Value = Meta And row.Cells("UO").Value = UO And
            '    row.Cells("CA").Value = CA and row.Cells("Año").Value = Año_Ejecucion)
            if (row.Cells("Codigo_Grupo").Value = Codigo_Grupo And row.Cells("Codigo_Clase").Value = Codigo_Clase And
                    row.Cells("Codigo_Familia").Value = Codigo_Familia And row.Cells("Codigo_Item").Value = Codigo_Item And 
                    row.Cells("UO").Value = UO And
                    row.Cells("Año").Value = Año_Ejecucion)

                Acumulado = (Convert.ToDouble(IIf(row.Cells("Cantidad").Value.ToString() = string.Empty, "0.00", row.Cells("Cantidad").Value))*
                    Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = string.Empty, "0.00", row.Cells("Costo").Value)))

                total_Item = total_Item + Acumulado

            end If
        Next
        Return total_Item
    End Function
    Public Function Obtiene_Mes_Actual() As String
        Return Datos.Obtiene_Mes_Actual()
    End Function
    Private Sub txtCosto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCosto.Enter
        txtCosto.SelectionStart = 0
        txtCosto.SelectionLength = txtCosto.Text.Length
    End Sub
    Private Sub txtCosto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCosto.GotFocus
        txtCosto.SelectionStart = 0
        txtCosto.SelectionLength = txtCosto.Text.Length
    End Sub
    Private Sub txtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress
        If txtCosto.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            Call Me.txtCosto_Leave(sender, e)
            Call Me.btnAgregar_Click(sender, e)
        End If
    End Sub
    Private Sub txtCosto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCosto.Leave
        If Me.txtCosto.Text.Trim.Length > 0 Then
            Me.txtCosto.Text = FormatNumber(txtCosto.Text, 2, , , TriState.True)
        Else
            Me.txtCosto.Text = "0.00"
        End If
    End Sub
End Class