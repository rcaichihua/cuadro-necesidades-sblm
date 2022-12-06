Public Class frmBuscar_Usuarios
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Private Sub frmBuscar_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        B_Busqueda_S = " Select Codigo_Usuario as Codigo,Descripcion As Tipo,[Nombre Completo],Usuario,Case Activo When 1 Then 'ACTIVO' When 0 Then 'INACTIVO' End As Estado from Lista_Usuarios "
        B_Busqueda_W = " Where Codigo_Usuario <> '000' "
        B_Busqueda_O = " Order By Codigo_Usuario "
        Call Me.Filtrar()
        Call Dimensionar()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Tipo_Transaccion = ""
        Variable_Generica = ""
        Variable_SubGenerica = ""
        Variable_SubGenerica_Detalle = ""
        Variable_Especifica = ""
        Variable_Especifica_Detalle = ""
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Usuario"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Nombre Completo"
    End Sub
    Sub Filtrar()
        If Me.txtDatos.Text.Length > 0 Then
            Dim S As String = ""
            If Me.RadioButton1.Checked = True Then
                S = " And Usuario Like '%" & Me.txtDatos.Text.Trim & "%'"
            End If
            If Me.RadioButton2.Checked = True Then
                S = " And [Nombre Completo] Like '%" & Me.txtDatos.Text.Trim & "%'"
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
        Me.DataGridView1.Columns(0).Width = 60
        Me.DataGridView1.Columns(1).Width = 120
        Me.DataGridView1.Columns(2).Width = 320
        Me.DataGridView1.Columns(3).Width = 120
        Me.DataGridView1.Columns(4).Width = 100
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            'Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
        Else
            'Variable_Tipo_Transaccion = ""
            'Variable_Generica = ""
            'Variable_SubGenerica = ""
            'Variable_SubGenerica_Detalle = ""
            'Variable_Especifica = ""
            'Variable_Especifica_Detalle = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            'Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
        Else
            'Variable_Tipo_Transaccion = ""
            'Variable_Generica = ""
            'Variable_SubGenerica = ""
            'Variable_SubGenerica_Detalle = ""
            'Variable_Especifica = ""
            'Variable_Especifica_Detalle = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            'Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
        Else
            'Variable_Tipo_Transaccion = ""
            'Variable_Generica = ""
            'Variable_SubGenerica = ""
            'Variable_SubGenerica_Detalle = ""
            'Variable_Especifica = ""
            'Variable_Especifica_Detalle = ""
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            'Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Me.Close()
        Else
            'Variable_Tipo_Transaccion = ""
            'Variable_Generica = ""
            'Variable_SubGenerica = ""
            'Variable_SubGenerica_Detalle = ""
            'Variable_Especifica = ""
            'Variable_Especifica_Detalle = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            'Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
        Else
            'Variable_Tipo_Transaccion = ""
            'Variable_Generica = ""
            'Variable_SubGenerica = ""
            'Variable_SubGenerica_Detalle = ""
            'Variable_Especifica = ""
            'Variable_Especifica_Detalle = ""
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            'Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            'Me.Close()
        Else
            'Variable_Tipo_Transaccion = ""
            'Variable_Generica = ""
            'Variable_SubGenerica = ""
            'Variable_SubGenerica_Detalle = ""
            'Variable_Especifica = ""
            'Variable_Especifica_Detalle = ""
        End If
    End Sub

End Class