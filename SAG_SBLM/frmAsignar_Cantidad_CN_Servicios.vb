'Public Class frmAsignar_Cantidad_CN_Servicios
'    Dim Datos As New Mantenimiento
'    Dim Separador As Char
'    Public Property _Cantidad_Enero_CN() As Decimal
'    Public Property _Cantidad_Febrero_CN() As Decimal
'    Public Property _Cantidad_Marzo_CN() As Decimal
'    Public Property _Cantidad_Abril_CN() As Decimal
'    Public Property _Cantidad_Mayo_CN() As Decimal
'    Public Property _Cantidad_Junio_CN() As Decimal
'    Public Property _Cantidad_Julio_CN() As Decimal
'    Public Property _Cantidad_Agosto_CN() As Decimal
'    Public Property _Cantidad_Septiembre_CN() As Decimal
'    Public Property _Cantidad_Octubre_CN() As Decimal
'    Public Property _Cantidad_Noviembre_CN() As Decimal
'    Public Property _Cantidad_Diciembre_CN() As Decimal

'    Public Property _Cantidad_Enero() As Decimal
'    Public Property _Cantidad_Febrero() As Decimal
'    Public Property _Cantidad_Marzo() As Decimal
'    Public Property _Cantidad_Abril() As Decimal
'    Public Property _Cantidad_Mayo() As Decimal
'    Public Property _Cantidad_Junio() As Decimal
'    Public Property _Cantidad_Julio() As Decimal
'    Public Property _Cantidad_Agosto() As Decimal
'    Public Property _Cantidad_Septiembre() As Decimal
'    Public Property _Cantidad_Octubre() As Decimal
'    Public Property _Cantidad_Noviembre() As Decimal
'    Public Property _Cantidad_Diciembre() As Decimal

'    Public Property _Cancela As Boolean
'    Public Property _Editado As Boolean
'    Dim Mes_Actual as integer = 0

'    Private Sub txtCantidadEnero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadEnero.KeyPress, txtEneroCN.KeyPress
'        If txtCantidadEnero.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadFebrero.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadEnero_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadEnero.Leave, txtEneroCN.Leave
'        If Me.txtCantidadEnero.Text.Trim.Length > 0 Then
'            Me.txtCantidadEnero.Text = FormatNumber(txtCantidadEnero.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadEnero.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadEnero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadEnero.LostFocus, txtEneroCN.LostFocus
'        With Me.txtCantidadEnero
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadFebrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadFebrero.KeyPress, txtFebreroCN.KeyPress
'        If txtCantidadFebrero.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadMarzo.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadFebrero_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadFebrero.Leave, txtFebreroCN.Leave
'        If Me.txtCantidadFebrero.Text.Trim.Length > 0 Then
'            Me.txtCantidadFebrero.Text = FormatNumber(txtCantidadFebrero.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadFebrero.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadFebrero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadFebrero.LostFocus, txtFebreroCN.LostFocus
'        With Me.txtCantidadFebrero
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadMarzo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadMarzo.KeyPress, txtMarzoCN.KeyPress
'        If txtCantidadMarzo.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadAbril.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadMarzo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadMarzo.Leave, txtMarzoCN.Leave
'        If Me.txtCantidadMarzo.Text.Trim.Length > 0 Then
'            Me.txtCantidadMarzo.Text = FormatNumber(txtCantidadMarzo.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadMarzo.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadMarzo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadMarzo.LostFocus, txtMarzoCN.LostFocus
'        With Me.txtCantidadMarzo
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadAbril_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadAbril.KeyPress, txtAbrilCN.KeyPress
'        If txtCantidadAbril.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadMayo.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadAbril_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAbril.Leave, txtAbrilCN.Leave
'        If Me.txtCantidadAbril.Text.Trim.Length > 0 Then
'            Me.txtCantidadAbril.Text = FormatNumber(txtCantidadAbril.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadAbril.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadAbril_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAbril.LostFocus, txtAbrilCN.LostFocus
'        With Me.txtCantidadAbril
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadMayo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadMayo.KeyPress, txtMayoCN.KeyPress
'        If txtCantidadMayo.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadJunio.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadMayo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadMayo.Leave, txtMayoCN.Leave
'        If Me.txtCantidadMayo.Text.Trim.Length > 0 Then
'            Me.txtCantidadMayo.Text = FormatNumber(txtCantidadMayo.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadMayo.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadMayo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadMayo.LostFocus, txtMayoCN.LostFocus
'        With Me.txtCantidadMayo
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadJunio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadJunio.KeyPress, txtJunioCN.KeyPress
'        If txtCantidadJunio.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadJulio.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadJunio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadJunio.Leave, txtJunioCN.Leave
'        If Me.txtCantidadJunio.Text.Trim.Length > 0 Then
'            Me.txtCantidadJunio.Text = FormatNumber(txtCantidadJunio.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadJunio.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadJunio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadJunio.LostFocus, txtJunioCN.LostFocus
'        With Me.txtCantidadJunio
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadJulio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadJulio.KeyPress, txtJulioCN.KeyPress
'        If txtCantidadJulio.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadAgosto.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadJulio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadJulio.Leave, txtJulioCN.Leave
'        If Me.txtCantidadJulio.Text.Trim.Length > 0 Then
'            Me.txtCantidadJulio.Text = FormatNumber(txtCantidadJulio.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadJulio.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadJulio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadJulio.LostFocus, txtJulioCN.LostFocus
'        With Me.txtCantidadJulio
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadAgosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadAgosto.KeyPress, txtAgostoCN.KeyPress
'        If txtCantidadAgosto.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadSeptiembre.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadAgosto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAgosto.Leave, txtAgostoCN.Leave
'        If Me.txtCantidadAgosto.Text.Trim.Length > 0 Then
'            Me.txtCantidadAgosto.Text = FormatNumber(txtCantidadAgosto.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadAgosto.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadAgosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAgosto.LostFocus, txtAgostoCN.LostFocus
'        With Me.txtCantidadAgosto
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadSeptiembre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadSeptiembre.KeyPress, txtSeptiembreCN.KeyPress
'        If txtCantidadSeptiembre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadOctubre.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadSeptiembre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadSeptiembre.Leave, txtSeptiembreCN.Leave
'        If Me.txtCantidadSeptiembre.Text.Trim.Length > 0 Then
'            Me.txtCantidadSeptiembre.Text = FormatNumber(txtCantidadSeptiembre.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadSeptiembre.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadSeptiembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadSeptiembre.LostFocus, txtSeptiembreCN.LostFocus
'        With Me.txtCantidadSeptiembre
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadOctubre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadOctubre.KeyPress, txtOctubreCN.KeyPress
'        If txtCantidadOctubre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadNoviembre.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadOctubre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadOctubre.Leave, txtOctubreCN.Leave
'        If Me.txtCantidadOctubre.Text.Trim.Length > 0 Then
'            Me.txtCantidadOctubre.Text = FormatNumber(txtCantidadOctubre.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadOctubre.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadOctubre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadOctubre.LostFocus, txtOctubreCN.LostFocus
'        With Me.txtCantidadOctubre
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadNoviembre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadNoviembre.KeyPress, txtNoviembreCN.KeyPress
'        If txtCantidadNoviembre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Me.txtCantidadDiciembre.Focus()
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadNoviembre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadNoviembre.Leave, txtNoviembreCN.Leave
'        If Me.txtCantidadNoviembre.Text.Trim.Length > 0 Then
'            Me.txtCantidadNoviembre.Text = FormatNumber(txtCantidadNoviembre.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadNoviembre.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadNoviembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadNoviembre.LostFocus, txtNoviembreCN.LostFocus
'        With Me.txtCantidadNoviembre
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadDiciembre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadDiciembre.KeyPress, txtDiciembreCN.KeyPress
'        If txtCantidadDiciembre.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
'        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
'        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
'        If Asc(e.KeyChar) = 13 Then
'            Call btnAceptar_Click(sender, e)
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadDiciembre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadDiciembre.Leave, txtDiciembreCN.Leave
'        If Me.txtCantidadDiciembre.Text.Trim.Length > 0 Then
'            Me.txtCantidadDiciembre.Text = FormatNumber(txtCantidadDiciembre.Text, 2, , , TriState.True)
'        Else
'            Me.txtCantidadDiciembre.Text = "0.00"
'        End If
'        Call Me.Total()
'    End Sub
'    Private Sub txtCantidadDiciembre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadDiciembre.LostFocus, txtDiciembreCN.LostFocus
'        With Me.txtCantidadDiciembre
'            If Len(Trim(.Text)) = 0 Then .Text = 0
'            .Text = FormatNumber(.Text, 2, , , TriState.True)
'        End With
'        Call Me.Total()
'    End Sub
'    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
'        If ValidarCantidades() then return

'        _Editado = True

'        _Cantidad_Enero = Convert.ToDecimal(Me.txtCantidadEnero.Text.Trim)
'        _Cantidad_Febrero = Convert.ToDecimal(Me.txtCantidadFebrero.Text.Trim)
'        _Cantidad_Marzo = Convert.ToDecimal(Me.txtCantidadMarzo.Text.Trim)
'        _Cantidad_Abril = Convert.ToDecimal(Me.txtCantidadAbril.Text.Trim)
'        _Cantidad_Mayo = Convert.ToDecimal(Me.txtCantidadMayo.Text.Trim)
'        _Cantidad_Junio = Convert.ToDecimal(Me.txtCantidadJunio.Text.Trim)
'        _Cantidad_Julio = Convert.ToDecimal(Me.txtCantidadJulio.Text.Trim)
'        _Cantidad_Agosto = Convert.ToDecimal(Me.txtCantidadAgosto.Text.Trim)
'        _Cantidad_Septiembre = Convert.ToDecimal(Me.txtCantidadSeptiembre.Text.Trim)
'        _Cantidad_Octubre = Convert.ToDecimal(Me.txtCantidadOctubre.Text.Trim)
'        _Cantidad_Noviembre = Convert.ToDecimal(Me.txtCantidadNoviembre.Text.Trim)
'        _Cantidad_Diciembre = Convert.ToDecimal(Me.txtCantidadDiciembre.Text.Trim)

'        _Cancela = False

'        Close()
'    End Sub
'    Private Function ValidarCantidades() as Boolean
'        ValidarCantidades = True
'        If Convert.ToDecimal(Me.txtCantidadEnero.Text.Trim)<=Convert.ToDecimal(Me.txtEneroCN.Text.Trim)
'            If Convert.ToDecimal(Me.txtCantidadFebrero.Text.Trim)<=Convert.ToDecimal(Me.txtFebreroCN.Text.Trim)
'                If Convert.ToDecimal(Me.txtCantidadMarzo.Text.Trim)<=Convert.ToDecimal(Me.txtMarzoCN.Text.Trim)
'                    If Convert.ToDecimal(Me.txtCantidadAbril.Text.Trim)<=Convert.ToDecimal(Me.txtAbrilCN.Text.Trim)
'                        If Convert.ToDecimal(Me.txtCantidadMayo.Text.Trim)<=Convert.ToDecimal(Me.txtMayoCN.Text.Trim)
'                            If Convert.ToDecimal(Me.txtCantidadJunio.Text.Trim)<=Convert.ToDecimal(Me.txtJunioCN.Text.Trim)
'                                If Convert.ToDecimal(Me.txtCantidadJulio.Text.Trim)<=Convert.ToDecimal(Me.txtJulioCN.Text.Trim)
'                                    If Convert.ToDecimal(Me.txtCantidadAgosto.Text.Trim)<=Convert.ToDecimal(Me.txtAgostoCN.Text.Trim)
'                                        If Convert.ToDecimal(Me.txtCantidadSeptiembre.Text.Trim)<=Convert.ToDecimal(Me.txtSeptiembreCN.Text.Trim)
'                                            If Convert.ToDecimal(Me.txtCantidadOctubre.Text.Trim)<=Convert.ToDecimal(Me.txtOctubreCN.Text.Trim)
'                                                If Convert.ToDecimal(Me.txtCantidadNoviembre.Text.Trim)<=Convert.ToDecimal(Me.txtNoviembreCN.Text.Trim)
'                                                    If Convert.ToDecimal(Me.txtCantidadDiciembre.Text.Trim)<=Convert.ToDecimal(Me.txtDiciembreCN.Text.Trim)
'                                                        If Convert.ToDecimal(Me.txtTotal.Text.Trim)>0.00
'                                                            ValidarCantidades = False
'                                                        Else
'                                                            MessageBox.Show("La cantidad total asignada debe ser mayor cero(0.00).", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                                            txtCantidadEnero.Focus()
'                                                        End If
'                                                    Else
'                                                        MessageBox.Show("La cantidad asignada en Diciembre NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                                        txtCantidadDiciembre.Focus()
'                                                    End If
'                                                Else
'                                                    MessageBox.Show("La cantidad asignada en Noviembre NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                                    txtCantidadNoviembre.Focus()
'                                                End If
'                                            Else
'                                                MessageBox.Show("La cantidad asignada en Octubre NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                                txtCantidadOctubre.Focus()
'                                            End If
'                                        Else
'                                            MessageBox.Show("La cantidad asignada en Septiembre NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                            txtCantidadSeptiembre.Focus()
'                                        End If
'                                    Else
'                                        MessageBox.Show("La cantidad asignada en Agosto NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                        txtCantidadAgosto.Focus()
'                                    End If
'                                Else
'                                    MessageBox.Show("La cantidad asignada en Julio NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                    txtCantidadJulio.Focus()
'                                End If
'                            Else
'                                MessageBox.Show("La cantidad asignada en Junio NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                                txtCantidadJunio.Focus()
'                            End If
'                        Else
'                            MessageBox.Show("La cantidad asignada en Mayo NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                            txtCantidadMayo.Focus()
'                        End If
'                    Else
'                        MessageBox.Show("La cantidad asignada en Abril NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                        txtCantidadAbril.Focus()
'                    End If
'                Else
'                    MessageBox.Show("La cantidad asignada en Marzo NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                    txtCantidadMarzo.Focus()
'                End If
'            Else
'                MessageBox.Show("La cantidad asignada en Febrero NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'                txtCantidadFebrero.Focus()
'            End If
'        Else
'            MessageBox.Show("La cantidad asignada en Enero NO puede ser mayor a la cantidad asignada en el C.N. del mismo mes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
'            txtCantidadEnero.Focus()
'        End If
'        Return ValidarCantidades
'    End Function
'    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
'        _Cancela=True
'        Me.Close()
'    End Sub
'    Private Sub Total()
'        On Error Resume Next
'        Dim Ene As Double = IIf(Me.txtCantidadEnero.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadEnero.Text.Trim), 0)
'        Dim Feb As Double = IIf(Me.txtCantidadFebrero.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadFebrero.Text.Trim), 0)
'        Dim Mar As Double = IIf(Me.txtCantidadMarzo.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadMarzo.Text.Trim), 0)
'        Dim Abr As Double = IIf(Me.txtCantidadAbril.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadAbril.Text.Trim), 0)
'        Dim May As Double = IIf(Me.txtCantidadMayo.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadMayo.Text.Trim), 0)
'        Dim Jun As Double = IIf(Me.txtCantidadJunio.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadJunio.Text.Trim), 0)
'        Dim Jul As Double = IIf(Me.txtCantidadJulio.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadJulio.Text.Trim), 0)
'        Dim Ago As Double = IIf(Me.txtCantidadAgosto.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadAgosto.Text.Trim), 0)
'        Dim Sep As Double = IIf(Me.txtCantidadSeptiembre.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadSeptiembre.Text.Trim), 0)
'        Dim Oct As Double = IIf(Me.txtCantidadOctubre.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadOctubre.Text.Trim), 0)
'        Dim Nov As Double = IIf(Me.txtCantidadNoviembre.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadNoviembre.Text.Trim), 0)
'        Dim Dic As Double = IIf(Me.txtCantidadDiciembre.Text.Trim.Length > 0, Convert.ToDecimal(Me.txtCantidadDiciembre.Text.Trim), 0)
'        Dim Total As Double = Ene + Feb + Mar + Abr + May + Jun + Jul + Ago + Sep + Oct + Nov + Dic
'        Me.txtTotal.Text = Format(Total, "###,###,#.00")
'    End Sub
'    Private Sub txtCantidadEnero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadEnero.TextChanged, txtEneroCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadFebrero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadFebrero.TextChanged, txtFebreroCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadMarzo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadMarzo.TextChanged, txtMarzoCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadAbril_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadAbril.TextChanged, txtAbrilCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadMayo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadMayo.TextChanged, txtMayoCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadJunio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadJunio.TextChanged, txtJunioCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadJulio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadJulio.TextChanged, txtJulioCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadAgosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadAgosto.TextChanged, txtAgostoCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadSeptiembre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadSeptiembre.TextChanged, txtSeptiembreCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadOctubre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadOctubre.TextChanged, txtOctubreCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadNoviembre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadNoviembre.TextChanged, txtNoviembreCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub txtCantidadDiciembre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadDiciembre.TextChanged, txtDiciembreCN.TextChanged
'        Call Me.Total()
'    End Sub

'    Private Sub frmAsignar_Cantidad_CN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Mes_Actual = Datos.Obtiene_Mes_Actual(My.Settings.Año_Ejecucion)
'        _Cancela = False
'        Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
'        If _Editado Then
'            Me.txtEneroCN.Text = Format(_Cantidad_Enero_CN, "###,###,#.00")
'            Me.txtFebreroCN.Text = Format(_Cantidad_Febrero_CN, "###,###,#.00")
'            Me.txtMarzoCN.Text = Format(_Cantidad_Marzo_CN, "###,###,#.00")
'            Me.txtAbrilCN.Text = Format(_Cantidad_Abril_CN, "###,###,#.00")
'            Me.txtMayoCN.Text = Format(_Cantidad_Mayo_CN, "###,###,#.00")
'            Me.txtJunioCN.Text = Format(_Cantidad_Junio_CN, "###,###,#.00")
'            Me.txtJulioCN.Text = Format(_Cantidad_Julio_CN, "###,###,#.00")
'            Me.txtAgostoCN.Text = Format(_Cantidad_Agosto_CN, "###,###,#.00")
'            Me.txtSeptiembreCN.Text = Format(_Cantidad_Septiembre_CN, "###,###,#.00")
'            Me.txtOctubreCN.Text = Format(_Cantidad_Octubre_CN, "###,###,#.00")
'            Me.txtNoviembreCN.Text = Format(_Cantidad_Noviembre_CN, "###,###,#.00")
'            Me.txtDiciembreCN.Text = Format(_Cantidad_Diciembre_CN, "###,###,#.00")

'            Me.txtCantidadEnero.Text = Format(_Cantidad_Enero, "###,###,#.00")
'            Me.txtCantidadFebrero.Text = Format(_Cantidad_Febrero, "###,###,#.00")
'            Me.txtCantidadMarzo.Text = Format(_Cantidad_Marzo, "###,###,#.00")
'            Me.txtCantidadAbril.Text = Format(_Cantidad_Abril, "###,###,#.00")
'            Me.txtCantidadMayo.Text = Format(_Cantidad_Mayo, "###,###,#.00")
'            Me.txtCantidadJunio.Text = Format(_Cantidad_Junio, "###,###,#.00")
'            Me.txtCantidadJulio.Text = Format(_Cantidad_Julio, "###,###,#.00")
'            Me.txtCantidadAgosto.Text = Format(_Cantidad_Agosto, "###,###,#.00")
'            Me.txtCantidadSeptiembre.Text = Format(_Cantidad_Septiembre, "###,###,#.00")
'            Me.txtCantidadOctubre.Text = Format(_Cantidad_Octubre, "###,###,#.00")
'            Me.txtCantidadNoviembre.Text = Format(_Cantidad_Noviembre, "###,###,#.00")
'            Me.txtCantidadDiciembre.Text = Format(_Cantidad_Diciembre, "###,###,#.00")
'        Else
'            Me.txtEneroCN.Text = Format(_Cantidad_Enero_CN, "###,###,#.00")
'            Me.txtFebreroCN.Text = Format(_Cantidad_Febrero_CN, "###,###,#.00")
'            Me.txtMarzoCN.Text = Format(_Cantidad_Marzo_CN, "###,###,#.00")
'            Me.txtAbrilCN.Text = Format(_Cantidad_Abril_CN, "###,###,#.00")
'            Me.txtMayoCN.Text = Format(_Cantidad_Mayo_CN, "###,###,#.00")
'            Me.txtJunioCN.Text = Format(_Cantidad_Junio_CN, "###,###,#.00")
'            Me.txtJulioCN.Text = Format(_Cantidad_Julio_CN, "###,###,#.00")
'            Me.txtAgostoCN.Text = Format(_Cantidad_Agosto_CN, "###,###,#.00")
'            Me.txtSeptiembreCN.Text = Format(_Cantidad_Septiembre_CN, "###,###,#.00")
'            Me.txtOctubreCN.Text = Format(_Cantidad_Octubre_CN, "###,###,#.00")
'            Me.txtNoviembreCN.Text = Format(_Cantidad_Noviembre_CN, "###,###,#.00")
'            Me.txtDiciembreCN.Text = Format(_Cantidad_Diciembre_CN, "###,###,#.00")
'        End If
'        DeshabilitaTextBox()
'        txtCantidadEnero.Focus()
'    End Sub
'    Private sub DeshabilitaTextBox()
'        If Mes_Actual=0 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato
'            txtCantidadJulio.ReadOnly=True
'            txtCantidadJulio.BackColor = Color.Tomato
'            txtCantidadAgosto.ReadOnly=True
'            txtCantidadAgosto.BackColor = Color.Tomato
'            txtCantidadSeptiembre.ReadOnly=True
'            txtCantidadSeptiembre.BackColor = Color.Tomato
'            txtCantidadOctubre.ReadOnly=True
'            txtCantidadOctubre.BackColor = Color.Tomato
'            txtCantidadNoviembre.ReadOnly=True
'            txtCantidadNoviembre.BackColor = Color.Tomato
'            txtCantidadDiciembre.ReadOnly=True
'            txtCantidadDiciembre.BackColor = Color.Tomato
'        ElseIf Mes_Actual=2 Then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato

'            txtCantidadFebrero.BackColor = Color.White
'            txtCantidadFebrero.ReadOnly=False
'            txtCantidadMarzo.BackColor = Color.White
'            txtCantidadMarzo.ReadOnly=False
'            txtCantidadAbril.BackColor = Color.White
'            txtCantidadAbril.ReadOnly=False
'            txtCantidadMayo.BackColor = Color.White
'            txtCantidadMayo.ReadOnly=False
'            txtCantidadJunio.BackColor = Color.White
'            txtCantidadJunio.ReadOnly=False
'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf  Mes_Actual=3 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato

'            txtCantidadMarzo.BackColor = Color.White
'            txtCantidadMarzo.ReadOnly=False
'            txtCantidadAbril.BackColor = Color.White
'            txtCantidadAbril.ReadOnly=False
'            txtCantidadMayo.BackColor = Color.White
'            txtCantidadMayo.ReadOnly=False
'            txtCantidadJunio.BackColor = Color.White
'            txtCantidadJunio.ReadOnly=False
'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        Elseif  Mes_Actual=4 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato

'            txtCantidadAbril.BackColor = Color.White
'            txtCantidadAbril.ReadOnly=False
'            txtCantidadMayo.BackColor = Color.White
'            txtCantidadMayo.ReadOnly=False
'            txtCantidadJunio.BackColor = Color.White
'            txtCantidadJunio.ReadOnly=False
'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=5 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato

'            txtCantidadMayo.BackColor = Color.White
'            txtCantidadMayo.ReadOnly=False
'            txtCantidadJunio.BackColor = Color.White
'            txtCantidadJunio.ReadOnly=False
'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=6 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato

'            txtCantidadJunio.BackColor = Color.White
'            txtCantidadJunio.ReadOnly=False
'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=7 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato

'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=8 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato
'            txtCantidadJulio.ReadOnly=True
'            txtCantidadJulio.BackColor = Color.Tomato

'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=9 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato
'            txtCantidadJulio.ReadOnly=True
'            txtCantidadJulio.BackColor = Color.Tomato
'            txtCantidadAgosto.ReadOnly=True
'            txtCantidadAgosto.BackColor = Color.Tomato

'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=10 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato
'            txtCantidadJulio.ReadOnly=True
'            txtCantidadJulio.BackColor = Color.Tomato
'            txtCantidadAgosto.ReadOnly=True
'            txtCantidadAgosto.BackColor = Color.Tomato
'            txtCantidadSeptiembre.ReadOnly=True
'            txtCantidadSeptiembre.BackColor = Color.Tomato

'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=11 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato
'            txtCantidadJulio.ReadOnly=True
'            txtCantidadJulio.BackColor = Color.Tomato
'            txtCantidadAgosto.ReadOnly=True
'            txtCantidadAgosto.BackColor = Color.Tomato
'            txtCantidadSeptiembre.ReadOnly=True
'            txtCantidadSeptiembre.BackColor = Color.Tomato
'            txtCantidadOctubre.ReadOnly=True
'            txtCantidadOctubre.BackColor = Color.Tomato

'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        ElseIf Mes_Actual=12 then
'            txtCantidadEnero.ReadOnly=True
'            txtCantidadEnero.BackColor = Color.Tomato
'            txtCantidadFebrero.ReadOnly=True
'            txtCantidadFebrero.BackColor = Color.Tomato
'            txtCantidadMarzo.ReadOnly=True
'            txtCantidadMarzo.BackColor = Color.Tomato
'            txtCantidadAbril.ReadOnly=True
'            txtCantidadAbril.BackColor = Color.Tomato
'            txtCantidadMayo.ReadOnly=True
'            txtCantidadMayo.BackColor = Color.Tomato
'            txtCantidadJunio.ReadOnly=True
'            txtCantidadJunio.BackColor = Color.Tomato
'            txtCantidadJulio.ReadOnly=True
'            txtCantidadJulio.BackColor = Color.Tomato
'            txtCantidadAgosto.ReadOnly=True
'            txtCantidadAgosto.BackColor = Color.Tomato
'            txtCantidadSeptiembre.ReadOnly=True
'            txtCantidadSeptiembre.BackColor = Color.Tomato
'            txtCantidadOctubre.ReadOnly=True
'            txtCantidadOctubre.BackColor = Color.Tomato
'            txtCantidadNoviembre.ReadOnly=True
'            txtCantidadNoviembre.BackColor = Color.Tomato

'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        Else
'            txtCantidadEnero.BackColor = Color.White
'            txtCantidadEnero.ReadOnly=False
'            txtCantidadFebrero.BackColor = Color.White
'            txtCantidadFebrero.ReadOnly=False
'            txtCantidadMarzo.BackColor = Color.White
'            txtCantidadMarzo.ReadOnly=False
'            txtCantidadAbril.BackColor = Color.White
'            txtCantidadAbril.ReadOnly=False
'            txtCantidadMayo.BackColor = Color.White
'            txtCantidadMayo.ReadOnly=False
'            txtCantidadJunio.BackColor = Color.White
'            txtCantidadJunio.ReadOnly=False
'            txtCantidadJulio.BackColor = Color.White
'            txtCantidadJulio.ReadOnly=False
'            txtCantidadAgosto.BackColor = Color.White
'            txtCantidadAgosto.ReadOnly=False
'            txtCantidadSeptiembre.BackColor = Color.White
'            txtCantidadSeptiembre.ReadOnly=False
'            txtCantidadOctubre.BackColor = Color.White
'            txtCantidadOctubre.ReadOnly=False
'            txtCantidadNoviembre.BackColor = Color.White
'            txtCantidadNoviembre.ReadOnly=False
'            txtCantidadDiciembre.BackColor = Color.White
'            txtCantidadDiciembre.ReadOnly=False
'        End If
'    End sub
'    Private Sub frmAsignar_Cantidad_CN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
'        If Not _Cancela Then Return
'        _Cancela=True
'    End Sub
'End Class