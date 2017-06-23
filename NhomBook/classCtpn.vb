Public Class classCtpn

    Private _mapn, _mas, _dvt As String
    Private _soluong, _gianhap, _thanhtien As Integer
    Public Sub New()

    End Sub
    Public Property Dvt As String
        Get
            Return _dvt
        End Get
        Set(value As String)
            _dvt = value
        End Set
    End Property

    Public Property Gianhap As Integer
        Get
            Return _gianhap
        End Get
        Set(value As Integer)
            _gianhap = value
        End Set
    End Property

    Public Property Mapn As String
        Get
            Return _mapn
        End Get
        Set(value As String)
            _mapn = value
        End Set
    End Property

    Public Property Mas As String
        Get
            Return _mas
        End Get
        Set(value As String)
            _mas = value
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

    Public Property Thanhtien As Integer
        Get
            Return _thanhtien
        End Get
        Set(value As Integer)
            _thanhtien = value
        End Set
    End Property
End Class
