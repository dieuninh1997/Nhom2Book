Public Class Form1
    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Environment.Exit(0)
    End Sub

    Private Sub picMinus_Click(sender As Object, e As EventArgs) Handles picMinus.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picShow_Click(sender As Object, e As EventArgs) Handles picShow.Click
        'If pnMenu.Width = 243 Then
        'pnMenu.Width = 50
        'trans1.ShowSync(pnMenu)
        'picShow.Location = New Point(10, 6)

        ' Else
        'pnMenu.Width = 243
        'picShow.Location = New Point(195, 6)
        'trans1.ShowSync(pnMenu)

        'End If
    End Sub

    Private Sub btnTrangChu_Click(sender As Object, e As EventArgs) Handles btnTrangChu.Click
        btnTrangChu.Normalcolor = btnTrangChu.Activecolor
        btnSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnKhachHang.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhanvien.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhacc.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhapSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnHoaDon.Normalcolor = Color.FromArgb(68, 102, 255)
        Formhome1.BringToFront()
        trans1.ShowSync(Formhome1)

    End Sub

    Private Sub btnSach_Click(sender As Object, e As EventArgs) Handles btnSach.Click
        btnTrangChu.Normalcolor = Color.FromArgb(68, 102, 255)
        btnSach.Normalcolor = btnSach.Activecolor
        btnKhachHang.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhanvien.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhacc.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhapSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnHoaDon.Normalcolor = Color.FromArgb(68, 102, 255)
        FormBook1.BringToFront()
        trans1.ShowSync(FormBook1)
    End Sub

    Private Sub btnKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        btnTrangChu.Normalcolor = Color.FromArgb(68, 102, 255)
        btnSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnKhachHang.Normalcolor = btnKhachHang.Activecolor
        btnNhanvien.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhacc.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhapSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnHoaDon.Normalcolor = Color.FromArgb(68, 102, 255)
        FormKhachhang1.BringToFront()
        trans1.ShowSync(FormKhachhang1)
    End Sub

    Private Sub btnNhanvien_Click(sender As Object, e As EventArgs) Handles btnNhanvien.Click
        btnTrangChu.Normalcolor = Color.FromArgb(68, 102, 255)
        btnSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnKhachHang.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhanvien.Normalcolor = btnNhanvien.Activecolor
        btnNhacc.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhapSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnHoaDon.Normalcolor = Color.FromArgb(68, 102, 255)
        FormNhanvien1.BringToFront()
        trans1.ShowSync(FormNhanvien1)
    End Sub

    Private Sub btnNhacc_Click(sender As Object, e As EventArgs) Handles btnNhacc.Click
        btnTrangChu.Normalcolor = Color.FromArgb(68, 102, 255)
        btnSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnKhachHang.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhanvien.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhacc.Normalcolor = btnNhacc.Activecolor
        btnNhapSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnHoaDon.Normalcolor = Color.FromArgb(68, 102, 255)
        FormNCC1.BringToFront()
        trans1.ShowSync(FormNCC1)
    End Sub

    Private Sub btnNhapSach_Click(sender As Object, e As EventArgs) Handles btnNhapSach.Click
        btnTrangChu.Normalcolor = Color.FromArgb(68, 102, 255)
        btnSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnKhachHang.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhanvien.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhacc.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhapSach.Normalcolor = btnNhapSach.Activecolor
        btnHoaDon.Normalcolor = Color.FromArgb(68, 102, 255)
        FormPhieuNhap1.BringToFront()
        trans1.ShowSync(FormPhieuNhap1)
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        btnTrangChu.Normalcolor = Color.FromArgb(68, 102, 255)
        btnSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnKhachHang.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhanvien.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhacc.Normalcolor = Color.FromArgb(68, 102, 255)
        btnNhapSach.Normalcolor = Color.FromArgb(68, 102, 255)
        btnHoaDon.Normalcolor = btnHoaDon.Activecolor
        FormHoadon1.BringToFront()
        trans1.ShowSync(FormHoadon1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTrangChu.Normalcolor = btnTrangChu.Activecolor
        Formhome1.BringToFront()

    End Sub

    Private Sub pnMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnMenu.Paint

    End Sub
End Class