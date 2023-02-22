Public Class frmMenu
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        RibbonTabItem3.Select
        Me.Text = "..:: Sistema Administrativo de Gestión - SBLM ::.. " & "Usuario: " & My.Settings.Nombre_Usuario & " - Año de Ejecución: " & My.Settings.Año_Ejecucion
    End Sub

    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Close()
    End Sub

    Private Sub Boton_Salir_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir_2.Click 
        Close()
    End Sub
    
    Private Sub Boton_Registro_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registro_Usuarios.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Registro_Usuarios.Name) = True Then
            Datos.Llamar_Formulario_Unico(frmModulo_Usuarios, Me)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Eliminar_Parametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Eliminar_Parametros.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Eliminar_Parametros.Name) = True Then
            If MessageBox.Show("¿Deseas realmente Eliminar los Parámetros de Funcionamiento del Sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                My.Settings.Reset()
                My.Settings.Save()
                End
            End If
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Configuracion_Base_Datos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Configuracion_Base_Datos.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Configuracion_Base_Datos.Name) = True Then
            Dim Formulario As New frmConfigurar_Base
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Generar_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Generar_Backup.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Generar_Backup.Name) = True Then
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    
    Private Sub Boton_Salir_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        Close()
    End Sub
    Private Sub Boton_Salir_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        Close()
    End Sub
    Private Sub Boton_Salir_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        Close()
    End Sub
    Private Sub Boton_Salir_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        Close()
    End Sub

    Private Sub Boton_Catalogo_Bienes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Catalogo_Bienes.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Catalogo_Bienes.Name) = True Then
            Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
            Formulario.Tipo_Catalogo = "01"
            Formulario.Operacion = 1
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Catalogo_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Catalogo_Servicios.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Catalogo_Servicios.Name) = True Then
            Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
            Formulario.Tipo_Catalogo = "02"
            Formulario.Operacion = 1
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Salir_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir_3.Click  
        me.Close()
    End Sub
    Private Sub Boton_Cambiar_Clave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Cambiar_Clave.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Cambiar_Clave.Name) = True Then
            Dim Formulario As New frmCambiar_Clave
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    
    Private Sub Boton_Registro_Bienes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registro_Bienes.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Registro_Bienes.Name) = True Then
            Dim Formulario As New frmRegistro_Items
            Formulario.Tipo_Catalogo = "01"
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Registro_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registro_Servicios.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Registro_Servicios.Name) = True Then
            Dim Formulario As New frmRegistro_Items
            Formulario.Tipo_Catalogo = "02"
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    
    Private Sub Boton_Salir_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        Close()
    End Sub
    Private Sub Boton_Salir_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        close()
    End Sub
    
    Private Sub Boton_Registro_Trabajadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
         MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Registro_Contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
         MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    'Private Sub Boton_Cadenas_Presupuestales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Cadenas_Presupuestales.Click 
    '    If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Cadenas_Presupuestales.Name) = True Then
    '        Dim Formulario As New frmCadenas_Presupuestales
    '        Formulario.ShowDialog()
    '    Else
    '        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    '    End If
    'End Sub
    Private Sub Boton_Unidades_Organicas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Unidades_Organicas.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Unidades_Organicas.Name) = True Then
            Dim Formulario As New frmRegistro_Unidades_Organicas
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Secuencias_Funcionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Secuencias_Funcionales.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Secuencias_Funcionales.Name) = True Then


        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Registro_Actividades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registro_Actividades.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Registro_Actividades.Name) = True Then


        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Boton_Registro_Clasificadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registro_Clasificadores.Click 
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Registro_Clasificadores.Name) = True Then
            Dim Formulario As New frmClasificadores
            Formulario.ShowDialog()
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

   Private Sub Boton_Cuadro_Necesidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Cuadro_Necesidades.Click 
        'MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Cuadro_Necesidades.Name) = True Then
            Datos.Llamar_Formulario_Unico(frmModulo_CN, Me)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Reporte_Requerimiento_Bienes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub Boton_Reporte_Requerimiento_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub Boton_Estudio_Mercado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub Boton_Gestion_PAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Registro_NEA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Registro_PECOSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Reporte_NEA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Reporte_PECOSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Registro_Convocatorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Registro_Legajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Reporte_Trabajadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Reporte_Legajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub Boton_Reporte_Planillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Este Módulo se encuentra en Construcción, Codificación y Diseño", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    End Sub
    
    'Private Sub Boton_Registro_Cuentas_Contables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registro_Cuentas_Contables.Click 
    '    If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Registro_Cuentas_Contables.Name) = True Then
    '        Dim Formulario As New frmRegistro_Cuentas_Contables
    '        Formulario.ShowDialog()
    '    Else
    '        MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
    '    End If
    'End Sub

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing 
        Dim Message As String
        Dim result As DialogResult
        Message = "Esta seguro que desea salir del Sistema?"
        Dim buttons As MessageBoxButtons
        buttons = MessageBoxButtons.YesNo

        result = MessageBox.Show(Message, Me.Text, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = System.Windows.Forms.DialogResult.Yes Then
            Dispose(True)
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Boton_Accion_Modificatoria_Click(sender As Object, e As EventArgs) Handles Boton_Accion_Modificatoria.Click
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Accion_Modificatoria.Name) = True Then
            Datos.Llamar_Formulario_Unico(frmModulo_Acciones_Modificatorias, Me)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Requerimiento_Bienes_Click(sender As Object, e As EventArgs) Handles Boton_Requerimiento_Bienes.Click
        If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Requerimiento_Bienes.Name) = True Then
            Datos.Llamar_Formulario_Unico(frmModulo_Requerimiento_Bienes, Me)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Boton_Requerimiento_Servicios_Click(sender As Object, e As EventArgs) Handles Boton_Requerimiento_Servicios.Click
         If Datos.Acceso_Boton(My.Settings.Usuario.Trim, Me.Boton_Requerimiento_Servicios.Name) = True Then
            Datos.Llamar_Formulario_Unico(frmModulo_Requerimiento_Servicios, Me)
        Else
            MessageBox.Show("Estimado: " & My.Settings.Nombre_Usuario & ", Ud no cuenta con privilegios para acceder a esta opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class
