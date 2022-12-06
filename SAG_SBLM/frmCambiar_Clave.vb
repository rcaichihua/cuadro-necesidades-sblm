Public Class frmCambiar_Clave
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub frmCambiar_Clave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Datos.Cargar_Data_Modificacion_Clave(My.Settings.Usuario, Me.txtApellidos, Me.txtNombres, Me.txtUsuario)
        Me.txtPasswordAnterior.Focus()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.txtPasswordAnterior.Text.Trim.Length > 0 Then
            If Datos.Verificar_Clave(Me.txtUsuario.Text.Trim, Datos.Encriptar(Me.txtPasswordAnterior.Text.Trim)) = True Then
                If Me.txtPasswordNuevo.Text.Length > 0 Then
                    If Me.txtConfirmarPassword.Text.Trim.Length > 0 Then
                        If Me.txtPasswordNuevo.Text.Trim = Me.txtConfirmarPassword.Text.Trim Then
                            Datos.Cambiar_Clave(My.Settings.Usuario, Datos.Encriptar(Me.txtConfirmarPassword.Text.Trim))
                            MessageBox.Show("Se ha Cambiado con Exito la Clave del Usuario: " & My.Settings.Usuario.Trim, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.Close()
                        Else
                            MessageBox.Show("La Contraseña Nueva no Coincide con la Confirmación de la Misma", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtConfirmarPassword.Text = ""
                            Me.txtPasswordNuevo.Text = ""
                            Me.txtPasswordNuevo.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes Repetir la nueva contraseña", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtConfirmarPassword.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar la nueva contraseña", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtPasswordNuevo.Focus()
                End If
            Else
                MessageBox.Show("La Clave ingresada es Incorrecta, Intentelo nuevamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtPasswordAnterior.Text = ""
                Me.txtPasswordAnterior.Focus()
            End If
        Else
            MessageBox.Show("Debes ingresar la clave actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.txtPasswordAnterior.Focus()
        End If
    End Sub
End Class