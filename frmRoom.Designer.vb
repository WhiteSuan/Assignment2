<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoom))
        Me.pbAvai = New System.Windows.Forms.PictureBox()
        Me.lbAvai = New System.Windows.Forms.Label()
        Me.pbBed = New System.Windows.Forms.PictureBox()
        Me.pbFloor = New System.Windows.Forms.PictureBox()
        Me.tbRNum = New System.Windows.Forms.TextBox()
        Me.pbRPrice = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbRPrice = New System.Windows.Forms.TextBox()
        Me.tbBed = New System.Windows.Forms.TextBox()
        Me.lbDescrip = New System.Windows.Forms.Label()
        Me.lbBed = New System.Windows.Forms.Label()
        Me.lbRPrice = New System.Windows.Forms.Label()
        Me.lbRType = New System.Windows.Forms.Label()
        Me.lbRNum = New System.Windows.Forms.Label()
        Me.cbAvai = New System.Windows.Forms.ComboBox()
        Me.pbRType = New System.Windows.Forms.PictureBox()
        Me.tbDescrip = New System.Windows.Forms.TextBox()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lbFloor = New System.Windows.Forms.Label()
        Me.cbFloor = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lbList = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.pbRNum = New System.Windows.Forms.PictureBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.RNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RBed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAvai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnsAboutHelp = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbRType = New System.Windows.Forms.TextBox()
        Me.pbDescrip = New System.Windows.Forms.PictureBox()
        CType(Me.pbAvai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsAboutHelp.SuspendLayout()
        CType(Me.pbDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAvai
        '
        Me.pbAvai.Image = CType(resources.GetObject("pbAvai.Image"), System.Drawing.Image)
        Me.pbAvai.Location = New System.Drawing.Point(366, 241)
        Me.pbAvai.Name = "pbAvai"
        Me.pbAvai.Size = New System.Drawing.Size(20, 20)
        Me.pbAvai.TabIndex = 72
        Me.pbAvai.TabStop = False
        Me.pbAvai.Visible = False
        '
        'lbAvai
        '
        Me.lbAvai.AutoSize = True
        Me.lbAvai.Location = New System.Drawing.Point(24, 243)
        Me.lbAvai.Name = "lbAvai"
        Me.lbAvai.Size = New System.Drawing.Size(56, 13)
        Me.lbAvai.TabIndex = 70
        Me.lbAvai.Text = "Availability"
        '
        'pbBed
        '
        Me.pbBed.Image = CType(resources.GetObject("pbBed.Image"), System.Drawing.Image)
        Me.pbBed.Location = New System.Drawing.Point(365, 193)
        Me.pbBed.Name = "pbBed"
        Me.pbBed.Size = New System.Drawing.Size(20, 20)
        Me.pbBed.TabIndex = 69
        Me.pbBed.TabStop = False
        Me.pbBed.Visible = False
        '
        'pbFloor
        '
        Me.pbFloor.Image = CType(resources.GetObject("pbFloor.Image"), System.Drawing.Image)
        Me.pbFloor.Location = New System.Drawing.Point(365, 27)
        Me.pbFloor.Name = "pbFloor"
        Me.pbFloor.Size = New System.Drawing.Size(20, 20)
        Me.pbFloor.TabIndex = 68
        Me.pbFloor.TabStop = False
        Me.pbFloor.Visible = False
        '
        'tbRNum
        '
        Me.tbRNum.Location = New System.Drawing.Point(108, 69)
        Me.tbRNum.Name = "tbRNum"
        Me.tbRNum.Size = New System.Drawing.Size(235, 20)
        Me.tbRNum.TabIndex = 67
        '
        'pbRPrice
        '
        Me.pbRPrice.Image = CType(resources.GetObject("pbRPrice.Image"), System.Drawing.Image)
        Me.pbRPrice.Location = New System.Drawing.Point(365, 153)
        Me.pbRPrice.Name = "pbRPrice"
        Me.pbRPrice.Size = New System.Drawing.Size(20, 20)
        Me.pbRPrice.TabIndex = 65
        Me.pbRPrice.TabStop = False
        Me.pbRPrice.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(417, 67)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 23)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Insert"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbRPrice
        '
        Me.tbRPrice.Location = New System.Drawing.Point(107, 153)
        Me.tbRPrice.Name = "tbRPrice"
        Me.tbRPrice.Size = New System.Drawing.Size(235, 20)
        Me.tbRPrice.TabIndex = 62
        '
        'tbBed
        '
        Me.tbBed.Location = New System.Drawing.Point(107, 193)
        Me.tbBed.Name = "tbBed"
        Me.tbBed.Size = New System.Drawing.Size(235, 20)
        Me.tbBed.TabIndex = 61
        '
        'lbDescrip
        '
        Me.lbDescrip.AutoSize = True
        Me.lbDescrip.Location = New System.Drawing.Point(26, 294)
        Me.lbDescrip.Name = "lbDescrip"
        Me.lbDescrip.Size = New System.Drawing.Size(60, 13)
        Me.lbDescrip.TabIndex = 59
        Me.lbDescrip.Text = "Description"
        '
        'lbBed
        '
        Me.lbBed.AutoSize = True
        Me.lbBed.Location = New System.Drawing.Point(25, 196)
        Me.lbBed.Name = "lbBed"
        Me.lbBed.Size = New System.Drawing.Size(68, 13)
        Me.lbBed.TabIndex = 58
        Me.lbBed.Text = "Num of Beds"
        '
        'lbRPrice
        '
        Me.lbRPrice.AutoSize = True
        Me.lbRPrice.Location = New System.Drawing.Point(24, 156)
        Me.lbRPrice.Name = "lbRPrice"
        Me.lbRPrice.Size = New System.Drawing.Size(62, 13)
        Me.lbRPrice.TabIndex = 57
        Me.lbRPrice.Text = "Room Price"
        '
        'lbRType
        '
        Me.lbRType.AutoSize = True
        Me.lbRType.Location = New System.Drawing.Point(24, 109)
        Me.lbRType.Name = "lbRType"
        Me.lbRType.Size = New System.Drawing.Size(62, 13)
        Me.lbRType.TabIndex = 56
        Me.lbRType.Text = "Room Type"
        '
        'lbRNum
        '
        Me.lbRNum.AutoSize = True
        Me.lbRNum.Location = New System.Drawing.Point(25, 69)
        Me.lbRNum.Name = "lbRNum"
        Me.lbRNum.Size = New System.Drawing.Size(75, 13)
        Me.lbRNum.TabIndex = 55
        Me.lbRNum.Text = "Room Number"
        '
        'cbAvai
        '
        Me.cbAvai.FormattingEnabled = True
        Me.cbAvai.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbAvai.Location = New System.Drawing.Point(107, 240)
        Me.cbAvai.Name = "cbAvai"
        Me.cbAvai.Size = New System.Drawing.Size(235, 21)
        Me.cbAvai.TabIndex = 76
        '
        'pbRType
        '
        Me.pbRType.Image = CType(resources.GetObject("pbRType.Image"), System.Drawing.Image)
        Me.pbRType.Location = New System.Drawing.Point(365, 109)
        Me.pbRType.Name = "pbRType"
        Me.pbRType.Size = New System.Drawing.Size(20, 20)
        Me.pbRType.TabIndex = 78
        Me.pbRType.TabStop = False
        Me.pbRType.Visible = False
        '
        'tbDescrip
        '
        Me.tbDescrip.Location = New System.Drawing.Point(108, 294)
        Me.tbDescrip.MaxLength = 5000
        Me.tbDescrip.Multiline = True
        Me.tbDescrip.Name = "tbDescrip"
        Me.tbDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDescrip.Size = New System.Drawing.Size(235, 109)
        Me.tbDescrip.TabIndex = 79
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(417, 285)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(150, 23)
        Me.btReset.TabIndex = 87
        Me.btReset.Text = "Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(417, 24)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(150, 23)
        Me.btnMenu.TabIndex = 89
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lbFloor
        '
        Me.lbFloor.AutoSize = True
        Me.lbFloor.Location = New System.Drawing.Point(25, 29)
        Me.lbFloor.Name = "lbFloor"
        Me.lbFloor.Size = New System.Drawing.Size(30, 13)
        Me.lbFloor.TabIndex = 90
        Me.lbFloor.Text = "Floor"
        '
        'cbFloor
        '
        Me.cbFloor.FormattingEnabled = True
        Me.cbFloor.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbFloor.Location = New System.Drawing.Point(107, 26)
        Me.cbFloor.Name = "cbFloor"
        Me.cbFloor.Size = New System.Drawing.Size(235, 21)
        Me.cbFloor.TabIndex = 91
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(417, 151)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(150, 23)
        Me.btnSearch.TabIndex = 92
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(417, 196)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 23)
        Me.btnUpdate.TabIndex = 93
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(417, 238)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 23)
        Me.btnDelete.TabIndex = 94
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lbList
        '
        Me.lbList.AutoSize = True
        Me.lbList.Location = New System.Drawing.Point(256, 426)
        Me.lbList.Name = "lbList"
        Me.lbList.Size = New System.Drawing.Size(73, 13)
        Me.lbList.TabIndex = 96
        Me.lbList.Text = "List of Results"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(27, 421)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(53, 23)
        Me.btnFirst.TabIndex = 97
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(95, 421)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(53, 23)
        Me.btnPrevious.TabIndex = 98
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(514, 421)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(53, 23)
        Me.btnLast.TabIndex = 99
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(444, 421)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(53, 23)
        Me.btnNext.TabIndex = 100
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(417, 109)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(150, 23)
        Me.btnView.TabIndex = 108
        Me.btnView.Text = "View all "
        Me.btnView.UseVisualStyleBackColor = True
        '
        'pbRNum
        '
        Me.pbRNum.Image = CType(resources.GetObject("pbRNum.Image"), System.Drawing.Image)
        Me.pbRNum.Location = New System.Drawing.Point(366, 70)
        Me.pbRNum.Name = "pbRNum"
        Me.pbRNum.Size = New System.Drawing.Size(20, 20)
        Me.pbRNum.TabIndex = 109
        Me.pbRNum.TabStop = False
        Me.pbRNum.Visible = False
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RNum, Me.RFloor, Me.RType, Me.RPrice, Me.RBed, Me.RAvai, Me.RDesc})
        Me.dgvResult.Location = New System.Drawing.Point(27, 450)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.Size = New System.Drawing.Size(540, 140)
        Me.dgvResult.TabIndex = 110
        '
        'RNum
        '
        Me.RNum.HeaderText = "Room Number"
        Me.RNum.Name = "RNum"
        Me.RNum.ReadOnly = True
        Me.RNum.Width = 50
        '
        'RFloor
        '
        Me.RFloor.HeaderText = "Floor"
        Me.RFloor.Name = "RFloor"
        Me.RFloor.ReadOnly = True
        Me.RFloor.Width = 50
        '
        'RType
        '
        Me.RType.HeaderText = "Type"
        Me.RType.Name = "RType"
        Me.RType.ReadOnly = True
        '
        'RPrice
        '
        Me.RPrice.HeaderText = "Price"
        Me.RPrice.Name = "RPrice"
        Me.RPrice.ReadOnly = True
        Me.RPrice.Width = 50
        '
        'RBed
        '
        Me.RBed.HeaderText = "Num of Beds"
        Me.RBed.Name = "RBed"
        Me.RBed.ReadOnly = True
        Me.RBed.Width = 50
        '
        'RAvai
        '
        Me.RAvai.HeaderText = "Availability"
        Me.RAvai.Name = "RAvai"
        Me.RAvai.ReadOnly = True
        '
        'RDesc
        '
        Me.RDesc.HeaderText = "Description"
        Me.RDesc.Name = "RDesc"
        Me.RDesc.ReadOnly = True
        '
        'mnsAboutHelp
        '
        Me.mnsAboutHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnsAboutHelp.Location = New System.Drawing.Point(0, 0)
        Me.mnsAboutHelp.Name = "mnsAboutHelp"
        Me.mnsAboutHelp.Size = New System.Drawing.Size(594, 24)
        Me.mnsAboutHelp.TabIndex = 111
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
        'tbRType
        '
        Me.tbRType.Location = New System.Drawing.Point(108, 109)
        Me.tbRType.Name = "tbRType"
        Me.tbRType.Size = New System.Drawing.Size(235, 20)
        Me.tbRType.TabIndex = 80
        '
        'pbDescrip
        '
        Me.pbDescrip.Image = CType(resources.GetObject("pbDescrip.Image"), System.Drawing.Image)
        Me.pbDescrip.Location = New System.Drawing.Point(366, 294)
        Me.pbDescrip.Name = "pbDescrip"
        Me.pbDescrip.Size = New System.Drawing.Size(20, 20)
        Me.pbDescrip.TabIndex = 112
        Me.pbDescrip.TabStop = False
        Me.pbDescrip.Visible = False
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 602)
        Me.Controls.Add(Me.pbDescrip)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.pbRNum)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lbList)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbFloor)
        Me.Controls.Add(Me.lbFloor)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.tbRType)
        Me.Controls.Add(Me.tbDescrip)
        Me.Controls.Add(Me.pbRType)
        Me.Controls.Add(Me.cbAvai)
        Me.Controls.Add(Me.pbAvai)
        Me.Controls.Add(Me.lbAvai)
        Me.Controls.Add(Me.pbBed)
        Me.Controls.Add(Me.pbFloor)
        Me.Controls.Add(Me.tbRNum)
        Me.Controls.Add(Me.pbRPrice)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbRPrice)
        Me.Controls.Add(Me.tbBed)
        Me.Controls.Add(Me.lbDescrip)
        Me.Controls.Add(Me.lbBed)
        Me.Controls.Add(Me.lbRPrice)
        Me.Controls.Add(Me.lbRType)
        Me.Controls.Add(Me.lbRNum)
        Me.Controls.Add(Me.mnsAboutHelp)
        Me.MainMenuStrip = Me.mnsAboutHelp
        Me.Name = "frmRoom"
        Me.Text = "Room Details"
        CType(Me.pbAvai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsAboutHelp.ResumeLayout(False)
        Me.mnsAboutHelp.PerformLayout()
        CType(Me.pbDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbAvai As System.Windows.Forms.PictureBox
    Friend WithEvents lbAvai As System.Windows.Forms.Label
    Friend WithEvents pbBed As System.Windows.Forms.PictureBox
    Friend WithEvents pbFloor As System.Windows.Forms.PictureBox
    Friend WithEvents tbRNum As System.Windows.Forms.TextBox
    Friend WithEvents pbRPrice As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tbRPrice As System.Windows.Forms.TextBox
    Friend WithEvents tbBed As System.Windows.Forms.TextBox
    Friend WithEvents lbDescrip As System.Windows.Forms.Label
    Friend WithEvents lbBed As System.Windows.Forms.Label
    Friend WithEvents lbRPrice As System.Windows.Forms.Label
    Friend WithEvents lbRType As System.Windows.Forms.Label
    Friend WithEvents lbRNum As System.Windows.Forms.Label
    Friend WithEvents cbAvai As System.Windows.Forms.ComboBox
    Friend WithEvents pbRType As System.Windows.Forms.PictureBox
    Friend WithEvents tbDescrip As System.Windows.Forms.TextBox
    Friend WithEvents btReset As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents lbFloor As System.Windows.Forms.Label
    Friend WithEvents cbFloor As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lbList As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents pbRNum As System.Windows.Forms.PictureBox
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents RNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFloor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RBed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAvai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnsAboutHelp As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbRType As System.Windows.Forms.TextBox
    Friend WithEvents pbDescrip As System.Windows.Forms.PictureBox
End Class
