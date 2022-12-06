<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModulo_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModulo_Usuarios))
        Me.ribbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar
        Me.Boton_Salir = New DevComponents.DotNetBar.ButtonItem
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.Boton_Nuevo_Usuario = New DevComponents.DotNetBar.ButtonItem
        Me.Boton_Editar_Usuario = New DevComponents.DotNetBar.ButtonItem
        Me.Boton_Eliminar_Usuario = New DevComponents.DotNetBar.ButtonItem
        Me.Boton_Anular_Usuario = New DevComponents.DotNetBar.ButtonItem
        Me.Boton_Asignar_Accesos_Usuario = New DevComponents.DotNetBar.ButtonItem
        Me.Boton_Actualizar_Registros = New DevComponents.DotNetBar.ButtonItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblRegistros = New System.Windows.Forms.Label
        Me.gbFiltros = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtDatos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbCriterio = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ribbonBarMergeContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonBarMergeContainer1
        '
        Me.ribbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBarMergeContainer1.Controls.Add(Me.RibbonBar3)
        Me.ribbonBarMergeContainer1.Controls.Add(Me.ribbonBar1)
        Me.ribbonBarMergeContainer1.Location = New System.Drawing.Point(384, 588)
        Me.ribbonBarMergeContainer1.Name = "ribbonBarMergeContainer1"
        Me.ribbonBarMergeContainer1.RibbonTabText = "Opciones de Registro de Usuarios"
        Me.ribbonBarMergeContainer1.Size = New System.Drawing.Size(681, 83)
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
        Me.ribbonBarMergeContainer1.Visible = False
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.DragDropSupport = True
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Salir})
        Me.RibbonBar3.Location = New System.Drawing.Point(310, 0)
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
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar1.ContainerControlProcessDialogKey = True
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.DragDropSupport = True
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Nuevo_Usuario, Me.Boton_Editar_Usuario, Me.Boton_Eliminar_Usuario, Me.Boton_Anular_Usuario, Me.Boton_Asignar_Accesos_Usuario, Me.Boton_Actualizar_Registros})
        Me.ribbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(310, 83)
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
        'Boton_Nuevo_Usuario
        '
        Me.Boton_Nuevo_Usuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Nuevo_Usuario.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Nuevo
        Me.Boton_Nuevo_Usuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Nuevo_Usuario.Name = "Boton_Nuevo_Usuario"
        Me.Boton_Nuevo_Usuario.Text = "<div align=""center"">Nuevo<br/>Usuario</div>"
        '
        'Boton_Editar_Usuario
        '
        Me.Boton_Editar_Usuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Editar_Usuario.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Editar
        Me.Boton_Editar_Usuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Editar_Usuario.Name = "Boton_Editar_Usuario"
        Me.Boton_Editar_Usuario.Text = "<div align=""center"">Ediar<br/>Usuario</div>"
        '
        'Boton_Eliminar_Usuario
        '
        Me.Boton_Eliminar_Usuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Eliminar_Usuario.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Eliminar
        Me.Boton_Eliminar_Usuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Eliminar_Usuario.Name = "Boton_Eliminar_Usuario"
        Me.Boton_Eliminar_Usuario.Text = "<div align=""center"">Eliminar<br/>Usuario</div>"
        '
        'Boton_Anular_Usuario
        '
        Me.Boton_Anular_Usuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Anular_Usuario.Image = Global.SAG_SBLM.My.Resources.Resources.Cancelar_Formato
        Me.Boton_Anular_Usuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Anular_Usuario.Name = "Boton_Anular_Usuario"
        Me.Boton_Anular_Usuario.Text = "<div align=""center"">Anular<br/>Usuario</div>"
        '
        'Boton_Asignar_Accesos_Usuario
        '
        Me.Boton_Asignar_Accesos_Usuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Asignar_Accesos_Usuario.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Aprobacion_Requerimiento
        Me.Boton_Asignar_Accesos_Usuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Asignar_Accesos_Usuario.Name = "Boton_Asignar_Accesos_Usuario"
        Me.Boton_Asignar_Accesos_Usuario.Text = "<div align=""center"">Asignar<br/>Accesos</div>"
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 451)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1041, 426)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblRegistros)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 542)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1053, 40)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(6, 16)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(0, 13)
        Me.lblRegistros.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbFiltros.Controls.Add(Me.GroupBox3)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1053, 73)
        Me.gbFiltros.TabIndex = 7
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Opciones de Filtro..."
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
        Me.GroupBox3.Size = New System.Drawing.Size(1038, 48)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(945, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDatos
        '
        Me.txtDatos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatos.Enabled = False
        Me.txtDatos.Location = New System.Drawing.Point(468, 13)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(471, 20)
        Me.txtDatos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Texto a Buscar:"
        '
        'cbCriterio
        '
        Me.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriterio.FormattingEnabled = True
        Me.cbCriterio.Location = New System.Drawing.Point(129, 13)
        Me.cbCriterio.Name = "cbCriterio"
        Me.cbCriterio.Size = New System.Drawing.Size(236, 21)
        Me.cbCriterio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione criterio:"
        '
        'frmModulo_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 675)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ribbonBarMergeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModulo_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Módulo de Registro de Usuarios del Sistema ::.."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ribbonBarMergeContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbFiltros.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ribbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Nuevo_Usuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Editar_Usuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Eliminar_Usuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Actualizar_Registros As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Asignar_Accesos_Usuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Salir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Anular_Usuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
