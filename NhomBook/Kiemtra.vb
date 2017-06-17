Imports System.Text.RegularExpressions
Public Class Kiemtra

    Public Function KiemtraSdt(ByVal sdt As String) As Boolean

        Dim rgx As New Regex("^-*[0-9,\.?\-?\(?\)?\ ]+$")
        If sdt.Length < 9 Or sdt.Length > 11 Then
            Return False
        Else Return rgx.IsMatch(sdt)
        End If

    End Function

    Public Function KiemtraNgaysinh(ByVal ngsinh As Date) As Boolean
        'trong do tuoi tu 18-70
        Dim tuoi As Integer = 0
        Dim kq As Boolean = False
        'ko quá hôm nay
        Dim nam As Integer
        nam = DateAndTime.Now.Year

        tuoi = DateAndTime.Now.Year - ngsinh.Year

        If (ngsinh.Year < nam) Then
            If tuoi > 17 And tuoi < 71 Then
                kq = True
            End If
        End If
        Return kq
    End Function

    Public Function KiemtraNgayNhapXuat(ByVal _date As Date) As Boolean
        'ko quá hôm nay
        Dim ngay, thang, nam As Integer
        Dim kq As Boolean = False

        ngay = DateAndTime.Now.Day
        thang = DateAndTime.Now.Month
        nam = DateAndTime.Now.Year
        If (_date.Year < nam) Then
            kq = True
        ElseIf (_date.Year = nam) Then
            If _date.Month < thang Then
                kq = True
            ElseIf _date.Month = thang Then

                If _date.Day <= ngay Then
                    kq = True
                End If
            End If
        End If
        Return kq
    End Function

    Public Function CheckMail(ByVal emailAddress As String) As Boolean
        If emailAddress.Length = 0 Then
            Return False
        End If
        If emailAddress.IndexOf("@") > -1 Then
            If (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@")) AndAlso emailAddress.Split(".").Length > 0 AndAlso emailAddress.Split(".")(1) <> "" Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
