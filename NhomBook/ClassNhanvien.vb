Public Class ClassNhanvien

    Private _manv, _hotennhanvien, _gioitinh, _diachi, _sdt As String
    Private _ngaysinh As Date

    Public Sub New()

    End Sub
    Public Property Diachi As String
        Get
            Return _diachi
        End Get
        Set(value As String)
            _diachi = value
        End Set
    End Property

    Public Property Gioitinh As String
        Get
            Return _gioitinh
        End Get
        Set(value As String)
            _gioitinh = value
        End Set
    End Property

    Public Property Hotennhanvien As String
        Get
            Return _hotennhanvien
        End Get
        Set(value As String)
            _hotennhanvien = value
        End Set
    End Property

    Public Property Manv As String
        Get
            Return _manv
        End Get
        Set(value As String)
            _manv = value
        End Set
    End Property

    Public Property Ngaysinh As Date
        Get
            Return _ngaysinh
        End Get
        Set(value As Date)
            _ngaysinh = value
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
