'Imports System.Runtime.InteropServices
Public NotInheritable Class MePresentacion
    'Public Structure MARGINS

    '    Public Destra As Integer
    '    Public Sinistra As Integer
    '    Public Su As Integer
    '    Public Giu As Integer

    'End Structure

    'Declare Auto Function DwmIsCompositionEnabled Lib "dwmapi.dll" Alias "DwmIsCompositionEnabled" (ByRef pfEnabled As Boolean) As Integer
    'Declare Auto Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" Alias "DwmExtendFrameIntoClientArea" (ByVal hWnd As IntPtr, ByRef pMargin As MARGINS) As Integer

    'Dim pMargins As New MARGINS With {.Su = -1, .Sinistra = -1, .Destra = -1, .Giu = -1}
    Private Sub MePresentacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.Timer1.Start()
        'Dim en As Boolean = False
        'DwmIsCompositionEnabled(en)
        'If en Then
        '    DwmExtendFrameIntoClientArea(Me.Handle, pMargins)
        'End If
        'Me.TransparencyKey = Color.FromKnownColor(KnownColor.ActiveCaption)

    End Sub
    'code snippet #1
    'Private Sub MePresentacion_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim Rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
    '    Dim LinearBrush As Drawing2D.LinearGradientBrush = _
    '           New Drawing2D.LinearGradientBrush(Rect, Color.MidnightBlue, Color.RoyalBlue, _
    '           Drawing2D.LinearGradientMode.Vertical)
    '    Dim g As Graphics = e.Graphics
    '    g.FillRectangle(LinearBrush, 0, 0, Me.Width, Me.Height)
    'End Sub
    Private Sub Entrada()
        Dim Efecto As Double
        For Efecto = 0.0 To 1.1 Step 0.1
            Me.Opacity = Efecto
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
    Private Sub Salida()
        Dim Efecto As Double
        For Efecto = 1.1 To 0.0 Step -0.1
            Me.Opacity = Efecto
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
    Private Sub MePresentacion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.Entrada()
        System.Threading.Thread.Sleep(4000)
        Call Me.Salida()
    End Sub
End Class
