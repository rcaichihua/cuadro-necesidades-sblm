Public Class frmModulo_Requerimiento_Servicios
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Dim Estado As New DataTable
    Dim Unidad_Organica As New DataTable
    Dim Mes As New DataTable
    Dim Datos As New Mantenimiento
    Private Sub frmRequerimiento_Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        B_Busqueda_S = " select Año_Ejecucion As Año,Numero,Nombre_Unidad_Organica as [Unidad Orgánica],Justificacion,IsNull(Convert(VarChar(10),FechaEmision,103),'00/00/0000') as Emisión,IsNull(Convert(VarChar(10),FechaAutorizacion,103),'00/00/0000') as Autorización,IsNull(Convert(VarChar(10),FechaAprobacion,103),'00/00/0000') As Aprobación,Monto_Referencial as Referencial,Descripcion_Estado_Requerimiento as Estado from [dbo].[lista_requerimientos_Servicios_basica] "
        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' "
        B_Busqueda_O = " Order By Año_Ejecucion,Numero "
        Estado = Datos.LLenar_Combo("Select * From Estado_Requerimiento", Me.cbEstado, "Descripcion_Estado_Requerimiento")
        Me.cbEstado.SelectedIndex = 0
        Mes = Datos.LLenar_Combo("Select * From Mes", Me.cbMes, "Nombre_Mes")
        Me.cbMes.SelectedIndex = Month(Now)
        Unidad_Organica = Datos.LLenar_Combo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
        Me.cbUnidadOrganica.SelectedIndex = 0
        Call Me.Filtrar()
        Call Me.Dimensionar()
        Me.cbCriterio.Items.Add(Me.DataGridView1.Columns(1).Name)
        Me.cbCriterio.Items.Add(Me.DataGridView1.Columns(3).Name)
        Me.cbCriterio.SelectedIndex = 0
    End Sub
    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir.Click
        Me.Close()
    End Sub
    Private Sub Boton_Nuevo_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Nuevo_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Nuevo_Requerimiento_Servicios.Name) = True Then
            Dim Formulario As New frmRegistro_Requerimiento_Servicios
            Formulario.Editar = False
            Formulario.ShowDialog()
            Call Me.Filtrar()
            Call Me.Dimensionar()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Sub Filtrar()
        If Me.cbEstado.Items.Count > 0 And Me.cbMes.Items.Count > 0 And Me.cbUnidadOrganica.Items.Count > 0 Then
            Dim S As String = ""
            If Me.cbEstado.SelectedIndex = 0 Then S = S & "" Else S = S & " and Descripcion_Estado_Requerimiento = '" & Estado.Rows(Me.cbEstado.SelectedIndex - 1).Item("Descripcion_Estado_Requerimiento") & "'"
            If Me.cbMes.SelectedIndex = 0 Then S = S & "" Else S = S & " and Month(FechaEmision) = " & Convert.ToDouble(Mes.Rows(Me.cbMes.SelectedIndex - 1).Item("Codigo_Mes").ToString) & " "
            If Me.cbUnidadOrganica.SelectedIndex = 0 Then S = S & " And Codigo_Unidad_Organica In(" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ") " Else S = S & " and Codigo_Unidad_Organica ='" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex - 1).Item("Codigo_Unidad_Organica").ToString & "' "
            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
            Call Me.Dimensionar()
        End If
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.DataGridView1.DataSource = DT
        If DT.Rows.Count > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & DT.Rows.Count
            Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
            Me.Boton_Editar_Requerimiento_Servicios.Enabled = False
            Me.Boton_Extornar_Requerimiento_Servicios.Enabled = False
            Me.Boton_Anular_Requerimiento_Servicios.Enabled = False
            Me.Boton_Eliminar_Requerimiento_Servicios.Enabled = False
            Me.Boton_Aprobar_Requerimiento_Servicios.Enabled = False
            Me.Boton_Autorizar_Requerimiento_Servicios.Enabled = False
            Me.Boton_Visualizar_Requerimiento_Servicios.Enabled = False
            Me.Boton_Imprimir_Requerimiento_Servicios.Enabled = False
        End If
    End Sub
    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        Call Me.Filtrar()
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
        Me.DataGridView1.Columns(0).Width = 50
        Me.DataGridView1.Columns(1).Width = 50
        Me.DataGridView1.Columns(2).Width = 320
        Me.DataGridView1.Columns(3).Width = 270
        Me.DataGridView1.Columns(4).Width = 80
        Me.DataGridView1.Columns(5).Width = 80
        Me.DataGridView1.Columns(6).Width = 80
        Me.DataGridView1.Columns(7).Width = 80
        Me.DataGridView1.Columns(8).Width = 90
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub
    Private Sub Boton_Visualizar_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Visualizar_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Visualizar_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Datos.Imprimir_Reporte("Select * From Lista_Detalle_Requerimientos_Servicios_Basica_Reportar Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Numero='" & Variable_Numero_Requerimiento_Servicio & "' Order By Abs(Año_Ejecucion),Abs(Numero)", New Requerimiento_Servicios, 100, "Reporte Requerimiento", False)
                Else
                    MessageBox.Show("Seleccione un Requerimiento para Reportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
            Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
        Else
            Variable_Numero_Requerimiento_Servicio = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
            Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
        Else
            Variable_Numero_Requerimiento_Servicio = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Requerimiento_Servicio = Me.DataGridView1.CurrentRow.Cells(1).Value
            Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
        Else
            Variable_Numero_Requerimiento_Servicio = ""
        End If
    End Sub
    Private Sub Boton_Editar_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Editar_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Editar_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                Dim Formulario As New frmRegistro_Requerimiento_Servicios
                Formulario.Editar = True
                Formulario.ShowDialog()
                Call Me.Filtrar()
                Call Me.Dimensionar()
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Actualizar_Registros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Actualizar_Registros.Click
        Call Me.Filtrar()
    End Sub
    Private Sub Boton_Imprimir_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Imprimir_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Imprimir_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If Me.DataGridView1.CurrentCellAddress.Y >= 0 Then
                    Datos.Imprimir_Reporte("Select * From Lista_Detalle_Requerimientos_Servicios_Basica_Reportar Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Numero='" & Variable_Numero_Requerimiento_Servicio & "' Order By Abs(Año_Ejecucion),Abs(Numero)", New Requerimiento_Servicios, 100, "Reporte Requerimiento", True)
                Else
                    MessageBox.Show("Seleccione un Requerimiento para Imprimir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Eliminar_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Eliminar_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Eliminar_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Eliminar el Requerimiento seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Eliminar_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, True,My.Settings.Usuario)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Extornar_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Extornar_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Extornar_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Extornar el Requerimiento seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    If Not Datos.Verifica_Orden_Compra_Con_Requerimiento(my.Settings.Año_Ejecucion,Variable_Numero_Requerimiento_Servicio, "S")
                        Datos.Extornar_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, My.Settings.Usuario)
                    Else
                        MessageBox.Show("No se puede extornar el requerimiento, ya se generó una Orden de Compra.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
                    End If
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Autorizar_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Autorizar_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Autorizar_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Autorizar el Requerimiento seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Autorizar_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, My.Settings.Usuario)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Aprobar_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Aprobar_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Aprobar_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Aprobar el Requerimiento seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Aprobar_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, My.Settings.Usuario)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Anular_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Anular_Requerimiento_Servicios.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Requerimiento_Servicios", Me.Boton_Anular_Requerimiento_Servicios.Name) = True Then
            If Variable_Numero_Requerimiento_Servicio.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Anular el Requerimiento seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Anular_Requerimiento_Servicio(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, My.Settings.Usuario)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Requerimiento_Servicios(My.Settings.Año_Ejecucion, Variable_Numero_Requerimiento_Servicio, Boton_Nuevo_Requerimiento_Servicios, Boton_Editar_Requerimiento_Servicios, Boton_Anular_Requerimiento_Servicios, Boton_Eliminar_Requerimiento_Servicios, Boton_Extornar_Requerimiento_Servicios, Boton_Autorizar_Requerimiento_Servicios, Boton_Aprobar_Requerimiento_Servicios, Me.Boton_Visualizar_Requerimiento_Servicios, Me.Boton_Imprimir_Requerimiento_Servicios)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Referencial" Then
            e.CellStyle.Format = "###,###,#.00"
        End If
    End Sub
    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        Call Me.Filtrar()
    End Sub
    Private Sub cbUnidadOrganica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidadOrganica.SelectedIndexChanged
        Call Me.Filtrar()
    End Sub
End Class