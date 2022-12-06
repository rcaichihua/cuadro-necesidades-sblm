Public Class Buscar_Comprobantes_Faltantes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Consulta As String = ""
    Dim Mes As New DataTable
    Dim Tipo_Procedimiento As New DataTable
    Private Sub Buscar_Comprobantes_Faltantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Mes = Datos.LLenar_Combo_Solo("Select * From Mes", Me.cbMes, "Nombre_Mes")
        Me.cbMes.Text = MonthName(Month(Today())).ToUpper
        Me.DateTimePicker1.MinDate = New DateTime(Convert.ToDouble(My.Settings.Año_Ejecucion.ToString), 1, 2)
        Me.DateTimePicker1.MaxDate = New DateTime(Convert.ToDouble(My.Settings.Año_Ejecucion.ToString), 12, 31)
        Me.DateTimePicker2.MinDate = New DateTime(Convert.ToDouble(My.Settings.Año_Ejecucion.ToString), 1, 2)
        Me.DateTimePicker2.MaxDate = New DateTime(Convert.ToDouble(My.Settings.Año_Ejecucion.ToString), 12, 31)
        Call Me.Dimensionar()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Tipo Documento", "Tipo Documento")
        Me.DataGridView1.Columns.Add("Número", "Número")
        Me.DataGridView1.Columns.Add("Año", "Año")
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(0).Width = 145
        Me.DataGridView1.Columns(1).Width = 55
        Me.DataGridView1.Columns(2).Width = 45
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    End Sub
    Private Sub btnConsulta_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta_01.Click
        If Me.cbMes.Text.Trim.Length > 0 Then
            Datos.Consulta_Mes_Comprobantes_Faltantes(My.Settings.Año_Ejecucion, Mes.Rows(Me.cbMes.SelectedIndex).Item("Codigo_Mes").ToString, Me.DataGridView1, Me.lblRangoInicial, Me.lblRangoFinal, Me.lblRegistrosEncontrados)
        Else
            MessageBox.Show("Debes Seleccionar el Mes a Filtrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.cbMes.Focus()
        End If
    End Sub
    Private Sub btnConsulta_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta_03.Click
        If NumericUpDown1.Value > 0 Then
            If NumericUpDown2.Value > 0 Then
                If NumericUpDown1.Value <= NumericUpDown2.Value Then
                    Datos.Consulta_Rangos_Comprobantes_Faltantes(My.Settings.Año_Ejecucion, Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.DataGridView1, Me.lblRangoInicial, Me.lblRangoFinal, Me.lblRegistrosEncontrados)
                Else
                    MessageBox.Show("Existe una Inconsistencia en el Rango Inicial y Final, favor de Corregirlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.NumericUpDown1.Focus()
                End If
            Else
                MessageBox.Show("El Número del Rango Final debe ser Mayor a Cero (0), favor de Corregirlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.NumericUpDown2.Focus()
            End If
        Else
            MessageBox.Show("El Número del Rango Inicial debe ser Mayor a Cero (0), favor de Corregirlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.NumericUpDown1.Focus()
        End If
    End Sub
    Private Sub btnConsulta_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta_02.Click
        If Me.DateTimePicker1.Value.Date <= Me.DateTimePicker2.Value.Date Then
            Datos.Consulta_Fechas_Comprobantes_Faltantes(My.Settings.Año_Ejecucion, Me.DateTimePicker1.Value.Date, Me.DateTimePicker2.Value.Date, Me.DataGridView1, Me.lblRangoInicial, Me.lblRangoFinal, Me.lblRegistrosEncontrados)
        Else
            MessageBox.Show("Existe una Inconsistencia en el Rango Inicial y Final de las Fechas, favor de Corregirlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.DateTimePicker1.Focus()
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            Datos.Exportar_Lista_Comprobantes_No_Emitidos(Me.DataGridView1)
        End If
    End Sub
End Class