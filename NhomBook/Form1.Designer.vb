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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnBill = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnImportedBook = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnProvider = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnStaff = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCustomer = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBook = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnScroll = New System.Windows.Forms.PictureBox()
        Me.panel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.FormNCC1 = New NhomBook.FormNCC()
        Me.FormPhieuNhap1 = New NhomBook.FormPhieuNhap()
        Me.FormBook1 = New NhomBook.FormBook()
        Me.Formhome1 = New NhomBook.Formhome()
        Me.panelMenu.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'panelMenu
        '
        Me.panelMenu.BackgroundImage = CType(resources.GetObject("panelMenu.BackgroundImage"), System.Drawing.Image)
        Me.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMenu.Controls.Add(Me.btnBill)
        Me.panelMenu.Controls.Add(Me.btnImportedBook)
        Me.panelMenu.Controls.Add(Me.btnProvider)
        Me.panelMenu.Controls.Add(Me.btnStaff)
        Me.panelMenu.Controls.Add(Me.btnCustomer)
        Me.panelMenu.Controls.Add(Me.btnBook)
        Me.panelMenu.Controls.Add(Me.btnHome)
        Me.panelMenu.Controls.Add(Me.BunifuGradientPanel2)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Quality = 10
        Me.panelMenu.Size = New System.Drawing.Size(185, 700)
        Me.panelMenu.TabIndex = 0
        '
        'btnBill
        '
        Me.btnBill.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBill.BorderRadius = 0
        Me.btnBill.ButtonText = "Bill "
        Me.btnBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBill.DisabledColor = System.Drawing.Color.Gray
        Me.btnBill.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBill.Iconimage = CType(resources.GetObject("btnBill.Iconimage"), System.Drawing.Image)
        Me.btnBill.Iconimage_right = Nothing
        Me.btnBill.Iconimage_right_Selected = Nothing
        Me.btnBill.Iconimage_Selected = Nothing
        Me.btnBill.IconMarginLeft = 0
        Me.btnBill.IconMarginRight = 0
        Me.btnBill.IconRightVisible = True
        Me.btnBill.IconRightZoom = 0R
        Me.btnBill.IconVisible = True
        Me.btnBill.IconZoom = 90.0R
        Me.btnBill.IsTab = False
        Me.btnBill.Location = New System.Drawing.Point(0, 389)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBill.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnBill.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBill.selected = False
        Me.btnBill.Size = New System.Drawing.Size(185, 48)
        Me.btnBill.TabIndex = 7
        Me.btnBill.Text = "Bill "
        Me.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBill.Textcolor = System.Drawing.Color.White
        Me.btnBill.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnImportedBook
        '
        Me.btnImportedBook.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnImportedBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImportedBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportedBook.BorderRadius = 0
        Me.btnImportedBook.ButtonText = "Imported books"
        Me.btnImportedBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportedBook.DisabledColor = System.Drawing.Color.Gray
        Me.btnImportedBook.Iconcolor = System.Drawing.Color.Transparent
        Me.btnImportedBook.Iconimage = CType(resources.GetObject("btnImportedBook.Iconimage"), System.Drawing.Image)
        Me.btnImportedBook.Iconimage_right = Nothing
        Me.btnImportedBook.Iconimage_right_Selected = Nothing
        Me.btnImportedBook.Iconimage_Selected = Nothing
        Me.btnImportedBook.IconMarginLeft = 0
        Me.btnImportedBook.IconMarginRight = 0
        Me.btnImportedBook.IconRightVisible = True
        Me.btnImportedBook.IconRightZoom = 0R
        Me.btnImportedBook.IconVisible = True
        Me.btnImportedBook.IconZoom = 90.0R
        Me.btnImportedBook.IsTab = False
        Me.btnImportedBook.Location = New System.Drawing.Point(0, 335)
        Me.btnImportedBook.Name = "btnImportedBook"
        Me.btnImportedBook.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImportedBook.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnImportedBook.OnHoverTextColor = System.Drawing.Color.White
        Me.btnImportedBook.selected = False
        Me.btnImportedBook.Size = New System.Drawing.Size(185, 48)
        Me.btnImportedBook.TabIndex = 6
        Me.btnImportedBook.Text = "Imported books"
        Me.btnImportedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportedBook.Textcolor = System.Drawing.Color.White
        Me.btnImportedBook.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnProvider
        '
        Me.btnProvider.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnProvider.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProvider.BorderRadius = 0
        Me.btnProvider.ButtonText = "Provider"
        Me.btnProvider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvider.DisabledColor = System.Drawing.Color.Gray
        Me.btnProvider.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProvider.Iconimage = CType(resources.GetObject("btnProvider.Iconimage"), System.Drawing.Image)
        Me.btnProvider.Iconimage_right = Nothing
        Me.btnProvider.Iconimage_right_Selected = Nothing
        Me.btnProvider.Iconimage_Selected = Nothing
        Me.btnProvider.IconMarginLeft = 0
        Me.btnProvider.IconMarginRight = 0
        Me.btnProvider.IconRightVisible = True
        Me.btnProvider.IconRightZoom = 0R
        Me.btnProvider.IconVisible = True
        Me.btnProvider.IconZoom = 90.0R
        Me.btnProvider.IsTab = False
        Me.btnProvider.Location = New System.Drawing.Point(0, 281)
        Me.btnProvider.Name = "btnProvider"
        Me.btnProvider.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProvider.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnProvider.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProvider.selected = False
        Me.btnProvider.Size = New System.Drawing.Size(185, 48)
        Me.btnProvider.TabIndex = 5
        Me.btnProvider.Text = "Provider"
        Me.btnProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProvider.Textcolor = System.Drawing.Color.White
        Me.btnProvider.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnStaff
        '
        Me.btnStaff.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStaff.BorderRadius = 0
        Me.btnStaff.ButtonText = "Staff"
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.DisabledColor = System.Drawing.Color.Gray
        Me.btnStaff.Iconcolor = System.Drawing.Color.Transparent
        Me.btnStaff.Iconimage = CType(resources.GetObject("btnStaff.Iconimage"), System.Drawing.Image)
        Me.btnStaff.Iconimage_right = Nothing
        Me.btnStaff.Iconimage_right_Selected = Nothing
        Me.btnStaff.Iconimage_Selected = Nothing
        Me.btnStaff.IconMarginLeft = 0
        Me.btnStaff.IconMarginRight = 0
        Me.btnStaff.IconRightVisible = True
        Me.btnStaff.IconRightZoom = 0R
        Me.btnStaff.IconVisible = True
        Me.btnStaff.IconZoom = 90.0R
        Me.btnStaff.IsTab = False
        Me.btnStaff.Location = New System.Drawing.Point(0, 227)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaff.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnStaff.OnHoverTextColor = System.Drawing.Color.White
        Me.btnStaff.selected = False
        Me.btnStaff.Size = New System.Drawing.Size(185, 48)
        Me.btnStaff.TabIndex = 4
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Textcolor = System.Drawing.Color.White
        Me.btnStaff.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCustomer
        '
        Me.btnCustomer.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomer.BorderRadius = 0
        Me.btnCustomer.ButtonText = "Customer"
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.DisabledColor = System.Drawing.Color.Gray
        Me.btnCustomer.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCustomer.Iconimage = CType(resources.GetObject("btnCustomer.Iconimage"), System.Drawing.Image)
        Me.btnCustomer.Iconimage_right = Nothing
        Me.btnCustomer.Iconimage_right_Selected = Nothing
        Me.btnCustomer.Iconimage_Selected = Nothing
        Me.btnCustomer.IconMarginLeft = 0
        Me.btnCustomer.IconMarginRight = 0
        Me.btnCustomer.IconRightVisible = True
        Me.btnCustomer.IconRightZoom = 0R
        Me.btnCustomer.IconVisible = True
        Me.btnCustomer.IconZoom = 90.0R
        Me.btnCustomer.IsTab = False
        Me.btnCustomer.Location = New System.Drawing.Point(0, 173)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCustomer.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCustomer.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCustomer.selected = False
        Me.btnCustomer.Size = New System.Drawing.Size(185, 48)
        Me.btnCustomer.TabIndex = 3
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Textcolor = System.Drawing.Color.White
        Me.btnCustomer.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBook
        '
        Me.btnBook.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBook.BorderRadius = 0
        Me.btnBook.ButtonText = "Book"
        Me.btnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBook.DisabledColor = System.Drawing.Color.Gray
        Me.btnBook.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBook.Iconimage = CType(resources.GetObject("btnBook.Iconimage"), System.Drawing.Image)
        Me.btnBook.Iconimage_right = Nothing
        Me.btnBook.Iconimage_right_Selected = Nothing
        Me.btnBook.Iconimage_Selected = Nothing
        Me.btnBook.IconMarginLeft = 0
        Me.btnBook.IconMarginRight = 0
        Me.btnBook.IconRightVisible = True
        Me.btnBook.IconRightZoom = 0R
        Me.btnBook.IconVisible = True
        Me.btnBook.IconZoom = 90.0R
        Me.btnBook.IsTab = False
        Me.btnBook.Location = New System.Drawing.Point(0, 119)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBook.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnBook.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBook.selected = False
        Me.btnBook.Size = New System.Drawing.Size(185, 48)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "Book"
        Me.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.Textcolor = System.Drawing.Color.White
        Me.btnBook.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnHome
        '
        Me.btnHome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.BorderRadius = 0
        Me.btnHome.ButtonText = "Home"
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.DisabledColor = System.Drawing.Color.Gray
        Me.btnHome.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHome.Iconimage = CType(resources.GetObject("btnHome.Iconimage"), System.Drawing.Image)
        Me.btnHome.Iconimage_right = Nothing
        Me.btnHome.Iconimage_right_Selected = Nothing
        Me.btnHome.Iconimage_Selected = Nothing
        Me.btnHome.IconMarginLeft = 0
        Me.btnHome.IconMarginRight = 0
        Me.btnHome.IconRightVisible = True
        Me.btnHome.IconRightZoom = 0R
        Me.btnHome.IconVisible = True
        Me.btnHome.IconZoom = 90.0R
        Me.btnHome.IsTab = False
        Me.btnHome.Location = New System.Drawing.Point(0, 72)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnHome.OnHoverTextColor = System.Drawing.Color.White
        Me.btnHome.selected = False
        Me.btnHome.Size = New System.Drawing.Size(185, 48)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Textcolor = System.Drawing.Color.White
        Me.btnHome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnScroll)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(185, 71)
        Me.BunifuGradientPanel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(102, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnScroll
        '
        Me.btnScroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnScroll.Image = CType(resources.GetObject("btnScroll.Image"), System.Drawing.Image)
        Me.btnScroll.Location = New System.Drawing.Point(7, 23)
        Me.btnScroll.Name = "btnScroll"
        Me.btnScroll.Size = New System.Drawing.Size(30, 33)
        Me.btnScroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnScroll.TabIndex = 0
        Me.btnScroll.TabStop = False
        '
        'panel
        '
        Me.panel.BackgroundImage = CType(resources.GetObject("panel.BackgroundImage"), System.Drawing.Image)
        Me.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel.Controls.Add(Me.btnMini)
        Me.panel.Controls.Add(Me.btnClose)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panel.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panel.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panel.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panel.Location = New System.Drawing.Point(185, 0)
        Me.panel.Name = "panel"
        Me.panel.Quality = 10
        Me.panel.Size = New System.Drawing.Size(1015, 36)
        Me.panel.TabIndex = 1
        '
        'btnMini
        '
        Me.btnMini.Location = New System.Drawing.Point(931, 7)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(33, 23)
        Me.btnMini.TabIndex = 1
        Me.btnMini.Text = "_"
        Me.btnMini.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(970, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.panel
        Me.BunifuDragControl1.Vertical = True
        '
        'FormNCC1
        '
        Me.FormNCC1.BackColor = System.Drawing.Color.White
        Me.FormNCC1.Location = New System.Drawing.Point(185, 36)
        Me.FormNCC1.Name = "FormNCC1"
        Me.FormNCC1.Size = New System.Drawing.Size(1015, 664)
        Me.FormNCC1.TabIndex = 5
        '
        'FormPhieuNhap1
        '
        Me.FormPhieuNhap1.BackColor = System.Drawing.Color.White
        Me.FormPhieuNhap1.Location = New System.Drawing.Point(186, 36)
        Me.FormPhieuNhap1.Name = "FormPhieuNhap1"
        Me.FormPhieuNhap1.Size = New System.Drawing.Size(1015, 664)
        Me.FormPhieuNhap1.TabIndex = 4
        '
        'FormBook1
        '
        Me.FormBook1.BackColor = System.Drawing.Color.White
        Me.FormBook1.Location = New System.Drawing.Point(185, 36)
        Me.FormBook1.Name = "FormBook1"
        Me.FormBook1.Size = New System.Drawing.Size(1015, 664)
        Me.FormBook1.TabIndex = 3
        '
        'Formhome1
        '
        Me.Formhome1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Formhome1.Location = New System.Drawing.Point(185, 37)
        Me.Formhome1.Name = "Formhome1"
        Me.Formhome1.Size = New System.Drawing.Size(1015, 663)
        Me.Formhome1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.FormNCC1)
        Me.Controls.Add(Me.FormPhieuNhap1)
        Me.Controls.Add(Me.FormBook1)
        Me.Controls.Add(Me.Formhome1)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelMenu.ResumeLayout(False)
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnScroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnBook As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnScroll As PictureBox
    Friend WithEvents btnImportedBook As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnProvider As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnStaff As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCustomer As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBill As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Formhome1 As Formhome
    Friend WithEvents panel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents FormBook1 As FormBook
    Friend WithEvents FormNCC1 As FormNCC
    Friend WithEvents FormPhieuNhap1 As FormPhieuNhap
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnMini As Button
    Friend WithEvents btnClose As Button
End Class
