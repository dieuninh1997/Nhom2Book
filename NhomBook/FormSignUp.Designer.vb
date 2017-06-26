<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSignUp
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSignUp))
        Me.txtFname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtLname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnCreateAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.picSignUp = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.checkboxShowPass = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbThongBao = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.drag1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.drag2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.tran = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.picSignUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.Color.White
        Me.txtFname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.BorderColorIdle = System.Drawing.Color.White
        Me.txtFname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.BorderThickness = 3
        Me.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran.SetDecoration(Me.txtFname, BunifuAnimatorNS.DecorationType.None)
        Me.txtFname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.isPassword = False
        Me.txtFname.Location = New System.Drawing.Point(71, 183)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(370, 44)
        Me.txtFname.TabIndex = 0
        Me.txtFname.Text = "First Name"
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.White
        Me.txtLname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.BorderColorIdle = System.Drawing.Color.White
        Me.txtLname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.BorderThickness = 3
        Me.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran.SetDecoration(Me.txtLname, BunifuAnimatorNS.DecorationType.None)
        Me.txtLname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtLname.ForeColor = System.Drawing.Color.Black
        Me.txtLname.isPassword = False
        Me.txtLname.Location = New System.Drawing.Point(71, 255)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(370, 44)
        Me.txtLname.TabIndex = 1
        Me.txtLname.Text = "Last Name"
        Me.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.White
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran.SetDecoration(Me.txtEmail, BunifuAnimatorNS.DecorationType.None)
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(102, 329)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(339, 44)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.Text = "Email"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.BorderColorIdle = System.Drawing.Color.White
        Me.txtUser.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.BorderThickness = 3
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran.SetDecoration(Me.txtUser, BunifuAnimatorNS.DecorationType.None)
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.isPassword = False
        Me.txtUser.Location = New System.Drawing.Point(102, 402)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(337, 44)
        Me.txtUser.TabIndex = 3
        Me.txtUser.Text = "Username"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.White
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.BorderThickness = 3
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(102, 473)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(337, 44)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateAccount.BorderRadius = 0
        Me.btnCreateAccount.ButtonText = "CREATE ACCOUNT"
        Me.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tran.SetDecoration(Me.btnCreateAccount, BunifuAnimatorNS.DecorationType.None)
        Me.btnCreateAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateAccount.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.Iconimage = CType(resources.GetObject("btnCreateAccount.Iconimage"), System.Drawing.Image)
        Me.btnCreateAccount.Iconimage_right = Nothing
        Me.btnCreateAccount.Iconimage_right_Selected = Nothing
        Me.btnCreateAccount.Iconimage_Selected = Nothing
        Me.btnCreateAccount.IconMarginLeft = 0
        Me.btnCreateAccount.IconMarginRight = 0
        Me.btnCreateAccount.IconRightVisible = True
        Me.btnCreateAccount.IconRightZoom = 0R
        Me.btnCreateAccount.IconVisible = False
        Me.btnCreateAccount.IconZoom = 90.0R
        Me.btnCreateAccount.IsTab = False
        Me.btnCreateAccount.Location = New System.Drawing.Point(131, 576)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateAccount.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnCreateAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateAccount.selected = False
        Me.btnCreateAccount.Size = New System.Drawing.Size(254, 48)
        Me.btnCreateAccount.TabIndex = 7
        Me.btnCreateAccount.Text = "CREATE ACCOUNT"
        Me.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCreateAccount.Textcolor = System.Drawing.Color.White
        Me.btnCreateAccount.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'picSignUp
        '
        Me.tran.SetDecoration(Me.picSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.picSignUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.picSignUp.Image = CType(resources.GetObject("picSignUp.Image"), System.Drawing.Image)
        Me.picSignUp.Location = New System.Drawing.Point(0, 0)
        Me.picSignUp.Name = "picSignUp"
        Me.picSignUp.Size = New System.Drawing.Size(501, 126)
        Me.picSignUp.TabIndex = 8
        Me.picSignUp.TabStop = False
        '
        'PictureBox2
        '
        Me.tran.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 339)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.tran.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(71, 411)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.tran.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(71, 482)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'checkboxShowPass
        '
        Me.checkboxShowPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.checkboxShowPass.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.checkboxShowPass.Checked = False
        Me.checkboxShowPass.CheckedOnColor = System.Drawing.Color.White
        Me.tran.SetDecoration(Me.checkboxShowPass, BunifuAnimatorNS.DecorationType.None)
        Me.checkboxShowPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkboxShowPass.Location = New System.Drawing.Point(102, 537)
        Me.checkboxShowPass.Name = "checkboxShowPass"
        Me.checkboxShowPass.Size = New System.Drawing.Size(20, 20)
        Me.checkboxShowPass.TabIndex = 12
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.tran.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(128, 541)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(93, 16)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Show password"
        '
        'lbThongBao
        '
        Me.lbThongBao.AutoSize = True
        Me.tran.SetDecoration(Me.lbThongBao, BunifuAnimatorNS.DecorationType.None)
        Me.lbThongBao.ForeColor = System.Drawing.Color.Red
        Me.lbThongBao.Location = New System.Drawing.Point(196, 145)
        Me.lbThongBao.Name = "lbThongBao"
        Me.lbThongBao.Size = New System.Drawing.Size(118, 13)
        Me.lbThongBao.TabIndex = 14
        Me.lbThongBao.Text = "(*) không được để rỗng"
        '
        'drag1
        '
        Me.drag1.Fixed = True
        Me.drag1.Horizontal = True
        Me.drag1.TargetControl = Me
        Me.drag1.Vertical = True
        '
        'drag2
        '
        Me.drag2.Fixed = True
        Me.drag2.Horizontal = True
        Me.drag2.TargetControl = Me.picSignUp
        Me.drag2.Vertical = True
        '
        'tran
        '
        Me.tran.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tran.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
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
        Me.tran.DefaultAnimation = Animation1
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tran.SetDecoration(Me.picClose, BunifuAnimatorNS.DecorationType.None)
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(469, 133)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(24, 24)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 15
        Me.picClose.TabStop = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.tran.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(47, 339)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(17, 24)
        Me.BunifuCustomLabel4.TabIndex = 18
        Me.BunifuCustomLabel4.Text = "*"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.tran.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(47, 411)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(17, 24)
        Me.BunifuCustomLabel5.TabIndex = 19
        Me.BunifuCustomLabel5.Text = "*"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.tran.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(48, 482)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(17, 24)
        Me.BunifuCustomLabel6.TabIndex = 20
        Me.BunifuCustomLabel6.Text = "*"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.tran.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(48, 255)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(17, 24)
        Me.BunifuCustomLabel2.TabIndex = 21
        Me.BunifuCustomLabel2.Text = "*"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.tran.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(47, 183)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(17, 24)
        Me.BunifuCustomLabel3.TabIndex = 22
        Me.BunifuCustomLabel3.Text = "*"
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lbThongBao)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.checkboxShowPass)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picSignUp)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.tran.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "FormSignUp"
        Me.Size = New System.Drawing.Size(501, 670)
        CType(Me.picSignUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtLname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnCreateAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents picSignUp As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents checkboxShowPass As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbThongBao As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents drag1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents drag2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents tran As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents picClose As PictureBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
