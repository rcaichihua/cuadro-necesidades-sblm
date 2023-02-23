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
    Dim Separador As Char
    Private Sub frmRegistro_Requerimiento_Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        If Editar = False Then
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")
            Call Me.Dimensionar()
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Else
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")
            Call Me.Dimensionar()
            Datos.Cargar_Requerimiento_Servicio_Para_Modificacion(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Me.DataGridView1, Me.cbUnidadOrganica, Me.txtJustificacion)
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
            Call Me.Evaluar_Saldos()
        Else
            Me.cbRubro.DataSource = Nothing
            Call Me.Evaluar_Saldos()
        End If
    End Sub
    Private Sub cbUnidadOrganica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidadOrganica.SelectedIndexChanged
        Me.cbSecuenciaFuncional.DataSource = Nothing
        Me.cbActividad.DataSource = Nothing
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
            Secuencia_Funcional = Datos.LLenar_Combo_Solo("Select * From Lista_Secuencias Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbSecuenciaFuncional, "Codigo_Secuencia_Funcional")
            Me.cbSecuenciaFuncional.SelectedIndex = 0
            Call Me.Evaluar_Saldos()
        Else
            Me.cbSecuenciaFuncional.DataSource = Nothing
            Call Me.Evaluar_Saldos()
        End If
    End Sub
    Private Sub cbSecuenciaFuncional_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSecuenciaFuncional.SelectedIndexChanged
        Me.cbActividad.DataSource = Nothing
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
            Call Me.Evaluar_Saldos()
            If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                Actividad = Datos.LLenar_Combo_Solo("Select * From Lista_Actividades Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Secuencia_Funcional='" & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional") & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbActividad, "Actividad")
                Call Me.Evaluar_Saldos()
                Me.cbActividad.SelectedIndex = 0
            Else
                Call Me.Evaluar_Saldos()
                Me.cbActividad.DataSource = Nothing
            End If
        Else
            Call Me.Evaluar_Saldos()
            Me.cbActividad.DataSource = Nothing
        End If
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Año", "Año")
        Me.DataGridView1.Columns.Add("FF", "FF")
        Me.DataGridView1.Columns.Add("R", "R")
        Me.DataGridView1.Columns.Add("TT", "TT")
        Me.DataGridView1.Columns.Add("G", "G")
        Me.DataGridView1.Columns.Add("SG", "SG")
        Me.DataGridView1.Columns.Add("SGD", "SGD")
        Me.DataGridView1.Columns.Add("E", "E")
        Me.DataGridView1.Columns.Add("ED", "ED")
        Me.DataGridView1.Columns.Add("Clasificador", "Clasificador")
        Me.DataGridView1.Columns.Add("Meta", "Meta")
        Me.DataGridView1.Columns.Add("UO", "UO")
        Me.DataGridView1.Columns.Add("CA", "CA")
        Me.DataGridView1.Columns.Add("Codigo_Grupo", "Codigo_Grupo")
        Me.DataGridView1.Columns.Add("Codigo_Clase", "Codigo_Clase")
        Me.DataGridView1.Columns.Add("Codigo_Familia", "Codigo_Familia")
        Me.DataGridView1.Columns.Add("Codigo_Item", "Codigo_Item")
        Me.DataGridView1.Columns.Add("Codigo", "Codigo")
        Me.DataGridView1.Columns.Add("Item", "Item")
        Me.DataGridView1.Columns.Add("Codigo_Unidad_Medida", "Codigo_Unidad_Medida")
        Me.DataGridView1.Columns.Add("Unidad", "Unidad")
        Me.DataGridView1.Columns.Add("Cantidad", "Cantidad")
        Me.DataGridView1.Columns.Add("Costo", "Costo")
        Me.DataGridView1.Columns.Add("Cadena", "Cadena")
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(0).Width = 55
        Me.DataGridView1.Columns(1).Width = 40
        Me.DataGridView1.Columns(2).Width = 40
        Me.DataGridView1.Columns(3).Width = 0
        Me.DataGridView1.Columns(4).Width = 0
        Me.DataGridView1.Columns(5).Width = 0
        Me.DataGridView1.Columns(6).Width = 0
        Me.DataGridView1.Columns(7).Width = 0
        Me.DataGridView1.Columns(8).Width = 0
        Me.DataGridView1.Columns(9).Width = 95
        Me.DataGridView1.Columns(10).Width = 65
        Me.DataGridView1.Columns(11).Width = 45
        Me.DataGridView1.Columns(12).Width = 45
        Me.DataGridView1.Columns(13).Width = 0
        Me.DataGridView1.Columns(14).Width = 0
        Me.DataGridView1.Columns(15).Width = 0
        Me.DataGridView1.Columns(16).Width = 0
        Me.DataGridView1.Columns(17).Width = 110
        Me.DataGridView1.Columns(18).Width = 280
        Me.DataGridView1.Columns(19).Width = 0
        Me.DataGridView1.Columns(22).Width = 100
        Me.DataGridView1.Columns(3).Visible = False
        Me.DataGridView1.Columns(4).Visible = False
        Me.DataGridView1.Columns(5).Visible = False
        Me.DataGridView1.Columns(6).Visible = False
        Me.DataGridView1.Columns(7).Visible = False
        Me.DataGridView1.Columns(8).Visible = False
        Me.DataGridView1.Columns(13).Visible = False
        Me.DataGridView1.Columns(14).Visible = False
        Me.DataGridView1.Columns(15).Visible = False
        Me.DataGridView1.Columns(16).Visible = False
        Me.DataGridView1.Columns(19).Visible = False
        Me.DataGridView1.Columns(23).Visible = False
        Me.DataGridView1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
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
        DataGridView1.Columns.Add(Boton1)
        DataGridView1.Columns(24).Width = 100
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
        DataGridView1.Columns.Add(Boton2)
        DataGridView1.Columns(25).Width = 100
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
        DataGridView1.Columns.Add(Boton3)
        DataGridView1.Columns(26).Width = 100
    End Sub
    Private Function ValidarSaldos() As Boolean
        ValidarSaldos = False
        If txtCosto.ReadOnly
            If Convert.ToDecimal(txtCantidad.Text)<=Convert.ToDecimal(txtSaldoMes.Text)
                If (Convert.ToDecimal(txtCantidad.Text)*Convert.ToDecimal(txtCosto.Text)<=Convert.ToDecimal(txtSaldo.Text))
                    ValidarSaldos=False
                Else
                    MessageBox.Show("El total a agregar supera el saldo presupuestal.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    ValidarSaldos = True
                End If
            Else
                MessageBox.Show("El monto asignado supera el saldo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
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
                                                    If Datos.Verificar_Duplicidad_Grid_Global(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.DataGridView1) = True Then
                                                        If ValidarSaldos() Then return
                                                        Me.DataGridView1.Rows.Add()
                                                        DataGridView1.Item(0, DataGridView1.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                                                        DataGridView1.Item(1, DataGridView1.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                                                        DataGridView1.Item(2, DataGridView1.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                                                        DataGridView1.Item(3, DataGridView1.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim
                                                        DataGridView1.Item(4, DataGridView1.Rows.Count - 1).Value = Me.txtGenerica.Text.Trim
                                                        DataGridView1.Item(5, DataGridView1.Rows.Count - 1).Value = Me.txtSubGenerica.Text.Trim
                                                        DataGridView1.Item(6, DataGridView1.Rows.Count - 1).Value = Me.txtSubGenericaDetalle.Text.Trim
                                                        DataGridView1.Item(7, DataGridView1.Rows.Count - 1).Value = Me.txtEspecifica.Text.Trim
                                                        DataGridView1.Item(8, DataGridView1.Rows.Count - 1).Value = Me.txtEspecificaDetalle.Text.Trim
                                                        DataGridView1.Item(9, DataGridView1.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim.Trim & "." & Me.txtGenerica.Text.Trim & "." & Me.txtSubGenerica.Text.Trim & "." & Me.txtSubGenericaDetalle.Text.Trim & "." & Me.txtEspecifica.Text.Trim & "." & Me.txtEspecificaDetalle.Text.Trim
                                                        DataGridView1.Item(10, DataGridView1.Rows.Count - 1).Value = Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString
                                                        DataGridView1.Item(11, DataGridView1.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                                                        DataGridView1.Item(12, DataGridView1.Rows.Count - 1).Value = Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                        DataGridView1.Item(13, DataGridView1.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim
                                                        DataGridView1.Item(14, DataGridView1.Rows.Count - 1).Value = Me.txtCodigoClase.Text.Trim
                                                        DataGridView1.Item(15, DataGridView1.Rows.Count - 1).Value = Me.txtCodigoFamilia.Text.Trim
                                                        DataGridView1.Item(16, DataGridView1.Rows.Count - 1).Value = Me.txtCodigoItem.Text.Trim
                                                        DataGridView1.Item(17, DataGridView1.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                        DataGridView1.Item(18, DataGridView1.Rows.Count - 1).Value = Me.txtItem.Text
                                                        DataGridView1.Item(19, DataGridView1.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                        DataGridView1.Item(20, DataGridView1.Rows.Count - 1).Value = Me.txtUnidadMedida.Text
                                                        DataGridView1.Item(21, DataGridView1.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                        DataGridView1.Item(22, DataGridView1.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00")
                                                        DataGridView1.Item(23, DataGridView1.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
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
                                                        Variable_Codigo_Catalogo = ""
                                                        Variable_Codigo_Grupo = ""
                                                        Variable_Codigo_Clase = ""
                                                        Variable_Codigo_Familia = ""
                                                        Variable_Codigo_Item = ""
                                                        Me.cbUnidadOrganica.Enabled = False
                                                        Me.btnBuscarItems.Focus()
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
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "btnEliminar" Then
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
            If Me.DataGridView1.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "btnEditar" Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value, Me.DataGridView1.CurrentRow.Cells(7).Value, Me.DataGridView1.CurrentRow.Cells(8).Value, Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(11).Value, Me.DataGridView1.CurrentRow.Cells(10).Value, Me.DataGridView1.CurrentRow.Cells(12).Value)
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
            Me.txtCantidad.Text = Format(Convert.ToDouble(Me.DataGridView1.CurrentRow.Cells(21).Value), "###,###,#.00")
            Me.txtCosto.Text = Format(Convert.ToDouble(Me.DataGridView1.CurrentRow.Cells(22).Value), "###,###,#.00")
            Datos.Mostrar_Data_Item_Catalogo(Me.DataGridView1.CurrentRow.Cells(13).Value, Me.DataGridView1.CurrentRow.Cells(14).Value, Me.DataGridView1.CurrentRow.Cells(15).Value, Me.DataGridView1.CurrentRow.Cells(16).Value, 2, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
            If Me.DataGridView1.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            Call Me.Evaluar_Saldos()
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "btnLimpiar" Then
            Me.DataGridView1.Rows.Clear()
            Me.cbUnidadOrganica.Enabled = True
            If Me.DataGridView1.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
        End If
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Monto" Then
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
            If Me.DataGridView1.RowCount > 0 Then
                If Me.txtJustificacion.Text.Trim.Length > 0 Then
                    Dim Numero As String = Datos.Generar_Numero_Requerimiento_Servicios(My.Settings.Año_Ejecucion)
                    Datos.Nuevo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Numero, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Me.txtJustificacion.Text.Trim, Today.Date, My.Settings.Usuario, "01", Me.Total)
                    
                    For Recorrido As Integer = 0 To Me.DataGridView1.RowCount - 1
                        Datos.Nuevo_Detalle_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Numero, Me.DataGridView1.Rows(Recorrido).Cells(1).Value, Me.DataGridView1.Rows(Recorrido).Cells(2).Value, Me.DataGridView1.Rows(Recorrido).Cells(3).Value, Me.DataGridView1.Rows(Recorrido).Cells(4).Value, Me.DataGridView1.Rows(Recorrido).Cells(5).Value, Me.DataGridView1.Rows(Recorrido).Cells(6).Value, Me.DataGridView1.Rows(Recorrido).Cells(7).Value, Me.DataGridView1.Rows(Recorrido).Cells(8).Value, Me.DataGridView1.Rows(Recorrido).Cells(10).Value, Me.DataGridView1.Rows(Recorrido).Cells(11).Value, Me.DataGridView1.Rows(Recorrido).Cells(12).Value, "02", Me.DataGridView1.Rows(Recorrido).Cells(13).Value, Me.DataGridView1.Rows(Recorrido).Cells(14).Value, Me.DataGridView1.Rows(Recorrido).Cells(15).Value, Me.DataGridView1.Rows(Recorrido).Cells(16).Value, Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells(21).Value), Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells(22).Value))
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
            If Me.DataGridView1.RowCount > 0 Then
                If Me.txtJustificacion.Text.Trim.Length > 0 Then
                    Datos.Eliminar_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, False,My.Settings.Usuario)
                    Datos.Modificar_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Me.txtJustificacion.Text.Trim, Me.Total)
                    
                    For Recorrido As Integer = 0 To Me.DataGridView1.RowCount - 1
                        Datos.Nuevo_Detalle_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Me.DataGridView1.Rows(Recorrido).Cells(1).Value, Me.DataGridView1.Rows(Recorrido).Cells(2).Value, Me.DataGridView1.Rows(Recorrido).Cells(3).Value, Me.DataGridView1.Rows(Recorrido).Cells(4).Value, Me.DataGridView1.Rows(Recorrido).Cells(5).Value, Me.DataGridView1.Rows(Recorrido).Cells(6).Value, Me.DataGridView1.Rows(Recorrido).Cells(7).Value, Me.DataGridView1.Rows(Recorrido).Cells(8).Value, Me.DataGridView1.Rows(Recorrido).Cells(10).Value, Me.DataGridView1.Rows(Recorrido).Cells(11).Value, Me.DataGridView1.Rows(Recorrido).Cells(12).Value, "02", Me.DataGridView1.Rows(Recorrido).Cells(13).Value, Me.DataGridView1.Rows(Recorrido).Cells(14).Value, Me.DataGridView1.Rows(Recorrido).Cells(15).Value, Me.DataGridView1.Rows(Recorrido).Cells(16).Value, Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells(21).Value), Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells(22).Value))
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
        
        If Me.DataGridView1.RowCount > 0 Then
            For Recorrido As Integer = 0 To DataGridView1.RowCount - 1
                Total = Total + (Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells("Cantidad").Value) * Convert.ToDouble(Me.DataGridView1.Rows(Recorrido).Cells("Costo").Value))
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
        If Me.cbRubro.Text.Trim.Length > 0 Then Call Me.Evaluar_Saldos()
    End Sub
    Private Sub cbActividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbActividad.SelectedIndexChanged
        If cbActividad.Text.Trim.Length > 0 Then Call Me.Evaluar_Saldos()
    End Sub
    Private Sub btnBuscarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarItems.Click
        Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
        Formulario.Operacion = 2
        Formulario.Tipo_Catalogo = "02"
        Formulario.ShowDialog()
        If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
            Datos.Mostrar_Data_Item_Catalogo(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, 2, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            if (Datos.Verifica_Si_Existe_en_CN_AM(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia,
                                             Variable_Codigo_Item, 2,
                                             Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString))
                
                txtCosto.Text = Format(Datos.Precio_ref_CN(txtCodigoGrupo.Text, txtCodigoClase.Text, txtCodigoFamilia.Text, txtCodigoItem.Text, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
                txtCosto.ReadOnly=True
                txtCantidad.Focus()
                Call Evaluar_Saldos()
                Call Evalua_Saldo_del_Mes()
                Call Evalua_Saldo_del_Acumulado()
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
                    txtCosto.ReadOnly=True
                Else
                    txtCantidad.Text="0.00"
                    txtSaldoMes.Text="0.00"
                    'txtSaldo.Text="0.00"
                    txtSaldoTotalCN.Text="0.00"
                    txtCosto.Text="0.00"
                    txtCosto.ReadOnly=false
               End If
            End If

            Me.txtCantidad.Focus()
            Call Me.Evaluar_Saldos()
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
        End If
    End Sub
    Private Sub Evalua_Saldo_del_Mes()
        Me.txtSaldoMes.Text = Format(Datos.Evalua_Saldo_del_Mes(Obtiene_Mes_Actual(),Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString), Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
    End Sub
    Private Sub Evalua_Saldo_del_Acumulado()
        Dim acululado_Mes as Decimal

        For i as integer = 1 To 12
            acululado_Mes = acululado_Mes + Datos.Evalua_Saldo_del_Mes(i,Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString), Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString)
        Next

        Me.txtSaldoTotalCN.Text = Format(acululado_Mes, "###,###,#.00")
    End Sub
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