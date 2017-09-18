<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputBox))
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.lblInputBox = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInputBox
        '
        Me.txtInputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtInputBox.Font = New System.Drawing.Font("News Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputBox.Location = New System.Drawing.Point(12, 83)
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(375, 31)
        Me.txtInputBox.TabIndex = 0
        '
        'lblInputBox
        '
        Me.lblInputBox.AutoSize = True
        Me.lblInputBox.Font = New System.Drawing.Font("News Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputBox.Location = New System.Drawing.Point(12, 44)
        Me.lblInputBox.Name = "lblInputBox"
        Me.lblInputBox.Size = New System.Drawing.Size(288, 19)
        Me.lblInputBox.TabIndex = 1
        Me.lblInputBox.Text = "Please Enter Your Text Below:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Napa SF", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(432, 30)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 45)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Napa SF", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(432, 83)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(91, 40)
        Me.btnOkay.TabIndex = 3
        Me.btnOkay.Text = "OK"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'frmInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 139)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblInputBox)
        Me.Controls.Add(Me.txtInputBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputBox"
        Me.Text = "English Spelling ABC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputBox As System.Windows.Forms.TextBox
    Friend WithEvents lblInputBox As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button

End Class
