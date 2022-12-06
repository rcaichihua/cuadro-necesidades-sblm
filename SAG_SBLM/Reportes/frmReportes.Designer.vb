<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.crvVisualizador = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvVisualizador
        '
        Me.crvVisualizador.ActiveViewIndex = -1
        Me.crvVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvVisualizador.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvVisualizador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvVisualizador.Location = New System.Drawing.Point(0, 0)
        Me.crvVisualizador.Name = "crvVisualizador"
        Me.crvVisualizador.SelectionFormula = ""
        Me.crvVisualizador.Size = New System.Drawing.Size(882, 600)
        Me.crvVisualizador.TabIndex = 0
        Me.crvVisualizador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvVisualizador.ViewTimeSelectionFormula = ""
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 600)
        Me.Controls.Add(Me.crvVisualizador)
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvVisualizador As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Visor_Reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
