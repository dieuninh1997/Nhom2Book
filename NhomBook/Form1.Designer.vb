<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnClose = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Title = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.picMinus = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnHoaDon = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhapSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhacc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhanvien = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnKhachHang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTrangChu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.picShow = New System.Windows.Forms.PictureBox()
        Me.diChuyen1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.diChuyen2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.diChuyen3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.trans1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FormKhachhang1 = New NhomBook.FormKhachhang()
        Me.FormHoadon1 = New NhomBook.FormHoadon()
        Me.FormPhieuNhap1 = New NhomBook.FormPhieuNhap()
        Me.FormNhanvien1 = New NhomBook.FormNhanvien()
        Me.FormNCC1 = New NhomBook.FormNCC()
        Me.Formhome1 = New NhomBook.Formhome()
        Me.FormBook1 = New NhomBook.FormBook()
        Me.pnClose.SuspendLayout()
        CType(Me.picMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMenu.SuspendLayout()
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'pnClose
        '
        Me.pnClose.BackgroundImage = CType(resources.GetObject("pnClose.BackgroundImage"), System.Drawing.Image)
        Me.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnClose.Controls.Add(Me.Title)
        Me.pnClose.Controls.Add(Me.picMinus)
        Me.pnClose.Controls.Add(Me.picClose)
        Me.trans1.SetDecoration(Me.pnClose, BunifuAnimatorNS.DecorationType.None)
        Me.pnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnClose.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnClose.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnClose.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnClose.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnClose.Location = New System.Drawing.Point(0, 0)
        Me.pnClose.Name = "pnClose"
        Me.pnClose.Quality = 10
        Me.pnClose.Size = New System.Drawing.Size(1258, 40)
        Me.pnClose.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.trans1.SetDecoration(Me.Title, BunifuAnimatorNS.DecorationType.None)
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(541, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(189, 25)
        Me.Title.TabIndex = 2
        Me.Title.Text = "QUẢN LÝ BÁN SÁCH"
        '
        'picMinus
        '
        Me.picMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.trans1.SetDecoration(Me.picMinus, BunifuAnimatorNS.DecorationType.None)
        Me.picMinus.Image = CType(resources.GetObject("picMinus.Image"), System.Drawing.Image)
        Me.picMinus.Location = New System.Drawing.Point(1188, 7)
        Me.picMinus.Name = "picMinus"
        Me.picMinus.Size = New System.Drawing.Size(24, 24)
        Me.picMinus.TabIndex = 1
        Me.picMinus.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.trans1.SetDecoration(Me.picClose, BunifuAnimatorNS.DecorationType.None)
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(1218, 7)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(24, 24)
        Me.picClose.TabIndex = 0
        Me.picClose.TabStop = False
        '
        'pnMenu
        '
        Me.pnMenu.BackgroundImage = CType(resources.GetObject("pnMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnMenu.Controls.Add(Me.btnHoaDon)
        Me.pnMenu.Controls.Add(Me.btnNhapSach)
        Me.pnMenu.Controls.Add(Me.btnNhacc)
        Me.pnMenu.Controls.Add(Me.btnNhanvien)
        Me.pnMenu.Controls.Add(Me.btnKhachHang)
        Me.pnMenu.Controls.Add(Me.btnSach)
        Me.pnMenu.Controls.Add(Me.btnTrangChu)
        Me.pnMenu.Controls.Add(Me.picShow)
        Me.trans1.SetDecoration(Me.pnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.pnMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnMenu.Location = New System.Drawing.Point(0, 40)
        Me.pnMenu.Name = "pnMenu"
        Me.pnMenu.Quality = 10
        Me.pnMenu.Size = New System.Drawing.Size(243, 668)
        Me.pnMenu.TabIndex = 1
        '
        'btnHoaDon
        '
        Me.btnHoaDon.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHoaDon.BorderRadius = 0
        Me.btnHoaDon.ButtonText = "Hóa đơn"
        Me.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnHoaDon, BunifuAnimatorNS.DecorationType.None)
        Me.btnHoaDon.DisabledColor = System.Drawing.Color.Gray
        Me.btnHoaDon.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHoaDon.Iconimage = CType(resources.GetObject("btnHoaDon.Iconimage"), System.Drawing.Image)
        Me.btnHoaDon.Iconimage_right = Nothing
        Me.btnHoaDon.Iconimage_right_Selected = Nothing
        Me.btnHoaDon.Iconimage_Selected = Nothing
        Me.btnHoaDon.IconMarginLeft = 0
        Me.btnHoaDon.IconMarginRight = 0
        Me.btnHoaDon.IconRightVisible = True
        Me.btnHoaDon.IconRightZoom = 0R
        Me.btnHoaDon.IconVisible = True
        Me.btnHoaDon.IconZoom = 40.0R
        Me.btnHoaDon.IsTab = False
        Me.btnHoaDon.Location = New System.Drawing.Point(0, 371)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHoaDon.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnHoaDon.OnHoverTextColor = System.Drawing.Color.White
        Me.btnHoaDon.selected = False
        Me.btnHoaDon.Size = New System.Drawing.Size(241, 48)
        Me.btnHoaDon.TabIndex = 11
        Me.btnHoaDon.Text = "Hóa đơn"
        Me.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHoaDon.Textcolor = System.Drawing.Color.White
        Me.btnHoaDon.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNhapSach
        '
        Me.btnNhapSach.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNhapSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhapSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhapSach.BorderRadius = 0
        Me.btnNhapSach.ButtonText = "Nhập sách"
        Me.btnNhapSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnNhapSach, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhapSach.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhapSach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhapSach.Iconimage = CType(resources.GetObject("btnNhapSach.Iconimage"), System.Drawing.Image)
        Me.btnNhapSach.Iconimage_right = Nothing
        Me.btnNhapSach.Iconimage_right_Selected = Nothing
        Me.btnNhapSach.Iconimage_Selected = Nothing
        Me.btnNhapSach.IconMarginLeft = 0
        Me.btnNhapSach.IconMarginRight = 0
        Me.btnNhapSach.IconRightVisible = True
        Me.btnNhapSach.IconRightZoom = 0R
        Me.btnNhapSach.IconVisible = True
        Me.btnNhapSach.IconZoom = 40.0R
        Me.btnNhapSach.IsTab = False
        Me.btnNhapSach.Location = New System.Drawing.Point(-1, 323)
        Me.btnNhapSach.Name = "btnNhapSach"
        Me.btnNhapSach.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhapSach.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnNhapSach.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNhapSach.selected = False
        Me.btnNhapSach.Size = New System.Drawing.Size(241, 48)
        Me.btnNhapSach.TabIndex = 10
        Me.btnNhapSach.Text = "Nhập sách"
        Me.btnNhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhapSach.Textcolor = System.Drawing.Color.White
        Me.btnNhapSach.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNhacc
        '
        Me.btnNhacc.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNhacc.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhacc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhacc.BorderRadius = 0
        Me.btnNhacc.ButtonText = "Nhà cung cấp"
        Me.btnNhacc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnNhacc, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhacc.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhacc.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhacc.Iconimage = CType(resources.GetObject("btnNhacc.Iconimage"), System.Drawing.Image)
        Me.btnNhacc.Iconimage_right = Nothing
        Me.btnNhacc.Iconimage_right_Selected = Nothing
        Me.btnNhacc.Iconimage_Selected = Nothing
        Me.btnNhacc.IconMarginLeft = 0
        Me.btnNhacc.IconMarginRight = 0
        Me.btnNhacc.IconRightVisible = True
        Me.btnNhacc.IconRightZoom = 0R
        Me.btnNhacc.IconVisible = True
        Me.btnNhacc.IconZoom = 40.0R
        Me.btnNhacc.IsTab = False
        Me.btnNhacc.Location = New System.Drawing.Point(0, 275)
        Me.btnNhacc.Name = "btnNhacc"
        Me.btnNhacc.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhacc.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnNhacc.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNhacc.selected = False
        Me.btnNhacc.Size = New System.Drawing.Size(241, 48)
        Me.btnNhacc.TabIndex = 9
        Me.btnNhacc.Text = "Nhà cung cấp"
        Me.btnNhacc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhacc.Textcolor = System.Drawing.Color.White
        Me.btnNhacc.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNhanvien
        '
        Me.btnNhanvien.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNhanvien.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhanvien.BorderRadius = 0
        Me.btnNhanvien.ButtonText = "Nhân viên"
        Me.btnNhanvien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnNhanvien, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhanvien.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhanvien.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhanvien.Iconimage = CType(resources.GetObject("btnNhanvien.Iconimage"), System.Drawing.Image)
        Me.btnNhanvien.Iconimage_right = Nothing
        Me.btnNhanvien.Iconimage_right_Selected = Nothing
        Me.btnNhanvien.Iconimage_Selected = Nothing
        Me.btnNhanvien.IconMarginLeft = 0
        Me.btnNhanvien.IconMarginRight = 0
        Me.btnNhanvien.IconRightVisible = True
        Me.btnNhanvien.IconRightZoom = 0R
        Me.btnNhanvien.IconVisible = True
        Me.btnNhanvien.IconZoom = 40.0R
        Me.btnNhanvien.IsTab = False
        Me.btnNhanvien.Location = New System.Drawing.Point(-1, 227)
        Me.btnNhanvien.Name = "btnNhanvien"
        Me.btnNhanvien.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhanvien.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnNhanvien.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNhanvien.selected = False
        Me.btnNhanvien.Size = New System.Drawing.Size(241, 48)
        Me.btnNhanvien.TabIndex = 8
        Me.btnNhanvien.Text = "Nhân viên"
        Me.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhanvien.Textcolor = System.Drawing.Color.White
        Me.btnNhanvien.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnKhachHang
        '
        Me.btnKhachHang.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKhachHang.BorderRadius = 0
        Me.btnKhachHang.ButtonText = "Khách hàng"
        Me.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnKhachHang, BunifuAnimatorNS.DecorationType.None)
        Me.btnKhachHang.DisabledColor = System.Drawing.Color.Gray
        Me.btnKhachHang.Iconcolor = System.Drawing.Color.Transparent
        Me.btnKhachHang.Iconimage = CType(resources.GetObject("btnKhachHang.Iconimage"), System.Drawing.Image)
        Me.btnKhachHang.Iconimage_right = Nothing
        Me.btnKhachHang.Iconimage_right_Selected = Nothing
        Me.btnKhachHang.Iconimage_Selected = Nothing
        Me.btnKhachHang.IconMarginLeft = 0
        Me.btnKhachHang.IconMarginRight = 0
        Me.btnKhachHang.IconRightVisible = True
        Me.btnKhachHang.IconRightZoom = 0R
        Me.btnKhachHang.IconVisible = True
        Me.btnKhachHang.IconZoom = 40.0R
        Me.btnKhachHang.IsTab = False
        Me.btnKhachHang.Location = New System.Drawing.Point(0, 179)
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKhachHang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnKhachHang.OnHoverTextColor = System.Drawing.Color.White
        Me.btnKhachHang.selected = False
        Me.btnKhachHang.Size = New System.Drawing.Size(241, 48)
        Me.btnKhachHang.TabIndex = 7
        Me.btnKhachHang.Text = "Khách hàng"
        Me.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnKhachHang.Textcolor = System.Drawing.Color.White
        Me.btnKhachHang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSach
        '
        Me.btnSach.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSach.BorderRadius = 0
        Me.btnSach.ButtonText = "Sách"
        Me.btnSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnSach, BunifuAnimatorNS.DecorationType.None)
        Me.btnSach.DisabledColor = System.Drawing.Color.Gray
        Me.btnSach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSach.Iconimage = CType(resources.GetObject("btnSach.Iconimage"), System.Drawing.Image)
        Me.btnSach.Iconimage_right = Nothing
        Me.btnSach.Iconimage_right_Selected = Nothing
        Me.btnSach.Iconimage_Selected = Nothing
        Me.btnSach.IconMarginLeft = 0
        Me.btnSach.IconMarginRight = 0
        Me.btnSach.IconRightVisible = True
        Me.btnSach.IconRightZoom = 0R
        Me.btnSach.IconVisible = True
        Me.btnSach.IconZoom = 40.0R
        Me.btnSach.IsTab = False
        Me.btnSach.Location = New System.Drawing.Point(-1, 131)
        Me.btnSach.Name = "btnSach"
        Me.btnSach.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSach.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnSach.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSach.selected = False
        Me.btnSach.Size = New System.Drawing.Size(241, 48)
        Me.btnSach.TabIndex = 6
        Me.btnSach.Text = "Sách"
        Me.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSach.Textcolor = System.Drawing.Color.White
        Me.btnSach.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTrangChu
        '
        Me.btnTrangChu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTrangChu.BorderRadius = 0
        Me.btnTrangChu.ButtonText = "Trang chủ"
        Me.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans1.SetDecoration(Me.btnTrangChu, BunifuAnimatorNS.DecorationType.None)
        Me.btnTrangChu.DisabledColor = System.Drawing.Color.Gray
        Me.btnTrangChu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTrangChu.Iconimage = CType(resources.GetObject("btnTrangChu.Iconimage"), System.Drawing.Image)
        Me.btnTrangChu.Iconimage_right = Nothing
        Me.btnTrangChu.Iconimage_right_Selected = Nothing
        Me.btnTrangChu.Iconimage_Selected = Nothing
        Me.btnTrangChu.IconMarginLeft = 0
        Me.btnTrangChu.IconMarginRight = 0
        Me.btnTrangChu.IconRightVisible = True
        Me.btnTrangChu.IconRightZoom = 0R
        Me.btnTrangChu.IconVisible = True
        Me.btnTrangChu.IconZoom = 40.0R
        Me.btnTrangChu.IsTab = False
        Me.btnTrangChu.Location = New System.Drawing.Point(-1, 82)
        Me.btnTrangChu.Name = "btnTrangChu"
        Me.btnTrangChu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTrangChu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnTrangChu.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTrangChu.selected = False
        Me.btnTrangChu.Size = New System.Drawing.Size(241, 48)
        Me.btnTrangChu.TabIndex = 5
        Me.btnTrangChu.Text = "Trang chủ"
        Me.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTrangChu.Textcolor = System.Drawing.Color.White
        Me.btnTrangChu.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'picShow
        '
        Me.picShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.trans1.SetDecoration(Me.picShow, BunifuAnimatorNS.DecorationType.None)
        Me.picShow.Image = CType(resources.GetObject("picShow.Image"), System.Drawing.Image)
        Me.picShow.Location = New System.Drawing.Point(195, 6)
        Me.picShow.Name = "picShow"
        Me.picShow.Size = New System.Drawing.Size(30, 30)
        Me.picShow.TabIndex = 0
        Me.picShow.TabStop = False
        '
        'diChuyen1
        '
        Me.diChuyen1.Fixed = True
        Me.diChuyen1.Horizontal = True
        Me.diChuyen1.TargetControl = Me.pnClose
        Me.diChuyen1.Vertical = True
        '
        'diChuyen2
        '
        Me.diChuyen2.Fixed = True
        Me.diChuyen2.Horizontal = True
        Me.diChuyen2.TargetControl = Me.Title
        Me.diChuyen2.Vertical = True
        '
        'diChuyen3
        '
        Me.diChuyen3.Fixed = True
        Me.diChuyen3.Horizontal = True
        Me.diChuyen3.TargetControl = Me.pnMenu
        Me.diChuyen3.Vertical = True
        '
        'trans1
        '
        Me.trans1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.trans1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.trans1.DefaultAnimation = Animation1
        '
        'FormKhachhang1
        '
        Me.FormKhachhang1.BackColor = System.Drawing.Color.White
        Me.trans1.SetDecoration(Me.FormKhachhang1, BunifuAnimatorNS.DecorationType.None)
        Me.FormKhachhang1.Location = New System.Drawing.Point(241, 39)
        Me.FormKhachhang1.Name = "FormKhachhang1"
        Me.FormKhachhang1.Size = New System.Drawing.Size(1016, 670)
        Me.FormKhachhang1.TabIndex = 5
        '
        'FormHoadon1
        '
        Me.FormHoadon1.BackColor = System.Drawing.Color.White
        Me.trans1.SetDecoration(Me.FormHoadon1, BunifuAnimatorNS.DecorationType.None)
        Me.FormHoadon1.Location = New System.Drawing.Point(241, 39)
        Me.FormHoadon1.Name = "FormHoadon1"
        Me.FormHoadon1.Size = New System.Drawing.Size(1016, 670)
        Me.FormHoadon1.TabIndex = 4
        '
        'FormPhieuNhap1
        '
        Me.FormPhieuNhap1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FormPhieuNhap1.BackColor = System.Drawing.Color.White
        Me.trans1.SetDecoration(Me.FormPhieuNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.FormPhieuNhap1.Location = New System.Drawing.Point(241, 40)
        Me.FormPhieuNhap1.Name = "FormPhieuNhap1"
        Me.FormPhieuNhap1.Size = New System.Drawing.Size(1016, 670)
        Me.FormPhieuNhap1.TabIndex = 8
        '
        'FormNhanvien1
        '
        Me.FormNhanvien1.BackColor = System.Drawing.Color.White
        Me.trans1.SetDecoration(Me.FormNhanvien1, BunifuAnimatorNS.DecorationType.None)
        Me.FormNhanvien1.Location = New System.Drawing.Point(241, 40)
        Me.FormNhanvien1.Name = "FormNhanvien1"
        Me.FormNhanvien1.Size = New System.Drawing.Size(1016, 670)
        Me.FormNhanvien1.TabIndex = 7
        '
        'FormNCC1
        '
        Me.FormNCC1.BackColor = System.Drawing.Color.White
        Me.trans1.SetDecoration(Me.FormNCC1, BunifuAnimatorNS.DecorationType.None)
        Me.FormNCC1.Location = New System.Drawing.Point(241, 40)
        Me.FormNCC1.Name = "FormNCC1"
        Me.FormNCC1.Size = New System.Drawing.Size(1016, 670)
        Me.FormNCC1.TabIndex = 6
        '
        'Formhome1
        '
        Me.Formhome1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.trans1.SetDecoration(Me.Formhome1, BunifuAnimatorNS.DecorationType.None)
        Me.Formhome1.Location = New System.Drawing.Point(241, 39)
        Me.Formhome1.Name = "Formhome1"
        Me.Formhome1.Size = New System.Drawing.Size(1016, 670)
        Me.Formhome1.TabIndex = 3
        '
        'FormBook1
        '
        Me.FormBook1.AllowDrop = True
        Me.FormBook1.AutoScroll = True
        Me.FormBook1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.trans1.SetDecoration(Me.FormBook1, BunifuAnimatorNS.DecorationType.None)
        Me.FormBook1.Location = New System.Drawing.Point(242, 40)
        Me.FormBook1.Name = "FormBook1"
        Me.FormBook1.Size = New System.Drawing.Size(1014, 664)
        Me.FormBook1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1258, 708)
        Me.Controls.Add(Me.FormKhachhang1)
        Me.Controls.Add(Me.FormHoadon1)
        Me.Controls.Add(Me.FormPhieuNhap1)
        Me.Controls.Add(Me.FormNhanvien1)
        Me.Controls.Add(Me.FormNCC1)
        Me.Controls.Add(Me.Formhome1)
        Me.Controls.Add(Me.FormBook1)
        Me.Controls.Add(Me.pnMenu)
        Me.Controls.Add(Me.pnClose)
        Me.trans1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnClose.ResumeLayout(False)
        Me.pnClose.PerformLayout()
        CType(Me.picMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMenu.ResumeLayout(False)
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnClose As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinus As PictureBox
    Friend WithEvents pnMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents picShow As PictureBox
    Friend WithEvents Title As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents diChuyen1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents diChuyen2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents diChuyen3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnHoaDon As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhapSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhacc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhanvien As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnKhachHang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTrangChu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents trans1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents FormBook1 As FormBook
    Friend WithEvents Formhome1 As Formhome
    Friend WithEvents FormPhieuNhap1 As FormPhieuNhap
    Friend WithEvents FormNhanvien1 As FormNhanvien
    Friend WithEvents FormNCC1 As FormNCC
    Friend WithEvents FormKhachhang1 As FormKhachhang
    Friend WithEvents FormHoadon1 As FormHoadon
End Class
