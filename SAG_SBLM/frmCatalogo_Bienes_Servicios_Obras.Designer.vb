<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogo_Bienes_Servicios_Obras
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogo_Bienes_Servicios_Obras))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarGlosaAlPortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenteParaDuplicidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.gbTextos = New System.Windows.Forms.GroupBox()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtDatos = New System.Windows.Forms.TextBox()
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
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ContextMenuStrip1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.gbFiltros.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.gbTextos.SuspendLayout
        Me.gbCombos.SuspendLayout
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AllowUserToResizeColumns = false
        Me.DataGridView1.AllowUserToResizeRows = false
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = false
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = false
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.RowHeadersVisible = false
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(908, 428)
        Me.DataGridView1.StandardTab = true
        Me.DataGridView1.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarGlosaAlPortapapelesToolStripMenuItem, Me.CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem, Me.AsistenteParaDuplicidadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(330, 70)
        '
        'CopiarGlosaAlPortapapelesToolStripMenuItem
        '
        Me.CopiarGlosaAlPortapapelesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.CopiarGlosaAlPortapapelesToolStripMenuItem.Name = "CopiarGlosaAlPortapapelesToolStripMenuItem"
        Me.CopiarGlosaAlPortapapelesToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.CopiarGlosaAlPortapapelesToolStripMenuItem.Text = "..:: Copiar Codigo al Portapapeles ::.."
        '
        'CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem
        '
        Me.CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem.Name = "CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem"
        Me.CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem.Text = "..:: Copiar Descripcion al Portapapeles :..."
        '
        'AsistenteParaDuplicidadToolStripMenuItem
        '
        Me.AsistenteParaDuplicidadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.AsistenteParaDuplicidadToolStripMenuItem.Name = "AsistenteParaDuplicidadToolStripMenuItem"
        Me.AsistenteParaDuplicidadToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.AsistenteParaDuplicidadToolStripMenuItem.Text = "..:: Copiar Unidad de Medida al Portapapeles ::.."
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(836, 621)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 44)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 453)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = false
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = true
        Me.lblRegistros.Location = New System.Drawing.Point(13, 16)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(0, 13)
        Me.lblRegistros.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblRegistros)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 575)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(922, 40)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = false
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAceptar.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(732, 621)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 44)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.GroupBox1)
        Me.gbFiltros.Controls.Add(Me.gbCombos)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbFiltros.Location = New System.Drawing.Point(12, 3)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(922, 113)
        Me.gbFiltros.TabIndex = 0
        Me.gbFiltros.TabStop = false
        Me.gbFiltros.Text = "..::Opciones de Filtros de Busqueda ::.."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.gbTextos)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 71)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "..::  Filtros Avanzados ::.."
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(137, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = true
        Me.RadioButton2.Text = "Por Código de Ítem:"
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(165, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.Text = "Por Descripción de Ítem:"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'gbTextos
        '
        Me.gbTextos.Controls.Add(Me.lblBusqueda)
        Me.gbTextos.Controls.Add(Me.txtDatos)
        Me.gbTextos.Location = New System.Drawing.Point(193, 19)
        Me.gbTextos.Name = "gbTextos"
        Me.gbTextos.Size = New System.Drawing.Size(691, 40)
        Me.gbTextos.TabIndex = 1
        Me.gbTextos.TabStop = false
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = true
        Me.lblBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBusqueda.Location = New System.Drawing.Point(13, 16)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(0, 13)
        Me.lblBusqueda.TabIndex = 0
        '
        'txtDatos
        '
        Me.txtDatos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatos.Location = New System.Drawing.Point(196, 14)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(489, 20)
        Me.txtDatos.TabIndex = 1
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
        Me.gbCombos.Location = New System.Drawing.Point(16, 19)
        Me.gbCombos.Name = "gbCombos"
        Me.gbCombos.Size = New System.Drawing.Size(28, 19)
        Me.gbCombos.TabIndex = 0
        Me.gbCombos.TabStop = false
        Me.gbCombos.Visible = false
        '
        'btnBuscarFamilia
        '
        Me.btnBuscarFamilia.Location = New System.Drawing.Point(812, 65)
        Me.btnBuscarFamilia.Name = "btnBuscarFamilia"
        Me.btnBuscarFamilia.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarFamilia.TabIndex = 8
        Me.btnBuscarFamilia.Text = "Buscar"
        Me.btnBuscarFamilia.UseVisualStyleBackColor = true
        '
        'btnBuscarClase
        '
        Me.btnBuscarClase.Location = New System.Drawing.Point(812, 38)
        Me.btnBuscarClase.Name = "btnBuscarClase"
        Me.btnBuscarClase.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarClase.TabIndex = 5
        Me.btnBuscarClase.Text = "Buscar"
        Me.btnBuscarClase.UseVisualStyleBackColor = true
        '
        'btnBuscarGrupo
        '
        Me.btnBuscarGrupo.Location = New System.Drawing.Point(812, 11)
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
        Me.cbFamilia.Location = New System.Drawing.Point(196, 67)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(610, 21)
        Me.cbFamilia.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seleccionar Familia:"
        '
        'cbClase
        '
        Me.cbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClase.FormattingEnabled = true
        Me.cbClase.Location = New System.Drawing.Point(196, 40)
        Me.cbClase.Name = "cbClase"
        Me.cbClase.Size = New System.Drawing.Size(610, 21)
        Me.cbClase.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccionar Clase:"
        '
        'cbGrupo
        '
        Me.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupo.FormattingEnabled = true
        Me.cbGrupo.Location = New System.Drawing.Point(196, 13)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(610, 21)
        Me.cbGrupo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar Grupo:"
        '
        'frmCatalogo_Bienes_Servicios_Obras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 677)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAceptar)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmCatalogo_Bienes_Servicios_Obras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.gbFiltros.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.gbTextos.ResumeLayout(false)
        Me.gbTextos.PerformLayout
        Me.gbCombos.ResumeLayout(false)
        Me.gbCombos.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents gbTextos As System.Windows.Forms.GroupBox
    Friend WithEvents lblBusqueda As System.Windows.Forms.Label
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents gbCombos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarGrupo As System.Windows.Forms.Button
    Friend WithEvents btnBuscarFamilia As System.Windows.Forms.Button
    Friend WithEvents btnBuscarClase As System.Windows.Forms.Button
    Friend WithEvents cbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarGlosaAlPortapapelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarRUCDelProveedorAlPortapapelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsistenteParaDuplicidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
