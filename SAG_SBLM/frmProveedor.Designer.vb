<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
        Me.gbDatos = New System.Windows.Forms.GroupBox
        Me.txtDescripcionTipoDocumento = New System.Windows.Forms.TextBox
        Me.cbTipoDocumento = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.btnBuscarUbigeo = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCelular = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.txtDetracciones = New System.Windows.Forms.TextBox
        Me.txtCCI = New System.Windows.Forms.TextBox
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtUbigeo = New System.Windows.Forms.TextBox
        Me.txtCodigoUgibeo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDomicilio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRazon_Social = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigoProveedor = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtRUC_Proveedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.gbDatos.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtDescripcionTipoDocumento)
        Me.gbDatos.Controls.Add(Me.cbTipoDocumento)
        Me.gbDatos.Controls.Add(Me.Label14)
        Me.gbDatos.Controls.Add(Me.chkActivo)
        Me.gbDatos.Controls.Add(Me.btnBuscarUbigeo)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.txtCelular)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.txtFax)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.txtTelefono)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtObservaciones)
        Me.gbDatos.Controls.Add(Me.txtDetracciones)
        Me.gbDatos.Controls.Add(Me.txtCCI)
        Me.gbDatos.Controls.Add(Me.txtCorreo)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtUbigeo)
        Me.gbDatos.Controls.Add(Me.txtCodigoUgibeo)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtDomicilio)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtRazon_Social)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtCodigoProveedor)
        Me.gbDatos.Controls.Add(Me.Label20)
        Me.gbDatos.Controls.Add(Me.txtRUC_Proveedor)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(541, 384)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "..:: Proveedor ::.."
        '
        'txtDescripcionTipoDocumento
        '
        Me.txtDescripcionTipoDocumento.Location = New System.Drawing.Point(257, 28)
        Me.txtDescripcionTipoDocumento.Name = "txtDescripcionTipoDocumento"
        Me.txtDescripcionTipoDocumento.ReadOnly = True
        Me.txtDescripcionTipoDocumento.Size = New System.Drawing.Size(269, 20)
        Me.txtDescripcionTipoDocumento.TabIndex = 1
        '
        'cbTipoDocumento
        '
        Me.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocumento.FormattingEnabled = True
        Me.cbTipoDocumento.Location = New System.Drawing.Point(152, 28)
        Me.cbTipoDocumento.Name = "cbTipoDocumento"
        Me.cbTipoDocumento.Size = New System.Drawing.Size(96, 21)
        Me.cbTipoDocumento.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Tipo Documento:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(153, 355)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 16
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'btnBuscarUbigeo
        '
        Me.btnBuscarUbigeo.Location = New System.Drawing.Point(254, 131)
        Me.btnBuscarUbigeo.Name = "btnBuscarUbigeo"
        Me.btnBuscarUbigeo.Size = New System.Drawing.Size(272, 23)
        Me.btnBuscarUbigeo.TabIndex = 14
        Me.btnBuscarUbigeo.Text = "..:: Búsqueda de Ubigeos ::.."
        Me.btnBuscarUbigeo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Distrito:"
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Location = New System.Drawing.Point(431, 185)
        Me.txtCelular.MaxLength = 11
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(95, 20)
        Me.txtCelular.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Cel.:"
        '
        'txtFax
        '
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax.Location = New System.Drawing.Point(291, 185)
        Me.txtFax.MaxLength = 11
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(95, 20)
        Me.txtFax.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fax:"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(153, 185)
        Me.txtTelefono.MaxLength = 11
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(95, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(153, 237)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(373, 63)
        Me.txtObservaciones.TabIndex = 13
        '
        'txtDetracciones
        '
        Me.txtDetracciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetracciones.Location = New System.Drawing.Point(153, 332)
        Me.txtDetracciones.MaxLength = 20
        Me.txtDetracciones.Name = "txtDetracciones"
        Me.txtDetracciones.Size = New System.Drawing.Size(233, 20)
        Me.txtDetracciones.TabIndex = 15
        '
        'txtCCI
        '
        Me.txtCCI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCCI.Location = New System.Drawing.Point(153, 306)
        Me.txtCCI.MaxLength = 20
        Me.txtCCI.Name = "txtCCI"
        Me.txtCCI.Size = New System.Drawing.Size(233, 20)
        Me.txtCCI.TabIndex = 14
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreo.Location = New System.Drawing.Point(153, 211)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(373, 20)
        Me.txtCorreo.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 335)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Cuenta  Detracciones:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Estado Actual:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "C.C.I.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Observaciones:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Correo Electrónico:"
        '
        'txtUbigeo
        '
        Me.txtUbigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbigeo.Location = New System.Drawing.Point(153, 159)
        Me.txtUbigeo.Name = "txtUbigeo"
        Me.txtUbigeo.ReadOnly = True
        Me.txtUbigeo.Size = New System.Drawing.Size(373, 20)
        Me.txtUbigeo.TabIndex = 8
        '
        'txtCodigoUgibeo
        '
        Me.txtCodigoUgibeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoUgibeo.Location = New System.Drawing.Point(153, 133)
        Me.txtCodigoUgibeo.Name = "txtCodigoUgibeo"
        Me.txtCodigoUgibeo.ReadOnly = True
        Me.txtCodigoUgibeo.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigoUgibeo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ubigeo:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Location = New System.Drawing.Point(153, 107)
        Me.txtDomicilio.MaxLength = 200
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(373, 20)
        Me.txtDomicilio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Domicilio:"
        '
        'txtRazon_Social
        '
        Me.txtRazon_Social.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazon_Social.Location = New System.Drawing.Point(153, 81)
        Me.txtRazon_Social.MaxLength = 200
        Me.txtRazon_Social.Name = "txtRazon_Social"
        Me.txtRazon_Social.Size = New System.Drawing.Size(373, 20)
        Me.txtRazon_Social.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Razón Social:"
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(431, 55)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.ReadOnly = True
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigoProveedor.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(254, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(156, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Código Interno Proveedor:"
        '
        'txtRUC_Proveedor
        '
        Me.txtRUC_Proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC_Proveedor.Location = New System.Drawing.Point(153, 55)
        Me.txtRUC_Proveedor.MaxLength = 11
        Me.txtRUC_Proveedor.Name = "txtRUC_Proveedor"
        Me.txtRUC_Proveedor.Size = New System.Drawing.Size(95, 20)
        Me.txtRUC_Proveedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUC Proveedor:"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnSalir)
        Me.gbOpciones.Controls.Add(Me.btnBuscar)
        Me.gbOpciones.Controls.Add(Me.btnCancelar)
        Me.gbOpciones.Controls.Add(Me.btnGuardar)
        Me.gbOpciones.Controls.Add(Me.btnNuevo)
        Me.gbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.Location = New System.Drawing.Point(12, 402)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(541, 61)
        Me.gbOpciones.TabIndex = 1
        Me.gbOpciones.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(429, 11)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 44)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Finalizar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Otros_Reportes
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(325, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 44)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(221, 11)
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
        Me.btnGuardar.Location = New System.Drawing.Point(117, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 44)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(13, 11)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 44)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 473)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbDatos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Registro de Proveedores ::.."
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoUgibeo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRazon_Social As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRUC_Proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUbigeo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarUbigeo As System.Windows.Forms.Button
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDetracciones As System.Windows.Forms.TextBox
    Friend WithEvents txtCCI As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionTipoDocumento As System.Windows.Forms.TextBox
End Class
