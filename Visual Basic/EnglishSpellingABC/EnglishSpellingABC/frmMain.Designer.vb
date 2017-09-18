<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblWrongScore = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblNewWord = New System.Windows.Forms.Label()
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.btnShowWrongSpelling = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLinkHelp = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnRandom
        '
        Me.btnRandom.Image = CType(resources.GetObject("btnRandom.Image"), System.Drawing.Image)
        Me.btnRandom.Location = New System.Drawing.Point(162, 12)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(156, 126)
        Me.btnRandom.TabIndex = 0
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Old English Text MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Blue
        Me.lblScore.Location = New System.Drawing.Point(526, 35)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(37, 42)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        '
        'btnWrite
        '
        Me.btnWrite.BackColor = System.Drawing.Color.Lime
        Me.btnWrite.Font = New System.Drawing.Font("Moire", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(1, 12)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(146, 56)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Add New Words"
        Me.btnWrite.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 116)
        Me.btnExit.TabIndex = 5
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Moire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.ForeColor = System.Drawing.Color.Blue
        Me.lblCorrect.Location = New System.Drawing.Point(341, 51)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(170, 23)
        Me.lblCorrect.TabIndex = 6
        Me.lblCorrect.Text = "Correct Spelling:"
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Font = New System.Drawing.Font("Moire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.Red
        Me.lblWrong.Location = New System.Drawing.Point(341, 135)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(160, 23)
        Me.lblWrong.TabIndex = 7
        Me.lblWrong.Text = "Wrong Spelling:"
        '
        'lblWrongScore
        '
        Me.lblWrongScore.AutoSize = True
        Me.lblWrongScore.Font = New System.Drawing.Font("Old English Text MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrongScore.ForeColor = System.Drawing.Color.Red
        Me.lblWrongScore.Location = New System.Drawing.Point(526, 119)
        Me.lblWrongScore.Name = "lblWrongScore"
        Me.lblWrongScore.Size = New System.Drawing.Size(37, 42)
        Me.lblWrongScore.TabIndex = 8
        Me.lblWrongScore.Text = "0"
        '
        'txtUserInput
        '
        Me.txtUserInput.Font = New System.Drawing.Font("News Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInput.Location = New System.Drawing.Point(368, 214)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(276, 31)
        Me.txtUserInput.TabIndex = 12
        '
        'lblNewWord
        '
        Me.lblNewWord.AutoSize = True
        Me.lblNewWord.Font = New System.Drawing.Font("Moire", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewWord.Location = New System.Drawing.Point(82, 214)
        Me.lblNewWord.Name = "lblNewWord"
        Me.lblNewWord.Size = New System.Drawing.Size(280, 23)
        Me.lblNewWord.TabIndex = 13
        Me.lblNewWord.Text = "Enter New Word to Learn :"
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Location = New System.Drawing.Point(218, 257)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(115, 13)
        Me.lblLink.TabIndex = 14
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "www.waheedrafiq.com"
        '
        'btnShowWrongSpelling
        '
        Me.btnShowWrongSpelling.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowWrongSpelling.Font = New System.Drawing.Font("Moire", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowWrongSpelling.Location = New System.Drawing.Point(1, 74)
        Me.btnShowWrongSpelling.Name = "btnShowWrongSpelling"
        Me.btnShowWrongSpelling.Size = New System.Drawing.Size(146, 75)
        Me.btnShowWrongSpelling.TabIndex = 15
        Me.btnShowWrongSpelling.Text = "Wrong Spelling List"
        Me.btnShowWrongSpelling.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(592, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Version 1.1"
        '
        'lblLinkHelp
        '
        Me.lblLinkHelp.AutoSize = True
        Me.lblLinkHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinkHelp.Location = New System.Drawing.Point(585, 9)
        Me.lblLinkHelp.Name = "lblLinkHelp"
        Me.lblLinkHelp.Size = New System.Drawing.Size(37, 16)
        Me.lblLinkHelp.TabIndex = 17
        Me.lblLinkHelp.TabStop = True
        Me.lblLinkHelp.Text = "Help"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 276)
        Me.Controls.Add(Me.lblLinkHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShowWrongSpelling)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.lblNewWord)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblWrongScore)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnRandom)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "English Spelling ABC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents lblWrong As System.Windows.Forms.Label
    Friend WithEvents lblWrongScore As System.Windows.Forms.Label
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
    Friend WithEvents lblNewWord As System.Windows.Forms.Label
    Friend WithEvents lblLink As System.Windows.Forms.LinkLabel
    Friend WithEvents btnShowWrongSpelling As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLinkHelp As System.Windows.Forms.LinkLabel

End Class
