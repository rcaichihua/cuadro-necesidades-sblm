Public Class frmFiltrarItemsCatalogoCN
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Unidad_Organica As New DataTable
    Dim Fuente_Financiaminto As New DataTable
    Dim Rubro As New DataTable
    Dim Secuencia_Funcional As New DataTable
    Dim Actividad As New DataTable
    Dim Tipo_Transaccion As New DataTable
    Dim Generica As New DataTable
    Dim SubGenerica As New DataTable
    Dim SubGenerica_Detalle As New DataTable
    Dim Especifica As New DataTable
    Dim Especifica_Detalle As New DataTable
    Public Editar As Boolean = False
    Dim Separador As Char
    Dim Mes_Actual As Integer

    Public Property _UnidadOrganica() As String
    Public Property _FuenteFinanciamientio() As String
    Public Property _RubroFuente() As String
    Public Property _CodigoSecuenciaFuncional() As String
    Public Property _CodigoActividad As String
    Public Property _CodigoCatalogo() As String
    Public Property _DatagridViewData As DataGridView

    Private Sub Dimensionar()
        Me.dgvDistribucionCn.Rows.Clear()
        Me.dgvDistribucionCn.Columns.Clear()
        Me.dgvDistribucionCn.Columns.Add("Año", "Año")'0
        Me.dgvDistribucionCn.Columns.Add("FF", "FF")
        Me.dgvDistribucionCn.Columns.Add("R", "R")
        Me.dgvDistribucionCn.Columns.Add("TT", "TT")'3
        Me.dgvDistribucionCn.Columns.Add("G", "G")
        Me.dgvDistribucionCn.Columns.Add("SG", "SG")
        Me.dgvDistribucionCn.Columns.Add("SGD", "SGD")'6
        Me.dgvDistribucionCn.Columns.Add("E", "E")
        Me.dgvDistribucionCn.Columns.Add("ED", "ED")
        Me.dgvDistribucionCn.Columns.Add("Clasificador", "Clasificador")'9
        Me.dgvDistribucionCn.Columns.Add("Meta", "Meta")
        Me.dgvDistribucionCn.Columns.Add("UO", "UO")
        Me.dgvDistribucionCn.Columns.Add("CA", "CA") '12
        Me.dgvDistribucionCn.Columns.Add("Codigo_Grupo", "Codigo_Grupo")
        Me.dgvDistribucionCn.Columns.Add("Codigo_Clase", "Codigo_Clase")
        Me.dgvDistribucionCn.Columns.Add("Codigo_Familia", "Codigo_Familia")
        Me.dgvDistribucionCn.Columns.Add("Codigo_Item", "Codigo_Item")
        Me.dgvDistribucionCn.Columns.Add("Codigo", "Codigo")
        Me.dgvDistribucionCn.Columns.Add("Item", "Item") '18
        Me.dgvDistribucionCn.Columns.Add("Codigo_Unidad_Medida", "Codigo_Unidad_Medida")
        Me.dgvDistribucionCn.Columns.Add("Unidad", "Unidad")
        Me.dgvDistribucionCn.Columns.Add("Cantidad", "Cantidad")
        Me.dgvDistribucionCn.Columns.Add("Costo", "Costo") '22
        Me.dgvDistribucionCn.Columns.Add("Ene.", "Ene.")
        Me.dgvDistribucionCn.Columns.Add("Feb.", "Feb.")
        Me.dgvDistribucionCn.Columns.Add("Mar.", "Mar.")
        Me.dgvDistribucionCn.Columns.Add("Abr.", "Abr.")
        Me.dgvDistribucionCn.Columns.Add("May.", "May.")
        Me.dgvDistribucionCn.Columns.Add("Jun.", "Jun.")
        Me.dgvDistribucionCn.Columns.Add("Jul.", "Jul.")
        Me.dgvDistribucionCn.Columns.Add("Ago.", "Ago.")
        Me.dgvDistribucionCn.Columns.Add("Sep.", "Sep.")
        Me.dgvDistribucionCn.Columns.Add("Oct.", "Oct.")
        Me.dgvDistribucionCn.Columns.Add("Nov.", "Nov.")
        Me.dgvDistribucionCn.Columns.Add("Dic.", "Dic.")
        Me.dgvDistribucionCn.Columns.Add("Cadena", "Cadena") '35
        Me.dgvDistribucionCn.Columns.Add("Codigo_Catalogo", "Codigo_Catalogo")
        Me.dgvDistribucionCn.Columns.Add("Descripcion_Especifica_Detalle", "Descripcion_Especifica_Detalle")'37
        Me.dgvDistribucionCn.Columns.Add("Total", "Total")'38

        Me.dgvDistribucionCn.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvDistribucionCn.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.dgvDistribucionCn.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDistribucionCn.Columns(0).Width = 35
        Me.dgvDistribucionCn.Columns(1).Width = 25
        Me.dgvDistribucionCn.Columns(2).Width = 25
        Me.dgvDistribucionCn.Columns(3).Width = 0
        Me.dgvDistribucionCn.Columns(4).Width = 0
        Me.dgvDistribucionCn.Columns(5).Width = 0
        Me.dgvDistribucionCn.Columns(6).Width = 0
        Me.dgvDistribucionCn.Columns(7).Width = 0
        Me.dgvDistribucionCn.Columns(8).Width = 0
        Me.dgvDistribucionCn.Columns(9).Width = 75
        Me.dgvDistribucionCn.Columns(10).Width = 35
        Me.dgvDistribucionCn.Columns(11).Width = 25
        Me.dgvDistribucionCn.Columns(12).Width = 25

        Me.dgvDistribucionCn.Columns(13).Width = 0
        Me.dgvDistribucionCn.Columns(14).Width = 0
        Me.dgvDistribucionCn.Columns(15).Width = 0
        Me.dgvDistribucionCn.Columns(16).Width = 0
        Me.dgvDistribucionCn.Columns(17).Width = 110
        Me.dgvDistribucionCn.Columns(18).Width = 260
        Me.dgvDistribucionCn.Columns(19).Width = 0
        Me.dgvDistribucionCn.Columns(20).Width = 80
        Me.dgvDistribucionCn.Columns(22).Width = 80

        Me.dgvDistribucionCn.Columns(23).Width = 55
        Me.dgvDistribucionCn.Columns(24).Width = 55
        Me.dgvDistribucionCn.Columns(25).Width = 55
        Me.dgvDistribucionCn.Columns(26).Width = 55
        Me.dgvDistribucionCn.Columns(27).Width = 55
        Me.dgvDistribucionCn.Columns(28).Width = 55
        Me.dgvDistribucionCn.Columns(29).Width = 55
        Me.dgvDistribucionCn.Columns(30).Width = 55
        Me.dgvDistribucionCn.Columns(31).Width = 55
        Me.dgvDistribucionCn.Columns(32).Width = 55
        Me.dgvDistribucionCn.Columns(33).Width = 55
        Me.dgvDistribucionCn.Columns(34).Width = 55
        Me.dgvDistribucionCn.Columns(35).Width = 0
        Me.dgvDistribucionCn.Columns(38).Width = 70
        Me.dgvDistribucionCn.Columns(0).Visible = False
        Me.dgvDistribucionCn.Columns(1).Visible = False
        Me.dgvDistribucionCn.Columns(2).Visible = False
        Me.dgvDistribucionCn.Columns(3).Visible = False
        Me.dgvDistribucionCn.Columns(4).Visible = False
        Me.dgvDistribucionCn.Columns(5).Visible = False
        Me.dgvDistribucionCn.Columns(6).Visible = False
        Me.dgvDistribucionCn.Columns(7).Visible = False
        Me.dgvDistribucionCn.Columns(8).Visible = False
        Me.dgvDistribucionCn.Columns(9).Visible = False
        Me.dgvDistribucionCn.Columns(10).Visible = False
        Me.dgvDistribucionCn.Columns(11).Visible = False
        Me.dgvDistribucionCn.Columns(12).Visible = False
        Me.dgvDistribucionCn.Columns(13).Visible = False
        Me.dgvDistribucionCn.Columns(14).Visible = False
        Me.dgvDistribucionCn.Columns(15).Visible = False
        Me.dgvDistribucionCn.Columns(16).Visible = False
        Me.dgvDistribucionCn.Columns(17).Visible = False
        Me.dgvDistribucionCn.Columns(19).Visible = False
        Me.dgvDistribucionCn.Columns(21).Visible = False
        Me.dgvDistribucionCn.Columns(35).Visible = False
        Me.dgvDistribucionCn.Columns(36).Visible = False
        Me.dgvDistribucionCn.Columns(37).Visible = False

        Me.dgvDistribucionCn.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(32).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(33).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(38).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvDistribucionCn.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDistribucionCn.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDistribucionCn.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDistribucionCn.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDistribucionCn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDistribucionCn.ColumnHeadersHeight = 25
        Me.dgvDistribucionCn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Dim Checked1 As New DataGridViewCheckBoxColumn
        dgvDistribucionCn.Columns.Add(Checked1)
        With Checked1
            .Name = "chkCargar"
            .HeaderText = "Cargar"
        End With
        dgvDistribucionCn.Columns(39).Width = 50
        Dim Boton1 As New DataGridViewButtonColumn
        With Boton1
            .Name = "btnAsignar"
            .HeaderText = "Asignar"
            .Text = "Asignar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 40
        End With
        dgvDistribucionCn.Columns.Add(Boton1)
        dgvDistribucionCn.Columns(40).Width = 70

        Me.dgvDistribucionCn.Columns.Add("Ene", "Ene")'41
        Me.dgvDistribucionCn.Columns.Add("Feb", "Feb")'42
        Me.dgvDistribucionCn.Columns.Add("Mar", "Mar")
        Me.dgvDistribucionCn.Columns.Add("Abr", "Abr")
        Me.dgvDistribucionCn.Columns.Add("May", "May")
        Me.dgvDistribucionCn.Columns.Add("Jun", "Jun")'46
        Me.dgvDistribucionCn.Columns.Add("Jul", "Jul")
        Me.dgvDistribucionCn.Columns.Add("Ago", "Ago")
        Me.dgvDistribucionCn.Columns.Add("Sep", "Sep")'49
        Me.dgvDistribucionCn.Columns.Add("Oct", "Oct")
        Me.dgvDistribucionCn.Columns.Add("Nov", "Nov")
        Me.dgvDistribucionCn.Columns.Add("Dic", "Dic")'52
        Me.dgvDistribucionCn.Columns.Add("Editado", "Editado")'53

        Me.dgvDistribucionCn.Columns(41).Visible = False
        Me.dgvDistribucionCn.Columns(42).Visible = False
        Me.dgvDistribucionCn.Columns(43).Visible = False
        Me.dgvDistribucionCn.Columns(44).Visible = False
        Me.dgvDistribucionCn.Columns(45).Visible = False
        Me.dgvDistribucionCn.Columns(46).Visible = False
        Me.dgvDistribucionCn.Columns(47).Visible = False
        Me.dgvDistribucionCn.Columns(48).Visible = False
        Me.dgvDistribucionCn.Columns(49).Visible = False
        Me.dgvDistribucionCn.Columns(50).Visible = False
        Me.dgvDistribucionCn.Columns(51).Visible = False
        Me.dgvDistribucionCn.Columns(52).Visible = False
        Me.dgvDistribucionCn.Columns(53).Visible = False
    End Sub
    Private Sub dgvDistribucionCn_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvDistribucionCn.CellFormatting
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Ene." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Feb." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Mar." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Abr." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "May." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Jun." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Jul." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Ago." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Sep." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Oct." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Nov." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Dic." Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Ene" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Feb" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Mar" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Abr" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "May" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Jun" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Jul" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Ago" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Sep" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Oct" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Nov" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Dic" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Costo" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Cantidad" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Total" Then
            e.CellStyle.Format = "###,###,#.00"
        End If

        If e.ColumnIndex = 23 Then 'Enero
            If Mes_Actual >= 2 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 24 then
            If Mes_Actual >= 3 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 25 then
            If Mes_Actual >= 4 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 26 then'Abril
            If Mes_Actual >= 5 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 27 then
            If Mes_Actual >= 6 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 28 then'Junio
            If Mes_Actual >= 7 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 29 then
            If Mes_Actual >= 8 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 30 then'Agosto
            If Mes_Actual >= 9 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 31 then
            If Mes_Actual >= 10 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 32 then'Octubre
            If Mes_Actual >= 11 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 33 then'Noviembre
            If Mes_Actual >= 12 Or Mes_Actual = 0
                e.CellStyle.BackColor = Color.Tomato
            End If
        Elseif e.ColumnIndex = 34 then'Noviembre
        If Mes_Actual = 0
            e.CellStyle.BackColor = Color.Tomato
        End If
        End If

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me._DatagridViewData.Rows.Clear()
        Dim Total As Decimal = 0.00

        For Recorrido As Integer = 0 To dgvDistribucionCn.Rows.Count - 1
            If dgvDistribucionCn.Rows(Recorrido).Cells(39).Value = True Then
                Total = Convert.ToDecimal(IIf(Mes_Actual>=2 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(23).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=3 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(24).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=4 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(25).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=5 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(26).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=6 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(27).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=7 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(28).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=8 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(29).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=9 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(30).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=10 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(31).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=11 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(32).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual>=12 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(33).Value))+
                    Convert.ToDecimal(IIf(Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))

                If (Total<=0)
                    MessageBox.Show("La cantidad total acumulada no puede ser cero."+Environment.NewLine+Environment.NewLine+"Verifique el item"+
                                    Environment.NewLine+dgvDistribucionCn.Rows(Recorrido).Cells(17).Value +" - "+
                                    dgvDistribucionCn.Rows(Recorrido).Cells(18).Value, Me.Text, MessageBoxButtons.OK, 
                                                                                       MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                Me._DatagridViewData.Rows.Add()
                _DatagridViewData.Item(0, _DatagridViewData.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                _DatagridViewData.Item(1, _DatagridViewData.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                _DatagridViewData.Item(2, _DatagridViewData.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                _DatagridViewData.Item(3, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(3).Value
                _DatagridViewData.Item(4, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(4).Value
                _DatagridViewData.Item(5, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(5).Value
                _DatagridViewData.Item(6, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(6).Value
                _DatagridViewData.Item(7, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(7).Value
                _DatagridViewData.Item(8, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(8).Value
                _DatagridViewData.Item(9, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(9).Value'Clasificador
                _DatagridViewData.Item(10, _DatagridViewData.Rows.Count - 1).Value = _CodigoSecuenciaFuncional
                _DatagridViewData.Item(11, _DatagridViewData.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                _DatagridViewData.Item(12, _DatagridViewData.Rows.Count - 1).Value = _CodigoActividad
                _DatagridViewData.Item(13, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(13).Value'Codigo_Grupo
                _DatagridViewData.Item(14, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(14).Value'Codigo_Clase
                _DatagridViewData.Item(15, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(15).Value'Codigo_Familia
                _DatagridViewData.Item(16, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(16).Value'Codigo_item
                _DatagridViewData.Item(17, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(17).Value'Codigo
                _DatagridViewData.Item(18, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(18).Value'Item
                _DatagridViewData.Item(19, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(19).Value'Codigo_unidad_medida
                _DatagridViewData.Item(20, _DatagridViewData.Rows.Count - 1).Value = dgvDistribucionCn.Rows(Recorrido).Cells(20).Value'Unidad_Medida

                _DatagridViewData.Item(23, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=2 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(23).Value)), "###,###,#.00")
                _DatagridViewData.Item(24, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=3 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(24).Value)), "###,###,#.00")
                _DatagridViewData.Item(25, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=4 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(25).Value)), "###,###,#.00")
                _DatagridViewData.Item(26, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=5 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(26).Value)), "###,###,#.00")
                _DatagridViewData.Item(27, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=6 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(27).Value)), "###,###,#.00")
                _DatagridViewData.Item(28, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=7 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(28).Value)), "###,###,#.00")
                _DatagridViewData.Item(29, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=8 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(29).Value)), "###,###,#.00")
                _DatagridViewData.Item(30, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=9 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(30).Value)), "###,###,#.00")
                _DatagridViewData.Item(31, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=10 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(31).Value)), "###,###,#.00")
                _DatagridViewData.Item(32, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=11 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(32).Value)), "###,###,#.00")
                _DatagridViewData.Item(33, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual>=12 Or Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(33).Value)), "###,###,#.00")
                _DatagridViewData.Item(34, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(IIf(Mes_Actual=0,"0.00",dgvDistribucionCn.Rows(Recorrido).Cells(34).Value)), "###,###,#.00")

                _DatagridViewData.Item(21, _DatagridViewData.Rows.Count - 1).Value = Format(Total, "###,###,#.00")'Cantidad
                _DatagridViewData.Item(22, _DatagridViewData.Rows.Count - 1).Value = Format(Convert.ToDecimal(dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), "###,###,#.00000")'Costo

                _DatagridViewData.Item(35, _DatagridViewData.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & dgvDistribucionCn.Rows(Recorrido).Cells(13).Value & "." & dgvDistribucionCn.Rows(Recorrido).Cells(14).Value & "." & dgvDistribucionCn.Rows(Recorrido).Cells(15).Value & "." & dgvDistribucionCn.Rows(Recorrido).Cells(16).Value & "." & _CodigoSecuenciaFuncional & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & _CodigoActividad
                '_DatagridViewData.Item(36, _DatagridViewData.Rows.Count - 1).Value = _CodigoCatalogo
                '_DatagridViewData.Item(38, _DatagridViewData.Rows.Count - 1).Value = Format(math.Round(convert.ToDecimal(dgvDistribucionCn.Rows(Recorrido).Cells(21).Value) * Convert.ToDecimal(dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), 2, MidpointRounding.AwayFromZero), "###,###,#.00")
                '_DatagridViewData.Item(41, _DatagridViewData.Rows.Count - 1).Value = IIf(dgvDistribucionCn.Rows(Recorrido).Cells(53).Value = string.Empty, "0", "1")
            End If
        Next
        Close()
    End Sub

    Private Sub Limpiar_Busqueda_items()
        Variable_Codigo_Catalogo = ""
        Variable_Codigo_Grupo = ""
        Variable_Codigo_Clase = ""
        Variable_Codigo_Familia = ""
        Variable_Codigo_Item = ""
    End Sub

    Private Sub dgvDistribucionCn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDistribucionCn.CellContentClick
        If dgvDistribucionCn.Columns(e.ColumnIndex).Name = "chkCargar" Then
            Dim row As DataGridViewRow = dgvDistribucionCn.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("chkCargar"), DataGridViewCheckBoxCell)
            dgvDistribucionCn.EditMode = DataGridViewEditMode.EditOnEnter
        ElseIf dgvDistribucionCn.Columns(e.ColumnIndex).Name = "btnAsignar" Then
            Dim Formulario As New frmAsignar_Cantidad_CN
            if Me.dgvDistribucionCn.CurrentRow.Cells(53).Value = "1"
                Formulario._Cantidad_Enero = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)
                Formulario._Cantidad_Febrero = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)
                Formulario._Cantidad_Marzo = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)
                Formulario._Cantidad_Abril = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)
                Formulario._Cantidad_Mayo = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)
                Formulario._Cantidad_Junio = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)
                Formulario._Cantidad_Julio = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)
                Formulario._Cantidad_Agosto = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)
                Formulario._Cantidad_Septiembre = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)
                Formulario._Cantidad_Octubre = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)
                Formulario._Cantidad_Noviembre = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)
                Formulario._Cantidad_Diciembre = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)

                Formulario._Cantidad_Enero_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(41).Value)
                Formulario._Cantidad_Febrero_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(42).Value)
                Formulario._Cantidad_Marzo_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(43).Value)
                Formulario._Cantidad_Abril_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(44).Value)
                Formulario._Cantidad_Mayo_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(45).Value)
                Formulario._Cantidad_Junio_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(46).Value)
                Formulario._Cantidad_Julio_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(47).Value)
                Formulario._Cantidad_Agosto_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(48).Value)
                Formulario._Cantidad_Septiembre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(49).Value)
                Formulario._Cantidad_Octubre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(50).Value)
                Formulario._Cantidad_Noviembre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(51).Value)
                Formulario._Cantidad_Diciembre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(52).Value)
                Formulario._Editado = True
            Else
                Formulario._Cantidad_Enero_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)
                Formulario._Cantidad_Febrero_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)
                Formulario._Cantidad_Marzo_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)
                Formulario._Cantidad_Abril_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)
                Formulario._Cantidad_Mayo_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)
                Formulario._Cantidad_Junio_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)
                Formulario._Cantidad_Julio_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)
                Formulario._Cantidad_Agosto_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)
                Formulario._Cantidad_Septiembre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)
                Formulario._Cantidad_Octubre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)
                Formulario._Cantidad_Noviembre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)
                Formulario._Cantidad_Diciembre_CN = Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)
            End If
            
            Formulario.ShowDialog()
            If Formulario._Cancela Then Return

            Me.dgvDistribucionCn.CurrentRow.Cells(23).Value = Formulario._Cantidad_Enero
            Me.dgvDistribucionCn.CurrentRow.Cells(24).Value = Formulario._Cantidad_Febrero
            Me.dgvDistribucionCn.CurrentRow.Cells(25).Value = Formulario._Cantidad_Marzo
            Me.dgvDistribucionCn.CurrentRow.Cells(26).Value = Formulario._Cantidad_Abril
            Me.dgvDistribucionCn.CurrentRow.Cells(27).Value = Formulario._Cantidad_Mayo
            Me.dgvDistribucionCn.CurrentRow.Cells(28).Value = Formulario._Cantidad_Junio
            Me.dgvDistribucionCn.CurrentRow.Cells(29).Value = Formulario._Cantidad_Julio
            Me.dgvDistribucionCn.CurrentRow.Cells(30).Value = Formulario._Cantidad_Agosto
            Me.dgvDistribucionCn.CurrentRow.Cells(31).Value = Formulario._Cantidad_Septiembre
            Me.dgvDistribucionCn.CurrentRow.Cells(32).Value = Formulario._Cantidad_Octubre
            Me.dgvDistribucionCn.CurrentRow.Cells(33).Value = Formulario._Cantidad_Noviembre
            Me.dgvDistribucionCn.CurrentRow.Cells(34).Value = Formulario._Cantidad_Diciembre
            Me.dgvDistribucionCn.CurrentRow.Cells(38).Value = Convert.ToDecimal((Formulario._Cantidad_Enero + Formulario._Cantidad_Febrero + 
                                                                                Formulario._Cantidad_Marzo + Formulario._Cantidad_Abril + 
                                                                                Formulario._Cantidad_Mayo + Formulario._Cantidad_Junio + 
                                                                                Formulario._Cantidad_Julio + Formulario._Cantidad_Agosto + 
                                                                                Formulario._Cantidad_Septiembre + Formulario._Cantidad_Octubre + 
                                                                                Formulario._Cantidad_Noviembre + Formulario._Cantidad_Diciembre)) * 
                                                                                Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(22).Value)
            Me.dgvDistribucionCn.CurrentRow.Cells(53).Value="1"
        Else
            dgvDistribucionCn.Columns(e.ColumnIndex).ReadOnly = True
            'dgvDistribucionCn.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        dgvDistribucionCn_CellEnter(sender, e)
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Me.Close()
    End Sub

    Private Sub frmRegistro_CN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mes_Actual = Datos.Obtiene_Mes_Actual(My.Settings.Año_Ejecucion)
        Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
        Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")

        cbUnidadOrganica.Text = _UnidadOrganica
        cbFF.Text=_FuenteFinanciamientio
        cbRubro.Text=_RubroFuente
        cbUnidadOrganica.Enabled=False
        cbFF.Enabled=False
        cbRubro.Enabled=False
        Call Me.Dimensionar()
        if (Datos.Cargar_CN_Filtro_Requerimientos(My.Settings.Año_Ejecucion, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString, Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,_CodigoCatalogo, Me.dgvDistribucionCn, _DatagridViewData, _CodigoSecuenciaFuncional, _CodigoActividad)=1)
            Me.Close
        End If
    End Sub

    Function Total_clasificador_CN_grilla(ByVal Codigo_FF As Integer, ByVal Codigo_Rubro As String, ByVal Tipo_Transaccion As String, ByVal Generica As String,
                                 ByVal Sub_Generica As String, ByVal Sub_Generica_Detalle As String, ByVal Especifica As String, 
                                ByVal Especifica_Detalle As String,ByVal Codigo_Secuencia_Funcional As String, ByVal Codigo_Unidad_Organica As String, 
                                ByVal Codigo_Actividad As String,ByVal Año_Ejecucion As String) As Double
        Dim total_clasificador As Double
        Dim Acumulado As Double

        total_clasificador = 0

        For Each row As DataGridViewRow In dgvDistribucionCn.rows
            if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And 
                row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And 
                row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("Meta").Value = Codigo_Secuencia_Funcional And 
                row.Cells("UO").Value = Codigo_Unidad_Organica and row.Cells("CA").Value = Codigo_Actividad and row.Cells("Año").Value = Año_Ejecucion)


                Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                      Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                    Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                total_clasificador = total_clasificador + Acumulado
                                         
            end If
        Next
        return total_clasificador
    End Function

    Function Total_clasificador_CN_grilla_no_db(ByVal Codigo_FF As Integer, ByVal Codigo_Rubro As String, ByVal Tipo_Transaccion As String, ByVal Generica As String,
                                 ByVal Sub_Generica As String, ByVal Sub_Generica_Detalle As String, ByVal Especifica As String, 
                                ByVal Especifica_Detalle As String,ByVal Codigo_Secuencia_Funcional As String, ByVal Codigo_Unidad_Organica As String, 
                                ByVal Codigo_Actividad As String,ByVal Año_Ejecucion As String) As Double
        Dim total_clasificador As Double
        Dim Acumulado As Double

        total_clasificador = 0

        For Each row As DataGridViewRow In dgvDistribucionCn.rows

            If Tipo_Transaccion & "." & Generica & "." & Sub_Generica = "2.3.1" 
                'Davy aqui puedes consultar si la UO tiene asignado el clasificador de limpieza
                'Dim Da_limpieza As New OleDb.OleDbDataAdapter("select * from PIA_prevision_detalle where Año_Ejecucion='"& My.Settings.Año_Ejecucion &"' and Codigo_Unidad_Organica='" & Codigo_Unidad_Organica & "'and ltrim(rtrim(Tipo_Transaccion))+'.'+Generica+'.'+Sub_Generica+'.'+Sub_Generica_Detalle+'.'+Especifica+'.'+Especifica_Detalle='2.3.1.5.3.1' ", Cn)
                Dim Ds_limpieza As New Data.DataTable
                'Da_limpieza.Fill(Ds_limpieza)

                Ds_limpieza = Datos.Ejecutar_Select("select * from PIA_prevision_detalle where Año_Ejecucion='"& My.Settings.Año_Ejecucion &"' and Codigo_Unidad_Organica='" & Codigo_Unidad_Organica & "'and ltrim(rtrim(Tipo_Transaccion))+'.'+Generica+'.'+Sub_Generica+'.'+Sub_Generica_Detalle+'.'+Especifica+'.'+Especifica_Detalle='2.3.1.5.3.1' ")

                if Ds_limpieza.Rows.Count>0
                    If Tipo_Transaccion & "." & Generica & "." & Sub_Generica & "." & Sub_Generica_Detalle & "." & Especifica & "." & Especifica_Detalle = "2.3.1.5.3.1"

                        if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
                            row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                            Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                                Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                            total_clasificador = total_clasificador + Acumulado
                        end If
                    else
                        if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                            Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                                Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                            total_clasificador = total_clasificador + Acumulado
                        end If
                    End If
                Else
                    if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                            Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                              Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                                Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                            total_clasificador = total_clasificador + Acumulado
                        end If
                End If
            else if Tipo_Transaccion & "." & Generica & "." & Sub_Generica = "2.3.2"
                If Tipo_Transaccion & "." & Generica & "." & Sub_Generica & "." & Sub_Generica_Detalle & "." & Especifica & "." & Especifica_Detalle = "2.3.2.7.2.99"
                    if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                        row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
                        row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                        row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                        Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                            Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                        total_clasificador = total_clasificador + Acumulado
                    end If
                else
                    if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                        row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                        row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                        Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                            Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                        total_clasificador = total_clasificador + Acumulado
                    end If
                End If
            else if Tipo_Transaccion & "." & Generica = "2.6"
                if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                        row.Cells("G").Value = Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and row.Cells("Año").Value = Año_Ejecucion And 
                        row.Cells("db").Value = "0")

                        Acumulado = (Convert.ToDecimal(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                          Convert.ToDecimal(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                            Acumulado = Acumulado*Convert.ToDecimal(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))

                        total_clasificador = total_clasificador + Acumulado
                    end If
            End If
        Next
        return total_clasificador
    End Function

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) 
         If dgvDistribucionCn.Rows.Count > 0 Then Datos.Exportar_Lista_Cuadro_Necesidades(dgvDistribucionCn)   
    End Sub

    Private Sub cbFF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFF.SelectedIndexChanged
        Me.cbRubro.DataSource = Nothing
        If Me.cbFF.Text.Trim.Length > 0 Then
            Rubro = Datos.LLenar_Combo_Solo("Select * From Lista_Rubros Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF='" & Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF") & "'", Me.cbRubro, "Rubro")
        Else
            Me.cbRubro.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvDistribucionCn_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDistribucionCn.CellValueChanged
         If e.RowIndex = -1 Then
            Return
        End If

        If dgvDistribucionCn.Columns(e.ColumnIndex).Name <> "chkCargar" Then
            dgvDistribucionCn.Columns(e.ColumnIndex).ReadOnly = True
        End If
    End Sub

    Private Sub dgvDistribucionCn_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDistribucionCn.CellEnter
        Call dgvDistribucionCn_CellValueChanged(sender, e)
    End Sub

    Private Sub dgvDistribucionCn_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDistribucionCn.CurrentCellDirtyStateChanged
        Dim Check As DataGridViewCheckBoxCell = TryCast(Me.dgvDistribucionCn.CurrentCell, DataGridViewCheckBoxCell)
        If (Check Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.dgvDistribucionCn.CurrentRow.Cells(39), DataGridViewCheckBoxCell)
        dgvDistribucionCn.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub dgvDistribucionCn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDistribucionCn.CellDoubleClick
        'Me.dgvDistribucionCn.CurrentRow.Cells(39).Value = Not Me.dgvDistribucionCn.CurrentRow.Cells(39).Value
        dgvDistribucionCn_CellEnter(sender, e)
    End Sub

    Private Sub dgvDistribucionCn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDistribucionCn.CellClick
        Call Me.dgvDistribucionCn_CellDoubleClick(sender, e)
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class
