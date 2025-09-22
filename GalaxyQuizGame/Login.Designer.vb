<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        labelPlease = New Label()
        labelLoginPage = New Label()
        picLog = New PictureBox()
        labelUser = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        labelPass = New Label()
        btnLogin = New Button()
        chckBox = New CheckBox()
        labelSupport = New Label()
        labelAbout = New Label()
        labelForgotPass = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLog, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(71), CByte(73), CByte(115))
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(labelPlease)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 498)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(35, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(279, 258)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' labelPlease
        ' 
        labelPlease.AutoSize = True
        labelPlease.BackColor = Color.Transparent
        labelPlease.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelPlease.ForeColor = SystemColors.Control
        labelPlease.Location = New Point(57, 341)
        labelPlease.Name = "labelPlease"
        labelPlease.Size = New Size(211, 48)
        labelPlease.TabIndex = 10
        labelPlease.Text = "Please login to access " & vbCrLf & "the application."
        labelPlease.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelLoginPage
        ' 
        labelLoginPage.AutoSize = True
        labelLoginPage.Font = New Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelLoginPage.Location = New Point(467, 21)
        labelLoginPage.Name = "labelLoginPage"
        labelLoginPage.Size = New Size(193, 34)
        labelLoginPage.TabIndex = 1
        labelLoginPage.Text = "LOGIN PAGE"
        ' 
        ' picLog
        ' 
        picLog.Image = CType(resources.GetObject("picLog.Image"), Image)
        picLog.Location = New Point(480, 67)
        picLog.Name = "picLog"
        picLog.Size = New Size(150, 75)
        picLog.SizeMode = PictureBoxSizeMode.Zoom
        picLog.TabIndex = 2
        picLog.TabStop = False
        ' 
        ' labelUser
        ' 
        labelUser.AutoSize = True
        labelUser.BackColor = Color.Transparent
        labelUser.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelUser.ForeColor = SystemColors.WindowText
        labelUser.Location = New Point(397, 163)
        labelUser.Name = "labelUser"
        labelUser.Size = New Size(100, 24)
        labelUser.TabIndex = 3
        labelUser.Text = "Username"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(397, 193)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(321, 31)
        txtUser.TabIndex = 4
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(397, 269)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(321, 31)
        txtPass.TabIndex = 6
        ' 
        ' labelPass
        ' 
        labelPass.AutoSize = True
        labelPass.BackColor = Color.Transparent
        labelPass.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelPass.ForeColor = SystemColors.WindowText
        labelPass.Location = New Point(397, 239)
        labelPass.Name = "labelPass"
        labelPass.Size = New Size(94, 24)
        labelPass.TabIndex = 5
        labelPass.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.GradientActiveCaption
        btnLogin.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(502, 342)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 51)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' chckBox
        ' 
        chckBox.AutoSize = True
        chckBox.Location = New Point(724, 271)
        chckBox.Name = "chckBox"
        chckBox.Size = New Size(63, 29)
        chckBox.TabIndex = 8
        chckBox.Text = "👀"
        chckBox.UseVisualStyleBackColor = True
        ' 
        ' labelSupport
        ' 
        labelSupport.AutoSize = True
        labelSupport.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelSupport.Location = New Point(716, 419)
        labelSupport.Name = "labelSupport"
        labelSupport.Size = New Size(72, 22)
        labelSupport.TabIndex = 9
        labelSupport.Text = "Support"
        ' 
        ' labelAbout
        ' 
        labelAbout.AutoSize = True
        labelAbout.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelAbout.Location = New Point(335, 419)
        labelAbout.Name = "labelAbout"
        labelAbout.Size = New Size(57, 22)
        labelAbout.TabIndex = 10
        labelAbout.Text = "About"
        ' 
        ' labelForgotPass
        ' 
        labelForgotPass.AutoSize = True
        labelForgotPass.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelForgotPass.Location = New Point(564, 303)
        labelForgotPass.Name = "labelForgotPass"
        labelForgotPass.Size = New Size(150, 22)
        labelForgotPass.TabIndex = 7
        labelForgotPass.Text = "Forgot Password?"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 450)
        Controls.Add(labelAbout)
        Controls.Add(labelSupport)
        Controls.Add(chckBox)
        Controls.Add(btnLogin)
        Controls.Add(labelForgotPass)
        Controls.Add(txtPass)
        Controls.Add(labelPass)
        Controls.Add(txtUser)
        Controls.Add(labelUser)
        Controls.Add(picLog)
        Controls.Add(labelLoginPage)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picLog, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelLoginPage As Label
    Friend WithEvents picLog As PictureBox
    Friend WithEvents labelUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents labelPass As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents chckBox As CheckBox
    Friend WithEvents labelPlease As Label
    Friend WithEvents labelSupport As Label
    Friend WithEvents labelAbout As Label
    Friend WithEvents labelForgotPass As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox

End Class
