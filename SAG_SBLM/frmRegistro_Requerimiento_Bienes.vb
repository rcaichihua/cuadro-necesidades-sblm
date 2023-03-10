Public Class frmRegistro_Requerimiento_Bienes
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
    Private Sub frmRegistro_Requerimiento_Bienes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Datos.Combo(Me.cbFF,"Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", "Codigo_FF","Fuente")
            Call Me.Dimensionar()
            Datos.Cargar_Requerimiento_Bien_Para_Modificacion(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Bien, Me.dgvRequerimientoBienes, Me.cbUnidadOrganica,cbFF,cbRubro,cbSecuenciaFuncional,cbActividad, txtJustificacion)
            Call Me.Total()
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        End If
        VerificaGrillaHabilitarCombos()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub cbFF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFF.SelectedIndexChanged
        Me.cbRubro.DataSource = Nothing
        If Me.cbFF.Text.Trim.Length > 0 Then
            Rubro = Datos.LLenar_Combo_Solo("Select * From Lista_Rubros Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF='" & Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF") & "'", Me.cbRubro, "Rubro")
            Datos.Combo(Me.cbRubro,"Select * From Lista_Rubros Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF='" & Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF") & "'", "Codigo_Rubro","Rubro")
            Call Me.Evaluar_Saldos()
        Else
            Me.cbRubro.DataSource = Nothing
            Call Me.Evaluar_Saldos()
        End If
    End Sub
    Private Sub cbUnidadOrganica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidadOrganica.SelectedIndexChanged
        Try
            Me.cbSecuenciaFuncional.DataSource = Nothing
            Me.cbActividad.DataSource = Nothing
            If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
                Secuencia_Funcional = Datos.LLenar_Combo_Solo("Select * From Lista_Secuencias Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbSecuenciaFuncional, "Codigo_Secuencia_Funcional")
                Datos.Combo(cbSecuenciaFuncional,"Select * From Lista_Secuencias Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", "Codigo_Secuencia_Funcional", "Codigo_Secuencia_Funcional")
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
                Datos.Combo(cbActividad,"Select * From Lista_Actividades Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Secuencia_Funcional='" & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional") & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", "Codigo_Actividad", "Actividad")
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
        Me.dgvRequerimientoBienes.Rows.Clear()
        Me.dgvRequerimientoBienes.Columns.Clear()
        Me.dgvRequerimientoBienes.Columns.Add("Año", "Año")
        Me.dgvRequerimientoBienes.Columns.Add("FF", "FF")
        Me.dgvRequerimientoBienes.Columns.Add("R", "R")
        Me.dgvRequerimientoBienes.Columns.Add("TT", "TT")
        Me.dgvRequerimientoBienes.Columns.Add("G", "G")
        Me.dgvRequerimientoBienes.Columns.Add("SG", "SG")
        Me.dgvRequerimientoBienes.Columns.Add("SGD", "SGD")
        Me.dgvRequerimientoBienes.Columns.Add("E", "E")
        Me.dgvRequerimientoBienes.Columns.Add("ED", "ED")
        Me.dgvRequerimientoBienes.Columns.Add("Clasificador", "Clasificador")'9
        Me.dgvRequerimientoBienes.Columns.Add("Meta", "Meta")'10
        Me.dgvRequerimientoBienes.Columns.Add("UO", "UO")
        Me.dgvRequerimientoBienes.Columns.Add("CA", "CA") '12
        Me.dgvRequerimientoBienes.Columns.Add("Codigo_Grupo", "Codigo_Grupo")
        Me.dgvRequerimientoBienes.Columns.Add("Codigo_Clase", "Codigo_Clase")
        Me.dgvRequerimientoBienes.Columns.Add("Codigo_Familia", "Codigo_Familia")
        Me.dgvRequerimientoBienes.Columns.Add("Codigo_Item", "Codigo_Item")
        Me.dgvRequerimientoBienes.Columns.Add("Codigo", "Codigo")'17
        Me.dgvRequerimientoBienes.Columns.Add("Item", "Item")
        Me.dgvRequerimientoBienes.Columns.Add("Codigo_Unidad_Medida", "Codigo_Unidad_Medida")
        Me.dgvRequerimientoBienes.Columns.Add("Unidad", "Unidad") '20
        Me.dgvRequerimientoBienes.Columns.Add("Cantidad", "Cantidad")
        Me.dgvRequerimientoBienes.Columns.Add("Costo", "Costo")'22
        Me.dgvRequerimientoBienes.Columns.Add("Ene.", "Ene.")
        Me.dgvRequerimientoBienes.Columns.Add("Feb.", "Feb.")
        Me.dgvRequerimientoBienes.Columns.Add("Mar.", "Mar.")
        Me.dgvRequerimientoBienes.Columns.Add("Abr.", "Abr.")
        Me.dgvRequerimientoBienes.Columns.Add("May.", "May.")
        Me.dgvRequerimientoBienes.Columns.Add("Jun.", "Jun.")
        Me.dgvRequerimientoBienes.Columns.Add("Jul.", "Jul.")
        Me.dgvRequerimientoBienes.Columns.Add("Ago.", "Ago.")
        Me.dgvRequerimientoBienes.Columns.Add("Sep.", "Sep.")
        Me.dgvRequerimientoBienes.Columns.Add("Oct.", "Oct.")
        Me.dgvRequerimientoBienes.Columns.Add("Nov.", "Nov.")
        Me.dgvRequerimientoBienes.Columns.Add("Dic.", "Dic.")
        Me.dgvRequerimientoBienes.Columns.Add("Cadena", "Cadena") '35
        Me.dgvRequerimientoBienes.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvRequerimientoBienes.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.dgvRequerimientoBienes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(0).Width = 55
        Me.dgvRequerimientoBienes.Columns(1).Width = 40
        Me.dgvRequerimientoBienes.Columns(2).Width = 40
        Me.dgvRequerimientoBienes.Columns(3).Width = 0
        Me.dgvRequerimientoBienes.Columns(4).Width = 0
        Me.dgvRequerimientoBienes.Columns(5).Width = 0
        Me.dgvRequerimientoBienes.Columns(6).Width = 0
        Me.dgvRequerimientoBienes.Columns(7).Width = 0
        Me.dgvRequerimientoBienes.Columns(8).Width = 0
        Me.dgvRequerimientoBienes.Columns(9).Width = 95
        Me.dgvRequerimientoBienes.Columns(10).Width = 65
        Me.dgvRequerimientoBienes.Columns(11).Width = 45
        Me.dgvRequerimientoBienes.Columns(12).Width = 45
        Me.dgvRequerimientoBienes.Columns(13).Width = 0
        Me.dgvRequerimientoBienes.Columns(14).Width = 0
        Me.dgvRequerimientoBienes.Columns(15).Width = 0
        Me.dgvRequerimientoBienes.Columns(16).Width = 0
        Me.dgvRequerimientoBienes.Columns(17).Width = 120
        Me.dgvRequerimientoBienes.Columns(18).Width = 280
        Me.dgvRequerimientoBienes.Columns(19).Width = 0
        Me.dgvRequerimientoBienes.Columns(22).Width = 100
        Me.dgvRequerimientoBienes.Columns(23).Width = 55
        Me.dgvRequerimientoBienes.Columns(24).Width = 55
        Me.dgvRequerimientoBienes.Columns(25).Width = 55
        Me.dgvRequerimientoBienes.Columns(26).Width = 55
        Me.dgvRequerimientoBienes.Columns(27).Width = 55
        Me.dgvRequerimientoBienes.Columns(28).Width = 55
        Me.dgvRequerimientoBienes.Columns(29).Width = 55
        Me.dgvRequerimientoBienes.Columns(30).Width = 55
        Me.dgvRequerimientoBienes.Columns(31).Width = 55
        Me.dgvRequerimientoBienes.Columns(32).Width = 55
        Me.dgvRequerimientoBienes.Columns(33).Width = 55
        Me.dgvRequerimientoBienes.Columns(34).Width = 55
        Me.dgvRequerimientoBienes.Columns(3).Visible = False
        Me.dgvRequerimientoBienes.Columns(4).Visible = False
        Me.dgvRequerimientoBienes.Columns(5).Visible = False
        Me.dgvRequerimientoBienes.Columns(6).Visible = False
        Me.dgvRequerimientoBienes.Columns(7).Visible = False
        Me.dgvRequerimientoBienes.Columns(8).Visible = False

        Me.dgvRequerimientoBienes.Columns(13).Visible = False
        Me.dgvRequerimientoBienes.Columns(14).Visible = False
        Me.dgvRequerimientoBienes.Columns(15).Visible = False
        Me.dgvRequerimientoBienes.Columns(16).Visible = False
        Me.dgvRequerimientoBienes.Columns(19).Visible = False
        Me.dgvRequerimientoBienes.Columns(35).Visible = False
        Me.dgvRequerimientoBienes.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRequerimientoBienes.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(32).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(33).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvRequerimientoBienes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequerimientoBienes.ColumnHeadersHeight = 25
        Me.dgvRequerimientoBienes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Dim Boton1 As New DataGridViewButtonColumn
        With Boton1
            .Name = "btnEditar"
            .HeaderText = "Editar"
            .Text = "Editar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 36
        End With
        dgvRequerimientoBienes.Columns.Add(Boton1)
        dgvRequerimientoBienes.Columns(36).Width = 100
        Dim Boton2 As New DataGridViewButtonColumn
        With Boton2
            .Name = "btnEliminar"
            .HeaderText = "Eliminar"
            .Text = "Eliminar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 37
        End With
        dgvRequerimientoBienes.Columns.Add(Boton2)
        dgvRequerimientoBienes.Columns(37).Width = 100
        Dim Boton3 As New DataGridViewButtonColumn
        With Boton3
            .Name = "btnLimpiar"
            .HeaderText = "Limpiar"
            .Text = "Limpiar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 38
        End With
        dgvRequerimientoBienes.Columns.Add(Boton3)
        dgvRequerimientoBienes.Columns(38).Width = 100
        Me.dgvRequerimientoBienes.Columns(36).Visible = False
    End Sub
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
                                                    If Datos.Verificar_Duplicidad_Grid_Requerimiento(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.dgvRequerimientoBienes) = True Then
                                                        If ValidarSaldos() Then return
                                                        Me.dgvRequerimientoBienes.Rows.Add()
                                                        dgvRequerimientoBienes.Item(0, dgvRequerimientoBienes.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                                                        dgvRequerimientoBienes.Item(1, dgvRequerimientoBienes.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                                                        dgvRequerimientoBienes.Item(2, dgvRequerimientoBienes.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                                                        dgvRequerimientoBienes.Item(3, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim
                                                        dgvRequerimientoBienes.Item(4, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtGenerica.Text.Trim
                                                        dgvRequerimientoBienes.Item(5, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtSubGenerica.Text.Trim
                                                        dgvRequerimientoBienes.Item(6, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtSubGenericaDetalle.Text.Trim
                                                        dgvRequerimientoBienes.Item(7, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtEspecifica.Text.Trim
                                                        dgvRequerimientoBienes.Item(8, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtEspecificaDetalle.Text.Trim
                                                        dgvRequerimientoBienes.Item(9, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim.Trim & "." & Me.txtGenerica.Text.Trim & "." & Me.txtSubGenerica.Text.Trim & "." & Me.txtSubGenericaDetalle.Text.Trim & "." & Me.txtEspecifica.Text.Trim & "." & Me.txtEspecificaDetalle.Text.Trim
                                                        dgvRequerimientoBienes.Item(10, dgvRequerimientoBienes.Rows.Count - 1).Value = Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString
                                                        dgvRequerimientoBienes.Item(11, dgvRequerimientoBienes.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                                                        dgvRequerimientoBienes.Item(12, dgvRequerimientoBienes.Rows.Count - 1).Value = Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                        dgvRequerimientoBienes.Item(13, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim
                                                        dgvRequerimientoBienes.Item(14, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtCodigoClase.Text.Trim
                                                        dgvRequerimientoBienes.Item(15, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtCodigoFamilia.Text.Trim
                                                        dgvRequerimientoBienes.Item(16, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtCodigoItem.Text.Trim
                                                        dgvRequerimientoBienes.Item(17, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                        dgvRequerimientoBienes.Item(18, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtItem.Text
                                                        dgvRequerimientoBienes.Item(19, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                        dgvRequerimientoBienes.Item(20, dgvRequerimientoBienes.Rows.Count - 1).Value = Me.txtUnidadMedida.Text
                                                        dgvRequerimientoBienes.Item(21, dgvRequerimientoBienes.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                        dgvRequerimientoBienes.Item(22, dgvRequerimientoBienes.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00")
                                                        dgvRequerimientoBienes.Item(23, dgvRequerimientoBienes.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                        ReiniciarCampos()
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
                                            MessageBox.Show("Debes Ingresar la Cantidad de Items a solicitar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
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
    Private sub ReiniciarCampos()
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
        'Me.cbUnidadOrganica.Enabled = False
        Me.btnBuscarItems.Focus()
    End sub
    Private Function ValidarSaldos() As Boolean
        ValidarSaldos = False
        If txtCosto.ReadOnly
            If Convert.ToDecimal(txtCantidad.Text)<=Convert.ToDecimal(txtSaldoMes.Text)
                ValidarSaldos=False
                'If (Convert.ToDecimal(txtCantidad.Text)*Convert.ToDecimal(txtCosto.Text)<=Convert.ToDecimal(txtSaldo.Text))
                '    ValidarSaldos=False
                'Else
                '    MessageBox.Show("El total a agregar supera el saldo presupuestal.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                '    ValidarSaldos = True
                'End If
            Else
                MessageBox.Show("La cantidad asignada supera el saldo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                ValidarSaldos = True
            End If
        End If
        Return ValidarSaldos
    End Function
    Private sub VerificaGrillaHabilitarCombos()
        If dgvRequerimientoBienes.Rows.Count > 0 Then
            cbUnidadOrganica.Enabled=False
            cbFF.Enabled=False
            cbRubro.Enabled=False
            cbSecuenciaFuncional.Enabled=False
            cbActividad.Enabled=False
        Else
            cbUnidadOrganica.Enabled=True
            cbFF.Enabled=True
            cbRubro.Enabled=True
            cbSecuenciaFuncional.Enabled=True
            cbActividad.Enabled=True
        End If
    End sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRequerimientoBienes.CellContentClick
        If dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "btnEliminar" Then
            Me.dgvRequerimientoBienes.Rows.Remove(Me.dgvRequerimientoBienes.CurrentRow)
            If Me.dgvRequerimientoBienes.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            Call VerificaGrillaHabilitarCombos()
        End If
        If dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "btnEditar" Then
            Datos.Llenar_Componentes(Me.dgvRequerimientoBienes.CurrentRow.Cells(3).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(4).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(5).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(6).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(7).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(8).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(1).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(2).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(11).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(10).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(12).Value)
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
            Me.txtCantidad.Text = Format(Convert.ToDouble(Me.dgvRequerimientoBienes.CurrentRow.Cells(21).Value), "###,###,#.00")
            Me.txtCosto.Text = Format(Convert.ToDouble(Me.dgvRequerimientoBienes.CurrentRow.Cells(22).Value), "###,###,#.00")
            Datos.Mostrar_Data_Item_Catalogo(Me.dgvRequerimientoBienes.CurrentRow.Cells(13).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(14).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(15).Value, Me.dgvRequerimientoBienes.CurrentRow.Cells(16).Value, 1, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            Me.dgvRequerimientoBienes.Rows.Remove(Me.dgvRequerimientoBienes.CurrentRow)
            If Me.dgvRequerimientoBienes.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            'Call Me.Evaluar_Saldos()
            Call Verifica_Existencia_Item()
            Call Evalua_Saldo_del_Mes()
            Call Evalua_Saldo_del_Mes_Acumulado()
        End If
        If dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "btnLimpiar" Then
            Me.dgvRequerimientoBienes.Rows.Clear()
            Me.cbUnidadOrganica.Enabled = True
            If Me.dgvRequerimientoBienes.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            If txtCodigoGrupo.Text.Length>0 Then
                Call Evalua_Saldo_del_Mes()
                Call Evalua_Saldo_del_Mes_Acumulado()
                'Call Verifica_Existencia_Item()
            End If
            Call VerificaGrillaHabilitarCombos()
        End If
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRequerimientoBienes.CellFormatting
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Ene." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Feb." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Mar." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Abr." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "May." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Jun." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Jul." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Ago." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Sep." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Oct." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Nov." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Dic." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvRequerimientoBienes.Columns(e.ColumnIndex).Name = "Monto" Then
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
        Dim dt_item_requerimiento As new DataTable()

        If Editar = False Then
            If Me.dgvRequerimientoBienes.RowCount > 0 Then
                If Me.txtJustificacion.Text.Trim.Length > 0 Then
                    For Recorrido As Integer = 0 To Me.dgvRequerimientoBienes.RowCount - 1

                        dt_item_requerimiento = Datos.Verificar_Items_No_Autorizados_Requerimientos_Por_Items(My.Settings.Año_Ejecucion,
                                                                                    Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                                                                    Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(17).Value)
                         If dt_item_requerimiento.Rows.Count > 0
                            MessageBox.Show("El item " +  dt_item_requerimiento.Rows(0)(3) + " - " + dt_item_requerimiento.Rows(0)(4) + Environment.NewLine +
                                            "se encuentra en el requerimiento número " + dt_item_requerimiento.Rows(0)(0) +" - "+dt_item_requerimiento.Rows(0)(1) + 
                                            Environment.NewLine + "con fecha de emisión " + dt_item_requerimiento.Rows(0)(2) +"."+
                                            Environment.NewLine + Environment.NewLine +
                                            "No se puede generar este requerimiento sin antes haber atendido el requerimiento mencionado.", 
                                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Exit Sub
                         End If
                    Next
                    
                    'Dim Numero As String = Datos.Generar_Numero_Requerimiento_Bienes(My.Settings.Año_Ejecucion)
                    Dim Numero As String = Datos.Generar_Numero_Requerimiento_Bienes(My.Settings.Año_Ejecucion)
                    Dim Numero_Unidad_Organica As String = Datos.Generar_Numero_Requerimiento_Bienes_Por_Unidad_Organica(My.Settings.Año_Ejecucion, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString)

                    Datos.Nuevo_Requerimiento_Bienes(My.Settings.Año_Ejecucion, Numero, Numero_Unidad_Organica, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Me.txtJustificacion.Text.Trim, Today.Date, My.Settings.Usuario, "01", Me.Total)
                    
                    For Recorrido As Integer = 0 To Me.dgvRequerimientoBienes.RowCount - 1
                        Datos.Nuevo_Detalle_Requerimiento_Bienes(My.Settings.Año_Ejecucion, Numero, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(1).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(2).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(3).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(4).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(5).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(6).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(7).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(8).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(10).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(11).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(12).Value, 
                                                                 "01", Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(13).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(14).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(15).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(16).Value, 
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(21).Value), 
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(22).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(23).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(24).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(25).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(26).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(27).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(28).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(29).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(30).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(31).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(32).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(33).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(34).Value))
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
            If Me.dgvRequerimientoBienes.RowCount > 0 Then
                If Me.txtJustificacion.Text.Trim.Length > 0 Then
                    Datos.Eliminar_Requerimiento_Bien(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Bien, False,My.Settings.Usuario)
                    Datos.Modificar_Requerimiento_Bienes(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Bien, 
                                                         Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, 
                                                         Me.txtJustificacion.Text.Trim, Me.Total)

                    For Recorrido As Integer = 0 To Me.dgvRequerimientoBienes.RowCount - 1
                        Datos.Nuevo_Detalle_Requerimiento_Bienes(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Bien, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(1).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(2).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(3).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(4).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(5).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(6).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(7).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(8).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(10).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(11).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(12).Value, 
                                                                 "01", Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(13).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(14).Value, 
                                                                 Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(15).Value, Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(16).Value, 
                                                                 Convert.ToDouble(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(21).Value), 
                                                                 Convert.ToDouble(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(22).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(23).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(24).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(25).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(26).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(27).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(28).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(29).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(30).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(31).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(32).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(33).Value),
                                                                 Convert.ToDecimal(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells(34).Value))
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

        If Me.dgvRequerimientoBienes.RowCount > 0 Then
            For Recorrido As Integer = 0 To dgvRequerimientoBienes.RowCount - 1
                Total = Total + (Convert.ToDouble(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells("Cantidad").Value) * Convert.ToDouble(Me.dgvRequerimientoBienes.Rows(Recorrido).Cells("Costo").Value))
            Next
        Else
            Total = 0
        End If
        Return Total
    End Function
    Public Function Obtiene_Mes_Actual(ByVal Año_Ejecucion As String) As String
        Return Datos.Obtiene_Mes_Actual(Año_Ejecucion)
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
        if cbUnidadOrganica.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar una Unidad Organica.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cbUnidadOrganica.Focus()
            Exit Sub
        End If
        if cbFF.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar una Fuente de financiamiento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cbFF.Focus()
            Exit Sub
        End If
        if cbRubro.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar un Rubro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cbRubro.Focus()
            Exit Sub
        End If
        If cbSecuenciaFuncional.SelectedIndex = -1
            MessageBox.Show("Debes seleccionar una Secuencia Funcional(Meta).", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cbSecuenciaFuncional.Focus()
            Exit Sub
        End If
        If cbActividad.SelectedIndex = -1
            MessageBox.Show("Debes seleccionar una Actividad.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cbActividad.Focus()
            Exit Sub
        End If

        Dim Formulario As New frmFiltrarItemsCatalogoCN
        Formulario._UnidadOrganica=cbUnidadOrganica.Text
        Formulario._FuenteFinanciamientio=cbFF.Text
        Formulario._RubroFuente =cbRubro.Text
        Formulario._CodigoSecuenciaFuncional=Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional")
        Formulario._CodigoActividad=Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad")
        Formulario._DatagridViewData = dgvRequerimientoBienes
        Formulario._CodigoCatalogo = "01"
        Formulario.ShowDialog()
        Call VerificaGrillaHabilitarCombos()
    End Sub
    Private Sub Asigna_Item_Segun_Filtro()
        If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
            Datos.Mostrar_Data_Item_Catalogo(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, 1, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            Call Verifica_Existencia_Item()
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
    End Sub
    Private sub Verifica_Existencia_Item()
        Try     
            if (Datos.Verifica_Si_Existe_en_CN_AM(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia,
                                             Variable_Codigo_Item, 1,
                                             Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString))
                
                txtCosto.Text = Format(Datos.Precio_ref_CN(txtCodigoGrupo.Text, txtCodigoClase.Text, txtCodigoFamilia.Text, txtCodigoItem.Text, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
                txtCosto.ReadOnly=True
                txtCantidad.Focus()
                'Call Evaluar_Saldos()
                Call Evalua_Saldo_del_Mes()
                Call Evalua_Saldo_del_Mes_Acumulado()
        Else
            If MessageBox.Show("El Item Seleccionado no se ha encontrado en el Cuadro de Necesidades de la Unidad Organica Seleccionada." + Environment.NewLine +
                                Environment.NewLine+"¿Desea Agregarlo de todas Formas?", Me.Text, 
                                                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                                                                         MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
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
                txtSaldo.Text="0.00"
                txtSaldoTotalCN.Text="0.00"
                txtCosto.Text="0.00"
                txtCosto.ReadOnly=false
                txtCantidad.focus()
                'Call Evaluar_Saldos()
            End If
        End If
        Catch ex As Exception
            'Sin error
        End Try
    End sub
    Private Sub Evalua_Saldo_del_Mes()
        Try
            Me.txtSaldoMes.Text = Format(Datos.Evalua_Saldo_del_Mes(Obtiene_Mes_Actual(My.Settings.Año_Ejecucion),
                                                                    Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString), 
                                                                    Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,Variable_Codigo_Grupo, 
                                                                    Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, 
                                                                    Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, 
                                                                    Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, 
                                                                    Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, 
                                                                    My.Settings.Año_Ejecucion.ToString) - 
                                                                    Saldo_Grilla(Me.txtCodigoGrupo.Text.Trim,
                                                                    Me.txtCodigoClase.Text.Trim,
                                                                    Me.txtCodigoFamilia.Text.Trim,
                                                                    Me.txtCodigoItem.Text.Trim,
                                                                    Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                                                    Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                                                    Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
        Catch ex As Exception
            'Sin errores
        End Try
    End Sub
    Private Function Saldo_Grilla(ByVal Codigo_Grupo As Integer, ByVal Codigo_Clase As String, ByVal Codigo_Familia As String, ByVal Codigo_Item As String,
                                 ByVal Meta As String, ByVal UO As String, ByVal CA As String, ByVal Año_Ejecucion As String) As Double
        Dim total_Item As Double
        Dim Acumulado As Double

        total_Item = 0

        For Each row As DataGridViewRow In dgvRequerimientoBienes.Rows
            'if (row.Cells("Codigo_Grupo").Value = Codigo_Grupo And row.Cells("Codigo_Clase").Value = Codigo_Clase And
            '        row.Cells("Codigo_Familia").Value = Codigo_Familia And row.Cells("Codigo_Item").Value = Codigo_Item And 
            '        row.Cells("Meta").Value = Meta And row.Cells("UO").Value = UO And
            '    row.Cells("CA").Value = CA and row.Cells("Año").Value = Año_Ejecucion)
            if (row.Cells("Codigo_Grupo").Value = Codigo_Grupo And row.Cells("Codigo_Clase").Value = Codigo_Clase And
                    row.Cells("Codigo_Familia").Value = Codigo_Familia And row.Cells("Codigo_Item").Value = Codigo_Item And 
                    row.Cells("UO").Value = UO And
                    row.Cells("Año").Value = Año_Ejecucion)

                Acumulado = (Convert.ToDouble(IIf(row.Cells("Cantidad").Value.ToString() = string.Empty, "0.00", row.Cells("Cantidad").Value)))

                total_Item = total_Item + Acumulado

            end If
        Next
        Return total_Item
    End Function
    Private Sub Evalua_Saldo_del_Mes_Acumulado()
        Dim acululado_Mes as Decimal
        Try
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
        Catch ex As Exception
            'Sin errores
        End Try
    End Sub
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