<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNCC
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNCC))
        Me.dgNCC = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMaNCC = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTenNCC = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDiachi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSdt = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTimKiemNCC = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDelSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbMaNCC = New System.Windows.Forms.Label()
        Me.lbTenNCC = New System.Windows.Forms.Label()
        Me.lbDiachi = New System.Windows.Forms.Label()
        Me.lbSdt = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbSoluongNCC = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.dgNCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgNCC
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgNCC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgNCC.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgNCC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgNCC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgNCC.DoubleBuffered = True
        Me.dgNCC.EnableHeadersVisualStyles = False
        Me.dgNCC.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgNCC.HeaderForeColor = System.Drawing.Color.White
        Me.dgNCC.Location = New System.Drawing.Point(445, 75)
        Me.dgNCC.Name = "dgNCC"
        Me.dgNCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgNCC.Size = New System.Drawing.Size(520, 543)
        Me.dgNCC.TabIndex = 3
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(49, 95)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(47, 13)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Mã NCC"
        '
        'txtMaNCC
        '
        Me.txtMaNCC.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMaNCC.Location = New System.Drawing.Point(102, 92)
        Me.txtMaNCC.Multiline = True
        Me.txtMaNCC.Name = "txtMaNCC"
        Me.txtMaNCC.Size = New System.Drawing.Size(321, 34)
        Me.txtMaNCC.TabIndex = 14
        '
        'txtTenNCC
        '
        Me.txtTenNCC.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTenNCC.Location = New System.Drawing.Point(106, 161)
        Me.txtTenNCC.Multiline = True
        Me.txtTenNCC.Name = "txtTenNCC"
        Me.txtTenNCC.Size = New System.Drawing.Size(317, 78)
        Me.txtTenNCC.TabIndex = 16
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(56, 280)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(40, 13)
        Me.BunifuCustomLabel3.TabIndex = 17
        Me.BunifuCustomLabel3.Text = "Địa chỉ"
        '
        'txtDiachi
        '
        Me.txtDiachi.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtDiachi.Location = New System.Drawing.Point(106, 277)
        Me.txtDiachi.Multiline = True
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(317, 77)
        Me.txtDiachi.TabIndex = 18
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(56, 395)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(29, 13)
        Me.BunifuCustomLabel4.TabIndex = 19
        Me.BunifuCustomLabel4.Text = "SĐT"
        '
        'txtSdt
        '
        Me.txtSdt.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSdt.Location = New System.Drawing.Point(106, 392)
        Me.txtSdt.Multiline = True
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(317, 34)
        Me.txtSdt.TabIndex = 20
        '
        'txtTimKiemNCC
        '
        Me.txtTimKiemNCC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimKiemNCC.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTimKiemNCC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTimKiemNCC.HintForeColor = System.Drawing.Color.Gray
        Me.txtTimKiemNCC.HintText = "Tìm kiếm"
        Me.txtTimKiemNCC.isPassword = False
        Me.txtTimKiemNCC.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTimKiemNCC.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTimKiemNCC.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTimKiemNCC.LineThickness = 3
        Me.txtTimKiemNCC.Location = New System.Drawing.Point(52, 17)
        Me.txtTimKiemNCC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiemNCC.Name = "txtTimKiemNCC"
        Me.txtTimKiemNCC.Size = New System.Drawing.Size(334, 44)
        Me.txtTimKiemNCC.TabIndex = 28
        Me.txtTimKiemNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnUpdate.Location = New System.Drawing.Point(212, 462)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 48
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
        Me.btnXoa.Location = New System.Drawing.Point(327, 462)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 49
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
        Me.btnThem.Location = New System.Drawing.Point(327, 541)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 50
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
        Me.btnNew.Location = New System.Drawing.Point(212, 541)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 63
        '
        'btnDelSearch
        '
        Me.btnDelSearch.BackColor = System.Drawing.Color.White
        Me.btnDelSearch.Image = CType(resources.GetObject("btnDelSearch.Image"), System.Drawing.Image)
        Me.btnDelSearch.ImageActive = CType(resources.GetObject("btnDelSearch.ImageActive"), System.Drawing.Image)
        Me.btnDelSearch.Location = New System.Drawing.Point(393, 31)
        Me.btnDelSearch.Name = "btnDelSearch"
        Me.btnDelSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnDelSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDelSearch.TabIndex = 68
        Me.btnDelSearch.TabStop = False
        Me.btnDelSearch.Zoom = 10
        '
        'lbMaNCC
        '
        Me.lbMaNCC.AutoSize = True
        Me.lbMaNCC.Location = New System.Drawing.Point(116, 129)
        Me.lbMaNCC.Name = "lbMaNCC"
        Me.lbMaNCC.Size = New System.Drawing.Size(19, 13)
        Me.lbMaNCC.TabIndex = 69
        Me.lbMaNCC.Text = "aa"
        Me.lbMaNCC.Visible = False
        '
        'lbTenNCC
        '
        Me.lbTenNCC.AutoSize = True
        Me.lbTenNCC.Location = New System.Drawing.Point(116, 242)
        Me.lbTenNCC.Name = "lbTenNCC"
        Me.lbTenNCC.Size = New System.Drawing.Size(19, 13)
        Me.lbTenNCC.TabIndex = 70
        Me.lbTenNCC.Text = "aa"
        Me.lbTenNCC.Visible = False
        '
        'lbDiachi
        '
        Me.lbDiachi.AutoSize = True
        Me.lbDiachi.Location = New System.Drawing.Point(116, 357)
        Me.lbDiachi.Name = "lbDiachi"
        Me.lbDiachi.Size = New System.Drawing.Size(19, 13)
        Me.lbDiachi.TabIndex = 71
        Me.lbDiachi.Text = "aa"
        Me.lbDiachi.Visible = False
        '
        'lbSdt
        '
        Me.lbSdt.AutoSize = True
        Me.lbSdt.Location = New System.Drawing.Point(116, 429)
        Me.lbSdt.Name = "lbSdt"
        Me.lbSdt.Size = New System.Drawing.Size(19, 13)
        Me.lbSdt.TabIndex = 72
        Me.lbSdt.Text = "aa"
        Me.lbSdt.Visible = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(49, 164)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(51, 13)
        Me.BunifuCustomLabel1.TabIndex = 15
        Me.BunifuCustomLabel1.Text = "Tên NCC"
        '
        'lbSoluongNCC
        '
        Me.lbSoluongNCC.AutoSize = True
        Me.lbSoluongNCC.Location = New System.Drawing.Point(926, 48)
        Me.lbSoluongNCC.Name = "lbSoluongNCC"
        Me.lbSoluongNCC.Size = New System.Drawing.Size(13, 13)
        Me.lbSoluongNCC.TabIndex = 73
        Me.lbSoluongNCC.Text = "2"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(879, 48)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(41, 13)
        Me.BunifuCustomLabel6.TabIndex = 74
        Me.BunifuCustomLabel6.Text = "Tất cả:"
        '
        'FormNCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.lbSoluongNCC)
        Me.Controls.Add(Me.lbSdt)
        Me.Controls.Add(Me.lbDiachi)
        Me.Controls.Add(Me.lbTenNCC)
        Me.Controls.Add(Me.lbMaNCC)
        Me.Controls.Add(Me.btnDelSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtTimKiemNCC)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.txtTenNCC)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtMaNCC)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgNCC)
        Me.Name = "FormNCC"
        Me.Size = New System.Drawing.Size(1014, 657)
        CType(Me.dgNCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgNCC As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMaNCC As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtTenNCC As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDiachi As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSdt As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtTimKiemNCC As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDelSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbMaNCC As Label
    Friend WithEvents lbTenNCC As Label
    Friend WithEvents lbDiachi As Label
    Friend WithEvents lbSdt As Label
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbSoluongNCC As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
