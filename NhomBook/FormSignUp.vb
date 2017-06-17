Public Class FormSignUp

    Dim kn As New KetNoi
    Dim _soluong As Integer
    Dim kt As New Kiemtra
    Private sql As String

    Public Function Add(ByVal ssql As String, ByVal tk As classTAIKHOAN) As Integer
        _soluong = 4

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@uname"
        Value(0) = tk.Uname

        Name(1) = "@mk"
        Value(1) = tk.Mk
        Name(2) = "@email"
        Value(2) = tk.Email
        Name(3) = "@fname"
        Value(3) = tk.Fname
        Name(4) = "@lname"
        Value(4) = tk.Lname

        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtFname.Text) Then
            lbThongBao.Visible = True
            lbThongBao.Text = "Hãy điền đầy đủ các mục!"
        End If
        If String.IsNullOrEmpty(txtLname.Text) Then
            lbThongBao.Visible = True
            lbThongBao.Text = "Hãy điền đầy đủ các mục!"
        End If
        If String.IsNullOrEmpty(txtEmail.Text) Then
            lbThongBao.Visible = True
            lbThongBao.Text = "Hãy điền đầy đủ các mục!"
        End If

        If String.IsNullOrEmpty(txtPassword.Text) Then
            lbThongBao.Visible = True
            lbThongBao.Text = "Hãy điền đầy đủ các mục!"
        End If
        If String.IsNullOrEmpty(txtUser.Text) Then
            lbThongBao.Visible = True
            lbThongBao.Text = "Hãy điền đầy đủ các mục!"
        End If

    End Sub
    Public Function ktrUser(ByVal user As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkUsername"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@uname"
        Value(0) = user
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        Try
            Dim _username As String
            _username = txtUser.Text

            If ktrUser(_username).Rows.Count > 0 Then
                lbThongBao.Text = "Username này đã tồn tại!"
                lbThongBao.Visible = True
                txtUser.Text = ""
                txtUser.Focus()
            Else
                If kt.CheckMail(txtEmail.Text) = False Then
                    lbThongBao.Text = "Email không hợp lệ!"
                    lbThongBao.Visible = True
                    txtEmail.Text = ""
                    txtEmail.Focus()
                Else
                    lbThongBao.Visible = False
                    If (String.IsNullOrEmpty(txtFname.Text)) OrElse (String.IsNullOrEmpty(txtLname.Text)) OrElse (String.IsNullOrEmpty(txtEmail.Text)) OrElse (String.IsNullOrEmpty(txtUser.Text)) OrElse (String.IsNullOrEmpty(txtPassword.Text)) Then
                        KtraNULL()
                    Else
                        lbThongBao.Visible = False
                        Dim tk As New classTAIKHOAN
                        tk.Uname = txtUser.Text
                        tk.Mk = txtPassword.Text
                        tk.Fname = txtFname.Text
                        tk.Lname = txtLname.Text
                        tk.Email = txtEmail.Text
                        sql = "insertTAIKHOAN"
                        Add(sql, tk)

                        MessageBox.Show("Tạo mới tài khoản thành công!")
                        tran.HideSync(Me)
                        'Me.Visible = False

                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub checkboxShowPass_OnChange(sender As Object, e As EventArgs) Handles checkboxShowPass.OnChange
        If checkboxShowPass.Checked = True Then
            txtPassword.isPassword = False
        Else
            txtPassword.isPassword = True

        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()

    End Sub
End Class
