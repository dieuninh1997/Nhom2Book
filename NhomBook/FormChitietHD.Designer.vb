<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChitietHD
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChitietHD))
        Me.dgChitietHd = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbMaHD = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMaHdCthd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtManvCthd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMakhCthd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtNgaybanCthd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTongtienCthd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnInHd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txtMaHD = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtSoluong = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbMaSach = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbDvt = New System.Windows.Forms.ComboBox()
        CType(Me.dgChitietHd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgChitietHd
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgChitietHd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgChitietHd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgChitietHd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgChitietHd.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgChitietHd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgChitietHd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgChitietHd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgChitietHd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgChitietHd.DoubleBuffered = True
        Me.dgChitietHd.EnableHeadersVisualStyles = False
        Me.dgChitietHd.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgChitietHd.HeaderForeColor = System.Drawing.Color.White
        Me.dgChitietHd.Location = New System.Drawing.Point(45, 240)
        Me.dgChitietHd.Name = "dgChitietHd"
        Me.dgChitietHd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgChitietHd.Size = New System.Drawing.Size(632, 389)
        Me.dgChitietHd.TabIndex = 2
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(50, 41)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(124, 21)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Chi tiết hóa đơn:"
        '
        'lbMaHD
        '
        Me.lbMaHD.AutoSize = True
        Me.lbMaHD.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbMaHD.Location = New System.Drawing.Point(180, 41)
        Me.lbMaHD.Name = "lbMaHD"
        Me.lbMaHD.Size = New System.Drawing.Size(63, 25)
        Me.lbMaHD.TabIndex = 4
        Me.lbMaHD.Text = "HD01"
        '
        'picExit
        '
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(980, 11)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(24, 24)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExit.TabIndex = 17
        Me.picExit.TabStop = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(8, 13)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(65, 13)
        Me.BunifuCustomLabel3.TabIndex = 18
        Me.BunifuCustomLabel3.Text = "Mã hóa đơn"
        '
        'txtMaHdCthd
        '
        Me.txtMaHdCthd.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMaHdCthd.Enabled = False
        Me.txtMaHdCthd.Location = New System.Drawing.Point(11, 29)
        Me.txtMaHdCthd.Multiline = True
        Me.txtMaHdCthd.Name = "txtMaHdCthd"
        Me.txtMaHdCthd.Size = New System.Drawing.Size(250, 39)
        Me.txtMaHdCthd.TabIndex = 19
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(8, 87)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 13)
        Me.BunifuCustomLabel4.TabIndex = 20
        Me.BunifuCustomLabel4.Text = "Mã nhân viên"
        '
        'txtManvCthd
        '
        Me.txtManvCthd.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtManvCthd.Enabled = False
        Me.txtManvCthd.Location = New System.Drawing.Point(11, 103)
        Me.txtManvCthd.Multiline = True
        Me.txtManvCthd.Name = "txtManvCthd"
        Me.txtManvCthd.Size = New System.Drawing.Size(250, 39)
        Me.txtManvCthd.TabIndex = 21
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(9, 315)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(52, 13)
        Me.BunifuCustomLabel5.TabIndex = 22
        Me.BunifuCustomLabel5.Text = "Tổng tiền"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(8, 240)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(53, 13)
        Me.BunifuCustomLabel6.TabIndex = 23
        Me.BunifuCustomLabel6.Text = "Ngày bán"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(8, 165)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(82, 13)
        Me.BunifuCustomLabel7.TabIndex = 24
        Me.BunifuCustomLabel7.Text = "Mã khách hàng"
        '
        'txtMakhCthd
        '
        Me.txtMakhCthd.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMakhCthd.Enabled = False
        Me.txtMakhCthd.Location = New System.Drawing.Point(11, 181)
        Me.txtMakhCthd.Multiline = True
        Me.txtMakhCthd.Name = "txtMakhCthd"
        Me.txtMakhCthd.Size = New System.Drawing.Size(250, 39)
        Me.txtMakhCthd.TabIndex = 25
        '
        'txtNgaybanCthd
        '
        Me.txtNgaybanCthd.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNgaybanCthd.Enabled = False
        Me.txtNgaybanCthd.Location = New System.Drawing.Point(11, 256)
        Me.txtNgaybanCthd.Multiline = True
        Me.txtNgaybanCthd.Name = "txtNgaybanCthd"
        Me.txtNgaybanCthd.Size = New System.Drawing.Size(250, 39)
        Me.txtNgaybanCthd.TabIndex = 26
        '
        'txtTongtienCthd
        '
        Me.txtTongtienCthd.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTongtienCthd.Enabled = False
        Me.txtTongtienCthd.Location = New System.Drawing.Point(11, 331)
        Me.txtTongtienCthd.Multiline = True
        Me.txtTongtienCthd.Name = "txtTongtienCthd"
        Me.txtTongtienCthd.Size = New System.Drawing.Size(250, 39)
        Me.txtTongtienCthd.TabIndex = 27
        '
        'btnInHd
        '
        Me.btnInHd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnInHd.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInHd.BorderRadius = 0
        Me.btnInHd.ButtonText = "In hóa đơn (Excel)"
        Me.btnInHd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInHd.DisabledColor = System.Drawing.Color.Gray
        Me.btnInHd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInHd.Iconimage = CType(resources.GetObject("btnInHd.Iconimage"), System.Drawing.Image)
        Me.btnInHd.Iconimage_right = Nothing
        Me.btnInHd.Iconimage_right_Selected = Nothing
        Me.btnInHd.Iconimage_Selected = Nothing
        Me.btnInHd.IconMarginLeft = 0
        Me.btnInHd.IconMarginRight = 0
        Me.btnInHd.IconRightVisible = True
        Me.btnInHd.IconRightZoom = 0R
        Me.btnInHd.IconVisible = True
        Me.btnInHd.IconZoom = 40.0R
        Me.btnInHd.IsTab = False
        Me.btnInHd.Location = New System.Drawing.Point(700, 581)
        Me.btnInHd.Name = "btnInHd"
        Me.btnInHd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInHd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnInHd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnInHd.selected = False
        Me.btnInHd.Size = New System.Drawing.Size(272, 48)
        Me.btnInHd.TabIndex = 28
        Me.btnInHd.Text = "In hóa đơn (Excel)"
        Me.btnInHd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnInHd.Textcolor = System.Drawing.Color.White
        Me.btnInHd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtMaHdCthd)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtManvCthd)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtTongtienCthd)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtMakhCthd)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtNgaybanCthd)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(700, 69)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(272, 389)
        Me.BunifuGradientPanel1.TabIndex = 29
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
        Me.btnThem.Location = New System.Drawing.Point(842, 510)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 83
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
        Me.btnXoa.Location = New System.Drawing.Point(771, 510)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 84
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
        Me.btnUpdate.Location = New System.Drawing.Point(700, 510)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 85
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
        Me.btnNew.Location = New System.Drawing.Point(913, 510)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 86
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.txtMaHD)
        Me.BunifuGradientPanel3.Controls.Add(Me.txtSoluong)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel10)
        Me.BunifuGradientPanel3.Controls.Add(Me.cbMaSach)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel12)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel13)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel14)
        Me.BunifuGradientPanel3.Controls.Add(Me.cbDvt)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(45, 69)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(632, 142)
        Me.BunifuGradientPanel3.TabIndex = 87
        '
        'txtMaHD
        '
        Me.txtMaHD.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMaHD.Enabled = False
        Me.txtMaHD.Location = New System.Drawing.Point(20, 30)
        Me.txtMaHD.Multiline = True
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(302, 35)
        Me.txtMaHD.TabIndex = 40
        '
        'txtSoluong
        '
        Me.txtSoluong.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSoluong.Location = New System.Drawing.Point(20, 90)
        Me.txtSoluong.Multiline = True
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(302, 35)
        Me.txtSoluong.TabIndex = 35
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(17, 74)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(49, 13)
        Me.BunifuCustomLabel10.TabIndex = 34
        Me.BunifuCustomLabel10.Text = "Số lượng"
        '
        'cbMaSach
        '
        Me.cbMaSach.FormattingEnabled = True
        Me.cbMaSach.Location = New System.Drawing.Point(340, 30)
        Me.cbMaSach.Name = "cbMaSach"
        Me.cbMaSach.Size = New System.Drawing.Size(269, 21)
        Me.cbMaSach.TabIndex = 36
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(17, 14)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(65, 13)
        Me.BunifuCustomLabel12.TabIndex = 30
        Me.BunifuCustomLabel12.Text = "Mã hóa đơn"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(339, 14)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(48, 13)
        Me.BunifuCustomLabel13.TabIndex = 32
        Me.BunifuCustomLabel13.Text = "Mã sách"
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(339, 74)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(60, 13)
        Me.BunifuCustomLabel14.TabIndex = 38
        Me.BunifuCustomLabel14.Text = "Đơn vị tính"
        '
        'cbDvt
        '
        Me.cbDvt.FormattingEnabled = True
        Me.cbDvt.Location = New System.Drawing.Point(340, 90)
        Me.cbDvt.Name = "cbDvt"
        Me.cbDvt.Size = New System.Drawing.Size(269, 21)
        Me.cbDvt.TabIndex = 39
        '
        'FormChitietHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnInHd)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lbMaHD)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.dgChitietHd)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Name = "FormChitietHD"
        Me.Size = New System.Drawing.Size(1016, 670)
        CType(Me.dgChitietHd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgChitietHd As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbMaHD As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMaHdCthd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtManvCthd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMakhCthd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtNgaybanCthd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtTongtienCthd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnInHd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txtMaHD As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtSoluong As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbMaSach As ComboBox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbDvt As ComboBox
End Class
