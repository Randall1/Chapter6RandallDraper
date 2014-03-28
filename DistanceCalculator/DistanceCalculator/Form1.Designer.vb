<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistanceCalculator
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.btnHours = New System.Windows.Forms.Button()
        Me.lstHours = New System.Windows.Forms.ListBox()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(352, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'txtSpeed
        '
        Me.txtSpeed.ForeColor = System.Drawing.Color.Black
        Me.txtSpeed.Location = New System.Drawing.Point(90, 29)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(30, 20)
        Me.txtSpeed.TabIndex = 2
        '
        'txtDays
        '
        Me.txtDays.ForeColor = System.Drawing.Color.Black
        Me.txtDays.Location = New System.Drawing.Point(90, 52)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(30, 20)
        Me.txtDays.TabIndex = 3
        '
        'btnHours
        '
        Me.btnHours.Location = New System.Drawing.Point(220, 27)
        Me.btnHours.Name = "btnHours"
        Me.btnHours.Size = New System.Drawing.Size(120, 23)
        Me.btnHours.TabIndex = 4
        Me.btnHours.Text = "Enter hours per Day"
        Me.btnHours.UseVisualStyleBackColor = True
        '
        'lstHours
        '
        Me.lstHours.FormattingEnabled = True
        Me.lstHours.Location = New System.Drawing.Point(295, 52)
        Me.lstHours.Name = "lstHours"
        Me.lstHours.Size = New System.Drawing.Size(45, 95)
        Me.lstHours.TabIndex = 5
        Me.lstHours.Visible = False
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.AutoSize = True
        Me.lblTotalMiles.Location = New System.Drawing.Point(130, 157)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(105, 13)
        Me.lblTotalMiles.TabIndex = 6
        Me.lblTotalMiles.Text = "Total miles for trip is: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTotalMiles.Visible = False
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblSpeed.Location = New System.Drawing.Point(25, 33)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(59, 13)
        Me.lblSpeed.TabIndex = 7
        Me.lblSpeed.Text = "Enter MPH"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.BackColor = System.Drawing.Color.Transparent
        Me.lblDays.Location = New System.Drawing.Point(28, 59)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(59, 13)
        Me.lblDays.TabIndex = 8
        Me.lblDays.Text = "Enter Days"
        '
        'DistanceCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DistanceCalculator.My.Resources.Resources.cabins
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(352, 341)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.lstHours)
        Me.Controls.Add(Me.btnHours)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "DistanceCalculator"
        Me.Text = "Distance Calculator"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents btnHours As System.Windows.Forms.Button
    Friend WithEvents lstHours As System.Windows.Forms.ListBox
    Friend WithEvents lblTotalMiles As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label

End Class
