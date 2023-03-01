Public Class frmRegistro_CN
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
    Private Sub txtEnero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnero.GotFocus
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
    Private Sub txtEnero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnero.LostFocus
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
    Private Sub txtFebrero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFebrero.GotFocus
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
    Private Sub txtFebrero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFebrero.LostFocus
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
    Private Sub txtMarzo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarzo.GotFocus
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
    Private Sub txtMarzo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarzo.LostFocus
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
    Private Sub txtAbril_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbril.GotFocus
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
    Private Sub txtAbril_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbril.LostFocus
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
    Private Sub txtMayo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMayo.GotFocus
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
    Private Sub txtMayo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMayo.LostFocus
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
    Private Sub txtJunio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJunio.GotFocus
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
    Private Sub txtJunio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJunio.LostFocus
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
    Private Sub txtJulio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJulio.GotFocus
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
    Private Sub txtJulio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJulio.LostFocus
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
    Private Sub txtAgosto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgosto.GotFocus
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
    Private Sub txtAgosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgosto.LostFocus
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
    Private Sub txtSeptiembre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeptiembre.GotFocus
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
    Private Sub txtSeptiembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeptiembre.LostFocus
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
    Private Sub txtOctubre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOctubre.GotFocus
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
    Private Sub txtOctubre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOctubre.LostFocus
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
    Private Sub txtNoviembre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoviembre.GotFocus
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
    Private Sub txtNoviembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoviembre.LostFocus
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
    Private Sub txtDiciembre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiciembre.GotFocus
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
    Private Sub txtDiciembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiciembre.LostFocus
        With Me.txtDiciembre
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
            SumaTotalMeses()
        End With
    End Sub
    Private Sub SumaTotalMeses()
        txtCantidad.Text = (Convert.ToDecimal(IIf(txtEnero.Text.Trim() = String.Empty, "0.00", txtEnero.Text)) + Convert.ToDecimal(IIf(txtFebrero.Text.Trim() = String.Empty, "0.00", txtFebrero.Text)) + Convert.ToDecimal(IIf(txtMarzo.Text.Trim() = String.Empty, "0.00", txtMarzo.Text)) + Convert.ToDecimal(IIf(txtAbril.Text.Trim() = String.Empty, "0.00", txtAbril.Text)) + Convert.ToDecimal(IIf(txtMayo.Text.Trim() = String.Empty, "0.00", txtMayo.Text)) + Convert.ToDecimal(IIf(txtJunio.Text.Trim() = String.Empty, "0.00", txtJunio.Text)) + Convert.ToDecimal(IIf(txtJulio.Text.Trim() = String.Empty, "0.00", txtJulio.Text)) + Convert.ToDecimal(IIf(txtAgosto.Text.Trim() = String.Empty, "0.00", txtAgosto.Text)) + Convert.ToDecimal(IIf(txtSeptiembre.Text.Trim() = String.Empty, "0.00", txtSeptiembre.Text)) + Convert.ToDecimal(IIf(txtOctubre.Text.Trim() = String.Empty, "0.00", txtOctubre.Text) + +Convert.ToDecimal(IIf(txtNoviembre.Text.Trim() = String.Empty, "0.00", txtNoviembre.Text)) + +Convert.ToDecimal(IIf(txtDiciembre.Text.Trim() = String.Empty, "0.00", txtDiciembre.Text)))).ToString("###,###,#.00")
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
                                        If Convert.ToDouble(Me.txtCantidad.Text.Trim()) > 0 Then
                                            If Convert.ToDouble(Me.txtCosto.Text.Trim()) > 0 Then
                                                If Convert.ToDouble(Me.txtCantidad.Text.Trim) > 0 Then
                                                    If Convert.ToDouble(Me.txtSaldo.Text.Trim) - Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCosto.Text) >= 0 Then
                                                        'If Datos.Verificar_Duplicidad_Grid_Global(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Me.dgvDistribucionCn) = True Then
                                                         If Datos.Verificar_Duplicidad_Grid_CN(23, Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & IIf(rbBienes.Checked, "B.", "S.") & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "", Me.dgvDistribucionCn) = True Then
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
                                                            dgvDistribucionCn.Item(17, dgvDistribucionCn.Rows.Count - 1).Value = iif(rbBienes.Checked,"B.","S.") & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim
                                                            dgvDistribucionCn.Item(18, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtItem.Text
                                                            dgvDistribucionCn.Item(19, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtCodigoUnidadMedida.Text
                                                            dgvDistribucionCn.Item(20, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtUnidadMedida.Text

                                                            dgvDistribucionCn.Item(21, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCantidad.Text), "###,###,#.00")
                                                            dgvDistribucionCn.Item(22, dgvDistribucionCn.Rows.Count - 1).Value = Format(Convert.ToDouble(Me.txtCosto.Text), "###,###,#.00000")

                                                            dgvDistribucionCn.Item(23, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtEnero.Text
                                                            dgvDistribucionCn.Item(24, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtFebrero.Text
                                                            dgvDistribucionCn.Item(25, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtMarzo.Text
                                                            dgvDistribucionCn.Item(26, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtAbril.Text
                                                            dgvDistribucionCn.Item(27, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtMayo.Text
                                                            dgvDistribucionCn.Item(28, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtJunio.Text
                                                            dgvDistribucionCn.Item(29, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtJulio.Text
                                                            dgvDistribucionCn.Item(30, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtAgosto.Text
                                                            dgvDistribucionCn.Item(31, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtSeptiembre.Text
                                                            dgvDistribucionCn.Item(32, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtOctubre.Text
                                                            dgvDistribucionCn.Item(33, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtNoviembre.Text
                                                            dgvDistribucionCn.Item(34, dgvDistribucionCn.Rows.Count - 1).Value = Me.txtDiciembre.Text
                                                            dgvDistribucionCn.Item(35, dgvDistribucionCn.Rows.Count - 1).Value = Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString & "." & Rubro.Rows(Me.cbRubro.SelectedIndex).Item("Codigo_Rubro").ToString & "." & Me.txtCodigoGrupo.Text.Trim & "." & Me.txtCodigoClase.Text.Trim & "." & Me.txtCodigoFamilia.Text.Trim & "." & Me.txtCodigoItem.Text.Trim & "." & Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString & "." & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString & "." & Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString
                                                            dgvDistribucionCn.Item(36, dgvDistribucionCn.Rows.Count - 1).Value = iif(rbBienes.Checked,"01","02")
                                                            dgvDistribucionCn.Item(38, dgvDistribucionCn.Rows.Count - 1).Value = Format(math.Round(convert.ToDouble(Me.txtCantidad.Text)*Convert.ToDouble(txtCosto.Text),2,MidpointRounding.AwayFromZero),"###,###,#.00")
                                                            dgvDistribucionCn.Item(41, dgvDistribucionCn.Rows.Count - 1).Value = IIf(Me.txtdb.Text.Trim()=string.Empty, "0", Me.txtdb.Text ) 
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
                                                            Me.cbUnidadOrganica.Enabled = False

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
                                                            Me.txtDB.Text=""
                                                            Me.btnBuscarItems.Focus()
                                                        Else
                                                            MessageBox.Show($"Ya exite en el Detalle el Item del Catalogo con la misma FF,RB y Unidad Orgánica.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                        End If
                                                    Else
                                                        MessageBox.Show(String.Format("No hay saldo suficiente para agregar este {0}",IIf(rbBienes.Checked,"Bien","Servicio")), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
                                            Me.txtItem.Focus()
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
            if txtDB.Text.Trim() <> String.Empty Then
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

            Me.txtEnero.Text = Me.dgvDistribucionCn.CurrentRow.Cells(23).Value
            Me.txtFebrero.Text = Me.dgvDistribucionCn.CurrentRow.Cells(24).Value
            Me.txtMarzo.Text = Me.dgvDistribucionCn.CurrentRow.Cells(25).Value
            Me.txtAbril.Text = Me.dgvDistribucionCn.CurrentRow.Cells(26).Value
            Me.txtMayo.Text = Me.dgvDistribucionCn.CurrentRow.Cells(27).Value
            Me.txtJunio.Text = Me.dgvDistribucionCn.CurrentRow.Cells(28).Value
            Me.txtJulio.Text = Me.dgvDistribucionCn.CurrentRow.Cells(29).Value
            Me.txtAgosto.Text = Me.dgvDistribucionCn.CurrentRow.Cells(30).Value
            Me.txtSeptiembre.Text = Me.dgvDistribucionCn.CurrentRow.Cells(31).Value
            Me.txtOctubre.Text = Me.dgvDistribucionCn.CurrentRow.Cells(32).Value
            Me.txtNoviembre.Text = Me.dgvDistribucionCn.CurrentRow.Cells(33).Value
            Me.txtDiciembre.Text = Me.dgvDistribucionCn.CurrentRow.Cells(34).Value
            Me.txtDB.Text = Me.dgvDistribucionCn.CurrentRow.Cells(41).Value

            SumaTotalMeses()
            Me.txtCosto.Text = Format(Convert.ToDouble(Me.dgvDistribucionCn.CurrentRow.Cells(22).Value), "###,###,#.00000")

            Me.dgvDistribucionCn.Rows.Remove(Me.dgvDistribucionCn.CurrentRow)
            Call Me.Evaluar_Saldos()
            txtSaldo.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtCantidad.Text)*CDbl(txtCosto.Text), "###,###,#.00")
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Editar = False Then
            If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
                If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                    If Me.cbActividad.Text.Trim.Length > 0 Then
                        If Datos.Verificar_Existencia_Cuadro_Necesidades(My.Settings.Año_Ejecucion, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString) = True Then
                            Datos.Nuevo_Cuadro_Necesidades(My.Settings.Año_Ejecucion, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, "01", Today.Date, My.Settings.Usuario)

                            For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                                Datos.Nuevo_Detalle_Cuadro_Necesidades(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value,Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                            Next
                            Me.Close()
                        Else
                            MessageBox.Show("La Unidad Orgánica seleccionada ya cuenta con una Lista"+ Environment.NewLine+"de Cuadro de Necesidades aperturado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar la Actividad a Registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.cbActividad.Focus()
                    End If
                Else
                    MessageBox.Show("Debes seleccionar la Secuencia Funcional o Meta Presupuestal a Registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.cbSecuenciaFuncional.Focus()
                End If
            Else
                MessageBox.Show("Debes seleccionar la Unidad Orgánica a Registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.cbUnidadOrganica.Focus()
            End If
        Else
            If Me.cbUnidadOrganica.Text.Trim.Length > 0 Then
                If Me.cbSecuenciaFuncional.Text.Trim.Length > 0 Then
                    If Me.cbActividad.Text.Trim.Length > 0 Then
                        Datos.Eliminar_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad)
                        Datos.Nuevo_Cuadro_Necesidades(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, "01", Today.Date, My.Settings.Usuario)

                        For Recorrido As Integer = 0 To Me.dgvDistribucionCn.RowCount - 1
                            Datos.Nuevo_Detalle_Cuadro_Necesidades(Me.dgvDistribucionCn.Rows(Recorrido).Cells(0).Value, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(1).Value), Me.dgvDistribucionCn.Rows(Recorrido).Cells(2).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(3).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(4).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(5).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(6).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(7).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(8).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(36).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(13).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(14).Value, Me.dgvDistribucionCn.Rows(Recorrido).Cells(15).Value,Me.dgvDistribucionCn.Rows(Recorrido).Cells(16).Value, Secuencia_Funcional.Rows(Me.cbSecuenciaFuncional.SelectedIndex).Item("Codigo_Secuencia_Funcional").ToString, Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex).Item("Codigo_Unidad_Organica").ToString, Actividad.Rows(Me.cbActividad.SelectedIndex).Item("Codigo_Actividad").ToString, Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(22).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(23).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(24).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(25).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(26).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(27).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(28).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(29).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(30).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(31).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(32).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(33).Value), Convert.ToDouble(Me.dgvDistribucionCn.Rows(Recorrido).Cells(34).Value))
                        Next
                        Me.Close()
                    Else
                        MessageBox.Show("Debes seleccionar la Actividad a Registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.cbActividad.Focus()
                    End If
                Else
                    MessageBox.Show("Debes seleccionar la Secuencia Funcional o Meta Presupuestal a Registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.cbSecuenciaFuncional.Focus()
                End If
            Else
                MessageBox.Show("Debes seleccionar la Unidad Orgánica a Registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.cbUnidadOrganica.Focus()
            End If
        End If

    End Sub

    Private Sub frmRegistro_CN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        If Editar = False Then
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")
            'Tipo_Transaccion = Datos.LLenar_Combo_Solo("Select * From Lista_Tipo_Transaccion Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cb, "Transaccion")
            Call Me.Dimensionar()
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Else
            Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
            Fuente_Financiaminto = Datos.LLenar_Combo_Solo("Select * From Lista_FF Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_FF In(2,4)", Me.cbFF, "Fuente")
            'Tipo_Transaccion = Datos.LLenar_Combo_Solo("Select * From Lista_Tipo_Transaccion Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cbTipoTransaccion, "Transaccion")
            Call Me.Dimensionar()
            if (Datos.Cargar_CN_Para_Modificacion(My.Settings.Año_Ejecucion, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad, Me.cbUnidadOrganica, Me.dgvDistribucionCn)=1)
                Me.Close
            End If
            Me.cbUnidadOrganica.Enabled = False
            Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        End If

    End Sub

    Private Sub btnBuscarItems_Click(sender As Object, e As EventArgs) Handles btnBuscarItems.Click
        if cbFF.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar una Fuente de financiamiento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        if cbRubro.SelectedIndex = -1 
            MessageBox.Show("Debes seleccionar un Rubro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
        Formulario.Operacion = 2
        Formulario.Tipo_Modulo = 1
        Formulario.Tipo_Catalogo = IIf(rbBienes.Checked, "01","02")
        Formulario.ShowDialog()
        If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
            Datos.Mostrar_Data_Item_Catalogo(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, 
                                             Variable_Codigo_Item, IIf(rbBienes.Checked, 1,2), Me.txtCodigoGrupo, 
                                             Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, 
                                             Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, 
                                             Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, 
                                             Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
            Me.txtEnero.Focus()
            Call Me.Evaluar_Saldos()
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
                                                        Format(Datos.Saldo_CN(Convert.ToDouble(Fuente_Financiaminto.Rows(Me.cbFF.SelectedIndex).Item("Codigo_FF").ToString),
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


                Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                      Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                If rbBienes.Checked
                    Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                End If

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

                            Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                            If rbBienes.Checked
                                Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                            End If

                            total_clasificador = total_clasificador + Acumulado
                        end If
                    else
                        if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                            Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                            If rbBienes.Checked
                                Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                            End If

                            total_clasificador = total_clasificador + Acumulado
                        end If
                    End If
                Else
                    if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                            row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                            row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                            Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                              Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                            If rbBienes.Checked
                                Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                            End If

                            total_clasificador = total_clasificador + Acumulado
                        end If
                End If
            else if Tipo_Transaccion & "." & Generica & "." & Sub_Generica = "2.3.2"
                If Tipo_Transaccion & "." & Generica & "." & Sub_Generica & "." & Sub_Generica_Detalle & "." & Especifica & "." & Especifica_Detalle = "2.3.2.7.2.99"
                    if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                        row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
                        row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                        row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                        Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                        If rbBienes.Checked
                            Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                        End If

                        total_clasificador = total_clasificador + Acumulado
                    end If
                else
                    if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                        row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and 
                        row.Cells("Año").Value = Año_Ejecucion And row.Cells("db").Value = "0")

                        Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                        If rbBienes.Checked
                            Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                        End If

                        total_clasificador = total_clasificador + Acumulado
                    end If
                End If
            else if Tipo_Transaccion & "." & Generica = "2.6"
                if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
                        row.Cells("G").Value = Generica And row.Cells("UO").Value = Codigo_Unidad_Organica and row.Cells("Año").Value = Año_Ejecucion And 
                        row.Cells("db").Value = "0")

                        Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
                                          Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

                        If rbBienes.Checked
                            Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
                        End If

                        total_clasificador = total_clasificador + Acumulado
                    end If
            End If

            'if (row.Cells("FF").Value = Codigo_FF And row.Cells("R").Value = Codigo_Rubro And row.Cells("TT").Value = Tipo_Transaccion And
            '    row.Cells("G").Value = Generica And row.Cells("SG").Value = Sub_Generica And row.Cells("SGD").Value = Sub_Generica_Detalle And
            '    row.Cells("E").Value = Especifica And row.Cells("ED").Value = Especifica_Detalle And row.Cells("Meta").Value = Codigo_Secuencia_Funcional And
            '    row.Cells("UO").Value = Codigo_Unidad_Organica and row.Cells("CA").Value = Codigo_Actividad and row.Cells("Año").Value = Año_Ejecucion)

            '    Acumulado = (Convert.ToDouble(IIf(row.Cells("Ene.").Value.ToString()=string.Empty,"0.00",row.Cells("Ene.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Feb.").Value.ToString()=string.Empty,"0.00",row.Cells("Feb.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Mar.").Value.ToString()=string.Empty,"0.00",row.Cells("Mar.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Abr.").Value.ToString()=string.Empty,"0.00",row.Cells("Abr.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("May.").Value.ToString()=string.Empty,"0.00",row.Cells("May.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Jun.").Value.ToString()=string.Empty,"0.00",row.Cells("Jun.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Jul.").Value.ToString()=string.Empty,"0.00",row.Cells("Jul.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Ago.").Value.ToString()=string.Empty,"0.00",row.Cells("Ago.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Sep.").Value.ToString()=string.Empty,"0.00",row.Cells("Sep.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Oct.").Value.ToString()=string.Empty,"0.00",row.Cells("Oct.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Nov.").Value.ToString()=string.Empty,"0.00",row.Cells("Nov.").Value))+
            '                          Convert.ToDouble(IIf(row.Cells("Dic.").Value.ToString()=string.Empty,"0.00",row.Cells("Dic.").Value))) 

            '    If rbBienes.Checked
            '        Acumulado = Acumulado*Convert.ToDouble(IIf(row.Cells("Costo").Value.ToString()=string.Empty,"0.00",row.Cells("Costo").Value))
            '    End If

            '    total_clasificador = total_clasificador + Acumulado
                                         
            'end If
        Next
        return total_clasificador
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
        If rbServicios.Checked 
            gbCatalogo.Text="Catalogo de Servicios"
            Label26.Text = "Importe Total a Solicitar"
            Label25.Visible=False
            txtCosto.Text="1.00"
            txtCosto.Visible=false
        Else 
            gbCatalogo.Text="Catalogo de Bienes"
            Label26.Text = "Cantidad Total a Solicitar"
            Label25.Visible=True
            txtCosto.Text="0.00"
            txtCosto.Visible=True
        End If
    End Sub

    Private Sub rbBienes_CheckedChanged(sender As Object, e As EventArgs) Handles rbBienes.CheckedChanged
        Limpiar_Busqueda_items()

        If rbBienes.Checked 
            gbCatalogo.Text="Catalogo de Bienes"
            Label26.Text = "Cantidad Total a Solicitar"
            Label25.Visible=True
            txtCosto.Text="0.00"
            txtCosto.Visible=True
        Else 
            gbCatalogo.Text="Catalogo de Servicios"
            Label26.Text = "Importe Total a Solicitar"
            Label25.Visible=False
            txtCosto.Text="1.00"
            txtCosto.Visible=false
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
End Class
