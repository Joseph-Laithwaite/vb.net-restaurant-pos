<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrders
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
        Me.grbMeal = New System.Windows.Forms.GroupBox
        Me.cmbMeal = New System.Windows.Forms.ComboBox
        Me.cmbMenu = New System.Windows.Forms.ComboBox
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnNewOrder = New System.Windows.Forms.Button
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.btnPrintOrder = New System.Windows.Forms.Button
        Me.btnPrintReceipt = New System.Windows.Forms.Button
        Me.lstOrder = New System.Windows.Forms.ListBox
        Me.lstReceipt = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOrderID = New System.Windows.Forms.TextBox
        Me.txtEmployeeName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTableNumber = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbOpenOrders = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.rdbTableCleared = New System.Windows.Forms.RadioButton
        Me.btnDeleteMeal = New System.Windows.Forms.Button
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.btnDeleteOrder = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument
        Me.btnPay = New System.Windows.Forms.Button
        Me.grbMeal.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbMeal
        '
        Me.grbMeal.Controls.Add(Me.cmbMeal)
        Me.grbMeal.Controls.Add(Me.cmbMenu)
        Me.grbMeal.Controls.Add(Me.txtQuantity)
        Me.grbMeal.Controls.Add(Me.Label7)
        Me.grbMeal.Controls.Add(Me.Label6)
        Me.grbMeal.Controls.Add(Me.Label5)
        Me.grbMeal.Controls.Add(Me.btnAdd)
        Me.grbMeal.ForeColor = System.Drawing.Color.White
        Me.grbMeal.Location = New System.Drawing.Point(40, 131)
        Me.grbMeal.Name = "grbMeal"
        Me.grbMeal.Size = New System.Drawing.Size(560, 60)
        Me.grbMeal.TabIndex = 0
        Me.grbMeal.TabStop = False
        Me.grbMeal.Text = "Meal"
        '
        'cmbMeal
        '
        Me.cmbMeal.FormattingEnabled = True
        Me.cmbMeal.Location = New System.Drawing.Point(224, 22)
        Me.cmbMeal.Name = "cmbMeal"
        Me.cmbMeal.Size = New System.Drawing.Size(121, 21)
        Me.cmbMeal.TabIndex = 21
        '
        'cmbMenu
        '
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Location = New System.Drawing.Point(50, 22)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(121, 21)
        Me.cmbMenu.TabIndex = 20
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(428, 23)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(37, 20)
        Me.txtQuantity.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(374, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(188, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Meal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Menu"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(496, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(49, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.White
        Me.btnNewOrder.Location = New System.Drawing.Point(24, 16)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(105, 23)
        Me.btnNewOrder.TabIndex = 1
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(495, 16)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnPrintOrder
        '
        Me.btnPrintOrder.BackColor = System.Drawing.Color.White
        Me.btnPrintOrder.Location = New System.Drawing.Point(236, 276)
        Me.btnPrintOrder.Name = "btnPrintOrder"
        Me.btnPrintOrder.Size = New System.Drawing.Size(105, 23)
        Me.btnPrintOrder.TabIndex = 4
        Me.btnPrintOrder.Text = "Print Order"
        Me.btnPrintOrder.UseVisualStyleBackColor = False
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.White
        Me.btnPrintReceipt.Location = New System.Drawing.Point(236, 305)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(105, 23)
        Me.btnPrintReceipt.TabIndex = 5
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
        '
        'lstOrder
        '
        Me.lstOrder.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.ItemHeight = 14
        Me.lstOrder.Location = New System.Drawing.Point(12, 218)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(183, 130)
        Me.lstOrder.TabIndex = 6
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(389, 218)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(241, 130)
        Me.lstReceipt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Order ID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(177, 65)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderID.TabIndex = 9
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(444, 65)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeName.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(354, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Employee Name"
        '
        'txtTableNumber
        '
        Me.txtTableNumber.Location = New System.Drawing.Point(444, 91)
        Me.txtTableNumber.Name = "txtTableNumber"
        Me.txtTableNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtTableNumber.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(354, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Table Number"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(177, 91)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(104, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Kitchen Order"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(393, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Customer Receipt"
        '
        'cmbOpenOrders
        '
        Me.cmbOpenOrders.FormattingEnabled = True
        Me.cmbOpenOrders.Location = New System.Drawing.Point(294, 18)
        Me.cmbOpenOrders.Name = "cmbOpenOrders"
        Me.cmbOpenOrders.Size = New System.Drawing.Size(121, 21)
        Me.cmbOpenOrders.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(198, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Open Orders"
        '
        'rdbTableCleared
        '
        Me.rdbTableCleared.AutoSize = True
        Me.rdbTableCleared.ForeColor = System.Drawing.Color.White
        Me.rdbTableCleared.Location = New System.Drawing.Point(215, 336)
        Me.rdbTableCleared.Name = "rdbTableCleared"
        Me.rdbTableCleared.Size = New System.Drawing.Size(91, 17)
        Me.rdbTableCleared.TabIndex = 21
        Me.rdbTableCleared.TabStop = True
        Me.rdbTableCleared.Text = "Table Cleared"
        Me.rdbTableCleared.UseVisualStyleBackColor = True
        '
        'btnDeleteMeal
        '
        Me.btnDeleteMeal.BackColor = System.Drawing.Color.White
        Me.btnDeleteMeal.Location = New System.Drawing.Point(236, 218)
        Me.btnDeleteMeal.Name = "btnDeleteMeal"
        Me.btnDeleteMeal.Size = New System.Drawing.Size(105, 23)
        Me.btnDeleteMeal.TabIndex = 22
        Me.btnDeleteMeal.Text = "Delete Meal"
        Me.btnDeleteMeal.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(495, 16)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(105, 23)
        Me.btnLogOut.TabIndex = 24
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        Me.btnLogOut.Visible = False
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(236, 247)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(105, 23)
        Me.btnDeleteOrder.TabIndex = 25
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDialog2
        '
        Me.PrintDialog2.Document = Me.PrintDocument2
        Me.PrintDialog2.UseEXDialog = True
        '
        'PrintDocument2
        '
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(308, 334)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(54, 20)
        Me.btnPay.TabIndex = 26
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(642, 361)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnDeleteMeal)
        Me.Controls.Add(Me.rdbTableCleared)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbOpenOrders)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTableNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.lstOrder)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.btnPrintOrder)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.grbMeal)
        Me.Name = "frmOrders"
        Me.Text = "Eastney Tavern - Orders"
        Me.grbMeal.ResumeLayout(False)
        Me.grbMeal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbMeal As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnPrintOrder As System.Windows.Forms.Button
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents lstOrder As System.Windows.Forms.ListBox
    Friend WithEvents lstReceipt As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTableNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbMeal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMenu As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbOpenOrders As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdbTableCleared As System.Windows.Forms.RadioButton
    Friend WithEvents btnDeleteMeal As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnDeleteOrder As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDialog2 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPay As System.Windows.Forms.Button
End Class
