Imports System.Windows.Forms
Public Class frmConfigurar_Base
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim DT_Bases As New DataTable
    Dim Cadena_Conexion As String = ""
    Dim Servidor As String = ""
    Dim U_Conexion As String = ""
    Private Sub Radio_Nombre_Servidor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_Nombre_Servidor.CheckedChanged, Radio_IP_Servidor.CheckedChanged
        Me.TxtNombreServidor.Enabled = Radio_Nombre_Servidor.Checked
        Me.TxtIp1.Enabled = Radio_IP_Servidor.Checked
        Me.TxtIp2.Enabled = Radio_IP_Servidor.Checked
        Me.TxtIp3.Enabled = Radio_IP_Servidor.Checked
        Me.TxtIp4.Enabled = Radio_IP_Servidor.Checked
        Me.PictureBox2.Image = Me.PictureBox2.InitialImage
        Me.CmdProbar.Enabled = False
        Me.GrupoBaseDatos.Enabled = False
        Me.OK_Button.Enabled = False
        If Me.Radio_Nombre_Servidor.Checked Then
            Me.TxtIp1.Text = ""
            Me.TxtIp2.Text = ""
            Me.TxtIp3.Text = ""
            Me.TxtIp4.Text = ""
            Me.TxtNombreServidor.Focus()
        Else
            Me.TxtNombreServidor.Text = ""
            Me.TxtIp1.Focus()
        End If
        Ver()
    End Sub
    Private Sub TxtIp1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp1.GotFocus
        With Me.TxtIp1
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtIp2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp2.GotFocus
        With Me.TxtIp2
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtIp3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp3.GotFocus
        With Me.TxtIp3
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtIp4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp4.GotFocus
        With Me.TxtIp4
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtNombreServidor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombreServidor.GotFocus
        With Me.TxtNombreServidor
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtIp1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIp1.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then e.KeyChar = Chr(0)
        If Asc(e.KeyChar) = 13 Then Me.TxtIp2.Focus()
    End Sub
    Private Sub TxtIp2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIp2.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then e.KeyChar = Chr(0)
        If Asc(e.KeyChar) = 13 Then Me.TxtIp3.Focus()
    End Sub
    Private Sub TxtIp3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIp3.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then e.KeyChar = Chr(0)
        If Asc(e.KeyChar) = 13 Then Me.TxtIp4.Focus()
    End Sub
    Private Sub TxtIp4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIp4.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then e.KeyChar = Chr(0)
        If Asc(e.KeyChar) = 13 Then Me.CmdProbar.Focus()
    End Sub
    Private Sub TxtIp1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp1.TextChanged
        Ver()
        If Len(Trim(Me.TxtIp1.Text)) = 3 Then Me.TxtIp2.Focus()
    End Sub
    Private Sub TxtIp2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp2.TextChanged
        Ver()
        If Len(Trim(Me.TxtIp2.Text)) = 3 Then Me.TxtIp3.Focus()
    End Sub
    Private Sub TxtIp3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp3.TextChanged
        Ver()
        If Len(Trim(Me.TxtIp3.Text)) = 3 Then Me.TxtIp4.Focus()
    End Sub
    Private Sub TxtIp4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIp4.TextChanged
        Ver()
        If Len(Trim(Me.TxtIp4.Text)) = 3 Then Me.CmdProbar.Focus()
    End Sub
    Private Sub TxtNombreServidor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreServidor.KeyPress
        'e.KeyChar = UCase(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then Me.CmdProbar.Focus()
    End Sub
    Private Sub CmdProbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdProbar.Click
        Me.PictureBox2.Image = Me.PictureBox2.InitialImage
        If Me.TxtContraseña.Text <> Me.TxtContraseña_R.Text Then
            MsgBox("No coinciden las Contraseñas ingresadas", MsgBoxStyle.Exclamation, "Error al validar contraseñas")
            Me.TxtContraseña.Focus()
        Else

            Dim RS_Conexion As String = ""
            If Me.Radio_Nombre_Servidor.Checked Then
                Servidor = Me.TxtNombreServidor.Text
            Else
                Servidor = Me.TxtIp1.Text & "." & Me.TxtIp2.Text & "." & Me.TxtIp3.Text & "." & Me.TxtIp4.Text
            End If
            If Me.Radio_Usuario.Checked Then
                U_Conexion = "uid=" & Me.TxtUsuario.Text & ";pwd=" & Me.TxtContraseña.Text
            Else
                U_Conexion = "Integrated Security=SSPI"
            End If
            On Error GoTo No_Valido
            RS_Conexion = "Provider=SQLOLEDB;Data Source = " & Servidor & ";Initial Catalog=Master;" & U_Conexion
            Dim CN_P As New OleDb.OleDbConnection(RS_Conexion)
            Dim DA As New OleDb.OleDbDataAdapter("Select * from sysdatabases", CN_P)
            Dim DT As New DataTable
            DA.Fill(DT)
            Me.PictureBox2.Image = My.Resources.Aceptar
            Me.GrupoBaseDatos.Enabled = True
            Me.OK_Button.Enabled = True
            Dim I As Integer
            Me.CmbBase.Items.Clear()
            If DT.Rows.Count > 0 Then
                For I = 0 To DT.Rows.Count - 1
                    CmbBase.Items.Add(DT.Rows(I).Item("name"))
                Next I
            Else
                CmbBase.Items.Add("-----")
            End If
            CmbBase.SelectedIndex = 0
            CmbBase.Focus()
        End If
        Exit Sub
No_Valido:
        Me.PictureBox2.Image = My.Resources.Cerrar
        Me.GrupoBaseDatos.Enabled = False
        Me.OK_Button.Enabled = False
    End Sub
    Sub Ver()
        Dim Pase As Boolean = True
        If Me.Radio_Nombre_Servidor.Checked And Me.TxtNombreServidor.Text.Trim.Length = 0 Then Pase = False
        If Me.Radio_IP_Servidor.Checked And (Me.TxtIp1.Text.Trim.Length = 0 Or Me.TxtIp2.Text.Trim.Length = 0 Or Me.TxtIp3.Text.Trim.Length = 0 Or Me.TxtIp4.Text.Trim.Length = 0) Then Pase = False
        If Me.Radio_Usuario.Checked And (Me.TxtUsuario.Text.Trim.Length = 0 Or Me.TxtContraseña.Text.Trim.Length = 0 Or Me.TxtContraseña_R.Text.Trim.Length = 0) Then Pase = False
        Me.CmdProbar.Enabled = Pase
    End Sub
    Private Sub TxtNombreServidor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombreServidor.TextChanged
        Ver()
    End Sub
    Private Sub FrmConfigurarBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Me.PictureBox2.Image = Me.PictureBox2.InitialImage
        Me.TxtNombreServidor.Focus()
    End Sub
    Private Sub CmbBase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbBase.KeyPress
        If Asc(e.KeyChar) = 13 Then Me.OK_Button.Focus()
    End Sub

    Private Sub Radio_Windows_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_Windows.CheckedChanged, Radio_Usuario.CheckedChanged
        Me.TxtUsuario.Enabled = Me.Radio_Usuario.Checked
        Me.TxtContraseña.Enabled = Me.Radio_Usuario.Checked
        Me.TxtContraseña_R.Enabled = Me.Radio_Usuario.Checked
        If Radio_Windows.Checked Then
            Me.TxtUsuario.Text = ""
            Me.TxtContraseña.Text = ""
            Me.TxtContraseña_R.Text = ""
        Else
            Me.TxtUsuario.Focus()
        End If

    End Sub
    Private Sub TxtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUsuario.GotFocus
        With Me.TxtUsuario
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then Me.TxtContraseña.Focus()
    End Sub
    Private Sub TxtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuario.TextChanged
        Ver()
    End Sub
    Private Sub TxtContraseña_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtContraseña.GotFocus
        With Me.TxtContraseña
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then Me.TxtContraseña_R.Focus()
    End Sub
    Private Sub TxtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña.TextChanged
        Ver()
    End Sub
    Private Sub TxtContraseña_R_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtContraseña_R.GotFocus
        With Me.TxtContraseña_R
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub TxtContraseña_R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContraseña_R.KeyPress
        If Asc(e.KeyChar) = 13 Then Me.CmdProbar.Focus()
    End Sub
    Private Sub TxtContraseña_R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña_R.TextChanged
        Ver()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Cadena_Conexion = "Provider=SQLOLEDB;Data Source="
        Cadena_Conexion = Cadena_Conexion & " " & Servidor
        Cadena_Conexion = Cadena_Conexion & ";Initial Catalog="
        Cadena_Conexion = Cadena_Conexion & " " & Me.CmbBase.Text
        Cadena_Conexion = Cadena_Conexion & ";" & U_Conexion
        My.Settings.Conexion = Cadena_Conexion
        My.Settings.Server = Servidor
        My.Settings.User = Me.TxtUsuario.Text
        My.Settings.Password = Me.TxtContraseña.Text
        My.Settings.Save()
        MsgBox("La Configuración  a sido Grabada Correctamente, debes iniciar nuevamente el Sistema", MsgBoxStyle.Information, "Exito al Guardar Configuración")
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Finalize()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Cadena_Conexion = ""
        Me.Close()
    End Sub

    
End Class