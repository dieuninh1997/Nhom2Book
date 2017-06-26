Public Class FormPhieuNhap

    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String
    Private sl As Integer = 0
    Private kt As New Kiemtra
    Private pn As New classPHIEUNHAP
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDPhieunhap"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function Add(ByVal ssql As String, ByVal PN As classPHIEUNHAP) As Integer
        _soluong = 4

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mapn"
        Value(0) = PN.Mapn
        Name(1) = "@manv"
        Value(1) = PN.Manv
        Name(2) = "@mancc"
        Value(2) = PN.Mancc
        Name(3) = "@ngaynhap"
        Value(3) = PN.Ngaynhap
        Name(4) = "@tongtien"
        Value(4) = PN.Tongtien

        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Public Function Remove(ByVal ssql As String, ByVal PN As classPHIEUNHAP) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = PN.mapn

        Return kn.Add(ssql, Name, Value, _soluong)

    End Function


    Private Sub NameHeaderDgv()
        dgPhieuNhap.Columns("mapn").HeaderText = "Mã phiếu nhập"
        dgPhieuNhap.Columns("manv").HeaderText = "Mã nhân viên"
        dgPhieuNhap.Columns("mancc").HeaderText = "Mã nhà cc"
        dgPhieuNhap.Columns("ngaynhap").HeaderText = "Ngày nhập"
        dgPhieuNhap.Columns("tongtien").HeaderText = "Tổng tiền"
    End Sub
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMapn.Text) Then
            lbMapn.Visible = True
            lbMapn.ForeColor = Color.Red
            lbMapn.Text = "Số phiếu nhập không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTongtien.Text) Then
            lbTongtien.Visible = True
            lbTongtien.ForeColor = Color.Red
            lbTongtien.Text = "Tổng tiền không được rỗng!"
        End If

    End Sub
    Private Sub ClearText()
        txtMapn.Text = ""
        txtTongtien.Text = ""

    End Sub
    Private Sub ShowData()
        dgPhieuNhap.DataSource = kn.getData("loadPhieunhap")
    End Sub


    Private Sub loadNv()
        cbManv.DataSource = kn.getData("loadNHANVIEN")
        cbManv.DisplayMember() = "tennv"
        cbManv.ValueMember() = "manv"

    End Sub

    Private Sub loadNcc()
        cbMancc.DataSource = kn.getData("loadNHACC")
        cbMancc.DisplayMember() = "tenncc"
        cbMancc.ValueMember() = "mancc"

    End Sub

    Private Sub FormPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormChiTietPN1.Visible = False
        FormChiTietPN1.SendToBack()
        lbMapn.Visible = False
        lbTongtien.Visible = False
        lbNgaynhap.Visible = False
        txtTimKiem.Text = ""
        txtTimKiem.HintText = "Tìm kiếm  "
        'load dg
        ShowData()
        NameHeaderDgv()
        'load combox
        loadNcc()
        loadNv()
        sl = dgPhieuNhap.Rows.Count - 1
        lbSoluongPhieuNhap.Text = sl.ToString
        ' cbSearch.Enabled = False
        ' cbSearch.Focused=False
        LoadDataOnCbSearchTheo()
    End Sub



    Private Sub dgPhieunhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPhieuNhap.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgPhieuNhap.Rows(e.RowIndex)
            txtMapn.Text = row.Cells("mapn").Value.ToString
            cbManv.SelectedValue = row.Cells("manv").Value.ToString
            cbMancc.SelectedValue = row.Cells("mancc").Value.ToString
            txtTongtien.Text = row.Cells("tongtien").Value.ToString
            dtpNgaynhap.Value = row.Cells("ngaynhap").Value.ToString
            txtMapn.Enabled = False

            FormChiTietPN1.lbMapn.Text = row.Cells("mapn").Value.ToString
            FormChiTietPN1.txtMapnCtpn.Text = row.Cells("mapn").Value.ToString
            FormChiTietPN1.txtManvCtpn.Text = row.Cells("manv").Value.ToString
            FormChiTietPN1.txtManccCtpn.Text = row.Cells("mancc").Value.ToString
            FormChiTietPN1.txtNgNhapCtpn.Text = dtpNgaynhap.Value.ToString
            FormChiTietPN1.txtTongTienCtpn.Text = row.Cells("tongtien").Value.ToString

            pn.Mapn = txtMapn.Text
        End If
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtMapn.Text)) OrElse (String.IsNullOrEmpty(txtTongtien.Text)) Then
            KtraNULL()
        Else
            lbMapn.Visible = False
            lbNgaynhap.Visible = False
            lbTongtien.Visible = False
            Dim pn As New classPHIEUNHAP

            pn.Mapn = txtMapn.Text
            pn.Mancc = cbMancc.SelectedValue
            pn.Manv = cbManv.SelectedValue
            pn.Tongtien = txtTongtien.Text
            pn.Ngaynhap = dtpNgaynhap.Value.ToString


            sql = "updatePHIEUNHAP"
            Add(sql, pn)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim pn As New classPHIEUNHAP
            pn.Mapn = txtMapn.Text
            sql = "removePHIEUNHAP"
            Remove(sql, pn)
            ShowData()
            ClearText()
            sl = sl - 1
            lbSoluongPhieuNhap.Text = sl.ToString
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMapn.Enabled = True
        txtMapn.Focus()
        txtTongtien.Text = "0"

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _mapn As String
            _mapn = txtMapn.Text

            If ktrID(_mapn).Rows.Count > 0 Then
                lbMapn.Text = "Trùng mã sách!"
                lbMapn.Visible = True
                lbMapn.ForeColor = Color.Red
                txtMapn.Text = ""
                txtMapn.Focus()

            Else
                If kt.KiemtraNgayNhapXuat(dtpNgaynhap.Value) = False Then
                    lbNgaynhap.Text = "Ngày nhập không hợp lệ!"
                    lbNgaynhap.Visible = True
                    lbNgaynhap.ForeColor = Color.Red
                Else


                    lbMapn.Visible = False
                    If (String.IsNullOrEmpty(txtMapn.Text)) OrElse (String.IsNullOrEmpty(txtTongtien.Text)) Then
                        KtraNULL()
                    Else


                        lbMapn.Visible = False
                        lbNgaynhap.Visible = False
                        lbTongtien.Visible = False
                        Dim pn As New classPHIEUNHAP
                        pn.Mapn = txtMapn.Text
                        pn.Manv = cbManv.SelectedValue
                        pn.Mancc = cbMancc.SelectedValue
                        pn.Tongtien = txtTongtien.Text
                        pn.Ngaynhap = dtpNgaynhap.Value.ToString


                        sql = "insertPHIEUNHAP"
                        Add(sql, pn)
                        ShowData()
                        sl = sl + 1
                        lbSoluongPhieuNhap.Text = sl.ToString
                        MessageBox.Show("Thêm thành công!")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        FormChiTietPN1.Visible = True
        FormChiTietPN1.BringToFront()
        FormChiTietPN1.lbMapn.Text = txtMapn.Text
    End Sub

    Private Sub LoadDataOnCbSearchTheo()
        Dim DT As DataTable = New DataTable()
        DT.Columns.Add("Name")


        DT.Rows.Add("Mã phiếu nhập")
        DT.Rows.Add("Mã nhân viên")
        DT.Rows.Add("Mã nhà cc")
        DT.Rows.Add("Ngày nhập")
        DT.Rows.Add("Tổng tiền (trong khoảng a-b)")
        cbSearch.DataSource = DT
        cbSearch.DisplayMember = "Name"
        cbSearch.ValueMember = "Name"
    End Sub

    Private Sub txtTimKiem_OnValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.OnValueChanged
        Dim _soluong As Integer
        Dim sql As String

        If cbSearch.SelectedValue = "Mã phiếu nhập" Then
            _soluong = 0
            Dim Value(_soluong) As String
            Dim Name(_soluong) As String
            If txtTimKiem.Text.Length > 0 Then

                sql = "searchIDPHIEUNHAP"
                Name(0) = "@ma"
                Value(0) = txtTimKiem.Text
                dgPhieuNhap.DataSource = kn.checkID(sql, Name, Value, _soluong)

            Else
                ' txtTimKiemnhanvien.HintText = "Tìm kiếm "
                ShowData()
                End
            End If
        ElseIf cbSearch.SelectedValue = "Mã nhân viên" Then
            _soluong = 0
            Dim Value(_soluong) As String
            Dim Name(_soluong) As String
            If txtTimKiem.Text.Length > 0 Then

                sql = "searchIDNv"
                Name(0) = "@ma"
                Value(0) = txtTimKiem.Text
                dgPhieuNhap.DataSource = kn.checkID(sql, Name, Value, _soluong)

            Else
                ' txtTimKiemnhanvien.HintText = "Tìm kiếm "
                ShowData()
                End
            End If
        ElseIf cbSearch.SelectedValue = "Mã nhà cc" Then
            _soluong = 0
            Dim Value(_soluong) As String
            Dim Name(_soluong) As String
            If txtTimKiem.Text.Length > 0 Then

                sql = "searchIDNcc"
                Name(0) = "@ma"
                Value(0) = txtTimKiem.Text
                dgPhieuNhap.DataSource = kn.checkID(sql, Name, Value, _soluong)

            Else
                ' txtTimKiemnhanvien.HintText = "Tìm kiếm "
                ShowData()
                End
            End If

        End If
        lbSoluongPhieuNhap.Text = dgPhieuNhap.RowCount - 1
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim _soluong As Integer
        Dim sql As String

        If cbSearch.SelectedValue = "Ngày nhập" Then
            If txtTimKiem.Text.Length > 0 Then
                Dim Mang() As String

                If (txtTimKiem.Text.Trim().Length = 7 Or txtTimKiem.Text.Trim().Length = 6) Then
                    sql = "searchNgayNhap2"
                    Mang = txtTimKiem.Text.Split("/")
                    _soluong = 1
                    Dim Value(_soluong) As String
                    Dim Name(_soluong) As String


                    Name(0) = "@m"
                    Value(0) = Mang(0)
                    Name(1) = "@y"
                    Value(1) = Mang(1)
                    dgPhieuNhap.DataSource = kn.checkID(sql, Name, Value, _soluong)
                ElseIf (txtTimKiem.Text.Trim().Length > 7)
                    sql = "searchNgayNhap"
                    Mang = txtTimKiem.Text.Split("/")
                    _soluong = 2
                    Dim Value(_soluong) As String
                    Dim Name(_soluong) As String

                    Name(0) = "@d"
                    Value(0) = Mang(0)
                    Name(1) = "@m"
                    Value(1) = Mang(1)
                    Name(2) = "@y"
                    Value(2) = Mang(2)
                    dgPhieuNhap.DataSource = kn.checkID(sql, Name, Value, _soluong)
                Else
                    ' txtTimKiemnhanvien.HintText = "Tìm kiếm "
                    ShowData()
                    End
                End If
            End If
        ElseIf cbSearch.SelectedValue = "Tổng tiền (trong khoảng a-b)" Then 'search theo tổng tiền
            sql = "searchBy1TongTien"
            _soluong = 1

            Dim Name(_soluong) As String
            Dim Value(_soluong) As Integer

            If txtTimKiem.Text.Length > 0 Then
                Dim Mang() As String
                Mang = txtTimKiem.Text.Split("-")
                MsgBox(Mang(0))
                MsgBox(Mang(1))


                Name(0) = "@t"


                Value(0) = Integer.Parse(Mang(0))

                Name(1) = "@tt"
                Value(1) = Integer.Parse(Mang(1))


                dgPhieuNhap.DataSource = kn.checkID(sql, Name, Value, _soluong)

                    btnExcel.Enabled = True
                Else
                    btnExcel.Enabled = False
                ShowData()
            End If
        End If
        lbSoluongPhieuNhap.Text = dgPhieuNhap.RowCount - 1
    End Sub

    Private Sub btnRefesh_Click(sender As Object, e As EventArgs) Handles btnRefesh.Click
        ShowData()

    End Sub

    Private Sub FormChiTietPN1_Load(sender As Object, e As EventArgs) Handles FormChiTietPN1.Load

    End Sub
End Class
