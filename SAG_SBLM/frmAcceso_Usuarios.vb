Public Class frmAcceso_Usuarios
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S_ As String = ""
    Dim B_Busqueda_W_ As String = ""
    Dim B_Busqueda_O_ As String = ""
    Dim Tipo As New DataTable
    Private Sub frmAcceso_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Tipo = Datos.LLenar_Combo_Solo("Select * From Tipo_Usuario", Me.cbTipo_Usuario, "Descripcion")
        Datos.Cargar_Datos_Usuarios(Variable_Codigo_Usuario, Me.txtCodigo, Me.cbTipo_Usuario, Me.txtApellidos, Me.txtNombres, Me.txtUsuario)
        Call Dimensionar()
        Call Dimensionar2()
        Call Dimensionar3()
        Call Dimensionar4()
        Call Dimensionar5()
        Call Dimensionar6()
        Call Dimensionar7()
        Call Dimensionar8()
        Datos.Cargar_Botones_Sub_Botones_Modulo_01(Me.DataGridView1)
        Datos.Cargar_Botones_Sub_Botones_Modulo_02(Me.DataGridView2)
        Datos.Cargar_Botones_Sub_Botones_Modulo_03(Me.DataGridView3)
        Datos.Cargar_Botones_Sub_Botones_Modulo_04(Me.DataGridView4)
        Datos.Cargar_Botones_Sub_Botones_Modulo_05(Me.DataGridView5)
        Datos.Cargar_Botones_Sub_Botones_Modulo_06(Me.DataGridView6)
        Datos.Cargar_Botones_Sub_Botones_Modulo_07(Me.DataGridView7)
        Datos.Cargar_Botones_Sub_Botones_Modulo_08(Me.DataGridView8)
        B_Busqueda_S_ = " select Año_Ejecucion As Año,Codigo_Unidad_Organica as Código,Nombre_Unidad_Organica as [Unidad Orgánica],Abreviatura From Unidad_Organica "
        B_Busqueda_W_ = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' "
        B_Busqueda_O_ = " Order By Año_Ejecucion,Codigo_Unidad_Organica"
        Call Me.Filtrar_()
        Datos.Cargar_Botones_Activos(Variable_Codigo_Usuario, Me.DataGridView1)
        Datos.Cargar_Botones_Activos2(Variable_Codigo_Usuario, Me.DataGridView2)
        Datos.Cargar_Botones_Activos3(Variable_Codigo_Usuario, Me.DataGridView3)
        Datos.Cargar_Botones_Activos4(Variable_Codigo_Usuario, Me.DataGridView4)
        Datos.Cargar_Botones_Activos5(Variable_Codigo_Usuario, Me.DataGridView5)
        Datos.Cargar_Botones_Activos6(Variable_Codigo_Usuario, Me.DataGridView6)
        Datos.Cargar_Botones_Activos7(Variable_Codigo_Usuario, Me.DataGridView7)
        Datos.Cargar_Botones_Activos8(Variable_Codigo_Usuario, Me.DataGridView8)
        Datos.Cargar_SubBotones_Activos(Variable_Codigo_Usuario, Me.DataGridView1)
        Datos.Cargar_SubBotones_Activos2(Variable_Codigo_Usuario, Me.DataGridView2)
        Datos.Cargar_SubBotones_Activos3(Variable_Codigo_Usuario, Me.DataGridView3)
        Datos.Cargar_SubBotones_Activos4(Variable_Codigo_Usuario, Me.DataGridView4)
        Datos.Cargar_SubBotones_Activos5(Variable_Codigo_Usuario, Me.DataGridView5)
        Datos.Cargar_SubBotones_Activos6(Variable_Codigo_Usuario, Me.DataGridView6)
        Datos.Cargar_SubBotones_Activos7(Variable_Codigo_Usuario, Me.DataGridView7)
        Datos.Cargar_SubBotones_Activos8(Variable_Codigo_Usuario, Me.DataGridView8)
        Datos.Cargar_Unidades_Activos(Variable_Codigo_Usuario, Me.DataGridView_Area, My.Settings.Año_Ejecucion)
    End Sub
    Private Sub btnBuscar_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Usuarios.Click
        Dim Formualario As New frmBuscar_Usuarios
        Formualario.ShowDialog()
    End Sub
    Sub Filtrar_()
        Dim S As String = ""
        Llenar_(B_Busqueda_S_ & B_Busqueda_W_ & S & B_Busqueda_O_)
        Call Me.Dimensionar_()
    End Sub
    Sub Llenar_(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.DataGridView_Area.DataSource = DT
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Código", "Código")
        Me.DataGridView1.Columns.Add("Módulo", "Módulo")
        Me.DataGridView1.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView1.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView1.Columns.Add(Check)
        Me.DataGridView1.Columns(0).Width = 60
        Me.DataGridView1.Columns(1).Width = 270
        Me.DataGridView1.Columns(2).Width = 270
        Me.DataGridView1.Columns(3).Width = 270
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar2()
        Me.DataGridView2.Columns.Clear()
        Me.DataGridView2.Columns.Add("Código", "Código")
        Me.DataGridView2.Columns.Add("Módulo", "Módulo")
        Me.DataGridView2.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView2.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView2.Columns.Add(Check)
        Me.DataGridView2.Columns(0).Width = 60
        Me.DataGridView2.Columns(1).Width = 270
        Me.DataGridView2.Columns(2).Width = 270
        Me.DataGridView2.Columns(3).Width = 270
        Me.DataGridView2.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar3()
        Me.DataGridView3.Columns.Clear()
        Me.DataGridView3.Columns.Add("Código", "Código")
        Me.DataGridView3.Columns.Add("Módulo", "Módulo")
        Me.DataGridView3.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView3.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView3.Columns.Add(Check)
        Me.DataGridView3.Columns(0).Width = 60
        Me.DataGridView3.Columns(1).Width = 270
        Me.DataGridView3.Columns(2).Width = 270
        Me.DataGridView3.Columns(3).Width = 270
        Me.DataGridView3.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView3.ColumnHeadersHeight = 30
        Me.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView3.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView3.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView3.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar4()
        Me.DataGridView4.Columns.Clear()
        Me.DataGridView4.Columns.Add("Código", "Código")
        Me.DataGridView4.Columns.Add("Módulo", "Módulo")
        Me.DataGridView4.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView4.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView4.Columns.Add(Check)
        Me.DataGridView4.Columns(0).Width = 60
        Me.DataGridView4.Columns(1).Width = 270
        Me.DataGridView4.Columns(2).Width = 270
        Me.DataGridView4.Columns(3).Width = 270
        Me.DataGridView4.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView4.ColumnHeadersHeight = 30
        Me.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView4.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView4.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView4.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView4.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar5()
        Me.DataGridView5.Columns.Clear()
        Me.DataGridView5.Columns.Add("Código", "Código")
        Me.DataGridView5.Columns.Add("Módulo", "Módulo")
        Me.DataGridView5.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView5.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView5.Columns.Add(Check)
        Me.DataGridView5.Columns(0).Width = 60
        Me.DataGridView5.Columns(1).Width = 270
        Me.DataGridView5.Columns(2).Width = 270
        Me.DataGridView5.Columns(3).Width = 270
        Me.DataGridView5.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView5.ColumnHeadersHeight = 30
        Me.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView5.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView5.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView5.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView5.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar6()
        Me.DataGridView6.Columns.Clear()
        Me.DataGridView6.Columns.Add("Código", "Código")
        Me.DataGridView6.Columns.Add("Módulo", "Módulo")
        Me.DataGridView6.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView6.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView6.Columns.Add(Check)
        Me.DataGridView6.Columns(0).Width = 60
        Me.DataGridView6.Columns(1).Width = 270
        Me.DataGridView6.Columns(2).Width = 270
        Me.DataGridView6.Columns(3).Width = 270
        Me.DataGridView6.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView6.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView6.ColumnHeadersHeight = 30
        Me.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView6.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView6.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView6.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView6.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar7()
        Me.DataGridView7.Columns.Clear()
        Me.DataGridView7.Columns.Add("Código", "Código")
        Me.DataGridView7.Columns.Add("Módulo", "Módulo")
        Me.DataGridView7.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView7.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView7.Columns.Add(Check)
        Me.DataGridView7.Columns(0).Width = 60
        Me.DataGridView7.Columns(1).Width = 270
        Me.DataGridView7.Columns(2).Width = 270
        Me.DataGridView7.Columns(3).Width = 270
        Me.DataGridView7.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView7.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView7.ColumnHeadersHeight = 30
        Me.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView7.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView7.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView7.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView7.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar8()
        Me.DataGridView8.Columns.Clear()
        Me.DataGridView8.Columns.Add("Código", "Código")
        Me.DataGridView8.Columns.Add("Módulo", "Módulo")
        Me.DataGridView8.Columns.Add("BotónPrimario", "Botón Primario")
        Me.DataGridView8.Columns.Add("BotónSecundario", "Botón Secundario")
        Dim Check As New DataGridViewCheckBoxColumn()
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView8.Columns.Add(Check)
        Me.DataGridView8.Columns(0).Width = 60
        Me.DataGridView8.Columns(1).Width = 270
        Me.DataGridView8.Columns(2).Width = 270
        Me.DataGridView8.Columns(3).Width = 270
        Me.DataGridView8.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView8.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView8.ColumnHeadersHeight = 30
        Me.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView8.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView8.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView8.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView8.Columns(4).Width = 60
    End Sub
    Private Sub Dimensionar_()
        Me.DataGridView_Area.Columns(0).Width = 70
        Me.DataGridView_Area.Columns(1).Width = 60
        Me.DataGridView_Area.Columns(2).Width = 500
        Me.DataGridView_Area.Columns(3).Width = 90
        Me.DataGridView_Area.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView_Area.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView_Area.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView_Area.ColumnHeadersHeight = 30
        Me.DataGridView_Area.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_Area.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView_Area.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView_Area.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Dim Check As New DataGridViewCheckBoxColumn()
        DataGridView_Area.Columns.Add(Check)
        Check.HeaderText = "Acceso"
        Check.Name = "Acceso"
        DataGridView_Area.Columns(4).Width = 60
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call Me.DataGridView1_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView1_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.DataGridView1.CurrentRow.Cells(4).Value = Not Me.DataGridView1.CurrentRow.Cells(4).Value
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
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView1.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView1.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView1.CurrentRow.Cells(4).Value = Not Me.DataGridView1.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Call Me.DataGridView2_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If DataGridView2.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView2.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView2_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Me.DataGridView2.CurrentRow.Cells(4).Value = Not Me.DataGridView2.CurrentRow.Cells(4).Value
        DataGridView2_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        Call DataGridView2_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView2_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView2.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView2.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView2.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView2.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView2.CurrentRow.Cells(4).Value = Not Me.DataGridView2.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Call Me.DataGridView3_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If DataGridView3.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView3.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView3_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView3_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        Me.DataGridView3.CurrentRow.Cells(4).Value = Not Me.DataGridView3.CurrentRow.Cells(4).Value
        DataGridView3_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView3_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        Call DataGridView3_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView3_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView3_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView3.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView3.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView3.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView3.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView3.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView3.CurrentRow.Cells(4).Value = Not Me.DataGridView3.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView4_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Call Me.DataGridView4_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If DataGridView4.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView4.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView4.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView4_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView4_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellDoubleClick
        Me.DataGridView4.CurrentRow.Cells(4).Value = Not Me.DataGridView4.CurrentRow.Cells(4).Value
        DataGridView4_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView4_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellEnter
        Call DataGridView4_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView4_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView4_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView4.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView4.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView4.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView4.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView4.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView4.CurrentRow.Cells(4).Value = Not Me.DataGridView4.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView5_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        Call Me.DataGridView5_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        If DataGridView5.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView5.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView5.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView5.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView5_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView5_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellDoubleClick
        Me.DataGridView5.CurrentRow.Cells(4).Value = Not Me.DataGridView5.CurrentRow.Cells(4).Value
        DataGridView5_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView5_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellEnter
        Call DataGridView5_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView5_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView5_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView5.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView5.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView5.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView5.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView5.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView5.CurrentRow.Cells(4).Value = Not Me.DataGridView5.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView6_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellClick
        Call Me.DataGridView6_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView6_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick
        If DataGridView6.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView6.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView6.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView6.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView6_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView6_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellDoubleClick
        Me.DataGridView6.CurrentRow.Cells(4).Value = Not Me.DataGridView6.CurrentRow.Cells(4).Value
        DataGridView6_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView6_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellEnter
        Call DataGridView6_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView6_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView6_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView6.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView6.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView6.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView6.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView6.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView6.CurrentRow.Cells(4).Value = Not Me.DataGridView6.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView7_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellClick
        Call Me.DataGridView7_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        If DataGridView7.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView7.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView7.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView7.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView7_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView7_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellDoubleClick
        Me.DataGridView7.CurrentRow.Cells(4).Value = Not Me.DataGridView7.CurrentRow.Cells(4).Value
        DataGridView7_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView7_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellEnter
        Call DataGridView7_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView7_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView7_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView7.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView7.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView7.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView7.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView7.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView7.CurrentRow.Cells(4).Value = Not Me.DataGridView7.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub DataGridView8_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellClick
        Call Me.DataGridView8_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView8_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellContentClick
        If DataGridView8.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView8.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView8.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView8.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView8_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView8_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellDoubleClick
        Me.DataGridView8.CurrentRow.Cells(4).Value = Not Me.DataGridView8.CurrentRow.Cells(4).Value
        DataGridView8_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView8_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellEnter
        Call DataGridView8_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView8_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView8_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView8.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView8.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView8.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView8.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView8.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView8.CurrentRow.Cells(4).Value = Not Me.DataGridView8.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Datos.Guardar_Accesos_Botones_Sub_Botones(Variable_Codigo_Usuario, Me.DataGridView1, Me.DataGridView2, Me.DataGridView3, Me.DataGridView4, Me.DataGridView5, Me.DataGridView6, Me.DataGridView7, Me.DataGridView8)
        Datos.Guardar_Accesos_Unidades_Organicas(My.Settings.Año_Ejecucion, Variable_Codigo_Usuario, Me.DataGridView_Area)
        Me.Close()
    End Sub
    Private Sub DataGridView_Area_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Area.CellClick
        Call Me.DataGridView_Area_CellDoubleClick(sender, e)
    End Sub
    Private Sub DataGridView_Area_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Area.CellContentClick
        If DataGridView_Area.Columns(e.ColumnIndex).Name = "Acceso" Then
            Dim row As DataGridViewRow = DataGridView_Area.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Acceso"), DataGridViewCheckBoxCell)
            DataGridView_Area.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            DataGridView_Area.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
        DataGridView_Area_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView_Area_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Area.CellDoubleClick
        Me.DataGridView_Area.CurrentRow.Cells(4).Value = Not Me.DataGridView_Area.CurrentRow.Cells(4).Value
        DataGridView_Area_CellEnter(sender, e)
    End Sub
    Private Sub DataGridView_Area_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call DataGridView_Area_CellValueChanged(sender, e)
    End Sub
    Private Sub DataGridView_Area_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Area.CellValueChanged
        If e.RowIndex = -1 Then
            Return
        End If
    End Sub
    Private Sub DataGridView_Area_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView_Area.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.DataGridView_Area.CurrentCell, DataGridViewCheckBoxCell)
        If (cb Is Nothing) Then Return
        Dim checkBox As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView_Area.CurrentRow.Cells(4), DataGridViewCheckBoxCell)
        DataGridView_Area.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub DataGridView_Area_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView_Area.KeyPress
        If e.KeyChar = Chr(32) Then
            Me.DataGridView_Area.CurrentRow.Cells(4).Value = Not Me.DataGridView_Area.CurrentRow.Cells(4).Value
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView1.RowCount - 1
            Me.DataGridView1.Rows(Recorrido).Cells(4).Value = Me.CheckBox1.Checked
        Next
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView_Area.RowCount - 1
            Me.DataGridView_Area.Rows(Recorrido).Cells(4).Value = Me.CheckBox2.Checked
        Next
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView2.RowCount - 1
            Me.DataGridView2.Rows(Recorrido).Cells(4).Value = Me.CheckBox3.Checked
        Next
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView3.RowCount - 1
            Me.DataGridView3.Rows(Recorrido).Cells(4).Value = Me.CheckBox4.Checked
        Next
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView4.RowCount - 1
            Me.DataGridView4.Rows(Recorrido).Cells(4).Value = Me.CheckBox5.Checked
        Next
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView5.RowCount - 1
            Me.DataGridView5.Rows(Recorrido).Cells(4).Value = Me.CheckBox6.Checked
        Next
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView6.RowCount - 1
            Me.DataGridView6.Rows(Recorrido).Cells(4).Value = Me.CheckBox7.Checked
        Next
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView7.RowCount - 1
            Me.DataGridView7.Rows(Recorrido).Cells(4).Value = Me.CheckBox8.Checked
        Next
    End Sub
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        
        For Recorrido As Integer = 0 To Me.DataGridView8.RowCount - 1
            Me.DataGridView8.Rows(Recorrido).Cells(4).Value = Me.CheckBox9.Checked
        Next
    End Sub
End Class