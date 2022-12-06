<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValorizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValorizar))
        Me.gbCatalogo = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtUnidadMedida = New System.Windows.Forms.TextBox
        Me.txtCostoUnitario = New System.Windows.Forms.TextBox
        Me.txtCantidadAdquirir = New System.Windows.Forms.TextBox
        Me.txtCantidadSolicitada = New System.Windows.Forms.TextBox
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
        Me.gbCatalogo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCatalogo
        '
        Me.gbCatalogo.Controls.Add(Me.GroupBox1)
        Me.gbCatalogo.Controls.Add(Me.Label7)
        Me.gbCatalogo.Controls.Add(Me.txtItem)
        Me.gbCatalogo.Controls.Add(Me.Label3)
        Me.gbCatalogo.Controls.Add(Me.Label2)
        Me.gbCatalogo.Controls.Add(Me.Label1)
        Me.gbCatalogo.Controls.Add(Me.Label11)
        Me.gbCatalogo.Controls.Add(Me.txtUnidadMedida)
        Me.gbCatalogo.Controls.Add(Me.txtCostoUnitario)
        Me.gbCatalogo.Controls.Add(Me.txtCantidadAdquirir)
        Me.gbCatalogo.Controls.Add(Me.txtCantidadSolicitada)
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
        Me.gbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCatalogo.Location = New System.Drawing.Point(12, 12)
        Me.gbCatalogo.Name = "gbCatalogo"
        Me.gbCatalogo.Size = New System.Drawing.Size(581, 280)
        Me.gbCatalogo.TabIndex = 2
        Me.gbCatalogo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Location = New System.Drawing.Point(338, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 73)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SAG_SBLM.My.Resources.Resources.Anular
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(120, 20)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 44)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SAG_SBLM.My.Resources.Resources.Aceptar
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(16, 20)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 44)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 14
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
        Me.txtItem.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo Unitario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad a Adquirir:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cantidad Solicitada:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Item Selecconado:"
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.BackColor = System.Drawing.Color.White
        Me.txtUnidadMedida.Location = New System.Drawing.Point(208, 105)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.ReadOnly = True
        Me.txtUnidadMedida.Size = New System.Drawing.Size(94, 20)
        Me.txtUnidadMedida.TabIndex = 16
        '
        'txtCostoUnitario
        '
        Me.txtCostoUnitario.BackColor = System.Drawing.Color.White
        Me.txtCostoUnitario.Location = New System.Drawing.Point(165, 245)
        Me.txtCostoUnitario.Name = "txtCostoUnitario"
        Me.txtCostoUnitario.Size = New System.Drawing.Size(81, 20)
        Me.txtCostoUnitario.TabIndex = 3
        Me.txtCostoUnitario.Text = "0.00000"
        Me.txtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadAdquirir
        '
        Me.txtCantidadAdquirir.BackColor = System.Drawing.Color.White
        Me.txtCantidadAdquirir.Location = New System.Drawing.Point(165, 219)
        Me.txtCantidadAdquirir.Name = "txtCantidadAdquirir"
        Me.txtCantidadAdquirir.Size = New System.Drawing.Size(81, 20)
        Me.txtCantidadAdquirir.TabIndex = 1
        Me.txtCantidadAdquirir.Text = "0.00000"
        Me.txtCantidadAdquirir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadSolicitada
        '
        Me.txtCantidadSolicitada.BackColor = System.Drawing.Color.White
        Me.txtCantidadSolicitada.Location = New System.Drawing.Point(165, 193)
        Me.txtCantidadSolicitada.Name = "txtCantidadSolicitada"
        Me.txtCantidadSolicitada.ReadOnly = True
        Me.txtCantidadSolicitada.Size = New System.Drawing.Size(81, 20)
        Me.txtCantidadSolicitada.TabIndex = 15
        Me.txtCantidadSolicitada.Text = "0.00000"
        Me.txtCantidadSolicitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigoItem
        '
        Me.txtCodigoItem.BackColor = System.Drawing.Color.White
        Me.txtCodigoItem.Location = New System.Drawing.Point(165, 132)
        Me.txtCodigoItem.Name = "txtCodigoItem"
        Me.txtCodigoItem.ReadOnly = True
        Me.txtCodigoItem.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoItem.TabIndex = 25
        '
        'txtCodigoUnidadMedida
        '
        Me.txtCodigoUnidadMedida.BackColor = System.Drawing.Color.White
        Me.txtCodigoUnidadMedida.Location = New System.Drawing.Point(165, 105)
        Me.txtCodigoUnidadMedida.Name = "txtCodigoUnidadMedida"
        Me.txtCodigoUnidadMedida.ReadOnly = True
        Me.txtCodigoUnidadMedida.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoUnidadMedida.TabIndex = 15
        '
        'txtFamilia
        '
        Me.txtFamilia.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Location = New System.Drawing.Point(208, 78)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(364, 20)
        Me.txtFamilia.TabIndex = 13
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.BackColor = System.Drawing.Color.White
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(165, 78)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoFamilia.TabIndex = 12
        '
        'txtClase
        '
        Me.txtClase.BackColor = System.Drawing.Color.White
        Me.txtClase.Location = New System.Drawing.Point(208, 51)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.ReadOnly = True
        Me.txtClase.Size = New System.Drawing.Size(364, 20)
        Me.txtClase.TabIndex = 10
        '
        'txtCodigoClase
        '
        Me.txtCodigoClase.BackColor = System.Drawing.Color.White
        Me.txtCodigoClase.Location = New System.Drawing.Point(165, 51)
        Me.txtCodigoClase.Name = "txtCodigoClase"
        Me.txtCodigoClase.ReadOnly = True
        Me.txtCodigoClase.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoClase.TabIndex = 9
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.Color.White
        Me.txtGrupo.Location = New System.Drawing.Point(208, 24)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(364, 20)
        Me.txtGrupo.TabIndex = 7
        '
        'txtCodigoGrupo
        '
        Me.txtCodigoGrupo.BackColor = System.Drawing.Color.White
        Me.txtCodigoGrupo.Location = New System.Drawing.Point(165, 24)
        Me.txtCodigoGrupo.Name = "txtCodigoGrupo"
        Me.txtCodigoGrupo.ReadOnly = True
        Me.txtCodigoGrupo.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoGrupo.TabIndex = 6
        '
        'txtEspecificaDetalle
        '
        Me.txtEspecificaDetalle.BackColor = System.Drawing.Color.White
        Me.txtEspecificaDetalle.Location = New System.Drawing.Point(550, 105)
        Me.txtEspecificaDetalle.Name = "txtEspecificaDetalle"
        Me.txtEspecificaDetalle.ReadOnly = True
        Me.txtEspecificaDetalle.Size = New System.Drawing.Size(20, 20)
        Me.txtEspecificaDetalle.TabIndex = 23
        Me.txtEspecificaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEspecifica
        '
        Me.txtEspecifica.BackColor = System.Drawing.Color.White
        Me.txtEspecifica.Location = New System.Drawing.Point(530, 105)
        Me.txtEspecifica.Name = "txtEspecifica"
        Me.txtEspecifica.ReadOnly = True
        Me.txtEspecifica.Size = New System.Drawing.Size(20, 20)
        Me.txtEspecifica.TabIndex = 22
        Me.txtEspecifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubGenericaDetalle
        '
        Me.txtSubGenericaDetalle.BackColor = System.Drawing.Color.White
        Me.txtSubGenericaDetalle.Location = New System.Drawing.Point(510, 105)
        Me.txtSubGenericaDetalle.Name = "txtSubGenericaDetalle"
        Me.txtSubGenericaDetalle.ReadOnly = True
        Me.txtSubGenericaDetalle.Size = New System.Drawing.Size(20, 20)
        Me.txtSubGenericaDetalle.TabIndex = 21
        Me.txtSubGenericaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubGenerica
        '
        Me.txtSubGenerica.BackColor = System.Drawing.Color.White
        Me.txtSubGenerica.Location = New System.Drawing.Point(490, 105)
        Me.txtSubGenerica.Name = "txtSubGenerica"
        Me.txtSubGenerica.ReadOnly = True
        Me.txtSubGenerica.Size = New System.Drawing.Size(20, 20)
        Me.txtSubGenerica.TabIndex = 20
        Me.txtSubGenerica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGenerica
        '
        Me.txtGenerica.BackColor = System.Drawing.Color.White
        Me.txtGenerica.Location = New System.Drawing.Point(470, 105)
        Me.txtGenerica.Name = "txtGenerica"
        Me.txtGenerica.ReadOnly = True
        Me.txtGenerica.Size = New System.Drawing.Size(20, 20)
        Me.txtGenerica.TabIndex = 19
        Me.txtGenerica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipoTransaccion
        '
        Me.txtTipoTransaccion.BackColor = System.Drawing.Color.White
        Me.txtTipoTransaccion.Location = New System.Drawing.Point(450, 105)
        Me.txtTipoTransaccion.Name = "txtTipoTransaccion"
        Me.txtTipoTransaccion.ReadOnly = True
        Me.txtTipoTransaccion.Size = New System.Drawing.Size(20, 20)
        Me.txtTipoTransaccion.TabIndex = 18
        Me.txtTipoTransaccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Clasificador Asociado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Familia Bien:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Clase Bien:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Grupo Bien:"
        '
        'frmValorizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 298)
        Me.Controls.Add(Me.gbCatalogo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmValorizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Valorización de Items ::.."
        Me.gbCatalogo.ResumeLayout(False)
        Me.gbCatalogo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCatalogo As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtClase As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoClase As System.Windows.Forms.TextBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecificaDetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecifica As System.Windows.Forms.TextBox
    Friend WithEvents txtSubGenericaDetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtSubGenerica As System.Windows.Forms.TextBox
    Friend WithEvents txtGenerica As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoTransaccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCostoUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadAdquirir As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadSolicitada As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
