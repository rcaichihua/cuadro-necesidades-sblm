Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmModulo_CN
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Estado As New DataTable
    Dim Unidad_Organica As New DataTable
    Dim B_Busqueda_S As String
    Dim B_Busqueda_W As String
    Dim B_Busqueda_O As String
    Private Sub frmModulo_CN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load 
        B_Busqueda_S = " Select Año_Ejecucion As Año,Codigo_Secuencia_Funcional As Meta,Codigo_Actividad As [Act.],Codigo_Unidad_Organica As [C.U.O.],Nombre_Unidad_Organica As [Unidad Organica],IsNull(Convert(VarChar(10),FechaEmision,103),'00/00/0000') as Emision,IsNull(Convert(VarChar(10),FechaAutorizacion,103),'00/00/0000') as Autorizacion,IsNull(Convert(VarChar(10),FechaAprobacion,103),'00/00/0000') as Aprobacion,Descripcion_Estado_CN as Estado From Lista_CN_Generados "
        B_Busqueda_W = " Where Año_Ejecucion ='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")"
        B_Busqueda_O = " Order By Codigo_Secuencia_Funcional,Codigo_Unidad_Organica,Codigo_Actividad"
        Unidad_Organica = Datos.LLenar_Combo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In (" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
        Me.cbUnidadOrganica.SelectedIndex = 0
        Estado = Datos.LLenar_Combo("Select * From Estado_CN", Me.cbEstado, "Descripcion_Estado_CN")
        Me.cbEstado.SelectedIndex = 0
        Call Me.Filtrar()
        Call Me.Dimensionar()
    End Sub
    Sub Filtrar()
        If Me.cbUnidadOrganica.Items.Count > 0 And Me.cbEstado.Items.Count > 0 Then
            Dim S As String = ""
            If Me.cbUnidadOrganica.SelectedIndex = 0 Then S = S & "" Else S = S & " and Nombre_Unidad_Organica = '" & Unidad_Organica.Rows(Me.cbUnidadOrganica.SelectedIndex - 1).Item("Nombre_Unidad_Organica") & "'"
            If Me.cbEstado.SelectedIndex = 0 Then S = S & "" Else S = S & " and Descripcion_Estado_CN = '" & Estado.Rows(Me.cbEstado.SelectedIndex - 1).Item("Descripcion_Estado_CN") & "'"
            Llenar(B_Busqueda_S & B_Busqueda_W & S & B_Busqueda_O)
            Call Me.Dimensionar()
        End If
    End Sub
    Sub Llenar(ByVal S_Busqueda As String)
        Dim DT As New DataTable
        DT = Datos.LLenar_DT(S_Busqueda)
        Me.dgvCuadroDeNecesidades.DataSource = DT
        If DT.Rows.Count > 0 Then
            Me.lblRegistros.Text = " - Total de Registros Encontrados: " & DT.Rows.Count
            Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
        Else
            Me.lblRegistros.Text = " - Total de Registros Encontrados: 0"
            Me.Boton_Editar_CN.Enabled = False
            Me.Boton_Extornar_CN.Enabled = False
            Me.Boton_Eliminar_CN.Enabled = False
            Me.Boton_Aprobar_CN.Enabled = False
            Me.Boton_Autorizar_CN.Enabled = False
            Me.Boton_Visualizar_CN.Enabled = False
            Me.Boton_Imprimir_CN.Enabled = False
        End If
    End Sub
    Private Sub cbUnidadOrganica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidadOrganica.SelectedIndexChanged 
        Call Me.Filtrar()
    End Sub
    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged 
        Call Me.Filtrar()
    End Sub
    Private Sub Dimensionar()
        Me.dgvCuadroDeNecesidades.Columns(0).Width = 50
        Me.dgvCuadroDeNecesidades.Columns(1).Width = 50
        Me.dgvCuadroDeNecesidades.Columns(2).Width = 40
        Me.dgvCuadroDeNecesidades.Columns(3).Width = 50
        Me.dgvCuadroDeNecesidades.Columns(4).Width = 480
        Me.dgvCuadroDeNecesidades.Columns(5).Width = 80
        Me.dgvCuadroDeNecesidades.Columns(6).Width = 80
        Me.dgvCuadroDeNecesidades.Columns(7).Width = 80
        Me.dgvCuadroDeNecesidades.Columns(8).Width = 100
        Me.dgvCuadroDeNecesidades.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvCuadroDeNecesidades.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Me.dgvCuadroDeNecesidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCuadroDeNecesidades.ColumnHeadersHeight = 30
        Me.dgvCuadroDeNecesidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCuadroDeNecesidades.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvCuadroDeNecesidades.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCuadroDeNecesidades.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub
    Private Sub Boton_Nuevo_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Nuevo_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Nuevo_CN.Name) = True Then
            Dim Formulario As New frmRegistro_CN
            Formulario.Editar = False
            Formulario.ShowDialog()
            Call Me.Filtrar()
            Call Me.Dimensionar()
            Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir.Click 
        Me.Close()
    End Sub
    Private Sub Boton_Visualizar_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Visualizar_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Visualizar_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If Me.dgvCuadroDeNecesidades.CurrentCellAddress.Y >= 0 Then
                    Datos.Imprimir_Reporte("Select * From Lista_Detalle_CN_Basica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Secuencia_Funcional='" & Me.dgvCuadroDeNecesidades.CurrentRow.Cells(1).Value & "' And Codigo_Actividad='" & Me.dgvCuadroDeNecesidades.CurrentRow.Cells(2).Value & "' And Codigo_Unidad_Organica='" & Me.dgvCuadroDeNecesidades.CurrentRow.Cells(3).Value & "' Order by Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle),Abs(Especifica),Abs(Especifica_Detalle)", New Reporte_CN_Resumen, 100, "Reporte Cuadro de Necesidades", False)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                Else
                    MessageBox.Show("Seleccione un C.N. para Reportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                End If
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuadroDeNecesidades.CellContentClick 
        If Me.dgvCuadroDeNecesidades.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Secuencia_Funcional = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(1).Value
            Variable_Codigo_Actividad = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(2).Value
            Variable_Codigo_Unidad_Organica = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(3).Value
            Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
        Else
            Variable_Codigo_Secuencia_Funcional = ""
            Variable_Codigo_Actividad = ""
            Variable_Codigo_Unidad_Organica = ""
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuadroDeNecesidades.CellContentDoubleClick 
        If Me.dgvCuadroDeNecesidades.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Secuencia_Funcional = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(1).Value
            Variable_Codigo_Actividad = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(2).Value
            Variable_Codigo_Unidad_Organica = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(3).Value
            Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
        Else
            Variable_Codigo_Secuencia_Funcional = ""
            Variable_Codigo_Actividad = ""
            Variable_Codigo_Unidad_Organica = ""
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuadroDeNecesidades.CellEnter 
        If Me.dgvCuadroDeNecesidades.CurrentCellAddress.Y >= 0 Then
            Variable_Codigo_Secuencia_Funcional = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(1).Value
            Variable_Codigo_Actividad = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(2).Value
            Variable_Codigo_Unidad_Organica = Me.dgvCuadroDeNecesidades.CurrentRow.Cells(3).Value
            Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
        Else
            Variable_Codigo_Secuencia_Funcional = ""
            Variable_Codigo_Actividad = ""
            Variable_Codigo_Unidad_Organica = ""
        End If
    End Sub
    Private Sub Boton_Editar_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Editar_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Editar_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                Dim Formulario As New frmRegistro_CN
                Formulario.Editar = True
                Formulario.ShowDialog()
                Call Me.Filtrar()
                Call Me.Dimensionar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Actualizar_Registros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Actualizar_Registros.Click 
        Call Me.Filtrar()
    End Sub
    Private Sub Boton_Imprimir_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Imprimir_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Imprimir_CN.Name) = True Then
           If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If Me.dgvCuadroDeNecesidades.CurrentCellAddress.Y >= 0 Then
                    Datos.Imprimir_Reporte("Select * From Lista_Detalle_CN_Basica_reporte Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Secuencia_Funcional='" & Me.dgvCuadroDeNecesidades.CurrentRow.Cells(1).Value & "' And Codigo_Actividad='" & Me.dgvCuadroDeNecesidades.CurrentRow.Cells(2).Value & "' And Codigo_Unidad_Organica='" & Me.dgvCuadroDeNecesidades.CurrentRow.Cells(3).Value & "' Order by Codigo_Catalogo, Partida, Nombre_Partida asc", New Reporte_CN_Resumen_General, 100, "Reporte Cuadro de Necesidades", False)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                Else
                    MessageBox.Show("Seleccione un C.N. para Reportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                End If
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Eliminar_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Eliminar_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Eliminar_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Eliminar el CN seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Eliminar_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Extornar_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Extornar_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Extornar_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Extornar el CN seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Extornar_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad)
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Autorizar_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Autorizar_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Autorizar_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Autorizar el CN seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Autorizar_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad, My.Settings.Usuario)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Aprobar_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Aprobar_CN.Click 
        If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Aprobar_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If MessageBox.Show("Deseas realmente Autorizar el CN seleccionado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Datos.Aprobar_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Unidad_Organica, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Actividad, My.Settings.Usuario)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                End If
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Visualizar_Saldos_CN_Click(sender As Object, e As EventArgs) Handles Boton_Visualizar_Saldos_CN.Click
        Dim Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte = new rpt_lista_saldos_generales
         If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Visualizar_Saldos_CN.Name) = True Then
            If Variable_Codigo_Secuencia_Funcional.Trim.Length > 0 And Variable_Codigo_Actividad.Trim.Length > 0 And Variable_Codigo_Unidad_Organica.Trim.Length > 0 Then
                If Me.dgvCuadroDeNecesidades.CurrentCellAddress.Y >= 0 Then
                    Datos.Consulta_Saldo_Unidades_Organicas(My.Settings.Año_Ejecucion)
                    Dim DT As New DataTable
                    DT = Datos.Consulta_Saldo_Unidades_Organicas(My.Settings.Año_Ejecucion).Tables(0)
                    With frmVisor_Reportes
                        .Reporte = Reporte 'rpt_lista_saldos_generales
                        .Reporte.SetDataSource(DT)
                        .Visor_Reporte.ReportSource = .Reporte
                        .Visor_Reporte.Zoom(100)
                        .Visor_Reporte.RefreshReport()
                        .Text = "Reporte de Saldos Totales"
                        .ShowDialog()
                    End With
                Else
                    MessageBox.Show("Seleccione un C.N. para Reportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    Call Me.Filtrar()
                    Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
                End If
            Else
                Call Me.Filtrar()
                Datos.Evaluacion_Botones_Modulo_CN(My.Settings.Año_Ejecucion, Variable_Codigo_Secuencia_Funcional, Variable_Codigo_Unidad_Organica, Variable_Codigo_Actividad, Boton_Nuevo_CN, Boton_Editar_CN, Boton_Eliminar_CN, Boton_Extornar_CN, Boton_Autorizar_CN, Boton_Aprobar_CN, Me.Boton_Visualizar_CN, Me.Boton_Imprimir_CN)
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Exportar_Excel_CN_General_Click(sender As Object, e As EventArgs) Handles Boton_Exportar_Excel_CN_General.Click
       '  If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Exportar_Excel_CN_General.Name) = True Then
       '     Dim Query As String = "Select Unidad_O as Unidad_Organica, Año_Ejecucion,case when Codigo_Catalogo='01' then 'BIEN' else 'SERVICIO' END TipoCatalogo, Clasificador, Descripcion_Especifica_Detalle, 
       '     codigo, item, unidad, costo, cantidad, Cantidad_Enero as Cantidad_Enero, Cantidad_Febrero as Cantidad_Febrero,
						 'Cantidad_Marzo as Cantidad_Marzo,
       '                  Cantidad_Abril as Cantidad_Abril,
						 'Cantidad_Mayo as Cantidad_Mayo,
						 'Cantidad_Junio as Cantidad_Junio, 
						 'Cantidad_Julio as Cantidad_Julio,
						 'Cantidad_Agosto as Cantidad_Agosto,
						 'Cantidad_Septiembre as Cantidad_Septiembre,
						 'Cantidad_Octubre as Cantidad_Octubre,                       
						 'Cantidad_Noviembre as Cantidad_Noviembre,
						 'Cantidad_Diciembre as Cantidad_Diciembre From Lista_Detalle_CN_Basica_edicion Where Año_Ejecucion='"+My.Settings.Año_Ejecucion+"'
						 'order by Unidad_O ,TipoCatalogo asc, item asc"
       '     Datos.Exportar_Lista_CN(Query)
       ' Else
       '     MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
       ' End If
        Dim Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte = new rptListadoPorItemCN
         If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Exportar_Excel_CN_General.Name) = True Then
                Dim DT As New DataTable

                Dim Query As String = "Select b.Abreviatura as Unidad_Organica, a.Año_Ejecucion,case when Codigo_Catalogo='01' then 'BIEN' else 'SERVICIO' END TipoCatalogo, Clasificador, Descripcion_Especifica_Detalle, 
codigo, item, unidad, costo, cantidad, Cantidad_Enero as Cantidad_Enero, Cantidad_Febrero as Cantidad_Febrero,
						 Cantidad_Marzo as Cantidad_Marzo,
                         Cantidad_Abril as Cantidad_Abril,
						 Cantidad_Mayo as Cantidad_Mayo,
						 Cantidad_Junio as Cantidad_Junio, 
						 Cantidad_Julio as Cantidad_Julio,
						 Cantidad_Agosto as Cantidad_Agosto,
						 Cantidad_Septiembre as Cantidad_Septiembre,
						 Cantidad_Octubre as Cantidad_Octubre,                       
						 Cantidad_Noviembre as Cantidad_Noviembre,
						 Cantidad_Diciembre as Cantidad_Diciembre 
						 From Lista_Detalle_CN_Basica_edicion a inner join Unidad_Organica b on a.Codigo_Unidad_Organica=b.Codigo_Unidad_Organica 
						 and a.Año_Ejecucion=b.Año_Ejecucion
						 Where a.Año_Ejecucion='"+My.Settings.Año_Ejecucion+"'
						 order by TipoCatalogo asc, Clasificador,codigo asc, item asc"

                DT = Datos.Ejecutar_Select(Query)
                With frmVisor_Reportes
                    .Reporte = Reporte 'rpt_lista_saldos_generales
                    .Reporte.SetDataSource(DT)
                    .Visor_Reporte.ReportSource = .Reporte
                    .Visor_Reporte.Zoom(100)
                    .Visor_Reporte.RefreshReport()
                    .Text = "Reporte de Saldos Totales"
                    .ShowDialog()
                End With
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Reporte_General_CN_Click(sender As Object, e As EventArgs) Handles Boton_Reporte_General_CN.Click
        Dim Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte = new rptCnGeneral
         If Datos.Acceso_Sub_Boton(My.Settings.Usuario.Trim, "Boton_Cuadro_Necesidades", Me.Boton_Reporte_General_CN.Name) = True Then
                Dim DT As New DataTable
                
                Dim Query As String = "Select b.Abreviatura as Unidad_Organica, a.Año_Ejecucion,case when Codigo_Catalogo='01' then 'B' else 'S' END TipoCatalogo, Clasificador, Descripcion_Especifica_Detalle, 
                             codigo, item, unidad, costo, cantidad, Cantidad_Enero as Cantidad_Enero, Cantidad_Febrero as Cantidad_Febrero,
						     Cantidad_Marzo as Cantidad_Marzo,
                             Cantidad_Abril as Cantidad_Abril,
						     Cantidad_Mayo as Cantidad_Mayo,
						     Cantidad_Junio as Cantidad_Junio, 
						     Cantidad_Julio as Cantidad_Julio,
						     Cantidad_Agosto as Cantidad_Agosto,
						     Cantidad_Septiembre as Cantidad_Septiembre,
						     Cantidad_Octubre as Cantidad_Octubre,                       
						     Cantidad_Noviembre as Cantidad_Noviembre,
						     Cantidad_Diciembre as Cantidad_Diciembre 
						     From Lista_Detalle_CN_Basica_edicion a inner join Unidad_Organica b on a.Codigo_Unidad_Organica=b.Codigo_Unidad_Organica 
						     and a.Año_Ejecucion=b.Año_Ejecucion
						     Where a.Año_Ejecucion='"+My.Settings.Año_Ejecucion+"'
						     order by Unidad_O ,TipoCatalogo asc, item asc"

                DT = Datos.Ejecutar_Select(Query)
                With frmVisor_Reportes
                    .Reporte = Reporte 'rpt_lista_saldos_generales
                    .Reporte.SetDataSource(DT)
                    .Visor_Reporte.ReportSource = .Reporte
                    .Visor_Reporte.Zoom(100)
                    .Visor_Reporte.RefreshReport()
                    .Text = "Reporte de Saldos Totales"
                    .ShowDialog()
                End With
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class