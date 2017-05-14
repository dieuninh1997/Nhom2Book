Public Class classTACGIA

    Private _matg, _tentg, _sdt As String

    Public Property Matg As String
        Get
            Return _matg
        End Get
        Set(value As String)
            _matg = value
        End Set
    End Property

    Public Property Sdt As String
        Get
            Return _sdt
        End Get
        Set(value As String)
            _sdt = value
        End Set
    End Property

    Public Property Tentg As String
        Get
            Return _tentg
        End Get
        Set(value As String)
            _tentg = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
