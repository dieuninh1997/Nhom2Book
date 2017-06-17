<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.picLogin = New System.Windows.Forms.PictureBox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnLogIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.checkbox = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.drag1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lbSignUp = New System.Windows.Forms.LinkLabel()
        Me.lbThongbaoLoi = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tran1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FormSignUp1 = New NhomBook.FormSignUp()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'picLogin
        '
        Me.picLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.picLogin, BunifuAnimatorNS.DecorationType.None)
        Me.picLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.picLogin.Image = CType(resources.GetObject("picLogin.Image"), System.Drawing.Image)
        Me.picLogin.Location = New System.Drawing.Point(0, 0)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(501, 670)
        Me.picLogin.TabIndex = 0
        Me.picLogin.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran1.SetDecoration(Me.txtUser, BunifuAnimatorNS.DecorationType.None)
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.HintForeColor = System.Drawing.Color.Gray
        Me.txtUser.HintText = "username"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUser.LineIdleColor = System.Drawing.Color.White
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUser.LineThickness = 3
        Me.txtUser.Location = New System.Drawing.Point(91, 358)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(343, 44)
        Me.txtUser.TabIndex = 1
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran1.SetDecoration(Me.txtPass, BunifuAnimatorNS.DecorationType.None)
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.HintForeColor = System.Drawing.Color.Gray
        Me.txtPass.HintText = "password"
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPass.LineIdleColor = System.Drawing.Color.White
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(91, 410)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(343, 44)
        Me.txtPass.TabIndex = 1
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLogIn
        '
        Me.btnLogIn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.BorderRadius = 0
        Me.btnLogIn.ButtonText = "LOG IN"
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tran1.SetDecoration(Me.btnLogIn, BunifuAnimatorNS.DecorationType.None)
        Me.btnLogIn.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogIn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogIn.Iconimage = CType(resources.GetObject("btnLogIn.Iconimage"), System.Drawing.Image)
        Me.btnLogIn.Iconimage_right = Nothing
        Me.btnLogIn.Iconimage_right_Selected = Nothing
        Me.btnLogIn.Iconimage_Selected = Nothing
        Me.btnLogIn.IconMarginLeft = 0
        Me.btnLogIn.IconMarginRight = 0
        Me.btnLogIn.IconRightVisible = True
        Me.btnLogIn.IconRightZoom = 0R
        Me.btnLogIn.IconVisible = False
        Me.btnLogIn.IconZoom = 90.0R
        Me.btnLogIn.IsTab = False
        Me.btnLogIn.Location = New System.Drawing.Point(153, 538)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogIn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnLogIn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogIn.selected = False
        Me.btnLogIn.Size = New System.Drawing.Size(213, 48)
        Me.btnLogIn.TabIndex = 6
        Me.btnLogIn.Text = "LOG IN"
        Me.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogIn.Textcolor = System.Drawing.Color.White
        Me.btnLogIn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(64, 373)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(64, 425)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'checkbox
        '
        Me.checkbox.BackColor = System.Drawing.Color.White
        Me.checkbox.ChechedOffColor = System.Drawing.Color.Silver
        Me.checkbox.Checked = True
        Me.checkbox.CheckedOnColor = System.Drawing.Color.White
        Me.tran1.SetDecoration(Me.checkbox, BunifuAnimatorNS.DecorationType.None)
        Me.checkbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbox.Location = New System.Drawing.Point(91, 486)
        Me.checkbox.Name = "checkbox"
        Me.checkbox.Size = New System.Drawing.Size(20, 20)
        Me.checkbox.TabIndex = 9
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(117, 493)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(106, 13)
        Me.BunifuCustomLabel1.TabIndex = 10
        Me.BunifuCustomLabel1.Text = "Remember passwork"
        '
        'drag1
        '
        Me.drag1.Fixed = True
        Me.drag1.Horizontal = True
        Me.drag1.TargetControl = Me.picLogin
        Me.drag1.Vertical = True
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(169, 603)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(125, 13)
        Me.BunifuCustomLabel2.TabIndex = 11
        Me.BunifuCustomLabel2.Text = "Don't have an account? "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.tran1.SetDecoration(Me.LinkLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel1.Location = New System.Drawing.Point(291, 603)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 12
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.tran1.SetDecoration(Me.picClose, BunifuAnimatorNS.DecorationType.None)
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(468, 294)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(24, 24)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 14
        Me.picClose.TabStop = False
        '
        'lbSignUp
        '
        Me.lbSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbSignUp.AutoSize = True
        Me.lbSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.lbSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.lbSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSignUp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbSignUp.Location = New System.Drawing.Point(291, 603)
        Me.lbSignUp.Name = "lbSignUp"
        Me.lbSignUp.Size = New System.Drawing.Size(52, 13)
        Me.lbSignUp.TabIndex = 16
        Me.lbSignUp.TabStop = True
        Me.lbSignUp.Text = "Sign Up"
        '
        'lbThongbaoLoi
        '
        Me.lbThongbaoLoi.AutoSize = True
        Me.lbThongbaoLoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tran1.SetDecoration(Me.lbThongbaoLoi, BunifuAnimatorNS.DecorationType.None)
        Me.lbThongbaoLoi.ForeColor = System.Drawing.Color.Red
        Me.lbThongbaoLoi.Location = New System.Drawing.Point(117, 325)
        Me.lbThongbaoLoi.Name = "lbThongbaoLoi"
        Me.lbThongbaoLoi.Size = New System.Drawing.Size(55, 13)
        Me.lbThongbaoLoi.TabIndex = 17
        Me.lbThongbaoLoi.Text = "thông báo"
        '
        'tran1
        '
        Me.tran1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tran1.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 0!
        Me.tran1.DefaultAnimation = Animation5
        '
        'FormSignUp1
        '
        Me.FormSignUp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tran1.SetDecoration(Me.FormSignUp1, BunifuAnimatorNS.DecorationType.None)
        Me.FormSignUp1.Location = New System.Drawing.Point(0, 0)
        Me.FormSignUp1.Name = "FormSignUp1"
        Me.FormSignUp1.Size = New System.Drawing.Size(501, 670)
        Me.FormSignUp1.TabIndex = 18
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 670)
        Me.Controls.Add(Me.FormSignUp1)
        Me.Controls.Add(Me.lbThongbaoLoi)
        Me.Controls.Add(Me.lbSignUp)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.checkbox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.picLogin)
        Me.tran1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents picLogin As PictureBox
    Friend WithEvents btnLogIn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents checkbox As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents drag1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents lbSignUp As LinkLabel
    Friend WithEvents lbThongbaoLoi As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tran1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents FormSignUp1 As FormSignUp
End Class
