<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguridad
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguridad))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAño = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbAño)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(61, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        '
        'cbAño
        '
        Me.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAño.FormattingEnabled = true
        Me.cbAño.Location = New System.Drawing.Point(89, 65)
        Me.cbAño.Name = "cbAño"
        Me.cbAño.Size = New System.Drawing.Size(79, 21)
        Me.cbAño.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Año Fiscal:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(89, 39)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txtPassword.Size = New System.Drawing.Size(218, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(89, 13)
        Me.txtUsuario.MaxLength = 30
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(218, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAceptar.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(6, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 44)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = false
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(110, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 44)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = false
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(157, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 63)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = false
        '
        'frmSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SAG_SBLM.My.Resources.Resources.Login_SAB
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(672, 438)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmSeguridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Seguridad del Sistema ::.."
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
