<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurar_Base
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigurar_Base))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grupo_Autentificacion = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtContraseña_R = New System.Windows.Forms.TextBox
        Me.TxtContraseña = New System.Windows.Forms.TextBox
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.Radio_Usuario = New System.Windows.Forms.RadioButton
        Me.Radio_Windows = New System.Windows.Forms.RadioButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtIp4 = New System.Windows.Forms.TextBox
        Me.TxtIp3 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtIp2 = New System.Windows.Forms.TextBox
        Me.TxtIp1 = New System.Windows.Forms.TextBox
        Me.TxtNombreServidor = New System.Windows.Forms.TextBox
        Me.Radio_IP_Servidor = New System.Windows.Forms.RadioButton
        Me.Radio_Nombre_Servidor = New System.Windows.Forms.RadioButton
        Me.CmbBase = New System.Windows.Forms.ComboBox
        Me.CmdProbar = New System.Windows.Forms.Button
        Me.GrupoBaseDatos = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Grupo_Autentificacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrupoBaseDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(90, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Repita Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(90, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña:"
        '
        'Grupo_Autentificacion
        '
        Me.Grupo_Autentificacion.Controls.Add(Me.Label5)
        Me.Grupo_Autentificacion.Controls.Add(Me.Label4)
        Me.Grupo_Autentificacion.Controls.Add(Me.Label3)
        Me.Grupo_Autentificacion.Controls.Add(Me.TxtContraseña_R)
        Me.Grupo_Autentificacion.Controls.Add(Me.TxtContraseña)
        Me.Grupo_Autentificacion.Controls.Add(Me.TxtUsuario)
        Me.Grupo_Autentificacion.Controls.Add(Me.Radio_Usuario)
        Me.Grupo_Autentificacion.Controls.Add(Me.Radio_Windows)
        Me.Grupo_Autentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo_Autentificacion.ForeColor = System.Drawing.Color.Black
        Me.Grupo_Autentificacion.Location = New System.Drawing.Point(297, 98)
        Me.Grupo_Autentificacion.Name = "Grupo_Autentificacion"
        Me.Grupo_Autentificacion.Size = New System.Drawing.Size(356, 166)
        Me.Grupo_Autentificacion.TabIndex = 8
        Me.Grupo_Autentificacion.TabStop = False
        Me.Grupo_Autentificacion.Text = "Tipo de Autentificación de Usuarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(90, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario:"
        '
        'TxtContraseña_R
        '
        Me.TxtContraseña_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña_R.Location = New System.Drawing.Point(188, 130)
        Me.TxtContraseña_R.Name = "TxtContraseña_R"
        Me.TxtContraseña_R.Size = New System.Drawing.Size(160, 20)
        Me.TxtContraseña_R.TabIndex = 4
        Me.TxtContraseña_R.UseSystemPasswordChar = True
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(188, 105)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(160, 20)
        Me.TxtContraseña.TabIndex = 3
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(188, 80)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(160, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'Radio_Usuario
        '
        Me.Radio_Usuario.AutoSize = True
        Me.Radio_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Usuario.ForeColor = System.Drawing.Color.Black
        Me.Radio_Usuario.Location = New System.Drawing.Point(10, 53)
        Me.Radio_Usuario.Name = "Radio_Usuario"
        Me.Radio_Usuario.Size = New System.Drawing.Size(163, 17)
        Me.Radio_Usuario.TabIndex = 1
        Me.Radio_Usuario.Text = "Por Usuario del Servidor SQL"
        Me.Radio_Usuario.UseVisualStyleBackColor = True
        '
        'Radio_Windows
        '
        Me.Radio_Windows.AutoSize = True
        Me.Radio_Windows.Checked = True
        Me.Radio_Windows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Windows.ForeColor = System.Drawing.Color.Black
        Me.Radio_Windows.Location = New System.Drawing.Point(10, 25)
        Me.Radio_Windows.Name = "Radio_Windows"
        Me.Radio_Windows.Size = New System.Drawing.Size(161, 17)
        Me.Radio_Windows.TabIndex = 0
        Me.Radio_Windows.TabStop = True
        Me.Radio_Windows.Text = "Por Autentificación Windows"
        Me.Radio_Windows.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre de la Base de Datos:"
        '
        'TxtIp4
        '
        Me.TxtIp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIp4.Location = New System.Drawing.Point(311, 50)
        Me.TxtIp4.MaxLength = 3
        Me.TxtIp4.Name = "TxtIp4"
        Me.TxtIp4.Size = New System.Drawing.Size(37, 20)
        Me.TxtIp4.TabIndex = 6
        Me.TxtIp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIp3
        '
        Me.TxtIp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIp3.Location = New System.Drawing.Point(270, 50)
        Me.TxtIp3.MaxLength = 3
        Me.TxtIp3.Name = "TxtIp3"
        Me.TxtIp3.Size = New System.Drawing.Size(37, 20)
        Me.TxtIp3.TabIndex = 5
        Me.TxtIp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIp4)
        Me.GroupBox1.Controls.Add(Me.TxtIp3)
        Me.GroupBox1.Controls.Add(Me.TxtIp2)
        Me.GroupBox1.Controls.Add(Me.TxtIp1)
        Me.GroupBox1.Controls.Add(Me.TxtNombreServidor)
        Me.GroupBox1.Controls.Add(Me.Radio_IP_Servidor)
        Me.GroupBox1.Controls.Add(Me.Radio_Nombre_Servidor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(297, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 85)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Conexión al Servidor"
        '
        'TxtIp2
        '
        Me.TxtIp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIp2.Location = New System.Drawing.Point(229, 50)
        Me.TxtIp2.MaxLength = 3
        Me.TxtIp2.Name = "TxtIp2"
        Me.TxtIp2.Size = New System.Drawing.Size(37, 20)
        Me.TxtIp2.TabIndex = 4
        Me.TxtIp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIp1
        '
        Me.TxtIp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIp1.Location = New System.Drawing.Point(188, 50)
        Me.TxtIp1.MaxLength = 3
        Me.TxtIp1.Name = "TxtIp1"
        Me.TxtIp1.Size = New System.Drawing.Size(37, 20)
        Me.TxtIp1.TabIndex = 3
        Me.TxtIp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreServidor
        '
        Me.TxtNombreServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreServidor.Location = New System.Drawing.Point(188, 25)
        Me.TxtNombreServidor.Name = "TxtNombreServidor"
        Me.TxtNombreServidor.Size = New System.Drawing.Size(160, 20)
        Me.TxtNombreServidor.TabIndex = 0
        '
        'Radio_IP_Servidor
        '
        Me.Radio_IP_Servidor.AutoSize = True
        Me.Radio_IP_Servidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_IP_Servidor.ForeColor = System.Drawing.Color.Black
        Me.Radio_IP_Servidor.Location = New System.Drawing.Point(10, 53)
        Me.Radio_IP_Servidor.Name = "Radio_IP_Servidor"
        Me.Radio_IP_Servidor.Size = New System.Drawing.Size(173, 17)
        Me.Radio_IP_Servidor.TabIndex = 2
        Me.Radio_IP_Servidor.Text = "Número de IP del Servidor SQL"
        Me.Radio_IP_Servidor.UseVisualStyleBackColor = True
        '
        'Radio_Nombre_Servidor
        '
        Me.Radio_Nombre_Servidor.AutoSize = True
        Me.Radio_Nombre_Servidor.Checked = True
        Me.Radio_Nombre_Servidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Nombre_Servidor.ForeColor = System.Drawing.Color.Black
        Me.Radio_Nombre_Servidor.Location = New System.Drawing.Point(10, 25)
        Me.Radio_Nombre_Servidor.Name = "Radio_Nombre_Servidor"
        Me.Radio_Nombre_Servidor.Size = New System.Drawing.Size(145, 17)
        Me.Radio_Nombre_Servidor.TabIndex = 1
        Me.Radio_Nombre_Servidor.TabStop = True
        Me.Radio_Nombre_Servidor.Text = "Nombre del Servidor SQL"
        Me.Radio_Nombre_Servidor.UseVisualStyleBackColor = True
        '
        'CmbBase
        '
        Me.CmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBase.FormattingEnabled = True
        Me.CmbBase.Location = New System.Drawing.Point(188, 25)
        Me.CmbBase.Name = "CmbBase"
        Me.CmbBase.Size = New System.Drawing.Size(160, 21)
        Me.CmbBase.TabIndex = 0
        '
        'CmdProbar
        '
        Me.CmdProbar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdProbar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdProbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdProbar.ForeColor = System.Drawing.Color.Black
        Me.CmdProbar.Location = New System.Drawing.Point(297, 276)
        Me.CmdProbar.Name = "CmdProbar"
        Me.CmdProbar.Size = New System.Drawing.Size(313, 25)
        Me.CmdProbar.TabIndex = 9
        Me.CmdProbar.Text = "Probar Conexión al Servidor"
        Me.CmdProbar.UseVisualStyleBackColor = False
        '
        'GrupoBaseDatos
        '
        Me.GrupoBaseDatos.Controls.Add(Me.Label2)
        Me.GrupoBaseDatos.Controls.Add(Me.CmbBase)
        Me.GrupoBaseDatos.Enabled = False
        Me.GrupoBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoBaseDatos.ForeColor = System.Drawing.Color.Black
        Me.GrupoBaseDatos.Location = New System.Drawing.Point(297, 314)
        Me.GrupoBaseDatos.Name = "GrupoBaseDatos"
        Me.GrupoBaseDatos.Size = New System.Drawing.Size(356, 65)
        Me.GrupoBaseDatos.TabIndex = 10
        Me.GrupoBaseDatos.TabStop = False
        Me.GrupoBaseDatos.Text = "Base de Datos y  Ruta de Acceso"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAG_SBLM.My.Resources.Resources.databaseIII
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 448)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(555, 393)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 44)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(451, 393)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(98, 44)
        Me.OK_Button.TabIndex = 14
        Me.OK_Button.Text = "&Aceptar"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(618, 270)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'frmConfigurar_Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 440)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Grupo_Autentificacion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdProbar)
        Me.Controls.Add(Me.GrupoBaseDatos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigurar_Base"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Configuración de Bases de Datos ::.."
        Me.Grupo_Autentificacion.ResumeLayout(False)
        Me.Grupo_Autentificacion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrupoBaseDatos.ResumeLayout(False)
        Me.GrupoBaseDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grupo_Autentificacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtContraseña_R As System.Windows.Forms.TextBox
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Radio_Usuario As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_Windows As System.Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtIp4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtIp3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtIp2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtIp1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreServidor As System.Windows.Forms.TextBox
    Friend WithEvents Radio_IP_Servidor As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_Nombre_Servidor As System.Windows.Forms.RadioButton
    Friend WithEvents CmbBase As System.Windows.Forms.ComboBox
    Friend WithEvents CmdProbar As System.Windows.Forms.Button
    Friend WithEvents GrupoBaseDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
