<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchForm
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
        Me.lblFirstCriteria = New System.Windows.Forms.Label()
        Me.lblSecondCriteria = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbFirstCriteria = New System.Windows.Forms.TextBox()
        Me.tbSecondCriteria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirstCriteria
        '
        Me.lblFirstCriteria.AutoSize = True
        Me.lblFirstCriteria.Location = New System.Drawing.Point(12, 30)
        Me.lblFirstCriteria.Name = "lblFirstCriteria"
        Me.lblFirstCriteria.Size = New System.Drawing.Size(61, 13)
        Me.lblFirstCriteria.TabIndex = 0
        Me.lblFirstCriteria.Text = "First Criteria"
        '
        'lblSecondCriteria
        '
        Me.lblSecondCriteria.AutoSize = True
        Me.lblSecondCriteria.Location = New System.Drawing.Point(12, 83)
        Me.lblSecondCriteria.Name = "lblSecondCriteria"
        Me.lblSecondCriteria.Size = New System.Drawing.Size(79, 13)
        Me.lblSecondCriteria.TabIndex = 1
        Me.lblSecondCriteria.Text = "Second Criteria"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(125, 125)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbFirstCriteria
        '
        Me.tbFirstCriteria.Location = New System.Drawing.Point(114, 27)
        Me.tbFirstCriteria.Name = "tbFirstCriteria"
        Me.tbFirstCriteria.Size = New System.Drawing.Size(107, 20)
        Me.tbFirstCriteria.TabIndex = 3
        '
        'tbSecondCriteria
        '
        Me.tbSecondCriteria.Location = New System.Drawing.Point(114, 80)
        Me.tbSecondCriteria.Name = "tbSecondCriteria"
        Me.tbSecondCriteria.Size = New System.Drawing.Size(107, 20)
        Me.tbSecondCriteria.TabIndex = 4
        '
        'frmSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 175)
        Me.Controls.Add(Me.tbSecondCriteria)
        Me.Controls.Add(Me.tbFirstCriteria)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSecondCriteria)
        Me.Controls.Add(Me.lblFirstCriteria)
        Me.Name = "frmSearchForm"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstCriteria As System.Windows.Forms.Label
    Friend WithEvents lblSecondCriteria As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbFirstCriteria As System.Windows.Forms.TextBox
    Friend WithEvents tbSecondCriteria As System.Windows.Forms.TextBox
End Class
