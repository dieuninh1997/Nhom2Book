Imports System.Data.SqlClient

Public Class Form2

    Dim flag As Boolean
    Dim kn As New KetNoi
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim connection As New SqlConnection("Data Source=DIEUNINH\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True")
        Dim queryString = "Select * from TAIKHOAN where  uname=@username and mk=@matkhau"
        Dim command As New SqlCommand(queryString, connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text
        command.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = txtPass.Text
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count <= 0 Then
            lbThongbaoLoi.Visible = True
            lbThongbaoLoi.Text = "Username or Password are invalid!"
            txtUser.Focus()

            '  MessageBox.Show("Username or Password are invalid!")
        Else
            lbThongbaoLoi.Visible = False
            MessageBox.Show("Login Successfully!")
            Me.Hide()
            Dim frm As New Form1()
            frm.Show()
        End If


    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormSignUp1.Visible = False
        lbThongbaoLoi.Visible = False
        txtPass.isPassword = True
        txtUser.Focus()
        txtPass.Text = ""

    End Sub

    Private Sub lbSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbSignUp.LinkClicked
        FormSignUp1.Visible = False
        FormSignUp1.BringToFront()
        tran1.ShowSync(FormSignUp1)
        FormSignUp1.Visible = True

    End Sub


    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Environment.Exit(0)

    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged
        txtPass.isPassword = True
    End Sub

    Private Sub checkbox_OnChange(sender As Object, e As EventArgs) Handles checkbox.OnChange

    End Sub
    Private Sub ShowData(ByVal user As String)


        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDTK"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = user
        txtPass.Text = kn.checkID(sql, Name, Value, _soluong).Columns("mk").ToString

    End Sub
    Private Sub txtUser_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser.OnValueChanged
        If checkbox.Checked = True Then

            ShowData(txtUser.Text)
        End If
    End Sub
End Class