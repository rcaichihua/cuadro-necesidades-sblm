Public Class frmRegistro_Acciones_Modificatorias
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
    Dim Motivo As New DataTable
    Public Editar As Boolean = False
    Dim Separador As Char
    Private Sub cbFF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFF.SelectedIndexChanged
        Me.cbRubro.DataSource = Nothing
        If Me.cbFF.Text.Trim.Length > 0 Then
            Rubro = Datos.LLenar_Combo_Solo("Select * From Lista_Rubros Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF='" & Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF") & "'", Me.cbRubro, "Rubro")
        Else
            Me.cbRubro.DataSource = Nothing
        End If
        txtSaldo.Text = "0.00"
    End Sub
    Private Sub cbUnidadOrganica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidadOrganica.SelectedIndexChanged
        Me.cbSecuenciaFuncional.DataSource = Nothing
        Me.cbActividad.DataSource = Nothing
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
            Secuencia_Funcional = Datos.LLenar_Combo_Solo("Select * From Lista_Secuencias Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbSecuenciaFuncional, "Codigo_Secuencia_Funcional")
            Me.cbSecuenciaFuncional.SelectedIndex = 0
        Else
            Me.cbSecuenciaFuncional.DataSource = Nothing
        End If
    End Sub
    Private Sub cbSecuenciaFuncional_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSecuenciaFuncional.SelectedIndexChanged
        Me.cbActividad.DataSource = Nothing
        If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
            If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                Actividad = Datos.LLenar_Combo_Solo("Select * From Lista_Actividades Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Secuencia_Funcional='" & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional") & "' And Codigo_Unidad_Organica='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica") & "'", Me.cbActividad, "Actividad")
                Me.cbActividad.SelectedIndex = 0
            Else
                Me.cbActividad.DataSource = Nothing
            End If
        Else
            Me.cbActividad.DataSource = Nothing
        End If
    End Sub
    Private Sub Dimensionar()
        Me.dgvDistribucionCn.Rows.Clear()
        Me.dgvDistribucionCn.Columns.Clear()
        Me.dgvDistribucionCn.Columns.Add("Año", "Año") '0
        Me.dgvDistribucionCn.Columns.Add("FF", "FF")
        Me.dgvDistribucionCn.Columns.Add("R", "R")
        Me.dgvDistribucionCn.Columns.Add("TT", "TT") '3
        Me.dgvDistribucionCn.Columns.Add("G", "G")
        Me.dgvDistribucionCn.Columns.Add("SG", "SG")
        Me.dgvDistribucionCn.Columns.Add("SGD", "SGD") '6
        Me.dgvDistribucionCn.Columns.Add("E", "E")
        Me.dgvDistribucionCn.Columns.Add("ED", "ED")
        Me.dgvDistribucionCn.Columns.Add("Clasificador", "Clasificador") '9
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
        Me.dgvDistribucionCn.Columns.Add("Descripcion_Especifica_Detalle", "Descripcion_Especifica_Detalle") '37
        Me.dgvDistribucionCn.Columns.Add("Total", "Total")
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
        Me.dgvDistribucionCn.Columns(3).Visible = False
        Me.dgvDistribucionCn.Columns(4).Visible = False
        Me.dgvDistribucionCn.Columns(5).Visible = False
        Me.dgvDistribucionCn.Columns(6).Visible = False
        Me.dgvDistribucionCn.Columns(7).Visible = False
        Me.dgvDistribucionCn.Columns(8).Visible = False
        Me.dgvDistribucionCn.Columns(13).Visible = False
        Me.dgvDistribucionCn.Columns(14).Visible = False
        Me.dgvDistribucionCn.Columns(15).Visible = False
        Me.dgvDistribucionCn.Columns(16).Visible = False
        Me.dgvDistribucionCn.Columns(19).Visible = False
        Me.dgvDistribucionCn.Columns(21).Visible = False
        Me.dgvDistribucionCn.Columns(35).Visible = False
        Me.dgvDistribucionCn.Columns(36).Visible = False
        Me.dgvDistribucionCn.Columns(37).Visible = False

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
        Dim Boton1 As New DataGridViewButtonColumn
        With Boton1
            .Name = "btnEditar"
            .HeaderText = "Editar"
            .Text = "Editar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 39
        End With
        dgvDistribucionCn.Columns.Add(Boton1)
        dgvDistribucionCn.Columns(39).Width = 70
        Dim Boton2 As New DataGridViewButtonColumn
        With Boton2
            .Name = "btnEliminar"
            .HeaderText = "Eliminar"
            .Text = "Eliminar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 40
        End With
        dgvDistribucionCn.Columns.Add(Boton2)
        dgvDistribucionCn.Columns(40).Width = 70

        Me.dgvDistribucionCn.Columns.Add("db", "db")
        Me.dgvDistribucionCn.Columns(41).Visible = False
    End Sub

    Private Sub txtEnero_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnero.Enter
        txtEnero.SelectionStart = 0
        txtEnero.SelectionLength = txtEnero.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtEnero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnero.GotFocus, txtEnero_m.GotFocus
        txtEnero.SelectionStart = 0
        txtEnero.SelectionLength = txtEnero.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtEnero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnero.KeyPress
        If txtEnero.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtFebrero.Focus()
        End If
    End Sub
    Private Sub txtEnero_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnero.Leave
        If Me.txtEnero.Text.Trim.Length > 0 Then
            Me.txtEnero.Text = FormatNumber(txtEnero.Text, 2, , , TriState.True)
        Else
            Me.txtEnero.Text = "0.00"
        End If
    End Sub
    Private Sub txtEnero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnero.LostFocus, txtEnero_m.LostFocus
        With Me.txtEnero
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub

    Private Sub txtEnero_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEnero.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtFebrero_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFebrero.Enter
        txtFebrero.SelectionStart = 0
        txtFebrero.SelectionLength = txtFebrero.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtFebrero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFebrero.GotFocus, txtFebrero_m.GotFocus
        txtFebrero.SelectionStart = 0
        txtFebrero.SelectionLength = txtFebrero.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtFebrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFebrero.KeyPress
        If txtFebrero.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtMarzo.Focus()
        End If
    End Sub
    Private Sub txtFebrero_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFebrero.Leave
        If Me.txtFebrero.Text.Trim.Length > 0 Then
            Me.txtFebrero.Text = FormatNumber(txtFebrero.Text, 2, , , TriState.True)
        Else
            Me.txtFebrero.Text = "0.00"
        End If
    End Sub
    Private Sub txtFebrero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFebrero.LostFocus, txtFebrero_m.LostFocus
        With Me.txtFebrero
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtMarzo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarzo.Enter
        txtMarzo.SelectionStart = 0
        txtMarzo.SelectionLength = txtMarzo.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtMarzo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarzo.GotFocus, txtMarzo_m.GotFocus
        txtMarzo.SelectionStart = 0
        txtMarzo.SelectionLength = txtMarzo.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtMarzo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarzo.KeyPress
        If txtMarzo.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtAbril.Focus()
        End If
    End Sub
    Private Sub txtMarzo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarzo.Leave
        If Me.txtMarzo.Text.Trim.Length > 0 Then
            Me.txtMarzo.Text = FormatNumber(txtMarzo.Text, 2, , , TriState.True)
        Else
            Me.txtMarzo.Text = "0.00"
        End If
    End Sub
    Private Sub txtMarzo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarzo.LostFocus, txtMarzo_m.LostFocus
        With Me.txtMarzo
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtAbril_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbril.Enter
        txtAbril.SelectionStart = 0
        txtAbril.SelectionLength = txtAbril.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtAbril_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbril.GotFocus, txtAbril_m.GotFocus
        txtAbril.SelectionStart = 0
        txtAbril.SelectionLength = txtAbril.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtAbril_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbril.KeyPress
        If txtAbril.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtMayo.Focus()
        End If
    End Sub
    Private Sub txtAbril_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbril.Leave
        If Me.txtAbril.Text.Trim.Length > 0 Then
            Me.txtAbril.Text = FormatNumber(txtAbril.Text, 2, , , TriState.True)
        Else
            Me.txtAbril.Text = "0.00"
        End If
    End Sub
    Private Sub txtAbril_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbril.LostFocus, txtAbril_m.LostFocus
        With Me.txtAbril
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtMayo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMayo.Enter
        txtMayo.SelectionStart = 0
        txtMayo.SelectionLength = txtMayo.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtMayo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMayo.GotFocus, txtMayo_m.GotFocus
        txtMayo.SelectionStart = 0
        txtMayo.SelectionLength = txtMayo.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtMayo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMayo.KeyPress
        If txtMayo.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtJunio.Focus()
        End If
    End Sub
    Private Sub txtMayo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMayo.Leave
        If Me.txtMayo.Text.Trim.Length > 0 Then
            Me.txtMayo.Text = FormatNumber(txtMayo.Text, 2, , , TriState.True)
        Else
            Me.txtMayo.Text = "0.00"
        End If
    End Sub
    Private Sub txtMayo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMayo.LostFocus, txtMayo_m.LostFocus
        With Me.txtMayo
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtJunio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJunio.Enter
        txtJunio.SelectionStart = 0
        txtJunio.SelectionLength = txtJunio.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtJunio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJunio.GotFocus, txtJunio_m.GotFocus
        txtJunio.SelectionStart = 0
        txtJunio.SelectionLength = txtJunio.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtJunio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJunio.KeyPress
        If txtJunio.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtJulio.Focus()
        End If
    End Sub
    Private Sub txtJunio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJunio.Leave
        If Me.txtJunio.Text.Trim.Length > 0 Then
            Me.txtJunio.Text = FormatNumber(txtJunio.Text, 2, , , TriState.True)
        Else
            Me.txtJunio.Text = "0.00"
        End If
    End Sub
    Private Sub txtJunio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJunio.LostFocus, txtJunio_m.LostFocus
        With Me.txtJunio
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtJulio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJulio.Enter
        txtJulio.SelectionStart = 0
        txtJulio.SelectionLength = txtJulio.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtJulio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJulio.GotFocus, txtJulio_m.GotFocus
        txtJulio.SelectionStart = 0
        txtJulio.SelectionLength = txtJulio.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtJulio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJulio.KeyPress
        If txtJulio.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtAgosto.Focus()
        End If
    End Sub
    Private Sub txtJulio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJulio.Leave
        If Me.txtJulio.Text.Trim.Length > 0 Then
            Me.txtJulio.Text = FormatNumber(txtJulio.Text, 2, , , TriState.True)
        Else
            Me.txtJulio.Text = "0.00"
        End If
    End Sub
    Private Sub txtJulio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJulio.LostFocus, txtJulio_m.LostFocus
        With Me.txtJulio
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtAgosto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgosto.Enter
        txtAgosto.SelectionStart = 0
        txtAgosto.SelectionLength = txtAgosto.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtAgosto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgosto.GotFocus, txtAgosto_m.GotFocus
        txtAgosto.SelectionStart = 0
        txtAgosto.SelectionLength = txtAgosto.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtAgosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAgosto.KeyPress
        If txtAgosto.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtSeptiembre.Focus()
        End If
    End Sub
    Private Sub txtAgosto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgosto.Leave
        If Me.txtAgosto.Text.Trim.Length > 0 Then
            Me.txtAgosto.Text = FormatNumber(txtAgosto.Text, 2, , , TriState.True)
        Else
            Me.txtAgosto.Text = "0.00"
        End If
    End Sub
    Private Sub txtAgosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgosto.LostFocus, txtAgosto_m.LostFocus
        With Me.txtAgosto
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtSeptiembre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeptiembre.Enter
        txtSeptiembre.SelectionStart = 0
        txtSeptiembre.SelectionLength = txtSeptiembre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtSeptiembre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeptiembre.GotFocus, txtSeptiembre_m.GotFocus
        txtSeptiembre.SelectionStart = 0
        txtSeptiembre.SelectionLength = txtSeptiembre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtSeptiembre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeptiembre.KeyPress
        If txtSeptiembre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtOctubre.Focus()
        End If
    End Sub
    Private Sub txtSeptiembre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeptiembre.Leave
        If Me.txtSeptiembre.Text.Trim.Length > 0 Then
            Me.txtSeptiembre.Text = FormatNumber(txtSeptiembre.Text, 2, , , TriState.True)
        Else
            Me.txtSeptiembre.Text = "0.00"
        End If
    End Sub
    Private Sub txtSeptiembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeptiembre.LostFocus, txtSeptiembre_m.LostFocus
        With Me.txtSeptiembre
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtOctubre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOctubre.Enter
        txtOctubre.SelectionStart = 0
        txtOctubre.SelectionLength = txtOctubre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtOctubre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOctubre.GotFocus, txtOctubre_m.GotFocus
        txtOctubre.SelectionStart = 0
        txtOctubre.SelectionLength = txtOctubre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtOctubre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOctubre.KeyPress
        If txtOctubre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtNoviembre.Focus()
        End If
    End Sub
    Private Sub txtOctubre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOctubre.Leave
        If Me.txtOctubre.Text.Trim.Length > 0 Then
            Me.txtOctubre.Text = FormatNumber(txtOctubre.Text, 2, , , TriState.True)
        Else
            Me.txtOctubre.Text = "0.00"
        End If
    End Sub
    Private Sub txtOctubre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOctubre.LostFocus, txtOctubre_m.LostFocus
        With Me.txtOctubre
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtNoviembre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoviembre.Enter
        txtNoviembre.SelectionStart = 0
        txtNoviembre.SelectionLength = txtNoviembre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtNoviembre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoviembre.GotFocus, txtNoviembre_m.GotFocus
        txtNoviembre.SelectionStart = 0
        txtNoviembre.SelectionLength = txtNoviembre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtNoviembre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoviembre.KeyPress
        If txtNoviembre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.txtDiciembre.Focus()
        End If
    End Sub
    Private Sub txtNoviembre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoviembre.Leave
        If Me.txtNoviembre.Text.Trim.Length > 0 Then
            Me.txtNoviembre.Text = FormatNumber(txtNoviembre.Text, 2, , , TriState.True)
        Else
            Me.txtNoviembre.Text = "0.00"
        End If
    End Sub
    Private Sub txtNoviembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoviembre.LostFocus, txtNoviembre_m.LostFocus
        With Me.txtNoviembre
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub txtDiciembre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiciembre.Enter
        txtDiciembre.SelectionStart = 0
        txtDiciembre.SelectionLength = txtDiciembre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtDiciembre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiciembre.GotFocus, txtDiciembre_m.GotFocus
        txtDiciembre.SelectionStart = 0
        txtDiciembre.SelectionLength = txtDiciembre.Text.Length
        SumaTotalMeses()
    End Sub
    Private Sub txtDiciembre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiciembre.KeyPress
        If txtDiciembre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses()
        If Asc(e.KeyChar) = 13 Then
            Me.btnAgregar.Focus()
        End If
    End Sub
    Private Sub txtDiciembre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiciembre.Leave
        If Me.txtDiciembre.Text.Trim.Length > 0 Then
            Me.txtDiciembre.Text = FormatNumber(txtDiciembre.Text, 2, , , TriState.True)
        Else
            Me.txtDiciembre.Text = "0.00"
        End If
        btnAgregar.Focus()
    End Sub
    Private Sub txtDiciembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiciembre.LostFocus, txtDiciembre_m.LostFocus
        With Me.txtDiciembre
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub SumaTotalMeses()
        txtCantidad.Text = (Convert.ToDecimal(IIf(txtEnero.Text.Trim() = String.Empty, "0.00", txtEnero.Text)) + Convert.ToDecimal(IIf(txtFebrero.Text.Trim() = String.Empty, "0.00", txtFebrero.Text)) + Convert.ToDecimal(IIf(txtMarzo.Text.Trim() = String.Empty, "0.00", txtMarzo.Text)) + Convert.ToDecimal(IIf(txtAbril.Text.Trim() = String.Empty, "0.00", txtAbril.Text)) + Convert.ToDecimal(IIf(txtMayo.Text.Trim() = String.Empty, "0.00", txtMayo.Text)) + Convert.ToDecimal(IIf(txtJunio.Text.Trim() = String.Empty, "0.00", txtJunio.Text)) + Convert.ToDecimal(IIf(txtJulio.Text.Trim() = String.Empty, "0.00", txtJulio.Text)) + Convert.ToDecimal(IIf(txtAgosto.Text.Trim() = String.Empty, "0.00", txtAgosto.Text)) + Convert.ToDecimal(IIf(txtSeptiembre.Text.Trim() = String.Empty, "0.00", txtSeptiembre.Text)) + Convert.ToDecimal(IIf(txtOctubre.Text.Trim() = String.Empty, "0.00", txtOctubre.Text) + +Convert.ToDecimal(IIf(txtNoviembre.Text.Trim() = String.Empty, "0.00", txtNoviembre.Text)) + +Convert.ToDecimal(IIf(txtDiciembre.Text.Trim() = String.Empty, "0.00", txtDiciembre.Text)))).ToString("###,###,#.00")
    End Sub
    Private Sub SumaTotalMeses_modificado()
        'txtCantidad_m.Text = (Convert.ToDecimal(IIf(txtEnero_m.Text.Trim() = String.Empty, "0.00", txtEnero_m.Text)) + Convert.ToDecimal(IIf(txtFebrero_m.Text.Trim() = String.Empty, "0.00", txtFebrero_m.Text)) + Convert.ToDecimal(IIf(txtMarzo_m.Text.Trim() = String.Empty, "0.00", txtMarzo_m.Text)) + Convert.ToDecimal(IIf(txtAbril_m.Text.Trim() = String.Empty, "0.00", txtAbril_m.Text)) + Convert.ToDecimal(IIf(txtMayo_m.Text.Trim() = String.Empty, "0.00", txtMayo_m.Text)) + Convert.ToDecimal(IIf(txtJunio_m.Text.Trim() = String.Empty, "0.00", txtJunio_m.Text)) + Convert.ToDecimal(IIf(txtJulio_m.Text.Trim() = String.Empty, "0.00", txtJulio_m.Text)) + Convert.ToDecimal(IIf(txtAgosto_m.Text.Trim() = String.Empty, "0.00", txtAgosto_m.Text)) + Convert.ToDecimal(IIf(txtSeptiembre_m.Text.Trim() = String.Empty, "0.00", txtSeptiembre_m.Text)) + Convert.ToDecimal(IIf(txtOctubre_m.Text.Trim() = String.Empty, "0.00", txtOctubre_m.Text) + +Convert.ToDecimal(IIf(txtNoviembre_m.Text.Trim() = String.Empty, "0.00", txtNoviembre_m.Text)) + +Convert.ToDecimal(IIf(txtDiciembre_m.Text.Trim() = String.Empty, "0.00", txtDiciembre_m.Text)))).ToString("###,###,#.00")
        txtCantidad_m.Text = (Convert.ToDecimal(IIf(txtEnero_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaEnero.Checked, Convert.ToDecimal(IIf(txtEnero_m.Text=String.Empty,"0.00",txtEnero_m.Text))*-1,Convert.ToDecimal(IIf(txtEnero_m.Text=String.Empty,"0.00",txtEnero_m.Text))*1))) + 
                                Convert.ToDecimal(IIf(txtFebrero_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaFebrero.Checked, Convert.ToDecimal(IIf(txtFebrero_m.Text=String.Empty,"0.00",txtFebrero_m.Text))*-1,Convert.ToDecimal(IIf(txtFebrero_m.Text=String.Empty,"0.00",txtFebrero_m.Text))*1))) + 
                                Convert.ToDecimal(IIf(txtMarzo_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaMarzo.Checked, Convert.ToDecimal(IIf(txtMarzo_m.Text=String.Empty,"0.00",txtMarzo_m.Text))*-1,Convert.ToDecimal(IIf(txtMarzo_m.Text=String.Empty,"0.00",txtMarzo_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtAbril_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaAbril.Checked, Convert.ToDecimal(IIf(txtAbril_m.Text=String.Empty,"0.00",txtAbril_m.Text))*-1,Convert.ToDecimal(IIf(txtAbril_m.Text=String.Empty,"0.00",txtAbril_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtMayo_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaMayo.Checked, Convert.ToDecimal(IIf(txtMayo_m.Text=String.Empty,"0.00",txtMayo_m.Text))*-1,Convert.ToDecimal(IIf(txtMayo_m.Text=String.Empty,"0.00",txtMayo_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtJunio_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaJunio.Checked, Convert.ToDecimal(IIf(txtJunio_m.Text=String.Empty,"0.00",txtJunio_m.Text))*-1,Convert.ToDecimal(IIf(txtJunio_m.Text=String.Empty,"0.00",txtJunio_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtJulio_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaJulio.Checked, Convert.ToDecimal(IIf(txtJulio_m.Text=String.Empty,"0.00",txtJulio_m.Text))*-1,Convert.ToDecimal(IIf(txtJulio_m.Text=String.Empty,"0.00",txtJulio_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtAgosto_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaAgosto.Checked, Convert.ToDecimal(IIf(txtAgosto_m.Text=String.Empty,"0.00",txtAgosto_m.Text))*-1,Convert.ToDecimal(IIf(txtAgosto_m.Text=String.Empty,"0.00",txtAgosto_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtSeptiembre_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaSeptiembre.Checked, Convert.ToDecimal(IIf(txtSeptiembre_m.Text=String.Empty,"0.00",txtSeptiembre_m.Text))*-1,Convert.ToDecimal(IIf(txtSeptiembre_m.Text=String.Empty,"0.00",txtSeptiembre_m.Text))*1))) + 
                              Convert.ToDecimal(IIf(txtOctubre_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaOctubre.Checked, Convert.ToDecimal(IIf(txtOctubre_m.Text=String.Empty,"0.00",txtOctubre_m.Text))*-1,Convert.ToDecimal(IIf(txtOctubre_m.Text=String.Empty,"0.00",txtOctubre_m.Text))*1))) +
                              Convert.ToDecimal(IIf(txtNoviembre_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaNoviembre.Checked, Convert.ToDecimal(IIf(txtNoviembre_m.Text=String.Empty,"0.00",txtNoviembre_m.Text))*-1,Convert.ToDecimal(IIf(txtNoviembre_m.Text=String.Empty,"0.00",txtNoviembre_m.Text))*1))) +
                              Convert.ToDecimal(IIf(txtDiciembre_m.Text.Trim() = String.Empty, "0.00", IIf(chkRebajaDiciembre.Checked, Convert.ToDecimal(txtDiciembre_m.Text)*-1,Convert.ToDecimal(txtDiciembre_m.Text)*1)))).ToString("###,###,#.00")
        txtMonto.Text = ((Convert.ToDouble(txtCantidad_m.Text)) * Convert.ToDecimal(txtCosto.Text)).ToString("###,###,#.00")
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
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Costo" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvDistribucionCn.Columns(e.ColumnIndex).Name = "Cantidad" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
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
                                        If Me.cbMotivo.Text.Trim.Length > 0 Then
                                            If Convert.ToDouble(Me.txtCantidad_m.Text.Trim()) > 0 Or Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString="003" Then
                                                If Convert.ToDouble(Me.txtCosto.Text.Trim()) > 0 Then
                                                    If Convert.ToDouble(Me.txtCantidad_m.Text.Trim) > 0 Or Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString="003" Then 
                                                        If Convert.ToDouble(Me.txtSaldo.Text.Trim) - Convert.ToDouble(txtCantidad_m.Text) * Convert.ToDouble(txtCosto.Text) >= 0 Then
                                                            If VerificaModificaciones() Then Return
                                                            'If Datos.Verificar_Duplicidad_Grid_Global(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.dgvDistribucionCn) = True Then
                                                            If Datos.Verificar_Duplicidad_Grid_CN(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & IIf(rbBienes.Checked, "B.", "S.") & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "", Me.dgvDistribucionCn) = True Then
                                                                If Datos.Verificar_Items_No_Autorizados_AM_Por_Items(IIf(rbBienes.Checked, "B.", "S."),Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Variable_Numero_Accion_Modificatoria, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString,Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString,Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,Me.txtTipoTransaccion.Text.Trim,Me.txtGenerica.Text.Trim,Me.txtSubGenerica.Text.Trim,Me.txtSubGenericaDetalle.Text.Trim,Me.txtEspecifica.Text.Trim,Me.txtEspecificaDetalle.Text.Trim) = True Then
                                                                    Select Case Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString
                                                                        Case "001"
                                                                            Me.dgvDistribucionCn.Rows.Add()
                                                                            dgvDistribucionCn.Item(0, dgvDistribucionCn.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                                                                            dgvDistribucionCn.Item(1, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                                                                            dgvDistribucionCn.Item(2, dgvDistribucionCn.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                                                                            dgvDistribucionCn.Item(3, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim
                                                                            dgvDistribucionCn.Item(4, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtGenerica.Text.Trim
                                                                            dgvDistribucionCn.Item(5, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSubGenerica.Text.Trim
                                                                            dgvDistribucionCn.Item(6, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSubGenericaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(7, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEspecifica.Text.Trim
                                                                            dgvDistribucionCn.Item(8, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEspecificaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(9, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim.Trim & "." & Me.txtGenerica.Text.Trim & "." & Me.txtSubGenerica.Text.Trim & "." & Me.txtSubGenericaDetalle.Text.Trim & "." & Me.txtEspecifica.Text.Trim & "." & Me.txtEspecificaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(10, dgvDistribucionCn.Rows.Count - 1).Value = Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString
                                                                            dgvDistribucionCn.Item(11, dgvDistribucionCn.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                                                                            dgvDistribucionCn.Item(12, dgvDistribucionCn.Rows.Count - 1).Value = Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                                            dgvDistribucionCn.Item(13, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim
                                                                            dgvDistribucionCn.Item(14, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoClase.Text.Trim
                                                                            dgvDistribucionCn.Item(15, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoFamilia.Text.Trim
                                                                            dgvDistribucionCn.Item(16, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoItem.Text.Trim
                                                                            dgvDistribucionCn.Item(17, dgvDistribucionCn.Rows.Count - 1).Value = IIf(rbBienes.Checked, "B.", "S.") & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                                            dgvDistribucionCn.Item(18, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtItem.Text
                                                                            dgvDistribucionCn.Item(19, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                                            dgvDistribucionCn.Item(20, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtUnidadMedida.Text

                                                                            dgvDistribucionCn.Item(21, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                                            dgvDistribucionCn.Item(22, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00000")

                                                                            dgvDistribucionCn.Item(23, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEnero_m.Text
                                                                            dgvDistribucionCn.Item(24, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtFebrero_m.Text
                                                                            dgvDistribucionCn.Item(25, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtMarzo_m.Text
                                                                            dgvDistribucionCn.Item(26, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtAbril_m.Text
                                                                            dgvDistribucionCn.Item(27, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtMayo_m.Text
                                                                            dgvDistribucionCn.Item(28, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtJunio_m.Text
                                                                            dgvDistribucionCn.Item(29, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtJulio_m.Text
                                                                            dgvDistribucionCn.Item(30, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtAgosto_m.Text
                                                                            dgvDistribucionCn.Item(31, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSeptiembre_m.Text
                                                                            dgvDistribucionCn.Item(32, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtOctubre_m.Text
                                                                            dgvDistribucionCn.Item(33, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtNoviembre_m.Text
                                                                            dgvDistribucionCn.Item(34, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtDiciembre_m.Text
                                                                            dgvDistribucionCn.Item(35, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                                            dgvDistribucionCn.Item(36, dgvDistribucionCn.Rows.Count - 1).Value = IIf(rbBienes.Checked, "01", "02")
                                                                            dgvDistribucionCn.Item(38, dgvDistribucionCn.Rows.Count - 1).Value = Format(Math.Round(Convert.ToDouble(Me.txtCantidad_m.Text) * Convert.ToDouble(txtCosto.Text), 2, MidpointRounding.AwayFromZero), "###,###,#.00")
                                                                            dgvDistribucionCn.Item(41, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Me.txtDB.Text.Trim() = String.Empty, "0", Me.txtDB.Text)
                                                                            Me.txtEnero.Text = "0.00"
                                                                            Me.txtFebrero.Text = "0.00"
                                                                            Me.txtMarzo.Text = "0.00"
                                                                            Me.txtAbril.Text = "0.00"
                                                                            Me.txtMayo.Text = "0.00"
                                                                            Me.txtJunio.Text = "0.00"
                                                                            Me.txtJulio.Text = "0.00"
                                                                            Me.txtAgosto.Text = "0.00"
                                                                            Me.txtSeptiembre.Text = "0.00"
                                                                            Me.txtOctubre.Text = "0.00"
                                                                            Me.txtNoviembre.Text = "0.00"
                                                                            Me.txtDiciembre.Text = "0.00"

                                                                            Me.txtEnero_m.Text = "0.00"
                                                                            Me.txtFebrero_m.Text = "0.00"
                                                                            Me.txtMarzo_m.Text = "0.00"
                                                                            Me.txtAbril_m.Text = "0.00"
                                                                            Me.txtMayo_m.Text = "0.00"
                                                                            Me.txtJunio_m.Text = "0.00"
                                                                            Me.txtJulio_m.Text = "0.00"
                                                                            Me.txtAgosto_m.Text = "0.00"
                                                                            Me.txtSeptiembre_m.Text = "0.00"
                                                                            Me.txtOctubre_m.Text = "0.00"
                                                                            Me.txtNoviembre_m.Text = "0.00"
                                                                            Me.txtDiciembre_m.Text = "0.00"

                                                                            Me.cbUnidadOrganica.Enabled = False
                                                                            Me.txtMonto.Text = "0.00"
                                                                            Me.txtCantidad_m.Text = "0.00"
                                                                            Me.chkRebajar.Checked = False
                                                                            Me.btnBuscarItems.Focus()
                                                                            Me.cbMotivo.Enabled = False

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
                                                                            Variable_Codigo_Catalogo = ""
                                                                            Variable_Codigo_Grupo = ""
                                                                            Variable_Codigo_Clase = ""
                                                                            Variable_Codigo_Familia = ""
                                                                            Variable_Codigo_Item = ""
                                                                            Me.cbUnidadOrganica.Enabled = False
                                                                            Me.txtDB.Text = ""
                                                                            Me.btnBuscarItems.Focus()
                                                                        Case "002"
                                                                            Me.dgvDistribucionCn.Rows.Add()
                                                                            dgvDistribucionCn.Item(0, dgvDistribucionCn.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                                                                            dgvDistribucionCn.Item(1, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                                                                            dgvDistribucionCn.Item(2, dgvDistribucionCn.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                                                                            dgvDistribucionCn.Item(3, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim
                                                                            dgvDistribucionCn.Item(4, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtGenerica.Text.Trim
                                                                            dgvDistribucionCn.Item(5, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSubGenerica.Text.Trim
                                                                            dgvDistribucionCn.Item(6, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSubGenericaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(7, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEspecifica.Text.Trim
                                                                            dgvDistribucionCn.Item(8, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEspecificaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(9, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim.Trim & "." & Me.txtGenerica.Text.Trim & "." & Me.txtSubGenerica.Text.Trim & "." & Me.txtSubGenericaDetalle.Text.Trim & "." & Me.txtEspecifica.Text.Trim & "." & Me.txtEspecificaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(10, dgvDistribucionCn.Rows.Count - 1).Value = Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString
                                                                            dgvDistribucionCn.Item(11, dgvDistribucionCn.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                                                                            dgvDistribucionCn.Item(12, dgvDistribucionCn.Rows.Count - 1).Value = Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                                            dgvDistribucionCn.Item(13, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim
                                                                            dgvDistribucionCn.Item(14, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoClase.Text.Trim
                                                                            dgvDistribucionCn.Item(15, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoFamilia.Text.Trim
                                                                            dgvDistribucionCn.Item(16, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoItem.Text.Trim
                                                                            dgvDistribucionCn.Item(17, dgvDistribucionCn.Rows.Count - 1).Value = IIf(rbBienes.Checked, "B.", "S.") & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                                            dgvDistribucionCn.Item(18, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtItem.Text
                                                                            dgvDistribucionCn.Item(19, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                                            dgvDistribucionCn.Item(20, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtUnidadMedida.Text

                                                                            dgvDistribucionCn.Item(21, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                                            dgvDistribucionCn.Item(22, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00000")
                                                                            If chkRebajar.Checked 
                                                                                dgvDistribucionCn.Item(23, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtEnero_m.Text)>0,Convert.ToDecimal(Me.txtEnero_m.Text)*-1,Convert.ToDecimal(Me.txtEnero_m.Text))
                                                                                dgvDistribucionCn.Item(24, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtFebrero_m.Text)>0,Convert.ToDecimal(Me.txtFebrero_m.Text)*-1,Convert.ToDecimal(Me.txtFebrero_m.Text))
                                                                                dgvDistribucionCn.Item(25, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtMarzo_m.Text)>0,Convert.ToDecimal(Me.txtMarzo_m.Text)*-1,Convert.ToDecimal(Me.txtMarzo_m.Text))
                                                                                dgvDistribucionCn.Item(26, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtAbril_m.Text)>0,Convert.ToDecimal(Me.txtAbril_m.Text)*-1,Convert.ToDecimal(Me.txtAbril_m.Text))
                                                                                dgvDistribucionCn.Item(27, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtMayo_m.Text)>0,Convert.ToDecimal(Me.txtMayo_m.Text)*-1,Convert.ToDecimal(Me.txtMayo_m.Text))
                                                                                dgvDistribucionCn.Item(28, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtJunio_m.Text)>0,Convert.ToDecimal(Me.txtJunio_m.Text)*-1,Convert.ToDecimal(Me.txtJunio_m.Text))
                                                                                dgvDistribucionCn.Item(29, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtJulio_m.Text)>0,Convert.ToDecimal(Me.txtJulio_m.Text)*-1,Convert.ToDecimal(Me.txtJulio_m.Text))
                                                                                dgvDistribucionCn.Item(30, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtAgosto_m.Text)>0,Convert.ToDecimal(Me.txtAgosto_m.Text)*-1,Convert.ToDecimal(Me.txtAgosto_m.Text))
                                                                                dgvDistribucionCn.Item(31, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtSeptiembre_m.Text)>0,Convert.ToDecimal(Me.txtSeptiembre_m.Text)*-1,Convert.ToDecimal(Me.txtSeptiembre_m.Text))
                                                                                dgvDistribucionCn.Item(32, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtOctubre_m.Text)>0,Convert.ToDecimal(Me.txtOctubre_m.Text)*-1,Convert.ToDecimal(Me.txtOctubre_m.Text))
                                                                                dgvDistribucionCn.Item(33, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtNoviembre_m.Text)>0,Convert.ToDecimal(Me.txtNoviembre_m.Text)*-1,Convert.ToDecimal(Me.txtNoviembre_m.Text))
                                                                                dgvDistribucionCn.Item(34, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtDiciembre_m.Text)>0,Convert.ToDecimal(Me.txtDiciembre_m.Text)*-1,Convert.ToDecimal(Me.txtDiciembre_m.Text))
                                                                            Else 
                                                                                dgvDistribucionCn.Item(23, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtEnero_m.Text)>0,Convert.ToDecimal(Me.txtEnero_m.Text)*1,Convert.ToDecimal(Me.txtEnero_m.Text))
                                                                                dgvDistribucionCn.Item(24, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtFebrero_m.Text)>0,Convert.ToDecimal(Me.txtFebrero_m.Text)*1,Convert.ToDecimal(Me.txtFebrero_m.Text))
                                                                                dgvDistribucionCn.Item(25, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtMarzo_m.Text)>0,Convert.ToDecimal(Me.txtMarzo_m.Text)*1,Convert.ToDecimal(Me.txtMarzo_m.Text))
                                                                                dgvDistribucionCn.Item(26, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtAbril_m.Text)>0,Convert.ToDecimal(Me.txtAbril_m.Text)*1,Convert.ToDecimal(Me.txtAbril_m.Text))
                                                                                dgvDistribucionCn.Item(27, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtMayo_m.Text)>0,Convert.ToDecimal(Me.txtMayo_m.Text)*1,Convert.ToDecimal(Me.txtMayo_m.Text))
                                                                                dgvDistribucionCn.Item(28, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtJunio_m.Text)>0,Convert.ToDecimal(Me.txtJunio_m.Text)*1,Convert.ToDecimal(Me.txtJunio_m.Text))
                                                                                dgvDistribucionCn.Item(29, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtJulio_m.Text)>0,Convert.ToDecimal(Me.txtJulio_m.Text)*1,Convert.ToDecimal(Me.txtJulio_m.Text))
                                                                                dgvDistribucionCn.Item(30, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtAgosto_m.Text)>0,Convert.ToDecimal(Me.txtAgosto_m.Text)*1,Convert.ToDecimal(Me.txtAgosto_m.Text))
                                                                                dgvDistribucionCn.Item(31, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtSeptiembre_m.Text)>0,Convert.ToDecimal(Me.txtSeptiembre_m.Text)*1,Convert.ToDecimal(Me.txtSeptiembre_m.Text))
                                                                                dgvDistribucionCn.Item(32, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtOctubre_m.Text)>0,Convert.ToDecimal(Me.txtOctubre_m.Text)*1,Convert.ToDecimal(Me.txtOctubre_m.Text))
                                                                                dgvDistribucionCn.Item(33, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtNoviembre_m.Text)>0,Convert.ToDecimal(Me.txtNoviembre_m.Text)*1,Convert.ToDecimal(Me.txtNoviembre_m.Text))
                                                                                dgvDistribucionCn.Item(34, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Convert.ToDecimal(Me.txtDiciembre_m.Text)>0,Convert.ToDecimal(Me.txtDiciembre_m.Text)*1,Convert.ToDecimal(Me.txtDiciembre_m.Text))
                                                                            End If
                                                                            
                                                                            dgvDistribucionCn.Item(35, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                                            dgvDistribucionCn.Item(36, dgvDistribucionCn.Rows.Count - 1).Value = IIf(rbBienes.Checked, "01", "02")
                                                                            dgvDistribucionCn.Item(38, dgvDistribucionCn.Rows.Count - 1).Value = Format(Math.Round(IIf (chkRebajar.Checked,(Convert.ToDouble(Me.txtCantidad_m.Text) * Convert.ToDouble(txtCosto.Text))*-1,Convert.ToDouble(Me.txtCantidad_m.Text) * Convert.ToDouble(txtCosto.Text)), 2, MidpointRounding.AwayFromZero), "###,###,#.00")
                                                                            dgvDistribucionCn.Item(41, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Me.txtDB.Text.Trim() = String.Empty, "0", Me.txtDB.Text)
                                                                            Me.txtEnero.Text = "0.00"
                                                                            Me.txtFebrero.Text = "0.00"
                                                                            Me.txtMarzo.Text = "0.00"
                                                                            Me.txtAbril.Text = "0.00"
                                                                            Me.txtMayo.Text = "0.00"
                                                                            Me.txtJunio.Text = "0.00"
                                                                            Me.txtJulio.Text = "0.00"
                                                                            Me.txtAgosto.Text = "0.00"
                                                                            Me.txtSeptiembre.Text = "0.00"
                                                                            Me.txtOctubre.Text = "0.00"
                                                                            Me.txtNoviembre.Text = "0.00"
                                                                            Me.txtDiciembre.Text = "0.00"

                                                                            Me.txtEnero_m.Text = "0.00"
                                                                            Me.txtFebrero_m.Text = "0.00"
                                                                            Me.txtMarzo_m.Text = "0.00"
                                                                            Me.txtAbril_m.Text = "0.00"
                                                                            Me.txtMayo_m.Text = "0.00"
                                                                            Me.txtJunio_m.Text = "0.00"
                                                                            Me.txtJulio_m.Text = "0.00"
                                                                            Me.txtAgosto_m.Text = "0.00"
                                                                            Me.txtSeptiembre_m.Text = "0.00"
                                                                            Me.txtOctubre_m.Text = "0.00"
                                                                            Me.txtNoviembre_m.Text = "0.00"
                                                                            Me.txtDiciembre_m.Text = "0.00"

                                                                            Me.cbUnidadOrganica.Enabled = False
                                                                            Me.txtMonto.Text = "0.00"
                                                                            Me.txtCantidad_m.Text = "0.00"
                                                                            Me.chkRebajar.Checked = False
                                                                            Me.btnBuscarItems.Focus()
                                                                            Me.cbMotivo.Enabled = False

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
                                                                            Variable_Codigo_Catalogo = ""
                                                                            Variable_Codigo_Grupo = ""
                                                                            Variable_Codigo_Clase = ""
                                                                            Variable_Codigo_Familia = ""
                                                                            Variable_Codigo_Item = ""
                                                                            Me.cbUnidadOrganica.Enabled = False
                                                                            Me.txtDB.Text = ""
                                                                            Me.btnBuscarItems.Focus()
                                                                        case "003"
                                                                            Me.dgvDistribucionCn.Rows.Add()
                                                                            dgvDistribucionCn.Item(0, dgvDistribucionCn.Rows.Count - 1).Value = My.Settings.Año_Ejecucion
                                                                            dgvDistribucionCn.Item(1, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString
                                                                            dgvDistribucionCn.Item(2, dgvDistribucionCn.Rows.Count - 1).Value = Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString
                                                                            dgvDistribucionCn.Item(3, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim
                                                                            dgvDistribucionCn.Item(4, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtGenerica.Text.Trim
                                                                            dgvDistribucionCn.Item(5, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSubGenerica.Text.Trim
                                                                            dgvDistribucionCn.Item(6, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSubGenericaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(7, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEspecifica.Text.Trim
                                                                            dgvDistribucionCn.Item(8, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEspecificaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(9, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtTipoTransaccion.Text.Trim.Trim & "." & Me.txtGenerica.Text.Trim & "." & Me.txtSubGenerica.Text.Trim & "." & Me.txtSubGenericaDetalle.Text.Trim & "." & Me.txtEspecifica.Text.Trim & "." & Me.txtEspecificaDetalle.Text.Trim
                                                                            dgvDistribucionCn.Item(10, dgvDistribucionCn.Rows.Count - 1).Value = Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString
                                                                            dgvDistribucionCn.Item(11, dgvDistribucionCn.Rows.Count - 1).Value = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
                                                                            dgvDistribucionCn.Item(12, dgvDistribucionCn.Rows.Count - 1).Value = Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                                            dgvDistribucionCn.Item(13, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoGrupo.Text.Trim
                                                                            dgvDistribucionCn.Item(14, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoClase.Text.Trim
                                                                            dgvDistribucionCn.Item(15, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoFamilia.Text.Trim
                                                                            dgvDistribucionCn.Item(16, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoItem.Text.Trim
                                                                            dgvDistribucionCn.Item(17, dgvDistribucionCn.Rows.Count - 1).Value = IIf(rbBienes.Checked, "B.", "S.") & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                                            dgvDistribucionCn.Item(18, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtItem.Text
                                                                            dgvDistribucionCn.Item(19, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                                            dgvDistribucionCn.Item(20, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtUnidadMedida.Text

                                                                            dgvDistribucionCn.Item(21, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                                            dgvDistribucionCn.Item(22, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00000")

                                                                            dgvDistribucionCn.Item(23, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaEnero.Checked,Convert.ToDecimal(Me.txtEnero_m.Text)*-1,Convert.ToDecimal(Me.txtEnero_m.Text)*1)  
                                                                            dgvDistribucionCn.Item(24, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaFebrero.Checked,Convert.ToDecimal(Me.txtFebrero_m.Text)*-1,Convert.ToDecimal(Me.txtFebrero_m.Text)*1)
                                                                            dgvDistribucionCn.Item(25, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaMarzo.Checked,Convert.ToDecimal(Me.txtMarzo_m.Text)*-1,Convert.ToDecimal(Me.txtMarzo_m.Text)*1)
                                                                            dgvDistribucionCn.Item(26, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaAbril.Checked,Convert.ToDecimal(Me.txtAbril_m.Text)*-1,Convert.ToDecimal(Me.txtAbril_m.Text)*1)
                                                                            dgvDistribucionCn.Item(27, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaMayo.Checked,Convert.ToDecimal(Me.txtMayo_m.Text)*-1,Convert.ToDecimal(Me.txtMayo_m.Text)*1)
                                                                            dgvDistribucionCn.Item(28, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaJunio.Checked,Convert.ToDecimal(Me.txtJunio_m.Text)*-1,Convert.ToDecimal(Me.txtJunio_m.Text)*1)
                                                                            dgvDistribucionCn.Item(29, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaJulio.Checked,Convert.ToDecimal(Me.txtJulio_m.Text)*-1,Convert.ToDecimal(Me.txtJulio_m.Text)*1)
                                                                            dgvDistribucionCn.Item(30, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaAgosto.Checked,Convert.ToDecimal(Me.txtAgosto_m.Text)*-1,Convert.ToDecimal(Me.txtAgosto_m.Text)*1)
                                                                            dgvDistribucionCn.Item(31, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaSeptiembre.Checked,Convert.ToDecimal(Me.txtSeptiembre_m.Text)*-1,Convert.ToDecimal(Me.txtSeptiembre_m.Text)*1)
                                                                            dgvDistribucionCn.Item(32, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaOctubre.Checked,Convert.ToDecimal(Me.txtOctubre_m.Text)*-1,Convert.ToDecimal(Me.txtOctubre_m.Text)*1)
                                                                            dgvDistribucionCn.Item(33, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaNoviembre.Checked,Convert.ToDecimal(Me.txtNoviembre_m.Text)*-1,Convert.ToDecimal(Me.txtNoviembre_m.Text)*1)
                                                                            dgvDistribucionCn.Item(34, dgvDistribucionCn.Rows.Count - 1).Value = IIf(chkRebajaDiciembre.Checked,Convert.ToDecimal(Me.txtDiciembre_m.Text)*-1,Convert.ToDecimal(Me.txtDiciembre_m.Text)*1)
                                                                            dgvDistribucionCn.Item(35, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                                            dgvDistribucionCn.Item(36, dgvDistribucionCn.Rows.Count - 1).Value = IIf(rbBienes.Checked, "01", "02")
                                                                            dgvDistribucionCn.Item(38, dgvDistribucionCn.Rows.Count - 1).Value = Format(Math.Round(Convert.ToDouble(Me.txtCantidad_m.Text) * Convert.ToDouble(txtCosto.Text), 2, MidpointRounding.AwayFromZero), "###,###,#.00")
                                                                            dgvDistribucionCn.Item(41, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Me.txtDB.Text.Trim() = String.Empty, "0", Me.txtDB.Text)
                                                                            Me.txtEnero.Text = "0.00"
                                                                            Me.txtFebrero.Text = "0.00"
                                                                            Me.txtMarzo.Text = "0.00"
                                                                            Me.txtAbril.Text = "0.00"
                                                                            Me.txtMayo.Text = "0.00"
                                                                            Me.txtJunio.Text = "0.00"
                                                                            Me.txtJulio.Text = "0.00"
                                                                            Me.txtAgosto.Text = "0.00"
                                                                            Me.txtSeptiembre.Text = "0.00"
                                                                            Me.txtOctubre.Text = "0.00"
                                                                            Me.txtNoviembre.Text = "0.00"
                                                                            Me.txtDiciembre.Text = "0.00"

                                                                            Me.txtEnero_m.Text = "0.00"
                                                                            Me.txtFebrero_m.Text = "0.00"
                                                                            Me.txtMarzo_m.Text = "0.00"
                                                                            Me.txtAbril_m.Text = "0.00"
                                                                            Me.txtMayo_m.Text = "0.00"
                                                                            Me.txtJunio_m.Text = "0.00"
                                                                            Me.txtJulio_m.Text = "0.00"
                                                                            Me.txtAgosto_m.Text = "0.00"
                                                                            Me.txtSeptiembre_m.Text = "0.00"
                                                                            Me.txtOctubre_m.Text = "0.00"
                                                                            Me.txtNoviembre_m.Text = "0.00"
                                                                            Me.txtDiciembre_m.Text = "0.00"

                                                                            Me.cbUnidadOrganica.Enabled = False
                                                                            Me.txtMonto.Text = "0.00"
                                                                            Me.txtCantidad_m.Text = "0.00"
                                                                            Me.chkRebajar.Checked = False
                                                                            Me.btnBuscarItems.Focus()
                                                                            Me.cbMotivo.Enabled = False

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
                                                                            Variable_Codigo_Catalogo = ""
                                                                            Variable_Codigo_Grupo = ""
                                                                            Variable_Codigo_Clase = ""
                                                                            Variable_Codigo_Familia = ""
                                                                            Variable_Codigo_Item = ""
                                                                            Me.cbUnidadOrganica.Enabled = False
                                                                            Me.txtDB.Text = ""
                                                                            Me.btnBuscarItems.Focus()
                                                                    End Select
                                                                    Me.txtTotal.Text = Format(Me.Total, "###,###,#.00")
                                                                    Me.txtTotal2.Text = Format(Me.Total2, "###,###,#.00")
                                                                    Me.txtDiferencia.Text = Format(Me.Total() + Me.Total2(), "###,###,#.00")
                                                                    Call desactivaRebajaMeses(False)

                                                                Else
                                                                        MessageBox.Show("Hay Acciones Modificatorias que estan pendientes de ser APROBADAS y que contienen el mismo clasificador o mismo Items en el listado que se intenta ingresar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                                        btnAgregar.Focus()
                                                                End If
                                                            Else
                                                                MessageBox.Show($"Ya exite en el Detalle el Item del Catalogo con la misma FF,RB y Unidad Orgánica.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                                Me.cbMotivo.Focus()
                                                            End If
                                                            
                                                        Else
                                                            MessageBox.Show(String.Format("No hay saldo suficiente para agregar este {0}", IIf(rbBienes.Checked, "Bien", "Servicio")), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                        End If
                                                    Else
                                                        MessageBox.Show("La Cantidad debe ser Mayor a Cero (0).", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                                        Me.txtCantidad.Focus()
                                                    End If
                                                Else
                                                    MessageBox.Show("Debes Ingresar el Costo Referencial.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                                    Me.txtCosto.Focus()
                                                End If
                                            Else
                                                MessageBox.Show("Debes Ingresar la Cantidad de Items a solicitar, al menos en un mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                                Me.txtEnero_m.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes seleccionar el motivo de gestión de la Acción Modificatoria", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        End If
                                    Else
                                        MessageBox.Show("Debes seleccionar un Item del Catalogo para el detalle del requerimiento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                        Me.btnBuscarItems.Focus()
                                    End If
                                Else
                                    MessageBox.Show("El Clasificador ingresado no es correcto.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
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
    Private sub desactivaRebajaMeses(valor As Boolean)
        chkRebajaEnero.Checked = valor
        chkRebajaFebrero.Checked = valor
        chkRebajaMarzo.Checked = valor
        chkRebajaAbril.Checked = valor
        chkRebajaMayo.Checked = valor
        chkRebajaJunio.Checked = valor
        chkRebajaJulio.Checked = valor
        chkRebajaAgosto.Checked = valor
        chkRebajaSeptiembre.Checked = valor
        chkRebajaOctubre.Checked = valor
        chkRebajaNoviembre.Checked = valor
        chkRebajaDiciembre.Checked = valor
    End sub
    Private Function Total() As Double
        Total = 0

        If Me.dgvDistribucionCn.RowCount > 0 Then
            For Recorrido As Integer = 0 To dgvDistribucionCn.RowCount - 1
                If Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells("Total").Value) < 0 Then
                    Total = Total + Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells("Total").Value)
                End If
            Next
        Else
            Total = 0
        End If
        Return Total
    End Function
    Private Function Total2() As Double
        Total2 = 0

        If Me.dgvDistribucionCn.RowCount > 0 Then
            For Recorrido As Integer = 0 To dgvDistribucionCn.RowCount - 1
                If Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells("Total").Value) > 0 Then
                    Total2 = Total2 + Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells("Total").Value)
                End If
            Next
        Else
            Total2 = 0
        End If
        Return Total2
    End Function
    Private Function VerificaModificaciones() As Boolean
        'Aqui se verifica si el Item es un nuevo Item que no se considero en CN o lo otro es que item si existe en CN pero ya se 
        'solicito todo con los requerimientos y todo quedo en cero.
        Select Case Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString
            Case "001"
                If (txtEnero.Text = txtEnero_m.Text And txtFebrero.Text = txtFebrero_m.Text And txtMarzo.Text = txtMarzo_m.Text And txtAbril.Text = txtAbril_m.Text And txtMayo.Text = txtMayo_m.Text And txtJunio.Text = txtJunio_m.Text And txtJulio.Text = txtJulio_m.Text And txtAgosto.Text = txtAgosto_m.Text And txtSeptiembre.Text = txtSeptiembre_m.Text And txtOctubre.Text = txtOctubre_m.Text And txtNoviembre.Text = txtNoviembre_m.Text And txtDiciembre.Text = txtDiciembre_m.Text) Then
                    MessageBox.Show("Para incluir o excluir debe realizar al menos algun cambio entre lo asignado en el CN y lo [Modificado]", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    Return True
                End If
                If (txtEnero_m.Text = "0.00" And txtFebrero_m.Text = "0.00" And txtMarzo_m.Text = "0.00" And txtAbril_m.Text = "0.00" And txtMayo_m.Text = "0.00" And txtJunio_m.Text = "0.00" And txtJulio_m.Text = "0.00" And txtAgosto_m.Text = "0.00" And txtSeptiembre_m.Text = "0.00" And txtOctubre_m.Text = "0.00" And txtNoviembre_m.Text = "0.00" And txtDiciembre_m.Text = "0.00") Then
                    MessageBox.Show("Para incluir debe realizar al menos algun cambio entre lo asignado en el CN y lo [Modificado]", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    Return True
                End If
            Case "002"
                If chkRebajar.Checked
                    if (Convert.ToDecimal(txtEnero.Text) < Convert.ToDecimal(txtEnero_m.Text))
                        MessageBox.Show("Enero modificado no puede ser mayor a Enero asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtEnero_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtFebrero.Text) < Convert.ToDecimal(txtFebrero_m.Text))
                        MessageBox.Show("Febrero modificado no puede ser mayor a Febrero asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtFebrero_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtMarzo.Text) < Convert.ToDecimal(txtMarzo_m.Text))
                        MessageBox.Show("Marzo modificado no puede ser mayor a Marzo asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtMarzo_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtAbril.Text) < Convert.ToDecimal(txtAbril_m.Text))
                        MessageBox.Show("Abril modificado no puede ser mayor a Abril asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtAbril_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtMayo.Text) < Convert.ToDecimal(txtMayo_m.Text))
                        MessageBox.Show("Mayo modificado no puede ser mayor a Mayo asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtMayo_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtJunio.Text) < Convert.ToDecimal(txtJunio_m.Text))
                        MessageBox.Show("Junio modificado no puede ser mayor a Junio asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtJunio_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtJulio.Text) < Convert.ToDecimal(txtJulio_m.Text))
                        MessageBox.Show("Julio modificado no puede ser mayor a Julio asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtJulio_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtAgosto.Text) < Convert.ToDecimal(txtAgosto_m.Text))
                        MessageBox.Show("Agosto modificado no puede ser mayor a Agosto asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtAgosto_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtSeptiembre.Text) < Convert.ToDecimal(txtSeptiembre_m.Text))
                        MessageBox.Show("Septiembre modificado no puede ser mayor a Septiembre asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtSeptiembre_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtOctubre.Text) < Convert.ToDecimal(txtOctubre_m.Text))
                        MessageBox.Show("Octubre modificado no puede ser mayor a Octubre asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtOctubre_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtNoviembre.Text) < Convert.ToDecimal(txtNoviembre_m.Text))
                        MessageBox.Show("Noviembre modificado no puede ser mayor a Noviembre asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtNoviembre_m.Focus()
                        Return True
                    End If
                    if (Convert.ToDecimal(txtDiciembre.Text) < Convert.ToDecimal(txtDiciembre_m.Text))
                        MessageBox.Show("Diciembre modificado no puede ser mayor a Diciembre asignado en el CN.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        txtDiciembre_m.Focus()
                        Return True
                    End If
                End If
                Case "003"
                If Math.Abs(Convert.ToDecimal(txtCantidad_m.Text))>0
                    MessageBox.Show("Para este motivo la cantidad total o el monto modificado debe ser Cero (0.00)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Return True
                End If
        End Select
        Return False
    End Function
    Private Sub Limpiar_Busqueda_items()
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

        Me.btnBuscarItems.Focus()
    End Sub

    Private Sub dgvDistribucionCn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDistribucionCn.CellContentClick
        If dgvDistribucionCn.Columns(e.ColumnIndex).Name = "btnEliminar" Then
            Me.dgvDistribucionCn.Rows.Remove(Me.dgvDistribucionCn.CurrentRow)
            If Me.dgvDistribucionCn.Rows.Count = 0 Then
                Me.cbUnidadOrganica.Enabled = True
            Else
                Me.cbUnidadOrganica.Enabled = False
            End If
        End If
        If dgvDistribucionCn.Columns(e.ColumnIndex).Name = "btnEditar" Then
            If txtDB.Text.Trim() <> String.Empty Then
                MessageBox.Show("Al parecer esta editando un Item sobre otro Item, guarde sus cambios para continuar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            rbBienes.Checked = (Me.dgvDistribucionCn.CurrentRow.Cells(36).Value = "01")
            rbServicios.Checked = (Me.dgvDistribucionCn.CurrentRow.Cells(36).Value = "02")

            Datos.Llenar_Componentes(Me.dgvDistribucionCn.CurrentRow.Cells(3).Value, Me.dgvDistribucionCn.CurrentRow.Cells(4).Value, Me.dgvDistribucionCn.CurrentRow.Cells(5).Value, Me.dgvDistribucionCn.CurrentRow.Cells(6).Value, Me.dgvDistribucionCn.CurrentRow.Cells(7).Value, Me.dgvDistribucionCn.CurrentRow.Cells(8).Value, Me.dgvDistribucionCn.CurrentRow.Cells(1).Value, Me.dgvDistribucionCn.CurrentRow.Cells(2).Value, Me.dgvDistribucionCn.CurrentRow.Cells(11).Value, Me.dgvDistribucionCn.CurrentRow.Cells(10).Value, Me.dgvDistribucionCn.CurrentRow.Cells(12).Value)
            Me.cbFF.Text = Variable_FF
            Me.cbRubro.Text = Variable_Rubro

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

            Datos.Mostrar_Data_Item_Catalogo(Me.dgvDistribucionCn.CurrentRow.Cells(13).Value, Me.dgvDistribucionCn.CurrentRow.Cells(14).Value, Me.dgvDistribucionCn.CurrentRow.Cells(15).Value, Me.dgvDistribucionCn.CurrentRow.Cells(16).Value, Me.dgvDistribucionCn.CurrentRow.Cells(36).Value, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)

            If Me.dgvDistribucionCn.Rows.Count = 0 Then Me.cbUnidadOrganica.Enabled = True Else Me.cbUnidadOrganica.Enabled = False
            Select Case Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString
                Case "001"
                    Me.txtEnero_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(23).Value
                    Me.txtFebrero_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(24).Value
                    Me.txtMarzo_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(25).Value
                    Me.txtAbril_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(26).Value
                    Me.txtMayo_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(27).Value
                    Me.txtJunio_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(28).Value
                    Me.txtJulio_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(29).Value
                    Me.txtAgosto_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(30).Value
                    Me.txtSeptiembre_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(31).Value
                    Me.txtOctubre_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(32).Value
                    Me.txtNoviembre_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(33).Value
                    Me.txtDiciembre_m.Text = Me.dgvDistribucionCn.CurrentRow.Cells(34).Value
                Case "002"
                    Me.txtEnero_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)*-1, "###,###,#.00"))
                    Me.txtFebrero_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)*-1, "###,###,#.00"))
                    Me.txtMarzo_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)*-1, "###,###,#.00"))
                    Me.txtAbril_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)*-1, "###,###,#.00"))
                    Me.txtMayo_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)*-1, "###,###,#.00"))
                    Me.txtJunio_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)*-1, "###,###,#.00"))
                    Me.txtJulio_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)*-1, "###,###,#.00"))
                    Me.txtAgosto_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)*-1, "###,###,#.00"))
                    Me.txtSeptiembre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)*-1, "###,###,#.00"))
                    Me.txtOctubre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)*-1, "###,###,#.00"))
                    Me.txtNoviembre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)*-1, "###,###,#.00"))
                    Me.txtDiciembre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)*-1, "###,###,#.00"))
                    For i As Integer = 23 To 34
                        if Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(i).Value)>0 Or Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(i).Value)<0
                            chkRebajar.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(i).Value)>0
                            exit For 
                        End If
                    Next
                Case "003"
                    Me.txtEnero_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)*-1, "###,###,#.00"))
                    Me.txtFebrero_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)*-1, "###,###,#.00"))
                    Me.txtMarzo_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)*-1, "###,###,#.00"))
                    Me.txtAbril_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)*-1, "###,###,#.00"))
                    Me.txtMayo_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)*-1, "###,###,#.00"))
                    Me.txtJunio_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)*-1, "###,###,#.00"))
                    Me.txtJulio_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)*-1, "###,###,#.00"))
                    Me.txtAgosto_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)*-1, "###,###,#.00"))
                    Me.txtSeptiembre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)*-1, "###,###,#.00"))
                    Me.txtOctubre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)*-1, "###,###,#.00"))
                    Me.txtNoviembre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)*-1, "###,###,#.00"))
                    Me.txtDiciembre_m.Text = IIf(Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)>0,Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value), "###,###,#.00"),Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)*-1, "###,###,#.00"))

                    chkRebajaEnero.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(23).Value)>=0
                    chkRebajaFebrero.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(24).Value)>=0
                    chkRebajaMarzo.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(25).Value)>=0
                    chkRebajaAbril.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(26).Value)>=0
                    chkRebajaMayo.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(27).Value)>=0
                    chkRebajaJunio.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(28).Value)>=0
                    chkRebajaJulio.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(29).Value)>=0
                    chkRebajaAgosto.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(30).Value)>=0
                    chkRebajaSeptiembre.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(31).Value)>=0
                    chkRebajaOctubre.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(32).Value)>=0
                    chkRebajaNoviembre.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(33).Value)>=0
                    chkRebajaDiciembre.Checked = Not Convert.ToDecimal(Me.dgvDistribucionCn.CurrentRow.Cells(34).Value)>=0
            End Select
            Me.txtDB.Text = Me.dgvDistribucionCn.CurrentRow.Cells(41).Value
            SumaTotalMeses()
            Me.txtCosto.Text = Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(22).Value), "###,###,#.00000")

            Me.dgvDistribucionCn.Rows.Remove(Me.dgvDistribucionCn.CurrentRow)
            Call Me.Evaluar_Saldos()
            SumaTotalMeses_modificado()
            'txtSaldo.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtCantidad_m.Text) * CDbl(txtCosto.Text), "###,###,#.00")
            'txtSaldo.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtCantidad_m.Text) * CDbl(txtCosto.Text), "###,###,#.00")
            
            If txtCodigoGrupo.Text.Trim().Length > 0 And txtCodigoClase.Text.Trim.Length > 0 And txtCodigoFamilia.Text.Trim.Length > 0 And txtCodigoItem.Text.Trim.Length > 0 Then
            Datos.Mostrar_Data_Item_Catalogo_Cuadro_Necesidades(txtCodigoGrupo.Text, txtCodigoClase.Text, txtCodigoFamilia.Text,
                                                                txtCodigoItem.Text, IIf(rbBienes.Checked, 1, 2),
                                             Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.txtCodigoGrupo,
                                             Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia,
                                             Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida,
                                             Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica,
                                             Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle,
                                             Me.txtEnero, Me.txtFebrero, Me.txtMarzo, Me.txtAbril, Me.txtMarzo, Me.txtJunio, Me.txtJulio,
                                             Me.txtAgosto, Me.txtSeptiembre, Me.txtOctubre, Me.txtNoviembre, Me.txtDiciembre,
                                             Me.txtEnero_m, Me.txtFebrero_m, Me.txtMarzo_m, Me.txtAbril_m, Me.txtMarzo_m, Me.txtJunio_m,
                                             Me.txtJulio_m, Me.txtAgosto_m, Me.txtSeptiembre_m, Me.txtOctubre_m, Me.txtNoviembre_m,
                                             Me.txtDiciembre_m, True)
            End If
            Me.txtEnero_m.Focus()
        End If
        Me.txtTotal.Text = Format(Me.Total, "###,###,#.00")
        Me.txtTotal2.Text = Format(Me.Total2, "###,###,#.00")
        If Me.dgvDistribucionCn.Rows.Count = 0 Then Me.cbMotivo.Enabled = True
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
            Me.Close()
        Catch ex As Exception
        Finally
            Me.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Editar = False Then
            If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
                If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                    If Me.cbActividad.Text.Trim.Length > 0 Then
                        If Me.dgvDistribucionCn.RowCount > 0 Then
                            If Me.cbMotivo.Text.Trim.Length > 0 Then
                                If Datos.Verificar_Items_No_Autorizados_AM(Me.dgvDistribucionCn,"") = True Then
                                    'If Datos.Verifica_Multiple_Apertura(My.Settings.Usuario,Net.Dns.GetHostName,Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica"),"frmRegistro_Acciones_Modificatorias") Then
                                    '    MessageBox.Show("Hay otro formulario de Acciones modificatorias que esta realizando modificaciones en el CN, cierre el otro formulario para continuar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                    '    Me.Close()
                                    'End If
                                    Select Case Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString
                                        Case "001"
                                            If Me.txtJustificacion.Text.Trim.Length > 0 Then
                                                Dim Numero As String = Datos.Generar_Numero_AM(My.Settings.Año_Ejecucion)
                                                Datos.Nueva_Accion_Modificatoria(My.Settings.Año_Ejecucion, Numero, Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString, Me.txtJustificacion.Text.Trim.Trim, Today.Date, My.Settings.Usuario, "01",Unidad_Organica.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Unidad_Organica").ToString)
                                                
                                                For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                                    Datos.Nuevo_Detalle_AM(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Numero, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                                                Next
                                                'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
                                                Me.Close()
                                            Else
                                                MessageBox.Show("Debes ingresar la Justificación para la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.txtJustificacion.Focus()
                                            End If
                                        Case "002"
                                            If Me.txtJustificacion.Text.Trim.Length > 0 Then
                                                If Math.Abs(Convert.ToDecimal(Me.txtTotal.Text.Trim)) = Math.Abs(Convert.ToDecimal(Me.txtTotal2.Text.Trim)) Then
                                                    Dim Numero As String = Datos.Generar_Numero_AM(My.Settings.Año_Ejecucion)
                                                    Datos.Nueva_Accion_Modificatoria(My.Settings.Año_Ejecucion, Numero, Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString, Me.txtJustificacion.Text.Trim.Trim, Today.Date, My.Settings.Usuario, "01",Unidad_Organica.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Unidad_Organica").ToString)

                                                    For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                                        Datos.Nuevo_Detalle_AM(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Numero, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                                                    Next
                                                    'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
                                                    Me.Close()
                                                Else
                                                    MessageBox.Show("El Monto acumulado de las Rebajas debe cubirir el Monto de las Habilitaciones.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                End If
                                            Else
                                                MessageBox.Show("Debes ingresar la Justificación para la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.txtJustificacion.Focus()
                                            End If
                                        Case "003"
                                            If Me.txtJustificacion.Text.Trim.Length > 0 Then
                                                If (Math.Abs(Convert.ToDecimal(Me.txtCantidad_m.Text.Trim)) = 0) Then
                                                    Dim Numero As String = Datos.Generar_Numero_AM(My.Settings.Año_Ejecucion)
                                                    Datos.Nueva_Accion_Modificatoria(My.Settings.Año_Ejecucion, Numero, Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString, Me.txtJustificacion.Text.Trim.Trim, Today.Date, My.Settings.Usuario, "01",Unidad_Organica.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Unidad_Organica").ToString)

                                                    For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                                        Datos.Nuevo_Detalle_AM(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Numero, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                                                    Next
                                                    'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
                                                    Me.Close()
                                                Else
                                                    MessageBox.Show("El Monto acumulado de las Rebajas en los Items debe cubrir el Monto de las Habilitaciones.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                End If
                                            Else
                                                MessageBox.Show("Debes ingresar la Justificación para la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.txtJustificacion.Focus()
                                            End If
                                    End Select
                                Else
                                    MessageBox.Show("Hay Acciones Modificatorias que estan pendientes de ser APROBADAS y que contienen el mismo clasificador o mismo Items en el listado que se intenta ingresar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.btnGuardar.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar el motivo de gestión de la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.cbMotivo.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes ingresar el detalle de la Acción modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.btnBuscarItems.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar la Actividad a Registrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.cbActividad.Focus()
                    End If
                Else
                    MessageBox.Show("Debes seleccionar la Secuencia Funcional o Meta Presupuestal a Registrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.cbSecuenciaFuncional.Focus()
                End If
            Else
                MessageBox.Show("Debes seleccionar la Unidad Orgánica a Registrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.cbUnidadOrganica.Focus()
            End If
        Else
            If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
                If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                    If Me.cbActividad.Text.Trim.Length > 0 Then
                        If Me.dgvDistribucionCn.RowCount > 0 Then
                            If Me.cbMotivo.Text.Trim.Length > 0 Then
                                If Datos.Verificar_Items_No_Autorizados_AM(Me.dgvDistribucionCn,Variable_Numero_Accion_Modificatoria) = True Then
                                    'If Datos.Verifica_Multiple_Apertura(My.Settings.Usuario,Net.Dns.GetHostName,Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica"),"frmRegistro_Acciones_Modificatorias") Then
                                    '    MessageBox.Show("Hay otro formulario de Acciones modificatorias que esta realizando modificaciones en el CN, cierre el otro formulario para continuar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                                    '    Me.Close()
                                    'End If
                                    Select Case Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString
                                        Case "001"
                                            If Me.txtJustificacion.Text.Trim.Length > 0 Then
                                                Datos.Eliminar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, False)
                                                Datos.Modificar_Acción_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString, Me.txtJustificacion.Text.Trim)
                                                
                                                For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                                    Datos.Nuevo_Detalle_AM(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Variable_Numero_Accion_Modificatoria, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                                                Next
                                                'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
                                                Me.Close()
                                            Else
                                                MessageBox.Show("Debes ingresar la Justificación para la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.txtJustificacion.Focus()
                                            End If
                                        Case "002"
                                            If Me.txtJustificacion.Text.Trim.Length > 0 Then
                                                If Math.Abs(Convert.ToDecimal(Me.txtTotal.Text.Trim)) = Math.Abs(Convert.ToDecimal(Me.txtTotal2.Text.Trim)) Then
                                                    Datos.Eliminar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, False)
                                                    Datos.Modificar_Acción_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString, Me.txtJustificacion.Text.Trim)
                                                    
                                                    For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                                        Datos.Nuevo_Detalle_AM(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Variable_Numero_Accion_Modificatoria, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                                                    Next
                                                    'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
                                                    Me.Close()
                                                Else
                                                    MessageBox.Show("El Monto acumudado de las Rebajas debe cubirir el Monto de las Habilitaciones.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                End If
                                            Else
                                                MessageBox.Show("Debes ingresar la Justificación para la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.txtJustificacion.Focus()
                                            End If
                                        Case "003"
                                            If Me.txtJustificacion.Text.Trim.Length > 0 Then
                                                If Math.Abs(Convert.ToDecimal(Me.txtTotal.Text.Trim)) = Math.Abs(Convert.ToDecimal(Me.txtTotal2.Text.Trim)) Then
                                                    Datos.Eliminar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, False)
                                                    Datos.Modificar_Acción_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString, Me.txtJustificacion.Text.Trim)
                                                    
                                                    For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                                        Datos.Nuevo_Detalle_AM(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Variable_Numero_Accion_Modificatoria, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                                                    Next
                                                    'Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
                                                    Me.Close()
                                                Else
                                                    MessageBox.Show("El Monto acumudado de las Rebajas debe cubirir el Monto de las Habilitaciones.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                End If
                                            Else
                                                MessageBox.Show("Debes ingresar la Justificación para la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.txtJustificacion.Focus()
                                            End If
                                    End Select
                                Else
                                    MessageBox.Show("Hay Acciones Modificatorias que estan pendientes de ser APROBADAS y que contienen el mismo clasificador o mismo Items en el listado que se intenta ingresar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.btnGuardar.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar el motivo de gestión de la Acción Modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.cbMotivo.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes ingresar el detalle de la Acción modificatoria.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.btnBuscarItems.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar la Actividad a Registrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.cbActividad.Focus()
                    End If
                Else
                    MessageBox.Show("Debes seleccionar la Secuencia Funcional o Meta Presupuestal a Registrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.cbSecuenciaFuncional.Focus()
                End If
            Else
                MessageBox.Show("Debes seleccionar la Unidad Orgánica a Registrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.cbUnidadOrganica.Focus()
            End If

        End If

    End Sub

    Private Sub frmRegistro_CN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        If Editar = False Then
            Motivo = Datos.LLenar_Combo_Solo("select Codigo_Motivo_AM, Descripcion_Motivo_AM, (Codigo_Motivo_AM + ' - ' + Descripcion_Motivo_AM) as Motivo from Motivo_Acccion_Modificatoria", Me.cbMotivo, "Motivo")
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cbFF, "Fuente")
            'Tipo_Transaccion = Datos.LLenar_Combo_Solo("Select * From Lista_Tipo_Transaccion Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cb, "Transaccion")
            Call Me.Dimensionar()
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Else
            Motivo = Datos.LLenar_Combo_Solo("select Codigo_Motivo_AM, Descripcion_Motivo_AM, (Codigo_Motivo_AM + ' - ' + Descripcion_Motivo_AM) as Motivo from Motivo_Acccion_Modificatoria", Me.cbMotivo, "Motivo")
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cbFF, "Fuente")
            'Tipo_Transaccion = Datos.LLenar_Combo_Solo("Select * From Lista_Tipo_Transaccion Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cbTipoTransaccion, "Transaccion")
            Call Me.Dimensionar()
            If (Datos.Cargar_AM_Para_Modificacion(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad, Me.cbUnidadOrganica, Me.dgvDistribucionCn, Me.cbMotivo, Me.txtJustificacion) = 1) Then
                Me.Close()
            End If
            Me.cbUnidadOrganica.Enabled = False
            Call Me.Total()
            Call Me.Total2()
            Me.txtTotal.Text = Format(Me.Total, "###,###,#.00")
            Me.txtTotal2.Text = Format(Me.Total2, "###,###,#.00")
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            If Me.dgvDistribucionCn.Rows.Count > 0 Then Me.cbMotivo.Enabled = False Else Me.cbMotivo.Enabled = True
        End If

    End Sub

    Private Sub btnBuscarItems_Click(sender As Object, e As EventArgs) Handles btnBuscarItems.Click
        If cbFF.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar una Fuente de financiamiento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If cbRubro.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar un Rubro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
        Formulario.Operacion = 2
        Formulario.Tipo_Modulo = 1
        Formulario.Tipo_Catalogo = IIf(rbBienes.Checked, "01", "02")
        Formulario.ShowDialog()
        If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
            Datos.Mostrar_Data_Item_Catalogo_Cuadro_Necesidades(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia,
                                             Variable_Codigo_Item, IIf(rbBienes.Checked, 1, 2),
                                             Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.txtCodigoGrupo,
                                             Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia,
                                             Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida,
                                             Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica,
                                             Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle,
                                             Me.txtEnero, Me.txtFebrero, Me.txtMarzo, Me.txtAbril, Me.txtMayo, Me.txtJunio, Me.txtJulio,
                                             Me.txtAgosto, Me.txtSeptiembre, Me.txtOctubre, Me.txtNoviembre, Me.txtDiciembre,
                                             Me.txtEnero_m, Me.txtFebrero_m, Me.txtMarzo_m, Me.txtAbril_m, Me.txtMayo_m, Me.txtJunio_m,
                                             Me.txtJulio_m, Me.txtAgosto_m, Me.txtSeptiembre_m, Me.txtOctubre_m, Me.txtNoviembre_m,
                                             Me.txtDiciembre_m, False)
            Me.txtEnero_m.Focus()
            Call Me.Evaluar_Saldos()
            Call Me.SumaTotalMeses_modificado()
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
        End If
    End Sub

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
                                                    Me.txtSaldo.Text =
                                                        Format(Datos.Saldo_CN_AM(Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                                             Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                                             Me.txtTipoTransaccion.Text.Trim,
                                                             Me.txtGenerica.Text.Trim,
                                                             Me.txtSubGenerica.Text.Trim,
                                                             Me.txtSubGenericaDetalle.Text.Trim,
                                                             Me.txtEspecifica.Text.Trim,
                                                             Me.txtEspecificaDetalle.Text.Trim,
                                                             Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                                             Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                                             Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString) -
                                                               Total_clasificador_CN_grilla_no_db(Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
                                                                                            Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString,
                                                                                            Me.txtTipoTransaccion.Text.Trim,
                                                                                            Me.txtGenerica.Text.Trim,
                                                                                            Me.txtSubGenerica.Text.Trim,
                                                                                            Me.txtSubGenericaDetalle.Text.Trim,
                                                                                            Me.txtEspecifica.Text.Trim,
                                                                                            Me.txtEspecificaDetalle.Text.Trim,
                                                                                            Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString,
                                                                                            Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,
                                                                                            Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
                                                    txtCosto.Text = Format(Datos.Precio_ref_CN(txtCodigoGrupo.Text, txtCodigoClase.Text, txtCodigoFamilia.Text, txtCodigoItem.Text, My.Settings.Año_Ejecucion.ToString), "###,###,#.00")
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

    Function Total_clasificador_CN_grilla(ByVal Codigo_FF As Integer, ByVal Codigo_Rubro As String, ByVal Tipo_Transaccion As String, ByVal Generica As String,
                                 ByVal Sub_Generica As String, ByVal Sub_Generica_Detalle As String, ByVal Especifica As String,
                                ByVal Especifica_Detalle As String, ByVal Codigo_Secuencia_Funcional As String, ByVal Codigo_Unidad_Organica As String,
                                ByVal Codigo_Actividad As String, ByVal Año_Ejecucion As String) As Double
        Dim total_clasificador As Double
        Dim Acumulado As Double

        total_clasificador = 0

        For Each row As DataGridViewRow In dgvDistribucionCn.Rows
            If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
                row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("Meta").Value = Codigo_Secuencia_Funcional And
                row.Cells("UO").Value = Codigo_Unidad_Organica And row.Cells("CA").Value = Codigo_Actividad And row.Cells("Año").Value = Año_Ejecucion) Then


                Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

                If rbBienes.Checked Then
                    Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
                End If

                total_clasificador = total_clasificador + Acumulado

            End If
        Next
        Return total_clasificador
    End Function

    Function Total_clasificador_CN_grilla_no_db(ByVal Codigo_FF As Integer, ByVal Codigo_Rubro As String, ByVal Tipo_Transaccion As String, ByVal Generica As String,
                                 ByVal Sub_Generica As String, ByVal Sub_Generica_Detalle As String, ByVal Especifica As String,
                                ByVal Especifica_Detalle As String, ByVal Codigo_Secuencia_Funcional As String, ByVal Codigo_Unidad_Organica As String,
                                ByVal Codigo_Actividad As String, ByVal Año_Ejecucion As String) As Double
        Dim total_clasificador As Double
        Dim Acumulado As Double

        total_clasificador = 0

        For Each row As DataGridViewRow In dgvDistribucionCn.Rows

            'If Tipo_Transaccion & "." & Generica & "." & Sub_Generica = "2.3.1" Then
            '    'Davy aqui puedes consultar si la UO tiene asignado el clasificador de limpieza
            '    'Dim Da_limpieza As New OleDb.OleDbDataAdapter("select * from PIA_prevision_detalle where Año_Ejecucion='"& My.Settings.Año_Ejecucion &"' and Codigo_Unidad_Organica='" & Codigo_Unidad_Organica & "'and ltrim(rtrim(Tipo_Transaccion))+'.'+Generica+'.'+Sub_Generica+'.'+Sub_Generica_Detalle+'.'+Especifica+'.'+Especifica_Detalle='2.3.1.5.3.1' ", Cn)
            '    Dim Ds_limpieza As New Data.DataTable
            '    'Da_limpieza.Fill(Ds_limpieza)

            '    Ds_limpieza = Datos.Ejecutar_Select("select * from PIA_prevision_detalle where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' and Codigo_Unidad_Organica='" & Codigo_Unidad_Organica & "'and ltrim(rtrim(Tipo_Transaccion))+'.'+Generica+'.'+Sub_Generica+'.'+Sub_Generica_Detalle+'.'+Especifica+'.'+Especifica_Detalle='2.3.1.5.3.1' ")

            '    If Ds_limpieza.Rows.Count > 0 Then

            '        If Tipo_Transaccion & "." & Generica & "." & Sub_Generica & "." & Sub_Generica_Detalle & "." & Especifica & "." & Especifica_Detalle = "2.3.1.5.3.1" Then

            '            If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '                row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
            '                row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("UO").Value = Codigo_Unidad_Organica And
            '                row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0") Then

            '                Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

            '                If rbBienes.Checked Then
            '                    Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
            '                End If

            '                total_clasificador = total_clasificador + Acumulado
            '            End If
            '        Else
            '            If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '                row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica And
            '                row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0") Then

            '                Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

            '                If rbBienes.Checked Then
            '                    Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
            '                End If

            '                total_clasificador = total_clasificador + Acumulado
            '            End If
            '        End If
            '    Else
            '        If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '                row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica And
            '                row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0") Then

            '            Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
            '                                  Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

            '            If rbBienes.Checked Then
            '                Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
            '            End If

            '            total_clasificador = total_clasificador + Acumulado
            '        End If
            '    End If
            'ElseIf Tipo_Transaccion & "." & Generica & "." & Sub_Generica = "2.3.2" Then

            '    If Tipo_Transaccion & "." & Generica & "." & Sub_Generica & "." & Sub_Generica_Detalle & "." & Especifica & "." & Especifica_Detalle = "2.3.2.7.2.99" Then

            '        If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
            '            row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("UO").Value = Codigo_Unidad_Organica And
            '            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0") Then

            '            Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

            '            If rbBienes.Checked Then
            '                Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
            '            End If

            '            total_clasificador = total_clasificador + Acumulado
            '        End If
            '    Else
            '        If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica And
            '            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0") Then

            '            Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

            '            If rbBienes.Checked Then
            '                Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
            '            End If

            '            total_clasificador = total_clasificador + Acumulado
            '        End If
            '    End If
            'ElseIf Tipo_Transaccion & "." & Generica = "2.6" Then

            '    If (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '            row.Cells("G").Value = Generica And row.Cells("UO").Value = Codigo_Unidad_Organica And row.Cells("Año").Value = Año_Ejecucion And
            '            row.Cells("db").Value = "0") Then

            '        Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = String.Empty, "0.00", row.Cells("Ene.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = String.Empty, "0.00", row.Cells("Feb.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = String.Empty, "0.00", row.Cells("Mar.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = String.Empty, "0.00", row.Cells("Abr.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = String.Empty, "0.00", row.Cells("May.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = String.Empty, "0.00", row.Cells("Jun.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = String.Empty, "0.00", row.Cells("Jul.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = String.Empty, "0.00", row.Cells("Ago.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = String.Empty, "0.00", row.Cells("Sep.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = String.Empty, "0.00", row.Cells("Oct.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = String.Empty, "0.00", row.Cells("Nov.").Value)) +
            '                              Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = String.Empty, "0.00", row.Cells("Dic.").Value)))

            '        If rbBienes.Checked Then
            '            Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = String.Empty, "0.00", row.Cells("Costo").Value))
            '        End If

            '        total_clasificador = total_clasificador + Acumulado
            '    End If
            'End If

            if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
                row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("Meta").Value = Codigo_Secuencia_Funcional And
                row.Cells("UO").Value = Codigo_Unidad_Organica and row.Cells("CA").Value = Codigo_Actividad and row.Cells("Año").Value = Año_Ejecucion)

                Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString() = string.Empty, "0.00", row.Cells("Ene.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString() = string.Empty, "0.00", row.Cells("Feb.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString() = string.Empty, "0.00", row.Cells("Mar.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString() = string.Empty, "0.00", row.Cells("Abr.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("May.").Value.ToString() = string.Empty, "0.00", row.Cells("May.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString() = string.Empty, "0.00", row.Cells("Jun.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString() = string.Empty, "0.00", row.Cells("Jul.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString() = string.Empty, "0.00", row.Cells("Ago.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString() = string.Empty, "0.00", row.Cells("Sep.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString() = string.Empty, "0.00", row.Cells("Oct.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString() = string.Empty, "0.00", row.Cells("Nov.").Value)) +
                                      Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString() = string.Empty, "0.00", row.Cells("Dic.").Value)))

                If rbBienes.Checked
                    Acumulado = Acumulado * Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString() = string.Empty, "0.00", row.Cells("Costo").Value))
                End If

                total_clasificador = total_clasificador + Acumulado

            end If
        Next
        Return total_clasificador
    End Function

    Private Sub txtFebrero_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFebrero.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtMarzo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMarzo.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtAbril_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAbril.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtMayo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMayo.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtJunio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJunio.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtJulio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJulio.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtAgosto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAgosto.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtSeptiembre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSeptiembre.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtOctubre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOctubre.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtNoviembre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNoviembre.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub txtDiciembre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDiciembre.KeyUp
        SumaTotalMeses()
    End Sub

    Private Sub rbServicios_CheckedChanged(sender As Object, e As EventArgs) Handles rbServicios.CheckedChanged
        Limpiar_Busqueda_items()
        If rbServicios.Checked Then
            gbCatalogo.Text = "Catalogo de Servicios"
            Label26.Text = "Importe Total a Solicitar"
            Label25.Visible = False
            txtCosto.Text = "1.00"
            txtCosto.Visible = False
        Else
            gbCatalogo.Text = "Catalogo de Bienes"
            Label26.Text = "Cantidad Total a Solicitar"
            Label25.Visible = True
            txtCosto.Text = "0.00"
            txtCosto.Visible = True
        End If
    End Sub

    Private Sub rbBienes_CheckedChanged(sender As Object, e As EventArgs) Handles rbBienes.CheckedChanged
        Limpiar_Busqueda_items()

        If rbBienes.Checked Then
            gbCatalogo.Text = "Catalogo de Bienes"
            Label26.Text = "Cantidad Total a Solicitar"
            Label25.Visible = True
            txtCosto.Text = "0.00"
            txtCosto.Visible = True
        Else
            gbCatalogo.Text = "Catalogo de Servicios"
            Label26.Text = "Importe Total a Solicitar"
            Label25.Visible = False
            txtCosto.Text = "1.00"
            txtCosto.Visible = False
        End If
    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        If dgvDistribucionCn.Rows.Count > 0 Then Datos.Exportar_Lista_Cuadro_Necesidades(dgvDistribucionCn)
    End Sub

    Private Sub btnSaldos_Click(sender As Object, e As EventArgs) Handles btnSaldos.Click
        Try
            Dim Formulario As New frmSaldos_CN
            Formulario.Codigo_Unidad_Organica_ = Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString
            Formulario.Unidad_Organica_ = cbUnidadOrganica.Text
            Formulario.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Debe Guardar al menos un Item para ver los saldos disponibles.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub cbRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRubro.SelectedIndexChanged
        txtSaldo.Text = "0.00"
    End Sub

    Private Sub cbMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMotivo.SelectedIndexChanged
        Call desactivaRebajaMeses(False)
        Call SumaTotalMeses_modificado()
        If Me.cbMotivo.Items.Count > 0 Then
            If Me.cbMotivo.Text.Trim.Length > 0 Then
                Select Case Motivo.Rows(Me.cbMotivo.SelectedIndex).Item("Codigo_Motivo_AM").ToString
                    Case "001"
                        Me.chkRebajar.Enabled = False
                        Me.txtDiferencia.Enabled = False
                        Me.txtDiferencia.Visible = False
                        Me.lblDiferencia.Visible = False
                        CambiaTamanioPosicionTextBoxMeses(100,20)
                        txtEnero_m.Location = New Point(74,20)
                        txtFebrero_m.Location = New Point(240,20)
                        txtMArzo_m.Location = New Point(420,20)
                        txtAbril_m.Location = New Point(600,20)
                        txtMayo_m.Location = New Point(74,45)
                        txtJunio_m.Location = New Point(240,45)
                        txtJulio_m.Location = New Point(420,45)
                        txtAgosto_m.Location = New Point(600,45)
                        txtSeptiembre_m.Location = New Point(74,70)
                        txtOctubre_m.Location = New Point(240,70)
                        txtNoviembre_m.Location = New Point(420,70)
                        txtDiciembre_m.Location = New Point(600,70)
                        LimpiarChecksMeses(False,False)
                    Case "002"
                        Me.chkRebajar.Enabled = True
                        Me.txtDiferencia.Enabled = True
                        Me.txtDiferencia.Visible = True
                        Me.lblDiferencia.Visible = True
                        CambiaTamanioPosicionTextBoxMeses(100,20)
                        txtEnero_m.Location = New Point(74,20)
                        txtFebrero_m.Location = New Point(240,20)
                        txtMArzo_m.Location = New Point(420,20)
                        txtAbril_m.Location = New Point(600,20)
                        txtMayo_m.Location = New Point(74,45)
                        txtJunio_m.Location = New Point(240,45)
                        txtJulio_m.Location = New Point(420,45)
                        txtAgosto_m.Location = New Point(600,45)
                        txtSeptiembre_m.Location = New Point(74,70)
                        txtOctubre_m.Location = New Point(240,70)
                        txtNoviembre_m.Location = New Point(420,70)
                        txtDiciembre_m.Location = New Point(600,70)
                        LimpiarChecksMeses(False,False)
                    Case "003"
                        Me.chkRebajar.Enabled = False
                        Me.txtDiferencia.Enabled = True
                        Me.txtDiferencia.Visible = True
                        Me.lblDiferencia.Visible = True
                        CambiaTamanioPosicionTextBoxMeses(87,20)
                        txtEnero_m.Location = New Point(88,20)
                        txtFebrero_m.Location = New Point(253,20)
                        txtMArzo_m.Location = New Point(433,20)
                        txtAbril_m.Location = New Point(614,20)
                        txtMayo_m.Location = New Point(88,45)
                        txtJunio_m.Location = New Point(253,45)
                        txtJulio_m.Location = New Point(433,45)
                        txtAgosto_m.Location = New Point(614,45)
                        txtSeptiembre_m.Location = New Point(88,70)
                        txtOctubre_m.Location = New Point(253,70)
                        txtNoviembre_m.Location = New Point(433,70)
                        txtDiciembre_m.Location = New Point(614,70)
                        LimpiarChecksMeses(False,True)
                End Select
            End If
        End If
    End Sub
    Private sub CambiaTamanioPosicionTextBoxMeses(width As Integer, height As Integer)
        txtEnero_m.Size = New Size(width,height)
        txtFebrero_m.Size = New Size(width,height)
        txtMArzo_m.Size = New Size(width,height)
        txtAbril_m.Size = New Size(width,height)
        txtMayo_m.Size = New Size(width,height)
        txtJunio_m.Size = New Size(width,height)
        txtJulio_m.Size = New Size(width,height)
        txtAgosto_m.Size = New Size(width,height)
        txtSeptiembre_m.Size = New Size(width,height)
        txtOctubre_m.Size = New Size(width,height)
        txtNoviembre_m.Size = New Size(width,height)
        txtDiciembre_m.Size = New Size(width,height)
    End sub

    Private sub LimpiarChecksMeses(cheked As Boolean, visible As Boolean)
        chkRebajaEnero.Checked = cheked
        chkRebajaFebrero.Checked = cheked
        chkRebajaMarzo.Checked = cheked
        chkRebajaAbril.Checked = cheked
        chkRebajaMayo.Checked = cheked
        chkRebajaJunio.Checked = cheked
        chkRebajaJulio.Checked = cheked
        chkRebajaAgosto.Checked = cheked
        chkRebajaSeptiembre.Checked = cheked
        chkRebajaOctubre.Checked = cheked
        chkRebajaNoviembre.Checked = cheked
        chkRebajaDiciembre.Checked = cheked

        chkRebajaEnero.Visible = visible
        chkRebajaFebrero.Visible = visible
        chkRebajaMarzo.Visible = visible
        chkRebajaAbril.Visible = visible
        chkRebajaMayo.Visible = visible
        chkRebajaJunio.Visible = visible
        chkRebajaJulio.Visible = visible
        chkRebajaAgosto.Visible = visible
        chkRebajaSeptiembre.Visible = visible
        chkRebajaOctubre.Visible = visible
        chkRebajaNoviembre.Visible = visible
        chkRebajaDiciembre.Visible = visible
    End sub

    Private Sub txtEnero_m_Enter(sender As Object, e As EventArgs) Handles txtEnero_m.Enter
        txtEnero_m.SelectionStart = 0
        txtEnero_m.SelectionLength = txtEnero_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtFebrero_m_Enter(sender As Object, e As EventArgs) Handles txtFebrero_m.Enter
        txtFebrero_m.SelectionStart = 0
        txtFebrero_m.SelectionLength = txtFebrero_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtMarzo_m_Enter(sender As Object, e As EventArgs) Handles txtMarzo_m.Enter
        txtMarzo_m.SelectionStart = 0
        txtMarzo_m.SelectionLength = txtMarzo_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtAbril_m_Enter(sender As Object, e As EventArgs) Handles txtAbril_m.Enter
        txtAbril_m.SelectionStart = 0
        txtAbril_m.SelectionLength = txtAbril_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtMayo_m_Enter(sender As Object, e As EventArgs) Handles txtMayo_m.Enter
        txtMayo_m.SelectionStart = 0
        txtMayo_m.SelectionLength = txtMayo_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtJunio_m_Enter(sender As Object, e As EventArgs) Handles txtJunio_m.Enter
        txtJunio_m.SelectionStart = 0
        txtJunio_m.SelectionLength = txtJunio_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtJulio_m_Enter(sender As Object, e As EventArgs) Handles txtJulio_m.Enter
        txtJulio_m.SelectionStart = 0
        txtJulio_m.SelectionLength = txtJulio_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtAgosto_m_Enter(sender As Object, e As EventArgs) Handles txtAgosto_m.Enter
        txtAgosto_m.SelectionStart = 0
        txtAgosto_m.SelectionLength = txtAgosto_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtSeptiembre_m_Enter(sender As Object, e As EventArgs) Handles txtSeptiembre_m.Enter
        txtSeptiembre_m.SelectionStart = 0
        txtSeptiembre_m.SelectionLength = txtSeptiembre_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtOctubre_m_Enter(sender As Object, e As EventArgs) Handles txtOctubre_m.Enter
        txtOctubre_m.SelectionStart = 0
        txtOctubre_m.SelectionLength = txtOctubre_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtNoviembre_m_Enter(sender As Object, e As EventArgs) Handles txtNoviembre_m.Enter
        txtNoviembre_m.SelectionStart = 0
        txtNoviembre_m.SelectionLength = txtNoviembre_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtDiciembre_m_Enter(sender As Object, e As EventArgs) Handles txtDiciembre_m.Enter
        txtDiciembre_m.SelectionStart = 0
        txtDiciembre_m.SelectionLength = txtDiciembre_m.Text.Length
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtEnero_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnero_m.KeyPress
        If txtEnero_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtFebrero_m.Focus()
        End If
    End Sub

    Private Sub txtFebrero_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFebrero_m.KeyPress
        If txtFebrero_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtMarzo_m.Focus()
        End If
    End Sub

    Private Sub txtMarzo_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarzo_m.KeyPress
        If txtMarzo_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtAbril_m.Focus()
        End If
    End Sub

    Private Sub txtAbril_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbril_m.KeyPress
        If txtAbril_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtMayo_m.Focus()
        End If
    End Sub

    Private Sub txtMayo_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMayo_m.KeyPress
        If txtMayo_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtJunio_m.Focus()
        End If
    End Sub

    Private Sub txtJunio_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJunio_m.KeyPress
        If txtJunio_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtJulio_m.Focus()
        End If
    End Sub

    Private Sub txtJulio_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJulio_m.KeyPress
        If txtJulio_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtAgosto_m.Focus()
        End If
    End Sub

    Private Sub txtAgosto_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgosto_m.KeyPress
        If txtAgosto_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtSeptiembre_m.Focus()
        End If
    End Sub

    Private Sub txtSeptiembre_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeptiembre_m.KeyPress
        If txtSeptiembre_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtOctubre_m.Focus()
        End If
    End Sub

    Private Sub txtOctubre_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOctubre_m.KeyPress
        If txtOctubre_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtNoviembre_m.Focus()
        End If
    End Sub

    Private Sub txtNoviembre_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoviembre_m.KeyPress
        If txtNoviembre_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.txtDiciembre_m.Focus()
        End If
    End Sub

    Private Sub txtDiciembre_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiciembre_m.KeyPress
        If txtDiciembre_m.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        SumaTotalMeses_modificado()
        If Asc(e.KeyChar) = 13 Then
            Me.btnAgregar.Focus()
        End If
    End Sub

    Private Sub txtEnero_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEnero_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtFebrero_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFebrero_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtMarzo_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMarzo_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtAbril_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAbril_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtMayo_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMayo_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtJunio_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJunio_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtJulio_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJulio_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtAgosto_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAgosto_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtSeptiembre_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSeptiembre_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtOctubre_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOctubre_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtNoviembre_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNoviembre_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtDiciembre_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDiciembre_m.KeyUp
        SumaTotalMeses_modificado()
    End Sub

    Private Sub txtEnero_m_Leave(sender As Object, e As EventArgs) Handles txtEnero_m.Leave
        If Me.txtEnero_m.Text.Trim.Length > 0 Then
            Me.txtEnero_m.Text = FormatNumber(txtEnero_m.Text, 2, , , TriState.True)
        Else
            Me.txtEnero_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtFebrero_m_Leave(sender As Object, e As EventArgs) Handles txtFebrero_m.Leave
        If Me.txtFebrero_m.Text.Trim.Length > 0 Then
            Me.txtFebrero_m.Text = FormatNumber(txtFebrero_m.Text, 2, , , TriState.True)
        Else
            Me.txtFebrero_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtMarzo_m_Leave(sender As Object, e As EventArgs) Handles txtMarzo_m.Leave
        If Me.txtMarzo_m.Text.Trim.Length > 0 Then
            Me.txtMarzo_m.Text = FormatNumber(txtMarzo_m.Text, 2, , , TriState.True)
        Else
            Me.txtMarzo_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtAbril_m_Leave(sender As Object, e As EventArgs) Handles txtAbril_m.Leave
        If Me.txtAbril_m.Text.Trim.Length > 0 Then
            Me.txtAbril_m.Text = FormatNumber(txtAbril_m.Text, 2, , , TriState.True)
        Else
            Me.txtAbril_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtMayo_m_Leave(sender As Object, e As EventArgs) Handles txtMayo_m.Leave
        If Me.txtMayo_m.Text.Trim.Length > 0 Then
            Me.txtMayo_m.Text = FormatNumber(txtMayo_m.Text, 2, , , TriState.True)
        Else
            Me.txtMayo_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtJunio_m_Leave(sender As Object, e As EventArgs) Handles txtJunio_m.Leave
        If Me.txtJunio_m.Text.Trim.Length > 0 Then
            Me.txtJunio_m.Text = FormatNumber(txtJunio_m.Text, 2, , , TriState.True)
        Else
            Me.txtJunio_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtJulio_m_Leave(sender As Object, e As EventArgs) Handles txtJulio_m.Leave
        If Me.txtJulio_m.Text.Trim.Length > 0 Then
            Me.txtJulio_m.Text = FormatNumber(txtJulio_m.Text, 2, , , TriState.True)
        Else
            Me.txtJulio_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtAgosto_m_Leave(sender As Object, e As EventArgs) Handles txtAgosto_m.Leave
        If Me.txtAgosto_m.Text.Trim.Length > 0 Then
            Me.txtAgosto_m.Text = FormatNumber(txtAgosto_m.Text, 2, , , TriState.True)
        Else
            Me.txtAgosto_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtSeptiembre_m_Leave(sender As Object, e As EventArgs) Handles txtSeptiembre_m.Leave
        If Me.txtSeptiembre_m.Text.Trim.Length > 0 Then
            Me.txtSeptiembre_m.Text = FormatNumber(txtSeptiembre_m.Text, 2, , , TriState.True)
        Else
            Me.txtSeptiembre_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtOctubre_m_Leave(sender As Object, e As EventArgs) Handles txtOctubre_m.Leave
        If Me.txtOctubre_m.Text.Trim.Length > 0 Then
            Me.txtOctubre_m.Text = FormatNumber(txtOctubre_m.Text, 2, , , TriState.True)
        Else
            Me.txtOctubre_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtNoviembre_m_Leave(sender As Object, e As EventArgs) Handles txtNoviembre_m.Leave
        If Me.txtNoviembre_m.Text.Trim.Length > 0 Then
            Me.txtNoviembre_m.Text = FormatNumber(txtNoviembre_m.Text, 2, , , TriState.True)
        Else
            Me.txtNoviembre_m.Text = "0.00"
        End If
    End Sub

    Private Sub txtDiciembre_m_Leave(sender As Object, e As EventArgs) Handles txtDiciembre_m.Leave
        If Me.txtDiciembre_m.Text.Trim.Length > 0 Then
            Me.txtDiciembre_m.Text = FormatNumber(txtDiciembre_m.Text, 2, , , TriState.True)
        Else
            Me.txtDiciembre_m.Text = "0.00"
        End If
    End Sub

    Private Sub chkRebajaEnero_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaEnero.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaFebrero_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaFebrero.CheckedChanged
        Call SumaTotalMeses_modificado()
        'If chkRebajaFebrero.Checked
        '    txtFebrero_m.Text=txtFebrero.Text
        'End If
    End Sub

    Private Sub chkRebajaMarzo_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaMarzo.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaAbril_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaAbril.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaMayo_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaMayo.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaJunio_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaJunio.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaJulio_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaJulio.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaAgosto_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaAgosto.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaSeptiembre_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaSeptiembre.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaOctubre_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaOctubre.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaNoviembre_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaNoviembre.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaDiciembre_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaDiciembre.CheckedChanged
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub frmRegistro_Acciones_Modificatorias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Try
        '    Datos.Eliminar_Registro_Restriccion_Abrir_Multiples_Formularios(Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString,"frmRegistro_Acciones_Modificatorias")
        'Catch ex As Exception
        '    Finally
        '    Close
        'End Try
    End Sub

    Private Sub chkRebajaFebrero_Click(sender As Object, e As EventArgs) Handles chkRebajaFebrero.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtFebrero.Text)>0)
                txtFebrero_m.Text=txtFebrero.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtFebrero_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaEnero_Click(sender As Object, e As EventArgs) Handles chkRebajaEnero.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtEnero.Text)>0)
                txtEnero_m.Text=txtEnero.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
         Else
            txtEnero_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaMarzo_Click(sender As Object, e As EventArgs) Handles chkRebajaMarzo.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtMarzo.Text)>0)
                txtMarzo_m.Text=txtMarzo.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtMarzo_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaAbril_Click(sender As Object, e As EventArgs) Handles chkRebajaAbril.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtAbril.Text)>0)
                txtAbril_m.Text=txtAbril.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtAbril_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaMayo_Click(sender As Object, e As EventArgs) Handles chkRebajaMayo.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtMayo.Text)>0)
                txtMayo_m.Text=txtMayo.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtMayo_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaJunio_Click(sender As Object, e As EventArgs) Handles chkRebajaJunio.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtJunio.Text)>0)
                txtJunio_m.Text=txtJunio.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtJunio_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaJulio_Click(sender As Object, e As EventArgs) Handles chkRebajaJulio.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtJulio.Text)>0)
                txtJulio_m.Text=txtJulio.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtJulio_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaAgosto_Click(sender As Object, e As EventArgs) Handles chkRebajaAgosto.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtAgosto.Text)>0)
                txtAgosto_m.Text=txtAgosto.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtAgosto_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaSeptiembre_Click(sender As Object, e As EventArgs) Handles chkRebajaSeptiembre.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtSeptiembre.Text)>0)
                txtSeptiembre_m.Text=txtSeptiembre.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtSeptiembre_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaOctubre_Click(sender As Object, e As EventArgs) Handles chkRebajaOctubre.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtOctubre.Text)>0)
                txtOctubre_m.Text=txtOctubre.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtOctubre_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaNoviembre_Click(sender As Object, e As EventArgs) Handles chkRebajaNoviembre.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtNoviembre.Text)>0)
                txtNoviembre_m.Text=txtNoviembre.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtNoviembre_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

    Private Sub chkRebajaDiciembre_Click(sender As Object, e As EventArgs) Handles chkRebajaDiciembre.Click
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        
        If checkBox.Checked
            If (Convert.ToDouble(txtDiciembre.Text)>0)
                txtDiciembre_m.Text=txtDiciembre.Text
                checkBox.Checked=True
            Else
                checkBox.Checked=False
            End If
        Else
            txtDiciembre_m.Text="0.00"
        End If
        Call SumaTotalMeses_modificado()
    End Sub

End Class
