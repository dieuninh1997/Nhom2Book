<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTheLoai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTheLoai))
        Me.dgTheloai = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.txtTimkiemTheloai = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMaTheloai = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTentheloai = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lbMatheloai = New System.Windows.Forms.Label()
        Me.lbTentheloai = New System.Windows.Forms.Label()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDelSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbSoluongTheLoai = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.dgTheloai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTheloai
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgTheloai.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTheloai.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgTheloai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTheloai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTheloai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTheloai.DoubleBuffered = True
        Me.dgTheloai.EnableHeadersVisualStyles = False
        Me.dgTheloai.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgTheloai.HeaderForeColor = System.Drawing.Color.Black
        Me.dgTheloai.Location = New System.Drawing.Point(421, 35)
        Me.dgTheloai.Name = "dgTheloai"
        Me.dgTheloai.ReadOnly = True
        Me.dgTheloai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgTheloai.Size = New System.Drawing.Size(546, 514)
        Me.dgTheloai.TabIndex = 3
        '
        'txtTimkiemTheloai
        '
        Me.txtTimkiemTheloai.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimkiemTheloai.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTimkiemTheloai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTimkiemTheloai.HintForeColor = System.Drawing.Color.Gray
        Me.txtTimkiemTheloai.HintText = "Tìm kiếm theo tên "
        Me.txtTimkiemTheloai.isPassword = False
        Me.txtTimkiemTheloai.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTimkiemTheloai.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTimkiemTheloai.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTimkiemTheloai.LineThickness = 3
        Me.txtTimkiemTheloai.Location = New System.Drawing.Point(38, 35)
        Me.txtTimkiemTheloai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimkiemTheloai.Name = "txtTimkiemTheloai"
        Me.txtTimkiemTheloai.Size = New System.Drawing.Size(322, 44)
        Me.txtTimkiemTheloai.TabIndex = 25
        Me.txtTimkiemTheloai.Text = "Tìm kiếm"
        Me.txtTimkiemTheloai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(35, 111)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(59, 13)
        Me.BunifuCustomLabel2.TabIndex = 26
        Me.BunifuCustomLabel2.Text = "Mã thể loại"
        '
        'txtMaTheloai
        '
        Me.txtMaTheloai.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMaTheloai.Location = New System.Drawing.Point(100, 108)
        Me.txtMaTheloai.Multiline = True
        Me.txtMaTheloai.Name = "txtMaTheloai"
        Me.txtMaTheloai.Size = New System.Drawing.Size(293, 34)
        Me.txtMaTheloai.TabIndex = 27
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(35, 173)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(63, 13)
        Me.BunifuCustomLabel1.TabIndex = 28
        Me.BunifuCustomLabel1.Text = "Tên thể loại"
        '
        'txtTentheloai
        '
        Me.txtTentheloai.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTentheloai.Location = New System.Drawing.Point(100, 170)
        Me.txtTentheloai.Multiline = True
        Me.txtTentheloai.Name = "txtTentheloai"
        Me.txtTentheloai.Size = New System.Drawing.Size(293, 34)
        Me.txtTentheloai.TabIndex = 29
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
        Me.btnThem.Location = New System.Drawing.Point(334, 263)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 45
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
        Me.btnXoa.Location = New System.Drawing.Point(241, 263)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 46
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
        Me.btnUpdate.Location = New System.Drawing.Point(149, 263)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 47
        '
        'lbMatheloai
        '
        Me.lbMatheloai.AutoSize = True
        Me.lbMatheloai.Location = New System.Drawing.Point(112, 145)
        Me.lbMatheloai.Name = "lbMatheloai"
        Me.lbMatheloai.Size = New System.Drawing.Size(19, 13)
        Me.lbMatheloai.TabIndex = 60
        Me.lbMatheloai.Text = "aa"
        Me.lbMatheloai.Visible = False
        '
        'lbTentheloai
        '
        Me.lbTentheloai.AutoSize = True
        Me.lbTentheloai.Location = New System.Drawing.Point(112, 207)
        Me.lbTentheloai.Name = "lbTentheloai"
        Me.lbTentheloai.Size = New System.Drawing.Size(19, 13)
        Me.lbTentheloai.TabIndex = 61
        Me.lbTentheloai.Text = "aa"
        Me.lbTentheloai.Visible = False
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
        Me.btnNew.Location = New System.Drawing.Point(60, 263)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 62
        '
        'btnDelSearch
        '
        Me.btnDelSearch.BackColor = System.Drawing.Color.White
        Me.btnDelSearch.Image = CType(resources.GetObject("btnDelSearch.Image"), System.Drawing.Image)
        Me.btnDelSearch.ImageActive = CType(resources.GetObject("btnDelSearch.ImageActive"), System.Drawing.Image)
        Me.btnDelSearch.Location = New System.Drawing.Point(363, 49)
        Me.btnDelSearch.Name = "btnDelSearch"
        Me.btnDelSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnDelSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDelSearch.TabIndex = 67
        Me.btnDelSearch.TabStop = False
        Me.btnDelSearch.Zoom = 10
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(880, 9)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(44, 13)
        Me.BunifuCustomLabel3.TabIndex = 68
        Me.BunifuCustomLabel3.Text = "Tất cả: "
        '
        'lbSoluongTheLoai
        '
        Me.lbSoluongTheLoai.AutoSize = True
        Me.lbSoluongTheLoai.Location = New System.Drawing.Point(930, 9)
        Me.lbSoluongTheLoai.Name = "lbSoluongTheLoai"
        Me.lbSoluongTheLoai.Size = New System.Drawing.Size(13, 13)
        Me.lbSoluongTheLoai.TabIndex = 69
        Me.lbSoluongTheLoai.Text = "2"
        '
        'FormTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.lbSoluongTheLoai)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.btnDelSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lbTentheloai)
        Me.Controls.Add(Me.lbMatheloai)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTentheloai)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtMaTheloai)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtTimkiemTheloai)
        Me.Controls.Add(Me.dgTheloai)
        Me.Name = "FormTheLoai"
        Me.Size = New System.Drawing.Size(1014, 596)
        CType(Me.dgTheloai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgTheloai As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtTimkiemTheloai As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMaTheloai As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTentheloai As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lbMatheloai As Label
    Friend WithEvents lbTentheloai As Label
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDelSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbSoluongTheLoai As Bunifu.Framework.UI.BunifuCustomLabel
End Class
