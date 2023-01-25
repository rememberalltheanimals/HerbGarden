'Author: Eunhae Hwang

Option Strict On
Option Explicit On

Public Class clsHerb

    'Shared Herb Garden Member information
    Private cintId As Integer
    Public Property Id() As Integer
        Get
            Return cintId
        End Get
        Set(value As Integer)
            cintId = value
        End Set
    End Property

    Private cstrLatin As String
    Public Property Latin() As String
        Get
            Return cstrLatin
        End Get
        Set(value As String)
            cstrLatin = value
        End Set
    End Property

    Private cstrMember As String
    Public Property Member() As String
        Get
            Return cstrMember
        End Get
        Set(value As String)
            cstrMember = value
        End Set
    End Property

    Private cstrYear As String
    Public Property Year() As String
        Get
            Return cstrYear
        End Get
        Set(value As String)
            cstrYear = value
        End Set
    End Property

    Private cintNumber As Integer
    Public Property Number() As Integer
        Get
            Return cintNumber
        End Get
        Set(value As Integer)
            cintNumber = value
        End Set
    End Property

    Private cstrFamily As String
    Public Property Family() As String
        Get
            Return cstrFamily
        End Get
        Set(value As String)
            cstrFamily = value
        End Set
    End Property

    Private cstrHabitat As String
    Public Property Habitat() As String
        Get
            Return cstrHabitat
        End Get
        Set(value As String)
            cstrHabitat = value
        End Set
    End Property

    Private cstrStatus As String
    Public Property Status() As String
        Get
            Return cstrStatus
        End Get
        Set(value As String)
            cstrStatus = value
        End Set
    End Property

    Private cstrParts As String
    Public Property Parts() As String
        Get
            Return cstrParts
        End Get
        Set(value As String)
            cstrParts = value
        End Set
    End Property

    Private cstrUses As String
    Public Property Uses() As String
        Get
            Return cstrUses
        End Get
        Set(value As String)
            cstrUses = value
        End Set
    End Property

    Private cdecSpacing As Decimal
    Public Property Spacing() As Decimal
        Get
            Return cdecSpacing
        End Get
        Set(value As Decimal)
            cdecSpacing = value
        End Set
    End Property

    Private cstrStartDate As String
    Public Property StartDate() As String
        Get
            Return cstrStartDate
        End Get
        Set(value As String)
            cstrStartDate = value
        End Set
    End Property

End Class
