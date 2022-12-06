Public Class frmRegistro_Unidades_Organicas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
    Private Sub frmRegistro_Unidades_Organicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        B_Busqueda_S = " Select * From Lista_Basica_Unidades "
        B_Busqueda_W = " Where Año ='" & My.Settings.Año_Ejecucion & "' "
        B_Busqueda_O = " Order By Año,ID"
        Call Dimensionar()
        Call Filtrar()
    End Sub
    Sub Filtrar()
        Llenar(B_Busqueda_S & B_Busqueda_W & B_Busqueda_O)
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        If DT.Rows.Count > 0 Then
            
            For Recorrido As Integer = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, DataGridView1.Rows.Count - 1).Value = DT.Rows(Recorrido).Item("Año")
                DataGridView1.Item(1, DataGridView1.Rows.Count - 1).Value = DT.Rows(Recorrido).Item("ID")
                DataGridView1.Item(2, DataGridView1.Rows.Count - 1).Value = DT.Rows(Recorrido).Item("Nombre")
                DataGridView1.Item(3, DataGridView1.Rows.Count - 1).Value = DT.Rows(Recorrido).Item("C.Costos")
            Next
        End If
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Año", "Año")
        Me.DataGridView1.Columns.Add("ID", "ID")
        Me.DataGridView1.Columns.Add("Nombre", "Nombre")
        Me.DataGridView1.Columns.Add("C.Costos", "C.Costos")
        Me.DataGridView1.Columns(0).Width = 50
        Me.DataGridView1.Columns(1).Width = 30
        Me.DataGridView1.Columns(2).Width = 500
        Me.DataGridView1.Columns(3).Width = 80
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Dim Boton1 As New DataGridViewButtonColumn
        With Boton1
            .Name = "btnEditar"
            .HeaderText = "Editar"
            .Text = "Editar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 4
        End With
        DataGridView1.Columns.Add(Boton1)
        DataGridView1.Columns(4).Width = 100
        Dim Boton2 As New DataGridViewButtonColumn
        With Boton2
            .Name = "btnEliminar"
            .HeaderText = "Eliminar"
            .Text = "Eliminar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 5
        End With
        DataGridView1.Columns.Add(Boton2)
        DataGridView1.Columns(5).Width = 100
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btnEliminar" Then
                If MessageBox.Show("¿Deseas Realmente Eliminar la Unidad Orgánica Seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    If Datos.Verificar_Unidad_Organica(My.Settings.Año_Ejecucion, Me.DataGridView1.CurrentRow.Cells(1).Value) = 0 Then
                        Datos.Eliminar_Unidad_Organica(My.Settings.Año_Ejecucion, Me.DataGridView1.CurrentRow.Cells(1).Value)
                        Call Dimensionar()
                        Call Filtrar()
                    Else
                        MessageBox.Show("Imposible Eliminar la Unidad Organica Seleccionada es posible que Tenga un PIA Activo o PIM o Certificación Presupuestal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
            If DataGridView1.Columns(e.ColumnIndex).Name = "btnEditar" Then
                Dim Formulario As New frmRegistro_Unidad_Organica
                Formulario.Editar = True
                Formulario.Codigo_Unidad_Organica = Me.DataGridView1.CurrentRow.Cells(1).Value
                Formulario.ShowDialog()
                Call Dimensionar()
                Call Filtrar()
            End If
        Else
            Return
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If DataGridView1.RowCount > 0 Then
            MessageBox.Show("Ya se han Generado los Registros Correspondientes al Año de Ejecución: " & My.Settings.Año_Ejecucion, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            Datos.Generar_Unidades_Organicas(My.Settings.Año_Ejecucion, Convert.ToInt32(My.Settings.Año_Ejecucion) - 1)
            Call Dimensionar()
            Call Filtrar()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim Formulario As New frmRegistro_Unidad_Organica
        Formulario.Editar = False
        Formulario.ShowDialog()
        Call Dimensionar()
        Call Filtrar()
    End Sub
End Class