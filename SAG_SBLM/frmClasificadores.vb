Public Class frmClasificadores
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Dim Tab As New System.Windows.Forms.TabPage
    Private Sub frmClasificadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        TabControl1.SelectedTab = TabPage1
        Call TabControl1_Click(sender, e)
    End Sub
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TypeOf Tab Is System.Windows.Forms.TabPage Then
            If TabControl1.SelectedTab Is TabPage1 Then
                B_Busqueda_S = " Select * From Lista_Tipo_Transaccion_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT"
                Call Filtrar(1)
                Call Dimensionar(1)
            End If
            If TabControl1.SelectedTab Is TabPage2 Then
                B_Busqueda_S = " Select * From Lista_Generica_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G"
                Call Filtrar(2)
                Call Dimensionar(2)
            End If
            If TabControl1.SelectedTab Is TabPage3 Then
                B_Busqueda_S = " Select * From Lista_Sub_Generica_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG"
                Call Filtrar(3)
                Call Dimensionar(3)
            End If
            If TabControl1.SelectedTab Is TabPage4 Then
                B_Busqueda_S = " Select * From Lista_Sub_Generica_Detalle_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG,SGD"
                Call Filtrar(4)
                Call Dimensionar(4)
            End If
            If TabControl1.SelectedTab Is TabPage5 Then
                B_Busqueda_S = " Select * From Lista_Especifica_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG,SGD,E"
                Call Filtrar(5)
                Call Dimensionar(5)
            End If
            If TabControl1.SelectedTab Is TabPage6 Then
                B_Busqueda_S = " Select * From Lista_Especifica_Detalle_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG,SGD,E,ED"
                Call Filtrar(6)
                Call Dimensionar(6)
            End If
        Else
            Exit Sub
        End If
    End Sub
    Sub Filtrar(ByVal Tabulador As Integer)
        Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O, Tabulador)
        Call Me.Dimensionar(Tabulador)
    End Sub
    Sub Llenar(ByVal S_Busqueda As String, ByVal Tabulador As Integer)
        Select Case Tabulador
            Case 1
                Dim DT As New DataTable
                DT = Datos.LLenar_DT(S_Busqueda)
                Me.DataGridView1.DataSource = DT
                If DT.Rows.Count > 0 Then

                End If
            Case 2
                Dim DT As New DataTable
                DT = Datos.LLenar_DT(S_Busqueda)
                Me.DataGridView2.DataSource = DT
                If DT.Rows.Count > 0 Then

                End If
            Case 3
                Dim DT As New DataTable
                DT = Datos.LLenar_DT(S_Busqueda)
                Me.DataGridView3.DataSource = DT
                If DT.Rows.Count > 0 Then

                End If
            Case 4
                Dim DT As New DataTable
                DT = Datos.LLenar_DT(S_Busqueda)
                Me.DataGridView4.DataSource = DT
                If DT.Rows.Count > 0 Then

                End If
            Case 5
                Dim DT As New DataTable
                DT = Datos.LLenar_DT(S_Busqueda)
                Me.DataGridView5.DataSource = DT
                If DT.Rows.Count > 0 Then

                End If
            Case 6
                Dim DT As New DataTable
                DT = Datos.LLenar_DT(S_Busqueda)
                Me.DataGridView6.DataSource = DT
                If DT.Rows.Count > 0 Then

                End If
          
        End Select

    End Sub
    Private Sub Dimensionar(ByVal Tabulador As Integer)
        Select Case Tabulador
            Case 1
                Me.DataGridView1.Columns(0).Width = 50
                Me.DataGridView1.Columns(1).Width = 30
                Me.DataGridView1.Columns(2).Width = 600
                Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView1.ColumnHeadersHeight = 30
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'Me.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Case 2
                Me.DataGridView2.Columns(0).Width = 50
                Me.DataGridView2.Columns(1).Width = 30
                Me.DataGridView2.Columns(2).Width = 30
                Me.DataGridView2.Columns(3).Width = 570
                Me.DataGridView2.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView2.ColumnHeadersHeight = 30
                Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.DataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'Me.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Case 3
                Me.DataGridView3.Columns(0).Width = 50
                Me.DataGridView3.Columns(1).Width = 30
                Me.DataGridView3.Columns(2).Width = 30
                Me.DataGridView3.Columns(3).Width = 30
                Me.DataGridView3.Columns(4).Width = 540
                Me.DataGridView3.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView3.ColumnHeadersHeight = 30
                Me.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView3.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView3.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView3.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView3.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView3.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.DataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'Me.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Case 4
                Me.DataGridView4.Columns(0).Width = 50
                Me.DataGridView4.Columns(1).Width = 30
                Me.DataGridView4.Columns(2).Width = 30
                Me.DataGridView4.Columns(3).Width = 30
                Me.DataGridView4.Columns(4).Width = 30
                Me.DataGridView4.Columns(5).Width = 510
                Me.DataGridView4.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView4.ColumnHeadersHeight = 30
                Me.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView4.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView4.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView4.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView4.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView4.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView4.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.DataGridView4.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'Me.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Case 5
                Me.DataGridView5.Columns(0).Width = 50
                Me.DataGridView5.Columns(1).Width = 30
                Me.DataGridView5.Columns(2).Width = 30
                Me.DataGridView5.Columns(3).Width = 30
                Me.DataGridView5.Columns(4).Width = 30
                Me.DataGridView5.Columns(5).Width = 30
                Me.DataGridView5.Columns(6).Width = 480
                Me.DataGridView5.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView5.ColumnHeadersHeight = 30
                Me.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView5.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView5.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView5.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView5.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView5.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView5.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView5.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.DataGridView5.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'Me.DataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Case 6
                Me.DataGridView6.Columns(0).Width = 50
                Me.DataGridView6.Columns(1).Width = 30
                Me.DataGridView6.Columns(2).Width = 30
                Me.DataGridView6.Columns(3).Width = 30
                Me.DataGridView6.Columns(4).Width = 30
                Me.DataGridView6.Columns(5).Width = 30
                Me.DataGridView6.Columns(6).Width = 30
                Me.DataGridView6.Columns(7).Width = 450
                Me.DataGridView6.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView6.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView6.ColumnHeadersHeight = 30
                Me.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView6.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView6.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.DataGridView6.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'Me.DataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
       
        End Select

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If TypeOf Tab Is System.Windows.Forms.TabPage Then
            If TabControl1.SelectedTab Is TabPage1 Then
                B_Busqueda_S = " Select * From Lista_Tipo_Transaccion_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT"
                Call Filtrar(1)
                Call Dimensionar(1)
                If DataGridView1.RowCount > 0 Then
                    MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    Datos.Generar_Clasificadores(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1, 1)
                    B_Busqueda_S = " Select * From Lista_Tipo_Transaccion_Basica "
                    B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                    B_Busqueda_O = " Order By Año,TT"
                    Call Filtrar(1)
                    Call Dimensionar(1)
                End If
            End If
            If TabControl1.SelectedTab Is TabPage2 Then
                B_Busqueda_S = " Select * From Lista_Generica_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G"
                Call Filtrar(2)
                Call Dimensionar(2)
                If DataGridView2.RowCount > 0 Then
                    MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    Datos.Generar_Clasificadores(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1, 2)
                    B_Busqueda_S = " Select * From Lista_Generica_Basica "
                    B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                    B_Busqueda_O = " Order By Año,TT,G"
                    Call Filtrar(2)
                    Call Dimensionar(2)
                End If
            End If
            If TabControl1.SelectedTab Is TabPage3 Then
                B_Busqueda_S = " Select * From Lista_Sub_Generica_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG"
                Call Filtrar(3)
                Call Dimensionar(3)
                If DataGridView3.RowCount > 0 Then
                    MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    Datos.Generar_Clasificadores(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1, 3)
                    B_Busqueda_S = " Select * From Lista_Sub_Generica_Basica "
                    B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                    B_Busqueda_O = " Order By Año,TT,G,SG"
                    Call Filtrar(3)
                    Call Dimensionar(3)
                End If
            End If
            If TabControl1.SelectedTab Is TabPage4 Then
                B_Busqueda_S = " Select * From Lista_Sub_Generica_Detalle_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG,SGD"
                Call Filtrar(4)
                Call Dimensionar(4)
                If DataGridView4.RowCount > 0 Then
                    MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    Datos.Generar_Clasificadores(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1, 4)
                    B_Busqueda_S = " Select * From Lista_Sub_Generica_Detalle_Basica "
                    B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                    B_Busqueda_O = " Order By Año,TT,G,SG,SGD"
                    Call Filtrar(4)
                    Call Dimensionar(4)
                End If
            End If
            If TabControl1.SelectedTab Is TabPage5 Then
                B_Busqueda_S = " Select * From Lista_Especifica_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG,SGD,E"
                Call Filtrar(5)
                Call Dimensionar(5)
                If DataGridView5.RowCount > 0 Then
                    MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    Datos.Generar_Clasificadores(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1, 5)
                    B_Busqueda_S = " Select * From Lista_Especifica_Basica "
                    B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                    B_Busqueda_O = " Order By Año,TT,G,SG,SGD,E"
                    Call Filtrar(5)
                    Call Dimensionar(5)
                End If
            End If
            If TabControl1.SelectedTab Is TabPage6 Then
                B_Busqueda_S = " Select * From Lista_Especifica_Detalle_Basica "
                B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                B_Busqueda_O = " Order By Año,TT,G,SG,SGD,E,ED"
                Call Filtrar(6)
                Call Dimensionar(6)
                If DataGridView6.RowCount > 0 Then
                    MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    Datos.Generar_Clasificadores(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1, 6)
                    B_Busqueda_S = " Select * From Lista_Especifica_Detalle_Basica "
                    B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
                    B_Busqueda_O = " Order By Año,TT,G,SG,SGD,E,ED"
                    Call Filtrar(6)
                    Call Dimensionar(6)
                End If
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class