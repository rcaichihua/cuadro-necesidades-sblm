<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar7 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Salir_2 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar23 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Registro_Bienes = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Registro_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Unidades_Organicas = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Secuencias_Funcionales = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Registro_Actividades = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Registro_Clasificadores = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Registro_Cuentas_Contables = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Registro_Denominaciones = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar6 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Eliminar_Parametros = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Configuracion_Base_Datos = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Generar_Backup = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar5 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Registro_Usuarios = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Cambiar_Clave = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar9 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Salir_3 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar8 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Cuadro_Necesidades = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Accion_Modificatoria = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Catalogo_Bienes = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Catalogo_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.Boton_Requerimiento_Bienes = New DevComponents.DotNetBar.ButtonItem()
        Me.Boton_Requerimiento_Servicios = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonTabItem3 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribbonControl1.SuspendLayout
        Me.RibbonPanel2.SuspendLayout
        Me.RibbonPanel4.SuspendLayout
        Me.SuspendLayout
        '
        'ribbonControl1
        '
        Me.ribbonControl1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel4)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.ForeColor = System.Drawing.Color.Black
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem3, Me.RibbonTabItem2})
        Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7!)
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ribbonControl1.Size = New System.Drawing.Size(1284, 120)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabIndex = 3
        Me.ribbonControl1.Text = "ribbonControl1"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar7)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar23)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar6)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar5)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(1284, 91)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = false
        '
        'RibbonBar7
        '
        Me.RibbonBar7.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar7.ContainerControlProcessDialogKey = true
        Me.RibbonBar7.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar7.DragDropSupport = true
        Me.RibbonBar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Salir_2})
        Me.RibbonBar7.Location = New System.Drawing.Point(1012, 0)
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Size = New System.Drawing.Size(69, 88)
        Me.RibbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar7.TabIndex = 10
        Me.RibbonBar7.Text = "Salir"
        '
        '
        '
        Me.RibbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Salir_2
        '
        Me.Boton_Salir_2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Salir_2.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Salir
        Me.Boton_Salir_2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Salir_2.Name = "Boton_Salir_2"
        Me.Boton_Salir_2.Text = "<div align=""center"">Salir a<br/>Windows</div>"
        '
        'RibbonBar23
        '
        Me.RibbonBar23.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar23.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar23.ContainerControlProcessDialogKey = true
        Me.RibbonBar23.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar23.DragDropSupport = true
        Me.RibbonBar23.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Registro_Bienes, Me.Boton_Registro_Servicios, Me.Boton_Unidades_Organicas, Me.Boton_Secuencias_Funcionales, Me.Boton_Registro_Actividades, Me.Boton_Registro_Clasificadores, Me.Boton_Registro_Cuentas_Contables, Me.Boton_Registro_Denominaciones})
        Me.RibbonBar23.Location = New System.Drawing.Point(361, 0)
        Me.RibbonBar23.Name = "RibbonBar23"
        Me.RibbonBar23.Size = New System.Drawing.Size(651, 88)
        Me.RibbonBar23.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar23.TabIndex = 9
        Me.RibbonBar23.Text = "Tablas Padre"
        '
        '
        '
        Me.RibbonBar23.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar23.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Registro_Bienes
        '
        Me.Boton_Registro_Bienes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Bienes.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Catalogo_Bienes
        Me.Boton_Registro_Bienes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Bienes.Name = "Boton_Registro_Bienes"
        Me.Boton_Registro_Bienes.Text = "<div align=""center"">Registro<br/>de Bienes</div>"
        '
        'Boton_Registro_Servicios
        '
        Me.Boton_Registro_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Catalogo_Servicios
        Me.Boton_Registro_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Servicios.Name = "Boton_Registro_Servicios"
        Me.Boton_Registro_Servicios.Text = "<div align=""center"">Registro<br/>de Servicios</div>"
        '
        'Boton_Unidades_Organicas
        '
        Me.Boton_Unidades_Organicas.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Unidades_Organicas.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Autorizar
        Me.Boton_Unidades_Organicas.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Unidades_Organicas.Name = "Boton_Unidades_Organicas"
        Me.Boton_Unidades_Organicas.Text = "<div align=""center"">Unidades<br/>Organicas</div>"
        '
        'Boton_Secuencias_Funcionales
        '
        Me.Boton_Secuencias_Funcionales.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Secuencias_Funcionales.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_PIA
        Me.Boton_Secuencias_Funcionales.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Secuencias_Funcionales.Name = "Boton_Secuencias_Funcionales"
        Me.Boton_Secuencias_Funcionales.Text = "<div align=""center"">Secuencias<br/>Funcionales</div>"
        '
        'Boton_Registro_Actividades
        '
        Me.Boton_Registro_Actividades.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Actividades.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Procesos
        Me.Boton_Registro_Actividades.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Actividades.Name = "Boton_Registro_Actividades"
        Me.Boton_Registro_Actividades.Text = "<div align=""center"">Registro<br/>Actividades</div>"
        '
        'Boton_Registro_Clasificadores
        '
        Me.Boton_Registro_Clasificadores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Clasificadores.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Planillas_2
        Me.Boton_Registro_Clasificadores.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Clasificadores.Name = "Boton_Registro_Clasificadores"
        Me.Boton_Registro_Clasificadores.Text = "<div align=""center"">Registro<br/>Clasificadores</div>"
        '
        'Boton_Registro_Cuentas_Contables
        '
        Me.Boton_Registro_Cuentas_Contables.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Cuentas_Contables.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Planillas
        Me.Boton_Registro_Cuentas_Contables.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Cuentas_Contables.Name = "Boton_Registro_Cuentas_Contables"
        Me.Boton_Registro_Cuentas_Contables.Text = "<div align=""center"">Cuentas<br/>Contables</div>"
        '
        'Boton_Registro_Denominaciones
        '
        Me.Boton_Registro_Denominaciones.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Denominaciones.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_PAC
        Me.Boton_Registro_Denominaciones.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Denominaciones.Name = "Boton_Registro_Denominaciones"
        Me.Boton_Registro_Denominaciones.Text = "<div align=""center"">Registro<br/>Denominaciones</div>"
        '
        'RibbonBar6
        '
        Me.RibbonBar6.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar6.ContainerControlProcessDialogKey = true
        Me.RibbonBar6.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar6.DragDropSupport = true
        Me.RibbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Eliminar_Parametros, Me.Boton_Configuracion_Base_Datos, Me.Boton_Generar_Backup})
        Me.RibbonBar6.Location = New System.Drawing.Point(121, 0)
        Me.RibbonBar6.Name = "RibbonBar6"
        Me.RibbonBar6.Size = New System.Drawing.Size(240, 88)
        Me.RibbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar6.TabIndex = 2
        Me.RibbonBar6.Text = "Base de Datos"
        '
        '
        '
        Me.RibbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Eliminar_Parametros
        '
        Me.Boton_Eliminar_Parametros.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Eliminar_Parametros.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Eliminar
        Me.Boton_Eliminar_Parametros.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Eliminar_Parametros.Name = "Boton_Eliminar_Parametros"
        Me.Boton_Eliminar_Parametros.Text = "<div align=""center"">Eliminar<br/>Parámetros</div>"
        '
        'Boton_Configuracion_Base_Datos
        '
        Me.Boton_Configuracion_Base_Datos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Configuracion_Base_Datos.Image = Global.SAG_SBLM.My.Resources.Resources.Actualizar_Registro
        Me.Boton_Configuracion_Base_Datos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Configuracion_Base_Datos.Name = "Boton_Configuracion_Base_Datos"
        Me.Boton_Configuracion_Base_Datos.Text = "<div align=""center"">Configuración<br/>Base de Datos</div>"
        '
        'Boton_Generar_Backup
        '
        Me.Boton_Generar_Backup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Generar_Backup.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Solicitud_Certificacion_2
        Me.Boton_Generar_Backup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Generar_Backup.Name = "Boton_Generar_Backup"
        Me.Boton_Generar_Backup.Text = "<div align=""center"">Generar<br/>Copia de B/D</div>"
        '
        'RibbonBar5
        '
        Me.RibbonBar5.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar5.ContainerControlProcessDialogKey = true
        Me.RibbonBar5.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar5.DragDropSupport = true
        Me.RibbonBar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Registro_Usuarios, Me.Boton_Cambiar_Clave})
        Me.RibbonBar5.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar5.Name = "RibbonBar5"
        Me.RibbonBar5.Size = New System.Drawing.Size(118, 88)
        Me.RibbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar5.TabIndex = 1
        Me.RibbonBar5.Text = "Usuarios "
        '
        '
        '
        Me.RibbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Registro_Usuarios
        '
        Me.Boton_Registro_Usuarios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Registro_Usuarios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Usuarios
        Me.Boton_Registro_Usuarios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Registro_Usuarios.Name = "Boton_Registro_Usuarios"
        Me.Boton_Registro_Usuarios.Text = "<div align=""center"">Registro<br/>Usuarios</div>"
        '
        'Boton_Cambiar_Clave
        '
        Me.Boton_Cambiar_Clave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Cambiar_Clave.Image = Global.SAG_SBLM.My.Resources.Resources.Editar2
        Me.Boton_Cambiar_Clave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Cambiar_Clave.Name = "Boton_Cambiar_Clave"
        Me.Boton_Cambiar_Clave.Text = "<div align=""center"">Cambiar<br/>Mi Clave</div>"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar9)
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar8)
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar4)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(1284, 91)
        '
        '
        '
        Me.RibbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel4.TabIndex = 4
        '
        'RibbonBar9
        '
        Me.RibbonBar9.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar9.ContainerControlProcessDialogKey = true
        Me.RibbonBar9.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar9.DragDropSupport = true
        Me.RibbonBar9.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Salir_3})
        Me.RibbonBar9.Location = New System.Drawing.Point(469, 0)
        Me.RibbonBar9.Name = "RibbonBar9"
        Me.RibbonBar9.Size = New System.Drawing.Size(69, 88)
        Me.RibbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar9.TabIndex = 18
        Me.RibbonBar9.Text = "Salir"
        '
        '
        '
        Me.RibbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Salir_3
        '
        Me.Boton_Salir_3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Salir_3.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Salir
        Me.Boton_Salir_3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Salir_3.Name = "Boton_Salir_3"
        Me.Boton_Salir_3.Text = "<div align=""center"">Salir del<br/>Sistema</div>"
        '
        'RibbonBar8
        '
        Me.RibbonBar8.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar8.ContainerControlProcessDialogKey = true
        Me.RibbonBar8.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar8.DragDropSupport = true
        Me.RibbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Cuadro_Necesidades, Me.Boton_Accion_Modificatoria, Me.Boton_Catalogo_Bienes, Me.Boton_Catalogo_Servicios})
        Me.RibbonBar8.Location = New System.Drawing.Point(179, 0)
        Me.RibbonBar8.Name = "RibbonBar8"
        Me.RibbonBar8.Size = New System.Drawing.Size(290, 88)
        Me.RibbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar8.TabIndex = 17
        Me.RibbonBar8.Text = "Cuadro de Necesidades"
        '
        '
        '
        Me.RibbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Cuadro_Necesidades
        '
        Me.Boton_Cuadro_Necesidades.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Cuadro_Necesidades.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Bienes
        Me.Boton_Cuadro_Necesidades.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Cuadro_Necesidades.Name = "Boton_Cuadro_Necesidades"
        Me.Boton_Cuadro_Necesidades.Text = "<div align=""center"">Cuadro<br/>Necesidades</div>"
        '
        'Boton_Accion_Modificatoria
        '
        Me.Boton_Accion_Modificatoria.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Accion_Modificatoria.Image = Global.SAG_SBLM.My.Resources.Resources.Editar2
        Me.Boton_Accion_Modificatoria.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Accion_Modificatoria.Name = "Boton_Accion_Modificatoria"
        Me.Boton_Accion_Modificatoria.Text = "<div align=""center"">Acciones<br/>Modificatorias</div>"
        '
        'Boton_Catalogo_Bienes
        '
        Me.Boton_Catalogo_Bienes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Catalogo_Bienes.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Catalogo_Bienes
        Me.Boton_Catalogo_Bienes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Catalogo_Bienes.Name = "Boton_Catalogo_Bienes"
        Me.Boton_Catalogo_Bienes.Text = "<div align=""center"">Catálogo<br/>de Bienes</div>"
        '
        'Boton_Catalogo_Servicios
        '
        Me.Boton_Catalogo_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Catalogo_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Catalogo_Servicios
        Me.Boton_Catalogo_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Catalogo_Servicios.Name = "Boton_Catalogo_Servicios"
        Me.Boton_Catalogo_Servicios.Text = "<div align=""center"">Catálogo<br/>de Servicios</div>"
        '
        'RibbonBar4
        '
        Me.RibbonBar4.AutoOverflowEnabled = true
        '
        '
        '
        Me.RibbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar4.ContainerControlProcessDialogKey = true
        Me.RibbonBar4.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar4.DragDropSupport = true
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Boton_Requerimiento_Bienes, Me.Boton_Requerimiento_Servicios})
        Me.RibbonBar4.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(176, 88)
        Me.RibbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar4.TabIndex = 15
        Me.RibbonBar4.Text = "Gestión de Requerimientos"
        '
        '
        '
        Me.RibbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Boton_Requerimiento_Bienes
        '
        Me.Boton_Requerimiento_Bienes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Requerimiento_Bienes.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Bienes
        Me.Boton_Requerimiento_Bienes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Requerimiento_Bienes.Name = "Boton_Requerimiento_Bienes"
        Me.Boton_Requerimiento_Bienes.Text = "<div align=""center"">Requerimiento<br/>Bienes</div>"
        '
        'Boton_Requerimiento_Servicios
        '
        Me.Boton_Requerimiento_Servicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Boton_Requerimiento_Servicios.Image = Global.SAG_SBLM.My.Resources.Resources.Icono_Servicios
        Me.Boton_Requerimiento_Servicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Boton_Requerimiento_Servicios.Name = "Boton_Requerimiento_Servicios"
        Me.Boton_Requerimiento_Servicios.Text = "<div align=""center"">Requerimiento<br/>Servicios</div>"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(1284, 117)
        '
        '
        '
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        '
        'RibbonTabItem3
        '
        Me.RibbonTabItem3.Checked = true
        Me.RibbonTabItem3.Name = "RibbonTabItem3"
        Me.RibbonTabItem3.Panel = Me.RibbonPanel4
        Me.RibbonTabItem3.Text = "Módulo del Area Usuaria"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel2
        Me.RibbonTabItem2.Text = "Modulo del Administrador del Sistema"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAG_SBLM.My.Resources.Resources.new_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 575)
        Me.Controls.Add(Me.ribbonControl1)
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ribbonControl1.ResumeLayout(false)
        Me.ribbonControl1.PerformLayout
        Me.RibbonPanel2.ResumeLayout(false)
        Me.RibbonPanel4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar5 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Registro_Usuarios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonBar6 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Eliminar_Parametros As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Configuracion_Base_Datos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Generar_Backup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem3 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents Boton_Cambiar_Clave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar7 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Salir_2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar23 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Registro_Bienes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Registro_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Unidades_Organicas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Secuencias_Funcionales As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Registro_Actividades As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Registro_Clasificadores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Registro_Cuentas_Contables As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Registro_Denominaciones As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Requerimiento_Bienes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Requerimiento_Servicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar9 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Salir_3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar8 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Boton_Cuadro_Necesidades As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Accion_Modificatoria As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Catalogo_Bienes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Boton_Catalogo_Servicios As DevComponents.DotNetBar.ButtonItem
End Class
