Public Class frmModulo_Acciones_Modificatorias
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim B_Busqueda_S As String = ""
    Dim B_Busqueda_W As String = ""
    Dim B_Busqueda_O As String = ""
    Dim Estado As New DataTable
    Dim Mes As New DataTable
    Dim Datos As New Mantenimiento
    Private Sub frmModulo_Acciones_Modificatorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        B_Busqueda_S = " select a.Año_Ejecucion As Año,a.Numero,b.Abreviatura as [U.O.],Justificacion,IsNull(Convert(VarChar(10),FechaEmision,103),'00/00/0000') as Emisión,IsNull(Convert(VarChar(10),FechaAutorizacion,103),'00/00/0000') as Autorización,IsNull(Convert(VarChar(10),FechaAprobacion,103),'00/00/0000') As Aprobación,Descripcion_Estado_AM as Estado from Lista_Acciones_Modificatorias_Basica a inner join Unidad_Organica b on a.Año_Ejecucion=b.Año_Ejecucion and a.Codigo_Unidad_Organica=b.Codigo_Unidad_Organica"
        B_Busqueda_W = " Where a.Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And a.Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")"
        B_Busqueda_O = " Order By a.Año_Ejecucion,a.Numero"
        Estado = Datos.LLenar_Combo("Select * From Estado_Accion", Me.cbEstado, "Descripcion_Estado_Accion")
        Me.cbEstado.SelectedIndex = 0
        Mes = Datos.LLenar_Combo("Select * From Mes", Me.cbMes, "Nombre_Mes")
        Me.cbMes.SelectedIndex = Month(Now)
        Call Me.Filtrar()
        Call Me.Dimensionar()
        Me.cbCriterio.Items.Add(Me.dgvAccionesModificatorias.Columns(1).Name)
        Me.cbCriterio.SelectedIndex = 0
        Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
        Me.Windowstate = FormWindowState.Maximized
    End Sub
    Sub Filtrar()
        If Me.cbEstado.Items.Count > 0 And Me.cbMes.Items.Count > 0 Then
            Dim S As String = ""
            If Me.cbEstado.SelectedIndex = 0 Then S = S & "" Else S = S & " and Descripcion_Estado_AM = '" & Estado.Rows(Me.cbEstado.SelectedIndex - 1).Item("Descripcion_Estado_AM") & "'"
            If Me.cbMes.SelectedIndex = 0 Then S = S & "" Else S = S & " and Month(FechaEmision) = " & Convert.ToDouble(Mes.Rows(Me.cbMes.SelectedIndex - 1).Item("Codigo_Mes").ToString) & " "
            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
            Call Me.Dimensionar()
        End If
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.dgvAccionesModificatorias.DataSource = DT
        If DT.Rows.Count > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & DT.Rows.Count
            Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
            Me.Boton_Editar_AM.Enabled = False
            Me.Boton_Extornar_AM.Enabled = False
            Me.Boton_Anular_AM.Enabled = False
            Me.Boton_Eliminar_AM.Enabled = False
            Me.Boton_Aprobar_AM.Enabled = False
            Me.Boton_Autorizar_AM.Enabled = False
            Me.Boton_Visualizar_AM.Enabled = False
            Me.Boton_Imprimir_AM.Enabled = False
        End If
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        Call Me.Filtrar()
    End Sub
    Private Sub Dimensionar()
        Me.dgvAccionesModificatorias.Columns(0).Width = 50
        Me.dgvAccionesModificatorias.Columns(1).Width = 70
        Me.dgvAccionesModificatorias.Columns(2).Width = 50
        Me.dgvAccionesModificatorias.Columns(3).Width = 320
        Me.dgvAccionesModificatorias.Columns(4).Width = 85
        Me.dgvAccionesModificatorias.Columns(5).Width = 85
        Me.dgvAccionesModificatorias.Columns(6).Width = 85
        Me.dgvAccionesModificatorias.Columns(7).Width = 90
        Me.dgvAccionesModificatorias.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvAccionesModificatorias.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.dgvAccionesModificatorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAccionesModificatorias.ColumnHeadersHeight = 30
        Me.dgvAccionesModificatorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAccionesModificatorias.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvAccionesModificatorias.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvAccionesModificatorias.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvAccionesModificatorias.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvAccionesModificatorias.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvAccionesModificatorias.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvAccionesModificatorias.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvAccionesModificatorias.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub
    Private Sub Boton_Nueva_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Nueva_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Nueva_AM.Name) = True Then
            Dim Formulario As New frmRegistro_Acciones_Modificatorias
            Variable_Numero_Accion_Modificatoria=""
            Formulario.Editar = False
            Formulario.ShowDialog()
            Call Me.Filtrar()
            Call Me.Dimensionar()
            Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Editar_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Editar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Editar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                Dim Formulario As New frmRegistro_Acciones_Modificatorias
                Formulario.Editar = True
                Formulario.ShowDialog()
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir.Click
        Me.Close()
    End Sub
    Private Sub Boton_Visualizar_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Visualizar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Visualizar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If Me.dgvAccionesModificatorias.CurrentCellAddress.Y >= 0 Then
                    Datos.Imprimir_Reporte("Select Compuesto,Justificacion,Emision,UsuarioEmision,Motivo,Codigo_FF,Codigo_Rubro, Codigo_Secuencia_Funcional,Descripcion_Especifica_Detalle,Rubro,Clasificador,Operacion,Estructura,Estructura2,
                                            codigo,item,unidad,Cantidad_Enero,Cantidad_Febrero, Cantidad_Marzo, Cantidad_Abril, Cantidad_Mayo, Cantidad_Junio, Cantidad_Julio, Cantidad_Agosto, Cantidad_Septiembre, Cantidad_Octubre, Cantidad_Noviembre, Cantidad_Diciembre,
                                            Cantidad_Total,costo_referencial,monto,(Codigo_Unidad_Organica+' - '+Nombre_Unidad_Organica) as Nombre_Unidad_Organica From Lista_Detalle_Accion_Modificatoria_Basica_Operacion_Reportar Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Numero='" & Variable_Numero_Accion_Modificatoria & "' Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle),Abs(Especifica),Abs(Especifica_Detalle)", New Reporte_Accion_Modificatoria, 100, "Reporte Acción Modificatoria", False)
                Else
                    MessageBox.Show("Seleccione un A.M. para Reportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccionesModificatorias.CellContentClick
        If Me.dgvAccionesModificatorias.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Accion_Modificatoria = Me.dgvAccionesModificatorias.CurrentRow.Cells(1).Value
            Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
        Else
            Variable_Numero_Accion_Modificatoria = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccionesModificatorias.CellContentDoubleClick
        If Me.dgvAccionesModificatorias.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Accion_Modificatoria = Me.dgvAccionesModificatorias.CurrentRow.Cells(1).Value
            Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
        Else
            Variable_Numero_Accion_Modificatoria = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccionesModificatorias.CellEnter
        If Me.dgvAccionesModificatorias.CurrentCellAddress.Y >= 0 Then
            Variable_Numero_Accion_Modificatoria = Me.dgvAccionesModificatorias.CurrentRow.Cells(1).Value
            Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
        Else
            Variable_Numero_Accion_Modificatoria = ""
        End If
    End Sub
    Private Sub Boton_Actualizar_Registros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Actualizar_Registros.Click
        Call Me.Filtrar()
    End Sub
    Private Sub Boton_Imprimir_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Imprimir_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Visualizar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If Me.dgvAccionesModificatorias.CurrentCellAddress.Y >= 0 Then
                    Datos.Imprimir_Reporte("Select Compuesto,Justificacion,Emision,UsuarioEmision,Motivo,Codigo_FF,Codigo_Rubro, Codigo_Secuencia_Funcional,Descripcion_Especifica_Detalle,Rubro,Clasificador,Operacion,Estructura,Estructura2,
                                            codigo,item,unidad,Cantidad_Enero,Cantidad_Febrero, Cantidad_Marzo, Cantidad_Abril, Cantidad_Mayo, Cantidad_Junio, Cantidad_Julio, Cantidad_Agosto, Cantidad_Septiembre, Cantidad_Octubre, Cantidad_Noviembre, Cantidad_Diciembre,
                                            Cantidad_Total,costo_referencial,monto,(Codigo_Unidad_Organica+' - '+Nombre_Unidad_Organica) as Nombre_Unidad_Organica From Lista_Detalle_Accion_Modificatoria_Basica_Operacion_Reportar Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Numero='" & Variable_Numero_Accion_Modificatoria & "' Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle),Abs(Especifica),Abs(Especifica_Detalle)", New Reporte_Accion_Modificatoria, 100, "Reporte Acción Modificatoria", True)
                Else
                    MessageBox.Show("Seleccione un A.M. para Reportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Eliminar_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Eliminar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Eliminar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas realmente Eliminar la A.M. seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Eliminar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria,My.Settings.Usuario)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Extornar_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Extornar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Extornar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas realmente Extornar la Acción Modificatoria seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Extornar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, My.Settings.Usuario)
                    Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Autorizar_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Autorizar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Autorizar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas realmente Autorizar la Acción Modificatoria seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Autorizar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, My.Settings.Usuario)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Aprobar_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Aprobar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Aprobar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas realmente Autorizar la Acción Modificatoria seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Aprobar_AM(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, My.Settings.Usuario)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Anular_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Anular_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Anular_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                If MessageBox.Show("¿Deseas realmente Anular la Acción Modificatoria seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Anular_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, My.Settings.Usuario)
                End If
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Reenumerar_AM_Click(sender As Object, e As EventArgs) Handles Boton_Reenumerar_AM.Click
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Accion_Modificatoria", Me.Boton_Reenumerar_AM.Name) = True Then
            If Variable_Numero_Accion_Modificatoria.Trim.Length > 0 Then
                Dim Formulario As New frmReenumerar_Certificado
                Formulario.Operacion = 1
                Formulario.ShowDialog()
                Call Me.Filtrar()
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            Else
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_Accion_Modificatoria(My.Settings.Año_Ejecucion, Variable_Numero_Accion_Modificatoria, Boton_Nueva_AM, Boton_Editar_AM, Boton_Anular_AM, Boton_Eliminar_AM, Boton_Extornar_AM, Boton_Autorizar_AM, Boton_Aprobar_AM, Me.Boton_Visualizar_AM, Me.Boton_Imprimir_AM, Me.Boton_Reenumerar_AM)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMes.SelectedIndexChanged
        Boton_Actualizar_Registros_Click(sender,e)
    End Sub
End Class