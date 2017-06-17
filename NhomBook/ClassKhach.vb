Public Class ClassKhach
    Private _makh, _hotenkh, _diachi, _sdt As String

    Public Property Diachi As String
        Get
            Return _diachi
        End Get
        Set(value As String)
            _diachi = value
        End Set
    End Property

    Public Property Hotenkh As String
        Get
            Return _hotenkh
        End Get
        Set(value As String)
            _hotenkh = value
        End Set
    End Property

    Public Property Makh As String
        Get
            Return _makh
        End Get
        Set(value As String)
            _makh = value
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
End Class
