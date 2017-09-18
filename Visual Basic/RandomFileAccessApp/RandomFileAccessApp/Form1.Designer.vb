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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtCreate = New System.Windows.Forms.TextBox()
        Me.lblCreateName = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtSurnameSearch = New System.Windows.Forms.TextBox()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        Me.txtIDSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(22, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(499, 275)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.btnCreate)
        Me.TabPage3.Controls.Add(Me.txtCreate)
        Me.TabPage3.Controls.Add(Me.lblCreateName)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(491, 249)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Create"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(45, 179)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(260, 23)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtCreate
        '
        Me.txtCreate.Location = New System.Drawing.Point(45, 99)
        Me.txtCreate.Name = "txtCreate"
        Me.txtCreate.Size = New System.Drawing.Size(260, 20)
        Me.txtCreate.TabIndex = 1
        '
        'lblCreateName
        '
        Me.lblCreateName.AutoSize = True
        Me.lblCreateName.Location = New System.Drawing.Point(42, 72)
        Me.lblCreateName.Name = "lblCreateName"
        Me.lblCreateName.Size = New System.Drawing.Size(54, 13)
        Me.lblCreateName.TabIndex = 0
        Me.lblCreateName.Text = "File Name"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnInsert)
        Me.TabPage4.Controls.Add(Me.txtSurname)
        Me.TabPage4.Controls.Add(Me.txtName)
        Me.TabPage4.Controls.Add(Me.txtID)
        Me.TabPage4.Controls.Add(Me.lblSurname)
        Me.TabPage4.Controls.Add(Me.lblName)
        Me.TabPage4.Controls.Add(Me.lblID)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(491, 249)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Input"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(78, 168)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(209, 23)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(78, 111)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(209, 20)
        Me.txtSurname.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(78, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(209, 20)
        Me.txtName.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(78, 32)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(209, 20)
        Me.txtID.TabIndex = 3
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(23, 114)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "Surname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 77)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(32, 40)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.LstOutput)
        Me.TabPage5.Controls.Add(Me.btnRead)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(491, 249)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Output"
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.Location = New System.Drawing.Point(22, 30)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(439, 95)
        Me.LstOutput.TabIndex = 1
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(152, 199)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.btnDelete)
        Me.TabPage6.Controls.Add(Me.btnUpdate)
        Me.TabPage6.Controls.Add(Me.btnFind)
        Me.TabPage6.Controls.Add(Me.txtSurnameSearch)
        Me.TabPage6.Controls.Add(Me.txtNameSearch)
        Me.TabPage6.Controls.Add(Me.txtIDSearch)
        Me.TabPage6.Controls.Add(Me.Label1)
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(491, 249)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Search"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(202, 178)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(32, 178)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(313, 28)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 12
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtSurnameSearch
        '
        Me.txtSurnameSearch.Location = New System.Drawing.Point(84, 110)
        Me.txtSurnameSearch.Name = "txtSurnameSearch"
        Me.txtSurnameSearch.Size = New System.Drawing.Size(209, 20)
        Me.txtSurnameSearch.TabIndex = 11
        '
        'txtNameSearch
        '
        Me.txtNameSearch.Location = New System.Drawing.Point(84, 68)
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(209, 20)
        Me.txtNameSearch.TabIndex = 10
        '
        'txtIDSearch
        '
        Me.txtIDSearch.Location = New System.Drawing.Point(84, 31)
        Me.txtIDSearch.Name = "txtIDSearch"
        Me.txtIDSearch.Size = New System.Drawing.Size(209, 20)
        Me.txtIDSearch.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 346)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 396)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtCreate As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateName As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents LstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtSurnameSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtIDSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
