Public Class frmCatalogo_Bienes_Servicios_Obras
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Public Tipo_Catalogo As String = ""
    Public Accion_Modificatoria_activa As Boolean = False
    Public Operacion As Integer = 0
    Public Tipo_Modulo As Integer = 0
    Dim Grupo As New DataTable
    Dim Clase As New DataTable
    Dim Familia As New DataTable
    Private Sub frmCatalogo_Bienes_Servicios_Obras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Select Case Tipo_Catalogo
            Case "01"
                If Tipo_Modulo = 0 Then
                    Me.Text = "..:: Catálogo de Bienes ::.."
                    B_Busqueda_S = " Select Codigo_Catalogo,Codigo_Grupo,Codigo_Clase,Codigo_Familia,Codigo_Item,Descripcion_Grupo as Grupo,Descripcion_Clase As Clase,Descripcion_Familia as Familia,Codigo,Descripcion_Item as Item, Descripcion_Unidad_Medida as [Unidad Medida],Clasificador,Estado From Catalogo_Bienes "
                    B_Busqueda_W = " Where Codigo_Catalogo='01' "
                    B_Busqueda_O = " Order By Abs(Codigo_Catalogo),Abs(Codigo_Grupo),Abs(Codigo_Clase),Abs(Codigo_Familia),Abs(Codigo_Item) "
                    Grupo = Datos.LLenar_Combo("Select * From Lista_Grupos Where Codigo_Catalogo='01'", Me.cbGrupo, "Grupo")
                    Me.cbGrupo.SelectedIndex = 1
                    Me.RadioButton1.Checked = True
                    'Call Me.Filtrar()
                Else
                    Me.Text = "..:: Catálogo de Bienes ::.."
                    B_Busqueda_S = " Select Codigo_Catalogo,Codigo_Grupo,Codigo_Clase,Codigo_Familia,Codigo_Item,Descripcion_Grupo as Grupo,Descripcion_Clase As Clase,Descripcion_Familia as Familia,a.Codigo,Descripcion_Item as Item, Descripcion_Unidad_Medida as [Unidad Medida],Clasificador,Estado From Catalogo_Bienes as a inner join Catalogo_CN as b on a.codigo=b.codigo"
                    B_Busqueda_W = " Where Codigo_Catalogo='01' and b.unidad_medida<>'SERVICIOS' and b.Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'"
                    B_Busqueda_O = " Order By Abs(Codigo_Catalogo),Abs(Codigo_Grupo),Abs(Codigo_Clase),Abs(Codigo_Familia),Abs(Codigo_Item) "
                    Grupo = Datos.LLenar_Combo("Select * From Lista_Grupos Where Codigo_Catalogo='01'", Me.cbGrupo, "Grupo")
                    Me.cbGrupo.SelectedIndex = 0
                    Me.RadioButton1.Checked = True
                    Call Me.Filtrar()
                End If

            Case "02"
                If Tipo_Modulo = 0 Then
                    Me.Text = "..:: Catálogo de Servicios ::.."
                    B_Busqueda_S = " Select Codigo_Catalogo,Codigo_Grupo,Codigo_Clase,Codigo_Familia,Codigo_Item,Descripcion_Grupo as Grupo,Descripcion_Clase As Clase,Descripcion_Familia as Familia,Codigo,Descripcion_Item as Item, Descripcion_Unidad_Medida as [Unidad Medida],Clasificador,Estado From Catalogo_Servicios "
                    B_Busqueda_W = " Where Codigo_Catalogo='02'"
                    B_Busqueda_O = " Order By Abs(Codigo_Catalogo),Abs(Codigo_Grupo),Abs(Codigo_Clase),Abs(Codigo_Familia),Abs(Codigo_Item) "
                    Grupo = Datos.LLenar_Combo("Select * From Lista_Grupos Where Codigo_Catalogo='02'", Me.cbGrupo, "Grupo")
                    Me.cbGrupo.SelectedIndex = 1
                    Me.RadioButton1.Checked = True
                    'Call Me.Filtrar()
                Else
                    Me.Text = "..:: Catálogo de Servicios ::.."
                    B_Busqueda_S = " Select Codigo_Catalogo,Codigo_Grupo,Codigo_Clase,Codigo_Familia,Codigo_Item,Descripcion_Grupo as Grupo,Descripcion_Clase As Clase,Descripcion_Familia as Familia,a.Codigo,Descripcion_Item as Item, Descripcion_Unidad_Medida as [Unidad Medida],Clasificador,Estado From Catalogo_Servicios as a inner join Catalogo_CN as b on a.codigo=b.codigo"
                    B_Busqueda_W = " Where Codigo_Catalogo='02' and b.unidad_medida='SERVICIOS' and b.Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'"
                    B_Busqueda_O = " Order By Abs(Codigo_Catalogo),Abs(Codigo_Grupo),Abs(Codigo_Clase),Abs(Codigo_Familia),Abs(Codigo_Item) "
                    Grupo = Datos.LLenar_Combo("Select * From Lista_Grupos Where Codigo_Catalogo='02'", Me.cbGrupo, "Grupo")
                    Me.cbGrupo.SelectedIndex = 0
                    Me.RadioButton1.Checked = True
                    Call Me.Filtrar()
                End If
            Case "03" 'Obras
        End Select
        Select Case Operacion
            Case 1
                Me.btnAceptar.Enabled = False
                Me.btnAceptar.Visible = False
                Me.btnCancelar.Text = "&Finalizar"
            Case 2
                Me.btnAceptar.Enabled = False
                Me.btnAceptar.Visible = False
                Me.btnCancelar.Text = "&Cancelar"
        End Select
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Select Case Tipo_Catalogo
            Case "01"
                Variable_Codigo_Catalogo = ""
                Variable_Codigo_Grupo = ""
                Variable_Codigo_Clase = ""
                Variable_Codigo_Familia = ""
                Variable_Codigo_Item = ""
                Me.Close()
            Case "02"
                Variable_Codigo_Catalogo = ""
                Variable_Codigo_Grupo = ""
                Variable_Codigo_Clase = ""
                Variable_Codigo_Familia = ""
                Variable_Codigo_Item = ""
                Me.Close()
        End Select
    End Sub
    Sub Filtrar()
         'If Tipo_Modulo = 1 Then
            gbCombos.Enabled = False

            If Me.RadioButton1.Checked = True Then
                If Me.txtDatos.Text.Trim.Length > 0 Then
                    Llenar(B_Busqueda_S & B_Busqueda_W & " And Descripcion_Item Like '%" & Me.txtDatos.Text.Trim & "%' " & B_Busqueda_O)
                Else
                    'MessageBox.Show("Ingrese al menos 3 caracteres para el criterio de busqueda.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    'Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
                End If
            End If
        If Me.RadioButton2.Checked = True Then
            If Me.txtDatos.Text.Trim.Length > 0 Then
                If Tipo_Modulo = 0 Then
                    Llenar(B_Busqueda_S & " Where Codigo Like '%" & Me.txtDatos.Text.Trim & "%' " & B_Busqueda_O)
                Else
                    Llenar(B_Busqueda_S & " Where a.Codigo Like '%" & Me.txtDatos.Text.Trim & "%' " & B_Busqueda_O)
                End If

            Else
                'MessageBox.Show("Ingrese el codigo del item para el filtro de busqueda.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                'Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
            End If
        End If
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.DataSource = DT
        If DT.Rows.Count > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & DT.Rows.Count
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
        End If
        Call Me.Dimensionar()
    End Sub
    Private Sub Dimensionar()
        Select Case Me.Operacion
            Case 1
                Me.DataGridView1.Columns(0).Width = 0
                Me.DataGridView1.Columns(1).Width = 0
                Me.DataGridView1.Columns(2).Width = 0
                Me.DataGridView1.Columns(3).Width = 0
                Me.DataGridView1.Columns(4).Width = 0
                Me.DataGridView1.Columns(5).Width = 0
                Me.DataGridView1.Columns(6).Width = 0
                Me.DataGridView1.Columns(7).Width = 0
                Me.DataGridView1.Columns(8).Width = 100
                Me.DataGridView1.Columns(9).Width = 500
                Me.DataGridView1.Columns(10).Width = 100
                Me.DataGridView1.Columns(11).Width = 100
                Me.DataGridView1.Columns(12).Width = 80
                Me.DataGridView1.Columns(0).Visible = False
                Me.DataGridView1.Columns(1).Visible = False
                Me.DataGridView1.Columns(2).Visible = False
                Me.DataGridView1.Columns(3).Visible = False
                Me.DataGridView1.Columns(4).Visible = False
                Me.DataGridView1.Columns(5).Visible = False
                Me.DataGridView1.Columns(6).Visible = False
                Me.DataGridView1.Columns(7).Visible = False
                Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView1.ColumnHeadersHeight = 30
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Case 2
                Me.DataGridView1.Columns(0).Width = 0
                Me.DataGridView1.Columns(1).Width = 0
                Me.DataGridView1.Columns(2).Width = 0
                Me.DataGridView1.Columns(3).Width = 0
                Me.DataGridView1.Columns(4).Width = 0
                Me.DataGridView1.Columns(5).Width = 0
                Me.DataGridView1.Columns(6).Width = 0
                Me.DataGridView1.Columns(7).Width = 0
                Me.DataGridView1.Columns(8).Width = 100
                Me.DataGridView1.Columns(9).Width = 420
                Me.DataGridView1.Columns(10).Width = 100
                Me.DataGridView1.Columns(11).Width = 100
                Me.DataGridView1.Columns(12).Width = 80
                Me.DataGridView1.Columns(0).Visible = False
                Me.DataGridView1.Columns(1).Visible = False
                Me.DataGridView1.Columns(2).Visible = False
                Me.DataGridView1.Columns(3).Visible = False
                Me.DataGridView1.Columns(4).Visible = False
                Me.DataGridView1.Columns(5).Visible = False
                Me.DataGridView1.Columns(6).Visible = False
                Me.DataGridView1.Columns(7).Visible = False
                Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView1.ColumnHeadersHeight = 30
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Dim Boton1 As New DataGridViewButtonColumn
                With Boton1
                    .Name = "btnSeleccionar"
                    .HeaderText = "Seleccionar"
                    .Text = "Seleccionar"
                    .UseColumnTextForButtonValue = True
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .FlatStyle = FlatStyle.Standard
                    .CellTemplate.Style.BackColor = Color.Honeydew
                    .DisplayIndex = 13
                End With
                DataGridView1.Columns.Add(Boton1)
                DataGridView1.Columns(13).Width = 100
        End Select
       
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Catalogo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Variable_Codigo_Grupo = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Codigo_Clase = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Codigo_Familia = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_Codigo_Item = Me.DataGridView1.CurrentRow.Cells(4).Value
        Else
            Variable_Codigo_Catalogo = ""
            Variable_Codigo_Grupo = ""
            Variable_Codigo_Clase = ""
            Variable_Codigo_Familia = ""
            Variable_Codigo_Item = ""
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "btnSeleccionar" Then
            Me.Close()
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Catalogo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Variable_Codigo_Grupo = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Codigo_Clase = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Codigo_Familia = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_Codigo_Item = Me.DataGridView1.CurrentRow.Cells(4).Value
        Else
            Variable_Codigo_Catalogo = ""
            Variable_Codigo_Grupo = ""
            Variable_Codigo_Clase = ""
            Variable_Codigo_Familia = ""
            Variable_Codigo_Item = ""
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Catalogo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Variable_Codigo_Grupo = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Codigo_Clase = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Codigo_Familia = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_Codigo_Item = Me.DataGridView1.CurrentRow.Cells(4).Value
            Me.Close()
        Else
            Variable_Codigo_Catalogo = ""
            Variable_Codigo_Grupo = ""
            Variable_Codigo_Clase = ""
            Variable_Codigo_Familia = ""
            Variable_Codigo_Item = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Catalogo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Variable_Codigo_Grupo = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Codigo_Clase = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Codigo_Familia = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_Codigo_Item = Me.DataGridView1.CurrentRow.Cells(4).Value
        Else
            Variable_Codigo_Catalogo = ""
            Variable_Codigo_Grupo = ""
            Variable_Codigo_Clase = ""
            Variable_Codigo_Familia = ""
            Variable_Codigo_Item = ""
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Catalogo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Variable_Codigo_Grupo = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Codigo_Clase = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Codigo_Familia = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_Codigo_Item = Me.DataGridView1.CurrentRow.Cells(4).Value
            Me.Close()
        Else
            Variable_Codigo_Catalogo = ""
            Variable_Codigo_Grupo = ""
            Variable_Codigo_Clase = ""
            Variable_Codigo_Familia = ""
            Variable_Codigo_Item = ""
        End If
    End Sub
    'Private Sub cbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedIndexChanged
    '    If Me.cbGrupo.Items.Count > 0 Then
    '        Me.cbFamilia.DataSource = Nothing
    '        Me.cbClase.DataSource = Nothing
    '        Select Case Tipo_Catalogo
    '            Case "01"
    '                If Me.cbGrupo.SelectedIndex = 0 Then
    '                    Clase = Datos.LLenar_Combo("Select * From Lista_Clases Where Codigo_Catalogo='01'", Me.cbClase, "Clase")
    '                    if Tipo_Modulo = 0 
    '                        cbClase.SelectedIndex = 1
    '                    Else
    '                        cbClase.SelectedIndex = 0
    '                    End If
    '                    If Tipo_Modulo = 0 Then
    '                        Call Me.Filtrar()
    '                    End If
    '                Else
    '                    Clase = Datos.LLenar_Combo("Select * From Lista_Clases Where Codigo_Catalogo='01' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex - 1).Item("Codigo_Grupo").ToString & "'", Me.cbClase, "Clase")
    '                    if Tipo_Modulo = 0 
    '                        cbClase.SelectedIndex = 1
    '                    Else
    '                        cbClase.SelectedIndex = 0
    '                    End If
    '                     If Tipo_Modulo = 0 Then
    '                        Call Me.Filtrar()
    '                    End If
    '                End If
    '            Case "02"
    '                If Me.cbGrupo.SelectedIndex = 0 Then
    '                    Clase = Datos.LLenar_Combo("Select * From Lista_Clases Where Codigo_Catalogo='02'", Me.cbClase, "Clase")
    '                    if Tipo_Modulo = 0 
    '                        cbClase.SelectedIndex = 1
    '                    Else
    '                        cbClase.SelectedIndex = 0
    '                    End If
    '                     If Tipo_Modulo = 0 Then
    '                        Call Me.Filtrar()
    '                    End If
    '                Else
    '                    Clase = Datos.LLenar_Combo("Select * From Lista_Clases Where Codigo_Catalogo='02' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex - 1).Item("Codigo_Grupo").ToString & "'", Me.cbClase, "Clase")
    '                    if Tipo_Modulo = 0 
    '                        cbClase.SelectedIndex = 1
    '                    Else
    '                        cbClase.SelectedIndex = 0
    '                    End If
    '                     If Tipo_Modulo = 0 Then
    '                        Call Me.Filtrar()
    '                    End If
    '                End If
    '        End Select
    '    End If
    'End Sub
    'Private Sub cbClase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbClase.SelectedIndexChanged
    '    If Me.cbClase.Items.Count > 0 Then
    '        Me.cbFamilia.DataSource = Nothing
    '        Select Case Tipo_Catalogo
    '            Case "01"
    '                If Me.cbGrupo.SelectedIndex = 0 Then
    '                    If Me.cbClase.SelectedIndex = 0 Then
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='01'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If

    '                        If Tipo_Modulo = 0 Then
    '                            Call Me.Filtrar()
    '                        End If
    '                    Else
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='01' And Codigo_Clase='" & Clase.Rows(Me.cbClase.SelectedIndex - 1).Item("Codigo_Clase").ToString & "'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                        If Tipo_Modulo = 0 Then
    '                           Call Me.Filtrar()
    '                        End If
    '                    End If
    '                Else
    '                    If Me.cbClase.SelectedIndex = 0 Then
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='01' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex - 1).Item("Codigo_Grupo").ToString & "'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                        If Tipo_Modulo = 0 Then
    '                           Call Me.Filtrar()
    '                        End If
    '                    Else
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='01' And Codigo_Clase='" & Clase.Rows(Me.cbClase.SelectedIndex - 1).Item("Codigo_Clase").ToString & "' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex - 1).Item("Codigo_Grupo").ToString & "'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                        If Tipo_Modulo = 0 Then
    '                           Call Me.Filtrar()
    '                        End If
    '                    End If
    '                End If
    '            Case "02"
    '                If Me.cbGrupo.SelectedIndex = 0 Then
    '                    If Me.cbClase.SelectedIndex = 0 Then
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='02'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                    Else
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='02' And Codigo_Clase='" & Clase.Rows(Me.cbClase.SelectedIndex - 1).Item("Codigo_Clase").ToString & "'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                    End If
    '                Else
    '                    If Me.cbClase.SelectedIndex = 0 Then
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='02' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex - 1).Item("Codigo_Grupo").ToString & "'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                    Else
    '                        Familia = Datos.LLenar_Combo("Select * From Lista_Familias Where Codigo_Catalogo='02' And Codigo_Clase='" & Clase.Rows(Me.cbClase.SelectedIndex - 1).Item("Codigo_Clase").ToString & "' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex - 1).Item("Codigo_Grupo").ToString & "'", Me.cbFamilia, "Familia")
    '                        if Tipo_Modulo = 0 
    '                            cbFamilia.SelectedIndex = 1
    '                        Else
    '                            cbFamilia.SelectedIndex = 0
    '                        End If
    '                    End If
    '                End If
    '        End Select
    '    End If
    'End Sub
    'Private Sub cbFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFamilia.SelectedIndexChanged
    '    If Me.cbFamilia.Items.Count > 0 Then
    '        If Tipo_Modulo = 0 Then
    '           Call Me.Filtrar()
    '        End If
    '    End If
    'End Sub
    Private Sub txtDatos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatos.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtDatos.Text.Trim.Length > 2 Then
                Call Me.Filtrar()
            Else
                MessageBox.Show("Debes Ingresar almenos un (03) caracter para realizar el filtrado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtDatos.Focus()
            End If
        End If
    End Sub
    'Private Sub btnBuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGrupo.Click
    '    Dim Formulario As New frmBuscar_Grupos
    '    Select Case Tipo_Catalogo
    '        Case "01"
    '            Formulario.Operacion = 1
    '        Case "02"
    '            Formulario.Operacion = 2
    '    End Select
    '    Formulario.ShowDialog()
    '    If Variable_Descripcion_Grupo.Trim.Length > 0 Then Me.cbGrupo.Text = Variable_Descripcion_Grupo
    'End Sub
    'Private Sub btnBuscarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarClase.Click
    '    Dim Formulario As New frmBuscar_Clases
    '    Select Case Tipo_Catalogo
    '        Case "01"
    '            Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex
    '            Formulario.Operacion = 1
    '        Case "02"
    '            Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex
    '            Formulario.Operacion = 2
    '    End Select
    '    Formulario.ShowDialog()
    '    If Variable_Descripcion_Grupo.Trim.Length > 0 Then Me.cbGrupo.Text = Variable_Descripcion_Grupo
    '    If Variable_Descripcion_Clase.Trim.Length > 0 Then Me.cbClase.Text = Variable_Descripcion_Clase
    'End Sub
    'Private Sub btnBuscarFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFamilia.Click
    '    Dim Formulario As New frmBuscar_Familia
    '    Select Case Tipo_Catalogo
    '        Case "01"
    '            Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex
    '            Formulario.Parametro_Clase = Me.cbClase.SelectedIndex
    '            Formulario.Operacion = 1
    '        Case "02"
    '            Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex
    '            Formulario.Parametro_Clase = Me.cbClase.SelectedIndex
    '            Formulario.Operacion = 2
    '    End Select
    '    Formulario.ShowDialog()
    '    If Variable_Descripcion_Grupo.Trim.Length > 0 Then Me.cbGrupo.Text = Variable_Descripcion_Grupo
    '    If Variable_Descripcion_Clase.Trim.Length > 0 Then Me.cbClase.Text = Variable_Descripcion_Clase
    '    If Variable_Descripcion_Familia.Trim.Length > 0 Then Me.cbFamilia.Text = Variable_Descripcion_Familia
    'End Sub
    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        If Me.RadioButton1.Checked = True Then
            If Me.txtDatos.Text.Trim.Length <= 0 Then Call Me.RadioButton1_CheckedChanged(sender, e)
        End If
        If Me.RadioButton2.Checked = True Then
            If Me.txtDatos.Text.Trim.Length <= 0 Then Call Me.RadioButton2_CheckedChanged(sender, e)
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.lblBusqueda.Text = "Ingresar Descripción del Item:"
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.gbCombos.Enabled = True
        If Tipo_Modulo = 0 Then
            Call Me.Filtrar()
        Else
            gbCombos.Enabled=False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.lblBusqueda.Text = "Ingresar Código del Item:"
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.gbCombos.Enabled = False
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Rows.Clear()
        If Me.DataGridView1.RowCount > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & Me.DataGridView1.RowCount
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
        End If
    End Sub
    Private Sub CopiarGlosaAlPortapapelesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarGlosaAlPortapapelesToolStripMenuItem.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Select Case Tipo_Catalogo
                Case "01"
                    Datos.Copiar_Data_Catalogo_BS_Portapapeles(1, Variable_Codigo_Grupo & "." & Variable_Codigo_Clase & "." & Variable_Codigo_Familia & "." & Variable_Codigo_Item, "Codigo")
                Case "02"
                    Datos.Copiar_Data_Catalogo_BS_Portapapeles(2, Variable_Codigo_Grupo & "." & Variable_Codigo_Clase & "." & Variable_Codigo_Familia & "." & Variable_Codigo_Item, "Codigo")
            End Select
        End If
    End Sub
    Private Sub CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Select Case Tipo_Catalogo
                Case "01"
                    Datos.Copiar_Data_Catalogo_BS_Portapapeles(1, Variable_Codigo_Grupo & "." & Variable_Codigo_Clase & "." & Variable_Codigo_Familia & "." & Variable_Codigo_Item, "Descripcion_Item")
                Case "02"
                    Datos.Copiar_Data_Catalogo_BS_Portapapeles(2, Variable_Codigo_Grupo & "." & Variable_Codigo_Clase & "." & Variable_Codigo_Familia & "." & Variable_Codigo_Item, "Descripcion_Item")
            End Select
        End If
    End Sub
    Private Sub AsistenteParaDuplicidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsistenteParaDuplicidadToolStripMenuItem.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Select Case Tipo_Catalogo
                Case "01"
                    Datos.Copiar_Data_Catalogo_BS_Portapapeles(1, Variable_Codigo_Grupo & "." & Variable_Codigo_Clase & "." & Variable_Codigo_Familia & "." & Variable_Codigo_Item, "Descripcion_Unidad_Medida")
                Case "02"
                    Datos.Copiar_Data_Catalogo_BS_Portapapeles(2, Variable_Codigo_Grupo & "." & Variable_Codigo_Clase & "." & Variable_Codigo_Familia & "." & Variable_Codigo_Item, "Descripcion_Unidad_Medida")
            End Select
        End If
    End Sub
End Class