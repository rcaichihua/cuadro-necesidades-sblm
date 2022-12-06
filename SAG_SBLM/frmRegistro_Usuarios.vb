Public Class frmRegistro_Usuarios
    Inherits DevComponents.DotNetBar.Office2007Form
    Public Editar As Boolean = False
    Dim Tipo As New DataTable
    Dim Datos As New Mantenimiento
    Private Sub frmRegistro_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        If Editar = True Then
            Tipo = Datos.LLenar_Combo_Solo("Select * From Tipo_Usuario", Me.cbTipo_Usuario, "Descripcion")
            Datos.Cargar_Datos_Usuarios(Variable_Codigo_Usuario, , Me.cbTipo_Usuario, Me.txtApellidos, Me.txtNombres, Me.txtUsuario, Me.chkActivo)
        Else
            Tipo = Datos.LLenar_Combo_Solo("Select * From Tipo_Usuario", Me.cbTipo_Usuario, "Descripcion")
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Editar = False Then
            If Me.cbTipo_Usuario.Text.Trim.Length > 0 Then
                If Me.txtApellidos.Text.Trim.Length > 0 Then
                    If Me.txtNombres.Text.Trim.Length > 0 Then
                        If Me.txtUsuario.Text.Trim.Length > 0 Then
                            If Me.txtPassword.Text.Trim.Length > 0 Then
                                If Me.txtPassword2.Text.Trim.Length > 0 Then
                                    If Me.txtPassword.Text.Trim = Me.txtPassword2.Text.Trim Then
                                        If Datos.Verificar_Duplicidad_Usuario(Me.txtUsuario.Text.Trim, True) = True Then
                                            Dim Codigo As String = Datos.Generar_Numero_Usuario
                                            Datos.Nuevo_Usuario(Codigo, Tipo.Rows(Me.cbTipo_Usuario.SelectedIndex).Item("Codigo_Tipo_Usuario").ToString, Me.txtApellidos.Text.Trim, Me.txtNombres.Text.Trim, Me.txtUsuario.Text.Trim, Datos.Encriptar(Me.txtPassword.Text.Trim), Me.chkActivo.Checked)
                                            Me.Close()
                                        Else
                                            MessageBox.Show("Ya Existe el Usuario: " & Me.txtUsuario.Text.Trim & "; Favor de Verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                            Me.txtUsuario.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Las Contraseñas no Coinciden, favor de corregir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtPassword.Text = ""
                                        Me.txtPassword2.Text = ""
                                        Me.txtPassword.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes Confirmar la Contraseña del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    Me.txtPassword2.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes Ingresar la Contraseña del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtPassword.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes Ingresar el Usuario que se Usará para el acceso al Sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtUsuario.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes Ingresar los Nombres del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtNombres.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar los Apellidos del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtApellidos.Focus()
                End If
            Else
                MessageBox.Show("Debes Seleccionar el Tipo de Usuario a Crear", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.cbTipo_Usuario.Focus()
            End If
        Else
            If Me.cbTipo_Usuario.Text.Trim.Length > 0 Then
                If Me.txtApellidos.Text.Trim.Length > 0 Then
                    If Me.txtNombres.Text.Trim.Length > 0 Then
                        If Me.txtUsuario.Text.Trim.Length > 0 Then
                            If Me.txtPassword.Text.Trim.Length > 0 Then
                                If Me.txtPassword2.Text.Trim.Length > 0 Then
                                    If Me.txtPassword.Text.Trim = Me.txtPassword2.Text.Trim Then
                                        If Datos.Verificar_Duplicidad_Usuario(Me.txtUsuario.Text.Trim, False, Variable_Codigo_Usuario) = True Then
                                            Datos.Modificar_Usuario(Variable_Codigo_Usuario, Tipo.Rows(Me.cbTipo_Usuario.SelectedIndex).Item("Codigo_Tipo_Usuario").ToString, Me.txtApellidos.Text.Trim, Me.txtNombres.Text.Trim, Me.txtUsuario.Text.Trim, Datos.Encriptar(Me.txtPassword.Text.Trim), Me.chkActivo.Checked)
                                            Me.Close()
                                        Else
                                            MessageBox.Show("El Usuario: " & Me.txtUsuario.Text.Trim & "; Pertenece a Otro ID, Favor de Verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                            Me.txtUsuario.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Las Contraseñas no Coinciden, favor de corregir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                        Me.txtPassword.Text = ""
                                        Me.txtPassword2.Text = ""
                                        Me.txtPassword.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes Confirmar la Contraseña del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    Me.txtPassword2.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes Ingresar la Contraseña del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtPassword.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes Ingresar el Usuario que se Usará para el acceso al Sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtUsuario.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes Ingresar los Nombres del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Me.txtNombres.Focus()
                    End If
                Else
                    MessageBox.Show("Debes Ingresar los Apellidos del Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtApellidos.Focus()
                End If
            Else
                MessageBox.Show("Debes Seleccionar el Tipo de Usuario a Crear", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.cbTipo_Usuario.Focus()
            End If
        End If
    End Sub
End Class