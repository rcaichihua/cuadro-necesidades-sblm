<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisor_Reportes
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisor_Reportes))
        Me.Visor_Reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.SuspendLayout()
        '
        'Visor_Reporte
        '
        Me.Visor_Reporte.ActiveViewIndex = -1
        Me.Visor_Reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visor_Reporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.Visor_Reporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Visor_Reporte.Location = New System.Drawing.Point(0, 0)
        Me.Visor_Reporte.Name = "Visor_Reporte"
        Me.Visor_Reporte.SelectionFormula = ""
        Me.Visor_Reporte.Size = New System.Drawing.Size(1119, 612)
        Me.Visor_Reporte.TabIndex = 0
        Me.Visor_Reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.Visor_Reporte.ViewTimeSelectionFormula = ""
        '
        'frmVisor_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 612)
        Me.Controls.Add(Me.Visor_Reporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisor_Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Generador de Reportes ::.."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Visor_Reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
