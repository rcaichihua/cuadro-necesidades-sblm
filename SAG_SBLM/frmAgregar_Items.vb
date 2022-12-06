Public Class frmAgregar_Items
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Public Operacion As Integer = 0
    Public Cadena As String = ""
    Dim Page As Integer = 0
    Private Sub frmAgregar_Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Select Case Operacion
            Case 1
                Call Me.Dimensionar()
                Call Me.Dimensionar2()
                Datos.Cargar_Items_Asistente(My.Settings.Año_Ejecucion, Me.Cadena, Me.DataGridView1)
                Me.TabControl1.SelectedTab = Me.TabPage1
                Page = 0
            Case 2
                Call Me.Dimensionar()
                Call Me.Dimensionar2()
                Datos.Cargar_Items_Asistente_2(My.Settings.Año_Ejecucion, Me.Cadena, Me.DataGridView1)
                Me.TabControl1.SelectedTab = Me.TabPage1
                Page = 0
        End Select
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Codigo_Grupo", "Grupo")
        Me.DataGridView1.Columns.Add("Codigo_Clase", "Clase")
        Me.DataGridView1.Columns.Add("Codigo_Familia", "Familia")
        Me.DataGridView1.Columns.Add("Codigo_Item", "Item")
        Me.DataGridView1.Columns.Add("Codigo", "Codigo")
        Me.DataGridView1.Columns.Add("Descripcion", "Descripcion")
        Me.DataGridView1.Columns.Add("Und.Med.", "Und.Med.")
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(0).Width = 60
        Me.DataGridView1.Columns(1).Width = 60
        Me.DataGridView1.Columns(2).Width = 60
        Me.DataGridView1.Columns(3).Width = 60
        Me.DataGridView1.Columns(4).Width = 110
        Me.DataGridView1.Columns(5).Width = 500
        Me.DataGridView1.Columns(6).Width = 100
        Me.DataGridView1.Columns(0).Visible = True
        Me.DataGridView1.Columns(1).Visible = True
        Me.DataGridView1.Columns(2).Visible = True
        Me.DataGridView1.Columns(3).Visible = True
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Dim Check As New DataGridViewCheckBoxColumn()
        DataGridView1.Columns.Add(Check)
        Check.HeaderText = "Cargar"
        Check.Name = "Cargar"
        DataGridView1.Columns(7).Width = 60
    End Sub
    Private Sub Dimensionar2()
        Me.DataGridView2.Rows.Clear()
        Me.DataGridView2.Columns.Clear()
        Me.DataGridView2.Columns.Add("Año_Ejecucion", "Año")
        Me.DataGridView2.Columns.Add("Numero", "Nro")
        Me.DataGridView2.Columns.Add("Codigo_FF", "FF")
        Me.DataGridView2.Columns.Add("Codigo_Rubro", "RB")
        Me.DataGridView2.Columns.Add("Rubro", "Rubro")
        Me.DataGridView2.Columns.Add("Tipo_Transaccion", "TT")
        Me.DataGridView2.Columns.Add("Generica", "G")
        Me.DataGridView2.Columns.Add("Sub_Generica", "SG")
        Me.DataGridView2.Columns.Add("Sub_Generica_Detalle", "SGD")
        Me.DataGridView2.Columns.Add("Especifica", "E")
        Me.DataGridView2.Columns.Add("Especifica_Detalle", "ED")
        Me.DataGridView2.Columns.Add("Clasificador", "Clasificador")
        Me.DataGridView2.Columns.Add("Codigo_Secuencia_Funcional", "Meta")
        Me.DataGridView2.Columns.Add("Codigo_Unidad_Organica", "CUO")
        Me.DataGridView2.Columns.Add("C.Costos", "C.Costos")
        Me.DataGridView2.Columns.Add("Codigo_Actividad", "CA")
        Me.DataGridView2.Columns.Add("Codigo_Catalogo", "CC")
        Me.DataGridView2.Columns.Add("Codigo_Grupo", "CG")
        Me.DataGridView2.Columns.Add("Codigo_Clase", "CC")
        Me.DataGridView2.Columns.Add("Codigo_Familia", "CF")
        Me.DataGridView2.Columns.Add("Codigo_Item", "CI")
        Me.DataGridView2.Columns.Add("Codigo", "Codigo")
        Me.DataGridView2.Columns.Add("Item", "Item")
        Me.DataGridView2.Columns.Add("Cantidad", "Cantidad")
        Me.DataGridView2.Columns.Add("Despachar", "Despachar")
        Me.DataGridView2.Columns.Add("Costo", "Costo")
        Me.DataGridView2.Columns.Add("Total", "Total")
        Me.DataGridView2.Columns(0).Width = 35  'Año_Ejecucion
        Me.DataGridView2.Columns(1).Width = 40  'Numero
        Me.DataGridView2.Columns(2).Width = 0  'Codigo_FF
        Me.DataGridView2.Columns(3).Width = 0  'Codigo_Rubro
        Me.DataGridView2.Columns(4).Width = 40  'Rubro
        Me.DataGridView2.Columns(5).Width = 0  'Tipo_Transaccion
        Me.DataGridView2.Columns(6).Width = 0  'Generica
        Me.DataGridView2.Columns(7).Width = 0  'Sub_Generica
        Me.DataGridView2.Columns(8).Width = 0  'Sub_Generica_Detalle
        Me.DataGridView2.Columns(9).Width = 0  'Especifica
        Me.DataGridView2.Columns(10).Width = 0  'Especifica_Detalle
        Me.DataGridView2.Columns(11).Width = 80  'Clasificador
        Me.DataGridView2.Columns(12).Width = 35  'Codigo_Secuencia_Funcional
        Me.DataGridView2.Columns(13).Width = 0  'Codigo_Unidad_Organica
        Me.DataGridView2.Columns(14).Width = 75  'C.Costos
        Me.DataGridView2.Columns(15).Width = 0  'Codigo_Actividad
        Me.DataGridView2.Columns(16).Width = 0  'Codigo_Catalogo
        Me.DataGridView2.Columns(17).Width = 0  'Codigo_Grupo
        Me.DataGridView2.Columns(18).Width = 0  'Codigo_Clase
        Me.DataGridView2.Columns(19).Width = 0  'Codigo_Familia
        Me.DataGridView2.Columns(20).Width = 0  'Codigo_Item
        Me.DataGridView2.Columns(21).Width = 95 'Codigo
        Me.DataGridView2.Columns(22).Width = 270  'Item
        Me.DataGridView2.Columns(23).Width = 65  'Cantidad
        Me.DataGridView2.Columns(24).Width = 75  'Despachar
        Me.DataGridView2.Columns(25).Width = 75  'Costo
        Me.DataGridView2.Columns(26).Width = 75  'Total
        Me.DataGridView2.Columns(0).Visible = True  'Año_Ejecucion
        Me.DataGridView2.Columns(1).Visible = True  'Numero
        Me.DataGridView2.Columns(2).Visible = False  'Codigo_FF
        Me.DataGridView2.Columns(3).Visible = False  'Codigo_Rubro
        Me.DataGridView2.Columns(4).Visible = True  'Rubro
        Me.DataGridView2.Columns(5).Visible = False  'Tipo_Transaccion
        Me.DataGridView2.Columns(6).Visible = False  'Generica
        Me.DataGridView2.Columns(7).Visible = False  'Sub_Generica
        Me.DataGridView2.Columns(8).Visible = False  'Sub_Generica_Detalle
        Me.DataGridView2.Columns(9).Visible = False  'Especifica
        Me.DataGridView2.Columns(10).Visible = False  'Especifica_Detalle
        Me.DataGridView2.Columns(11).Visible = True  'Clasificador
        Me.DataGridView2.Columns(12).Visible = True  'Codigo_Secuencia_Funcional
        Me.DataGridView2.Columns(13).Visible = False  'Codigo_Unidad_Organica
        Me.DataGridView2.Columns(14).Visible = True  'C.Costos
        Me.DataGridView2.Columns(15).Visible = False  'Codigo_Actividad
        Me.DataGridView2.Columns(16).Visible = False  'Codigo_Catalogo
        Me.DataGridView2.Columns(17).Visible = False  'Codigo_Grupo
        Me.DataGridView2.Columns(18).Visible = False  'Codigo_Clase
        Me.DataGridView2.Columns(19).Visible = False  'Codigo_Familia
        Me.DataGridView2.Columns(20).Visible = False  'Codigo_Item
        Me.DataGridView2.Columns(21).Visible = True  'Codigo
        Me.DataGridView2.Columns(22).Visible = True  'Item
        Me.DataGridView2.Columns(23).Visible = True  'Cantidad
        Me.DataGridView2.Columns(24).Visible = True  'Despachar
        Me.DataGridView2.Columns(25).Visible = True  'Costo
        Me.DataGridView2.Columns(26).Visible = True  'Total
        Me.DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter  'Año_Ejecucion
        Me.DataGridView2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter  'Numero
        Me.DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Rubro
        Me.DataGridView2.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft  'Clasificador
        Me.DataGridView2.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter  'Codigo_Secuencia_Funcional
        Me.DataGridView2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft  'C.Costos
        Me.DataGridView2.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Codigo
        Me.DataGridView2.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft  'Item
        Me.DataGridView2.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight  'Cantidad
        Me.DataGridView2.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight  'Despachar
        Me.DataGridView2.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight 'Costo
        Me.DataGridView2.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight  'Total
        Me.DataGridView2.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView2.ColumnHeadersHeight = 25
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Dim Boton1 As New DataGridViewButtonColumn
        With Boton1
            .Name = "btnValorizar"
            .HeaderText = "Valorizar"
            .Text = "Valorizar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 27
        End With
        DataGridView2.Columns.Add(Boton1)
        DataGridView2.Columns(27).Width = 100
        Me.DataGridView2.Columns(24).DefaultCellStyle.BackColor = Color.DarkOrange
        Me.DataGridView2.Columns(25).DefaultCellStyle.BackColor = Color.DarkOrange
        Me.DataGridView2.Columns(26).DefaultCellStyle.BackColor = Color.DarkOrange
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call Me.DataGridView1_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Cargar" Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Cargar"), DataGridViewCheckBoxCell)
            DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView1_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.DataGridView1.CurrentRow.Cells(7).Value = Not Me.DataGridView1.CurrentRow.Cells(7).Value
        DataGridView1_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call DataGridView1_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        Dim Check As DataGridViewCheckBoxCell = TryCast(Me.DataGridView1.CurrentCell, DataGridViewCheckBoxCell)
        If (Check Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView1.CurrentRow.Cells(7), DataGridViewCheckBoxCell)
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView1.CurrentRow.Cells(7).Value = Not Me.DataGridView1.CurrentRow.Cells(7).Value
        End If
    End Sub
    Private Sub TabControl1_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        If Not Page > 0 Then
            e.Cancel = True
        End If
    End Sub
    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Select Case Operacion
            Case 1
                If Me.DataGridView2.CurrentCellAddress.Y >= 0 Then
                    Variable_Codigo_Catalogo = Me.DataGridView2.CurrentRow.Cells(16).Value
                    Variable_Codigo_Grupo = Me.DataGridView2.CurrentRow.Cells(17).Value
                    Variable_Codigo_Clase = Me.DataGridView2.CurrentRow.Cells(18).Value
                    Variable_Codigo_Familia = Me.DataGridView2.CurrentRow.Cells(19).Value
                    Variable_Codigo_Item = Me.DataGridView2.CurrentRow.Cells(20).Value
                    Variable_Cantidad_Maxima_Disponible = Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(23).Value)
                    If Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(25).Value) > 0 Then Variable_Precio_Unitario = Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(25).Value) Else Variable_Precio_Unitario = 0
                    If Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(24).Value) > 0 Then Variable_Cantidad_Despachar = Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(24).Value) Else Variable_Cantidad_Despachar = 0
                    If DataGridView2.Columns(e.ColumnIndex).Name = "btnValorizar" Then
                        Dim Formulario As New frmValorizar
                        Formulario.Operacion = 1
                        Formulario.ShowDialog()
                        If Variable_Cantidad_Despachar > 0 Then
                            If Variable_Precio_Unitario > 0 Then
                                Me.DataGridView2.CurrentRow.Cells(24).Value = Format(Variable_Cantidad_Despachar, "###,###,#.00000")
                                Me.DataGridView2.CurrentRow.Cells(25).Value = Format(Variable_Precio_Unitario, "###,###,#.00000")
                                Me.DataGridView2.CurrentRow.Cells(26).Value = Format(Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(24).Value) * Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(25).Value), "###,###,#.00000")
                                Dim Codigo_Verificador As String = Me.DataGridView2.CurrentRow.Cells(21).Value
                                
                                For Recorrido As Integer = 0 To Me.DataGridView2.Rows.Count - 1
                                    If Me.DataGridView2.Rows(Recorrido).Cells(21).Value = Codigo_Verificador Then
                                        Me.DataGridView2.Rows(Recorrido).Cells(25).Value = Format(Variable_Precio_Unitario, "###,###,#.00000")
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            Case 2
                If Me.DataGridView2.CurrentCellAddress.Y >= 0 Then
                    Variable_Codigo_Catalogo = Me.DataGridView2.CurrentRow.Cells(16).Value
                    Variable_Codigo_Grupo = Me.DataGridView2.CurrentRow.Cells(17).Value
                    Variable_Codigo_Clase = Me.DataGridView2.CurrentRow.Cells(18).Value
                    Variable_Codigo_Familia = Me.DataGridView2.CurrentRow.Cells(19).Value
                    Variable_Codigo_Item = Me.DataGridView2.CurrentRow.Cells(20).Value
                    Variable_Cantidad_Maxima_Disponible = Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(23).Value)
                    If Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(25).Value) > 0 Then Variable_Precio_Unitario = Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(25).Value) Else Variable_Precio_Unitario = 0
                    If Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(24).Value) > 0 Then Variable_Cantidad_Despachar = Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(24).Value) Else Variable_Cantidad_Despachar = 0
                    If DataGridView2.Columns(e.ColumnIndex).Name = "btnValorizar" Then
                        Dim Formulario As New frmValorizar
                        Formulario.Operacion = 2
                        Formulario.ShowDialog()
                        If Variable_Cantidad_Despachar > 0 Then
                            If Variable_Precio_Unitario > 0 Then
                                Me.DataGridView2.CurrentRow.Cells(24).Value = Format(Variable_Cantidad_Despachar, "###,###,#.00")
                                Me.DataGridView2.CurrentRow.Cells(25).Value = Format(Variable_Precio_Unitario, "###,###,#.00")
                                Me.DataGridView2.CurrentRow.Cells(26).Value = Format(Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(24).Value) * Convert.ToDouble(Me.DataGridView2.CurrentRow.Cells(25).Value), "###,###,#.00")
                                Dim Codigo_Verificador As String = Me.DataGridView2.CurrentRow.Cells(21).Value
                                
                                For Recorrido As Integer = 0 To Me.DataGridView2.Rows.Count - 1
                                    If Me.DataGridView2.Rows(Recorrido).Cells(21).Value = Codigo_Verificador Then
                                        Me.DataGridView2.Rows(Recorrido).Cells(25).Value = Format(Variable_Precio_Unitario, "###,###,#.00")
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
        End Select

    End Sub
    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Select Case Operacion
            Case 1
                
                Dim Contador As Integer = 0
                For Recorrido As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    If Me.DataGridView1.Rows(Recorrido).Cells(7).Value = True Then
                        Contador = Contador + 1
                    End If
                Next
                If Contador > 0 Then
                    Page = 1
                    Me.TabControl1.SelectedTab = Me.TabPage2
                    Page = 0
                    Dim Cadena_Items As String = ""
                    For Recorrido As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                        If Me.DataGridView1.Rows(Recorrido).Cells(7).Value = True Then
                            Cadena_Items = Cadena_Items & "'" & Me.DataGridView1.Rows(Recorrido).Cells(4).Value & "',"
                        End If
                    Next
                    Cadena_Items = Microsoft.VisualBasic.Left(Cadena_Items, Cadena_Items.Trim.Length - 1)
                    Datos.Cargar_Items_Asistente_Distribucion(My.Settings.Año_Ejecucion, Me.Cadena, Cadena_Items, Me.DataGridView2)
                Else
                    MessageBox.Show("Debes seleccionar algún Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Case 2
                
                Dim Contador As Integer = 0
                For Recorrido As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    If Me.DataGridView1.Rows(Recorrido).Cells(7).Value = True Then
                        Contador = Contador + 1
                    End If
                Next
                If Contador > 0 Then
                    Page = 1
                    Me.TabControl1.SelectedTab = Me.TabPage2
                    Page = 0
                    Dim Cadena_Items As String = ""
                    For Recorrido As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                        If Me.DataGridView1.Rows(Recorrido).Cells(7).Value = True Then
                            Cadena_Items = Cadena_Items & "'" & Me.DataGridView1.Rows(Recorrido).Cells(4).Value & "',"
                        End If
                    Next
                    Cadena_Items = Microsoft.VisualBasic.Left(Cadena_Items, Cadena_Items.Trim.Length - 1)
                    Datos.Cargar_Items_Asistente_Distribucion_2(My.Settings.Año_Ejecucion, Me.Cadena, Cadena_Items, Me.DataGridView2)
                Else
                    MessageBox.Show("Debes seleccionar algún Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
        End Select



    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Page = 1
        Me.TabControl1.SelectedTab = Me.TabPage1
        Page = 0
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case Operacion
            Case 1
                If Me.DataGridView2.Rows.Count > 0 Then
                    
                    Dim Mensaje As String = ""
                    Dim Acumulador_Cantidades As Integer = 0
                    Dim Acumulador_Costos As Integer = 0
                    Dim Acumulador_Items As Integer = 0
                    For Recorrido As Integer = 0 To Me.DataGridView2.Rows.Count - 1
                        If Convert.ToDouble(Me.DataGridView2.Rows(Recorrido).Cells(24).Value) <= 0 Then
                            Acumulador_Cantidades = Acumulador_Cantidades + 1
                        End If
                        If Convert.ToDouble(Me.DataGridView2.Rows(Recorrido).Cells(25).Value) <= 0 Then
                            Acumulador_Costos = Acumulador_Costos + 1
                        End If
                    Next
                    If Acumulador_Cantidades = 0 And Acumulador_Costos = 0 Then
                        For Recorrido As Integer = 0 To Me.DataGridView2.Rows.Count - 1
                            If Datos.Evaluar_Existencia_Item_Detalle_Orden_Compra(My.Settings.Año_Ejecucion, Me.DataGridView2.Rows(Recorrido).Cells(17).Value, Me.DataGridView2.Rows(Recorrido).Cells(18).Value, Me.DataGridView2.Rows(Recorrido).Cells(19).Value, Me.DataGridView2.Rows(Recorrido).Cells(20).Value, Me.DataGridView2.Rows(Recorrido).Cells(1).Value, Variable_Operacion_Orden_Compra) = True Then
                                Acumulador_Items = Acumulador_Items + 1
                                Mensaje = Mensaje & "- " & Me.DataGridView2.Rows(Recorrido).Cells(21).Value & ": " & Me.DataGridView2.Rows(Recorrido).Cells(22).Value + vbCr
                            End If
                        Next
                        If Acumulador_Items = 0 Then
                            'Datos.LLenar_Detalle_Orden_Compra(Me.DataGridView2, Variable_Operacion_Orden_Compra)
                            Datos.LLenar_Detalle_Orden_Compra_2(Me.DataGridView2, Variable_Operacion_Orden_Compra)
                            Me.Close()
                        Else
                            MessageBox.Show("Los siguientes Items ya se encuentran ingresados y valorizados en el Detalle de la Orden de Compra: " + vbCr & Mensaje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        End If
                    Else
                        MessageBox.Show("Debes Valorizar (Ingresar Costo y Cantidad) a todos los Items seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    End If
                End If
            Case 2
                If Me.DataGridView2.Rows.Count > 0 Then
                    
                    Dim Mensaje As String = ""
                    Dim Acumulador_Cantidades As Integer = 0
                    Dim Acumulador_Costos As Integer = 0
                    Dim Acumulador_Items As Integer = 0
                    For Recorrido As Integer = 0 To Me.DataGridView2.Rows.Count - 1
                        If Convert.ToDouble(Me.DataGridView2.Rows(Recorrido).Cells(24).Value) <= 0 Then
                            Acumulador_Cantidades = Acumulador_Cantidades + 1
                        End If
                        If Convert.ToDouble(Me.DataGridView2.Rows(Recorrido).Cells(25).Value) <= 0 Then
                            Acumulador_Costos = Acumulador_Costos + 1
                        End If
                    Next
                    If Acumulador_Cantidades = 0 And Acumulador_Costos = 0 Then
                        For Recorrido As Integer = 0 To Me.DataGridView2.Rows.Count - 1
                            If Datos.Evaluar_Existencia_Item_Detalle_Orden_Servicio(My.Settings.Año_Ejecucion, Me.DataGridView2.Rows(Recorrido).Cells(17).Value, Me.DataGridView2.Rows(Recorrido).Cells(18).Value, Me.DataGridView2.Rows(Recorrido).Cells(19).Value, Me.DataGridView2.Rows(Recorrido).Cells(20).Value, Me.DataGridView2.Rows(Recorrido).Cells(1).Value, Variable_Operacion_Orden_Servicio) = True Then
                                Acumulador_Items = Acumulador_Items + 1
                                Mensaje = Mensaje & "- " & Me.DataGridView2.Rows(Recorrido).Cells(21).Value & ": " & Me.DataGridView2.Rows(Recorrido).Cells(22).Value + vbCr
                            End If
                        Next
                        If Acumulador_Items = 0 Then
                            Datos.LLenar_Detalle_Orden_Servicio(Me.DataGridView2, Variable_Operacion_Orden_Servicio)
                            Me.Close()
                        Else
                            MessageBox.Show("Los siguientes Items ya se encuentran ingresados y valorizados en el Detalle de la Orden de Servicio: " + vbCr & Mensaje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        End If
                    Else
                        MessageBox.Show("Debes Valorizar (Ingresar Costo y Cantidad) a todos los Items seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    End If
                End If
        End Select
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            Me.DataGridView1.Rows(Recorrido).Cells(7).Value = CheckBox1.Checked
        Next
    End Sub
End Class