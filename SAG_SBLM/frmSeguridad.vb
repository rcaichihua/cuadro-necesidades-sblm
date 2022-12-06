Imports System.Deployment.Application
Public Class frmSeguridad
    Dim Año As New DataTable
    Dim Datos As New Mantenimiento
    Private Sub frmSeguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'My.Settings.Reset()
        If My.Settings.Conexion.Length = 0 Then
            Dim Formulario As New frmConfigurar_Base
            Formulario.ShowDialog()
        Else
            Dim Datos As New Mantenimiento
            Año = Datos.LLenar_Combo_Solo("Select * From Año", Me.cbAño, "Año_Ejecucion")
            Me.cbAño.Text = Year(Now).ToString
            Me.Text = "..:: Seguridad del Sistema ::.." & Me.VersionAplicacion
        End If
    End Sub
    Function VersionAplicacion() As String
        'muestra versión de la aplicacion
        If My.Application.IsNetworkDeployed Then
            Dim ver As System.Deployment.Application.ApplicationDeployment
            ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment
            Return " - Versión de Compilación: " & ver.CurrentVersion.ToString & " - "
        Else
            Return " - No se encontro Versión - "
        End If
    End Function
    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Me.txtUsuario.Text.Trim.Length > 0 Then
            If e.KeyChar = Chr(13) Then
                Me.txtPassword.Focus()
            End If
        End If
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Me.txtPassword.Text.Trim.Length > 0 Then
            If e.KeyChar = Chr(13) Then
                Me.cbAño.Focus()
            End If
        End If
    End Sub
    Private Sub cbAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbAño.KeyPress
        If Me.cbAño.Text.Trim.Length > 0 Then
            If e.KeyChar = Chr(13) Then
                Call Me.btnAceptar_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If My.Settings.Conexion.Trim.Length > 0 Then
            If Me.txtUsuario.Text.Trim.Length > 0 Then
                If Me.txtPassword.Text.Trim.Length > 0 Then
                    If Me.cbAño.Text.Trim.Length > 0 Then
                        Dim Datos As New Mantenimiento
                        If Datos.Verificar_Clave(Me.txtUsuario.Text.Trim, Datos.Encriptar(Me.txtPassword.Text.Trim)) = True Then
                            If Datos.Verificar_Usuario_Activo(Me.txtUsuario.Text.Trim, Datos.Encriptar(Me.txtPassword.Text.Trim)) = True Then
                                My.Settings.Nombre_Usuario = Datos.Obtener_Nombre_Usuario(Me.txtUsuario.Text.Trim)
                                My.Settings.Usuario = Me.txtUsuario.Text.Trim
                                My.Settings.Año_Ejecucion = Me.cbAño.Text
                                My.Settings.Save()
                                Dim Formulario As New frmMenu
                                Formulario.Show()
                                Me.Finalize()
                            Else
                                MessageBox.Show("El Usuario se encuentra Inactivo, coordinar con el Administrador del Sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtUsuario.Text = ""
                                Me.txtPassword.Text = ""
                                Me.txtUsuario.Focus()
                            End If
                        Else
                            MessageBox.Show("Los datos ingresados no son los correctos, por favor verifiquelos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtUsuario.Text = ""
                            Me.txtPassword.Text = ""
                            Me.txtUsuario.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes Seleccionar el Año y/o Periodo Activo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.cbAño.Focus()
                    End If
                Else
                    MessageBox.Show("Debes ingresar el passoword o contraseña", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtPassword.Focus()
                End If
            Else
                MessageBox.Show("Debes ingresar el Usurio para iniciar sesión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtUsuario.Focus()
            End If
        Else
            If My.Settings.Conexion.Length = 0 Then
                Dim Formulario As New frmConfigurar_Base
                Formulario.ShowDialog()
            Else
                Dim Datos As New Mantenimiento
                Año = Datos.LLenar_Combo_Solo("Select * From Año", Me.cbAño, "Año_Ejecucion")
                Me.cbAño.Text = Year(Now).ToString
            End If
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class
