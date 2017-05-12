<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooking))
        Me.pbCustomer = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbNumDay = New System.Windows.Forms.TextBox()
        Me.cbRoom = New System.Windows.Forms.ComboBox()
        Me.lbComment = New System.Windows.Forms.Label()
        Me.lbNumDay = New System.Windows.Forms.Label()
        Me.lbCustomer = New System.Windows.Forms.Label()
        Me.lbRoom = New System.Windows.Forms.Label()
        Me.lbChecking = New System.Windows.Forms.Label()
        Me.pbNumDay = New System.Windows.Forms.PictureBox()
        Me.lbGuest = New System.Windows.Forms.Label()
        Me.pbGuest = New System.Windows.Forms.PictureBox()
        Me.tbGuest = New System.Windows.Forms.TextBox()
        Me.lbBooking = New System.Windows.Forms.Label()
        Me.tbComment = New System.Windows.Forms.TextBox()
        Me.dtBooking = New System.Windows.Forms.DateTimePicker()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pbRoom = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.lbList = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
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
        Me.tbBookingId = New System.Windows.Forms.TextBox()
        Me.mnsAboutHelp = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbComment = New System.Windows.Forms.PictureBox()
        Me.dtChecking = New System.Windows.Forms.DateTimePicker()
        Me.cbCustomer = New System.Windows.Forms.ComboBox()
        CType(Me.pbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNumDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsAboutHelp.SuspendLayout()
        CType(Me.pbComment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCustomer
        '
        Me.pbCustomer.Image = CType(resources.GetObject("pbCustomer.Image"), System.Drawing.Image)
        Me.pbCustomer.Location = New System.Drawing.Point(357, 110)
        Me.pbCustomer.Name = "pbCustomer"
        Me.pbCustomer.Size = New System.Drawing.Size(20, 20)
        Me.pbCustomer.TabIndex = 41
        Me.pbCustomer.TabStop = False
        Me.pbCustomer.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(413, 65)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Insert"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbNumDay
        '
        Me.tbNumDay.Location = New System.Drawing.Point(105, 151)
        Me.tbNumDay.Name = "tbNumDay"
        Me.tbNumDay.Size = New System.Drawing.Size(235, 20)
        Me.tbNumDay.TabIndex = 33
        '
        'cbRoom
        '
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.Location = New System.Drawing.Point(104, 67)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(235, 21)
        Me.cbRoom.TabIndex = 31
        '
        'lbComment
        '
        Me.lbComment.AutoSize = True
        Me.lbComment.Location = New System.Drawing.Point(23, 302)
        Me.lbComment.Name = "lbComment"
        Me.lbComment.Size = New System.Drawing.Size(51, 13)
        Me.lbComment.TabIndex = 30
        Me.lbComment.Text = "Comment"
        '
        'lbNumDay
        '
        Me.lbNumDay.AutoSize = True
        Me.lbNumDay.Location = New System.Drawing.Point(23, 154)
        Me.lbNumDay.Name = "lbNumDay"
        Me.lbNumDay.Size = New System.Drawing.Size(68, 13)
        Me.lbNumDay.TabIndex = 27
        Me.lbNumDay.Text = "Num of Days"
        '
        'lbCustomer
        '
        Me.lbCustomer.AutoSize = True
        Me.lbCustomer.Location = New System.Drawing.Point(21, 113)
        Me.lbCustomer.Name = "lbCustomer"
        Me.lbCustomer.Size = New System.Drawing.Size(65, 13)
        Me.lbCustomer.TabIndex = 25
        Me.lbCustomer.Text = "Customer ID"
        '
        'lbRoom
        '
        Me.lbRoom.AutoSize = True
        Me.lbRoom.Location = New System.Drawing.Point(22, 70)
        Me.lbRoom.Name = "lbRoom"
        Me.lbRoom.Size = New System.Drawing.Size(35, 13)
        Me.lbRoom.TabIndex = 24
        Me.lbRoom.Text = "Room"
        '
        'lbChecking
        '
        Me.lbChecking.AutoSize = True
        Me.lbChecking.Location = New System.Drawing.Point(20, 33)
        Me.lbChecking.Name = "lbChecking"
        Me.lbChecking.Size = New System.Drawing.Size(78, 13)
        Me.lbChecking.TabIndex = 23
        Me.lbChecking.Text = "Checking Date"
        '
        'pbNumDay
        '
        Me.pbNumDay.Image = CType(resources.GetObject("pbNumDay.Image"), System.Drawing.Image)
        Me.pbNumDay.Location = New System.Drawing.Point(357, 151)
        Me.pbNumDay.Name = "pbNumDay"
        Me.pbNumDay.Size = New System.Drawing.Size(20, 20)
        Me.pbNumDay.TabIndex = 48
        Me.pbNumDay.TabStop = False
        Me.pbNumDay.Visible = False
        '
        'lbGuest
        '
        Me.lbGuest.AutoSize = True
        Me.lbGuest.Location = New System.Drawing.Point(23, 195)
        Me.lbGuest.Name = "lbGuest"
        Me.lbGuest.Size = New System.Drawing.Size(77, 13)
        Me.lbGuest.TabIndex = 49
        Me.lbGuest.Text = "Num of Guests"
        '
        'pbGuest
        '
        Me.pbGuest.Image = CType(resources.GetObject("pbGuest.Image"), System.Drawing.Image)
        Me.pbGuest.Location = New System.Drawing.Point(357, 192)
        Me.pbGuest.Name = "pbGuest"
        Me.pbGuest.Size = New System.Drawing.Size(20, 20)
        Me.pbGuest.TabIndex = 51
        Me.pbGuest.TabStop = False
        Me.pbGuest.Visible = False
        '
        'tbGuest
        '
        Me.tbGuest.Location = New System.Drawing.Point(106, 192)
        Me.tbGuest.Name = "tbGuest"
        Me.tbGuest.Size = New System.Drawing.Size(235, 20)
        Me.tbGuest.TabIndex = 50
        '
        'lbBooking
        '
        Me.lbBooking.AutoSize = True
        Me.lbBooking.Location = New System.Drawing.Point(23, 237)
        Me.lbBooking.Name = "lbBooking"
        Me.lbBooking.Size = New System.Drawing.Size(72, 13)
        Me.lbBooking.TabIndex = 52
        Me.lbBooking.Text = "Booking Date"
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(105, 302)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbComment.Size = New System.Drawing.Size(235, 109)
        Me.tbComment.TabIndex = 80
        '
        'dtBooking
        '
        Me.dtBooking.Location = New System.Drawing.Point(106, 231)
        Me.dtBooking.MaxDate = New Date(2017, 5, 11, 0, 0, 0, 0)
        Me.dtBooking.MinDate = New Date(1850, 1, 1, 0, 0, 0, 0)
        Me.dtBooking.Name = "dtBooking"
        Me.dtBooking.Size = New System.Drawing.Size(235, 20)
        Me.dtBooking.TabIndex = 81
        Me.dtBooking.Value = New Date(2017, 5, 11, 0, 0, 0, 0)
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(23, 272)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(58, 13)
        Me.lbTotal.TabIndex = 83
        Me.lbTotal.Text = "Total Price"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Location = New System.Drawing.Point(104, 269)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(235, 20)
        Me.tbTotal.TabIndex = 84
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(413, 272)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(150, 23)
        Me.btReset.TabIndex = 86
        Me.btReset.Text = "Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(413, 28)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(150, 23)
        Me.btnMenu.TabIndex = 87
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'pbRoom
        '
        Me.pbRoom.Image = CType(resources.GetObject("pbRoom.Image"), System.Drawing.Image)
        Me.pbRoom.Location = New System.Drawing.Point(357, 68)
        Me.pbRoom.Name = "pbRoom"
        Me.pbRoom.Size = New System.Drawing.Size(20, 20)
        Me.pbRoom.TabIndex = 88
        Me.pbRoom.TabStop = False
        Me.pbRoom.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(413, 232)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 23)
        Me.btnDelete.TabIndex = 97
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(413, 192)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 23)
        Me.btnUpdate.TabIndex = 96
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(413, 149)
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
        Me.btnView.Location = New System.Drawing.Point(413, 107)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(150, 23)
        Me.btnView.TabIndex = 108
        Me.btnView.Text = "View all "
        Me.btnView.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RNum, Me.RFloor, Me.RType, Me.RPrice, Me.RBed, Me.RAvai, Me.RDesc, Me.TotalPrice, Me.Comment})
        Me.dgvResult.Location = New System.Drawing.Point(26, 450)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.Size = New System.Drawing.Size(540, 140)
        Me.dgvResult.TabIndex = 111
        '
        'RNum
        '
        Me.RNum.HeaderText = "Booking Id"
        Me.RNum.Name = "RNum"
        Me.RNum.ReadOnly = True
        Me.RNum.Width = 50
        '
        'RFloor
        '
        Me.RFloor.HeaderText = "Room"
        Me.RFloor.Name = "RFloor"
        Me.RFloor.ReadOnly = True
        Me.RFloor.Width = 50
        '
        'RType
        '
        Me.RType.HeaderText = "Customer ID"
        Me.RType.Name = "RType"
        Me.RType.ReadOnly = True
        '
        'RPrice
        '
        Me.RPrice.HeaderText = "Checking Date"
        Me.RPrice.Name = "RPrice"
        Me.RPrice.ReadOnly = True
        Me.RPrice.Width = 50
        '
        'RBed
        '
        Me.RBed.HeaderText = "Booking Date"
        Me.RBed.Name = "RBed"
        Me.RBed.ReadOnly = True
        Me.RBed.Width = 50
        '
        'RAvai
        '
        Me.RAvai.HeaderText = "Num of Days"
        Me.RAvai.Name = "RAvai"
        Me.RAvai.ReadOnly = True
        '
        'RDesc
        '
        Me.RDesc.HeaderText = "Num of Guests"
        Me.RDesc.Name = "RDesc"
        Me.RDesc.ReadOnly = True
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'Comment
        '
        Me.Comment.HeaderText = "Comment"
        Me.Comment.Name = "Comment"
        Me.Comment.ReadOnly = True
        '
        'tbBookingId
        '
        Me.tbBookingId.Location = New System.Drawing.Point(413, 344)
        Me.tbBookingId.Name = "tbBookingId"
        Me.tbBookingId.Size = New System.Drawing.Size(120, 20)
        Me.tbBookingId.TabIndex = 112
        Me.tbBookingId.Visible = False
        '
        'mnsAboutHelp
        '
        Me.mnsAboutHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnsAboutHelp.Location = New System.Drawing.Point(0, 0)
        Me.mnsAboutHelp.Name = "mnsAboutHelp"
        Me.mnsAboutHelp.Size = New System.Drawing.Size(594, 24)
        Me.mnsAboutHelp.TabIndex = 113
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
        'pbComment
        '
        Me.pbComment.Image = CType(resources.GetObject("pbComment.Image"), System.Drawing.Image)
        Me.pbComment.Location = New System.Drawing.Point(357, 302)
        Me.pbComment.Name = "pbComment"
        Me.pbComment.Size = New System.Drawing.Size(20, 20)
        Me.pbComment.TabIndex = 114
        Me.pbComment.TabStop = False
        Me.pbComment.Visible = False
        '
        'dtChecking
        '
        Me.dtChecking.Location = New System.Drawing.Point(106, 31)
        Me.dtChecking.Name = "dtChecking"
        Me.dtChecking.Size = New System.Drawing.Size(235, 20)
        Me.dtChecking.TabIndex = 115
        '
        'cbCustomer
        '
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.Location = New System.Drawing.Point(104, 109)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(235, 21)
        Me.cbCustomer.TabIndex = 116
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 602)
        Me.Controls.Add(Me.cbCustomer)
        Me.Controls.Add(Me.dtChecking)
        Me.Controls.Add(Me.pbComment)
        Me.Controls.Add(Me.tbBookingId)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lbList)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pbRoom)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.dtBooking)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.lbBooking)
        Me.Controls.Add(Me.pbGuest)
        Me.Controls.Add(Me.tbGuest)
        Me.Controls.Add(Me.lbGuest)
        Me.Controls.Add(Me.pbNumDay)
        Me.Controls.Add(Me.pbCustomer)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbNumDay)
        Me.Controls.Add(Me.cbRoom)
        Me.Controls.Add(Me.lbComment)
        Me.Controls.Add(Me.lbNumDay)
        Me.Controls.Add(Me.lbCustomer)
        Me.Controls.Add(Me.lbRoom)
        Me.Controls.Add(Me.lbChecking)
        Me.Controls.Add(Me.mnsAboutHelp)
        Me.MainMenuStrip = Me.mnsAboutHelp
        Me.Name = "frmBooking"
        Me.Text = "frmBooking"
        CType(Me.pbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNumDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsAboutHelp.ResumeLayout(False)
        Me.mnsAboutHelp.PerformLayout()
        CType(Me.pbComment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tbNumDay As System.Windows.Forms.TextBox
    Friend WithEvents cbRoom As System.Windows.Forms.ComboBox
    Friend WithEvents lbComment As System.Windows.Forms.Label
    Friend WithEvents lbNumDay As System.Windows.Forms.Label
    Friend WithEvents lbCustomer As System.Windows.Forms.Label
    Friend WithEvents lbRoom As System.Windows.Forms.Label
    Friend WithEvents lbChecking As System.Windows.Forms.Label
    Friend WithEvents pbNumDay As System.Windows.Forms.PictureBox
    Friend WithEvents lbGuest As System.Windows.Forms.Label
    Friend WithEvents pbGuest As System.Windows.Forms.PictureBox
    Friend WithEvents tbGuest As System.Windows.Forms.TextBox
    Friend WithEvents lbBooking As System.Windows.Forms.Label
    Friend WithEvents tbComment As System.Windows.Forms.TextBox
    Friend WithEvents dtBooking As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents btReset As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents pbRoom As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents lbList As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
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
    Friend WithEvents tbBookingId As System.Windows.Forms.TextBox
    Friend WithEvents mnsAboutHelp As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbComment As System.Windows.Forms.PictureBox
    Friend WithEvents dtChecking As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCustomer As System.Windows.Forms.ComboBox
End Class
