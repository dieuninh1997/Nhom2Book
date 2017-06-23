<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPhieuNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPhieuNhap))
        Me.dgPhieuNhap = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.txtTimKiem = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMapn = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTongtien = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbMancc = New System.Windows.Forms.ComboBox()
        Me.cbManv = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpNgaynhap = New System.Windows.Forms.DateTimePicker()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDetail = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lbMapn = New System.Windows.Forms.Label()
        Me.lbNgaynhap = New System.Windows.Forms.Label()
        Me.lbTongtien = New System.Windows.Forms.Label()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbSoluongPhieuNhap = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnExcel = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.FormChiTietPN1 = New NhomBook.FormChiTietPN()
        CType(Me.dgPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPhieuNhap
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgPhieuNhap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPhieuNhap.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPhieuNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPhieuNhap.DoubleBuffered = True
        Me.dgPhieuNhap.EnableHeadersVisualStyles = False
        Me.dgPhieuNhap.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgPhieuNhap.HeaderForeColor = System.Drawing.Color.White
        Me.dgPhieuNhap.Location = New System.Drawing.Point(424, 80)
        Me.dgPhieuNhap.Name = "dgPhieuNhap"
        Me.dgPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPhieuNhap.Size = New System.Drawing.Size(537, 539)
        Me.dgPhieuNhap.TabIndex = 3
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
        Me.txtTimKiem.Location = New System.Drawing.Point(40, 38)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(336, 44)
        Me.txtTimKiem.TabIndex = 25
        Me.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(37, 144)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(76, 13)
        Me.BunifuCustomLabel2.TabIndex = 26
        Me.BunifuCustomLabel2.Text = "Số phiếu nhập"
        '
        'txtMapn
        '
        Me.txtMapn.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMapn.Location = New System.Drawing.Point(124, 141)
        Me.txtMapn.Multiline = True
        Me.txtMapn.Name = "txtMapn"
        Me.txtMapn.Size = New System.Drawing.Size(278, 34)
        Me.txtMapn.TabIndex = 27
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(41, 210)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(72, 13)
        Me.BunifuCustomLabel1.TabIndex = 28
        Me.BunifuCustomLabel1.Text = "Mã nhân viên"
        '
        'txtTongtien
        '
        Me.txtTongtien.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTongtien.Location = New System.Drawing.Point(124, 313)
        Me.txtTongtien.Multiline = True
        Me.txtTongtien.Name = "txtTongtien"
        Me.txtTongtien.Size = New System.Drawing.Size(278, 34)
        Me.txtTongtien.TabIndex = 29
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(50, 264)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(47, 13)
        Me.BunifuCustomLabel3.TabIndex = 30
        Me.BunifuCustomLabel3.Text = "Mã NCC"
        '
        'cbMancc
        '
        Me.cbMancc.FormattingEnabled = True
        Me.cbMancc.Location = New System.Drawing.Point(124, 261)
        Me.cbMancc.Name = "cbMancc"
        Me.cbMancc.Size = New System.Drawing.Size(278, 21)
        Me.cbMancc.TabIndex = 32
        '
        'cbManv
        '
        Me.cbManv.FormattingEnabled = True
        Me.cbManv.Location = New System.Drawing.Point(124, 207)
        Me.cbManv.Name = "cbManv"
        Me.cbManv.Size = New System.Drawing.Size(278, 21)
        Me.cbManv.TabIndex = 33
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(45, 313)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(52, 26)
        Me.BunifuCustomLabel4.TabIndex = 34
        Me.BunifuCustomLabel4.Text = "Tổng tiền" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(VNĐ)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(45, 391)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(59, 13)
        Me.BunifuCustomLabel5.TabIndex = 35
        Me.BunifuCustomLabel5.Text = "Ngày nhập"
        '
        'dtpNgaynhap
        '
        Me.dtpNgaynhap.Location = New System.Drawing.Point(124, 388)
        Me.dtpNgaynhap.Name = "dtpNgaynhap"
        Me.dtpNgaynhap.Size = New System.Drawing.Size(278, 20)
        Me.dtpNgaynhap.TabIndex = 36
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
        Me.btnXoa.Location = New System.Drawing.Point(185, 464)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 43
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
        Me.btnThem.Location = New System.Drawing.Point(280, 544)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 44
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
        Me.btnUpdate.Location = New System.Drawing.Point(89, 464)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 45
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDetail.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDetail.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetail.ForeColor = System.Drawing.Color.Black
        Me.btnDetail.Image = CType(resources.GetObject("btnDetail.Image"), System.Drawing.Image)
        Me.btnDetail.ImagePosition = 5
        Me.btnDetail.ImageZoom = 40
        Me.btnDetail.LabelPosition = 20
        Me.btnDetail.LabelText = "Detail"
        Me.btnDetail.Location = New System.Drawing.Point(185, 544)
        Me.btnDetail.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(59, 50)
        Me.btnDetail.TabIndex = 46
        '
        'lbMapn
        '
        Me.lbMapn.AutoSize = True
        Me.lbMapn.Location = New System.Drawing.Point(129, 178)
        Me.lbMapn.Name = "lbMapn"
        Me.lbMapn.Size = New System.Drawing.Size(19, 13)
        Me.lbMapn.TabIndex = 61
        Me.lbMapn.Text = "aa"
        Me.lbMapn.Visible = False
        '
        'lbNgaynhap
        '
        Me.lbNgaynhap.AutoSize = True
        Me.lbNgaynhap.Location = New System.Drawing.Point(129, 411)
        Me.lbNgaynhap.Name = "lbNgaynhap"
        Me.lbNgaynhap.Size = New System.Drawing.Size(19, 13)
        Me.lbNgaynhap.TabIndex = 63
        Me.lbNgaynhap.Text = "aa"
        Me.lbNgaynhap.Visible = False
        '
        'lbTongtien
        '
        Me.lbTongtien.AutoSize = True
        Me.lbTongtien.Location = New System.Drawing.Point(129, 350)
        Me.lbTongtien.Name = "lbTongtien"
        Me.lbTongtien.Size = New System.Drawing.Size(19, 13)
        Me.lbTongtien.TabIndex = 64
        Me.lbTongtien.Text = "aa"
        Me.lbTongtien.Visible = False
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
        Me.btnNew.Location = New System.Drawing.Point(280, 464)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 65
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = CType(resources.GetObject("btnSearch.ImageActive"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(383, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSearch.TabIndex = 68
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'lbSoluongPhieuNhap
        '
        Me.lbSoluongPhieuNhap.AutoSize = True
        Me.lbSoluongPhieuNhap.Location = New System.Drawing.Point(916, 56)
        Me.lbSoluongPhieuNhap.Name = "lbSoluongPhieuNhap"
        Me.lbSoluongPhieuNhap.Size = New System.Drawing.Size(13, 13)
        Me.lbSoluongPhieuNhap.TabIndex = 69
        Me.lbSoluongPhieuNhap.Text = "2"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(869, 56)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(41, 13)
        Me.BunifuCustomLabel7.TabIndex = 70
        Me.BunifuCustomLabel7.Text = "Tất cả:"
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExcel.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExcel.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.Enabled = False
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.Black
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImagePosition = 5
        Me.btnExcel.ImageZoom = 40
        Me.btnExcel.LabelPosition = 20
        Me.btnExcel.LabelText = "In"
        Me.btnExcel.Location = New System.Drawing.Point(89, 544)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(59, 50)
        Me.btnExcel.TabIndex = 101
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(41, 89)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(32, 13)
        Me.BunifuCustomLabel6.TabIndex = 102
        Me.BunifuCustomLabel6.Text = "Theo"
        '
        'cbSearch
        '
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.Location = New System.Drawing.Point(79, 86)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(208, 21)
        Me.cbSearch.TabIndex = 103
        '
        'FormChiTietPN1
        '
        Me.FormChiTietPN1.BackColor = System.Drawing.Color.White
        Me.FormChiTietPN1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormChiTietPN1.Location = New System.Drawing.Point(-2, 0)
        Me.FormChiTietPN1.Name = "FormChiTietPN1"
        Me.FormChiTietPN1.Size = New System.Drawing.Size(1016, 670)
        Me.FormChiTietPN1.TabIndex = 71
        '
        'FormPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.FormChiTietPN1)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.lbSoluongPhieuNhap)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lbTongtien)
        Me.Controls.Add(Me.lbNgaynhap)
        Me.Controls.Add(Me.lbMapn)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.dtpNgaynhap)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.cbManv)
        Me.Controls.Add(Me.cbMancc)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.txtTongtien)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtMapn)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgPhieuNhap)
        Me.Name = "FormPhieuNhap"
        Me.Size = New System.Drawing.Size(1014, 657)
        CType(Me.dgPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgPhieuNhap As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtTimKiem As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMapn As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTongtien As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbMancc As ComboBox
    Friend WithEvents cbManv As ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpNgaynhap As DateTimePicker
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDetail As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lbMapn As Label
    Friend WithEvents lbNgaynhap As Label
    Friend WithEvents lbTongtien As Label
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbSoluongPhieuNhap As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FormChiTietPN1 As FormChiTietPN
    Friend WithEvents btnExcel As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbSearch As ComboBox
End Class
