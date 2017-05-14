﻿Public Class FormBook

    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String

    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDBook"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function Add(ByVal ssql As String, ByVal Sach As classSACH) As Integer
        _soluong = 6

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mas"
        Value(0) = Sach.Mas


        Name(1) = "@tens"
        Value(1) = Sach.Tens

        Name(2) = "@soluongton"
        Value(2) = Sach.Soluong


        Name(3) = "@dongia"
        Value(3) = Sach.Dg


        Name(4) = "@matg"
        Value(4) = Sach.Tg


        Name(5) = "@matl"
        Value(5) = Sach.Tl


        Name(6) = "@nxb"
        Value(6) = Sach.Nxb


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function

    Public Function Remove(ByVal ssql As String, ByVal Sach As classSACH) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = Sach.Mas
        Return kn.Add(ssql, Name, Value, _soluong)

    End Function



    Private Sub loadTacgia()
        cbTacgia.DataSource = kn.getData("loadTACGIA")
        cbTacgia.DisplayMember() = "tentg"
        cbTacgia.ValueMember() = "matg"

    End Sub
    Private Sub loadTheloai()
        cbTheLoai.DataSource = kn.getData("loadTHELOAI")
        cbTheLoai.DisplayMember() = "tentl"
        cbTheLoai.ValueMember() = "matl"

    End Sub
  

    Private Sub NameHeaderDgv()
        dgSach.Columns("mas").HeaderText = "Mã sách"
        dgSach.Columns("tens").HeaderText = "Tên bìa sách"
        dgSach.Columns("soluongton").HeaderText = "Số lượng"
        dgSach.Columns("dongia").HeaderText = "Đơn giá"
        dgSach.Columns("matg").HeaderText = "Mã tác giả"
        dgSach.Columns("matl").HeaderText = "Mã thể loại"
        dgSach.Columns("nxb").HeaderText = "Nhà xuất bản"
    End Sub

    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaSach.Text) Then
            lbMasach.Visible = True
            lbMasach.ForeColor = Color.Red
            lbMasach.Text = "Mã sách không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTenSach.Text) Then
            lbTenSach.Visible = True
            lbTenSach.ForeColor = Color.Red
            lbTenSach.Text = "Tên sách không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoluongton.Text) Then
            lbSoluong.Visible = True
            lbSoluong.ForeColor = Color.Red
            lbSoluong.Text = "Số lượng không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtDongia.Text) Then
            lbDongia.Visible = True
            lbDongia.ForeColor = Color.Red
            lbDongia.Text = "Đơn giá không được rỗng!"
        End If
    End Sub

    Private Sub ClearText()
        txtMaSach.Text = ""
        txtTenSach.Text = ""
        txtSoluongton.Text = ""
        txtDongia.Text = ""
        txtNXB.Text = ""

    End Sub
    Private Sub ShowData()
        dgSach.DataSource = kn.getData("loadSACH")
    End Sub

    Private Sub FormBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1014
        Me.Height = 664

        FormTacgia1.Visible = False
        FormTheLoai1.Visible = False
        lbMasach.Visible = False
        lbDongia.Visible = False
        lbSoluong.Visible = False
        lbTenSach.Visible = False
        txtTimKiem.Text = ""

        txtTimKiem.HintText = "Tìm kiếm theo tên "



        dgSach.HeaderForeColor = Color.Black
        dgSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells







        'load dg
        ShowData()
        NameHeaderDgv()
        'load combox
        loadTacgia()
        loadTheloai()



    End Sub

    Private Sub btnSach_Click(sender As Object, e As EventArgs) Handles btnSach.Click

        separator.Width = btnSach.Width
        separator.Left = btnSach.Left
        FormTacgia1.Visible = False
        FormTheLoai1.Visible = False

    End Sub

    Private Sub btnTacgia_Click(sender As Object, e As EventArgs) Handles btnTacgia.Click
        separator.Width = btnTacgia.Width
        separator.Left = btnTacgia.Left
        FormTacgia1.BringToFront()
        FormTacgia1.Visible = True
        FormTheLoai1.Visible = False
    End Sub

    Private Sub btnTheloai_Click(sender As Object, e As EventArgs) Handles btnTheloai.Click
        separator.Width = btnTheloai.Width
        separator.Left = btnTheloai.Left
        FormTheLoai1.BringToFront()
        FormTheLoai1.Visible = True
        FormTacgia1.Visible = False
    End Sub

    Private Sub dgSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSach.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgSach.Rows(e.RowIndex)
            txtMaSach.Text = row.Cells("mas").Value.ToString
            txtTenSach.Text = row.Cells("tens").Value.ToString
            txtSoluongton.Text = row.Cells("soluongton").Value.ToString
            txtDongia.Text = row.Cells("dongia").Value.ToString
            cbTacgia.SelectedValue = row.Cells("matg").Value
            cbTheLoai.SelectedValue = row.Cells("matl").Value
            txtNXB.Text = row.Cells("nxb").Value.ToString

            txtMaSach.Enabled = False

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtMaSach.Text)) OrElse (String.IsNullOrEmpty(txtTenSach.Text)) OrElse (String.IsNullOrEmpty(txtSoluongton.Text)) OrElse (String.IsNullOrEmpty(txtDongia.Text)) Then
            KtraNULL()
        Else
            lbMasach.Visible = False
            lbTenSach.Visible = False
            lbSoluong.Visible = False
            lbDongia.Visible = False
            Dim Sach As New classSACH
            Sach.Mas = txtMaSach.Text
            Sach.Tens = txtTenSach.Text
            Sach.Soluong = txtSoluongton.Text
            Sach.Dg = txtDongia.Text
            Sach.Tg = cbTacgia.SelectedValue
            Sach.Tl = cbTheLoai.SelectedValue
            Sach.Nxb = txtNXB.Text


            sql = "updateSACH"
            Add(sql, Sach)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim Sach As New classSACH
            Sach.Mas = txtMaSach.Text
            sql = "removeSACH"
            Remove(sql, Sach)
            ShowData()
            ClearText()
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        Try
            Dim _mas As String
            _mas = txtMaSach.Text

            If ktrID(_mas).Rows.Count > 0 Then
                lbMasach.Text = "Trùng mã sách!"
                lbMasach.Visible = True
                lbMasach.ForeColor = Color.Red
                txtMaSach.Text = ""
                txtMaSach.Focus()

            Else
                lbMasach.Visible = False
                If (String.IsNullOrEmpty(txtMaSach.Text)) OrElse (String.IsNullOrEmpty(txtTenSach.Text)) OrElse (String.IsNullOrEmpty(txtSoluongton.Text)) OrElse (String.IsNullOrEmpty(txtDongia.Text)) Then
                    KtraNULL()
                Else
                    lbMasach.Visible = False
                    lbTenSach.Visible = False
                    lbSoluong.Visible = False
                    lbDongia.Visible = False
                    Dim Sach As New classSACH
                    Sach.Mas = txtMaSach.Text
                    Sach.Tens = txtTenSach.Text
                    Sach.Soluong = txtSoluongton.Text
                    Sach.Dg = txtDongia.Text
                    Sach.Tg = cbTacgia.SelectedValue
                    Sach.Tl = cbTheLoai.SelectedValue
                    Sach.Nxb = txtNXB.Text


                    sql = "insertSACH"
                    Add(sql, Sach)
                    ShowData()
                    MessageBox.Show("Thêm thành công!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaSach.Enabled = True



    End Sub
    Private Sub txtTimKiem_OnValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.OnValueChanged

    End Sub

    Private Sub btnDelSearch_Click(sender As Object, e As EventArgs)

    End Sub
End Class
