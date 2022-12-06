<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaldos_CN
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaldos_CN))
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvSaldos = New System.Windows.Forms.DataGridView()
        Me.gbCatalogo = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtUnidadOrganica = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPIA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCN = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalSaldo = New System.Windows.Forms.Label()
        Me.gbDetalle.SuspendLayout
        CType(Me.dgvSaldos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbCatalogo.SuspendLayout
        Me.SuspendLayout
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.dgvSaldos)
        Me.gbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbDetalle.Location = New System.Drawing.Point(12, 81)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(829, 207)
        Me.gbDetalle.TabIndex = 6
        Me.gbDetalle.TabStop = false
        '
        'dgvSaldos
        '
        Me.dgvSaldos.AllowUserToAddRows = false
        Me.dgvSaldos.AllowUserToDeleteRows = false
        Me.dgvSaldos.AllowUserToResizeColumns = false
        Me.dgvSaldos.AllowUserToResizeRows = false
        Me.dgvSaldos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaldos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaldos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvSaldos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSaldos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSaldos.EnableHeadersVisualStyles = false
        Me.dgvSaldos.Location = New System.Drawing.Point(3, 16)
        Me.dgvSaldos.MultiSelect = false
        Me.dgvSaldos.Name = "dgvSaldos"
        Me.dgvSaldos.RowHeadersVisible = false
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvSaldos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaldos.Size = New System.Drawing.Size(823, 188)
        Me.dgvSaldos.StandardTab = true
        Me.dgvSaldos.TabIndex = 18
        '
        'gbCatalogo
        '
        Me.gbCatalogo.Controls.Add(Me.btnCerrar)
        Me.gbCatalogo.Controls.Add(Me.txtUnidadOrganica)
        Me.gbCatalogo.Controls.Add(Me.Label10)
        Me.gbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbCatalogo.Location = New System.Drawing.Point(12, 12)
        Me.gbCatalogo.Name = "gbCatalogo"
        Me.gbCatalogo.Size = New System.Drawing.Size(829, 63)
        Me.gbCatalogo.TabIndex = 7
        Me.gbCatalogo.TabStop = false
        Me.gbCatalogo.Text = "Saldos"
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Salir
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(609, 16)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(214, 34)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar vista de Saldos"
        Me.btnCerrar.UseVisualStyleBackColor = true
        '
        'txtUnidadOrganica
        '
        Me.txtUnidadOrganica.BackColor = System.Drawing.Color.White
        Me.txtUnidadOrganica.Location = New System.Drawing.Point(166, 24)
        Me.txtUnidadOrganica.Name = "txtUnidadOrganica"
        Me.txtUnidadOrganica.ReadOnly = true
        Me.txtUnidadOrganica.Size = New System.Drawing.Size(437, 20)
        Me.txtUnidadOrganica.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(20, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Unidad Orgánica"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total P.I.A."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPIA
        '
        Me.lblTotalPIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotalPIA.Location = New System.Drawing.Point(430, 293)
        Me.lblTotalPIA.Name = "lblTotalPIA"
        Me.lblTotalPIA.Size = New System.Drawing.Size(72, 23)
        Me.lblTotalPIA.TabIndex = 8
        Me.lblTotalPIA.Text = "Total P.I.A."
        Me.lblTotalPIA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total C.N."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCN
        '
        Me.lblTotalCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotalCN.Location = New System.Drawing.Point(586, 292)
        Me.lblTotalCN.Name = "lblTotalCN"
        Me.lblTotalCN.Size = New System.Drawing.Size(72, 25)
        Me.lblTotalCN.TabIndex = 8
        Me.lblTotalCN.Text = "Total C.N."
        Me.lblTotalCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(664, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Saldo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalSaldo
        '
        Me.lblTotalSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotalSaldo.Location = New System.Drawing.Point(742, 292)
        Me.lblTotalSaldo.Name = "lblTotalSaldo"
        Me.lblTotalSaldo.Size = New System.Drawing.Size(96, 25)
        Me.lblTotalSaldo.TabIndex = 8
        Me.lblTotalSaldo.Text = "Total Saldo"
        Me.lblTotalSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSaldos_CN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 324)
        Me.Controls.Add(Me.lblTotalPIA)
        Me.Controls.Add(Me.lblTotalSaldo)
        Me.Controls.Add(Me.gbCatalogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbDetalle)
        Me.Controls.Add(Me.lblTotalCN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmSaldos_CN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ..:: Saldos PIA ::.."
        Me.gbDetalle.ResumeLayout(false)
        CType(Me.dgvSaldos,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbCatalogo.ResumeLayout(false)
        Me.gbCatalogo.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents dgvSaldos As DataGridView
    Friend WithEvents gbCatalogo As GroupBox
    Friend WithEvents txtUnidadOrganica As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalPIA As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalCN As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalSaldo As Label
End Class
