Imports System.Data.SqlClient

Public Class FormChiTietPN
    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String
    Private sl As Integer = 0
    Private kt As New Kiemtra
    Dim directory As String = My.Application.Info.DirectoryPath

    Private Sub FormChiTietPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClearText()

        txtMaSach.Enabled = False
        txtSoLuong.Enabled = False
        txtDvt.Enabled = False
        txtSoLuong.Enabled = False
        dgChitietPn.ForeColor = Color.Black
    End Sub

    Private Sub NameHeaderDgv()
        dgChitietPn.Columns("mapn").HeaderText = "Mã phiếu nhập"
        dgChitietPn.Columns("mas").HeaderText = "Mã sách"
        dgChitietPn.Columns("soluong").HeaderText = "Số lượng"
        dgChitietPn.Columns("gianhap").HeaderText = "Giá nhập"
        dgChitietPn.Columns("dvt").HeaderText = "Đơn vị tính"
        dgChitietPn.Columns("thanhtien").HeaderText = "Thành tiền"
    End Sub
    Private Sub ShowData(ByVal id As String)
        ' MsgBox(id)

        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDCtpn"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = id
        dgChitietPn.DataSource = kn.checkID(sql, Name, Value, _soluong)

    End Sub

    Private Sub btnInPn_Click(sender As Object, e As EventArgs) Handles btnInPn.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Mã phiếu nhập,Mã sách,Số lượng,Giá nhập,Đơn vị tính,Thành tiền"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel(dgChitietPn.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Try
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub txtMapnCtpn_TextChanged(sender As Object, e As EventArgs) Handles txtMapnCtpn.TextChanged
        ShowData(Me.txtMapnCtpn.Text)
        NameHeaderDgv()
    End Sub

    Private Sub dgCtpn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgChitietPn.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgChitietPn.Rows(e.RowIndex)
            txtMaSach.Enabled = False

            txtSoLuong.Enabled = True
            txtDvt.Enabled = True
            txtGiaNhap.Enabled = True
            txtMaSach.Text = row.Cells("mas").Value.ToString
            txtSoLuong.Text = row.Cells("soluong").Value.ToString
            txtGiaNhap.Text = row.Cells("gianhap").Value.ToString
            txtDvt.Text = row.Cells("dvt").Value.ToString

        End If
    End Sub
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDHoadon"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function

    Public Function Add(ByVal ssql As String, ByVal ctpn As classCtpn) As Integer
        _soluong = 4

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mapn"
        Value(0) = ctpn.Mapn

        Name(1) = "@mas"
        Value(1) = ctpn.Mas
        Name(2) = "@soluong"
        Value(2) = ctpn.Soluong
        Name(3) = "@gianhap"
        Value(3) = ctpn.Gianhap
        Name(4) = "@dvt"
        Value(4) = ctpn.Dvt


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Public Function Remove(ByVal ssql As String, ByVal ctpn As classCtpn) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = ctpn.Mas


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaSach.Text) OrElse String.IsNullOrEmpty(txtSoLuong.Text) OrElse String.IsNullOrEmpty(txtGiaNhap.Text) OrElse String.IsNullOrEmpty(txtDvt.Text) Then
            MsgBox("Hãy điền đầy đủ thông tin!")

        End If

    End Sub
    Private Sub ClearText()
        txtSoLuong.Text = ""
        txtMaSach.Text = ""
        txtDvt.Text = ""
        txtGiaNhap.Text = ""
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaSach.Enabled = True
        txtSoLuong.Enabled = True
        txtDvt.Enabled = True
        txtGiaNhap.Enabled = True
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtMaSach.Text)) OrElse (String.IsNullOrEmpty(txtSoLuong.Text)) OrElse (String.IsNullOrEmpty(txtGiaNhap.Text)) OrElse (String.IsNullOrEmpty(txtDvt.Text)) Then
            KtraNULL()
        Else

            Dim ctpn As New classCtpn
            ctpn.Mapn = txtMapnCtpn.Text

            ctpn.Mas = txtMaSach.Text
            ctpn.Soluong = txtSoLuong.Text
            ctpn.Gianhap = txtGiaNhap.Text
            ctpn.Dvt = txtDvt.Text

            sql = "updateItemCtpn"
            Add(sql, ctpn)
            ShowData(Me.txtMapnCtpn.Text)
            '  NameHeaderDgv()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub
End Class
