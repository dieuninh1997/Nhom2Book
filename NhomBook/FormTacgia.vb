Public Class FormTacgia

    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String
    Private ktSdt As New Kiemtra


    Private Sub ShowData()
        dgTacgia.DataSource = kn.getData("loadTACGIA")
    End Sub
    Private Sub ClearText()
        txtMatacgia.Text = ""
        txtTentacgia.Text = ""
        txtSdtTacgia.Text = ""


    End Sub

    Private Sub NameHeaderDgv()
        dgTacgia.Columns("matg").HeaderText = "Mã tác giả"
        dgTacgia.Columns("tentg").HeaderText = "Tên tác giả"
        dgTacgia.Columns("sdt").HeaderText = "Số điện thoại"

    End Sub

    Private Sub FormTacgia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTimKiemTg.Text = ""
        txtTimKiemTg.HintText = "Tìm kiếm theo tên "
        lbMaTacgia.Visible = False
        lbTentacgia.Visible = False
        lbSdt.Visible = False

        ShowData()
        NameHeaderDgv()



    End Sub
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDTacgia"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub dgTacgia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTacgia.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgTacgia.Rows(e.RowIndex)
            txtMatacgia.Text = row.Cells("matg").Value.ToString
            txtTentacgia.Text = row.Cells("tentg").Value.ToString
            txtSdtTacgia.Text = row.Cells("sdt").Value.ToString
            txtMatacgia.Enabled = False

        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _matg As String
            _matg = txtMatacgia.Text

            If ktrID(_matg).Rows.Count > 0 Then
                lbMaTacgia.Text = "Trùng mã tác giả!"
                lbMaTacgia.Visible = True
                lbMaTacgia.ForeColor = Color.Red
                txtMatacgia.Text = ""
                txtMatacgia.Focus()
            Else
                If ktSdt.KiemtraSdt(txtSdtTacgia.Text) = False Then
                    lbSdt.Text = "Số điện thoại không hợp lệ!"
                    lbSdt.Visible = True
                    lbSdt.ForeColor = Color.Red
                    txtSdtTacgia.Text = ""
                    txtSdtTacgia.Focus()



                Else
                    lbMaTacgia.Visible = False
                    If (String.IsNullOrEmpty(txtMatacgia.Text)) OrElse (String.IsNullOrEmpty(txtTentacgia.Text)) OrElse (String.IsNullOrEmpty(txtSdtTacgia.Text)) Then
                        KtraNULL()
                    Else
                        lbMaTacgia.Visible = False
                        lbTentacgia.Visible = False
                        lbSdt.Visible = False
                        Dim Tacgia As New classTACGIA
                        Tacgia.Matg = txtMatacgia.Text
                        Tacgia.Tentg = txtTentacgia.Text
                        Tacgia.Sdt = txtSdtTacgia.Text
                        sql = "insertTACGIA"
                        Add(sql, Tacgia)
                        ShowData()
                        MessageBox.Show("Thêm thành công!")
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim Tacgia As New classTACGIA

            Tacgia.Matg = txtMatacgia.Text
            sql = "removeTACGIA"
            Remove(sql, Tacgia)
            ShowData()
            ClearText()
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMatacgia.Text) Then
            lbMaTacgia.Visible = True
            lbMaTacgia.ForeColor = Color.Red
            lbMaTacgia.Text = "Mã tác giả không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTentacgia.Text) Then
            lbTentacgia.Visible = True
            lbTentacgia.ForeColor = Color.Red
            lbTentacgia.Text = "Tên tác giả không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSdtTacgia.Text) Then
            lbSdt.Visible = True
            lbSdt.ForeColor = Color.Red
            lbSdt.Text = "Số điện thoại không được rỗng!"

        End If
    End Sub
    Public Function Add(ByVal ssql As String, ByVal Tacgia As classTACGIA) As Integer
        _soluong = 2

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@matg"
        Value(0) = Tacgia.Matg
        Name(1) = "@tentg"
        Value(1) = Tacgia.Tentg
        Name(2) = "@sdt"
        Value(2) = Tacgia.Sdt


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function

    Public Function Remove(ByVal ssql As String, ByVal Tacgia As classTACGIA) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@matg"
        Value(0) = Tacgia.Matg
        Return kn.Add(ssql, Name, Value, _soluong)

    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtTentacgia.Text)) OrElse (String.IsNullOrEmpty(txtSdtTacgia.Text)) Then
            KtraNULL()
        Else
            lbMaTacgia.Visible = False
            lbTentacgia.Visible = False
            lbSdt.Visible = False
            Dim Tacgia As New classTACGIA
            If ktSdt.KiemtraSdt(txtSdtTacgia.Text) = False Then
                lbSdt.Text = "Số điện thoại không hợp lệ!"
                lbSdt.Visible = True
                lbSdt.ForeColor = Color.Red
                txtSdtTacgia.Text = ""
                txtSdtTacgia.Focus()
            Else
                Tacgia.Matg = txtMatacgia.Text
                Tacgia.Tentg = txtTentacgia.Text
                Tacgia.Sdt = txtSdtTacgia.Text

                sql = "updateTACGIA"
                Add(sql, Tacgia)
                ShowData()
                MessageBox.Show("Cập nhật thành công!")
            End If
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMatacgia.Enabled = True

    End Sub

    Private Sub txtTimKiemTg_OnValueChanged(sender As Object, e As EventArgs) Handles txtTimKiemTg.OnValueChanged
        If String.IsNullOrEmpty(txtTimKiemTg.Text) Then
            ShowData()
        Else


        End If
    End Sub
End Class
