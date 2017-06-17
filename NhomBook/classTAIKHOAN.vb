Public Class classTAIKHOAN
    Private _uname, _mk, _email, _fname, _lname As String
    Public Sub New()

    End Sub
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Fname As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Public Property Lname As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Public Property Mk As String
        Get
            Return _mk
        End Get
        Set(value As String)
            _mk = value
        End Set
    End Property

    Public Property Uname As String
        Get
            Return _uname
        End Get
        Set(value As String)
            _uname = value
        End Set
    End Property
End Class
