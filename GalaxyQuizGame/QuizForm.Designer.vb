<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizForm))
        picQuestionImage = New PictureBox()
        btnChoice1 = New Button()
        btnChoice2 = New Button()
        btnChoice3 = New Button()
        btnChoice4 = New Button()
        btnNext = New Button()
        lblFeedback = New Label()
        lblQuestion = New Label()
        CType(picQuestionImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picQuestionImage
        ' 
        picQuestionImage.Image = CType(resources.GetObject("picQuestionImage.Image"), Image)
        picQuestionImage.Location = New Point(12, 12)
        picQuestionImage.Name = "picQuestionImage"
        picQuestionImage.Size = New Size(689, 369)
        picQuestionImage.SizeMode = PictureBoxSizeMode.StretchImage
        picQuestionImage.TabIndex = 0
        picQuestionImage.TabStop = False
        ' 
        ' btnChoice1
        ' 
        btnChoice1.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChoice1.Location = New Point(38, 489)
        btnChoice1.Name = "btnChoice1"
        btnChoice1.Size = New Size(152, 68)
        btnChoice1.TabIndex = 2
        btnChoice1.Text = "Earth"
        btnChoice1.UseVisualStyleBackColor = True
        ' 
        ' btnChoice2
        ' 
        btnChoice2.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChoice2.Location = New Point(196, 489)
        btnChoice2.Name = "btnChoice2"
        btnChoice2.Size = New Size(152, 68)
        btnChoice2.TabIndex = 3
        btnChoice2.Text = "Mars"
        btnChoice2.UseVisualStyleBackColor = True
        ' 
        ' btnChoice3
        ' 
        btnChoice3.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChoice3.Location = New Point(354, 489)
        btnChoice3.Name = "btnChoice3"
        btnChoice3.Size = New Size(152, 68)
        btnChoice3.TabIndex = 4
        btnChoice3.Text = "Jupiter"
        btnChoice3.UseVisualStyleBackColor = True
        ' 
        ' btnChoice4
        ' 
        btnChoice4.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChoice4.Location = New Point(512, 489)
        btnChoice4.Name = "btnChoice4"
        btnChoice4.Size = New Size(152, 68)
        btnChoice4.TabIndex = 5
        btnChoice4.Text = "Saturn"
        btnChoice4.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(118, 639)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(473, 34)
        btnNext.TabIndex = 6
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' lblFeedback
        ' 
        lblFeedback.BackColor = Color.Transparent
        lblFeedback.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFeedback.ForeColor = SystemColors.ControlLightLight
        lblFeedback.Location = New Point(49, 575)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(590, 61)
        lblFeedback.TabIndex = 7
        lblFeedback.Text = "Feedback"
        ' 
        ' lblQuestion
        ' 
        lblQuestion.BackColor = Color.Transparent
        lblQuestion.Font = New Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestion.ForeColor = SystemColors.ButtonHighlight
        lblQuestion.Location = New Point(38, 401)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(626, 85)
        lblQuestion.TabIndex = 8
        lblQuestion.Text = "What is the largest planet in the Solar System?"
        ' 
        ' QuizForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(716, 701)
        Controls.Add(lblQuestion)
        Controls.Add(lblFeedback)
        Controls.Add(btnNext)
        Controls.Add(btnChoice4)
        Controls.Add(btnChoice3)
        Controls.Add(btnChoice2)
        Controls.Add(btnChoice1)
        Controls.Add(picQuestionImage)
        Name = "QuizForm"
        Text = "Form1"
        CType(picQuestionImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picQuestionImage As PictureBox
    Friend WithEvents btnChoice1 As Button
    Friend WithEvents btnChoice2 As Button
    Friend WithEvents btnChoice3 As Button
    Friend WithEvents btnChoice4 As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblFeedback As Label
    Friend WithEvents lblQuestion As Label
End Class
