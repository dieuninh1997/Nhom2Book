<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTacgia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTacgia))
        Me.dgTacgia = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMatacgia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTentacgia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSdtTacgia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTimKiemTg = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lbMaTacgia = New System.Windows.Forms.Label()
        Me.lbTentacgia = New System.Windows.Forms.Label()
        Me.lbSdt = New System.Windows.Forms.Label()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDelSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbSoluongTacgia = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        CType(Me.dgTacgia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTacgia
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgTacgia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTacgia.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgTacgia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTacgia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTacgia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTacgia.DoubleBuffered = True
        Me.dgTacgia.EnableHeadersVisualStyles = False
        Me.dgTacgia.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgTacgia.HeaderForeColor = System.Drawing.Color.Black
        Me.dgTacgia.Location = New System.Drawing.Point(423, 41)
        Me.dgTacgia.Name = "dgTacgia"
        Me.dgTacgia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgTacgia.Size = New System.Drawing.Size(542, 506)
        Me.dgTacgia.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(33, 163)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(57, 13)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Mã tác giả"
        '
        'txtMatacgia
        '
        Me.txtMatacgia.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMatacgia.Location = New System.Drawing.Point(106, 160)
        Me.txtMatacgia.Multiline = True
        Me.txtMatacgia.Name = "txtMatacgia"
        Me.txtMatacgia.Size = New System.Drawing.Size(293, 34)
        Me.txtMatacgia.TabIndex = 13
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(29, 239)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(61, 13)
        Me.BunifuCustomLabel1.TabIndex = 14
        Me.BunifuCustomLabel1.Text = "Tên tác giả"
        '
        'txtTentacgia
        '
        Me.txtTentacgia.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTentacgia.Location = New System.Drawing.Point(106, 236)
        Me.txtTentacgia.Multiline = True
        Me.txtTentacgia.Name = "txtTentacgia"
        Me.txtTentacgia.Size = New System.Drawing.Size(293, 67)
        Me.txtTentacgia.TabIndex = 15
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(26, 345)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(70, 13)
        Me.BunifuCustomLabel3.TabIndex = 16
        Me.BunifuCustomLabel3.Text = "Số điện thoại"
        '
        'txtSdtTacgia
        '
        Me.txtSdtTacgia.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSdtTacgia.Location = New System.Drawing.Point(106, 342)
        Me.txtSdtTacgia.Multiline = True
        Me.txtSdtTacgia.Name = "txtSdtTacgia"
        Me.txtSdtTacgia.Size = New System.Drawing.Size(293, 34)
        Me.txtSdtTacgia.TabIndex = 17
        '
        'txtTimKiemTg
        '
        Me.txtTimKiemTg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimKiemTg.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTimKiemTg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTimKiemTg.HintForeColor = System.Drawing.Color.Gray
        Me.txtTimKiemTg.HintText = "Tìm kiếm"
        Me.txtTimKiemTg.isPassword = False
        Me.txtTimKiemTg.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTimKiemTg.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTimKiemTg.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTimKiemTg.LineThickness = 3
        Me.txtTimKiemTg.Location = New System.Drawing.Point(29, 27)
        Me.txtTimKiemTg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiemTg.Name = "txtTimKiemTg"
        Me.txtTimKiemTg.Size = New System.Drawing.Size(337, 44)
        Me.txtTimKiemTg.TabIndex = 24
        Me.txtTimKiemTg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnUpdate.Location = New System.Drawing.Point(142, 456)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 50)
        Me.btnUpdate.TabIndex = 46
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
        Me.btnXoa.Location = New System.Drawing.Point(231, 456)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 47
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
        Me.btnThem.Location = New System.Drawing.Point(322, 456)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 48
        '
        'lbMaTacgia
        '
        Me.lbMaTacgia.AutoSize = True
        Me.lbMaTacgia.Location = New System.Drawing.Point(116, 197)
        Me.lbMaTacgia.Name = "lbMaTacgia"
        Me.lbMaTacgia.Size = New System.Drawing.Size(19, 13)
        Me.lbMaTacgia.TabIndex = 57
        Me.lbMaTacgia.Text = "aa"
        Me.lbMaTacgia.Visible = False
        '
        'lbTentacgia
        '
        Me.lbTentacgia.AutoSize = True
        Me.lbTentacgia.Location = New System.Drawing.Point(116, 306)
        Me.lbTentacgia.Name = "lbTentacgia"
        Me.lbTentacgia.Size = New System.Drawing.Size(19, 13)
        Me.lbTentacgia.TabIndex = 58
        Me.lbTentacgia.Text = "aa"
        Me.lbTentacgia.Visible = False
        '
        'lbSdt
        '
        Me.lbSdt.AutoSize = True
        Me.lbSdt.Location = New System.Drawing.Point(116, 379)
        Me.lbSdt.Name = "lbSdt"
        Me.lbSdt.Size = New System.Drawing.Size(19, 13)
        Me.lbSdt.TabIndex = 59
        Me.lbSdt.Text = "aa"
        Me.lbSdt.Visible = False
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
        Me.btnNew.Location = New System.Drawing.Point(50, 456)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 50)
        Me.btnNew.TabIndex = 63
        '
        'btnDelSearch
        '
        Me.btnDelSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelSearch.Image = CType(resources.GetObject("btnDelSearch.Image"), System.Drawing.Image)
        Me.btnDelSearch.ImageActive = CType(resources.GetObject("btnDelSearch.ImageActive"), System.Drawing.Image)
        Me.btnDelSearch.Location = New System.Drawing.Point(369, 41)
        Me.btnDelSearch.Name = "btnDelSearch"
        Me.btnDelSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnDelSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDelSearch.TabIndex = 68
        Me.btnDelSearch.TabStop = False
        Me.btnDelSearch.Zoom = 10
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(887, 13)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(41, 13)
        Me.BunifuCustomLabel4.TabIndex = 69
        Me.BunifuCustomLabel4.Text = "Tất cả:"
        '
        'lbSoluongTacgia
        '
        Me.lbSoluongTacgia.AutoSize = True
        Me.lbSoluongTacgia.Location = New System.Drawing.Point(934, 13)
        Me.lbSoluongTacgia.Name = "lbSoluongTacgia"
        Me.lbSoluongTacgia.Size = New System.Drawing.Size(13, 13)
        Me.lbSoluongTacgia.TabIndex = 70
        Me.lbSoluongTacgia.Text = "2"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(31, 78)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(32, 13)
        Me.BunifuCustomLabel5.TabIndex = 71
        Me.BunifuCustomLabel5.Text = "Theo"
        '
        'cbSearch
        '
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.Location = New System.Drawing.Point(67, 75)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(195, 21)
        Me.cbSearch.TabIndex = 72
        '
        'FormTacgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lbSoluongTacgia)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.btnDelSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lbSdt)
        Me.Controls.Add(Me.lbTentacgia)
        Me.Controls.Add(Me.lbMaTacgia)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtTimKiemTg)
        Me.Controls.Add(Me.txtSdtTacgia)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.txtTentacgia)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtMatacgia)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgTacgia)
        Me.Name = "FormTacgia"
        Me.Size = New System.Drawing.Size(1014, 596)
        CType(Me.dgTacgia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgTacgia As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMatacgia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTentacgia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSdtTacgia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtTimKiemTg As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lbMaTacgia As Label
    Friend WithEvents lbTentacgia As Label
    Friend WithEvents lbSdt As Label
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDelSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbSoluongTacgia As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbSearch As ComboBox
End Class
