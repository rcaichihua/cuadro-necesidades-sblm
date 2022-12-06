Public Class frmUnidad_Organica
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Datos As New Mantenimiento
    Dim Unidad_Organica As New DataTable
    Public Operacion As Integer = 0
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case Operacion
            Case 1



            Case 2




            Case 3




            Case 3
        End Select
    End Sub
    Private Sub frmUnidad_Organica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
        Select Case Operacion
            Case 1 'PIA Anual
                Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In(" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
                Me.cbUnidadOrganica.SelectedIndex = 0


            Case 2 'PIA Mensual
                Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In(" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
                Me.cbUnidadOrganica.SelectedIndex = 0


            Case 3 'Saldos
                Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In(" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
                Me.cbUnidadOrganica.SelectedIndex = 0

            Case 4 'Ejecucion
                Unidad_Organica = Datos.LLenar_Combo_Solo("Select * From Unidad_Organica Where Año_Ejecucion='" & My.Settings.Año_Ejecucion & "' And Codigo_Unidad_Organica In(" & Datos.Cadena_Unidades_Organicas_Por_Usuario(My.Settings.Año_Ejecucion, My.Settings.Usuario) & ")", Me.cbUnidadOrganica, "Nombre_Unidad_Organica")
                Me.cbUnidadOrganica.SelectedIndex = 0

        End Select
    End Sub
End Class