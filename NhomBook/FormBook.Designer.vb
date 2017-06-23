<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBook))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.separator = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnSach = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnTacgia = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnTheloai = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbTacgia = New System.Windows.Forms.ComboBox()
        Me.txtMaSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTenSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDongia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTimKiem = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbSoluongSach = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnthem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lbMasach = New System.Windows.Forms.Label()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.lbSoluong = New System.Windows.Forms.Label()
        Me.lbDongia = New System.Windows.Forms.Label()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.txtSoluongton = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtNXB = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lbNXB = New System.Windows.Forms.Label()
        Me.btnDelSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.FormTacgia1 = New NhomBook.FormTacgia()
        Me.FormTheLoai1 = New NhomBook.FormTheLoai()
        Me.panelTop.SuspendLayout()
        CType(Me.dgSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.White
        Me.panelTop.BackgroundImage = CType(resources.GetObject("panelTop.BackgroundImage"), System.Drawing.Image)
        Me.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelTop.Controls.Add(Me.separator)
        Me.panelTop.Controls.Add(Me.btnSach)
        Me.panelTop.Controls.Add(Me.btnTacgia)
        Me.panelTop.Controls.Add(Me.btnTheloai)
        Me.panelTop.GradientBottomLeft = System.Drawing.Color.White
        Me.panelTop.GradientBottomRight = System.Drawing.Color.White
        Me.panelTop.GradientTopLeft = System.Drawing.Color.White
        Me.panelTop.GradientTopRight = System.Drawing.Color.White
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Quality = 10
        Me.panelTop.Size = New System.Drawing.Size(1014, 65)
        Me.panelTop.TabIndex = 0
        '
        'separator
        '
        Me.separator.BackColor = System.Drawing.Color.Transparent
        Me.separator.ForeColor = System.Drawing.Color.Aqua
        Me.separator.LineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.separator.LineThickness = 5
        Me.separator.Location = New System.Drawing.Point(25, 46)
        Me.separator.Name = "separator"
        Me.separator.Size = New System.Drawing.Size(50, 13)
        Me.separator.TabIndex = 4
        Me.separator.Transparency = 255
        Me.separator.Vertical = False
        '
        'btnSach
        '
        Me.btnSach.BackColor = System.Drawing.Color.White
        Me.btnSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSach.Location = New System.Drawing.Point(23, 23)
        Me.btnSach.Name = "btnSach"
        Me.btnSach.Size = New System.Drawing.Size(52, 36)
        Me.btnSach.TabIndex = 0
        Me.btnSach.Text = "Sách"
        Me.btnSach.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTacgia
        '
        Me.btnTacgia.BackColor = System.Drawing.Color.White
        Me.btnTacgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTacgia.Location = New System.Drawing.Point(97, 23)
        Me.btnTacgia.Name = "btnTacgia"
        Me.btnTacgia.Size = New System.Drawing.Size(72, 36)
        Me.btnTacgia.TabIndex = 5
        Me.btnTacgia.Text = "Tác giả"
        Me.btnTacgia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTheloai
        '
        Me.btnTheloai.BackColor = System.Drawing.Color.White
        Me.btnTheloai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTheloai.Location = New System.Drawing.Point(198, 23)
        Me.btnTheloai.Name = "btnTheloai"
        Me.btnTheloai.Size = New System.Drawing.Size(76, 36)
        Me.btnTheloai.TabIndex = 6
        Me.btnTheloai.Text = "Thể loại"
        Me.btnTheloai.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgSach
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSach.DoubleBuffered = True
        Me.dgSach.EnableHeadersVisualStyles = False
        Me.dgSach.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgSach.HeaderForeColor = System.Drawing.Color.White
        Me.dgSach.Location = New System.Drawing.Point(420, 133)
        Me.dgSach.Name = "dgSach"
        Me.dgSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSach.Size = New System.Drawing.Size(541, 488)
        Me.dgSach.TabIndex = 1
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(27, 84)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(48, 13)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Mã sách"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(31, 348)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(44, 13)
        Me.BunifuCustomLabel5.TabIndex = 3
        Me.BunifuCustomLabel5.Text = "Nhà XB"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(26, 299)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(45, 13)
        Me.BunifuCustomLabel6.TabIndex = 4
        Me.BunifuCustomLabel6.Text = "Thể loại"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(27, 253)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(43, 13)
        Me.BunifuCustomLabel7.TabIndex = 5
        Me.BunifuCustomLabel7.Text = "Tác giả"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(27, 146)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(52, 13)
        Me.BunifuCustomLabel8.TabIndex = 6
        Me.BunifuCustomLabel8.Text = "Tên sách"
        '
        'cbTacgia
        '
        Me.cbTacgia.FormattingEnabled = True
        Me.cbTacgia.Location = New System.Drawing.Point(85, 250)
        Me.cbTacgia.Name = "cbTacgia"
        Me.cbTacgia.Size = New System.Drawing.Size(306, 21)
        Me.cbTacgia.TabIndex = 11
        '
        'txtMaSach
        '
        Me.txtMaSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMaSach.Location = New System.Drawing.Point(85, 81)
        Me.txtMaSach.Multiline = True
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(306, 34)
        Me.txtMaSach.TabIndex = 12
        '
        'txtTenSach
        '
        Me.txtTenSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTenSach.Location = New System.Drawing.Point(85, 143)
        Me.txtTenSach.Multiline = True
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(306, 78)
        Me.txtTenSach.TabIndex = 13
        '
        'cbTheLoai
        '
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(85, 296)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(306, 21)
        Me.cbTheLoai.TabIndex = 14
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(31, 412)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(49, 13)
        Me.BunifuCustomLabel9.TabIndex = 16
        Me.BunifuCustomLabel9.Text = "Số lượng"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(35, 477)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(44, 13)
        Me.BunifuCustomLabel10.TabIndex = 17
        Me.BunifuCustomLabel10.Text = "Đơn giá"
        '
        'txtDongia
        '
        Me.txtDongia.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtDongia.Location = New System.Drawing.Point(85, 474)
        Me.txtDongia.Multiline = True
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(306, 34)
        Me.txtDongia.TabIndex = 19
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(41, 495)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(30, 13)
        Me.BunifuCustomLabel11.TabIndex = 22
        Me.BunifuCustomLabel11.Text = "VNĐ"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimKiem.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTimKiem.HintForeColor = System.Drawing.Color.Gray
        Me.txtTimKiem.HintText = "Tìm kiếm"
        Me.txtTimKiem.isPassword = False
        Me.txtTimKiem.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTimKiem.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTimKiem.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTimKiem.LineThickness = 3
        Me.txtTimKiem.Location = New System.Drawing.Point(558, 67)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(370, 44)
        Me.txtTimKiem.TabIndex = 23
        Me.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(417, 98)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(71, 13)
        Me.BunifuCustomLabel12.TabIndex = 24
        Me.BunifuCustomLabel12.Text = "Số đầu sách:"
        '
        'lbSoluongSach
        '
        Me.lbSoluongSach.AutoSize = True
        Me.lbSoluongSach.Location = New System.Drawing.Point(485, 98)
        Me.lbSoluongSach.Name = "lbSoluongSach"
        Me.lbSoluongSach.Size = New System.Drawing.Size(19, 13)
        Me.lbSoluongSach.TabIndex = 25
        Me.lbSoluongSach.Text = "12"
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnthem.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnthem.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnthem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnthem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.Black
        Me.btnthem.Image = CType(resources.GetObject("btnthem.Image"), System.Drawing.Image)
        Me.btnthem.ImagePosition = 0
        Me.btnthem.ImageZoom = 40
        Me.btnthem.LabelPosition = 20
        Me.btnthem.LabelText = "Thêm"
        Me.btnthem.Location = New System.Drawing.Point(332, 546)
        Me.btnthem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(59, 50)
        Me.btnthem.TabIndex = 49
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
        Me.btnXoa.Location = New System.Drawing.Point(238, 546)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 50
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
        Me.btnUpdate.Location = New System.Drawing.Point(141, 546)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 51
        '
        'lbMasach
        '
        Me.lbMasach.AutoSize = True
        Me.lbMasach.Location = New System.Drawing.Point(98, 117)
        Me.lbMasach.Name = "lbMasach"
        Me.lbMasach.Size = New System.Drawing.Size(19, 13)
        Me.lbMasach.TabIndex = 54
        Me.lbMasach.Text = "aa"
        Me.lbMasach.Visible = False
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(98, 224)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(19, 13)
        Me.lbTenSach.TabIndex = 55
        Me.lbTenSach.Text = "aa"
        Me.lbTenSach.Visible = False
        '
        'lbSoluong
        '
        Me.lbSoluong.AutoSize = True
        Me.lbSoluong.Location = New System.Drawing.Point(98, 446)
        Me.lbSoluong.Name = "lbSoluong"
        Me.lbSoluong.Size = New System.Drawing.Size(19, 13)
        Me.lbSoluong.TabIndex = 56
        Me.lbSoluong.Text = "aa"
        Me.lbSoluong.Visible = False
        '
        'lbDongia
        '
        Me.lbDongia.AutoSize = True
        Me.lbDongia.Location = New System.Drawing.Point(98, 511)
        Me.lbDongia.Name = "lbDongia"
        Me.lbDongia.Size = New System.Drawing.Size(19, 13)
        Me.lbDongia.TabIndex = 57
        Me.lbDongia.Text = "aa"
        Me.lbDongia.Visible = False
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
        Me.btnNew.Location = New System.Drawing.Point(44, 546)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 58
        '
        'txtSoluongton
        '
        Me.txtSoluongton.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSoluongton.Location = New System.Drawing.Point(85, 409)
        Me.txtSoluongton.Multiline = True
        Me.txtSoluongton.Name = "txtSoluongton"
        Me.txtSoluongton.Size = New System.Drawing.Size(306, 34)
        Me.txtSoluongton.TabIndex = 18
        '
        'txtNXB
        '
        Me.txtNXB.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNXB.Location = New System.Drawing.Point(85, 345)
        Me.txtNXB.Multiline = True
        Me.txtNXB.Name = "txtNXB"
        Me.txtNXB.Size = New System.Drawing.Size(306, 34)
        Me.txtNXB.TabIndex = 59
        '
        'lbNXB
        '
        Me.lbNXB.AutoSize = True
        Me.lbNXB.Location = New System.Drawing.Point(98, 382)
        Me.lbNXB.Name = "lbNXB"
        Me.lbNXB.Size = New System.Drawing.Size(19, 13)
        Me.lbNXB.TabIndex = 60
        Me.lbNXB.Text = "aa"
        Me.lbNXB.Visible = False
        '
        'btnDelSearch
        '
        Me.btnDelSearch.BackColor = System.Drawing.Color.White
        Me.btnDelSearch.Image = CType(resources.GetObject("btnDelSearch.Image"), System.Drawing.Image)
        Me.btnDelSearch.ImageActive = CType(resources.GetObject("btnDelSearch.ImageActive"), System.Drawing.Image)
        Me.btnDelSearch.Location = New System.Drawing.Point(931, 81)
        Me.btnDelSearch.Name = "btnDelSearch"
        Me.btnDelSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnDelSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDelSearch.TabIndex = 66
        Me.btnDelSearch.TabStop = False
        Me.btnDelSearch.Zoom = 10
        '
        'FormTacgia1
        '
        Me.FormTacgia1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FormTacgia1.Location = New System.Drawing.Point(0, 65)
        Me.FormTacgia1.Name = "FormTacgia1"
        Me.FormTacgia1.Size = New System.Drawing.Size(1014, 596)
        Me.FormTacgia1.TabIndex = 68
        '
        'FormTheLoai1
        '
        Me.FormTheLoai1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FormTheLoai1.Location = New System.Drawing.Point(0, 65)
        Me.FormTheLoai1.Name = "FormTheLoai1"
        Me.FormTheLoai1.Size = New System.Drawing.Size(1014, 596)
        Me.FormTheLoai1.TabIndex = 67
        '
        'FormBook
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.FormTheLoai1)
        Me.Controls.Add(Me.FormTacgia1)
        Me.Controls.Add(Me.btnDelSearch)
        Me.Controls.Add(Me.lbNXB)
        Me.Controls.Add(Me.txtNXB)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lbDongia)
        Me.Controls.Add(Me.lbSoluong)
        Me.Controls.Add(Me.lbTenSach)
        Me.Controls.Add(Me.lbMasach)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.lbSoluongSach)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.txtSoluongton)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.cbTheLoai)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.cbTacgia)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgSach)
        Me.Controls.Add(Me.panelTop)
        Me.Name = "FormBook"
        Me.Size = New System.Drawing.Size(878, 528)
        Me.panelTop.ResumeLayout(False)
        CType(Me.dgSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnSach As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents separator As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents dgSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbTacgia As ComboBox
    Friend WithEvents txtMaSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtTenSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDongia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTimKiem As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbSoluongSach As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnTheloai As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnTacgia As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnthem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lbMasach As Label
    Friend WithEvents lbTenSach As Label
    Friend WithEvents lbSoluong As Label
    Friend WithEvents lbDongia As Label
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents txtSoluongton As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtNXB As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lbNXB As Label
    Friend WithEvents btnDelSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents FormTacgia1 As FormTacgia
    Friend WithEvents FormTheLoai1 As FormTheLoai
End Class
