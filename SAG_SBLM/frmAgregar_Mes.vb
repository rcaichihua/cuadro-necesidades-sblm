Public Class frmAgregar_Mes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Mes As New DataTable
    Dim Separador As Char
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Codigo_Mes = ""
        Variable_Nombre_Mes = ""
        Variable_Monto_Mes = 0
        Me.Close()
    End Sub
    Private Sub frmAgregar_Mes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Mes = Datos.LLenar_Combo_Solo("Select * From Mes Where Abs(Codigo_Mes) >= Month(GetDate())", Me.cbMes, "Nombre_Mes")
        Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    End Sub
    Private Sub txtMonto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Enter
        txtMonto.SelectionStart = 0
        txtMonto.SelectionLength = txtMonto.Text.Length
    End Sub
    Private Sub txtMonto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.GotFocus
        txtMonto.SelectionStart = 0
        txtMonto.SelectionLength = txtMonto.Text.Length
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If txtMonto.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            Call Me.btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        If Me.txtMonto.Text.Trim.Length > 0 Then
            Me.txtMonto.Text = FormatNumber(txtMonto.Text, 2, , , TriState.True)
        Else
            Me.txtMonto.Text = "0.00"
        End If
    End Sub
    Private Sub txtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.LostFocus
        With Me.txtMonto
            If Len(Trim(.Text)) = 0 Then .Text = 0
            .Text = FormatNumber(.Text, 2, , , TriState.True)
        End With
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.cbMes.Text.Trim.Length > 0 Then
            If Convert.ToDouble(Me.txtMonto.Text) > 0 Then
                Variable_Codigo_Mes = Mes.Rows(Me.cbMes.SelectedIndex).Item("Codigo_Mes").ToString
                Variable_Nombre_Mes = Me.cbMes.Text
                Variable_Monto_Mes = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Else
                MessageBox.Show("Debes Ingresar el Monto del Entegrable", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtMonto.Focus()
            End If
        Else
            MessageBox.Show("Debes Seleccionar el Mes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.cbMes.Focus()
        End If
    End Sub
    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        If Me.cbMes.Items.Count > 0 Then
            If Me.cbMes.Text.Trim.Length > 0 Then
                Me.txtMonto.Focus()
            End If
        End If
    End Sub
End Class