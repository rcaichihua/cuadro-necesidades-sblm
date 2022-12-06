Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReportes
    Private _NombreGerente As String
    Public Property NombreGerente() As String
        Get
            Return _NombreGerente
        End Get
        Set(ByVal value As String)
            _NombreGerente = value
        End Set
    End Property

    Private _DocGerente As String
    Public Property DocGerente() As String
        Get
            Return _DocGerente
        End Get
        Set(ByVal value As String)
            _DocGerente = value
        End Set
    End Property

    Private _AbreviaturaGenero As String
    Public Property AbreviaturaGenero() As String
        Get
            Return _AbreviaturaGenero
        End Get
        Set(ByVal value As String)
            _AbreviaturaGenero = value
        End Set
    End Property

    Private _DT As DataTable
    Public Property DT() As DataTable
        Get
            Return _DT
        End Get
        Set(ByVal value As DataTable)
            _DT = value
        End Set
    End Property

    Private _Mes As String
    Public Property Mes() As String
        Get
            Return _Mes
        End Get
        Set(ByVal value As String)
            _Mes = value
        End Set
    End Property
End Class