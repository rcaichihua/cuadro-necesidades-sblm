<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro_Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro_Items))
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkIGV = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbCombos = New System.Windows.Forms.GroupBox()
        Me.btnBuscarFamilia = New System.Windows.Forms.Button()
        Me.btnBuscarClase = New System.Windows.Forms.Button()
        Me.btnBuscarGrupo = New System.Windows.Forms.Button()
        Me.cbFamilia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbClase = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatosEspecificos = New System.Windows.Forms.GroupBox()
        Me.lblClasificador = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPrecioReferencial = New System.Windows.Forms.TextBox()
        Me.btnBuscarClasificador = New System.Windows.Forms.Button()
        Me.cbEspecificaDetalle = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbEspecifica = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbSubGenericaDetalle = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSubGenerica = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGenerica = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTipoTransaccion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminarCN = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.gbCombos.SuspendLayout
        Me.gbDatosEspecificos.SuspendLayout
        Me.gbOpciones.SuspendLayout
        Me.SuspendLayout
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.GroupBox2)
        Me.gbDatos.Controls.Add(Me.gbCombos)
        Me.gbDatos.Controls.Add(Me.gbDatosEspecificos)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(884, 352)
        Me.gbDatos.TabIndex = 4
        Me.gbDatos.TabStop = false
        Me.gbDatos.Text = "Registro de Items en el Catalogo de Bienes, Servicios y Obras"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkIGV)
        Me.GroupBox2.Controls.Add(Me.chkActivo)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.btnEliminarCN)
        Me.GroupBox2.Controls.Add(Me.cbUnidadMedida)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 215)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Datos Específicos:"
        '
        'chkIGV
        '
        Me.chkIGV.AutoSize = true
        Me.chkIGV.Location = New System.Drawing.Point(99, 185)
        Me.chkIGV.Name = "chkIGV"
        Me.chkIGV.Size = New System.Drawing.Size(114, 17)
        Me.chkIGV.TabIndex = 6
        Me.chkIGV.Text = "Afecto al I.G.V."
        Me.chkIGV.UseVisualStyleBackColor = true
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = true
        Me.chkActivo.Location = New System.Drawing.Point(6, 185)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 6
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = true
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(99, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = true
        Me.txtCodigo.Size = New System.Drawing.Size(181, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbUnidadMedida
        '
        Me.cbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadMedida.FormattingEnabled = true
        Me.cbUnidadMedida.Location = New System.Drawing.Point(99, 154)
        Me.cbUnidadMedida.Name = "cbUnidadMedida"
        Me.cbUnidadMedida.Size = New System.Drawing.Size(181, 21)
        Me.cbUnidadMedida.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(6, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Unidad Medida:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(99, 46)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Multiline = true
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 97)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(6, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Código:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripción:"
        '
        'gbCombos
        '
        Me.gbCombos.Controls.Add(Me.btnBuscarFamilia)
        Me.gbCombos.Controls.Add(Me.btnBuscarClase)
        Me.gbCombos.Controls.Add(Me.btnBuscarGrupo)
        Me.gbCombos.Controls.Add(Me.cbFamilia)
        Me.gbCombos.Controls.Add(Me.Label3)
        Me.gbCombos.Controls.Add(Me.cbClase)
        Me.gbCombos.Controls.Add(Me.Label2)
        Me.gbCombos.Controls.Add(Me.cbGrupo)
        Me.gbCombos.Controls.Add(Me.Label1)
        Me.gbCombos.Location = New System.Drawing.Point(6, 19)
        Me.gbCombos.Name = "gbCombos"
        Me.gbCombos.Size = New System.Drawing.Size(869, 101)
        Me.gbCombos.TabIndex = 5
        Me.gbCombos.TabStop = false
        Me.gbCombos.Text = "Datos Globales"
        '
        'btnBuscarFamilia
        '
        Me.btnBuscarFamilia.Location = New System.Drawing.Point(783, 65)
        Me.btnBuscarFamilia.Name = "btnBuscarFamilia"
        Me.btnBuscarFamilia.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarFamilia.TabIndex = 8
        Me.btnBuscarFamilia.Text = "Buscar"
        Me.btnBuscarFamilia.UseVisualStyleBackColor = true
        '
        'btnBuscarClase
        '
        Me.btnBuscarClase.Location = New System.Drawing.Point(783, 38)
        Me.btnBuscarClase.Name = "btnBuscarClase"
        Me.btnBuscarClase.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarClase.TabIndex = 5
        Me.btnBuscarClase.Text = "Buscar"
        Me.btnBuscarClase.UseVisualStyleBackColor = true
        '
        'btnBuscarGrupo
        '
        Me.btnBuscarGrupo.Location = New System.Drawing.Point(783, 11)
        Me.btnBuscarGrupo.Name = "btnBuscarGrupo"
        Me.btnBuscarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarGrupo.TabIndex = 2
        Me.btnBuscarGrupo.Text = "Buscar"
        Me.btnBuscarGrupo.UseVisualStyleBackColor = true
        '
        'cbFamilia
        '
        Me.cbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFamilia.FormattingEnabled = true
        Me.cbFamilia.Location = New System.Drawing.Point(167, 67)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(610, 21)
        Me.cbFamilia.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seleccionar Familia:"
        '
        'cbClase
        '
        Me.cbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClase.FormattingEnabled = true
        Me.cbClase.Location = New System.Drawing.Point(167, 40)
        Me.cbClase.Name = "cbClase"
        Me.cbClase.Size = New System.Drawing.Size(610, 21)
        Me.cbClase.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccionar Clase:"
        '
        'cbGrupo
        '
        Me.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupo.FormattingEnabled = true
        Me.cbGrupo.Location = New System.Drawing.Point(167, 13)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(610, 21)
        Me.cbGrupo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccionar Grupo:"
        '
        'gbDatosEspecificos
        '
        Me.gbDatosEspecificos.Controls.Add(Me.lblClasificador)
        Me.gbDatosEspecificos.Controls.Add(Me.Label24)
        Me.gbDatosEspecificos.Controls.Add(Me.txtPrecioReferencial)
        Me.gbDatosEspecificos.Controls.Add(Me.btnBuscarClasificador)
        Me.gbDatosEspecificos.Controls.Add(Me.cbEspecificaDetalle)
        Me.gbDatosEspecificos.Controls.Add(Me.Label11)
        Me.gbDatosEspecificos.Controls.Add(Me.Label14)
        Me.gbDatosEspecificos.Controls.Add(Me.cbEspecifica)
        Me.gbDatosEspecificos.Controls.Add(Me.Label10)
        Me.gbDatosEspecificos.Controls.Add(Me.cbSubGenericaDetalle)
        Me.gbDatosEspecificos.Controls.Add(Me.Label9)
        Me.gbDatosEspecificos.Controls.Add(Me.cbSubGenerica)
        Me.gbDatosEspecificos.Controls.Add(Me.Label8)
        Me.gbDatosEspecificos.Controls.Add(Me.cbGenerica)
        Me.gbDatosEspecificos.Controls.Add(Me.Label7)
        Me.gbDatosEspecificos.Controls.Add(Me.cbTipoTransaccion)
        Me.gbDatosEspecificos.Controls.Add(Me.Label6)
        Me.gbDatosEspecificos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbDatosEspecificos.Location = New System.Drawing.Point(6, 126)
        Me.gbDatosEspecificos.Name = "gbDatosEspecificos"
        Me.gbDatosEspecificos.Size = New System.Drawing.Size(572, 215)
        Me.gbDatosEspecificos.TabIndex = 4
        Me.gbDatosEspecificos.TabStop = false
        Me.gbDatosEspecificos.Text = "Clasificadores de Gasto"
        '
        'lblClasificador
        '
        Me.lblClasificador.BackColor = System.Drawing.Color.White
        Me.lblClasificador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClasificador.Location = New System.Drawing.Point(167, 181)
        Me.lblClasificador.Name = "lblClasificador"
        Me.lblClasificador.Size = New System.Drawing.Size(103, 19)
        Me.lblClasificador.TabIndex = 16
        Me.lblClasificador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Location = New System.Drawing.Point(10, 182)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(138, 13)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Clasificador Propuesto:"
        '
        'txtPrecioReferencial
        '
        Me.txtPrecioReferencial.Location = New System.Drawing.Point(328, 181)
        Me.txtPrecioReferencial.Name = "txtPrecioReferencial"
        Me.txtPrecioReferencial.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecioReferencial.TabIndex = 1
        Me.txtPrecioReferencial.Text = "1.00"
        Me.txtPrecioReferencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarClasificador
        '
        Me.btnBuscarClasificador.Location = New System.Drawing.Point(406, 181)
        Me.btnBuscarClasificador.Name = "btnBuscarClasificador"
        Me.btnBuscarClasificador.Size = New System.Drawing.Size(156, 23)
        Me.btnBuscarClasificador.TabIndex = 14
        Me.btnBuscarClasificador.Text = "Buscar Clasificador"
        Me.btnBuscarClasificador.UseVisualStyleBackColor = true
        '
        'cbEspecificaDetalle
        '
        Me.cbEspecificaDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEspecificaDetalle.FormattingEnabled = true
        Me.cbEspecificaDetalle.Location = New System.Drawing.Point(167, 154)
        Me.cbEspecificaDetalle.Name = "cbEspecificaDetalle"
        Me.cbEspecificaDetalle.Size = New System.Drawing.Size(395, 21)
        Me.cbEspecificaDetalle.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(10, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Específica Detalle:"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(280, 185)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "P. ref."
        '
        'cbEspecifica
        '
        Me.cbEspecifica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEspecifica.FormattingEnabled = true
        Me.cbEspecifica.Location = New System.Drawing.Point(167, 127)
        Me.cbEspecifica.Name = "cbEspecifica"
        Me.cbEspecifica.Size = New System.Drawing.Size(395, 21)
        Me.cbEspecifica.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(10, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Específica:"
        '
        'cbSubGenericaDetalle
        '
        Me.cbSubGenericaDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubGenericaDetalle.FormattingEnabled = true
        Me.cbSubGenericaDetalle.Location = New System.Drawing.Point(167, 100)
        Me.cbSubGenericaDetalle.Name = "cbSubGenericaDetalle"
        Me.cbSubGenericaDetalle.Size = New System.Drawing.Size(395, 21)
        Me.cbSubGenericaDetalle.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(10, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "SubGenérica Detalle:"
        '
        'cbSubGenerica
        '
        Me.cbSubGenerica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubGenerica.FormattingEnabled = true
        Me.cbSubGenerica.Location = New System.Drawing.Point(167, 73)
        Me.cbSubGenerica.Name = "cbSubGenerica"
        Me.cbSubGenerica.Size = New System.Drawing.Size(395, 21)
        Me.cbSubGenerica.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(10, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "SubGenérica:"
        '
        'cbGenerica
        '
        Me.cbGenerica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenerica.FormattingEnabled = true
        Me.cbGenerica.Location = New System.Drawing.Point(167, 46)
        Me.cbGenerica.Name = "cbGenerica"
        Me.cbGenerica.Size = New System.Drawing.Size(395, 21)
        Me.cbGenerica.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(10, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Genérica:"
        '
        'cbTipoTransaccion
        '
        Me.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoTransaccion.FormattingEnabled = true
        Me.cbTipoTransaccion.Location = New System.Drawing.Point(167, 19)
        Me.cbTipoTransaccion.Name = "cbTipoTransaccion"
        Me.cbTipoTransaccion.Size = New System.Drawing.Size(395, 21)
        Me.cbTipoTransaccion.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(10, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo de Transacción:"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnSalir)
        Me.gbOpciones.Controls.Add(Me.btnBuscar)
        Me.gbOpciones.Controls.Add(Me.btnCancelar)
        Me.gbOpciones.Controls.Add(Me.btnGuardar)
        Me.gbOpciones.Controls.Add(Me.btnNuevo)
        Me.gbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbOpciones.Location = New System.Drawing.Point(902, 12)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(113, 352)
        Me.gbOpciones.TabIndex = 5
        Me.gbOpciones.TabStop = false
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSalir.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(6, 279)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 59)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Finalizar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = true
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnBuscar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Otros_Reportes
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(6, 214)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 59)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = true
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(6, 149)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 59)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGuardar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Reporte_Servicios
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(6, 84)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 59)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = true
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnNuevo.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(6, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 59)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = true
        '
        'btnEliminarCN
        '
        Me.btnEliminarCN.Location = New System.Drawing.Point(6, 66)
        Me.btnEliminarCN.Name = "btnEliminarCN"
        Me.btnEliminarCN.Size = New System.Drawing.Size(87, 55)
        Me.btnEliminarCN.TabIndex = 14
        Me.btnEliminarCN.Text = "Eliminar del Catalogo de C.N."
        Me.btnEliminarCN.UseVisualStyleBackColor = true
        '
        'frmRegistro_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 370)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbDatos)
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRegistro_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Registro de Items ::.."
        Me.gbDatos.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.gbCombos.ResumeLayout(false)
        Me.gbCombos.PerformLayout
        Me.gbDatosEspecificos.ResumeLayout(false)
        Me.gbDatosEspecificos.PerformLayout
        Me.gbOpciones.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents gbCombos As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarFamilia As System.Windows.Forms.Button
    Friend WithEvents btnBuscarClase As System.Windows.Forms.Button
    Friend WithEvents btnBuscarGrupo As System.Windows.Forms.Button
    Friend WithEvents cbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbDatosEspecificos As System.Windows.Forms.GroupBox
    Friend WithEvents lblClasificador As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarClasificador As System.Windows.Forms.Button
    Friend WithEvents cbEspecificaDetalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbEspecifica As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbSubGenericaDetalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbSubGenerica As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbGenerica As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTipoTransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkIGV As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrecioReferencial As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEliminarCN As Button
End Class
