﻿Public Class frmBuscar_Clasificadores
    Inherits DevComponents.DotNetBar.Office2007Form
    Public B_Adicional As String = ""
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Private Sub frmBuscar_Clasificadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        B_Busqueda_S = " select Año_Ejecucion as Año,Tipo_Transaccion as TT,Generica as G,Sub_Generica As SG,Sub_Generica_Detalle  As SGD,Especifica as E,Especifica_Detalle As ED,Descripcion_Especifica_Detalle as Descripcion,Clasificador from Lista_Clasificadores "
        If B_Adicional.Trim.Length > 0 Then
            B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' " & B_Adicional
        Else
            B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' "
        End If

        B_Busqueda_O = " Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle),Abs(Especifica),Abs(Especifica_Detalle)"
        Call Me.Filtrar()
        Call Dimensionar()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Variable_Tipo_Transaccion = ""
        Variable_Generica = ""
        Variable_SubGenerica = ""
        Variable_SubGenerica_Detalle = ""
        Variable_Especifica = ""
        Variable_Especifica_Detalle = ""
        Variable_Clasificador = ""
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Clasificador"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.txtDatos.Enabled = True
        Me.txtDatos.Text = ""
        Me.txtDatos.Focus()
        Me.lblBusqueda.Text = "Ingrese Descripción"
    End Sub
    Sub Filtrar()
        If Me.txtDatos.Text.Length > 0 Then
            Dim S As String = ""
            If Me.RadioButton1.Checked = True Then
                S = " And Clasificador Like '%" & Me.txtDatos.Text.Trim & "%'"
            End If
            If Me.RadioButton2.Checked = True Then
                S = " And Descripcion_Especifica_Detalle Like '%" & Me.txtDatos.Text.Trim & "%'"
            End If
            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Adicional & B_Busqueda_O)
            Call Me.Dimensionar()
        Else
            Llenar(B_Busqueda_S & B_Busqueda_W & B_Adicional & B_Busqueda_O)
            Call Me.Dimensionar()
        End If
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.DataGridView1.DataSource = DT
        If DT.Rows.Count > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & DT.Rows.Count
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
        End If
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Columns(0).Width = 50
        Me.DataGridView1.Columns(1).Width = 30
        Me.DataGridView1.Columns(2).Width = 30
        Me.DataGridView1.Columns(3).Width = 30
        Me.DataGridView1.Columns(4).Width = 30
        Me.DataGridView1.Columns(5).Width = 30
        Me.DataGridView1.Columns(6).Width = 30
        Me.DataGridView1.Columns(7).Width = 400
        Me.DataGridView1.Columns(8).Width = 80
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub
    Private Sub txtDatos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatos.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case Me.DataGridView1.Rows.Count
                Case 0
                    Return
                Case 1
                    Me.DataGridView1.Focus()
                    Call btnAceptar_Click(sender, e)
                Case Is > 1
                    Me.DataGridView1.Focus()
            End Select
        End If
    End Sub
    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        If Me.txtDatos.Text.Trim.Length > 0 Then
            Call Me.Filtrar()
        Else
            Call Me.Filtrar()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Variable_TT = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_G = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_SG = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_SGD = Me.DataGridView1.CurrentRow.Cells(4).Value
            Variable_E = Me.DataGridView1.CurrentRow.Cells(5).Value
            Variable_ED = Me.DataGridView1.CurrentRow.Cells(6).Value
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
            Variable_TT = ""
            Variable_G = ""
            Variable_SG = ""
            Variable_SGD = ""
            Variable_E = ""
            Variable_ED = ""
            Variable_Clasificador = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Variable_TT = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_G = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_SG = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_SGD = Me.DataGridView1.CurrentRow.Cells(4).Value
            Variable_E = Me.DataGridView1.CurrentRow.Cells(5).Value
            Variable_ED = Me.DataGridView1.CurrentRow.Cells(6).Value
            Variable_Descripcion_Clasificador = Me.DataGridView1.CurrentRow.Cells(7).Value
            Variable_Clasificador = Me.DataGridView1.CurrentRow.Cells(8).Value
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
            Variable_TT = ""
            Variable_G = ""
            Variable_SG = ""
            Variable_SGD = ""
            Variable_E = ""
            Variable_ED = ""
            Variable_Descripcion_Clasificador = ""
            Variable_Clasificador = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Variable_TT = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_G = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_SG = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_SGD = Me.DataGridView1.CurrentRow.Cells(4).Value
            Variable_E = Me.DataGridView1.CurrentRow.Cells(5).Value
            Variable_ED = Me.DataGridView1.CurrentRow.Cells(6).Value
            Variable_Descripcion_Clasificador = Me.DataGridView1.CurrentRow.Cells(7).Value
            Variable_Clasificador = Me.DataGridView1.CurrentRow.Cells(8).Value
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
            Variable_TT = ""
            Variable_G = ""
            Variable_SG = ""
            Variable_SGD = ""
            Variable_E = ""
            Variable_ED = ""
            Variable_Descripcion_Clasificador = ""
            Variable_Clasificador = ""
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Variable_TT = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_G = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_SG = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_SGD = Me.DataGridView1.CurrentRow.Cells(4).Value
            Variable_E = Me.DataGridView1.CurrentRow.Cells(5).Value
            Variable_ED = Me.DataGridView1.CurrentRow.Cells(6).Value
            Variable_Descripcion_Clasificador = Me.DataGridView1.CurrentRow.Cells(7).Value
            Variable_Clasificador = Me.DataGridView1.CurrentRow.Cells(8).Value
            Me.Close()
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
            Variable_TT = ""
            Variable_G = ""
            Variable_SG = ""
            Variable_SGD = ""
            Variable_E = ""
            Variable_ED = ""
            Variable_Descripcion_Clasificador = ""
            Variable_Clasificador = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Variable_TT = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_G = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_SG = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_SGD = Me.DataGridView1.CurrentRow.Cells(4).Value
            Variable_E = Me.DataGridView1.CurrentRow.Cells(5).Value
            Variable_ED = Me.DataGridView1.CurrentRow.Cells(6).Value
            Variable_Descripcion_Clasificador = Me.DataGridView1.CurrentRow.Cells(7).Value
            Variable_Clasificador = Me.DataGridView1.CurrentRow.Cells(8).Value
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
            Variable_TT = ""
            Variable_G = ""
            Variable_SG = ""
            Variable_SGD = ""
            Variable_E = ""
            Variable_ED = ""
            Variable_Descripcion_Clasificador = ""
            Variable_Clasificador = ""
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Datos.Llenar_Componentes(Me.DataGridView1.CurrentRow.Cells(1).Value, Me.DataGridView1.CurrentRow.Cells(2).Value, Me.DataGridView1.CurrentRow.Cells(3).Value, Me.DataGridView1.CurrentRow.Cells(4).Value, Me.DataGridView1.CurrentRow.Cells(5).Value, Me.DataGridView1.CurrentRow.Cells(6).Value)
            Me.Close()
            Variable_TT = Me.DataGridView1.CurrentRow.Cells(1).Value
            Variable_G = Me.DataGridView1.CurrentRow.Cells(2).Value
            Variable_SG = Me.DataGridView1.CurrentRow.Cells(3).Value
            Variable_SGD = Me.DataGridView1.CurrentRow.Cells(4).Value
            Variable_E = Me.DataGridView1.CurrentRow.Cells(5).Value
            Variable_ED = Me.DataGridView1.CurrentRow.Cells(6).Value
            Variable_Descripcion_Clasificador = Me.DataGridView1.CurrentRow.Cells(7).Value
            Variable_Clasificador = Me.DataGridView1.CurrentRow.Cells(8).Value
        Else
            Variable_Tipo_Transaccion = ""
            Variable_Generica = ""
            Variable_SubGenerica = ""
            Variable_SubGenerica_Detalle = ""
            Variable_Especifica = ""
            Variable_Especifica_Detalle = ""
            Variable_TT = ""
            Variable_G = ""
            Variable_SG = ""
            Variable_SGD = ""
            Variable_E = ""
            Variable_ED = ""
            Variable_Descripcion_Clasificador = ""
            Variable_Clasificador = ""
        End If
    End Sub
End Class