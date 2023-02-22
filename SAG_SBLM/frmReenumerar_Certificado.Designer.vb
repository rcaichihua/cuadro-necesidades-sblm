<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReenumerar_Certificado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReenumerar_Certificado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAñoEjecucion = New System.Windows.Forms.TextBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.txtNumeroNuevo = New System.Windows.Forms.TextBox()
        Me.lblNuevo = New System.Windows.Forms.Label()
        Me.txtNumeroAnterior = New System.Windows.Forms.TextBox()
        Me.lblAnterior = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAñoEjecucion)
        Me.GroupBox1.Controls.Add(Me.lblAño)
        Me.GroupBox1.Controls.Add(Me.txtNumeroNuevo)
        Me.GroupBox1.Controls.Add(Me.lblNuevo)
        Me.GroupBox1.Controls.Add(Me.txtNumeroAnterior)
        Me.GroupBox1.Controls.Add(Me.lblAnterior)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Datos"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(197, 93)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(6, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Emisión:"
        '
        'txtAñoEjecucion
        '
        Me.txtAñoEjecucion.Location = New System.Drawing.Point(197, 15)
        Me.txtAñoEjecucion.MaxLength = 4
        Me.txtAñoEjecucion.Name = "txtAñoEjecucion"
        Me.txtAñoEjecucion.ReadOnly = true
        Me.txtAñoEjecucion.Size = New System.Drawing.Size(100, 20)
        Me.txtAñoEjecucion.TabIndex = 2
        '
        'lblAño
        '
        Me.lblAño.AutoSize = true
        Me.lblAño.Location = New System.Drawing.Point(6, 22)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(111, 13)
        Me.lblAño.TabIndex = 2
        Me.lblAño.Text = "Año de Ejecución:"
        '
        'txtNumeroNuevo
        '
        Me.txtNumeroNuevo.Location = New System.Drawing.Point(197, 67)
        Me.txtNumeroNuevo.MaxLength = 4
        Me.txtNumeroNuevo.Name = "txtNumeroNuevo"
        Me.txtNumeroNuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroNuevo.TabIndex = 0
        '
        'lblNuevo
        '
        Me.lblNuevo.AutoSize = true
        Me.lblNuevo.Location = New System.Drawing.Point(6, 70)
        Me.lblNuevo.Name = "lblNuevo"
        Me.lblNuevo.Size = New System.Drawing.Size(135, 13)
        Me.lblNuevo.TabIndex = 2
        Me.lblNuevo.Text = "Número de AM Nueva:"
        '
        'txtNumeroAnterior
        '
        Me.txtNumeroAnterior.Location = New System.Drawing.Point(197, 41)
        Me.txtNumeroAnterior.MaxLength = 4
        Me.txtNumeroAnterior.Name = "txtNumeroAnterior"
        Me.txtNumeroAnterior.ReadOnly = true
        Me.txtNumeroAnterior.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroAnterior.TabIndex = 2
        '
        'lblAnterior
        '
        Me.lblAnterior.AutoSize = true
        Me.lblAnterior.Location = New System.Drawing.Point(6, 44)
        Me.lblAnterior.Name = "lblAnterior"
        Me.lblAnterior.Size = New System.Drawing.Size(148, 13)
        Me.lblAnterior.TabIndex = 2
        Me.lblAnterior.Text = "Número de CCP Anterior:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(221, 170)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 44)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAceptar.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(117, 170)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 44)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = true
        Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkFecha.Location = New System.Drawing.Point(21, 145)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(146, 17)
        Me.chkFecha.TabIndex = 8
        Me.chkFecha.Text = "Modificar Solo Fecha"
        Me.chkFecha.UseVisualStyleBackColor = true
        '
        'frmReenumerar_Certificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 218)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmReenumerar_Certificado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Reenumerar AM ::.."
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAñoEjecucion As System.Windows.Forms.TextBox
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents txtNumeroNuevo As System.Windows.Forms.TextBox
    Friend WithEvents lblNuevo As System.Windows.Forms.Label
    Friend WithEvents txtNumeroAnterior As System.Windows.Forms.TextBox
    Friend WithEvents lblAnterior As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
End Class
