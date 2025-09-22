<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        MenuStrip2 = New MenuStrip()
        menuFile = New ToolStripMenuItem()
        menuitemNewQuiz = New ToolStripMenuItem()
        menuitemSaveProgress = New ToolStripMenuItem()
        menuitemLoadProgress = New ToolStripMenuItem()
        menuitemPrint = New ToolStripMenuItem()
        menuitemExit = New ToolStripMenuItem()
        menuEdit = New ToolStripMenuItem()
        menuitemCopy = New ToolStripMenuItem()
        menuitemSelectAll = New ToolStripMenuItem()
        menuHelp = New ToolStripMenuItem()
        menuitemUserGuide = New ToolStripMenuItem()
        menuitemAbout = New ToolStripMenuItem()
        menuitemUpdates = New ToolStripMenuItem()
        MenuQuiz = New ToolStripMenuItem()
        labelWelcome = New Label()
        btnOpen = New Button()
        picLogout = New PictureBox()
        btnLogout = New Button()
        PictureBox1 = New PictureBox()
        lblHow = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        MenuStrip2.SuspendLayout()
        CType(picLogout, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackgroundImageLayout = ImageLayout.Stretch
        MenuStrip2.ImageScalingSize = New Size(24, 24)
        MenuStrip2.Items.AddRange(New ToolStripItem() {menuFile, menuEdit, menuHelp, MenuQuiz})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 33)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' menuFile
        ' 
        menuFile.DropDownItems.AddRange(New ToolStripItem() {menuitemNewQuiz, menuitemSaveProgress, menuitemLoadProgress, menuitemPrint, menuitemExit})
        menuFile.Name = "menuFile"
        menuFile.ShortcutKeys = Keys.Alt Or Keys.F
        menuFile.Size = New Size(54, 29)
        menuFile.Text = "File"
        ' 
        ' menuitemNewQuiz
        ' 
        menuitemNewQuiz.Name = "menuitemNewQuiz"
        menuitemNewQuiz.ShortcutKeys = Keys.Control Or Keys.N
        menuitemNewQuiz.Size = New Size(286, 34)
        menuitemNewQuiz.Text = "New Quiz"
        ' 
        ' menuitemSaveProgress
        ' 
        menuitemSaveProgress.Name = "menuitemSaveProgress"
        menuitemSaveProgress.ShortcutKeys = Keys.Control Or Keys.S
        menuitemSaveProgress.Size = New Size(286, 34)
        menuitemSaveProgress.Text = "Save Progress"
        ' 
        ' menuitemLoadProgress
        ' 
        menuitemLoadProgress.Name = "menuitemLoadProgress"
        menuitemLoadProgress.ShortcutKeys = Keys.Control Or Keys.L
        menuitemLoadProgress.Size = New Size(286, 34)
        menuitemLoadProgress.Text = "Load Progress"
        ' 
        ' menuitemPrint
        ' 
        menuitemPrint.Name = "menuitemPrint"
        menuitemPrint.ShortcutKeys = Keys.Control Or Keys.P
        menuitemPrint.Size = New Size(286, 34)
        menuitemPrint.Text = "Print"
        ' 
        ' menuitemExit
        ' 
        menuitemExit.Name = "menuitemExit"
        menuitemExit.ShortcutKeys = Keys.Alt Or Keys.F4
        menuitemExit.Size = New Size(286, 34)
        menuitemExit.Text = "Exit"
        ' 
        ' menuEdit
        ' 
        menuEdit.DropDownItems.AddRange(New ToolStripItem() {menuitemCopy, menuitemSelectAll})
        menuEdit.Name = "menuEdit"
        menuEdit.ShortcutKeys = Keys.Control Or Keys.E
        menuEdit.Size = New Size(58, 29)
        menuEdit.Text = "Edit"
        ' 
        ' menuitemCopy
        ' 
        menuitemCopy.Name = "menuitemCopy"
        menuitemCopy.ShortcutKeys = Keys.Control Or Keys.C
        menuitemCopy.Size = New Size(270, 34)
        menuitemCopy.Text = "Copy"
        ' 
        ' menuitemSelectAll
        ' 
        menuitemSelectAll.Name = "menuitemSelectAll"
        menuitemSelectAll.ShortcutKeys = Keys.Control Or Keys.A
        menuitemSelectAll.Size = New Size(270, 34)
        menuitemSelectAll.Text = "Select All"
        ' 
        ' menuHelp
        ' 
        menuHelp.DropDownItems.AddRange(New ToolStripItem() {menuitemUserGuide, menuitemAbout, menuitemUpdates})
        menuHelp.Name = "menuHelp"
        menuHelp.ShortcutKeys = Keys.Control Or Keys.H
        menuHelp.Size = New Size(65, 29)
        menuHelp.Text = "Help"
        ' 
        ' menuitemUserGuide
        ' 
        menuitemUserGuide.Name = "menuitemUserGuide"
        menuitemUserGuide.Size = New Size(270, 34)
        menuitemUserGuide.Text = "User Guide"
        ' 
        ' menuitemAbout
        ' 
        menuitemAbout.Name = "menuitemAbout"
        menuitemAbout.Size = New Size(270, 34)
        menuitemAbout.Text = "About"
        ' 
        ' menuitemUpdates
        ' 
        menuitemUpdates.Name = "menuitemUpdates"
        menuitemUpdates.Size = New Size(270, 34)
        menuitemUpdates.Text = "Check for Updates"
        ' 
        ' MenuQuiz
        ' 
        MenuQuiz.Name = "MenuQuiz"
        MenuQuiz.Size = New Size(64, 29)
        MenuQuiz.Text = "Quiz"
        ' 
        ' labelWelcome
        ' 
        labelWelcome.AutoSize = True
        labelWelcome.BackColor = SystemColors.ScrollBar
        labelWelcome.Font = New Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelWelcome.ForeColor = SystemColors.ActiveCaptionText
        labelWelcome.Location = New Point(386, 57)
        labelWelcome.Name = "labelWelcome"
        labelWelcome.Size = New Size(0, 48)
        labelWelcome.TabIndex = 10
        ' 
        ' btnOpen
        ' 
        btnOpen.BackColor = SystemColors.ActiveCaption
        btnOpen.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOpen.ForeColor = SystemColors.ActiveCaptionText
        btnOpen.Location = New Point(210, 332)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(135, 60)
        btnOpen.TabIndex = 13
        btnOpen.Text = "New Game"
        btnOpen.UseVisualStyleBackColor = False
        ' 
        ' picLogout
        ' 
        picLogout.BackColor = Color.Transparent
        picLogout.Image = CType(resources.GetObject("picLogout.Image"), Image)
        picLogout.Location = New Point(471, 163)
        picLogout.Name = "picLogout"
        picLogout.Size = New Size(143, 149)
        picLogout.SizeMode = PictureBoxSizeMode.Zoom
        picLogout.TabIndex = 14
        picLogout.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(255), CByte(71), CByte(76))
        btnLogout.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(471, 332)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(135, 60)
        btnLogout.TabIndex = 15
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(166, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' lblHow
        ' 
        lblHow.AutoSize = True
        lblHow.BackColor = Color.Transparent
        lblHow.Font = New Font("Tahoma", 11F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblHow.ForeColor = Color.White
        lblHow.Location = New Point(339, 404)
        lblHow.Name = "lblHow"
        lblHow.Size = New Size(128, 27)
        lblHow.TabIndex = 19
        lblHow.Text = "How to play"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(210, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(377, 39)
        Label2.TabIndex = 20
        Label2.Text = "The Galaxy Quiz Game"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(305, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 39)
        Label1.TabIndex = 21
        Label1.Text = "Welcome to"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(12, 422)
        Label3.Name = "Label3"
        Label3.Size = New Size(219, 19)
        Label3.TabIndex = 22
        Label3.Text = "Developed by: April Cabanilla"
        Label3.Visible = False
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(lblHow)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogout)
        Controls.Add(picLogout)
        Controls.Add(btnOpen)
        Controls.Add(labelWelcome)
        Controls.Add(MenuStrip2)
        Name = "MenuForm"
        Text = "MenuForm"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(picLogout, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuEdit As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuitemExit As ToolStripMenuItem
    Friend WithEvents menuitemCopy As ToolStripMenuItem
    Friend WithEvents labelWelcome As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents menuitemUserGuide As ToolStripMenuItem
    Friend WithEvents menuitemAbout As ToolStripMenuItem
    Friend WithEvents menuitemNewQuiz As ToolStripMenuItem
    Friend WithEvents menuitemUpdates As ToolStripMenuItem
    Friend WithEvents menuitemPrint As ToolStripMenuItem
    Friend WithEvents menuitemSelectAll As ToolStripMenuItem
    Friend WithEvents menuitemSaveProgress As ToolStripMenuItem
    Friend WithEvents MenuQuiz As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHow As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents menuitemLoadProgress As ToolStripMenuItem
    Friend WithEvents Label3 As Label
End Class
