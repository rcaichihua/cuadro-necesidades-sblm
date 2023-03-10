<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModulo_Requerimiento_Servicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModulo_Requerimiento_Servicios))
        Me.ribbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Salir = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Visualizar_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Imprimir_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Autorizar_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Aprobar_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Nuevo_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Editar_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Eliminar_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Extornar_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Anular_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Actualizar_Registros = New DevComponents.DotNetBar.ButtonItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbUnidadOrganica = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCriterio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ribbonBarMergeContainer1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.gbFiltros.SuspendLayout
        Me.GroupBox6.SuspendLayout
        Me.GroupBox5.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.GroupBox3.SuspendLayout
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
        Me.ribbonBarMergeContainer1.RibbonTabText = "Opciones de Requerimiento de Servicios"
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
        Me.RibbonBar3.Location = New System.Drawing.Point(818, 0)
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
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios})
        Me.RibbonBar4.Location = New System.Drawing.Point(645, 0)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(173, 83)
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
        'Boton_Visualizar_Requerimiento_Servicios
        '
        Me.Boton_Visualizar_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Visualizar_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Reportar
        Me.Boton_Visualizar_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Visualizar_Requerimiento_Servicios.Name = "Boton_Visualizar_Requerimiento_Servicios"
        Me.Boton_Visualizar_Requerimiento_Servicios.Text = "<div align=""center"">Visualizar<br/>Requerimiento</div>"
        '
        'Boton_Imprimir_Requerimiento_Servicios
        '
        Me.Boton_Imprimir_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Imprimir_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Reporte_General
        Me.Boton_Imprimir_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Imprimir_Requerimiento_Servicios.Name = "Boton_Imprimir_Requerimiento_Servicios"
        Me.Boton_Imprimir_Requerimiento_Servicios.Text = "<div align=""center"">Imprimir<br/>Requerimiento</div>"
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
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Autorizar_Requerimiento_Servicios, Me.Boton_Aprobar_Requerimiento_Servicios})
        Me.RibbonBar2.Location = New System.Drawing.Point(477, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(168, 83)
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
        'Boton_Autorizar_Requerimiento_Servicios
        '
        Me.Boton_Autorizar_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Autorizar_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Autorizar
        Me.Boton_Autorizar_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Autorizar_Requerimiento_Servicios.Name = "Boton_Autorizar_Requerimiento_Servicios"
        Me.Boton_Autorizar_Requerimiento_Servicios.Text = "<div align=""center"">Autorizar<br/>Requerimiento</div>"
        '
        'Boton_Aprobar_Requerimiento_Servicios
        '
        Me.Boton_Aprobar_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Aprobar_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Aprobacion_Requerimiento
        Me.Boton_Aprobar_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Aprobar_Requerimiento_Servicios.Name = "Boton_Aprobar_Requerimiento_Servicios"
        Me.Boton_Aprobar_Requerimiento_Servicios.Text = "<div align=""center"">Aprobar<br/>Requerimiento</div>"
        Me.Boton_Aprobar_Requerimiento_Servicios.Visible = false
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
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Nuevo_Requerimiento_Servicios, Me.Boton_Editar_Requerimiento_Servicios, Me.Boton_Eliminar_Requerimiento_Servicios, Me.Boton_Extornar_Requerimiento_Servicios, Me.Boton_Anular_Requerimiento_Servicios, Me.Boton_Actualizar_Registros})
        Me.ribbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(477, 83)
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
        'Boton_Nuevo_Requerimiento_Servicios
        '
        Me.Boton_Nuevo_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Nuevo_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Nuevo
        Me.Boton_Nuevo_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Nuevo_Requerimiento_Servicios.Name = "Boton_Nuevo_Requerimiento_Servicios"
        Me.Boton_Nuevo_Requerimiento_Servicios.Text = "<div align=""center"">Nuevo<br/>Requerimiento</div>"
        '
        'Boton_Editar_Requerimiento_Servicios
        '
        Me.Boton_Editar_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Editar_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Editar
        Me.Boton_Editar_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Editar_Requerimiento_Servicios.Name = "Boton_Editar_Requerimiento_Servicios"
        Me.Boton_Editar_Requerimiento_Servicios.Text = "<div align=""center"">Editar<br/>Requerimiento</div>"
        '
        'Boton_Eliminar_Requerimiento_Servicios
        '
        Me.Boton_Eliminar_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Eliminar_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Eliminar
        Me.Boton_Eliminar_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Eliminar_Requerimiento_Servicios.Name = "Boton_Eliminar_Requerimiento_Servicios"
        Me.Boton_Eliminar_Requerimiento_Servicios.Text = "<div align=""center"">Eliminar<br/>Requerimiento</div>"
        '
        'Boton_Extornar_Requerimiento_Servicios
        '
        Me.Boton_Extornar_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Extornar_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Extornar
        Me.Boton_Extornar_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Extornar_Requerimiento_Servicios.Name = "Boton_Extornar_Requerimiento_Servicios"
        Me.Boton_Extornar_Requerimiento_Servicios.Text = "<div align=""center"">Extornar<br/>Requerimiento</div>"
        '
        'Boton_Anular_Requerimiento_Servicios
        '
        Me.Boton_Anular_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Anular_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Cancelar_Formato
        Me.Boton_Anular_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Anular_Requerimiento_Servicios.Name = "Boton_Anular_Requerimiento_Servicios"
        Me.Boton_Anular_Requerimiento_Servicios.Text = "<div align=""center"">Anular<br/>Requerimiento</div>"
        '
        'Boton_Actualizar_Registros
        '
        Me.Boton_Actualizar_Registros.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Actualizar_Registros.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Actualizar
        Me.Boton_Actualizar_Registros.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Actualizar_Registros.Name = "Boton_Actualizar_Registros"
        Me.Boton_Actualizar_Registros.Text = "<div align=""center"">Actualizar<br/>Registros</div>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1140, 389)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = false
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AllowUserToResizeColumns = false
        Me.DataGridView1.AllowUserToResizeRows = false
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = false
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = false
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = false
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1128, 364)
        Me.DataGridView1.StandardTab = true
        Me.DataGridView1.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblRegistros)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 542)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1140, 40)
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
        'gbFiltros
        '
        Me.gbFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbFiltros.Controls.Add(Me.GroupBox6)
        Me.gbFiltros.Controls.Add(Me.GroupBox5)
        Me.gbFiltros.Controls.Add(Me.GroupBox4)
        Me.gbFiltros.Controls.Add(Me.GroupBox3)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1140, 129)
        Me.gbFiltros.TabIndex = 10
        Me.gbFiltros.TabStop = false
        Me.gbFiltros.Text = "Opciones de Búsqueda Avanzada..."
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbUnidadOrganica)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 73)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(813, 48)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = false
        Me.GroupBox6.Text = "Seleccione la Unidad Orgánica"
        '
        'cbUnidadOrganica
        '
        Me.cbUnidadOrganica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadOrganica.FormattingEnabled = true
        Me.cbUnidadOrganica.Location = New System.Drawing.Point(15, 19)
        Me.cbUnidadOrganica.Name = "cbUnidadOrganica"
        Me.cbUnidadOrganica.Size = New System.Drawing.Size(792, 21)
        Me.cbUnidadOrganica.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbMes)
        Me.GroupBox5.Location = New System.Drawing.Point(992, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 48)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = false
        Me.GroupBox5.Text = "Seleccione Mes"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.FormattingEnabled = true
        Me.cbMes.Location = New System.Drawing.Point(15, 19)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(115, 21)
        Me.cbMes.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbEstado)
        Me.GroupBox4.Location = New System.Drawing.Point(828, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 48)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Seleccione Estado"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = true
        Me.cbEstado.Location = New System.Drawing.Point(15, 19)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(127, 21)
        Me.cbEstado.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.txtDatos)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbCriterio)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(813, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Por Campos Basicos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(732, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = true
        '
        'txtDatos
        '
        Me.txtDatos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatos.Enabled = false
        Me.txtDatos.Location = New System.Drawing.Point(435, 21)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(291, 20)
        Me.txtDatos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(290, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingrese Texto a Buscar:"
        '
        'cbCriterio
        '
        Me.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriterio.FormattingEnabled = true
        Me.cbCriterio.Location = New System.Drawing.Point(129, 21)
        Me.cbCriterio.Name = "cbCriterio"
        Me.cbCriterio.Size = New System.Drawing.Size(155, 21)
        Me.cbCriterio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione Campo:"
        '
        'frmModulo_Requerimiento_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 675)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ribbonBarMergeContainer1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmModulo_Requerimiento_Servicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Módulo de Registro Requerimiento de Servicios ::.."
        Me.ribbonBarMergeContainer1.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.gbFiltros.ResumeLayout(false)
        Me.GroupBox6.ResumeLayout(false)
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ribbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Nuevo_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Editar_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Eliminar_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Actualizar_Registros As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Autorizar_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Aprobar_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Extornar_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Salir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Visualizar_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Imprimir_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Anular_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cbUnidadOrganica As System.Windows.Forms.ComboBox

End Class
