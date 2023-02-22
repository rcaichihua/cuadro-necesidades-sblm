Public Class frmReenumerar_Certificado
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Public Operacion As Integer = 0
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.chkFecha.Checked = True Then
            If Me.txtNumeroNuevo.Text.Trim.Length > 0 Then
                Select Case Operacion
                    Case 1
                        If Datos.Valida_Fecha_Presupuesto_Documentos_Reenumeracion(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Operacion, DateValue(Me.DateTimePicker1.Value)) = True Then
                            Datos.Cambiar_Fecha_Documento_Presupuesto(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, DateValue(Me.DateTimePicker1.Value), 1)
                            Me.Close()
                        Else
                            MessageBox.Show("Existe un Error de Consistencia en la Fecha de Emisión Seleccionada, Favor de Revisar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.DateTimePicker1.Focus()
                        End If
                End Select
            Else
                MessageBox.Show("Debes Ingresar el Nuevo Número a Asignar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtNumeroNuevo.Focus()
            End If
        Else
            If Me.txtNumeroNuevo.Text.Trim.Length > 0 Then
                Select Case Operacion
                    Case 1
                        If Datos.Valida_Fecha_Presupuesto_Documentos_Reenumeracion(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Operacion, DateValue(Me.DateTimePicker1.Value)) = True Then
                            Datos.Reenumerar_Documentos_Presupuesto(My.Settings.Año_Ejecucion, Microsoft.VisualBasic.Right("0000" & Me.txtNumeroNuevo.Text.Trim, 4), Me.txtNumeroAnterior.Text.Trim, 1, DateValue(Me.DateTimePicker1.Value))
                            Me.Close()
                        Else
                            MessageBox.Show("Existe un Error de Consistencia en la Fecha de Emisión Seleccionada, Favor de Revisar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.DateTimePicker1.Focus()
                        End If
                End Select
            Else
                MessageBox.Show("Debes Ingresar el Nuevo Número a Asignar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtNumeroNuevo.Focus()
            End If
        End If

    End Sub
    Private Sub frmReenumerar_Certificado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Select Case Operacion
            Case 1
                Me.txtAñoEjecucion.Text = My.Settings.Año_Ejecucion
                Me.txtNumeroAnterior.Text = Variable_Numero_Accion_Modificatoria
                Me.txtNumeroNuevo.Focus()
                Me.DateTimePicker1.MinDate = New DateTime(Convert.ToDouble(My.Settings.Año_Ejecucion.ToString), 1, 2)
                Me.DateTimePicker1.MaxDate = New DateTime(Convert.ToDouble(My.Settings.Año_Ejecucion.ToString), 12, 31)
                Me.lblAnterior.Text = "Número de Nota Anterior:"
                Me.lblNuevo.Text = "Número de Nota Nuevo:"
                Me.Text = "..:: Reenumerar Nota Modificatoria Presupuestal ::.."
        End Select
    End Sub
    Private Sub txtNumeroNuevo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroNuevo.KeyPress
        If InStr(1, "0123456789" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        If e.KeyChar = Chr(13) And Me.txtNumeroNuevo.Text.Trim.Length > 0 Then Call btnAceptar_Click(sender, e)
    End Sub
    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If Me.chkFecha.Checked = True Then
            Me.txtNumeroNuevo.ReadOnly = True
            Me.txtNumeroNuevo.Text = Me.txtNumeroAnterior.Text
        Else
            Me.txtNumeroNuevo.ReadOnly = False
            Me.txtNumeroNuevo.Text = String.Empty
        End If
    End Sub
End Class