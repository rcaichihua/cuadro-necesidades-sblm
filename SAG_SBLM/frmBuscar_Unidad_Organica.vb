Public Class frmBuscar_Unidad_Organica
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Private Sub frmBuscar_Unidad_Organica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        B_Busqueda_S = " Select Año_Ejecucion As Año,Codigo_Unidad_Organica As ID,Nombre_Unidad_Organica As Unidad from Unidad_Organica "
        B_Busqueda_W = " Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & " 'And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")"
        B_Busqueda_O = " Order By Año_Ejecucion,Codigo_Unidad_Organica"
        Call Me.Filtrar()
        Call Dimensionar()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Codigo_Ubigeo = ""
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Nombre de la Unidad"
    End Sub
    Sub Filtrar()
        If Me.txtDatos.Text.Length > 0 Then
            Dim S As String = ""
            If Me.RadioButton1.Checked = True Then
                S = " And Nombre Like '%" & Me.txtDatos.Text.Trim & "%'"
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
        Me.DataGridView1.Columns(0).Width = 90
        Me.DataGridView1.Columns(1).Width = 460
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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
            Variable_Codigo_Ubigeo = Me.DataGridView1.CurrentRow.Cells(0).Value
        Else
            Variable_Codigo_Ubigeo = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Ubigeo = Me.DataGridView1.CurrentRow.Cells(0).Value
        Else
            Variable_Codigo_Ubigeo = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Ubigeo = Me.DataGridView1.CurrentRow.Cells(0).Value
        Else
            Variable_Codigo_Ubigeo = ""
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Ubigeo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        Else
            Variable_Codigo_Ubigeo = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Ubigeo = Me.DataGridView1.CurrentRow.Cells(0).Value
        Else
            Variable_Codigo_Ubigeo = ""
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Ubigeo = Me.DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        Else
            Variable_Codigo_Ubigeo = ""
        End If
    End Sub
End Class