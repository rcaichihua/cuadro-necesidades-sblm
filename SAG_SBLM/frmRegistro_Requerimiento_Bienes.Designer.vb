<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro_Requerimiento_Bienes))
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbActividad = New System.Windows.Forms.ComboBox()
        Me.cbSecuenciaFuncional = New System.Windows.Forms.ComboBox()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.cbFF = New System.Windows.Forms.ComboBox()
        Me.cbUnidadOrganica = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSaldoTotalCN = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSaldoMes = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvRequerimientoBienes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtJustificacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBuscarItems = New System.Windows.Forms.Button()
        Me.gbCatalogo = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnidadMedida = New System.Windows.Forms.TextBox()
        Me.txtCodigoItem = New System.Windows.Forms.TextBox()
        Me.txtCodigoUnidadMedida = New System.Windows.Forms.TextBox()
        Me.txtFamilia = New System.Windows.Forms.TextBox()
        Me.txtCodigoFamilia = New System.Windows.Forms.TextBox()
        Me.txtClase = New System.Windows.Forms.TextBox()
        Me.txtCodigoClase = New System.Windows.Forms.TextBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtCodigoGrupo = New System.Windows.Forms.TextBox()
        Me.txtEspecificaDetalle = New System.Windows.Forms.TextBox()
        Me.txtEspecifica = New System.Windows.Forms.TextBox()
        Me.txtSubGenericaDetalle = New System.Windows.Forms.TextBox()
        Me.txtSubGenerica = New System.Windows.Forms.TextBox()
        Me.txtGenerica = New System.Windows.Forms.TextBox()
        Me.txtTipoTransaccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbOriginal = New System.Windows.Forms.GroupBox()
        Me.txtDiciembre = New System.Windows.Forms.TextBox()
        Me.txtJunio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNoviembre = New System.Windows.Forms.TextBox()
        Me.txtMayo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtOctubre = New System.Windows.Forms.TextBox()
        Me.txtAbril = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSeptiembre = New System.Windows.Forms.TextBox()
        Me.txtMarzo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAgosto = New System.Windows.Forms.TextBox()
        Me.txtFebrero = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtJulio = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtEnero = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbDatosGenerales.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.gbDetalle.SuspendLayout
        CType(Me.dgvRequerimientoBienes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.gbCatalogo.SuspendLayout
        Me.gbOriginal.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.SuspendLayout
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
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(710, 139)
        Me.gbDatosGenerales.TabIndex = 0
        Me.gbDatosGenerales.TabStop = false
        Me.gbDatosGenerales.Text = "Datos Generales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(270, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Actividad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(20, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Secuencia Funcional:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(20, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rubro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fuente Financiamiento:"
        '
        'cbActividad
        '
        Me.cbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbActividad.FormattingEnabled = true
        Me.cbActividad.Location = New System.Drawing.Point(340, 105)
        Me.cbActividad.Name = "cbActividad"
        Me.cbActividad.Size = New System.Drawing.Size(364, 21)
        Me.cbActividad.TabIndex = 9
        '
        'cbSecuenciaFuncional
        '
        Me.cbSecuenciaFuncional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSecuenciaFuncional.FormattingEnabled = true
        Me.cbSecuenciaFuncional.Location = New System.Drawing.Point(165, 105)
        Me.cbSecuenciaFuncional.Name = "cbSecuenciaFuncional"
        Me.cbSecuenciaFuncional.Size = New System.Drawing.Size(99, 21)
        Me.cbSecuenciaFuncional.TabIndex = 7
        '
        'cbRubro
        '
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.FormattingEnabled = true
        Me.cbRubro.Location = New System.Drawing.Point(165, 78)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(539, 21)
        Me.cbRubro.TabIndex = 5
        '
        'cbFF
        '
        Me.cbFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFF.FormattingEnabled = true
        Me.cbFF.Location = New System.Drawing.Point(165, 51)
        Me.cbFF.Name = "cbFF"
        Me.cbFF.Size = New System.Drawing.Size(539, 21)
        Me.cbFF.TabIndex = 3
        '
        'cbUnidadOrganica
        '
        Me.cbUnidadOrganica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadOrganica.FormattingEnabled = true
        Me.cbUnidadOrganica.Location = New System.Drawing.Point(165, 24)
        Me.cbUnidadOrganica.Name = "cbUnidadOrganica"
        Me.cbUnidadOrganica.Size = New System.Drawing.Size(539, 21)
        Me.cbUnidadOrganica.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad Orgánica:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(199, 462)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = false
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Reporte_SEACE
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(425, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(155, 41)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "&Agregar al detalle"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(342, 13)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = true
        Me.txtCosto.Size = New System.Drawing.Size(77, 20)
        Me.txtCosto.TabIndex = 3
        Me.txtCosto.Text = "0.00"
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(224, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Costo Referencial:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(134, 13)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(84, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cantidad a Solicitar:"
        '
        'txtSaldoTotalCN
        '
        Me.txtSaldoTotalCN.Location = New System.Drawing.Point(677, 415)
        Me.txtSaldoTotalCN.Name = "txtSaldoTotalCN"
        Me.txtSaldoTotalCN.ReadOnly = true
        Me.txtSaldoTotalCN.Size = New System.Drawing.Size(103, 20)
        Me.txtSaldoTotalCN.TabIndex = 5
        Me.txtSaldoTotalCN.Text = "0.00"
        Me.txtSaldoTotalCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(556, 418)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Saldo C.N. del Año"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoMes
        '
        Me.txtSaldoMes.Location = New System.Drawing.Point(205, 415)
        Me.txtSaldoMes.Name = "txtSaldoMes"
        Me.txtSaldoMes.ReadOnly = true
        Me.txtSaldoMes.Size = New System.Drawing.Size(103, 20)
        Me.txtSaldoMes.TabIndex = 5
        Me.txtSaldoMes.Text = "0.00"
        Me.txtSaldoMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(83, 418)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Saldo C.N. del Mes"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(442, 415)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = true
        Me.txtSaldo.Size = New System.Drawing.Size(103, 20)
        Me.txtSaldo.TabIndex = 5
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Visible = false
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(320, 418)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Saldo Presupuestal"
        Me.Label13.Visible = false
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.dgvRequerimientoBienes)
        Me.gbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbDetalle.Location = New System.Drawing.Point(13, 224)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(1296, 351)
        Me.gbDetalle.TabIndex = 5
        Me.gbDetalle.TabStop = false
        '
        'dgvRequerimientoBienes
        '
        Me.dgvRequerimientoBienes.AllowUserToAddRows = false
        Me.dgvRequerimientoBienes.AllowUserToDeleteRows = false
        Me.dgvRequerimientoBienes.AllowUserToResizeColumns = false
        Me.dgvRequerimientoBienes.AllowUserToResizeRows = false
        Me.dgvRequerimientoBienes.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequerimientoBienes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRequerimientoBienes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequerimientoBienes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvRequerimientoBienes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequerimientoBienes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRequerimientoBienes.EnableHeadersVisualStyles = false
        Me.dgvRequerimientoBienes.Location = New System.Drawing.Point(3, 16)
        Me.dgvRequerimientoBienes.MultiSelect = false
        Me.dgvRequerimientoBienes.Name = "dgvRequerimientoBienes"
        Me.dgvRequerimientoBienes.RowHeadersVisible = false
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvRequerimientoBienes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRequerimientoBienes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequerimientoBienes.Size = New System.Drawing.Size(1290, 332)
        Me.dgvRequerimientoBienes.StandardTab = true
        Me.dgvRequerimientoBienes.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(710, 70)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Opciones de Registro"
        '
        'Button1
        '
        Me.Button1.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(514, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exportar Detalle a Excel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(258, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(250, 42)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar Registro de Requerimiento"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Guadar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(13, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(239, 42)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar y/o editar Requerimiento"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = true
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtJustificacion)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(728, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(581, 132)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Justificación"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificacion.Location = New System.Drawing.Point(9, 41)
        Me.txtJustificacion.MaxLength = 300
        Me.txtJustificacion.Multiline = true
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificacion.Size = New System.Drawing.Size(539, 78)
        Me.txtJustificacion.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(6, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Ingrese Justificación:"
        '
        'btnBuscarItems
        '
        Me.btnBuscarItems.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Buscar
        Me.btnBuscarItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarItems.Location = New System.Drawing.Point(6, 16)
        Me.btnBuscarItems.Name = "btnBuscarItems"
        Me.btnBuscarItems.Size = New System.Drawing.Size(279, 45)
        Me.btnBuscarItems.TabIndex = 17
        Me.btnBuscarItems.Text = "Buscar Items del Cuadro de Necesidades"
        Me.btnBuscarItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarItems.UseVisualStyleBackColor = true
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
        Me.gbCatalogo.Controls.Add(Me.Label10)
        Me.gbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbCatalogo.Location = New System.Drawing.Point(811, 460)
        Me.gbCatalogo.Name = "gbCatalogo"
        Me.gbCatalogo.Size = New System.Drawing.Size(73, 35)
        Me.gbCatalogo.TabIndex = 1
        Me.gbCatalogo.TabStop = false
        Me.gbCatalogo.Text = "Catalogo de Bienes"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
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
        Me.txtItem.Multiline = true
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = true
        Me.txtItem.Size = New System.Drawing.Size(362, 55)
        Me.txtItem.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = true
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
        Me.txtUnidadMedida.ReadOnly = true
        Me.txtUnidadMedida.Size = New System.Drawing.Size(94, 20)
        Me.txtUnidadMedida.TabIndex = 11
        '
        'txtCodigoItem
        '
        Me.txtCodigoItem.BackColor = System.Drawing.Color.White
        Me.txtCodigoItem.Location = New System.Drawing.Point(165, 132)
        Me.txtCodigoItem.Name = "txtCodigoItem"
        Me.txtCodigoItem.ReadOnly = true
        Me.txtCodigoItem.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoItem.TabIndex = 15
        '
        'txtCodigoUnidadMedida
        '
        Me.txtCodigoUnidadMedida.BackColor = System.Drawing.Color.White
        Me.txtCodigoUnidadMedida.Location = New System.Drawing.Point(165, 105)
        Me.txtCodigoUnidadMedida.Name = "txtCodigoUnidadMedida"
        Me.txtCodigoUnidadMedida.ReadOnly = true
        Me.txtCodigoUnidadMedida.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoUnidadMedida.TabIndex = 10
        '
        'txtFamilia
        '
        Me.txtFamilia.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Location = New System.Drawing.Point(208, 78)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.ReadOnly = true
        Me.txtFamilia.Size = New System.Drawing.Size(364, 20)
        Me.txtFamilia.TabIndex = 8
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.BackColor = System.Drawing.Color.White
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(165, 78)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.ReadOnly = true
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoFamilia.TabIndex = 7
        '
        'txtClase
        '
        Me.txtClase.BackColor = System.Drawing.Color.White
        Me.txtClase.Location = New System.Drawing.Point(208, 51)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.ReadOnly = true
        Me.txtClase.Size = New System.Drawing.Size(364, 20)
        Me.txtClase.TabIndex = 5
        '
        'txtCodigoClase
        '
        Me.txtCodigoClase.BackColor = System.Drawing.Color.White
        Me.txtCodigoClase.Location = New System.Drawing.Point(165, 51)
        Me.txtCodigoClase.Name = "txtCodigoClase"
        Me.txtCodigoClase.ReadOnly = true
        Me.txtCodigoClase.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoClase.TabIndex = 4
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.Color.White
        Me.txtGrupo.Location = New System.Drawing.Point(208, 24)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = true
        Me.txtGrupo.Size = New System.Drawing.Size(364, 20)
        Me.txtGrupo.TabIndex = 5
        '
        'txtCodigoGrupo
        '
        Me.txtCodigoGrupo.BackColor = System.Drawing.Color.White
        Me.txtCodigoGrupo.Location = New System.Drawing.Point(165, 24)
        Me.txtCodigoGrupo.Name = "txtCodigoGrupo"
        Me.txtCodigoGrupo.ReadOnly = true
        Me.txtCodigoGrupo.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoGrupo.TabIndex = 1
        '
        'txtEspecificaDetalle
        '
        Me.txtEspecificaDetalle.BackColor = System.Drawing.Color.White
        Me.txtEspecificaDetalle.Location = New System.Drawing.Point(550, 105)
        Me.txtEspecificaDetalle.Name = "txtEspecificaDetalle"
        Me.txtEspecificaDetalle.ReadOnly = true
        Me.txtEspecificaDetalle.Size = New System.Drawing.Size(20, 20)
        Me.txtEspecificaDetalle.TabIndex = 13
        Me.txtEspecificaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEspecifica
        '
        Me.txtEspecifica.BackColor = System.Drawing.Color.White
        Me.txtEspecifica.Location = New System.Drawing.Point(530, 105)
        Me.txtEspecifica.Name = "txtEspecifica"
        Me.txtEspecifica.ReadOnly = true
        Me.txtEspecifica.Size = New System.Drawing.Size(20, 20)
        Me.txtEspecifica.TabIndex = 13
        Me.txtEspecifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubGenericaDetalle
        '
        Me.txtSubGenericaDetalle.BackColor = System.Drawing.Color.White
        Me.txtSubGenericaDetalle.Location = New System.Drawing.Point(510, 105)
        Me.txtSubGenericaDetalle.Name = "txtSubGenericaDetalle"
        Me.txtSubGenericaDetalle.ReadOnly = true
        Me.txtSubGenericaDetalle.Size = New System.Drawing.Size(20, 20)
        Me.txtSubGenericaDetalle.TabIndex = 13
        Me.txtSubGenericaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubGenerica
        '
        Me.txtSubGenerica.BackColor = System.Drawing.Color.White
        Me.txtSubGenerica.Location = New System.Drawing.Point(490, 105)
        Me.txtSubGenerica.Name = "txtSubGenerica"
        Me.txtSubGenerica.ReadOnly = true
        Me.txtSubGenerica.Size = New System.Drawing.Size(20, 20)
        Me.txtSubGenerica.TabIndex = 13
        Me.txtSubGenerica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGenerica
        '
        Me.txtGenerica.BackColor = System.Drawing.Color.White
        Me.txtGenerica.Location = New System.Drawing.Point(470, 105)
        Me.txtGenerica.Name = "txtGenerica"
        Me.txtGenerica.ReadOnly = true
        Me.txtGenerica.Size = New System.Drawing.Size(20, 20)
        Me.txtGenerica.TabIndex = 13
        Me.txtGenerica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipoTransaccion
        '
        Me.txtTipoTransaccion.BackColor = System.Drawing.Color.White
        Me.txtTipoTransaccion.Location = New System.Drawing.Point(450, 105)
        Me.txtTipoTransaccion.Name = "txtTipoTransaccion"
        Me.txtTipoTransaccion.ReadOnly = true
        Me.txtTipoTransaccion.Size = New System.Drawing.Size(20, 20)
        Me.txtTipoTransaccion.TabIndex = 13
        Me.txtTipoTransaccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(308, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Clasificador Asociado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(20, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Familia Bien:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(20, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Clase Bien:"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(20, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Grupo Bien:"
        '
        'gbOriginal
        '
        Me.gbOriginal.Controls.Add(Me.txtDiciembre)
        Me.gbOriginal.Controls.Add(Me.txtJunio)
        Me.gbOriginal.Controls.Add(Me.Label23)
        Me.gbOriginal.Controls.Add(Me.Label18)
        Me.gbOriginal.Controls.Add(Me.txtNoviembre)
        Me.gbOriginal.Controls.Add(Me.txtMayo)
        Me.gbOriginal.Controls.Add(Me.Label22)
        Me.gbOriginal.Controls.Add(Me.Label19)
        Me.gbOriginal.Controls.Add(Me.txtOctubre)
        Me.gbOriginal.Controls.Add(Me.txtAbril)
        Me.gbOriginal.Controls.Add(Me.Label21)
        Me.gbOriginal.Controls.Add(Me.Label20)
        Me.gbOriginal.Controls.Add(Me.txtSeptiembre)
        Me.gbOriginal.Controls.Add(Me.txtMarzo)
        Me.gbOriginal.Controls.Add(Me.Label24)
        Me.gbOriginal.Controls.Add(Me.Label25)
        Me.gbOriginal.Controls.Add(Me.txtAgosto)
        Me.gbOriginal.Controls.Add(Me.txtFebrero)
        Me.gbOriginal.Controls.Add(Me.Label26)
        Me.gbOriginal.Controls.Add(Me.Label27)
        Me.gbOriginal.Controls.Add(Me.txtJulio)
        Me.gbOriginal.Controls.Add(Me.Label28)
        Me.gbOriginal.Controls.Add(Me.txtEnero)
        Me.gbOriginal.Controls.Add(Me.Label29)
        Me.gbOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbOriginal.Location = New System.Drawing.Point(908, 450)
        Me.gbOriginal.Name = "gbOriginal"
        Me.gbOriginal.Size = New System.Drawing.Size(229, 46)
        Me.gbOriginal.TabIndex = 6
        Me.gbOriginal.TabStop = false
        Me.gbOriginal.Text = "Cantidad / Importe Mensualizados"
        '
        'txtDiciembre
        '
        Me.txtDiciembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDiciembre.Location = New System.Drawing.Point(509, 71)
        Me.txtDiciembre.Name = "txtDiciembre"
        Me.txtDiciembre.Size = New System.Drawing.Size(65, 20)
        Me.txtDiciembre.TabIndex = 11
        Me.txtDiciembre.Text = "0.00"
        Me.txtDiciembre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJunio
        '
        Me.txtJunio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtJunio.Location = New System.Drawing.Point(217, 46)
        Me.txtJunio.Name = "txtJunio"
        Me.txtJunio.Size = New System.Drawing.Size(65, 20)
        Me.txtJunio.TabIndex = 5
        Me.txtJunio.Text = "0.00"
        Me.txtJunio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label23.Location = New System.Drawing.Point(436, 74)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Diciembre:"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.Location = New System.Drawing.Point(170, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Junio:"
        '
        'txtNoviembre
        '
        Me.txtNoviembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNoviembre.Location = New System.Drawing.Point(365, 71)
        Me.txtNoviembre.Name = "txtNoviembre"
        Me.txtNoviembre.Size = New System.Drawing.Size(65, 20)
        Me.txtNoviembre.TabIndex = 10
        Me.txtNoviembre.Text = "0.00"
        Me.txtNoviembre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMayo
        '
        Me.txtMayo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMayo.Location = New System.Drawing.Point(84, 47)
        Me.txtMayo.Name = "txtMayo"
        Me.txtMayo.Size = New System.Drawing.Size(65, 20)
        Me.txtMayo.TabIndex = 4
        Me.txtMayo.Text = "0.00"
        Me.txtMayo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.Location = New System.Drawing.Point(288, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Noviembre:"
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Mayo:"
        '
        'txtOctubre
        '
        Me.txtOctubre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtOctubre.Location = New System.Drawing.Point(217, 71)
        Me.txtOctubre.Name = "txtOctubre"
        Me.txtOctubre.Size = New System.Drawing.Size(65, 20)
        Me.txtOctubre.TabIndex = 9
        Me.txtOctubre.Text = "0.00"
        Me.txtOctubre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAbril
        '
        Me.txtAbril.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtAbril.Location = New System.Drawing.Point(509, 21)
        Me.txtAbril.Name = "txtAbril"
        Me.txtAbril.Size = New System.Drawing.Size(65, 20)
        Me.txtAbril.TabIndex = 3
        Me.txtAbril.Text = "0.00"
        Me.txtAbril.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label21.Location = New System.Drawing.Point(155, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Octubre:"
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label20.Location = New System.Drawing.Point(467, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Abril:"
        '
        'txtSeptiembre
        '
        Me.txtSeptiembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSeptiembre.Location = New System.Drawing.Point(84, 72)
        Me.txtSeptiembre.Name = "txtSeptiembre"
        Me.txtSeptiembre.Size = New System.Drawing.Size(65, 20)
        Me.txtSeptiembre.TabIndex = 8
        Me.txtSeptiembre.Text = "0.00"
        Me.txtSeptiembre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarzo
        '
        Me.txtMarzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMarzo.Location = New System.Drawing.Point(365, 21)
        Me.txtMarzo.Name = "txtMarzo"
        Me.txtMarzo.Size = New System.Drawing.Size(65, 20)
        Me.txtMarzo.TabIndex = 2
        Me.txtMarzo.Text = "0.00"
        Me.txtMarzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label24.Location = New System.Drawing.Point(4, 74)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Septiembre:"
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.Location = New System.Drawing.Point(314, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Marzo:"
        '
        'txtAgosto
        '
        Me.txtAgosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtAgosto.Location = New System.Drawing.Point(509, 46)
        Me.txtAgosto.Name = "txtAgosto"
        Me.txtAgosto.Size = New System.Drawing.Size(65, 20)
        Me.txtAgosto.TabIndex = 7
        Me.txtAgosto.Text = "0.00"
        Me.txtAgosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFebrero
        '
        Me.txtFebrero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFebrero.Location = New System.Drawing.Point(217, 21)
        Me.txtFebrero.Name = "txtFebrero"
        Me.txtFebrero.Size = New System.Drawing.Size(65, 20)
        Me.txtFebrero.TabIndex = 1
        Me.txtFebrero.Text = "0.00"
        Me.txtFebrero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label26.Location = New System.Drawing.Point(453, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Agosto:"
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.Location = New System.Drawing.Point(157, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Febrero:"
        '
        'txtJulio
        '
        Me.txtJulio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtJulio.Location = New System.Drawing.Point(365, 46)
        Me.txtJulio.Name = "txtJulio"
        Me.txtJulio.Size = New System.Drawing.Size(65, 20)
        Me.txtJulio.TabIndex = 6
        Me.txtJulio.Text = "0.00"
        Me.txtJulio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label28.Location = New System.Drawing.Point(322, 50)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(37, 13)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "Julio:"
        '
        'txtEnero
        '
        Me.txtEnero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtEnero.Location = New System.Drawing.Point(84, 22)
        Me.txtEnero.Name = "txtEnero"
        Me.txtEnero.Size = New System.Drawing.Size(65, 20)
        Me.txtEnero.TabIndex = 0
        Me.txtEnero.Text = "0.00"
        Me.txtEnero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label29.Location = New System.Drawing.Point(34, 25)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Enero:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBuscarItems)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(728, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(581, 70)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Opciones de Búsqueda de Bienes del C.N."
        '
        'frmRegistro_Requerimiento_Bienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 590)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbDetalle)
        Me.Controls.Add(Me.gbCatalogo)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtSaldoMes)
        Me.Controls.Add(Me.txtSaldoTotalCN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbOriginal)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRegistro_Requerimiento_Bienes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Registro General de Requerimiento de Bienes ::.."
        Me.gbDatosGenerales.ResumeLayout(false)
        Me.gbDatosGenerales.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.gbDetalle.ResumeLayout(false)
        CType(Me.dgvRequerimientoBienes,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.gbCatalogo.ResumeLayout(false)
        Me.gbCatalogo.PerformLayout
        Me.gbOriginal.ResumeLayout(false)
        Me.gbOriginal.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents dgvRequerimientoBienes As System.Windows.Forms.DataGridView
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
    Friend WithEvents txtSaldoTotalCN As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSaldoMes As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gbOriginal As GroupBox
    Friend WithEvents txtDiciembre As TextBox
    Friend WithEvents txtJunio As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNoviembre As TextBox
    Friend WithEvents txtMayo As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtOctubre As TextBox
    Friend WithEvents txtAbril As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSeptiembre As TextBox
    Friend WithEvents txtMarzo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtAgosto As TextBox
    Friend WithEvents txtFebrero As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtJulio As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtEnero As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
