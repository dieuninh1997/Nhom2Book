Public Class classCthd
    Private _mahd, _mas, _dvt As String
    Private _soluong, _giaban, _giamgia, _thanhtien As Integer
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

    Public Property Giaban As Integer
        Get
            Return _giaban
        End Get
        Set(value As Integer)
            _giaban = value
        End Set
    End Property

    Public Property Giamgia As Integer
        Get
            Return _giamgia
        End Get
        Set(value As Integer)
            _giamgia = value
        End Set
    End Property

    Public Property Mahd As String
        Get
            Return _mahd
        End Get
        Set(value As String)
            _mahd = value
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
