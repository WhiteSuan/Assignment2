<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportGenerate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportGenerate))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.cboReport = New System.Windows.Forms.ComboBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.lblOpenBy = New System.Windows.Forms.Label()
        Me.rdbFirefox = New System.Windows.Forms.RadioButton()
        Me.rdbChrome = New System.Windows.Forms.RadioButton()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.cboRoom = New System.Windows.Forms.ComboBox()
        Me.lblFromMonth = New System.Windows.Forms.Label()
        Me.lblFromYear = New System.Windows.Forms.Label()
        Me.lblToYear = New System.Windows.Forms.Label()
        Me.lblToMonth = New System.Windows.Forms.Label()
        Me.cboFromMonth = New System.Windows.Forms.ComboBox()
        Me.cboToMonth = New System.Windows.Forms.ComboBox()
        Me.tbFromYear = New System.Windows.Forms.TextBox()
        Me.tbToYear = New System.Windows.Forms.TextBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbTo = New System.Windows.Forms.PictureBox()
        Me.pbFrom = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(82, 42)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(428, 31)
        Me.lblHeading.TabIndex = 38
        Me.lblHeading.Text = "Hotel Room Reservation Report"
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(35, 91)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(105, 13)
        Me.lblReport.TabIndex = 39
        Me.lblReport.Text = "Report Generate:"
        '
        'cboReport
        '
        Me.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReport.FormattingEnabled = True
        Me.cboReport.Items.AddRange(New Object() {"Last booking of a customer and its duration (if any)", "Last booking of a room number and it's total price paid (if any)", "Number of rooms booked by a customer in a period", "Booking(s) made in a given month of a given year", "Customer(s) due checkin in a given month of a given year", "All the booking(s) for a room in a given month of a given year", "All the booking(s) in a given month of a given year broken down by room number", "All the invoice(s) in current year broken down by month"})
        Me.cboReport.Location = New System.Drawing.Point(38, 107)
        Me.cboReport.Name = "cboReport"
        Me.cboReport.Size = New System.Drawing.Size(508, 21)
        Me.cboReport.TabIndex = 40
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(216, 385)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(132, 34)
        Me.btnReport.TabIndex = 45
        Me.btnReport.Text = "Generate Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'lblOpenBy
        '
        Me.lblOpenBy.AutoSize = True
        Me.lblOpenBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenBy.Location = New System.Drawing.Point(35, 309)
        Me.lblOpenBy.Name = "lblOpenBy"
        Me.lblOpenBy.Size = New System.Drawing.Size(58, 13)
        Me.lblOpenBy.TabIndex = 46
        Me.lblOpenBy.Text = "Open by:"
        '
        'rdbFirefox
        '
        Me.rdbFirefox.AutoSize = True
        Me.rdbFirefox.Location = New System.Drawing.Point(124, 307)
        Me.rdbFirefox.Name = "rdbFirefox"
        Me.rdbFirefox.Size = New System.Drawing.Size(56, 17)
        Me.rdbFirefox.TabIndex = 47
        Me.rdbFirefox.TabStop = True
        Me.rdbFirefox.Text = "Firefox" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdbFirefox.UseVisualStyleBackColor = True
        '
        'rdbChrome
        '
        Me.rdbChrome.AutoSize = True
        Me.rdbChrome.Location = New System.Drawing.Point(287, 309)
        Me.rdbChrome.Name = "rdbChrome"
        Me.rdbChrome.Size = New System.Drawing.Size(61, 17)
        Me.rdbChrome.TabIndex = 48
        Me.rdbChrome.TabStop = True
        Me.rdbChrome.Text = "Chrome"
        Me.rdbChrome.UseVisualStyleBackColor = True
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(35, 158)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(63, 13)
        Me.lblCustomer.TabIndex = 52
        Me.lblCustomer.Text = "Customer:"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(124, 155)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(121, 21)
        Me.cboCustomer.TabIndex = 53
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(35, 158)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(90, 13)
        Me.lblRoom.TabIndex = 54
        Me.lblRoom.Text = "Room Number:"
        '
        'cboRoom
        '
        Me.cboRoom.FormattingEnabled = True
        Me.cboRoom.Location = New System.Drawing.Point(124, 155)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(121, 21)
        Me.cboRoom.TabIndex = 55
        '
        'lblFromMonth
        '
        Me.lblFromMonth.AutoSize = True
        Me.lblFromMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromMonth.Location = New System.Drawing.Point(35, 209)
        Me.lblFromMonth.Name = "lblFromMonth"
        Me.lblFromMonth.Size = New System.Drawing.Size(76, 13)
        Me.lblFromMonth.TabIndex = 56
        Me.lblFromMonth.Text = "From month:"
        '
        'lblFromYear
        '
        Me.lblFromYear.AutoSize = True
        Me.lblFromYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromYear.Location = New System.Drawing.Point(286, 209)
        Me.lblFromYear.Name = "lblFromYear"
        Me.lblFromYear.Size = New System.Drawing.Size(31, 13)
        Me.lblFromYear.TabIndex = 57
        Me.lblFromYear.Text = "year"
        '
        'lblToYear
        '
        Me.lblToYear.AutoSize = True
        Me.lblToYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToYear.Location = New System.Drawing.Point(286, 257)
        Me.lblToYear.Name = "lblToYear"
        Me.lblToYear.Size = New System.Drawing.Size(31, 13)
        Me.lblToYear.TabIndex = 59
        Me.lblToYear.Text = "year"
        '
        'lblToMonth
        '
        Me.lblToMonth.AutoSize = True
        Me.lblToMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToMonth.Location = New System.Drawing.Point(35, 254)
        Me.lblToMonth.Name = "lblToMonth"
        Me.lblToMonth.Size = New System.Drawing.Size(64, 13)
        Me.lblToMonth.TabIndex = 58
        Me.lblToMonth.Text = "To month:"
        '
        'cboFromMonth
        '
        Me.cboFromMonth.FormattingEnabled = True
        Me.cboFromMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboFromMonth.Location = New System.Drawing.Point(124, 206)
        Me.cboFromMonth.Name = "cboFromMonth"
        Me.cboFromMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboFromMonth.TabIndex = 60
        '
        'cboToMonth
        '
        Me.cboToMonth.FormattingEnabled = True
        Me.cboToMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboToMonth.Location = New System.Drawing.Point(124, 254)
        Me.cboToMonth.Name = "cboToMonth"
        Me.cboToMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboToMonth.TabIndex = 62
        '
        'tbFromYear
        '
        Me.tbFromYear.Location = New System.Drawing.Point(354, 206)
        Me.tbFromYear.Name = "tbFromYear"
        Me.tbFromYear.Size = New System.Drawing.Size(121, 20)
        Me.tbFromYear.TabIndex = 63
        '
        'tbToYear
        '
        Me.tbToYear.Location = New System.Drawing.Point(354, 251)
        Me.tbToYear.Name = "tbToYear"
        Me.tbToYear.Size = New System.Drawing.Size(121, 20)
        Me.tbToYear.TabIndex = 64
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(60, 209)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(46, 13)
        Me.lblMonth.TabIndex = 65
        Me.lblMonth.Text = "Month:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'pbTo
        '
        Me.pbTo.Enabled = False
        Me.pbTo.Image = CType(resources.GetObject("pbTo.Image"), System.Drawing.Image)
        Me.pbTo.Location = New System.Drawing.Point(490, 251)
        Me.pbTo.Name = "pbTo"
        Me.pbTo.Size = New System.Drawing.Size(20, 20)
        Me.pbTo.TabIndex = 90
        Me.pbTo.TabStop = False
        Me.pbTo.Visible = False
        '
        'pbFrom
        '
        Me.pbFrom.Enabled = False
        Me.pbFrom.Image = CType(resources.GetObject("pbFrom.Image"), System.Drawing.Image)
        Me.pbFrom.Location = New System.Drawing.Point(490, 206)
        Me.pbFrom.Name = "pbFrom"
        Me.pbFrom.Size = New System.Drawing.Size(20, 20)
        Me.pbFrom.TabIndex = 89
        Me.pbFrom.TabStop = False
        Me.pbFrom.Visible = False
        '
        'frmReportGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 478)
        Me.Controls.Add(Me.pbTo)
        Me.Controls.Add(Me.pbFrom)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.tbToYear)
        Me.Controls.Add(Me.tbFromYear)
        Me.Controls.Add(Me.cboToMonth)
        Me.Controls.Add(Me.cboFromMonth)
        Me.Controls.Add(Me.lblToYear)
        Me.Controls.Add(Me.lblToMonth)
        Me.Controls.Add(Me.lblFromYear)
        Me.Controls.Add(Me.lblFromMonth)
        Me.Controls.Add(Me.cboRoom)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.rdbChrome)
        Me.Controls.Add(Me.rdbFirefox)
        Me.Controls.Add(Me.lblOpenBy)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.cboReport)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReportGenerate"
        Me.Text = "Report Generate"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents cboReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents lblOpenBy As System.Windows.Forms.Label
    Friend WithEvents rdbFirefox As System.Windows.Forms.RadioButton
    Friend WithEvents rdbChrome As System.Windows.Forms.RadioButton
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents cboRoom As System.Windows.Forms.ComboBox
    Friend WithEvents lblFromMonth As System.Windows.Forms.Label
    Friend WithEvents lblFromYear As System.Windows.Forms.Label
    Friend WithEvents lblToYear As System.Windows.Forms.Label
    Friend WithEvents lblToMonth As System.Windows.Forms.Label
    Friend WithEvents cboFromMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboToMonth As System.Windows.Forms.ComboBox
    Friend WithEvents tbFromYear As System.Windows.Forms.TextBox
    Friend WithEvents tbToYear As System.Windows.Forms.TextBox
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbTo As System.Windows.Forms.PictureBox
    Friend WithEvents pbFrom As System.Windows.Forms.PictureBox
End Class
