<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModulo_CN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModulo_CN))
        Me.ribbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Salir = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Imprimir_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Visualizar_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Visualizar_Saldos_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Exportar_Excel_CN_General = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Reporte_General_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Autorizar_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Aprobar_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Nuevo_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Editar_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Eliminar_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Extornar_CN = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Actualizar_Registros = New DevComponents.DotNetBar.ButtonItem()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbUnidadOrganica = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCuadroDeNecesidades = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.ribbonBarMergeContainer1.SuspendLayout
        Me.gbFiltros.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.dgvCuadroDeNecesidades,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'ribbonBarMergeContainer1
        '
        Me.ribbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBarMergeContainer1.Controls.Add(Me.RibbonBar3)
        Me.ribbonBarMergeContainer1.Controls.Add(Me.RibbonBar4)
        Me.ribbonBarMergeContainer1.Controls.Add(Me.RibbonBar2)
        Me.ribbonBarMergeContainer1.Controls.Add(Me.ribbonBar1)
        Me.ribbonBarMergeContainer1.Location = New System.Drawing.Point(12, 588)
        Me.ribbonBarMergeContainer1.Name = "ribbonBarMergeContainer1"
        Me.ribbonBarMergeContainer1.RibbonTabText = "Opciones del CN"
        Me.ribbonBarMergeContainer1.Size = New System.Drawing.Size(1053, 83)
        '
        '
        '
        Me.ribbonBarMergeContainer1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBarMergeContainer1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBarMergeContainer1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBarMergeContainer1.TabIndex = 5
        Me.ribbonBarMergeContainer1.Visible = false
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = true
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.DragDropSupport = true
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Salir})
        Me.RibbonBar3.Location = New System.Drawing.Point(710, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(69, 83)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar3.TabIndex = 4
        Me.RibbonBar3.Text = "Salir"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Salir
        '
        Me.Boton_Salir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Salir.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Salir
        Me.Boton_Salir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Text = "<div align=""center"">Retornar<br/>Al Menú</div>"
        '
        'RibbonBar4
        '
        Me.RibbonBar4.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar4.ContainerControlProcessDialogKey = true
        Me.RibbonBar4.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar4.DragDropSupport = true
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Imprimir_CN, Me.Boton_Visualizar_CN, Me.Boton_Visualizar_Saldos_CN, Me.Boton_Exportar_Excel_CN_General, Me.Boton_Reporte_General_CN})
        Me.RibbonBar4.Location = New System.Drawing.Point(371, 0)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(339, 83)
        Me.RibbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar4.TabIndex = 3
        Me.RibbonBar4.Text = "Reportes Individuales"
        '
        '
        '
        Me.RibbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Imprimir_CN
        '
        Me.Boton_Imprimir_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Imprimir_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Estadistica
        Me.Boton_Imprimir_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Imprimir_CN.Name = "Boton_Imprimir_CN"
        Me.Boton_Imprimir_CN.Text = "<div align=""center"">Ver C.N.<br/>por B. y S.</div>"
        '
        'Boton_Visualizar_CN
        '
        Me.Boton_Visualizar_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Visualizar_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Reportar
        Me.Boton_Visualizar_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Visualizar_CN.Name = "Boton_Visualizar_CN"
        Me.Boton_Visualizar_CN.Text = "<div align=""center"">Ver<br/>C.N. por S/.</div>"
        '
        'Boton_Visualizar_Saldos_CN
        '
        Me.Boton_Visualizar_Saldos_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Visualizar_Saldos_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Registro_Prevision
        Me.Boton_Visualizar_Saldos_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Visualizar_Saldos_CN.Name = "Boton_Visualizar_Saldos_CN"
        Me.Boton_Visualizar_Saldos_CN.Text = "<div align=""center"">Ver<br/>Saldos</div>"
        '
        'Boton_Exportar_Excel_CN_General
        '
        Me.Boton_Exportar_Excel_CN_General.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Exportar_Excel_CN_General.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Planillas
        Me.Boton_Exportar_Excel_CN_General.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Exportar_Excel_CN_General.Name = "Boton_Exportar_Excel_CN_General"
        Me.Boton_Exportar_Excel_CN_General.Text = "<div align=""center"">Agrupado por<br/>Item y U.O.</div>"
        '
        'Boton_Reporte_General_CN
        '
        Me.Boton_Reporte_General_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Reporte_General_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Proveedores
        Me.Boton_Reporte_General_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Reporte_General_CN.Name = "Boton_Reporte_General_CN"
        Me.Boton_Reporte_General_CN.Text = "<div align=""center"">Reporte<br/>C.N. General</div>"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = true
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.DragDropSupport = true
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Autorizar_CN, Me.Boton_Aprobar_CN})
        Me.RibbonBar2.Location = New System.Drawing.Point(258, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(113, 83)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar2.TabIndex = 1
        Me.RibbonBar2.Text = "Aprobaciones"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Autorizar_CN
        '
        Me.Boton_Autorizar_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Autorizar_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Autorizar
        Me.Boton_Autorizar_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Autorizar_CN.Name = "Boton_Autorizar_CN"
        Me.Boton_Autorizar_CN.Text = "<div align=""center"">Autorizar<br/>C.N.</div>"
        '
        'Boton_Aprobar_CN
        '
        Me.Boton_Aprobar_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Aprobar_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Aprobacion_Requerimiento
        Me.Boton_Aprobar_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Aprobar_CN.Name = "Boton_Aprobar_CN"
        Me.Boton_Aprobar_CN.Text = "<div align=""center"">Aprobar<br/>C.N.</div>"
        '
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = true
        '
        '
        '
        Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar1.ContainerControlProcessDialogKey = true
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.DragDropSupport = true
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Nuevo_CN, Me.Boton_Editar_CN, Me.Boton_Eliminar_CN, Me.Boton_Extornar_CN, Me.Boton_Actualizar_Registros})
        Me.ribbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(258, 83)
        Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBar1.TabIndex = 0
        Me.ribbonBar1.Text = "Opciones Básicas"
        '
        '
        '
        Me.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Nuevo_CN
        '
        Me.Boton_Nuevo_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Nuevo_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Nuevo
        Me.Boton_Nuevo_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Nuevo_CN.Name = "Boton_Nuevo_CN"
        Me.Boton_Nuevo_CN.Text = "<div align=""center"">Nuevo<br/>C.N.</div>"
        '
        'Boton_Editar_CN
        '
        Me.Boton_Editar_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Editar_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Editar
        Me.Boton_Editar_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Editar_CN.Name = "Boton_Editar_CN"
        Me.Boton_Editar_CN.Text = "<div align=""center"">Editar<br/>C.N.</div>"
        '
        'Boton_Eliminar_CN
        '
        Me.Boton_Eliminar_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Eliminar_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Eliminar
        Me.Boton_Eliminar_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Eliminar_CN.Name = "Boton_Eliminar_CN"
        Me.Boton_Eliminar_CN.Text = "<div align=""center"">Eliminar<br/>C.N.</div>"
        '
        'Boton_Extornar_CN
        '
        Me.Boton_Extornar_CN.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Extornar_CN.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Extornar
        Me.Boton_Extornar_CN.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Extornar_CN.Name = "Boton_Extornar_CN"
        Me.Boton_Extornar_CN.Text = "<div align=""center"">Extornar<br/>C.N.</div>"
        '
        'Boton_Actualizar_Registros
        '
        Me.Boton_Actualizar_Registros.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Actualizar_Registros.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Actualizar
        Me.Boton_Actualizar_Registros.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Actualizar_Registros.Name = "Boton_Actualizar_Registros"
        Me.Boton_Actualizar_Registros.Text = "<div align=""center"">Actualizar<br/>Registros</div>"
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbFiltros.Controls.Add(Me.cbEstado)
        Me.gbFiltros.Controls.Add(Me.Label2)
        Me.gbFiltros.Controls.Add(Me.cbUnidadOrganica)
        Me.gbFiltros.Controls.Add(Me.Label1)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1053, 54)
        Me.gbFiltros.TabIndex = 6
        Me.gbFiltros.TabStop = false
        Me.gbFiltros.Text = "Opciones de Filtro..."
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = true
        Me.cbEstado.Location = New System.Drawing.Point(854, 19)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(160, 21)
        Me.cbEstado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(774, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado C.N.:"
        '
        'cbUnidadOrganica
        '
        Me.cbUnidadOrganica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadOrganica.FormattingEnabled = true
        Me.cbUnidadOrganica.Location = New System.Drawing.Point(146, 19)
        Me.cbUnidadOrganica.Name = "cbUnidadOrganica"
        Me.cbUnidadOrganica.Size = New System.Drawing.Size(617, 21)
        Me.cbUnidadOrganica.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad Orgánica:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.dgvCuadroDeNecesidades)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 464)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = false
        '
        'dgvCuadroDeNecesidades
        '
        Me.dgvCuadroDeNecesidades.AllowUserToAddRows = false
        Me.dgvCuadroDeNecesidades.AllowUserToDeleteRows = false
        Me.dgvCuadroDeNecesidades.AllowUserToResizeColumns = false
        Me.dgvCuadroDeNecesidades.AllowUserToResizeRows = false
        Me.dgvCuadroDeNecesidades.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuadroDeNecesidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCuadroDeNecesidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuadroDeNecesidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCuadroDeNecesidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCuadroDeNecesidades.EnableHeadersVisualStyles = false
        Me.dgvCuadroDeNecesidades.Location = New System.Drawing.Point(6, 19)
        Me.dgvCuadroDeNecesidades.MultiSelect = false
        Me.dgvCuadroDeNecesidades.Name = "dgvCuadroDeNecesidades"
        Me.dgvCuadroDeNecesidades.RowHeadersVisible = false
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvCuadroDeNecesidades.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCuadroDeNecesidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuadroDeNecesidades.Size = New System.Drawing.Size(1041, 439)
        Me.dgvCuadroDeNecesidades.StandardTab = true
        Me.dgvCuadroDeNecesidades.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblRegistros)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 542)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1053, 40)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = false
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = true
        Me.lblRegistros.Location = New System.Drawing.Point(6, 16)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(0, 13)
        Me.lblRegistros.TabIndex = 0
        '
        'frmModulo_CN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 675)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.ribbonBarMergeContainer1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmModulo_CN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Módulo de Registro del Cuadro de Necesidades ::.."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ribbonBarMergeContainer1.ResumeLayout(false)
        Me.gbFiltros.ResumeLayout(false)
        Me.gbFiltros.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.dgvCuadroDeNecesidades,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ribbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Nuevo_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Editar_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Eliminar_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Actualizar_Registros As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Autorizar_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Aprobar_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Extornar_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents cbUnidadOrganica As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCuadroDeNecesidades As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Salir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Visualizar_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Imprimir_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Visualizar_Saldos_CN As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Exportar_Excel_CN_General As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Reporte_General_CN As DevComponents.DotNetBar.ButtonItem
End Class
