<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnOrders = New System.Windows.Forms.Button
        Me.btnMeals = New System.Windows.Forms.Button
        Me.btnEmployees = New System.Windows.Forms.Button
        Me.btnReports = New System.Windows.Forms.Button
        Me.btnSettingsHelp = New System.Windows.Forms.Button
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrders
        '
        Me.btnOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOrders.Location = New System.Drawing.Point(12, 14)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(92, 35)
        Me.btnOrders.TabIndex = 0
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = False
        '
        'btnMeals
        '
        Me.btnMeals.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMeals.Location = New System.Drawing.Point(12, 55)
        Me.btnMeals.Name = "btnMeals"
        Me.btnMeals.Size = New System.Drawing.Size(92, 35)
        Me.btnMeals.TabIndex = 1
        Me.btnMeals.Text = "Meals"
        Me.btnMeals.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmployees.Location = New System.Drawing.Point(12, 96)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(92, 35)
        Me.btnEmployees.TabIndex = 2
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReports.Location = New System.Drawing.Point(12, 137)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(92, 35)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnSettingsHelp
        '
        Me.btnSettingsHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSettingsHelp.Location = New System.Drawing.Point(12, 178)
        Me.btnSettingsHelp.Name = "btnSettingsHelp"
        Me.btnSettingsHelp.Size = New System.Drawing.Size(92, 35)
        Me.btnSettingsHelp.TabIndex = 5
        Me.btnSettingsHelp.Text = "Settings/Help"
        Me.btnSettingsHelp.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogOut.Location = New System.Drawing.Point(124, 179)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(92, 35)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(237, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.EastneyTavernSept20041
        Me.PictureBox1.Location = New System.Drawing.Point(110, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(358, 238)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnSettingsHelp)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnMeals)
        Me.Controls.Add(Me.btnOrders)
        Me.Name = "frmMenu"
        Me.Text = "Eastney Tavern - Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOrders As System.Windows.Forms.Button
    Friend WithEvents btnMeals As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnSettingsHelp As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
