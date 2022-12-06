Public Class frmMonto
    Inherits DevComponents.DotNetBar.Office2007Form
    Public Operacion As Integer = 0
    Dim Separador As Char
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
            Call Me.txtMonto_Leave(sender, e)
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
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Select Case Operacion
            Case 1
                Variable_Monto_Rebajar = 0
                Me.Close()
            Case 2
                Variable_Monto_Ampliar = 0
                Me.Close()
            Case 3
                Variable_Monto_Girar = 0
                Me.Close()
            Case 4
                Variable_Monto_Debe = 0
                Me.Close()
            Case 5
                Variable_Monto_Haber = 0
                Me.Close()
            Case 6
                Variable_Monto_Planilla = 0
                Me.Close()
            Case 7
                Variable_Monto_Devengar = 0
                Me.Close()
            Case 8
                Variable_Monto_Pagos_Varios = 0
                Me.Close()
            Case 9
                Variable_Monto_Encargo_Interno = 0
                Me.Close()
            Case 10
                Variable_Monto_Planilla = 0
                Me.Close()
        End Select
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case Operacion
            Case 1
                Variable_Monto_Rebajar = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 2
                Variable_Monto_Ampliar = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 3
                Variable_Monto_Girar = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 4
                Variable_Monto_Debe = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 5
                Variable_Monto_Haber = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 6
                Variable_Monto_Planilla = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 7
                Variable_Monto_Devengar = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 8
                Variable_Monto_Pagos_Varios = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 9
                Variable_Monto_Encargo_Interno = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
            Case 10
                Variable_Monto_Planilla = Convert.ToDouble(Me.txtMonto.Text)
                Me.Close()
        End Select
    End Sub
    Private Sub frmMonto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If Operacion = 3 Then
            Me.txtMonto.Text = Format(Variable_Monto_Girar, "###,###,#.00")
        End If
        If Operacion = 4 Then
            Me.txtMonto.Text = Format(Variable_Monto_Debe, "###,###,#.00")
        End If
        If Operacion = 5 Then
            Me.txtMonto.Text = Format(Variable_Monto_Haber, "###,###,#.00")
        End If
        If Operacion = 6 Then
            Me.txtMonto.Text = Format(Variable_Monto_Planilla, "###,###,#.00")
        End If
        If Operacion = 7 Then
            Me.txtMonto.Text = Format(Variable_Monto_Devengar, "###,###,#.00")
        End If
        If Operacion = 8 Then
            Me.txtMonto.Text = Format(Variable_Monto_Pagos_Varios, "###,###,#.00")
        End If
        If Operacion = 9 Then
            Me.txtMonto.Text = Format(Variable_Monto_Encargo_Interno, "###,###,#.00")
        End If
        If Operacion = 10 Then
            Me.txtMonto.Text = Format(Variable_Monto_Planilla, "###,###,#.00")
        End If
    End Sub
End Class