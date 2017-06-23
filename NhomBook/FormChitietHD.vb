Public Class FormChitietHD
    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String

    Dim directory As String = My.Application.Info.DirectoryPath

    Private Sub FormChitietHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMas()
        loadDvt()
    End Sub

    Private Sub ClearText()
        txtSoLuong.Text = ""
        txtDonGia.Text = ""
    End Sub


    Private Sub loadMas()
        cbMaSach.DataSource = kn.getData("loadSACH")
        cbMaSach.DisplayMember() = "tens"
        cbMaSach.ValueMember() = "mas"

    End Sub

    Private Sub loadDvt()
        cbDvt.DataSource = kn.getData("loadDvt")
        cbDvt.DisplayMember() = "dvt"
        cbDvt.ValueMember() = "dvt"

    End Sub
    Public Function Add(ByVal ssql As String, ByVal Hd As ClassHoadon) As Integer
        _soluong = 3

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mahd"
        Value(0) = Hd.Mahd




        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Private Sub NameHeaderDgv()
        dgChitietHd.Columns("mahd").HeaderText = "Mã hóa đơn"
        dgChitietHd.Columns("mas").HeaderText = "Mã sách"
        dgChitietHd.Columns("soluong").HeaderText = "Số lượng"
        dgChitietHd.Columns("giaban").HeaderText = "Giá bán"
        dgChitietHd.Columns("giamgia").HeaderText = "Giảm giá"

        dgChitietHd.Columns("thanhtien").HeaderText = "Thành tiền"
        dgChitietHd.Columns("dvt").HeaderText = "Đơn vị tính"
    End Sub
    Private Sub btnInHd_Click(sender As Object, e As EventArgs) Handles btnInHd.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Mã hóa đơn,Mã sách,Số lượng,Giá bán,Giảm giá,Thành tiền,Đơn vị tính"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel(dgChitietHd.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Private Sub ShowData(ByVal id As String)
        ' MsgBox(id)

        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDCthd"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = id
        dgChitietHd.DataSource = kn.checkID(sql, Name, Value, _soluong)

    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Try
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub txtMaHdCthd_TextChanged(sender As Object, e As EventArgs) Handles txtMaHdCthd.TextChanged
        ShowData(Me.txtMaHdCthd.Text)
        NameHeaderDgv()
    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'txt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
End Class
