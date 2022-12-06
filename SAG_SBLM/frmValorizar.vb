Public Class frmValorizar
    Inherits DevComponents.DotNetBar.Office2007Form
    Public Operacion As Integer = 0
    Dim Datos As New Mantenimiento
    Dim Separador As Char
    Private Sub frmValorizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Select Case Operacion
            Case 1
                Me.gbCatalogo.Text = "..:: Catálogo de Bienes ::.."
                If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
                    Datos.Mostrar_Data_Item_Catalogo(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, 1, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
                    Me.txtCantidadSolicitada.Text = Format(Variable_Cantidad_Maxima_Disponible, "###,###,#.00000")
                    Me.txtCantidadAdquirir.Text = Format(Variable_Cantidad_Despachar, "###,###,#.00000")
                    Me.txtCostoUnitario.Text = Format(Variable_Precio_Unitario, "###,###,#.00000")
                    Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                End If
            Case 2
                Me.gbCatalogo.Text = "..:: Catálogo de Servicios ::.."
                If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
                    Datos.Mostrar_Data_Item_Catalogo(Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, 2, Me.txtCodigoGrupo, Me.txtGrupo, Me.txtCodigoClase, Me.txtClase, Me.txtCodigoFamilia, Me.txtFamilia, Me.txtCodigoItem, Me.txtItem, Me.txtCodigoUnidadMedida, Me.txtUnidadMedida, Me.txtTipoTransaccion, Me.txtGenerica, Me.txtSubGenerica, Me.txtSubGenericaDetalle, Me.txtEspecifica, Me.txtEspecificaDetalle)
                    Me.txtCantidadSolicitada.Text = Format(Variable_Cantidad_Maxima_Disponible, "###,###,#.00000")
                    Me.txtCantidadAdquirir.Text = Format(Variable_Cantidad_Despachar, "###,###,#.00000")
                    Me.txtCostoUnitario.Text = Format(Variable_Precio_Unitario, "###,###,#.00000")
                    Separador = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                End If

        End Select
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Cantidad_Despachar = 0
        Variable_Precio_Unitario = 0
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Convert.ToDouble(Me.txtCantidadAdquirir.Text) > 0 Then
            If Convert.ToDouble(Me.txtCostoUnitario.Text) > 0 Then
                If Convert.ToDouble(Me.txtCantidadSolicitada.Text) >= Convert.ToDouble(Me.txtCantidadAdquirir.Text) Then
                    Variable_Cantidad_Despachar = Convert.ToDouble(Me.txtCantidadAdquirir.Text)
                    Variable_Precio_Unitario = Convert.ToDouble(Me.txtCostoUnitario.Text)
                    Me.Close()
                Else
                    MessageBox.Show("No se puede Despachar más Productos de los Solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.txtCantidadAdquirir.Focus()
                End If
            Else
                MessageBox.Show("Debes Ingresar el Costo Unitario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.txtCostoUnitario.Focus()
            End If
        Else
            MessageBox.Show("Debes Ingresar la Cantidad a Adquirir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.txtCantidadAdquirir.Focus()
        End If
    End Sub
    Private Sub txtCantidadAdquirir_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAdquirir.Enter
        txtCantidadAdquirir.SelectionStart = 0
        txtCantidadAdquirir.SelectionLength = txtCantidadAdquirir.Text.Length
    End Sub
    Private Sub txtCantidadAdquirir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAdquirir.GotFocus
        txtCantidadAdquirir.SelectionStart = 0
        txtCantidadAdquirir.SelectionLength = txtCantidadAdquirir.Text.Length
    End Sub
    Private Sub txtCantidadAdquirir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadAdquirir.KeyPress
        If txtCantidadAdquirir.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            Me.txtCostoUnitario.Focus()
        End If
    End Sub
    Private Sub txtCantidadAdquirir_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAdquirir.Leave
        Select Case Operacion
            Case 1
                If Me.txtCantidadAdquirir.Text.Trim.Length > 0 Then
                    Me.txtCantidadAdquirir.Text = FormatNumber(txtCantidadAdquirir.Text, 5, , , TriState.True)
                Else
                    Me.txtCantidadAdquirir.Text = "0.00000"
                End If
            Case 2
                If Me.txtCantidadAdquirir.Text.Trim.Length > 0 Then
                    Me.txtCantidadAdquirir.Text = FormatNumber(txtCantidadAdquirir.Text, 5, , , TriState.True)
                Else
                    Me.txtCantidadAdquirir.Text = "0.00000"
                End If
        End Select
    End Sub
    Private Sub txtCantidadAdquirir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadAdquirir.LostFocus
        Select Case Operacion
            Case 1
                With Me.txtCantidadAdquirir
                    If Len(Trim(.Text)) = 0 Then .Text = 0
                    .Text = FormatNumber(.Text, 5, , , TriState.True)
                End With
            Case 2
                With Me.txtCantidadAdquirir
                    If Len(Trim(.Text)) = 0 Then .Text = 0
                    .Text = FormatNumber(.Text, 5, , , TriState.True)
                End With
        End Select
    End Sub
    Private Sub txtCostoUnitario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoUnitario.Enter
        txtCostoUnitario.SelectionStart = 0
        txtCostoUnitario.SelectionLength = txtCostoUnitario.Text.Length
    End Sub
    Private Sub txtCostoUnitario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoUnitario.GotFocus
        txtCostoUnitario.SelectionStart = 0
        txtCostoUnitario.SelectionLength = txtCostoUnitario.Text.Length
    End Sub
    Private Sub txtCostoUnitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoUnitario.KeyPress
        If txtCostoUnitario.Text.IndexOf(".") <> -1 And Asc(e.KeyChar) = 46 Then e.KeyChar = Chr(0)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 46 Then e.KeyChar = Chr(0)
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Separador) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            Call Me.btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub txtCostoUnitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoUnitario.Leave
        Select Case Operacion
            Case 1
                If Me.txtCostoUnitario.Text.Trim.Length > 0 Then
                    Me.txtCostoUnitario.Text = FormatNumber(txtCostoUnitario.Text, 5, , , TriState.True)
                Else
                    Me.txtCostoUnitario.Text = "0.00000"
                End If
            Case 2
                If Me.txtCostoUnitario.Text.Trim.Length > 0 Then
                    Me.txtCostoUnitario.Text = FormatNumber(txtCostoUnitario.Text, 5, , , TriState.True)
                Else
                    Me.txtCostoUnitario.Text = "0.00000"
                End If
        End Select
    End Sub
    Private Sub txtCostoUnitario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoUnitario.LostFocus
        Select Case Operacion
            Case 1
                With Me.txtCostoUnitario
                    If Len(Trim(.Text)) = 0 Then .Text = 0
                    .Text = FormatNumber(.Text, 5, , , TriState.True)
                End With
            Case 2
                With Me.txtCostoUnitario
                    If Len(Trim(.Text)) = 0 Then .Text = 0
                    .Text = FormatNumber(.Text, 5, , , TriState.True)
                End With
        End Select
    End Sub
End Class