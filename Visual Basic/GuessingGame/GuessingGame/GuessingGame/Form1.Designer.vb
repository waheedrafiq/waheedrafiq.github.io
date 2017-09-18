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
        Me.btnGuessNumber = New System.Windows.Forms.Button()
        Me.lblGuessPrompt = New System.Windows.Forms.Label()
        Me.msktbGuessNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuessNumber = New System.Windows.Forms.Label()
        Me.lblTooHigh = New System.Windows.Forms.Label()
        Me.lstHigherValues = New System.Windows.Forms.ListBox()
        Me.lblTooLow = New System.Windows.Forms.Label()
        Me.lstLowerValues = New System.Windows.Forms.ListBox()
        Me.lblGuessesSoFar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuessNumber
        '
        Me.btnGuessNumber.Location = New System.Drawing.Point(26, 303)
        Me.btnGuessNumber.Name = "btnGuessNumber"
        Me.btnGuessNumber.Size = New System.Drawing.Size(222, 23)
        Me.btnGuessNumber.TabIndex = 2
        Me.btnGuessNumber.Text = "Guess Number >>"
        Me.btnGuessNumber.UseVisualStyleBackColor = True
        '
        'lblGuessPrompt
        '
        Me.lblGuessPrompt.AutoSize = True
        Me.lblGuessPrompt.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessPrompt.Location = New System.Drawing.Point(12, 20)
        Me.lblGuessPrompt.Name = "lblGuessPrompt"
        Me.lblGuessPrompt.Size = New System.Drawing.Size(319, 19)
        Me.lblGuessPrompt.TabIndex = 3
        Me.lblGuessPrompt.Text = "Guess the number I'm thinking of (0 -100):"
        '
        'msktbGuessNumber
        '
        Me.msktbGuessNumber.Font = New System.Drawing.Font("Miramonte", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msktbGuessNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.msktbGuessNumber.Location = New System.Drawing.Point(110, 62)
        Me.msktbGuessNumber.Mask = "000"
        Me.msktbGuessNumber.Name = "msktbGuessNumber"
        Me.msktbGuessNumber.Size = New System.Drawing.Size(59, 41)
        Me.msktbGuessNumber.TabIndex = 4
        Me.msktbGuessNumber.Text = "000"
        '
        'lblGuessNumber
        '
        Me.lblGuessNumber.AutoSize = True
        Me.lblGuessNumber.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessNumber.Location = New System.Drawing.Point(22, 145)
        Me.lblGuessNumber.Name = "lblGuessNumber"
        Me.lblGuessNumber.Size = New System.Drawing.Size(253, 19)
        Me.lblGuessNumber.TabIndex = 5
        Me.lblGuessNumber.Text = "I have a number, Start Guessing !!"
        '
        'lblTooHigh
        '
        Me.lblTooHigh.AutoSize = True
        Me.lblTooHigh.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooHigh.Location = New System.Drawing.Point(404, 20)
        Me.lblTooHigh.Name = "lblTooHigh"
        Me.lblTooHigh.Size = New System.Drawing.Size(134, 19)
        Me.lblTooHigh.TabIndex = 6
        Me.lblTooHigh.Text = "Guesses too High"
        '
        'lstHigherValues
        '
        Me.lstHigherValues.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstHigherValues.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHigherValues.FormattingEnabled = True
        Me.lstHigherValues.ItemHeight = 19
        Me.lstHigherValues.Location = New System.Drawing.Point(408, 62)
        Me.lstHigherValues.Name = "lstHigherValues"
        Me.lstHigherValues.Size = New System.Drawing.Size(139, 80)
        Me.lstHigherValues.TabIndex = 7
        '
        'lblTooLow
        '
        Me.lblTooLow.AutoSize = True
        Me.lblTooLow.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooLow.Location = New System.Drawing.Point(404, 170)
        Me.lblTooLow.Name = "lblTooLow"
        Me.lblTooLow.Size = New System.Drawing.Size(128, 19)
        Me.lblTooLow.TabIndex = 8
        Me.lblTooLow.Text = "Guesses too Low"
        '
        'lstLowerValues
        '
        Me.lstLowerValues.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstLowerValues.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLowerValues.FormattingEnabled = True
        Me.lstLowerValues.ItemHeight = 19
        Me.lstLowerValues.Location = New System.Drawing.Point(408, 215)
        Me.lstLowerValues.Name = "lstLowerValues"
        Me.lstLowerValues.Size = New System.Drawing.Size(139, 80)
        Me.lstLowerValues.TabIndex = 9
        '
        'lblGuessesSoFar
        '
        Me.lblGuessesSoFar.AutoSize = True
        Me.lblGuessesSoFar.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessesSoFar.Location = New System.Drawing.Point(22, 215)
        Me.lblGuessesSoFar.Name = "lblGuessesSoFar"
        Me.lblGuessesSoFar.Size = New System.Drawing.Size(213, 19)
        Me.lblGuessesSoFar.TabIndex = 10
        Me.lblGuessesSoFar.Text = "Number of Guesses so far: 0"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 347)
        Me.Controls.Add(Me.lblGuessesSoFar)
        Me.Controls.Add(Me.lstLowerValues)
        Me.Controls.Add(Me.lblTooLow)
        Me.Controls.Add(Me.lstHigherValues)
        Me.Controls.Add(Me.lblTooHigh)
        Me.Controls.Add(Me.lblGuessNumber)
        Me.Controls.Add(Me.msktbGuessNumber)
        Me.Controls.Add(Me.lblGuessPrompt)
        Me.Controls.Add(Me.btnGuessNumber)
        Me.Name = "frmMain"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuessNumber As System.Windows.Forms.Button
    Friend WithEvents lblGuessPrompt As System.Windows.Forms.Label
    Friend WithEvents msktbGuessNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblGuessNumber As System.Windows.Forms.Label
    Friend WithEvents lblTooHigh As System.Windows.Forms.Label
    Friend WithEvents lstHigherValues As System.Windows.Forms.ListBox
    Friend WithEvents lblTooLow As System.Windows.Forms.Label
    Friend WithEvents lstLowerValues As System.Windows.Forms.ListBox
    Friend WithEvents lblGuessesSoFar As System.Windows.Forms.Label

End Class
