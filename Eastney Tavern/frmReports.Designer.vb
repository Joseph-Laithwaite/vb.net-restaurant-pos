<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lstReports = New System.Windows.Forms.ListBox
        Me.grpDateRange = New System.Windows.Forms.GroupBox
        Me.btnGrossProfit = New System.Windows.Forms.Button
        Me.datToDate = New System.Windows.Forms.DateTimePicker
        Me.datFromDate = New System.Windows.Forms.DateTimePicker
        Me.btnMeals = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEmployeePerformance = New System.Windows.Forms.Button
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnMealAlphabetical = New System.Windows.Forms.Button
        Me.btnMealSearch = New System.Windows.Forms.Button
        Me.btnByProfit = New System.Windows.Forms.Button
        Me.btnMealsByPopularity = New System.Windows.Forms.Button
        Me.btnMoneyTaken = New System.Windows.Forms.Button
        Me.btnEmployeeSearch = New System.Windows.Forms.Button
        Me.btnTablesServed = New System.Windows.Forms.Button
        Me.btnEmployeesAlphabetical = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.btnQarterly = New System.Windows.Forms.Button
        Me.btnMonthly = New System.Windows.Forms.Button
        Me.grpDateRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 271)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(0, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'lstReports
        '
        Me.lstReports.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReports.FormattingEnabled = True
        Me.lstReports.ItemHeight = 14
        Me.lstReports.Location = New System.Drawing.Point(12, 177)
        Me.lstReports.Name = "lstReports"
        Me.lstReports.Size = New System.Drawing.Size(559, 256)
        Me.lstReports.TabIndex = 1
        '
        'grpDateRange
        '
        Me.grpDateRange.Controls.Add(Me.btnGrossProfit)
        Me.grpDateRange.Controls.Add(Me.datToDate)
        Me.grpDateRange.Controls.Add(Me.datFromDate)
        Me.grpDateRange.Controls.Add(Me.btnMeals)
        Me.grpDateRange.Controls.Add(Me.Label2)
        Me.grpDateRange.Controls.Add(Me.Label1)
        Me.grpDateRange.Controls.Add(Me.btnEmployeePerformance)
        Me.grpDateRange.ForeColor = System.Drawing.Color.White
        Me.grpDateRange.Location = New System.Drawing.Point(42, 42)
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.Size = New System.Drawing.Size(506, 72)
        Me.grpDateRange.TabIndex = 2
        Me.grpDateRange.TabStop = False
        Me.grpDateRange.Text = "Date Range"
        '
        'btnGrossProfit
        '
        Me.btnGrossProfit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGrossProfit.ForeColor = System.Drawing.Color.Black
        Me.btnGrossProfit.Location = New System.Drawing.Point(401, 31)
        Me.btnGrossProfit.Name = "btnGrossProfit"
        Me.btnGrossProfit.Size = New System.Drawing.Size(91, 23)
        Me.btnGrossProfit.TabIndex = 12
        Me.btnGrossProfit.Text = "Gross Profits"
        Me.btnGrossProfit.UseVisualStyleBackColor = False
        '
        'datToDate
        '
        Me.datToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datToDate.Location = New System.Drawing.Point(66, 43)
        Me.datToDate.Name = "datToDate"
        Me.datToDate.Size = New System.Drawing.Size(96, 20)
        Me.datToDate.TabIndex = 11
        Me.datToDate.Value = New Date(2014, 10, 27, 0, 0, 0, 0)
        '
        'datFromDate
        '
        Me.datFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFromDate.Location = New System.Drawing.Point(66, 17)
        Me.datFromDate.Name = "datFromDate"
        Me.datFromDate.Size = New System.Drawing.Size(96, 20)
        Me.datFromDate.TabIndex = 10
        Me.datFromDate.Value = New Date(2014, 10, 27, 0, 0, 0, 0)
        '
        'btnMeals
        '
        Me.btnMeals.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMeals.ForeColor = System.Drawing.Color.Black
        Me.btnMeals.Location = New System.Drawing.Point(186, 31)
        Me.btnMeals.Name = "btnMeals"
        Me.btnMeals.Size = New System.Drawing.Size(91, 23)
        Me.btnMeals.TabIndex = 7
        Me.btnMeals.Text = "Meals"
        Me.btnMeals.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "From Date"
        '
        'btnEmployeePerformance
        '
        Me.btnEmployeePerformance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmployeePerformance.ForeColor = System.Drawing.Color.Black
        Me.btnEmployeePerformance.Location = New System.Drawing.Point(283, 24)
        Me.btnEmployeePerformance.Name = "btnEmployeePerformance"
        Me.btnEmployeePerformance.Size = New System.Drawing.Size(112, 37)
        Me.btnEmployeePerformance.TabIndex = 5
        Me.btnEmployeePerformance.Text = "Employee Performance"
        Me.btnEmployeePerformance.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMainMenu.Location = New System.Drawing.Point(443, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnMainMenu.TabIndex = 22
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(39, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 23)
        Me.btnPrint.TabIndex = 23
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnMealAlphabetical
        '
        Me.btnMealAlphabetical.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMealAlphabetical.ForeColor = System.Drawing.Color.Black
        Me.btnMealAlphabetical.Location = New System.Drawing.Point(58, 133)
        Me.btnMealAlphabetical.Name = "btnMealAlphabetical"
        Me.btnMealAlphabetical.Size = New System.Drawing.Size(112, 23)
        Me.btnMealAlphabetical.TabIndex = 29
        Me.btnMealAlphabetical.Text = "Alphabetical"
        Me.btnMealAlphabetical.UseVisualStyleBackColor = False
        Me.btnMealAlphabetical.Visible = False
        '
        'btnMealSearch
        '
        Me.btnMealSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMealSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMealSearch.Location = New System.Drawing.Point(412, 133)
        Me.btnMealSearch.Name = "btnMealSearch"
        Me.btnMealSearch.Size = New System.Drawing.Size(112, 23)
        Me.btnMealSearch.TabIndex = 28
        Me.btnMealSearch.Text = "Search"
        Me.btnMealSearch.UseVisualStyleBackColor = False
        Me.btnMealSearch.Visible = False
        '
        'btnByProfit
        '
        Me.btnByProfit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnByProfit.ForeColor = System.Drawing.Color.Black
        Me.btnByProfit.Location = New System.Drawing.Point(294, 133)
        Me.btnByProfit.Name = "btnByProfit"
        Me.btnByProfit.Size = New System.Drawing.Size(112, 23)
        Me.btnByProfit.TabIndex = 27
        Me.btnByProfit.Text = "By Gross Profit"
        Me.btnByProfit.UseVisualStyleBackColor = False
        Me.btnByProfit.Visible = False
        '
        'btnMealsByPopularity
        '
        Me.btnMealsByPopularity.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMealsByPopularity.ForeColor = System.Drawing.Color.Black
        Me.btnMealsByPopularity.Location = New System.Drawing.Point(176, 133)
        Me.btnMealsByPopularity.Name = "btnMealsByPopularity"
        Me.btnMealsByPopularity.Size = New System.Drawing.Size(112, 23)
        Me.btnMealsByPopularity.TabIndex = 26
        Me.btnMealsByPopularity.Text = "By Popularity"
        Me.btnMealsByPopularity.UseVisualStyleBackColor = False
        Me.btnMealsByPopularity.Visible = False
        '
        'btnMoneyTaken
        '
        Me.btnMoneyTaken.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoneyTaken.ForeColor = System.Drawing.Color.Black
        Me.btnMoneyTaken.Location = New System.Drawing.Point(294, 133)
        Me.btnMoneyTaken.Name = "btnMoneyTaken"
        Me.btnMoneyTaken.Size = New System.Drawing.Size(112, 23)
        Me.btnMoneyTaken.TabIndex = 32
        Me.btnMoneyTaken.Text = "Money Taken"
        Me.btnMoneyTaken.UseVisualStyleBackColor = False
        Me.btnMoneyTaken.Visible = False
        '
        'btnEmployeeSearch
        '
        Me.btnEmployeeSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmployeeSearch.ForeColor = System.Drawing.Color.Black
        Me.btnEmployeeSearch.Location = New System.Drawing.Point(412, 133)
        Me.btnEmployeeSearch.Name = "btnEmployeeSearch"
        Me.btnEmployeeSearch.Size = New System.Drawing.Size(112, 23)
        Me.btnEmployeeSearch.TabIndex = 31
        Me.btnEmployeeSearch.Text = "Search"
        Me.btnEmployeeSearch.UseVisualStyleBackColor = False
        Me.btnEmployeeSearch.Visible = False
        '
        'btnTablesServed
        '
        Me.btnTablesServed.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTablesServed.ForeColor = System.Drawing.Color.Black
        Me.btnTablesServed.Location = New System.Drawing.Point(176, 133)
        Me.btnTablesServed.Name = "btnTablesServed"
        Me.btnTablesServed.Size = New System.Drawing.Size(112, 23)
        Me.btnTablesServed.TabIndex = 30
        Me.btnTablesServed.Text = "Tables Served"
        Me.btnTablesServed.UseVisualStyleBackColor = False
        Me.btnTablesServed.Visible = False
        '
        'btnEmployeesAlphabetical
        '
        Me.btnEmployeesAlphabetical.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmployeesAlphabetical.ForeColor = System.Drawing.Color.Black
        Me.btnEmployeesAlphabetical.Location = New System.Drawing.Point(58, 133)
        Me.btnEmployeesAlphabetical.Name = "btnEmployeesAlphabetical"
        Me.btnEmployeesAlphabetical.Size = New System.Drawing.Size(112, 23)
        Me.btnEmployeesAlphabetical.TabIndex = 29
        Me.btnEmployeesAlphabetical.Text = "Alphabetical"
        Me.btnEmployeesAlphabetical.UseVisualStyleBackColor = False
        Me.btnEmployeesAlphabetical.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnQarterly
        '
        Me.btnQarterly.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnQarterly.ForeColor = System.Drawing.Color.Black
        Me.btnQarterly.Location = New System.Drawing.Point(353, 133)
        Me.btnQarterly.Name = "btnQarterly"
        Me.btnQarterly.Size = New System.Drawing.Size(112, 23)
        Me.btnQarterly.TabIndex = 33
        Me.btnQarterly.Text = "Quarterly"
        Me.btnQarterly.UseVisualStyleBackColor = False
        Me.btnQarterly.Visible = False
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMonthly.ForeColor = System.Drawing.Color.Black
        Me.btnMonthly.Location = New System.Drawing.Point(123, 133)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(112, 23)
        Me.btnMonthly.TabIndex = 34
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        Me.btnMonthly.Visible = False
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(584, 446)
        Me.Controls.Add(Me.btnMonthly)
        Me.Controls.Add(Me.btnQarterly)
        Me.Controls.Add(Me.btnMoneyTaken)
        Me.Controls.Add(Me.btnMealAlphabetical)
        Me.Controls.Add(Me.btnEmployeeSearch)
        Me.Controls.Add(Me.btnMealSearch)
        Me.Controls.Add(Me.btnTablesServed)
        Me.Controls.Add(Me.btnEmployeesAlphabetical)
        Me.Controls.Add(Me.btnByProfit)
        Me.Controls.Add(Me.btnMealsByPopularity)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.grpDateRange)
        Me.Controls.Add(Me.lstReports)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmReports"
        Me.Text = "Eastney Tavern - Reports"
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lstReports As System.Windows.Forms.ListBox
    Friend WithEvents grpDateRange As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmployeePerformance As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMeals As System.Windows.Forms.Button
    Friend WithEvents datFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents datToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnMealSearch As System.Windows.Forms.Button
    Friend WithEvents btnByProfit As System.Windows.Forms.Button
    Friend WithEvents btnMealsByPopularity As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeSearch As System.Windows.Forms.Button
    Friend WithEvents btnTablesServed As System.Windows.Forms.Button
    Friend WithEvents btnEmployeesAlphabetical As System.Windows.Forms.Button
    Friend WithEvents btnMealAlphabetical As System.Windows.Forms.Button
    Friend WithEvents btnMoneyTaken As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnGrossProfit As System.Windows.Forms.Button
    Friend WithEvents btnQarterly As System.Windows.Forms.Button
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
End Class
