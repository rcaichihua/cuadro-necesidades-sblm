﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro_Requerimiento_Bienes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro_Requerimiento_Bienes))
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbActividad = New System.Windows.Forms.ComboBox
        Me.cbSecuenciaFuncional = New System.Windows.Forms.ComboBox
        Me.cbRubro = New System.Windows.Forms.ComboBox
        Me.cbFF = New System.Windows.Forms.ComboBox
        Me.cbUnidadOrganica = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbDetalle = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtJustificacion = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnBuscarItems = New System.Windows.Forms.Button
        Me.gbCatalogo = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtUnidadMedida = New System.Windows.Forms.TextBox
        Me.txtCodigoItem = New System.Windows.Forms.TextBox
        Me.txtCodigoUnidadMedida = New System.Windows.Forms.TextBox
        Me.txtFamilia = New System.Windows.Forms.TextBox
        Me.txtCodigoFamilia = New System.Windows.Forms.TextBox
        Me.txtClase = New System.Windows.Forms.TextBox
        Me.txtCodigoClase = New System.Windows.Forms.TextBox
        Me.txtGrupo = New System.Windows.Forms.TextBox
        Me.txtCodigoGrupo = New System.Windows.Forms.TextBox
        Me.txtEspecificaDetalle = New System.Windows.Forms.TextBox
        Me.txtEspecifica = New System.Windows.Forms.TextBox
        Me.txtSubGenericaDetalle = New System.Windows.Forms.TextBox
        Me.txtSubGenerica = New System.Windows.Forms.TextBox
        Me.txtGenerica = New System.Windows.Forms.TextBox
        Me.txtTipoTransaccion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbCatalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Controls.Add(Me.Label5)
        Me.gbDatosGenerales.Controls.Add(Me.Label4)
        Me.gbDatosGenerales.Controls.Add(Me.Label3)
        Me.gbDatosGenerales.Controls.Add(Me.Label2)
        Me.gbDatosGenerales.Controls.Add(Me.cbActividad)
        Me.gbDatosGenerales.Controls.Add(Me.cbSecuenciaFuncional)
        Me.gbDatosGenerales.Controls.Add(Me.cbRubro)
        Me.gbDatosGenerales.Controls.Add(Me.cbFF)
        Me.gbDatosGenerales.Controls.Add(Me.cbUnidadOrganica)
        Me.gbDatosGenerales.Controls.Add(Me.Label1)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(710, 143)
        Me.gbDatosGenerales.TabIndex = 0
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Datos Generales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Actividad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Secuencia Funcional:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rubro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fuente Financiamiento:"
        '
        'cbActividad
        '
        Me.cbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbActividad.FormattingEnabled = True
        Me.cbActividad.Location = New System.Drawing.Point(340, 105)
        Me.cbActividad.Name = "cbActividad"
        Me.cbActividad.Size = New System.Drawing.Size(364, 21)
        Me.cbActividad.TabIndex = 9
        '
        'cbSecuenciaFuncional
        '
        Me.cbSecuenciaFuncional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSecuenciaFuncional.FormattingEnabled = True
        Me.cbSecuenciaFuncional.Location = New System.Drawing.Point(165, 105)
        Me.cbSecuenciaFuncional.Name = "cbSecuenciaFuncional"
        Me.cbSecuenciaFuncional.Size = New System.Drawing.Size(99, 21)
        Me.cbSecuenciaFuncional.TabIndex = 7
        '
        'cbRubro
        '
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(165, 78)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(539, 21)
        Me.cbRubro.TabIndex = 5
        '
        'cbFF
        '
        Me.cbFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFF.FormattingEnabled = True
        Me.cbFF.Location = New System.Drawing.Point(165, 51)
        Me.cbFF.Name = "cbFF"
        Me.cbFF.Size = New System.Drawing.Size(539, 21)
        Me.cbFF.TabIndex = 3
        '
        'cbUnidadOrganica
        '
        Me.cbUnidadOrganica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadOrganica.FormattingEnabled = True
        Me.cbUnidadOrganica.Location = New System.Drawing.Point(165, 24)
        Me.cbUnidadOrganica.Name = "cbUnidadOrganica"
        Me.cbUnidadOrganica.Size = New System.Drawing.Size(539, 21)
        Me.cbUnidadOrganica.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad Orgánica:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(728, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 91)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Aprobacion_Requerimiento
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(411, 43)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(161, 42)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar al Detalle"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(165, 43)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(103, 20)
        Me.txtSaldo.TabIndex = 5
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Saldo Total Disponible"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(447, 16)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(123, 20)
        Me.txtCosto.TabIndex = 3
        Me.txtCosto.Text = "0.00"
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(308, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Costo Referencial:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(165, 16)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(103, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cantidad a Solicitar:"
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.DataGridView1)
        Me.gbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetalle.Location = New System.Drawing.Point(13, 308)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(1296, 276)
        Me.gbDetalle.TabIndex = 5
        Me.gbDetalle.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1279, 251)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(710, 63)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de Registro"
        '
        'Button1
        '
        Me.Button1.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(503, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exportar Detalle a Excel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(252, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(245, 42)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar Registro de Requerimiento"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Guadar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(13, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(233, 42)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar y/o Crear Requerimiento"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtJustificacion)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(710, 79)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Justificación"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificacion.Location = New System.Drawing.Point(165, 19)
        Me.txtJustificacion.MaxLength = 300
        Me.txtJustificacion.Multiline = True
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificacion.Size = New System.Drawing.Size(539, 53)
        Me.txtJustificacion.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Ingrese Justificación:"
        '
        'btnBuscarItems
        '
        Me.btnBuscarItems.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Buscar
        Me.btnBuscarItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarItems.Location = New System.Drawing.Point(21, 149)
        Me.btnBuscarItems.Name = "btnBuscarItems"
        Me.btnBuscarItems.Size = New System.Drawing.Size(117, 38)
        Me.btnBuscarItems.TabIndex = 17
        Me.btnBuscarItems.Text = "Buscar Items"
        Me.btnBuscarItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarItems.UseVisualStyleBackColor = True
        '
        'gbCatalogo
        '
        Me.gbCatalogo.Controls.Add(Me.Label7)
        Me.gbCatalogo.Controls.Add(Me.txtItem)
        Me.gbCatalogo.Controls.Add(Me.Label11)
        Me.gbCatalogo.Controls.Add(Me.txtUnidadMedida)
        Me.gbCatalogo.Controls.Add(Me.txtCodigoItem)
        Me.gbCatalogo.Controls.Add(Me.txtCodigoUnidadMedida)
        Me.gbCatalogo.Controls.Add(Me.txtFamilia)
        Me.gbCatalogo.Controls.Add(Me.txtCodigoFamilia)
        Me.gbCatalogo.Controls.Add(Me.txtClase)
        Me.gbCatalogo.Controls.Add(Me.txtCodigoClase)
        Me.gbCatalogo.Controls.Add(Me.txtGrupo)
        Me.gbCatalogo.Controls.Add(Me.txtCodigoGrupo)
        Me.gbCatalogo.Controls.Add(Me.txtEspecificaDetalle)
        Me.gbCatalogo.Controls.Add(Me.txtEspecifica)
        Me.gbCatalogo.Controls.Add(Me.txtSubGenericaDetalle)
        Me.gbCatalogo.Controls.Add(Me.txtSubGenerica)
        Me.gbCatalogo.Controls.Add(Me.txtGenerica)
        Me.gbCatalogo.Controls.Add(Me.txtTipoTransaccion)
        Me.gbCatalogo.Controls.Add(Me.Label6)
        Me.gbCatalogo.Controls.Add(Me.Label8)
        Me.gbCatalogo.Controls.Add(Me.Label9)
        Me.gbCatalogo.Controls.Add(Me.btnBuscarItems)
        Me.gbCatalogo.Controls.Add(Me.Label10)
        Me.gbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCatalogo.Location = New System.Drawing.Point(728, 12)
        Me.gbCatalogo.Name = "gbCatalogo"
        Me.gbCatalogo.Size = New System.Drawing.Size(581, 200)
        Me.gbCatalogo.TabIndex = 1
        Me.gbCatalogo.TabStop = False
        Me.gbCatalogo.Text = "Catalogo de Bienes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Unidad de Medida:"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.White
        Me.txtItem.Location = New System.Drawing.Point(208, 132)
        Me.txtItem.Multiline = True
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(362, 55)
        Me.txtItem.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Item Selecconado:"
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.BackColor = System.Drawing.Color.White
        Me.txtUnidadMedida.Location = New System.Drawing.Point(208, 105)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.ReadOnly = True
        Me.txtUnidadMedida.Size = New System.Drawing.Size(94, 20)
        Me.txtUnidadMedida.TabIndex = 11
        '
        'txtCodigoItem
        '
        Me.txtCodigoItem.BackColor = System.Drawing.Color.White
        Me.txtCodigoItem.Location = New System.Drawing.Point(165, 132)
        Me.txtCodigoItem.Name = "txtCodigoItem"
        Me.txtCodigoItem.ReadOnly = True
        Me.txtCodigoItem.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoItem.TabIndex = 15
        '
        'txtCodigoUnidadMedida
        '
        Me.txtCodigoUnidadMedida.BackColor = System.Drawing.Color.White
        Me.txtCodigoUnidadMedida.Location = New System.Drawing.Point(165, 105)
        Me.txtCodigoUnidadMedida.Name = "txtCodigoUnidadMedida"
        Me.txtCodigoUnidadMedida.ReadOnly = True
        Me.txtCodigoUnidadMedida.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoUnidadMedida.TabIndex = 10
        '
        'txtFamilia
        '
        Me.txtFamilia.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Location = New System.Drawing.Point(208, 78)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(364, 20)
        Me.txtFamilia.TabIndex = 8
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.BackColor = System.Drawing.Color.White
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(165, 78)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoFamilia.TabIndex = 7
        '
        'txtClase
        '
        Me.txtClase.BackColor = System.Drawing.Color.White
        Me.txtClase.Location = New System.Drawing.Point(208, 51)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.ReadOnly = True
        Me.txtClase.Size = New System.Drawing.Size(364, 20)
        Me.txtClase.TabIndex = 5
        '
        'txtCodigoClase
        '
        Me.txtCodigoClase.BackColor = System.Drawing.Color.White
        Me.txtCodigoClase.Location = New System.Drawing.Point(165, 51)
        Me.txtCodigoClase.Name = "txtCodigoClase"
        Me.txtCodigoClase.ReadOnly = True
        Me.txtCodigoClase.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoClase.TabIndex = 4
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.Color.White
        Me.txtGrupo.Location = New System.Drawing.Point(208, 24)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(364, 20)
        Me.txtGrupo.TabIndex = 5
        '
        'txtCodigoGrupo
        '
        Me.txtCodigoGrupo.BackColor = System.Drawing.Color.White
        Me.txtCodigoGrupo.Location = New System.Drawing.Point(165, 24)
        Me.txtCodigoGrupo.Name = "txtCodigoGrupo"
        Me.txtCodigoGrupo.ReadOnly = True
        Me.txtCodigoGrupo.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoGrupo.TabIndex = 1
        '
        'txtEspecificaDetalle
        '
        Me.txtEspecificaDetalle.BackColor = System.Drawing.Color.White
        Me.txtEspecificaDetalle.Location = New System.Drawing.Point(550, 105)
        Me.txtEspecificaDetalle.Name = "txtEspecificaDetalle"
        Me.txtEspecificaDetalle.ReadOnly = True
        Me.txtEspecificaDetalle.Size = New System.Drawing.Size(20, 20)
        Me.txtEspecificaDetalle.TabIndex = 13
        Me.txtEspecificaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEspecifica
        '
        Me.txtEspecifica.BackColor = System.Drawing.Color.White
        Me.txtEspecifica.Location = New System.Drawing.Point(530, 105)
        Me.txtEspecifica.Name = "txtEspecifica"
        Me.txtEspecifica.ReadOnly = True
        Me.txtEspecifica.Size = New System.Drawing.Size(20, 20)
        Me.txtEspecifica.TabIndex = 13
        Me.txtEspecifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubGenericaDetalle
        '
        Me.txtSubGenericaDetalle.BackColor = System.Drawing.Color.White
        Me.txtSubGenericaDetalle.Location = New System.Drawing.Point(510, 105)
        Me.txtSubGenericaDetalle.Name = "txtSubGenericaDetalle"
        Me.txtSubGenericaDetalle.ReadOnly = True
        Me.txtSubGenericaDetalle.Size = New System.Drawing.Size(20, 20)
        Me.txtSubGenericaDetalle.TabIndex = 13
        Me.txtSubGenericaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubGenerica
        '
        Me.txtSubGenerica.BackColor = System.Drawing.Color.White
        Me.txtSubGenerica.Location = New System.Drawing.Point(490, 105)
        Me.txtSubGenerica.Name = "txtSubGenerica"
        Me.txtSubGenerica.ReadOnly = True
        Me.txtSubGenerica.Size = New System.Drawing.Size(20, 20)
        Me.txtSubGenerica.TabIndex = 13
        Me.txtSubGenerica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGenerica
        '
        Me.txtGenerica.BackColor = System.Drawing.Color.White
        Me.txtGenerica.Location = New System.Drawing.Point(470, 105)
        Me.txtGenerica.Name = "txtGenerica"
        Me.txtGenerica.ReadOnly = True
        Me.txtGenerica.Size = New System.Drawing.Size(20, 20)
        Me.txtGenerica.TabIndex = 13
        Me.txtGenerica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipoTransaccion
        '
        Me.txtTipoTransaccion.BackColor = System.Drawing.Color.White
        Me.txtTipoTransaccion.Location = New System.Drawing.Point(450, 105)
        Me.txtTipoTransaccion.Name = "txtTipoTransaccion"
        Me.txtTipoTransaccion.ReadOnly = True
        Me.txtTipoTransaccion.Size = New System.Drawing.Size(20, 20)
        Me.txtTipoTransaccion.TabIndex = 13
        Me.txtTipoTransaccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Clasificador Asociado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Familia Bien:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Clase Bien:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Grupo Bien:"
        '
        'frmRegistro_Requerimiento_Bienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDetalle)
        Me.Controls.Add(Me.gbCatalogo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro_Requerimiento_Bienes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Registro General de Requerimiento de Bienes ::.."
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbCatalogo.ResumeLayout(False)
        Me.gbCatalogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents cbUnidadOrganica As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFF As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbActividad As System.Windows.Forms.ComboBox
    Friend WithEvents cbSecuenciaFuncional As System.Windows.Forms.ComboBox
    Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtJustificacion As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarItems As System.Windows.Forms.Button
    Friend WithEvents gbCatalogo As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTipoTransaccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtClase As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoClase As System.Windows.Forms.TextBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSubGenerica As System.Windows.Forms.TextBox
    Friend WithEvents txtGenerica As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecificaDetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecifica As System.Windows.Forms.TextBox
    Friend WithEvents txtSubGenericaDetalle As System.Windows.Forms.TextBox
End Class
