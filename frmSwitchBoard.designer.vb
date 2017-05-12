<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSwitchBoard
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnManufacturer = New System.Windows.Forms.Button()
        Me.btnWatches = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.mnsAboutHelp = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsAboutHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(12, 33)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(475, 25)
        Me.lblHeading.TabIndex = 11
        Me.lblHeading.Text = "Hotel Room Reservation Information System"
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(283, 77)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(93, 32)
        Me.btnRoom.TabIndex = 19
        Me.btnRoom.Text = "Room"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(184, 77)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(93, 32)
        Me.btnBooking.TabIndex = 18
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(93, 77)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(86, 32)
        Me.btnCustomer.TabIndex = 17
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnManufacturer
        '
        Me.btnManufacturer.Location = New System.Drawing.Point(184, 53)
        Me.btnManufacturer.Name = "btnManufacturer"
        Me.btnManufacturer.Size = New System.Drawing.Size(93, 32)
        Me.btnManufacturer.TabIndex = 18
        Me.btnManufacturer.Text = "Booking"
        Me.btnManufacturer.UseVisualStyleBackColor = True
        '
        'btnWatches
        '
        Me.btnWatches.Location = New System.Drawing.Point(93, 53)
        Me.btnWatches.Name = "btnWatches"
        Me.btnWatches.Size = New System.Drawing.Size(86, 32)
        Me.btnWatches.TabIndex = 17
        Me.btnWatches.Text = "Customer"
        Me.btnWatches.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(184, 129)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(93, 32)
        Me.btnReport.TabIndex = 20
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'mnsAboutHelp
        '
        Me.mnsAboutHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnsAboutHelp.Location = New System.Drawing.Point(0, 0)
        Me.mnsAboutHelp.Name = "mnsAboutHelp"
        Me.mnsAboutHelp.Size = New System.Drawing.Size(497, 24)
        Me.mnsAboutHelp.TabIndex = 21
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
        'frmSwitchBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 191)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnsAboutHelp)
        Me.MainMenuStrip = Me.mnsAboutHelp
        Me.Name = "frmSwitchBoard"
        Me.Text = "Menu"
        Me.mnsAboutHelp.ResumeLayout(False)
        Me.mnsAboutHelp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnRoom As System.Windows.Forms.Button
    Friend WithEvents btnBooking As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnManufacturer As System.Windows.Forms.Button
    Friend WithEvents btnWatches As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents mnsAboutHelp As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
