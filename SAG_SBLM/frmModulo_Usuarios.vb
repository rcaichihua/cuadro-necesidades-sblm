Public Class frmModulo_Usuarios
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Dim Estado As New DataTable
    Dim Datos As New Mantenimiento
    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir.Click
        Me.Close()
    End Sub
    Private Sub frmModulo_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        B_Busqueda_S = " select Codigo_Usuario as ID,Descripcion as [Tipo Usuario],Apellidos,Nombres,Usuario,Case Activo When 1 Then 'ACTIVO' When 0 Then 'INACTIVO' End As Estado from lista_usuarios "
        B_Busqueda_W = " Where Codigo_Usuario <> '000' "
        B_Busqueda_O = " Order By Codigo_Usuario "
        Call Me.Filtrar()
        Call Me.Dimensionar()
        Me.cbCriterio.Items.Add(Me.DataGridView1.Columns(2).Name)
        Me.cbCriterio.Items.Add(Me.DataGridView1.Columns(3).Name)
        Me.cbCriterio.Items.Add(Me.DataGridView1.Columns(4).Name)
        Me.cbCriterio.SelectedIndex = 0
        Datos.Evaluacion_Botones_Modulo_Usuarios(Variable_Codigo_Usuario, Boton_Nuevo_Usuario, Boton_Editar_Usuario, Boton_Anular_Usuario, Boton_Eliminar_Usuario, Boton_Asignar_Accesos_Usuario)
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Usuario = Me.DataGridView1.CurrentRow.Cells(0).Value
            Datos.Evaluacion_Botones_Modulo_Usuarios(Variable_Codigo_Usuario, Boton_Nuevo_Usuario, Boton_Editar_Usuario, Boton_Anular_Usuario, Boton_Eliminar_Usuario, Boton_Asignar_Accesos_Usuario)
        Else
            Variable_Codigo_Usuario = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Usuario = Me.DataGridView1.CurrentRow.Cells(0).Value
            Datos.Evaluacion_Botones_Modulo_Usuarios(Variable_Codigo_Usuario, Boton_Nuevo_Usuario, Boton_Editar_Usuario, Boton_Anular_Usuario, Boton_Eliminar_Usuario, Boton_Asignar_Accesos_Usuario)
        Else
            Variable_Codigo_Usuario = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Usuario = Me.DataGridView1.CurrentRow.Cells(0).Value
            Datos.Evaluacion_Botones_Modulo_Usuarios(Variable_Codigo_Usuario, Boton_Nuevo_Usuario, Boton_Editar_Usuario, Boton_Anular_Usuario, Boton_Eliminar_Usuario, Boton_Asignar_Accesos_Usuario)
        Else
            Variable_Codigo_Usuario = ""
        End If
    End Sub
    Sub Filtrar()
        Dim S As String = ""
        Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
        Call Me.Dimensionar()
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
    Sub Buscar()
        Dim R As Double, C As Double, E As Double, I As Double
        E = -1
        C = Me.DataGridView1.Rows.Count - 1
        R = Me.DataGridView1.CurrentRow.Index + 1
        For I = R To C
            If Me.DataGridView1.Rows(I).Cells(Me.cbCriterio.Text).Value Like "*" & Me.txtDatos.Text & "*" Then
                E = I
                Exit For
            End If
        Next I
        If E = -1 Then
            If Me.DataGridView1.CurrentRow.Index = Me.DataGridView1.Rows.Count - 1 Then R = Me.DataGridView1.Rows.Count - 1
            For I = 0 To R
                If Me.DataGridView1.Rows(I).Cells(Me.cbCriterio.Text).Value Like "*" & Me.txtDatos.Text & "*" Then
                    E = I
                    Exit For
                End If
            Next I
        End If
        If E = -1 Then
            MessageBox.Show("No se encontro un registro que conincida con el criterio de busqueda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(E).Cells(1)
            Me.DataGridView1.Rows(E).Selected = True
        End If
    End Sub
    Private Sub cbCriterio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCriterio.SelectedIndexChanged
        If Me.cbCriterio.Text.Trim.Length > 0 Then
            Me.txtDatos.Enabled = True
            Me.txtDatos.Text = ""
            Me.txtDatos.Focus()
        End If
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.txtDatos.Text.Trim.Length > 0 Then
                Call Me.Buscar()
            Else
                MessageBox.Show("Debes Ingresar el Dato a Buscar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtDatos.Focus()
            End If
        Else
            MessageBox.Show("No hay donde buscar data, la grilla esta vacía", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub txtDatos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatos.KeyPress
        If Me.txtDatos.Text.Trim.Length > 0 Then
            If e.KeyChar = Chr(13) Then
                Call Me.btnBuscar_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub Dimensionar()
        Me.DataGridView1.Columns(0).Width = 60
        Me.DataGridView1.Columns(1).Width = 150
        Me.DataGridView1.Columns(2).Width = 240
        Me.DataGridView1.Columns(3).Width = 240
        Me.DataGridView1.Columns(4).Width = 240
        Me.DataGridView1.Columns(5).Width = 80
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub
    Private Sub Boton_Nuevo_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Nuevo_Usuario.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Registro_Usuarios", Me.Boton_Nuevo_Usuario.Name) = True Then
            Dim Formulario As New frmRegistro_Usuarios
            Formulario.Editar = False
            Formulario.ShowDialog()
            Call Me.Filtrar()
            Call Me.Dimensionar()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Editar_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Editar_Usuario.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Registro_Usuarios", Me.Boton_Editar_Usuario.Name) = True Then
            Dim Formulario As New frmRegistro_Usuarios
            Formulario.Editar = True
            Formulario.ShowDialog()
            Call Me.Filtrar()
            Call Me.Dimensionar()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Asignar_Accesos_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Asignar_Accesos_Usuario.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Registro_Usuarios", Me.Boton_Asignar_Accesos_Usuario.Name) = True Then
            Dim Formulario As New frmAcceso_Usuarios
            Formulario.ShowDialog()
            Call Me.Filtrar()
            Call Me.Dimensionar()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Eliminar_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Eliminar_Usuario.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Registro_Usuarios", Me.Boton_Eliminar_Usuario.Name) = True Then
            If Variable_Codigo_Usuario.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas Realmente Eliminar a este Usuario del Sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Eliminar_Usuario(Variable_Codigo_Usuario)
                    Call Me.Filtrar()
                    Call Me.Dimensionar()
                Else
                    Call Me.Filtrar()
                    Call Me.Dimensionar()
                End If
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Anular_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Anular_Usuario.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Registro_Usuarios", Me.Boton_Anular_Usuario.Name) = True Then
            If Variable_Codigo_Usuario.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas Realmente Anular a este Usuario del Sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Anular_Usuario(Variable_Codigo_Usuario)
                    Call Me.Filtrar()
                    Call Me.Dimensionar()
                Else
                    Call Me.Filtrar()
                    Call Me.Dimensionar()
                End If
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Actualizar_Registros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Actualizar_Registros.Click
        Call Me.Filtrar()
    End Sub

   
End Class