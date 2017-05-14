Imports System.Text.RegularExpressions
Public Class Kiemtra

    Public Function KiemtraSdt(ByVal sdt As String) As Boolean
        '  Dim pattern As String
        ' pattern = "^-*[0-9,\.?\-?\(?\)?\ ]+$"
        Dim rgx As New Regex("^-*[0-9,\.?\-?\(?\)?\ ]+$")
        If sdt.Length < 9 Or sdt.Length > 11 Then
            Return False
        Else Return rgx.IsMatch(sdt)
        End If

    End Function
End Class
