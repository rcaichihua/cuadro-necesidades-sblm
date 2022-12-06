<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro_Unidad_Organica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro_Unidad_Organica))
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.gbDatos = New System.Windows.Forms.GroupBox
        Me.gbCajaChica = New System.Windows.Forms.GroupBox
        Me.txtBuscarSuplente = New System.Windows.Forms.Button
        Me.btnBuscarTitular = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtProveedor02 = New System.Windows.Forms.TextBox
        Me.txtCodigoProveedor02 = New System.Windows.Forms.TextBox
        Me.txtProveedor01 = New System.Windows.Forms.TextBox
        Me.txtCodigoProveedor01 = New System.Windows.Forms.TextBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.txtCorrelativo = New System.Windows.Forms.TextBox
        Me.txtResolucion = New System.Windows.Forms.TextBox
        Me.txtCodigoPartida = New System.Windows.Forms.TextBox
        Me.chkCaja = New System.Windows.Forms.CheckBox
        Me.txtAbreviatura = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtAño = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbOpciones.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.gbCajaChica.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnCancelar)
        Me.gbOpciones.Controls.Add(Me.btnGuardar)
        Me.gbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.Location = New System.Drawing.Point(337, 341)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(216, 61)
        Me.gbOpciones.TabIndex = 3
        Me.gbOpciones.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(110, 11)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 44)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Reporte_Servicios
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(6, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 44)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.gbCajaChica)
        Me.gbDatos.Controls.Add(Me.chkCaja)
        Me.gbDatos.Controls.Add(Me.txtAbreviatura)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtCodigo)
        Me.gbDatos.Controls.Add(Me.txtAño)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(541, 323)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos Básicos"
        '
        'gbCajaChica
        '
        Me.gbCajaChica.Controls.Add(Me.txtBuscarSuplente)
        Me.gbCajaChica.Controls.Add(Me.btnBuscarTitular)
        Me.gbCajaChica.Controls.Add(Me.Label10)
        Me.gbCajaChica.Controls.Add(Me.Label9)
        Me.gbCajaChica.Controls.Add(Me.Label7)
        Me.gbCajaChica.Controls.Add(Me.Label8)
        Me.gbCajaChica.Controls.Add(Me.Label6)
        Me.gbCajaChica.Controls.Add(Me.Label5)
        Me.gbCajaChica.Controls.Add(Me.txtProveedor02)
        Me.gbCajaChica.Controls.Add(Me.txtCodigoProveedor02)
        Me.gbCajaChica.Controls.Add(Me.txtProveedor01)
        Me.gbCajaChica.Controls.Add(Me.txtCodigoProveedor01)
        Me.gbCajaChica.Controls.Add(Me.txtMonto)
        Me.gbCajaChica.Controls.Add(Me.txtCorrelativo)
        Me.gbCajaChica.Controls.Add(Me.txtResolucion)
        Me.gbCajaChica.Controls.Add(Me.txtCodigoPartida)
        Me.gbCajaChica.Enabled = False
        Me.gbCajaChica.Location = New System.Drawing.Point(19, 122)
        Me.gbCajaChica.Name = "gbCajaChica"
        Me.gbCajaChica.Size = New System.Drawing.Size(508, 194)
        Me.gbCajaChica.TabIndex = 9
        Me.gbCajaChica.TabStop = False
        Me.gbCajaChica.Text = "Detalles de la Caja Chica:"
        '
        'txtBuscarSuplente
        '
        Me.txtBuscarSuplente.Location = New System.Drawing.Point(366, 160)
        Me.txtBuscarSuplente.Name = "txtBuscarSuplente"
        Me.txtBuscarSuplente.Size = New System.Drawing.Size(136, 23)
        Me.txtBuscarSuplente.TabIndex = 15
        Me.txtBuscarSuplente.Text = "Buscar Suplente"
        Me.txtBuscarSuplente.UseVisualStyleBackColor = True
        '
        'btnBuscarTitular
        '
        Me.btnBuscarTitular.Location = New System.Drawing.Point(366, 105)
        Me.btnBuscarTitular.Name = "btnBuscarTitular"
        Me.btnBuscarTitular.Size = New System.Drawing.Size(136, 23)
        Me.btnBuscarTitular.TabIndex = 11
        Me.btnBuscarTitular.Text = "Buscar Titular"
        Me.btnBuscarTitular.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Encargado Titular:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Encargado Titular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Monto Apertura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(216, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Correlativo Cuenta Caja:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Resolución de Apertura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código de Partida:"
        '
        'txtProveedor02
        '
        Me.txtProveedor02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor02.Location = New System.Drawing.Point(216, 134)
        Me.txtProveedor02.MaxLength = 8
        Me.txtProveedor02.Name = "txtProveedor02"
        Me.txtProveedor02.ReadOnly = True
        Me.txtProveedor02.Size = New System.Drawing.Size(286, 20)
        Me.txtProveedor02.TabIndex = 14
        '
        'txtCodigoProveedor02
        '
        Me.txtCodigoProveedor02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProveedor02.Location = New System.Drawing.Point(135, 134)
        Me.txtCodigoProveedor02.MaxLength = 8
        Me.txtCodigoProveedor02.Name = "txtCodigoProveedor02"
        Me.txtCodigoProveedor02.ReadOnly = True
        Me.txtCodigoProveedor02.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoProveedor02.TabIndex = 13
        '
        'txtProveedor01
        '
        Me.txtProveedor01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor01.Location = New System.Drawing.Point(216, 79)
        Me.txtProveedor01.MaxLength = 8
        Me.txtProveedor01.Name = "txtProveedor01"
        Me.txtProveedor01.ReadOnly = True
        Me.txtProveedor01.Size = New System.Drawing.Size(286, 20)
        Me.txtProveedor01.TabIndex = 10
        '
        'txtCodigoProveedor01
        '
        Me.txtCodigoProveedor01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProveedor01.Location = New System.Drawing.Point(135, 79)
        Me.txtCodigoProveedor01.MaxLength = 8
        Me.txtCodigoProveedor01.Name = "txtCodigoProveedor01"
        Me.txtCodigoProveedor01.ReadOnly = True
        Me.txtCodigoProveedor01.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoProveedor01.TabIndex = 9
        '
        'txtMonto
        '
        Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.Location = New System.Drawing.Point(135, 53)
        Me.txtMonto.MaxLength = 10
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(75, 20)
        Me.txtMonto.TabIndex = 5
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorrelativo.Location = New System.Drawing.Point(366, 53)
        Me.txtCorrelativo.MaxLength = 2
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(38, 20)
        Me.txtCorrelativo.TabIndex = 7
        '
        'txtResolucion
        '
        Me.txtResolucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResolucion.Location = New System.Drawing.Point(366, 27)
        Me.txtResolucion.MaxLength = 20
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(136, 20)
        Me.txtResolucion.TabIndex = 3
        '
        'txtCodigoPartida
        '
        Me.txtCodigoPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoPartida.Location = New System.Drawing.Point(135, 27)
        Me.txtCodigoPartida.MaxLength = 10
        Me.txtCodigoPartida.Name = "txtCodigoPartida"
        Me.txtCodigoPartida.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoPartida.TabIndex = 1
        '
        'chkCaja
        '
        Me.chkCaja.AutoSize = True
        Me.chkCaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCaja.Location = New System.Drawing.Point(19, 97)
        Me.chkCaja.Name = "chkCaja"
        Me.chkCaja.Size = New System.Drawing.Size(142, 17)
        Me.chkCaja.TabIndex = 8
        Me.chkCaja.Text = "Habilitar Caja Chica:"
        Me.chkCaja.UseVisualStyleBackColor = True
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.Location = New System.Drawing.Point(435, 28)
        Me.txtAbreviatura.MaxLength = 20
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(92, 20)
        Me.txtAbreviatura.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Abreviatura:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(146, 54)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombre.Size = New System.Drawing.Size(381, 37)
        Me.txtNombre.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre Unidad:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(299, 28)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(33, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'txtAño
        '
        Me.txtAño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Enabled = False
        Me.txtAño.Location = New System.Drawing.Point(146, 28)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(52, 20)
        Me.txtAño.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Codigo (ID):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año Ejecucion:"
        '
        'frmRegistro_Unidad_Organica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 408)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbDatos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro_Unidad_Organica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Registro de Unidad Orgánica ::.."
        Me.gbOpciones.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbCajaChica.ResumeLayout(False)
        Me.gbCajaChica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbCajaChica As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPartida As System.Windows.Forms.TextBox
    Friend WithEvents chkCaja As System.Windows.Forms.CheckBox
    Friend WithEvents txtBuscarSuplente As System.Windows.Forms.Button
    Friend WithEvents btnBuscarTitular As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor02 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProveedor02 As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor01 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProveedor01 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
End Class
