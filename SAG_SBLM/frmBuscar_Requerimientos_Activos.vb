Public Class frmBuscar_Requerimientos_Activos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Public Operacion As Integer = 0
    Public Parametro_Cadena As String = ""
    Private Sub frmBuscar_Requerimientos_Activos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Select Case Operacion
            Case 1
                B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Nombre_Unidad_Organica as [Unidad Orgánica],Justificacion,IsNull(Convert(VarChar(10),FechaEmision,103),'00/00/0000') as Emisión,IsNull(Convert(VarChar(10),FechaAutorizacion,103),'00/00/0000') as Autorización,IsNull(Convert(VarChar(10),FechaAprobacion,103),'00/00/0000') As Aprobación,Monto_Referencial as Referencial,Descripcion_Estado_Requerimiento as Estado from [dbo].[lista_requerimientos_bienes_basica] "
                B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Codigo_Estado_Requerimiento In('03','05') And Numero In(" & Me.Parametro_Cadena & ")"
                B_Busqueda_O = " Order By Abs(Numero)"
                Call Me.Filtrar()
                Call Dimensionar()
            Case 2
                B_Busqueda_S = " Select Año_Ejecucion As Año,Numero,Nombre_Unidad_Organica as [Unidad Orgánica],Justificacion,IsNull(Convert(VarChar(10),FechaEmision,103),'00/00/0000') as Emisión,IsNull(Convert(VarChar(10),FechaAutorizacion,103),'00/00/0000') as Autorización,IsNull(Convert(VarChar(10),FechaAprobacion,103),'00/00/0000') As Aprobación,Monto_Referencial as Referencial,Descripcion_Estado_Requerimiento as Estado from [dbo].[lista_requerimientos_servicios_basica] "
                B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Codigo_Estado_Requerimiento In('03','05') And Numero In(" & Me.Parametro_Cadena & ")"
                B_Busqueda_O = " Order By Abs(Numero)"
                Call Me.Filtrar()
                Call Dimensionar()
        End Select
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Select Case Operacion
            Case 1
                Variable_Numero_Requerimiento_Bien = ""
                Me.Close()
            Case 2
                Variable_Numero_Requerimiento_Servicio = ""
                Me.Close()
        End Select
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Número de Requerimiento"
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Justificación del Requerimiento"
    End Sub
    Sub Filtrar()
        If Me.txtDatos.Text.Length > 0 Then
            Dim S As String = ""
            If Me.RadioButton1.Checked = True Then
                S = " And Numero Like '%" & Me.txtDatos.Text.Trim & "%'"
            End If
            If Me.RadioButton3.Checked = True Then
                S = " And Justificacion Like '%" & Me.txtDatos.Text.Trim & "%'"
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
        Me.DataGridView1.Columns(0).Width = 40
        Me.DataGridView1.Columns(1).Width = 50
        Me.DataGridView1.Columns(2).Width = 275
        Me.DataGridView1.Columns(3).Width = 275
        Me.DataGridView1.Columns(4).Width = 80
        Me.DataGridView1.Columns(5).Width = 80
        Me.DataGridView1.Columns(6).Width = 80
        Me.DataGridView1.Columns(7).Width = 80
        Me.DataGridView1.Columns(8).Width = 80
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
        Select Case Operacion
            Case 1
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Bien = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Bien = ""
                End If
            Case 2
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Servicio = ""
                End If
        End Select
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Select Case Operacion
            Case 1
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Bien = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Bien = ""
                End If
            Case 2
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Servicio = ""
                End If
        End Select
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Select Case Operacion
            Case 1
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Bien = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Bien = ""
                End If
            Case 2
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Servicio = ""
                End If
        End Select
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Select Case Operacion
            Case 1
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Bien = Me.DataGridView1.CurrentRow.Cells(1).Value
                    Me.Close()
                Else
                    Variable_Numero_Requerimiento_Bien = ""
                End If
            Case 2
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
                    Me.Close()
                Else
                    Variable_Numero_Requerimiento_Servicio = ""
                End If
        End Select
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Select Case Operacion
            Case 1
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Bien = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Bien = ""
                End If
            Case 2
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
                Else
                    Variable_Numero_Requerimiento_Servicio = ""
                End If
        End Select
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case Operacion
            Case 1
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Bien = Me.DataGridView1.CurrentRow.Cells(1).Value
                    Me.Close()
                Else
                    Variable_Numero_Requerimiento_Bien = ""
                End If
            Case 2
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
                    Me.Close()
                Else
                    Variable_Numero_Requerimiento_Servicio = ""
                End If
        End Select
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Refrencial" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
    End Sub
End Class