<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltrarItemsCatalogoCN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiltrarItemsCatalogoCN))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDistribucionCn = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFF = New System.Windows.Forms.ComboBox()
        Me.cbUnidadOrganica = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDetalle.SuspendLayout
        CType(Me.dgvDistribucionCn,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox3.SuspendLayout
        Me.SuspendLayout
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Aprobacion_Requerimiento
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(955, 14)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(158, 42)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar al Detalle"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.dgvDistribucionCn)
        Me.gbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbDetalle.Location = New System.Drawing.Point(12, 12)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(1285, 485)
        Me.gbDetalle.TabIndex = 5
        Me.gbDetalle.TabStop = false
        Me.gbDetalle.Text = "[ Listado Bienes y Servicios Cuadro de Necesidades ]"
        '
        'dgvDistribucionCn
        '
        Me.dgvDistribucionCn.AllowUserToAddRows = false
        Me.dgvDistribucionCn.AllowUserToDeleteRows = false
        Me.dgvDistribucionCn.AllowUserToResizeColumns = false
        Me.dgvDistribucionCn.AllowUserToResizeRows = false
        Me.dgvDistribucionCn.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDistribucionCn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDistribucionCn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistribucionCn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvDistribucionCn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDistribucionCn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDistribucionCn.EnableHeadersVisualStyles = false
        Me.dgvDistribucionCn.Location = New System.Drawing.Point(3, 16)
        Me.dgvDistribucionCn.MultiSelect = false
        Me.dgvDistribucionCn.Name = "dgvDistribucionCn"
        Me.dgvDistribucionCn.RowHeadersVisible = false
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvDistribucionCn.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDistribucionCn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDistribucionCn.Size = New System.Drawing.Size(1279, 466)
        Me.dgvDistribucionCn.StandardTab = true
        Me.dgvDistribucionCn.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbRubro)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbFF)
        Me.GroupBox3.Controls.Add(Me.cbUnidadOrganica)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 503)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1285, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = false
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(1119, 14)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(160, 42)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar Asignación"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(102, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rubro:"
        '
        'cbRubro
        '
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.FormattingEnabled = true
        Me.cbRubro.Location = New System.Drawing.Point(153, 68)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(539, 21)
        Me.cbRubro.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fuente Financiamiento:"
        '
        'cbFF
        '
        Me.cbFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFF.FormattingEnabled = true
        Me.cbFF.Location = New System.Drawing.Point(153, 41)
        Me.cbFF.Name = "cbFF"
        Me.cbFF.Size = New System.Drawing.Size(539, 21)
        Me.cbFF.TabIndex = 3
        '
        'cbUnidadOrganica
        '
        Me.cbUnidadOrganica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadOrganica.FormattingEnabled = true
        Me.cbUnidadOrganica.Location = New System.Drawing.Point(153, 14)
        Me.cbUnidadOrganica.Name = "cbUnidadOrganica"
        Me.cbUnidadOrganica.Size = New System.Drawing.Size(539, 21)
        Me.cbUnidadOrganica.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(41, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Unidad Orgánica:"
        '
        'frmFiltrarItemsCatalogoCN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194,Byte),Integer), CType(CType(217,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1309, 615)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbDetalle)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmFiltrarItemsCatalogoCN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ..:: Listado General del C.N. ::.."
        Me.gbDetalle.ResumeLayout(false)
        CType(Me.dgvDistribucionCn,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDistribucionCn As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbUnidadOrganica As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFF As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRubro As ComboBox
    Friend WithEvents btnCancelar As Button
End Class
