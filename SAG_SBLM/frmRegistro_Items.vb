Public Class frmRegistro_Items
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Tipo_Transaccion As New DataTable
    Dim Generica As New DataTable
    Dim SubGenerica As New DataTable
    Dim SubGenerica_Detalle As New DataTable
    Dim Especifica As New DataTable
    Dim Especifica_Detalle As New DataTable
    Dim Datos As New Mantenimiento
    Public Tipo_Catalogo As String = ""
    Public Operacion As Integer = 0
    Dim Grupo As New DataTable
    Dim Clase As New DataTable
    Dim Familia As New DataTable
    Dim Unidad As New DataTable
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub cbTipoTransaccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoTransaccion.SelectedIndexChanged
        If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
            Generica = Datos.LLenar_Combo_Solo("Select * From Lista_Genericas Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Tipo_Transaccion='" & Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion") & "' Order By Abs(Tipo_Transaccion),Abs(Generica)", Me.cbGenerica, "Descripcion")
            Me.lblClasificador.Text = Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString & "."
            Me.cbGenerica.SelectedIndex = -1
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbGenerica.DataSource = Nothing
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        Else
            Me.cbGenerica.SelectedIndex = -1
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbGenerica.DataSource = Nothing
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub
    Private Sub cbGenerica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGenerica.SelectedIndexChanged
        If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
            If Me.cbGenerica.Text.Trim.Length > 0 Then
                SubGenerica = Datos.LLenar_Combo_Solo("Select * From Lista_SubGenericas Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Tipo_Transaccion='" & Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion") & "' And Generica='" & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica") & "' Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica)", Me.cbSubGenerica, "Descripcion")
                Me.lblClasificador.Text = Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString & "." & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString & "."
                Me.cbSubGenericaDetalle.SelectedIndex = -1
                Me.cbEspecifica.SelectedIndex = -1
                Me.cbEspecificaDetalle.SelectedIndex = -1
                Me.cbSubGenericaDetalle.DataSource = Nothing
                Me.cbEspecifica.DataSource = Nothing
                Me.cbEspecificaDetalle.DataSource = Nothing
            Else
                Me.cbSubGenericaDetalle.SelectedIndex = -1
                Me.cbEspecifica.SelectedIndex = -1
                Me.cbEspecificaDetalle.SelectedIndex = -1
                Me.cbSubGenericaDetalle.DataSource = Nothing
                Me.cbEspecifica.DataSource = Nothing
                Me.cbEspecificaDetalle.DataSource = Nothing
            End If
        Else
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub
    Private Sub cbSubGenericaDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubGenericaDetalle.SelectedIndexChanged
        If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
            If Me.cbGenerica.Text.Trim.Length > 0 Then
                If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                    If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                        Especifica = Datos.LLenar_Combo_Solo("Select * From Lista_Especificas Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Tipo_Transaccion='" & Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion") & "' And Generica='" & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica") & "' And Sub_Generica='" & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica") & "' And Sub_Generica_Detalle='" & SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle") & "' Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle),Abs(Especifica)", Me.cbEspecifica, "Descripcion")
                        Me.lblClasificador.Text = Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString & "." & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString & "." & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString & "." & SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString & "."
                        Me.cbEspecificaDetalle.SelectedIndex = -1
                        Me.cbEspecificaDetalle.DataSource = Nothing
                    Else
                        Me.cbEspecificaDetalle.SelectedIndex = -1
                        Me.cbEspecificaDetalle.DataSource = Nothing
                    End If
                Else
                    Me.cbEspecifica.SelectedIndex = -1
                    Me.cbEspecificaDetalle.SelectedIndex = -1
                    Me.cbEspecifica.DataSource = Nothing
                    Me.cbEspecificaDetalle.DataSource = Nothing
                End If
            Else
                Me.cbSubGenericaDetalle.SelectedIndex = -1
                Me.cbEspecifica.SelectedIndex = -1
                Me.cbEspecificaDetalle.SelectedIndex = -1
                Me.cbSubGenericaDetalle.DataSource = Nothing
                Me.cbEspecifica.DataSource = Nothing
                Me.cbEspecificaDetalle.DataSource = Nothing
            End If
        Else
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub

    Private Sub cbSubGenerica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubGenerica.SelectedIndexChanged
        If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
            If Me.cbGenerica.Text.Trim.Length > 0 Then
                If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                    SubGenerica_Detalle = Datos.LLenar_Combo_Solo("Select * From Lista_Subgenericas_Detalle Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Tipo_Transaccion='" & Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion") & "' And Generica='" & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica") & "' And Sub_Generica='" & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica") & "' Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle)", Me.cbSubGenericaDetalle, "Descripcion")
                    Me.lblClasificador.Text = Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString & "." & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString & "." & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString & "."
                    Me.cbEspecifica.SelectedIndex = -1
                    Me.cbEspecificaDetalle.SelectedIndex = -1
                    Me.cbEspecifica.DataSource = Nothing
                    Me.cbEspecificaDetalle.DataSource = Nothing
                Else
                    Me.cbEspecifica.SelectedIndex = -1
                    Me.cbEspecificaDetalle.SelectedIndex = -1
                    Me.cbEspecifica.DataSource = Nothing
                    Me.cbEspecificaDetalle.DataSource = Nothing
                End If
            Else
                Me.cbSubGenericaDetalle.SelectedIndex = -1
                Me.cbEspecifica.SelectedIndex = -1
                Me.cbEspecificaDetalle.SelectedIndex = -1
                Me.cbSubGenericaDetalle.DataSource = Nothing
                Me.cbEspecifica.DataSource = Nothing
                Me.cbEspecificaDetalle.DataSource = Nothing
            End If
        Else
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub
    Private Sub btnBuscarClasificador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarClasificador.Click
        Dim Formulario As New frmBuscar_Clasificadores
        Formulario.B_Adicional = " And Tipo_Transaccion ='2' "
        Formulario.ShowDialog()
        If Variable_Tipo_Transaccion.Trim.Length > 0 Then
            Me.cbTipoTransaccion.Text = Variable_Tipo_Transaccion
            Me.cbGenerica.Text = Variable_Generica
            Me.cbSubGenerica.Text = Variable_SubGenerica
            Me.cbSubGenericaDetalle.Text = Variable_SubGenerica_Detalle
            Me.cbEspecifica.Text = Variable_Especifica
            Me.cbEspecificaDetalle.Text = Variable_Especifica_Detalle
        Else
            Me.cbTipoTransaccion.SelectedIndex = -1
            Me.cbGenerica.SelectedIndex = -1
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbGenerica.DataSource = Nothing
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub
    Private Sub cbEspecifica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEspecifica.SelectedIndexChanged
        If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
            If Me.cbGenerica.Text.Trim.Length > 0 Then
                If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                    If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                        If Me.cbEspecifica.Text.Trim.Length > 0 Then
                            Especifica_Detalle = Datos.LLenar_Combo_Solo("Select * From Lista_Especificas_Detalle Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Tipo_Transaccion='" & Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion") & "' And Generica='" & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica") & "' And Sub_Generica='" & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica") & "' And Sub_Generica_Detalle='" & SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle") & "' And Especifica='" & Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica") & "' Order By Abs(Tipo_Transaccion),Abs(Generica),Abs(Sub_Generica),Abs(Sub_Generica_Detalle),Abs(Especifica),Abs(Especifica_Detalle)", Me.cbEspecificaDetalle, "Descripcion")
                            Me.lblClasificador.Text = Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString & "." & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString & "." & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString & "." & SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString & "." & Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica").ToString & "."
                        End If
                    Else
                        Me.cbEspecificaDetalle.SelectedIndex = -1
                        Me.cbEspecificaDetalle.DataSource = Nothing
                    End If
                Else
                    Me.cbEspecifica.SelectedIndex = -1
                    Me.cbEspecificaDetalle.SelectedIndex = -1
                    Me.cbEspecifica.DataSource = Nothing
                    Me.cbEspecificaDetalle.DataSource = Nothing
                End If
            Else
                Me.cbSubGenericaDetalle.SelectedIndex = -1
                Me.cbEspecifica.SelectedIndex = -1
                Me.cbEspecificaDetalle.SelectedIndex = -1
                Me.cbSubGenericaDetalle.DataSource = Nothing
                Me.cbEspecifica.DataSource = Nothing
                Me.cbEspecificaDetalle.DataSource = Nothing
            End If
        Else
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub
    Private Sub cbEspecificaDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEspecificaDetalle.SelectedIndexChanged
        If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
            If Me.cbGenerica.Text.Trim.Length > 0 Then
                If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                    If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                        If Me.cbEspecifica.Text.Trim.Length > 0 Then
                            If Me.cbEspecificaDetalle.Text.Trim.Length > 0 Then
                                Me.lblClasificador.Text = Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString & "." & Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString & "." & SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString & "." & SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString & "." & Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica").ToString & "." & Especifica_Detalle.Rows(Me.cbEspecificaDetalle.SelectedIndex).Item("Especifica_Detalle").ToString()
                            End If
                        Else
                            Me.cbEspecificaDetalle.SelectedIndex = -1
                            Me.cbEspecificaDetalle.DataSource = Nothing
                        End If
                    Else
                        Me.cbEspecificaDetalle.SelectedIndex = -1
                        Me.cbEspecificaDetalle.DataSource = Nothing
                    End If
                Else
                    Me.cbEspecifica.SelectedIndex = -1
                    Me.cbEspecificaDetalle.SelectedIndex = -1
                    Me.cbEspecifica.DataSource = Nothing
                    Me.cbEspecificaDetalle.DataSource = Nothing
                End If
            Else
                Me.cbSubGenericaDetalle.SelectedIndex = -1
                Me.cbEspecifica.SelectedIndex = -1
                Me.cbEspecificaDetalle.SelectedIndex = -1
                Me.cbSubGenericaDetalle.DataSource = Nothing
                Me.cbEspecifica.DataSource = Nothing
                Me.cbEspecificaDetalle.DataSource = Nothing
            End If
        Else
            Me.cbSubGenerica.SelectedIndex = -1
            Me.cbSubGenericaDetalle.SelectedIndex = -1
            Me.cbEspecifica.SelectedIndex = -1
            Me.cbEspecificaDetalle.SelectedIndex = -1
            Me.cbSubGenerica.DataSource = Nothing
            Me.cbSubGenericaDetalle.DataSource = Nothing
            Me.cbEspecifica.DataSource = Nothing
            Me.cbEspecificaDetalle.DataSource = Nothing
        End If
    End Sub
    Private Sub frmRegistro_Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Tipo_Transaccion = Datos.LLenar_Combo_Solo("Select * From Lista_Tipo_Transaccion Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "'", Me.cbTipoTransaccion, "Transaccion")
        Select Case Tipo_Catalogo
            Case "01"
                Grupo = Datos.LLenar_Combo_Solo("Select * From Lista_Grupos Where Codigo_Catalogo='01'", Me.cbGrupo, "Grupo")
                Unidad = Datos.LLenar_Combo_Solo("Select * From Lista_Unidades_Medida Where Codigo_Unidad_Medida <>'01'", Me.cbUnidadMedida, "Unidad")
            Case "02"
                Grupo = Datos.LLenar_Combo_Solo("Select * From Lista_Grupos Where Codigo_Catalogo='02'", Me.cbGrupo, "Grupo")
                Unidad = Datos.LLenar_Combo_Solo("Select * From Lista_Unidades_Medida Where Codigo_Unidad_Medida ='01'", Me.cbUnidadMedida, "Unidad")
                Label14.Visible = False
                txtPrecioReferencial.Visible=False
        End Select
        Call Botones(True)
    End Sub
    Private Sub cbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedIndexChanged
        If Me.cbGrupo.Items.Count > 0 Then
            Me.cbFamilia.DataSource = Nothing
            Me.cbClase.DataSource = Nothing
            Select Case Tipo_Catalogo
                Case "01"
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        Clase = Datos.LLenar_Combo_Solo("Select * From Lista_Clases Where Codigo_Catalogo='01' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString & "'", Me.cbClase, "Clase")
                        Me.cbFamilia.SelectedIndex = -1
                        Me.cbFamilia.DataSource = Nothing
                    Else
                        Me.cbClase.SelectedIndex = -1
                        Me.cbClase.DataSource = Nothing
                        Me.cbFamilia.SelectedIndex = -1
                        Me.cbFamilia.DataSource = Nothing
                    End If
                Case "02"
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        Clase = Datos.LLenar_Combo_Solo("Select * From Lista_Clases Where Codigo_Catalogo='02' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString & "'", Me.cbClase, "Clase")
                        Me.cbFamilia.SelectedIndex = -1
                        Me.cbFamilia.DataSource = Nothing
                    Else
                        Me.cbClase.SelectedIndex = -1
                        Me.cbClase.DataSource = Nothing
                        Me.cbFamilia.SelectedIndex = -1
                        Me.cbFamilia.DataSource = Nothing
                    End If
            End Select
        End If
    End Sub
    Private Sub cbClase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbClase.SelectedIndexChanged
        If Me.cbClase.Items.Count > 0 Then
            Me.cbFamilia.DataSource = Nothing
            Select Case Tipo_Catalogo
                Case "01"
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        If Me.cbClase.Text.Trim.Length > 0 Then
                            Familia = Datos.LLenar_Combo_Solo("Select * From Lista_Familias Where Codigo_Catalogo='01' And Codigo_Clase='" & Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString & "' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString & "'", Me.cbFamilia, "Familia")
                        Else
                            Me.cbFamilia.SelectedIndex = -1
                            Me.cbFamilia.DataSource = Nothing
                        End If
                    Else
                        Me.cbFamilia.SelectedIndex = -1
                        Me.cbFamilia.DataSource = Nothing
                    End If
                Case "02"
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        If Me.cbClase.Text.Trim.Length > 0 Then
                            Familia = Datos.LLenar_Combo_Solo("Select * From Lista_Familias Where Codigo_Catalogo='02' And Codigo_Clase='" & Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString & "' And Codigo_Grupo='" & Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString & "'", Me.cbFamilia, "Familia")
                        Else
                            Me.cbFamilia.SelectedIndex = -1
                            Me.cbFamilia.DataSource = Nothing
                        End If
                    Else
                        Me.cbFamilia.SelectedIndex = -1
                        Me.cbFamilia.DataSource = Nothing
                    End If
            End Select
        End If
    End Sub
    Private Sub Botones(ByVal Estado As Boolean)
        Me.gbDatos.Enabled = Not Estado
        Me.btnNuevo.Enabled = Estado
        Me.btnGuardar.Enabled = Not Estado
        Me.btnCancelar.Enabled = Not Estado
        Me.btnBuscar.Enabled = Estado
        Me.btnSalir.Enabled = Estado
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call Limpiar()
        Call Botones(False)
        Me.chkActivo.Checked = True
        Me.chkIGV.Checked = True
        Me.cbGrupo.Enabled = True
        Me.cbClase.Enabled = True
        Me.cbFamilia.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.cbUnidadMedida.Enabled = True
        Me.cbTipoTransaccion.Enabled = True
        Me.cbGenerica.Enabled = True
        Me.cbSubGenerica.Enabled = True
        Me.cbSubGenericaDetalle.Enabled = True
        Me.cbEspecifica.Enabled = True
        Me.cbEspecificaDetalle.Enabled = True
        Me.btnBuscarClasificador.Enabled = True
    End Sub
    Private Sub Limpiar()
        Me.cbFamilia.DataSource = Nothing
        Me.cbFamilia.SelectedIndex = -1
        Me.cbClase.DataSource = Nothing
        Me.cbClase.SelectedIndex = -1
        Me.cbEspecificaDetalle.DataSource = Nothing
        Me.cbEspecificaDetalle.SelectedIndex = -1
        Me.cbEspecifica.DataSource = Nothing
        Me.cbEspecifica.SelectedIndex = -1
        Me.cbSubGenericaDetalle.DataSource = Nothing
        Me.cbSubGenericaDetalle.SelectedIndex = -1
        Me.cbSubGenerica.DataSource = Nothing
        Me.cbSubGenerica.SelectedIndex = -1
        Me.cbGenerica.DataSource = Nothing
        Me.cbGenerica.SelectedIndex = -1
        Me.cbUnidadMedida.SelectedIndex = -1
        Me.cbGrupo.SelectedIndex = -1
        Me.cbTipoTransaccion.SelectedIndex = -1
        Me.chkActivo.Checked = False
        Me.txtCodigo.Text = ""
        Me.txtDescripcion.Text = ""
        Me.lblClasificador.Text = ""
        Me.btnGuardar.Text = "&Guardar"
        Me.cbGrupo.Enabled = True
        Me.cbClase.Enabled = True
        Me.cbFamilia.Enabled = True
        Me.cbTipoTransaccion.Enabled = True
        Me.cbGenerica.Enabled = True
        Me.cbSubGenerica.Enabled = True
        Me.cbSubGenericaDetalle.Enabled = True
        Me.cbEspecifica.Enabled = True
        Me.cbEspecificaDetalle.Enabled = True
        Me.btnBuscarClasificador.Enabled = True
        Me.chkIGV.Checked = False
        Me.txtPrecioReferencial.Text = "1.00"
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Select Case Tipo_Catalogo
            Case "01"
                If Me.btnGuardar.Text = "&Guardar" Then
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        If Me.cbClase.Text.Trim.Length > 0 Then
                            If Me.cbFamilia.Text.Trim.Length > 0 Then
                                If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
                                    If Me.cbGenerica.Text.Trim.Length > 0 Then
                                        If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                                            If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                                                If Me.cbEspecifica.Text.Trim.Length > 0 Then
                                                    If Me.cbEspecificaDetalle.Text.Trim.Length > 0 Then
                                                        If Me.txtDescripcion.Text.Trim.Length > 0 Then
                                                            If Me.cbUnidadMedida.Text.Trim.Length > 0 Then
                                                                If Me.lblClasificador.Text.Trim <> "0.0.0.0.0.0" Then
                                                                    If Datos.Verificar_Duplicidad_Item("01", Me.txtDescripcion.Text.Trim, Unidad.Rows(Me.cbUnidadMedida.SelectedIndex).Item("Codigo_Unidad_Medida").ToString, Me.lblClasificador.Text.Trim) = True Then
                                                                        Dim Numero As String = Datos.Generar_Numero_Item(Tipo_Catalogo, Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString, Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString, Familia.Rows(Me.cbFamilia.SelectedIndex).Item("Codigo_Familia").ToString)
                                                                        Datos.Nuevo_Item(Tipo_Catalogo, Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString, Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString, Familia.Rows(Me.cbFamilia.SelectedIndex).Item("Codigo_Familia").ToString, Numero, Me.txtDescripcion.Text.Trim, Unidad.Rows(Me.cbUnidadMedida.SelectedIndex).Item("Codigo_Unidad_Medida").ToString, Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString, Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString, SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString, SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString, Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica").ToString, Especifica_Detalle.Rows(Me.cbEspecificaDetalle.SelectedIndex).Item("Especifica_Detalle").ToString, Me.chkActivo.Checked, Me.chkIGV.Checked, CDbl(Me.txtPrecioReferencial.Text), My.Settings.Año_Ejecucion)
                                                                        MessageBox.Show("Se ha Generado un Nuevo Item:" & vbNewLine & "- Codigo: " & Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString & "." & Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString & "." & Familia.Rows(Me.cbFamilia.SelectedIndex).Item("Codigo_Familia").ToString & "." & Numero & vbNewLine & "- Descripcion: " & Me.txtDescripcion.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                        Call Me.Limpiar()
                                                                        Call Me.Botones(True)
                                                                    Else
                                                                        MessageBox.Show("Se ha Detectado una Duplicidad en el Item ingresado, favor de revisar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                        Me.txtDescripcion.Focus()
                                                                    End If

                                                                Else
                                                                    MessageBox.Show("El Item no puede estar Relacionado con un Clasificador Generico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                    Me.btnBuscarClasificador.Focus()
                                                                End If
                                                            Else
                                                                MessageBox.Show("Debes Seleccionar la Unidad de Medida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                Me.cbUnidadMedida.Focus()
                                                            End If
                                                        Else
                                                            MessageBox.Show("Ingresar la Descripción del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                            Me.txtDescripcion.Text = ""
                                                        End If
                                                    Else
                                                        MessageBox.Show("Debes seleccionar la Específica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                        Me.cbEspecificaDetalle.Focus()
                                                    End If
                                                Else
                                                    MessageBox.Show("Debes seleccionar la Específica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                    Me.cbEspecifica.Focus()
                                                End If
                                            Else
                                                MessageBox.Show("Debes seleccionar la SubGenerica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.cbSubGenericaDetalle.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes seleccionar la SubGenerica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                            Me.cbSubGenerica.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes seleccionar la Generica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        Me.cbGenerica.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes seleccionar el Tpo de Transacción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.cbTipoTransaccion.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar la Familia del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.cbFamilia.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar la Clase del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.cbClase.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar el Grupo del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.cbFamilia.Focus()
                    End If
                Else
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        If Me.cbClase.Text.Trim.Length > 0 Then
                            If Me.cbFamilia.Text.Trim.Length > 0 Then
                                If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
                                    If Me.cbGenerica.Text.Trim.Length > 0 Then
                                        If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                                            If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                                                If Me.cbEspecifica.Text.Trim.Length > 0 Then
                                                    If Me.cbEspecificaDetalle.Text.Trim.Length > 0 Then
                                                        If Me.txtDescripcion.Text.Trim.Length > 0 Then
                                                            If Me.cbUnidadMedida.Text.Trim.Length > 0 Then
                                                                If Me.lblClasificador.Text.Trim <> "0.0.0.0.0.0" Then
                                                                    Datos.Modificar_Item(Tipo_Catalogo, Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Me.txtDescripcion.Text.Trim, Unidad.Rows(Me.cbUnidadMedida.SelectedIndex).Item("Codigo_Unidad_Medida").ToString, Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString, Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString, SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString, SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString, Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica").ToString, Especifica_Detalle.Rows(Me.cbEspecificaDetalle.SelectedIndex).Item("Especifica_Detalle").ToString, Me.chkActivo.Checked, Me.chkIGV.Checked, CDbl(Me.txtPrecioReferencial.Text), My.Settings.Año_Ejecucion)
                                                                    Call Me.Limpiar()
                                                                    Call Me.Botones(True)
                                                                Else
                                                                    MessageBox.Show("El Item no puede estar Relacionado con un Clasificador Generico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                    Me.btnBuscarClasificador.Focus()
                                                                End If
                                                            Else
                                                                MessageBox.Show("Debes Seleccionar la Unidad de Medida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                Me.cbUnidadMedida.Focus()
                                                            End If
                                                        Else
                                                            MessageBox.Show("Ingresar la Descripción del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                            Me.txtDescripcion.Text = ""
                                                        End If
                                                    Else
                                                        MessageBox.Show("Debes seleccionar la Específica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                        Me.cbEspecificaDetalle.Focus()
                                                    End If
                                                Else
                                                    MessageBox.Show("Debes seleccionar la Específica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                    Me.cbEspecifica.Focus()
                                                End If
                                            Else
                                                MessageBox.Show("Debes seleccionar la SubGenerica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.cbSubGenericaDetalle.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes seleccionar la SubGenerica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                            Me.cbSubGenerica.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes seleccionar la Generica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        Me.cbGenerica.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes seleccionar el Tpo de Transacción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.cbTipoTransaccion.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar la Familia del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.cbFamilia.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar la Clase del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.cbClase.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar el Grupo del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.cbFamilia.Focus()
                    End If
                End If
            Case "02"
                If Me.btnGuardar.Text = "&Guardar" Then
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        If Me.cbClase.Text.Trim.Length > 0 Then
                            If Me.cbFamilia.Text.Trim.Length > 0 Then
                                If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
                                    If Me.cbGenerica.Text.Trim.Length > 0 Then
                                        If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                                            If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                                                If Me.cbEspecifica.Text.Trim.Length > 0 Then
                                                    If Me.cbEspecificaDetalle.Text.Trim.Length > 0 Then
                                                        If Me.txtDescripcion.Text.Trim.Length > 0 Then
                                                            If Me.cbUnidadMedida.Text.Trim.Length > 0 Then
                                                                If Me.lblClasificador.Text.Trim <> "0.0.0.0.0.0" Then
                                                                    If Datos.Verificar_Duplicidad_Item("02", Me.txtDescripcion.Text.Trim, Unidad.Rows(Me.cbUnidadMedida.SelectedIndex).Item("Codigo_Unidad_Medida").ToString, Me.lblClasificador.Text.Trim) = True Then
                                                                        Dim Numero As String = Datos.Generar_Numero_Item(Tipo_Catalogo, Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString, Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString, Familia.Rows(Me.cbFamilia.SelectedIndex).Item("Codigo_Familia").ToString)
                                                                        Datos.Nuevo_Item(Tipo_Catalogo, Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString, Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString, Familia.Rows(Me.cbFamilia.SelectedIndex).Item("Codigo_Familia").ToString, Numero, Me.txtDescripcion.Text.Trim, Unidad.Rows(Me.cbUnidadMedida.SelectedIndex).Item("Codigo_Unidad_Medida").ToString, Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString, Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString, SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString, SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString, Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica").ToString, Especifica_Detalle.Rows(Me.cbEspecificaDetalle.SelectedIndex).Item("Especifica_Detalle").ToString, Me.chkActivo.Checked, Me.chkIGV.Checked, 0.00, My.Settings.Año_Ejecucion)
                                                                        MessageBox.Show("Se ha Generado un Nuevo Item:" & vbNewLine & "- Codigo: " & Grupo.Rows(Me.cbGrupo.SelectedIndex).Item("Codigo_Grupo").ToString & "." & Clase.Rows(Me.cbClase.SelectedIndex).Item("Codigo_Clase").ToString & "." & Familia.Rows(Me.cbFamilia.SelectedIndex).Item("Codigo_Familia").ToString & "." & Numero & vbNewLine & "- Descripcion: " & Me.txtDescripcion.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                        Call Me.Limpiar()
                                                                        Call Me.Botones(True)
                                                                    Else
                                                                        MessageBox.Show("Se ha Detectado una Duplicidad en el Item ingresado, favor de revisar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                        Me.txtDescripcion.Focus()
                                                                    End If

                                                                Else
                                                                    MessageBox.Show("El Item no puede estar Relacionado con un Clasificador Generico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                    Me.btnBuscarClasificador.Focus()
                                                                End If
                                                            Else
                                                                MessageBox.Show("Debes Seleccionar la Unidad de Medida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                Me.cbUnidadMedida.Focus()
                                                            End If
                                                        Else
                                                            MessageBox.Show("Ingresar la Descripción del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                            Me.txtDescripcion.Text = ""
                                                        End If
                                                    Else
                                                        MessageBox.Show("Debes seleccionar la Específica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                        Me.cbEspecificaDetalle.Focus()
                                                    End If
                                                Else
                                                    MessageBox.Show("Debes seleccionar la Específica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                    Me.cbEspecifica.Focus()
                                                End If
                                            Else
                                                MessageBox.Show("Debes seleccionar la SubGenerica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.cbSubGenericaDetalle.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes seleccionar la SubGenerica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                            Me.cbSubGenerica.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes seleccionar la Generica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        Me.cbGenerica.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes seleccionar el Tpo de Transacción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.cbTipoTransaccion.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar la Familia del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.cbFamilia.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar la Clase del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.cbClase.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar el Grupo del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.cbFamilia.Focus()
                    End If
                Else
                    If Me.cbGrupo.Text.Trim.Length > 0 Then
                        If Me.cbClase.Text.Trim.Length > 0 Then
                            If Me.cbFamilia.Text.Trim.Length > 0 Then
                                If Me.cbTipoTransaccion.Text.Trim.Length > 0 Then
                                    If Me.cbGenerica.Text.Trim.Length > 0 Then
                                        If Me.cbSubGenerica.Text.Trim.Length > 0 Then
                                            If Me.cbSubGenericaDetalle.Text.Trim.Length > 0 Then
                                                If Me.cbEspecifica.Text.Trim.Length > 0 Then
                                                    If Me.cbEspecificaDetalle.Text.Trim.Length > 0 Then
                                                        If Me.txtDescripcion.Text.Trim.Length > 0 Then
                                                            If Me.cbUnidadMedida.Text.Trim.Length > 0 Then
                                                                If Me.lblClasificador.Text.Trim <> "0.0.0.0.0.0" Then
                                                                    Datos.Modificar_Item(Tipo_Catalogo, Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Me.txtDescripcion.Text.Trim, Unidad.Rows(Me.cbUnidadMedida.SelectedIndex).Item("Codigo_Unidad_Medida").ToString, Tipo_Transaccion.Rows(Me.cbTipoTransaccion.SelectedIndex).Item("Tipo_Transaccion").ToString, Generica.Rows(Me.cbGenerica.SelectedIndex).Item("Generica").ToString, SubGenerica.Rows(Me.cbSubGenerica.SelectedIndex).Item("Sub_Generica").ToString, SubGenerica_Detalle.Rows(Me.cbSubGenericaDetalle.SelectedIndex).Item("Sub_Generica_Detalle").ToString, Especifica.Rows(Me.cbEspecifica.SelectedIndex).Item("Especifica").ToString, Especifica_Detalle.Rows(Me.cbEspecificaDetalle.SelectedIndex).Item("Especifica_Detalle").ToString, Me.chkActivo.Checked, Me.chkIGV.Checked, 1.00, My.Settings.Año_Ejecucion)
                                                                    Call Me.Limpiar()
                                                                    Call Me.Botones(True)
                                                                Else
                                                                    MessageBox.Show("El Item no puede estar Relacionado con un Clasificador Generico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                    Me.btnBuscarClasificador.Focus()
                                                                End If
                                                            Else
                                                                MessageBox.Show("Debes Seleccionar la Unidad de Medida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                                Me.cbUnidadMedida.Focus()
                                                            End If
                                                        Else
                                                            MessageBox.Show("Ingresar la Descripción del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                                            Me.txtDescripcion.Text = ""
                                                        End If
                                                    Else
                                                        MessageBox.Show("Debes seleccionar la Específica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                        Me.cbEspecificaDetalle.Focus()
                                                    End If
                                                Else
                                                    MessageBox.Show("Debes seleccionar la Específica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                    Me.cbEspecifica.Focus()
                                                End If
                                            Else
                                                MessageBox.Show("Debes seleccionar la SubGenerica Detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                Me.cbSubGenericaDetalle.Focus()
                                            End If
                                        Else
                                            MessageBox.Show("Debes seleccionar la SubGenerica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                            Me.cbSubGenerica.Focus()
                                        End If
                                    Else
                                        MessageBox.Show("Debes seleccionar la Generica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        Me.cbGenerica.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debes seleccionar el Tpo de Transacción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.cbTipoTransaccion.Focus()
                                End If
                            Else
                                MessageBox.Show("Debes seleccionar la Familia del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.cbFamilia.Focus()
                            End If
                        Else
                            MessageBox.Show("Debes seleccionar la Clase del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.cbClase.Focus()
                        End If
                    Else
                        MessageBox.Show("Debes seleccionar el Grupo del Item", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.cbFamilia.Focus()
                    End If
                End If
        End Select
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call Me.Limpiar()
        Call Me.Botones(True)
    End Sub
    Private Sub btnBuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGrupo.Click
        Dim Formulario As New frmBuscar_Grupos
        Select Case Tipo_Catalogo
            Case "01"
                Formulario.Operacion = 1
            Case "02"
                Formulario.Operacion = 2
        End Select
        Formulario.ShowDialog()
        If Variable_Descripcion_Grupo.Trim.Length > 0 Then Me.cbGrupo.Text = Variable_Descripcion_Grupo
    End Sub
    Private Sub btnBuscarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarClase.Click
        Dim Formulario As New frmBuscar_Clases
        If Me.cbGrupo.Text.Trim.Length > 0 Then
            Select Case Tipo_Catalogo
                Case "01"
                    Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex + 1
                    Formulario.Operacion = 1
                Case "02"
                    Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex + 1
                    Formulario.Operacion = 2
            End Select
            Formulario.ShowDialog()
            If Variable_Descripcion_Grupo.Trim.Length > 0 Then Me.cbGrupo.Text = Variable_Descripcion_Grupo
            If Variable_Descripcion_Clase.Trim.Length > 0 Then Me.cbClase.Text = Variable_Descripcion_Clase
        Else
            MessageBox.Show("Debes elegir un Grupo para Filrar las Clases", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.cbGrupo.Focus()
        End If

    End Sub
    Private Sub btnBuscarFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFamilia.Click
        Dim Formulario As New frmBuscar_Familia
        If Me.cbGrupo.Text.Trim.Length > 0 Then
            If Me.cbClase.Text.Trim.Length > 0 Then
                Select Case Tipo_Catalogo
                    Case "01"
                        Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex + 1
                        Formulario.Parametro_Clase = Me.cbClase.SelectedIndex + 1
                        Formulario.Operacion = 1
                    Case "02"
                        Formulario.Parametro_Grupo = Me.cbGrupo.SelectedIndex + 1
                        Formulario.Parametro_Clase = Me.cbClase.SelectedIndex + 1
                        Formulario.Operacion = 2
                End Select
                Formulario.ShowDialog()
                If Variable_Descripcion_Grupo.Trim.Length > 0 Then Me.cbGrupo.Text = Variable_Descripcion_Grupo
                If Variable_Descripcion_Clase.Trim.Length > 0 Then Me.cbClase.Text = Variable_Descripcion_Clase
                If Variable_Descripcion_Familia.Trim.Length > 0 Then Me.cbFamilia.Text = Variable_Descripcion_Familia
            Else
                MessageBox.Show("Debes elegir una Clase para Filrar las Familias", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.cbGrupo.Focus()
            End If
        Else
            MessageBox.Show("Debes elegir un Grupo para Filrar las Clases y Familias", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.cbFamilia.Focus()
        End If

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Select Case Tipo_Catalogo
            Case "01"
                Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
                Formulario.Operacion = 2
                Formulario.Tipo_Catalogo = "01"
                Formulario.ShowDialog()
                If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
                    Datos.Mostrar_Data_Item_Catalogo_Modificacion(1, Tipo_Catalogo, Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Me.cbGrupo, Me.cbClase, Me.cbFamilia, Me.txtCodigo, Me.txtDescripcion, Me.cbUnidadMedida, Me.cbTipoTransaccion, Me.cbGenerica, Me.cbSubGenerica, Me.cbSubGenericaDetalle, Me.cbEspecifica, Me.cbEspecificaDetalle, Me.chkActivo, Me.chkIGV, Me.txtPrecioReferencial, My.Settings.Año_Ejecucion)
                    Call Botones(False)
                    Me.btnGuardar.Text = "&Modificar"
                    Me.cbGrupo.Enabled = False
                    Me.cbClase.Enabled = False
                    Me.cbFamilia.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    Me.cbUnidadMedida.Enabled = False

                    If (Datos.Ejecutar_Select("select Año_Ejecucion from Detalle_Orden_Compra where Codigo_Catalogo+'.'+Codigo_Grupo+'.'+Codigo_Clase+'.'+Codigo_Familia+'.'+Codigo_Item ='"+ Tipo_Catalogo +"."+ Variable_Codigo_Grupo + "." + Variable_Codigo_Clase + "."+ Variable_Codigo_Familia + "." + Variable_Codigo_Item +"'").Rows.Count > 0) Then
                        MessageBox.Show("El item ya fue usado en una Orden, no se puede modificar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.cbTipoTransaccion.Enabled = False
                        Me.cbGenerica.Enabled = False
                        Me.cbSubGenerica.Enabled = False
                        Me.cbSubGenericaDetalle.Enabled = False
                        Me.cbEspecifica.Enabled = False
                        Me.cbEspecificaDetalle.Enabled = False
                        Me.btnBuscarClasificador.Enabled = False
                    else
                        Me.txtDescripcion.Enabled = True
                    End If
                Else
                    Call Limpiar()
                    Call Botones(True)
                End If
            Case "02"
                Dim Formulario As New frmCatalogo_Bienes_Servicios_Obras
                Formulario.Operacion = 2
                Formulario.Tipo_Catalogo = "02"
                Formulario.ShowDialog()
                If Variable_Codigo_Grupo.Trim.Length > 0 And Variable_Codigo_Clase.Trim.Length > 0 And Variable_Codigo_Familia.Trim.Length > 0 And Variable_Codigo_Item.Trim.Length > 0 Then
                    Datos.Mostrar_Data_Item_Catalogo_Modificacion(2, Tipo_Catalogo, Variable_Codigo_Grupo, Variable_Codigo_Clase, Variable_Codigo_Familia, Variable_Codigo_Item, Me.cbGrupo, Me.cbClase, Me.cbFamilia, Me.txtCodigo, Me.txtDescripcion, Me.cbUnidadMedida, Me.cbTipoTransaccion, Me.cbGenerica, Me.cbSubGenerica, Me.cbSubGenericaDetalle, Me.cbEspecifica, Me.cbEspecificaDetalle, Me.chkActivo, Me.chkIGV, Me.txtPrecioReferencial, My.Settings.Año_Ejecucion)
                    Call Botones(False)
                    Me.btnGuardar.Text = "&Modificar"
                    Me.cbGrupo.Enabled = False
                    Me.cbClase.Enabled = False
                    Me.cbFamilia.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    Me.cbUnidadMedida.Enabled = False

                    If (Datos.Ejecutar_Select("select Año_Ejecucion from Detalle_Orden_Compra where Codigo_Catalogo+'.'+Codigo_Grupo+'.'+Codigo_Clase+'.'+Codigo_Familia+'.'+Codigo_Item ='"+ Tipo_Catalogo +"."+ Variable_Codigo_Grupo + "." + Variable_Codigo_Clase + "."+ Variable_Codigo_Familia + "." + Variable_Codigo_Item +"'").Rows.Count > 0) Then
                        MessageBox.Show("El item ya fue usado en una Orden, no se puede modificar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.cbTipoTransaccion.Enabled = False
                        Me.cbGenerica.Enabled = False
                        Me.cbSubGenerica.Enabled = False
                        Me.cbSubGenericaDetalle.Enabled = False
                        Me.cbEspecifica.Enabled = False
                        Me.cbEspecificaDetalle.Enabled = False
                        Me.btnBuscarClasificador.Enabled = False
                    else
                        Me.txtDescripcion.Enabled = True
                    End If
                Else
                    Call Limpiar()
                    Call Botones(True)
                End If
        End Select
    End Sub

    Private Sub btnEliminarCN_Click(sender As Object, e As EventArgs) Handles btnEliminarCN.Click

        If txtCodigo.Text.Length > 0
            Dim Message As String
            Dim result As DialogResult
            Message = "Esta seguro que desea eliminar el Item del catalogo de CN?"
            Dim buttons As MessageBoxButtons
            buttons = MessageBoxButtons.YesNo

            result = MessageBox.Show(Message, Me.Text, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If result = System.Windows.Forms.DialogResult.Yes Then
                Dim Cadena As String = "delete from Catalogo_CN where codigo = '"+txtCodigo.Text+"'"

                if (Datos.Ejecutar_Select("select * from Detalle_Cuadro_Necesidades where Codigo_Grupo+'.'+Codigo_Clase+'.'+Codigo_Familia+'.'+Codigo_Item='"+ txtCodigo.Text +"'").Rows.Count>0)
                    MessageBox.Show("No se puede eliminar el Item del catalogo porque esta siendo usado por una U.O.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                Dim Cn As New OleDb.OleDbConnection(My.Settings.Conexion)
                Cn.Open()
                Dim Cm As New OleDb.OleDbCommand
                Cm.CommandTimeout = 0
                Cm.Connection = Cn
                Cm.CommandType = CommandType.Text
                Cm.CommandText = Cadena
                Cm.ExecuteNonQuery()
                Cn.Close
                MessageBox.Show("Se elimino del calálogo de CN correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub
End Class