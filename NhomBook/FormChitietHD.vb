Public Class FormChitietHD
    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String

    Dim directory As String = My.Application.Info.DirectoryPath

    Private Sub FormChitietHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMas()
        loadDvt()
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

    Public Function ktrID(ByVal _mahd As String, ByVal _mas As String) As DataTable
        Dim _soluong As Integer
        _soluong = 1
        Dim sql As String
        sql = "checkIDCtpn"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@mapn"
        Value(0) = _mahd
        Name(1) = "@mas"
        Value(1) = _mas
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function

    Public Function Add(ByVal ssql As String, ByVal cthd As classCthd) As Integer
        _soluong = 4

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mahd"
        Value(0) = cthd.Mahd

        Name(1) = "@mas"
        Value(1) = cthd.Mas
        Name(2) = "@soluong"
        Value(2) = cthd.Soluong
        Name(3) = "@giaban"
        Value(3) = cthd.Giaban
        Name(4) = "@dvt"
        Value(4) = cthd.Dvt


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function

    Public Function Remove(ByVal ssql As String, ByVal cthd As classCthd) As Integer
        _soluong = 1
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@mahd"
        Value(0) = cthd.Mahd
        Name(1) = "@mas"
        Value(1) = cthd.Mas


        Return kn.Add(ssql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtSoLuong.Text) OrElse String.IsNullOrEmpty(txtGiaBan.Text) Then
            MsgBox("Hãy điền đầy đủ thông tin!")

        End If

    End Sub
    Private Sub ClearText()
        txtSoLuong.Focus()

        txtSoLuong.Text = ""
        txtGiaBan.Text = ""
    End Sub

   
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
        sql = "checkIDCthd1"
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
        ClearText()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _mas, _mahd As String
            _mas = cbMaSach.SelectedValue
            _mahd = txtMaHdCthd.Text
            If ktrID(_mahd, _mas).Rows.Count > 0 Then
                MsgBox("Trùng mã sách!")


            Else
                If (String.IsNullOrEmpty(txtSoLuong.Text)) OrElse (String.IsNullOrEmpty(txtGiaBan.Text)) Then
                    KtraNULL()
                Else

                    Dim cthd As New classCthd
                    cthd.Mahd = txtMaHdCthd.Text
                    cthd.Mas = cbMaSach.SelectedValue
                    cthd.Soluong = txtSoLuong.Text
                    cthd.Giaban = txtGiaBan.Text
                    cthd.Dvt = cbDvt.SelectedValue

                    sql = "insertCHITIETHD"
                    Add(sql, cthd)
                    ShowData(Me.txtMaHdCthd.Text)

                    MessageBox.Show("Thêm thành công!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim cthd As New classCthd
            cthd.Mahd = txtMaHdCthd.Text
            cthd.Mas = cbMaSach.SelectedValue
            sql = "removeItemCthd"
            Remove(sql, cthd)
            ShowData(Me.txtMaHdCthd.Text)
            ClearText()


            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtSoLuong.Text)) OrElse (String.IsNullOrEmpty(txtGiaBan.Text)) Then
            KtraNULL()
        Else

            Dim cthd As New classCthd
            cthd.Mahd = txtMaHdCthd.Text

            cthd.Mas = cbMaSach.SelectedValue
            cthd.Soluong = txtSoLuong.Text
            cthd.Giaban = txtGiaBan.Text
            cthd.Dvt = cbDvt.SelectedValue

            sql = "updateItemCthd"
            If (Add(sql, cthd) <> -1) Then

                ShowData(Me.txtMaHdCthd.Text)
                '  NameHeaderDgv()
                MessageBox.Show("Cập nhật thành công!")
            Else
                MessageBox.Show("Cập nhật thất bại!")
                ClearText()

            End If
        End If
    End Sub

    Private Sub dgCthd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgChitietHd.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgChitietHd.Rows(e.RowIndex)

            cbMaSach.Text = row.Cells("mas").Value.ToString
            txtSoLuong.Text = row.Cells("soluong").Value.ToString
            txtGiaBan.Text = row.Cells("giaban").Value.ToString
            cbDvt.Text = row.Cells("dvt").Value.ToString

        End If
    End Sub
End Class
