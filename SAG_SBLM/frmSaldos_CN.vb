Public Class frmSaldos_CN
    Inherits DevComponents.DotNetBar.Office2007Form

    Public Unidad_Organica_ As String
    Public Codigo_Unidad_Organica_ As String
    Dim Datos As New Mantenimiento

    Private Sub frmSaldos_CN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUnidadOrganica.Text = Unidad_Organica_
        dgvSaldos.DataSource = Datos.Consulta_Saldo_por_Unidad_Organica( My.Settings.Año_Ejecucion,Codigo_Unidad_Organica_).Tables(0)
        Call Me.Dimensionar()
        Dim AcumuladoPIA As Double
        Dim total_PIA As Double
        
        Dim AcumuladoCN As Double
        Dim total_CN As Double

        Dim AcumuladoSaldo As Double
        Dim total_Saldo As Double

        For Each row As DataGridViewRow In dgvSaldos.rows

            AcumuladoPIA = (Convert.ToDouble(row.Cells("PIA").Value.ToString()))
            AcumuladoCN = (Convert.ToDouble(row.Cells("CN").Value.ToString()))
            AcumuladoSaldo = (Convert.ToDouble(row.Cells("Saldo").Value.ToString()))

            total_PIA = total_PIA + AcumuladoPIA
            total_CN = total_CN + AcumuladoCN
            total_Saldo = total_Saldo + AcumuladoSaldo
        Next

        lblTotalPIA.Text = total_PIA.ToString("###,###,#.00")
        lblTotalCN.Text = total_CN.ToString("###,###,#.00")
        lblTotalSaldo.Text = total_Saldo.ToString("###,###,#.00")
    End Sub

    Private Sub Dimensionar()
        Me.dgvSaldos.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvSaldos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.dgvSaldos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgvSaldos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgvSaldos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgvSaldos.Columns(0).Width = 160
        Me.dgvSaldos.Columns(1).Width = 160
        Me.dgvSaldos.Columns(2).Width = 80
        Me.dgvSaldos.Columns(3).Width = 150
        Me.dgvSaldos.Columns(4).Width = 80
        Me.dgvSaldos.Columns(5).Width = 80
        Me.dgvSaldos.Columns(6).Width = 80

        Me.dgvSaldos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSaldos.ColumnHeadersHeight = 25
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvSaldos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSaldos.CellFormatting
        If Me.dgvSaldos.Columns(e.ColumnIndex).Name = "PIA" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvSaldos.Columns(e.ColumnIndex).Name = "CN" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
        If Me.dgvSaldos.Columns(e.ColumnIndex).Name = "Saldo" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
    End Sub
End Class