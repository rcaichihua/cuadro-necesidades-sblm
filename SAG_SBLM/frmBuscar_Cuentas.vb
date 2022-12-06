Public Class frmBuscar_Cuentas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Public Operacion As Integer = 0
    Public Naturaleza As String = ""
    Public Clasificadores As String = ""
    Public Cadena_Mayor As String = ""
    Private Sub frmBuscar_Cuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Año_Ejecucion < "2020" Then
            Select Case Operacion
                Case 1
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('13','15')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 2
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('53','15')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 3
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('53','15')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 4
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('53','15','13','15','51')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 5
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('53','15','13','15','51','52','21','55')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"

                    End Select

                Case 6
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('53','15')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"

                    End Select
                Case 7
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('53','15','13','15','51','52','21','55')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"

                    End Select

                Case 1000
                    Select Case Naturaleza
                        Case "D"

                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 10000
                    B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                    B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'"
                    B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
            End Select
        Else
            Select Case Operacion
                Case 1
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('60','34','33')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 2
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('33','60','62','63','65')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 3
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('60','33')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 4
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('60','33','25','62')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 5
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('67','65','64','63','62','60','46',40,'33','25','16')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"

                    End Select

                Case 6
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('60','62','63','33')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"

                    End Select
                Case 7
                    Select Case Naturaleza
                        Case "D"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Clasificador In(" & Clasificadores & ") And Left(Mayor,2)In('63','62','60','33','25','46','65')"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Mayor In(" & Cadena_Mayor & ")"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"

                    End Select

                Case 1000
                    Select Case Naturaleza
                        Case "D"

                        Case "H"

                        Case "A"
                            B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                            B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'"
                            B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
                    End Select
                Case 10000
                    B_Busqueda_S = " Select Año_Ejecucion As Año,Mayor,Sub_Cuenta As [Sub Cta.],Cuenta,Nombre_Sub_Cuenta As Descripcion,Clasificador From Lista_Plan_Cuentas_Clasificador_2 "
                    B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'"
                    B_Busqueda_O = " Order By Año_Ejecucion,Mayor,Sub_Cuenta"
            End Select
        End If
        

        'End If
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Call Me.Filtrar()
        Call Dimensionar()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
       Variable_Cuenta = ""
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Código de Cuenta"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Nombre de Cuenta"
    End Sub
    Sub Filtrar()
        If Me.txtDatos.Text.Length > 0 Then
            Dim S As String = ""
            If Me.RadioButton1.Checked = True Then
                S = " And Cuenta Like '%" & Me.txtDatos.Text.Trim & "%'"
            End If
            If Me.RadioButton2.Checked = True Then
                S = " And Nombre_Sub_Cuenta Like '%" & Me.txtDatos.Text.Trim & "%'"
            End If
            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
            Call Me.Dimensionar()
        Else
            Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
            Call Me.Dimensionar()
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
    Private Sub Dimensionar()
        Select Case Operacion
            Case 1
                Select Case Naturaleza
                    Case "D"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "H"
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 2
                Select Case Naturaleza
                    Case "D"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "H"
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 3
                Select Case Naturaleza
                    Case "D"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "H"
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 4
                Select Case Naturaleza
                    Case "D"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "H"
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 5, 7
                Select Case Naturaleza
                    Case "D"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "H"
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 6
                Select Case Naturaleza
                    Case "D"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "H"
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 1000
                Select Case Naturaleza
                    Case "A"
                        Me.DataGridView1.Columns(0).Width = 50
                        Me.DataGridView1.Columns(1).Width = 50
                        Me.DataGridView1.Columns(2).Width = 80
                        Me.DataGridView1.Columns(3).Width = 120
                        Me.DataGridView1.Columns(4).Width = 425
                        Me.DataGridView1.Columns(5).Width = 100
                        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                        Me.DataGridView1.ColumnHeadersHeight = 30
                        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
            Case 10000
                Me.DataGridView1.Columns(0).Width = 50
                Me.DataGridView1.Columns(1).Width = 50
                Me.DataGridView1.Columns(2).Width = 80
                Me.DataGridView1.Columns(3).Width = 120
                Me.DataGridView1.Columns(4).Width = 425
                Me.DataGridView1.Columns(5).Width = 100
                Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
                Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                Me.DataGridView1.ColumnHeadersHeight = 30
                Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Select
    End Sub
    Private Sub txtDatos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatos.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case Me.DataGridView1.Rows.Count
                Case 0
                    Return
                Case 1
                    Me.DataGridView1.Focus()
                    Call btnAceptar_Click(sender, e)
                Case Is > 1
                    Me.DataGridView1.Focus()
            End Select
        End If
    End Sub
    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        If Me.txtDatos.Text.Trim.Length > 0 Then
            Call Me.Filtrar()
        Else
            Call Me.Filtrar()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Mayor_Cuenta = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Sub_Cuenta = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Cuenta = Me.DataGridView1.CurrentRow.Cells(3).Value
        Else
            Variable_Mayor_Cuenta = ""
            Variable_Sub_Cuenta = ""
            Variable_Cuenta = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Mayor_Cuenta = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Sub_Cuenta = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Cuenta = Me.DataGridView1.CurrentRow.Cells(3).Value
        Else
            Variable_Mayor_Cuenta = ""
            Variable_Sub_Cuenta = ""
            Variable_Cuenta = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Mayor_Cuenta = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Sub_Cuenta = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Cuenta = Me.DataGridView1.CurrentRow.Cells(3).Value
        Else
            Variable_Mayor_Cuenta = ""
            Variable_Sub_Cuenta = ""
            Variable_Cuenta = ""
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Mayor_Cuenta = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Sub_Cuenta = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Cuenta = Me.DataGridView1.CurrentRow.Cells(3).Value
            Me.Close()
        Else
            Variable_Mayor_Cuenta = ""
            Variable_Sub_Cuenta = ""
            Variable_Cuenta = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Mayor_Cuenta = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Sub_Cuenta = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Cuenta = Me.DataGridView1.CurrentRow.Cells(3).Value
        Else
            Variable_Mayor_Cuenta = ""
            Variable_Sub_Cuenta = ""
            Variable_Cuenta = ""
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Mayor_Cuenta = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_Sub_Cuenta = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_Cuenta = Me.DataGridView1.CurrentRow.Cells(3).Value
            Me.Close()
        Else
            Variable_Mayor_Cuenta = ""
            Variable_Sub_Cuenta = ""
            Variable_Cuenta = ""
        End If
    End Sub
End Class