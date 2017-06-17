Public Class FormTheLoai

    Dim kn As New KetNoi
    Private _soluong As Integer
    Private sql As String
    Private sl As Integer = 0

    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDTheloai"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function

    Public Function Add(ByVal ssql As String, ByVal TL As classTHELOAI) As Integer
        _soluong = 1

        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@matl"
        Value(0) = TL.Matl

        Name(1) = "@tentl"
        Value(1) = TL.Tentl

        Return kn.Add(ssql, Name, Value, _soluong)
    End Function

    Public Function Remove(ByVal ssql As String, ByVal TL As classTHELOAI) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = TL.Matl

        Return kn.Add(ssql, Name, Value, _soluong)

    End Function


    Private Sub NameHeaderDgv()
        dgTheloai.Columns("matl").HeaderText = "Mã thể loại"
        dgTheloai.Columns("tentl").HeaderText = "Tên thể loại"
    End Sub

    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaTheloai.Text) Then
            lbMatheloai.Visible = True
            lbMatheloai.ForeColor = Color.Red
            lbMatheloai.Text = "Mã thể loại không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTentheloai.Text) Then
            lbTentheloai.Visible = True
            lbTentheloai.ForeColor = Color.Red
            lbTentheloai.Text = "Tên thể loại không được rỗng!"
        End If
    End Sub
    Private Sub ClearText()
        txtMaTheloai.Text = ""
        txtTentheloai.Text = ""

    End Sub
    Private Sub ShowData()
        dgTheloai.DataSource = kn.getData("loadTHELOAI")
    End Sub
    Private Sub FormTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTimkiemTheloai.Text = ""
        txtTimkiemTheloai.HintText = "Tìm kiếm theo tên thể loại"
        ShowData()
        NameHeaderDgv()
        lbMatheloai.Visible = False
        lbTentheloai.Visible = False

        sl = dgTheloai.Rows.Count - 1
        lbSoluongTheLoai.Text = sl.ToString
    End Sub


    Private Sub dgTheloai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTheloai.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgTheloai.Rows(e.RowIndex)
            txtMaTheloai.Text = row.Cells("matl").Value.ToString
            txtTentheloai.Text = row.Cells("tentl").Value.ToString

            txtMaTheloai.Enabled = False

        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _matl As String
            _matl = txtMaTheloai.Text

            If ktrID(_matl).Rows.Count > 0 Then
                lbMatheloai.Text = "Trùng mã thể loại!"
                lbMatheloai.Visible = True
                lbMatheloai.ForeColor = Color.Red
                txtMaTheloai.Text = ""
                txtMaTheloai.Focus()

            Else
                lbMatheloai.Visible = False
                If (String.IsNullOrEmpty(txtMaTheloai.Text)) OrElse (String.IsNullOrEmpty(txtTentheloai.Text)) Then
                    KtraNULL()
                Else
                    lbMatheloai.Visible = False
                    lbTentheloai.Visible = False
                    Dim TL As New classTHELOAI

                    TL.Matl = txtMaTheloai.Text
                    TL.Tentl = txtTentheloai.Text


                    sql = "insertTHELOAI"
                    Add(sql, TL)
                    ShowData()

                    sl = sl + 1
                    lbSoluongTheLoai.Text = sl.ToString
                    MessageBox.Show("Thêm thành công!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim TL As New classTHELOAI
            TL.Matl = txtMaTheloai.Text
            sql = "removeTHELOAI"
            Remove(sql, TL)
            ShowData()
            ClearText()

            sl = sl - 1
            lbSoluongTheLoai.Text = sl.ToString
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (String.IsNullOrEmpty(txtMaTheloai.Text)) OrElse (String.IsNullOrEmpty(txtTentheloai.Text)) Then
            KtraNULL()
        Else
            lbMatheloai.Visible = False
            lbTentheloai.Visible = False
            Dim TL As New classTHELOAI
            TL.Matl = txtMaTheloai.Text
            TL.Tentl = txtTentheloai.Text


            sql = "updateTHELOAI"
            Add(sql, TL)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaTheloai.Enabled = True
    End Sub

    Private Sub btnDelSearch_Click(sender As Object, e As EventArgs) Handles btnDelSearch.Click
        txtTimkiemTheloai.Text = ""
        txtTimkiemTheloai.HintText = "Tìm kiếm theo tên thể loại"
    End Sub

    Private Sub txtTimkiemTheloai_OnValueChanged(sender As Object, e As EventArgs) Handles txtTimkiemTheloai.OnValueChanged

    End Sub


End Class
