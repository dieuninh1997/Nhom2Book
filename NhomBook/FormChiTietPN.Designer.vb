<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChiTietPN
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChiTietPN))
        Me.dgChitietPn = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbMapn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnInPn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtMapnCtpn = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtManvCtpn = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtManccCtpn = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtNgNhapCtpn = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTongTienCtpn = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txtDvt = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtSoLuong = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtMaSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtGiaNhap = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.dgChitietPn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgChitietPn
        '
        Me.dgChitietPn.AllowUserToAddRows = False
        Me.dgChitietPn.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgChitietPn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgChitietPn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgChitietPn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgChitietPn.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgChitietPn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgChitietPn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgChitietPn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgChitietPn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgChitietPn.DoubleBuffered = True
        Me.dgChitietPn.EnableHeadersVisualStyles = False
        Me.dgChitietPn.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgChitietPn.HeaderForeColor = System.Drawing.Color.White
        Me.dgChitietPn.Location = New System.Drawing.Point(43, 242)
        Me.dgChitietPn.Name = "dgChitietPn"
        Me.dgChitietPn.ReadOnly = True
        Me.dgChitietPn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgChitietPn.Size = New System.Drawing.Size(647, 376)
        Me.dgChitietPn.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(42, 46)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(148, 21)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Chi tiết phiếu nhập :"
        '
        'lbMapn
        '
        Me.lbMapn.AutoSize = True
        Me.lbMapn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMapn.Location = New System.Drawing.Point(216, 46)
        Me.lbMapn.Name = "lbMapn"
        Me.lbMapn.Size = New System.Drawing.Size(0, 21)
        Me.lbMapn.TabIndex = 3
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(715, 93)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(78, 13)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "Mã phiếu nhập"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(715, 167)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 13)
        Me.BunifuCustomLabel4.TabIndex = 5
        Me.BunifuCustomLabel4.Text = "Mã nhân viên"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(715, 242)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(91, 13)
        Me.BunifuCustomLabel5.TabIndex = 6
        Me.BunifuCustomLabel5.Text = "Mã nhà cung cấp"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(715, 311)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(59, 13)
        Me.BunifuCustomLabel6.TabIndex = 7
        Me.BunifuCustomLabel6.Text = "Ngày nhập"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(715, 380)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(84, 13)
        Me.BunifuCustomLabel7.TabIndex = 8
        Me.BunifuCustomLabel7.Text = "Tổng tiền (VNĐ)"
        '
        'btnInPn
        '
        Me.btnInPn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnInPn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInPn.BorderRadius = 0
        Me.btnInPn.ButtonText = "In phiếu nhập (Excel)"
        Me.btnInPn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInPn.DisabledColor = System.Drawing.Color.Gray
        Me.btnInPn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInPn.Iconimage = CType(resources.GetObject("btnInPn.Iconimage"), System.Drawing.Image)
        Me.btnInPn.Iconimage_right = Nothing
        Me.btnInPn.Iconimage_right_Selected = Nothing
        Me.btnInPn.Iconimage_Selected = Nothing
        Me.btnInPn.IconMarginLeft = 0
        Me.btnInPn.IconMarginRight = 0
        Me.btnInPn.IconRightVisible = True
        Me.btnInPn.IconRightZoom = 0R
        Me.btnInPn.IconVisible = True
        Me.btnInPn.IconZoom = 40.0R
        Me.btnInPn.IsTab = False
        Me.btnInPn.Location = New System.Drawing.Point(708, 570)
        Me.btnInPn.Name = "btnInPn"
        Me.btnInPn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInPn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnInPn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnInPn.selected = False
        Me.btnInPn.Size = New System.Drawing.Size(272, 48)
        Me.btnInPn.TabIndex = 10
        Me.btnInPn.Text = "In phiếu nhập (Excel)"
        Me.btnInPn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnInPn.Textcolor = System.Drawing.Color.White
        Me.btnInPn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtMapnCtpn
        '
        Me.txtMapnCtpn.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMapnCtpn.Enabled = False
        Me.txtMapnCtpn.Location = New System.Drawing.Point(718, 109)
        Me.txtMapnCtpn.Multiline = True
        Me.txtMapnCtpn.Name = "txtMapnCtpn"
        Me.txtMapnCtpn.Size = New System.Drawing.Size(250, 39)
        Me.txtMapnCtpn.TabIndex = 11
        '
        'txtManvCtpn
        '
        Me.txtManvCtpn.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtManvCtpn.Enabled = False
        Me.txtManvCtpn.Location = New System.Drawing.Point(718, 183)
        Me.txtManvCtpn.Multiline = True
        Me.txtManvCtpn.Name = "txtManvCtpn"
        Me.txtManvCtpn.Size = New System.Drawing.Size(250, 39)
        Me.txtManvCtpn.TabIndex = 12
        '
        'txtManccCtpn
        '
        Me.txtManccCtpn.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtManccCtpn.Enabled = False
        Me.txtManccCtpn.Location = New System.Drawing.Point(718, 258)
        Me.txtManccCtpn.Multiline = True
        Me.txtManccCtpn.Name = "txtManccCtpn"
        Me.txtManccCtpn.Size = New System.Drawing.Size(250, 39)
        Me.txtManccCtpn.TabIndex = 13
        '
        'txtNgNhapCtpn
        '
        Me.txtNgNhapCtpn.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNgNhapCtpn.Enabled = False
        Me.txtNgNhapCtpn.Location = New System.Drawing.Point(718, 327)
        Me.txtNgNhapCtpn.Multiline = True
        Me.txtNgNhapCtpn.Name = "txtNgNhapCtpn"
        Me.txtNgNhapCtpn.Size = New System.Drawing.Size(250, 39)
        Me.txtNgNhapCtpn.TabIndex = 14
        '
        'txtTongTienCtpn
        '
        Me.txtTongTienCtpn.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTongTienCtpn.Enabled = False
        Me.txtTongTienCtpn.Location = New System.Drawing.Point(718, 396)
        Me.txtTongTienCtpn.Multiline = True
        Me.txtTongTienCtpn.Name = "txtTongTienCtpn"
        Me.txtTongTienCtpn.Size = New System.Drawing.Size(250, 39)
        Me.txtTongTienCtpn.TabIndex = 15
        '
        'picExit
        '
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(976, 13)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(24, 24)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExit.TabIndex = 16
        Me.picExit.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(708, 69)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(272, 389)
        Me.BunifuGradientPanel1.TabIndex = 17
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.txtDvt)
        Me.BunifuGradientPanel3.Controls.Add(Me.txtSoLuong)
        Me.BunifuGradientPanel3.Controls.Add(Me.txtMaSach)
        Me.BunifuGradientPanel3.Controls.Add(Me.txtGiaNhap)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel10)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel12)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel13)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel14)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(43, 70)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(647, 152)
        Me.BunifuGradientPanel3.TabIndex = 88
        '
        'txtDvt
        '
        Me.txtDvt.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtDvt.Location = New System.Drawing.Point(339, 90)
        Me.txtDvt.Multiline = True
        Me.txtDvt.Name = "txtDvt"
        Me.txtDvt.Size = New System.Drawing.Size(283, 35)
        Me.txtDvt.TabIndex = 42
        '
        'txtSoLuong
        '
        Me.txtSoLuong.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSoLuong.Location = New System.Drawing.Point(339, 30)
        Me.txtSoLuong.Multiline = True
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(283, 35)
        Me.txtSoLuong.TabIndex = 41
        '
        'txtMaSach
        '
        Me.txtMaSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMaSach.Location = New System.Drawing.Point(25, 30)
        Me.txtMaSach.Multiline = True
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(283, 35)
        Me.txtMaSach.TabIndex = 40
        '
        'txtGiaNhap
        '
        Me.txtGiaNhap.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtGiaNhap.Location = New System.Drawing.Point(25, 89)
        Me.txtGiaNhap.Multiline = True
        Me.txtGiaNhap.Name = "txtGiaNhap"
        Me.txtGiaNhap.Size = New System.Drawing.Size(283, 35)
        Me.txtGiaNhap.TabIndex = 35
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(26, 74)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(114, 13)
        Me.BunifuCustomLabel10.TabIndex = 34
        Me.BunifuCustomLabel10.Text = "Giá nhập ( nghìn VNĐ)"
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(26, 14)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(48, 13)
        Me.BunifuCustomLabel12.TabIndex = 30
        Me.BunifuCustomLabel12.Text = "Mã sách"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(342, 14)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(49, 13)
        Me.BunifuCustomLabel13.TabIndex = 32
        Me.BunifuCustomLabel13.Text = "Số lượng"
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(340, 74)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(60, 13)
        Me.BunifuCustomLabel14.TabIndex = 38
        Me.BunifuCustomLabel14.Text = "Đơn vị tính"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImagePosition = 5
        Me.btnUpdate.ImageZoom = 30
        Me.btnUpdate.LabelPosition = 20
        Me.btnUpdate.LabelText = "Update"
        Me.btnUpdate.Location = New System.Drawing.Point(708, 496)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 86
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnXoa.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnXoa.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Black
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImagePosition = 5
        Me.btnXoa.ImageZoom = 40
        Me.btnXoa.LabelPosition = 20
        Me.btnXoa.LabelText = "Xóa"
        Me.btnXoa.Location = New System.Drawing.Point(779, 496)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 87
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.Black
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImagePosition = 0
        Me.btnThem.ImageZoom = 40
        Me.btnThem.LabelPosition = 20
        Me.btnThem.LabelText = "Thêm"
        Me.btnThem.Location = New System.Drawing.Point(850, 496)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 88
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNew.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNew.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImagePosition = 5
        Me.btnNew.ImageZoom = 40
        Me.btnNew.LabelPosition = 20
        Me.btnNew.LabelText = "New"
        Me.btnNew.Location = New System.Drawing.Point(921, 496)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 89
        '
        'FormChiTietPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.txtTongTienCtpn)
        Me.Controls.Add(Me.txtNgNhapCtpn)
        Me.Controls.Add(Me.txtManccCtpn)
        Me.Controls.Add(Me.txtManvCtpn)
        Me.Controls.Add(Me.txtMapnCtpn)
        Me.Controls.Add(Me.btnInPn)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.lbMapn)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.dgChitietPn)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormChiTietPN"
        Me.Size = New System.Drawing.Size(1016, 670)
        CType(Me.dgChitietPn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgChitietPn As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbMapn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnInPn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtMapnCtpn As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtManvCtpn As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtManccCtpn As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtNgNhapCtpn As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtTongTienCtpn As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents picExit As PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txtMaSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtGiaNhap As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents txtDvt As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtSoLuong As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
