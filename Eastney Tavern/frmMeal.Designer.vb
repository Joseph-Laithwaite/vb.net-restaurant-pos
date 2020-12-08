<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeal
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
        Me.btnSaveRecord = New System.Windows.Forms.Button
        Me.cmbMenuEnter = New System.Windows.Forms.ComboBox
        Me.btnNextRecord = New System.Windows.Forms.Button
        Me.btnLastRecord = New System.Windows.Forms.Button
        Me.lstMeals = New System.Windows.Forms.ListBox
        Me.chkHistoric = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkInStock = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAllergyAdvice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMealName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMealID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMeal = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbMenuSelector = New System.Windows.Forms.ComboBox
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.btnNewMeal = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveRecord.Location = New System.Drawing.Point(436, 210)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(89, 23)
        Me.btnSaveRecord.TabIndex = 109
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = False
        '
        'cmbMenuEnter
        '
        Me.cmbMenuEnter.FormattingEnabled = True
        Me.cmbMenuEnter.Location = New System.Drawing.Point(145, 121)
        Me.cmbMenuEnter.Name = "cmbMenuEnter"
        Me.cmbMenuEnter.Size = New System.Drawing.Size(108, 21)
        Me.cmbMenuEnter.TabIndex = 108
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNextRecord.Location = New System.Drawing.Point(531, 210)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(89, 23)
        Me.btnNextRecord.TabIndex = 107
        Me.btnNextRecord.Text = "Next Record"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLastRecord.Location = New System.Drawing.Point(341, 210)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(89, 23)
        Me.btnLastRecord.TabIndex = 105
        Me.btnLastRecord.Text = "Last Record"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'lstMeals
        '
        Me.lstMeals.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMeals.FormattingEnabled = True
        Me.lstMeals.HorizontalScrollbar = True
        Me.lstMeals.ItemHeight = 14
        Me.lstMeals.Location = New System.Drawing.Point(17, 250)
        Me.lstMeals.Name = "lstMeals"
        Me.lstMeals.Size = New System.Drawing.Size(620, 102)
        Me.lstMeals.TabIndex = 104
        '
        'chkHistoric
        '
        Me.chkHistoric.AutoSize = True
        Me.chkHistoric.Location = New System.Drawing.Point(467, 175)
        Me.chkHistoric.Name = "chkHistoric"
        Me.chkHistoric.Size = New System.Drawing.Size(15, 14)
        Me.chkHistoric.TabIndex = 103
        Me.chkHistoric.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(377, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Historic"
        '
        'chkInStock
        '
        Me.chkInStock.AutoSize = True
        Me.chkInStock.Checked = True
        Me.chkInStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInStock.Location = New System.Drawing.Point(467, 151)
        Me.chkInStock.Name = "chkInStock"
        Me.chkInStock.Size = New System.Drawing.Size(15, 14)
        Me.chkInStock.TabIndex = 101
        Me.chkInStock.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(377, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "In Stock"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(467, 122)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(108, 20)
        Me.txtCost.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(377, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Cost"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(467, 96)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(108, 20)
        Me.txtPrice.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(377, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Price"
        '
        'txtAllergyAdvice
        '
        Me.txtAllergyAdvice.Location = New System.Drawing.Point(467, 70)
        Me.txtAllergyAdvice.Name = "txtAllergyAdvice"
        Me.txtAllergyAdvice.Size = New System.Drawing.Size(108, 20)
        Me.txtAllergyAdvice.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(377, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Allergy Advice"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(55, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Menu"
        '
        'txtMealName
        '
        Me.txtMealName.Location = New System.Drawing.Point(145, 96)
        Me.txtMealName.Name = "txtMealName"
        Me.txtMealName.Size = New System.Drawing.Size(108, 20)
        Me.txtMealName.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Meal Name"
        '
        'txtMealID
        '
        Me.txtMealID.Location = New System.Drawing.Point(145, 70)
        Me.txtMealID.Name = "txtMealID"
        Me.txtMealID.ReadOnly = True
        Me.txtMealID.Size = New System.Drawing.Size(108, 20)
        Me.txtMealID.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Meal ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(187, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Meal"
        '
        'cmbMeal
        '
        Me.cmbMeal.FormattingEnabled = True
        Me.cmbMeal.Location = New System.Drawing.Point(223, 13)
        Me.cmbMeal.Name = "cmbMeal"
        Me.cmbMeal.Size = New System.Drawing.Size(108, 21)
        Me.cmbMeal.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(21, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Menu"
        '
        'cmbMenuSelector
        '
        Me.cmbMenuSelector.FormattingEnabled = True
        Me.cmbMenuSelector.Location = New System.Drawing.Point(61, 13)
        Me.cmbMenuSelector.Name = "cmbMenuSelector"
        Me.cmbMenuSelector.Size = New System.Drawing.Size(108, 21)
        Me.cmbMenuSelector.TabIndex = 85
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMainMenu.Location = New System.Drawing.Point(515, 19)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnMainMenu.TabIndex = 84
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnNewMeal
        '
        Me.btnNewMeal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNewMeal.Location = New System.Drawing.Point(17, 19)
        Me.btnNewMeal.Name = "btnNewMeal"
        Me.btnNewMeal.Size = New System.Drawing.Size(105, 23)
        Me.btnNewMeal.TabIndex = 83
        Me.btnNewMeal.Text = "New Meal"
        Me.btnNewMeal.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(246, 210)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 23)
        Me.btnPrint.TabIndex = 110
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMeal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbMenuSelector)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(143, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 45)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'frmMeal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(649, 366)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.cmbMenuEnter)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.lstMeals)
        Me.Controls.Add(Me.chkHistoric)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkInStock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAllergyAdvice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMealName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMealID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnNewMeal)
        Me.Name = "frmMeal"
        Me.Text = "Meal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveRecord As System.Windows.Forms.Button
    Friend WithEvents cmbMenuEnter As System.Windows.Forms.ComboBox
    Friend WithEvents btnNextRecord As System.Windows.Forms.Button
    Friend WithEvents btnLastRecord As System.Windows.Forms.Button
    Friend WithEvents lstMeals As System.Windows.Forms.ListBox
    Friend WithEvents chkHistoric As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkInStock As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAllergyAdvice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMealName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMealID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMeal As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbMenuSelector As System.Windows.Forms.ComboBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnNewMeal As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
