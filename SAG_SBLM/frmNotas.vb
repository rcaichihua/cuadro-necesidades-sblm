Public Class frmNotas
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Notas = ""
        Me.Close()
    End Sub
    Private Sub txtNotas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotas.TextChanged
        If Me.txtNotas.Text.Trim.Length > 0 Then
            Me.lblDisponibles.Text = "Caracteres Disponibles: " & Me.txtNotas.MaxLength - Me.txtNotas.Text.Trim.Length
            Me.lblUsados.Text = "Caracteres Usuados: " & Me.txtNotas.Text.Trim.Length
        Else
            Me.lblDisponibles.Text = "Caracteres Disponibles: " & Me.txtNotas.MaxLength
            Me.lblUsados.Text = "Caracteres Usados: 0"
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Variable_Notas = Me.txtNotas.Text.Trim
        Me.Close()
    End Sub
    Private Sub frmNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        If Variable_Notas.Trim.Length > 0 Then
            Me.txtNotas.Text = Variable_Notas
        End If
    End Sub
End Class