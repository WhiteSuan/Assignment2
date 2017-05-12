<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbFName = New System.Windows.Forms.Label()
        Me.lbLName = New System.Windows.Forms.Label()
        Me.lbDob = New System.Windows.Forms.Label()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.cbTitle = New System.Windows.Forms.ComboBox()
        Me.tbFName = New System.Windows.Forms.TextBox()
        Me.tbLName = New System.Windows.Forms.TextBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pbFName = New System.Windows.Forms.PictureBox()
        Me.pbLName = New System.Windows.Forms.PictureBox()
        Me.pbPhone = New System.Windows.Forms.PictureBox()
        Me.pbAddress = New System.Windows.Forms.PictureBox()
        Me.pbEmail = New System.Windows.Forms.PictureBox()
        Me.pbDob = New System.Windows.Forms.PictureBox()
        Me.dtDob = New System.Windows.Forms.DateTimePicker()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pbTitle = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.lbList = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.tbGender = New System.Windows.Forms.TextBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.RNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RBed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAvai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbCustomerId = New System.Windows.Forms.TextBox()
        Me.mnsAboutHelp = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbFName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsAboutHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Location = New System.Drawing.Point(22, 36)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(27, 13)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "Title"
        '
        'lbFName
        '
        Me.lbFName.AutoSize = True
        Me.lbFName.Location = New System.Drawing.Point(21, 76)
        Me.lbFName.Name = "lbFName"
        Me.lbFName.Size = New System.Drawing.Size(57, 13)
        Me.lbFName.TabIndex = 1
        Me.lbFName.Text = "First Name"
        '
        'lbLName
        '
        Me.lbLName.AutoSize = True
        Me.lbLName.Location = New System.Drawing.Point(21, 123)
        Me.lbLName.Name = "lbLName"
        Me.lbLName.Size = New System.Drawing.Size(58, 13)
        Me.lbLName.TabIndex = 2
        Me.lbLName.Text = "Last Name"
        '
        'lbDob
        '
        Me.lbDob.AutoSize = True
        Me.lbDob.Location = New System.Drawing.Point(22, 339)
        Me.lbDob.Name = "lbDob"
        Me.lbDob.Size = New System.Drawing.Size(30, 13)
        Me.lbDob.TabIndex = 3
        Me.lbDob.Text = "DOB"
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Location = New System.Drawing.Point(22, 163)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(42, 13)
        Me.lbGender.TabIndex = 4
        Me.lbGender.Text = "Gender"
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Location = New System.Drawing.Point(22, 210)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(38, 13)
        Me.lbPhone.TabIndex = 5
        Me.lbPhone.Text = "Phone"
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Location = New System.Drawing.Point(22, 251)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(45, 13)
        Me.lbAddress.TabIndex = 6
        Me.lbAddress.Text = "Address"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(22, 294)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 7
        Me.lbEmail.Text = "Email"
        '
        'cbTitle
        '
        Me.cbTitle.FormattingEnabled = True
        Me.cbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Ms"})
        Me.cbTitle.Location = New System.Drawing.Point(104, 33)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(235, 21)
        Me.cbTitle.TabIndex = 9
        '
        'tbFName
        '
        Me.tbFName.Location = New System.Drawing.Point(104, 73)
        Me.tbFName.Name = "tbFName"
        Me.tbFName.Size = New System.Drawing.Size(235, 20)
        Me.tbFName.TabIndex = 10
        '
        'tbLName
        '
        Me.tbLName.Location = New System.Drawing.Point(104, 120)
        Me.tbLName.Name = "tbLName"
        Me.tbLName.Size = New System.Drawing.Size(235, 20)
        Me.tbLName.TabIndex = 11
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(104, 207)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(235, 20)
        Me.tbPhone.TabIndex = 13
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(104, 248)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(235, 20)
        Me.tbAddress.TabIndex = 14
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(104, 291)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(235, 20)
        Me.tbEmail.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(416, 76)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Insert"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pbFName
        '
        Me.pbFName.Image = CType(resources.GetObject("pbFName.Image"), System.Drawing.Image)
        Me.pbFName.Location = New System.Drawing.Point(360, 73)
        Me.pbFName.Name = "pbFName"
        Me.pbFName.Size = New System.Drawing.Size(20, 20)
        Me.pbFName.TabIndex = 17
        Me.pbFName.TabStop = False
        Me.pbFName.Visible = False
        '
        'pbLName
        '
        Me.pbLName.Image = CType(resources.GetObject("pbLName.Image"), System.Drawing.Image)
        Me.pbLName.Location = New System.Drawing.Point(360, 120)
        Me.pbLName.Name = "pbLName"
        Me.pbLName.Size = New System.Drawing.Size(20, 20)
        Me.pbLName.TabIndex = 18
        Me.pbLName.TabStop = False
        Me.pbLName.Visible = False
        '
        'pbPhone
        '
        Me.pbPhone.Image = CType(resources.GetObject("pbPhone.Image"), System.Drawing.Image)
        Me.pbPhone.Location = New System.Drawing.Point(360, 207)
        Me.pbPhone.Name = "pbPhone"
        Me.pbPhone.Size = New System.Drawing.Size(20, 20)
        Me.pbPhone.TabIndex = 19
        Me.pbPhone.TabStop = False
        Me.pbPhone.Visible = False
        '
        'pbAddress
        '
        Me.pbAddress.Image = CType(resources.GetObject("pbAddress.Image"), System.Drawing.Image)
        Me.pbAddress.Location = New System.Drawing.Point(360, 248)
        Me.pbAddress.Name = "pbAddress"
        Me.pbAddress.Size = New System.Drawing.Size(20, 20)
        Me.pbAddress.TabIndex = 20
        Me.pbAddress.TabStop = False
        Me.pbAddress.Visible = False
        '
        'pbEmail
        '
        Me.pbEmail.Image = CType(resources.GetObject("pbEmail.Image"), System.Drawing.Image)
        Me.pbEmail.Location = New System.Drawing.Point(360, 291)
        Me.pbEmail.Name = "pbEmail"
        Me.pbEmail.Size = New System.Drawing.Size(20, 20)
        Me.pbEmail.TabIndex = 21
        Me.pbEmail.TabStop = False
        Me.pbEmail.Visible = False
        '
        'pbDob
        '
        Me.pbDob.Image = CType(resources.GetObject("pbDob.Image"), System.Drawing.Image)
        Me.pbDob.Location = New System.Drawing.Point(360, 336)
        Me.pbDob.Name = "pbDob"
        Me.pbDob.Size = New System.Drawing.Size(20, 20)
        Me.pbDob.TabIndex = 22
        Me.pbDob.TabStop = False
        Me.pbDob.Visible = False
        '
        'dtDob
        '
        Me.dtDob.Location = New System.Drawing.Point(104, 336)
        Me.dtDob.MaxDate = New Date(2017, 5, 11, 0, 0, 0, 0)
        Me.dtDob.MinDate = New Date(1850, 1, 1, 0, 0, 0, 0)
        Me.dtDob.Name = "dtDob"
        Me.dtDob.Size = New System.Drawing.Size(235, 20)
        Me.dtDob.TabIndex = 23
        Me.dtDob.Value = New Date(2017, 5, 11, 0, 0, 0, 0)
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(416, 289)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(150, 23)
        Me.btReset.TabIndex = 87
        Me.btReset.Text = "Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(416, 33)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(150, 23)
        Me.btnMenu.TabIndex = 88
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'pbTitle
        '
        Me.pbTitle.Image = CType(resources.GetObject("pbTitle.Image"), System.Drawing.Image)
        Me.pbTitle.Location = New System.Drawing.Point(360, 33)
        Me.pbTitle.Name = "pbTitle"
        Me.pbTitle.Size = New System.Drawing.Size(20, 20)
        Me.pbTitle.TabIndex = 89
        Me.pbTitle.TabStop = False
        Me.pbTitle.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(416, 245)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 23)
        Me.btnDelete.TabIndex = 97
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(416, 205)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 23)
        Me.btnUpdate.TabIndex = 96
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(416, 158)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(150, 23)
        Me.btnSearch.TabIndex = 95
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(443, 421)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(53, 23)
        Me.btnNext.TabIndex = 106
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(513, 421)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(53, 23)
        Me.btnLast.TabIndex = 105
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(94, 421)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(53, 23)
        Me.btnPrevious.TabIndex = 104
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(26, 421)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(53, 23)
        Me.btnFirst.TabIndex = 103
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'lbList
        '
        Me.lbList.AutoSize = True
        Me.lbList.Location = New System.Drawing.Point(255, 426)
        Me.lbList.Name = "lbList"
        Me.lbList.Size = New System.Drawing.Size(73, 13)
        Me.lbList.TabIndex = 102
        Me.lbList.Text = "List of Results"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(416, 118)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(150, 23)
        Me.btnView.TabIndex = 107
        Me.btnView.Text = "View all "
        Me.btnView.UseVisualStyleBackColor = True
        '
        'tbGender
        '
        Me.tbGender.Enabled = False
        Me.tbGender.Location = New System.Drawing.Point(104, 163)
        Me.tbGender.Name = "tbGender"
        Me.tbGender.Size = New System.Drawing.Size(235, 20)
        Me.tbGender.TabIndex = 108
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RNum, Me.RFloor, Me.RType, Me.RPrice, Me.RBed, Me.RAvai, Me.RDesc, Me.TotalPrice, Me.Comment})
        Me.dgvResult.Location = New System.Drawing.Point(26, 450)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.Size = New System.Drawing.Size(540, 140)
        Me.dgvResult.TabIndex = 112
        '
        'RNum
        '
        Me.RNum.HeaderText = "Customer Id"
        Me.RNum.Name = "RNum"
        Me.RNum.ReadOnly = True
        Me.RNum.Width = 50
        '
        'RFloor
        '
        Me.RFloor.HeaderText = "Title"
        Me.RFloor.Name = "RFloor"
        Me.RFloor.ReadOnly = True
        Me.RFloor.Width = 50
        '
        'RType
        '
        Me.RType.HeaderText = "First Name"
        Me.RType.Name = "RType"
        Me.RType.ReadOnly = True
        '
        'RPrice
        '
        Me.RPrice.HeaderText = "Last Name"
        Me.RPrice.Name = "RPrice"
        Me.RPrice.ReadOnly = True
        Me.RPrice.Width = 50
        '
        'RBed
        '
        Me.RBed.HeaderText = "Gender "
        Me.RBed.Name = "RBed"
        Me.RBed.ReadOnly = True
        Me.RBed.Width = 50
        '
        'RAvai
        '
        Me.RAvai.HeaderText = "Phone"
        Me.RAvai.Name = "RAvai"
        Me.RAvai.ReadOnly = True
        '
        'RDesc
        '
        Me.RDesc.HeaderText = "Address"
        Me.RDesc.Name = "RDesc"
        Me.RDesc.ReadOnly = True
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Email"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'Comment
        '
        Me.Comment.HeaderText = "DOB"
        Me.Comment.Name = "Comment"
        Me.Comment.ReadOnly = True
        '
        'tbCustomerId
        '
        Me.tbCustomerId.Location = New System.Drawing.Point(416, 339)
        Me.tbCustomerId.Name = "tbCustomerId"
        Me.tbCustomerId.Size = New System.Drawing.Size(112, 20)
        Me.tbCustomerId.TabIndex = 113
        Me.tbCustomerId.Visible = False
        '
        'mnsAboutHelp
        '
        Me.mnsAboutHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnsAboutHelp.Location = New System.Drawing.Point(0, 0)
        Me.mnsAboutHelp.Name = "mnsAboutHelp"
        Me.mnsAboutHelp.Size = New System.Drawing.Size(594, 24)
        Me.mnsAboutHelp.TabIndex = 114
        Me.mnsAboutHelp.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 602)
        Me.Controls.Add(Me.tbCustomerId)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.tbGender)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lbList)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pbTitle)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.dtDob)
        Me.Controls.Add(Me.pbDob)
        Me.Controls.Add(Me.pbEmail)
        Me.Controls.Add(Me.pbAddress)
        Me.Controls.Add(Me.pbPhone)
        Me.Controls.Add(Me.pbLName)
        Me.Controls.Add(Me.pbFName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.tbLName)
        Me.Controls.Add(Me.tbFName)
        Me.Controls.Add(Me.cbTitle)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbAddress)
        Me.Controls.Add(Me.lbPhone)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.lbDob)
        Me.Controls.Add(Me.lbLName)
        Me.Controls.Add(Me.lbFName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.mnsAboutHelp)
        Me.MainMenuStrip = Me.mnsAboutHelp
        Me.Name = "frmCustomer"
        Me.Text = "Customer Details"
        CType(Me.pbFName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsAboutHelp.ResumeLayout(False)
        Me.mnsAboutHelp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents lbFName As System.Windows.Forms.Label
    Friend WithEvents lbLName As System.Windows.Forms.Label
    Friend WithEvents lbDob As System.Windows.Forms.Label
    Friend WithEvents lbGender As System.Windows.Forms.Label
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents cbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents tbFName As System.Windows.Forms.TextBox
    Friend WithEvents tbLName As System.Windows.Forms.TextBox
    Friend WithEvents tbPhone As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pbFName As System.Windows.Forms.PictureBox
    Friend WithEvents pbLName As System.Windows.Forms.PictureBox
    Friend WithEvents pbPhone As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddress As System.Windows.Forms.PictureBox
    Friend WithEvents pbEmail As System.Windows.Forms.PictureBox
    Friend WithEvents pbDob As System.Windows.Forms.PictureBox
    Friend WithEvents dtDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents btReset As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents pbTitle As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents lbList As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents tbGender As System.Windows.Forms.TextBox
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents RNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFloor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RBed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAvai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents mnsAboutHelp As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
