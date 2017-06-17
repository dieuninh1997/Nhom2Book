Public Class FormNCC

    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String
    Private ktSdt As New Kiemtra
    Private sl As Integer = 0

    Private Sub ShowData()
        dgNCC.DataSource = kn.getData("loadNHACC")
    End Sub

    Private Sub ClearText()
        txtMaNCC.Text = ""
        txtTenNCC.Text = ""
        txtDiachi.Text = ""
        txtDiachi.Text = ""
    End Sub
    Private Sub NameHeaderDgv()
        dgNCC.Columns("mancc").HeaderText = "Mã nhà cung cấp"
        dgNCC.Columns("tenncc").HeaderText = "Tên nhà cung cấp"
        dgNCC.Columns("diachi").HeaderText = "địa chỉ cung cấp"
        dgNCC.Columns("sdt").HeaderText = "Số điện thoại"

    End Sub

    Private Sub FormNCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTimKiemNCC.Text = ""
        txtTimKiemNCC.HintText = "Tìm kiếm theo tên nhà cung cấp"
        lbMaNCC.Visible = False
        lbTenNCC.Visible = False
        lbDiachi.Visible = False
        lbSdt.Visible = False

        ShowData()
        NameHeaderDgv()
        sl = dgNCC.Rows.Count - 1
        lbSoluongNCC.Text = sl.ToString


    End Sub
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDNhacc"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@maNhacc"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub dgncc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNCC.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgNCC.Rows(e.RowIndex)
            txtMaNCC.Text = row.Cells("mancc").Value.ToString
            txtTenNCC.Text = row.Cells("tenncc").Value.ToString
            txtDiachi.Text = row.Cells("diachi").Value.ToString
            txtSdt.Text = row.Cells("sdt").Value.ToString
            txtMaNCC.Enabled = False

        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _mancc As String
            _mancc = txtMaNCC.Text

            If ktrID(_mancc).Rows.Count > 0 Then
                lbMaNCC.Text = "Trùng mã nhà cung cấp!"
                lbMaNCC.Visible = True
                lbMaNCC.ForeColor = Color.Red
                txtMaNCC.Text = ""
                txtMaNCC.Focus()
            Else
                If ktSdt.KiemtraSdt(txtSdt.Text) = False Then
                    lbSdt.Text = "Số điện thoại không hợp lệ!"
                    lbSdt.Visible = True
                    lbSdt.ForeColor = Color.Red
                    txtSdt.Text = ""
                    txtSdt.Focus()



                Else
                    lbMaNCC.Visible = False
                    If (String.IsNullOrEmpty(txtMaNCC.Text)) OrElse (String.IsNullOrEmpty(txtTenNCC.Text)) OrElse (String.IsNullOrEmpty(txtDiachi.Text)) OrElse (String.IsNullOrEmpty(txtSdt.Text)) Then
                        KtraNULL()
                    Else
                        lbMaNCC.Visible = False
                        lbTenNCC.Visible = False
                        lbDiachi.Visible = False
                        lbSdt.Visible = False
                        Dim ncc As New ClassNCC
                        ncc.Mancc = txtMaNCC.Text
                        ncc.Tenncc = txtTenNCC.Text
                        ncc.Diachi = txtDiachi.Text
                        ncc.Sdt = txtSdt.Text
                        sql = "insertNHACC"
                        Add(sql, ncc)
                        ShowData()
                        sl = sl + 1
                        lbSoluongNCC.Text = sl.ToString
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
            Dim ncc As New ClassNCC

            ncc.Mancc = txtMaNCC.Text
            sql = "removeNHACC"
            Remove(sql, ncc)
            ShowData()
            ClearText()
            sl = sl - 1
            lbSoluongNCC.Text = sl.ToString
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaNCC.Text) Then
            lbMaNCC.Visible = True
            lbMaNCC.ForeColor = Color.Red
            lbMaNCC.Text = "Mã nhà cung cấp không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTenNCC.Text) Then
            lbTenNCC.Visible = True
            lbTenNCC.ForeColor = Color.Red
            lbTenNCC.Text = "Tên nhà cung cấp không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtDiachi.Text) Then
            lbDiachi.Visible = True
            lbDiachi.ForeColor = Color.Red
            lbDiachi.Text = "Địa chỉ không được rỗng"
        End If
        If String.IsNullOrEmpty(txtSdt.Text) Then
            lbSdt.Visible = True
            lbSdt.ForeColor = Color.Red
            lbSdt.Text = "Số điện thoại không được rỗng!"

        End If
    End Sub
    Public Function Add(ByVal ssql As String, ByVal ncc As ClassNCC) As Integer
        _soluong = 3

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mancc"
        Value(0) = ncc.Mancc
        Name(1) = "@tenncc"
        Value(1) = ncc.Tenncc
        Name(2) = "@diachi"
        Value(2) = ncc.Diachi
        Name(3) = "@sdt"
        Value(3) = ncc.Sdt


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Public Function Remove(ByVal ssql As String, ByVal ncc As ClassNCC) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = ncc.Mancc
        Return kn.Add(ssql, Name, Value, _soluong)

    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtTenNCC.Text)) OrElse (String.IsNullOrEmpty(txtSdt.Text)) OrElse (String.IsNullOrEmpty(txtDiachi.Text)) Then
            KtraNULL()
        Else
            lbMaNCC.Visible = False
            lbTenNCC.Visible = False
            lbDiachi.Visible = False
            lbSdt.Visible = False
            Dim ncc As New ClassNCC
            If ktSdt.KiemtraSdt(txtSdt.Text) = False Then
                lbSdt.Text = "Số điện thoại không hợp lệ!"
                lbSdt.Visible = True
                lbSdt.ForeColor = Color.Red
                txtSdt.Text = ""
                txtSdt.Focus()
            Else
                ncc.Mancc = txtMaNCC.Text
                ncc.Tenncc = txtTenNCC.Text
                ncc.Diachi = txtDiachi.Text
                ncc.Sdt = txtSdt.Text

                sql = "updateNHACC"
                Add(sql, ncc)
                ShowData()
                MessageBox.Show("Cập nhật thành công!")
            End If
        End If

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaNCC.Enabled = True

    End Sub
    Private Sub txtTimKiemncc_OnValueChanged(sender As Object, e As EventArgs) Handles txtTimKiemNCC.OnValueChanged
        If String.IsNullOrEmpty(txtTimKiemNCC.Text) Then
            ShowData()
        Else


        End If
    End Sub

    Private Sub btnDelSearch_Click(sender As Object, e As EventArgs) Handles btnDelSearch.Click
        txtTimKiemNCC.Text = ""
        txtTimKiemNCC.HintText = "Tìm kiếm theo tên nhà cung cấp"
    End Sub
End Class
