Public Class frmResumenes_Caja
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Separador As Char
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub frmResumenes_Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Dimensionar()
        Dimensionar2()
        Datos.Resumenes_Caja_Chica(My.Settings.Año_Ejecucion, Caja_Chica_Codigo_Tipo_Caja, Variable_Numero_Caja_Chica, Caja_Chica_Codigo_Unidad_Organica, Caja_Chica_Numero_Rendicion, Me.DataGridView1, Me.DataGridView2, Me.txtTipoCaja, Me.txtNumeroCaja, Me.txtNumeroRendicion, Me.txtUnidadOganica, txtCentroCostos, txtFuenteRubro, txtTotal01, Me.txtTotal02)
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Año", "Año")
        Me.DataGridView1.Columns.Add("Clasificador", "Clasificador")
        Me.DataGridView1.Columns.Add("Descripción del Clasificador de Gasto", "Descripción del Clasificador de Gasto")
        Me.DataGridView1.Columns.Add("Monto", "Monto")
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(0).Width = 60
        Me.DataGridView1.Columns(1).Width = 100
        Me.DataGridView1.Columns(2).Width = 450
        Me.DataGridView1.Columns(3).Width = 90
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    End Sub
    Private Sub Dimensionar2()
        Me.DataGridView2.Rows.Clear()
        Me.DataGridView2.Columns.Clear()
        Me.DataGridView2.Columns.Add("Año", "Año")
        Me.DataGridView2.Columns.Add("Clasificador", "Clasificador")
        Me.DataGridView2.Columns.Add("Descripción de la Denominación de Gasto", "Descripción de la Denominación de Gasto")
        Me.DataGridView2.Columns.Add("Monto", "Monto")
        Me.DataGridView2.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.Columns(0).Width = 60
        Me.DataGridView2.Columns(1).Width = 100
        Me.DataGridView2.Columns(2).Width = 450
        Me.DataGridView2.Columns(3).Width = 90
        Me.DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView2.ColumnHeadersHeight = 25
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    End Sub
    Private Sub btnExportar01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar01.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            Datos.Exportar_Grilla_Resumen_Caja(Me.DataGridView1)
        Else
            MessageBox.Show("No Hay Data para Enviar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub btnExportar02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportar02.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            Datos.Exportar_Grilla_Resumen_Caja(Me.DataGridView2)
        Else
            MessageBox.Show("No Hay Data para Enviar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class