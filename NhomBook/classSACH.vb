Public Class classSACH
    Private _mas, _tens, _tg, _tl, _nxb As String
    Private _dg, _soluong As Integer

    Public Property Mas As String
        Get
            Return _mas
        End Get
        Set(value As String)
            _mas = value
        End Set
    End Property

    Public Property Tens As String
        Get
            Return _tens
        End Get
        Set(value As String)
            _tens = value
        End Set
    End Property

    Public Property Tg As String
        Get
            Return _tg
        End Get
        Set(value As String)
            _tg = value
        End Set
    End Property

    Public Property Tl As String
        Get
            Return _tl
        End Get
        Set(value As String)
            _tl = value
        End Set
    End Property

    Public Property Nxb As String
        Get
            Return _nxb
        End Get
        Set(value As String)
            _nxb = value
        End Set
    End Property

    Public Property Dg As Integer
        Get
            Return _dg
        End Get
        Set(value As Integer)
            _dg = value
        End Set
    End Property

    Public Property Soluong As Integer
        Get
            Return _soluong
        End Get
        Set(value As Integer)
            _soluong = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
