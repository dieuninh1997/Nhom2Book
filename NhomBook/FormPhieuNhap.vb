Public Class FormPhieuNhap

    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String

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
        Name(0) = "@sopn"
        Value(0) = PN.Sopn
        Name(1) = "@manv"
        Value(1) = PN.Manv
        Name(2) = "@mancc"
        Value(2) = PN.Mancc
        Name(3) = "@ngaynhap"
        Value(3) = PN.Ngaynhap
        Name(4) = "@tongtien"
        Value(4) = PN.Ngaynhap

        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Public Function Remove(ByVal ssql As String, ByVal PN As classPHIEUNHAP) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = PN.Sopn

        Return kn.Add(ssql, Name, Value, _soluong)

    End Function


    Private Sub NameHeaderDgv()
        dgPhieuNhap.Columns("sopn").HeaderText = "Số phiếu nhập"
        dgPhieuNhap.Columns("manv").HeaderText = "Mã nhân viên"
        dgPhieuNhap.Columns("mancc").HeaderText = "Mã nhà cc"
        dgPhieuNhap.Columns("ngaynhap").HeaderText = "Ngày nhập"
        dgPhieuNhap.Columns("tongtien").HeaderText = "Tổng tiền"
    End Sub
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtSopn.Text) Then
            lbSopn.Visible = True
            lbSopn.ForeColor = Color.Red
            lbSopn.Text = "Số phiếu nhập không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTongtien.Text) Then
            lbTongtien.Visible = True
            lbTongtien.ForeColor = Color.Red
            lbTongtien.Text = "Tổng tiền không được rỗng!"
        End If

    End Sub
    Private Sub ClearText()
        txtSopn.Text = ""
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

        lbSopn.Visible = False
        lbTongtien.Visible = False
        lbNgaynhap.Visible = False
        txtTimKiem.Text = ""
        txtTimKiem.HintText = "Tìm kiếm theo số phiếu nhập "
        'load dg
        ShowData()
        NameHeaderDgv()
        'load combox
        loadNcc()
        loadNv()


    End Sub



    Private Sub dgPhieunhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPhieuNhap.CellClick

    End Sub
End Class
