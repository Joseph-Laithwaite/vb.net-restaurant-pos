Public Class frmOrders
    Dim Total As Single

    Private Sub frmOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CurrentUserAdministrator = False Then        'If the employee logged in without using a password
            btnMainMenu.Visible = False                 'Removes the open main menu button and replaces it with a logout button
            btnLogOut.Visible = True
        Else
            btnMainMenu.Visible = True                  'If they logged in using a password then only the main menu buttton will be visible
            btnLogOut.Visible = False
        End If
        MenuComboLoad()                                 'Call procedures to load combo boxes.
        LoadOpenOrders()
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub LoadOpenOrders()
        cmbOpenOrders.Items.Clear()                                     'Clear combo box
        Dim Index As Integer
        For Index = 1 To LOF(OrderFileNumber) / Len(OrderRecord)        'Loop through every record in the order file
            FileGet(OrderFileNumber, OrderRecord, Index)
            If OrderRecord.OrderCleared = False And OrderRecord.TableNumber <> 0 Then                    'If the order hasn't been paiid for then it will be writen in the open orders combo box
                cmbOpenOrders.Items.Add(OrderRecord.TableNumber)
            End If
        Next
    End Sub

    Private Sub cmbOpenOrders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOpenOrders.SelectedIndexChanged
        Dim index, index2 As Integer
        Dim RecordNumber As Short = 0
        cmbMeal.Items.Clear()
        For index = 1 To LOF(OrderFileNumber) / Len(OrderRecord)        'Loop through order records
            FileGet(OrderFileNumber, OrderRecord, index)
            If RTrim(OrderRecord.TableNumber) = cmbOpenOrders.Text And OrderRecord.OrderCleared = False Then        'Find the selected order
                txtOrderID.Text = OrderRecord.OrderID                   'Get employee record data
                txtDate.Text = OrderRecord.OrderDate
                For index2 = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)
                    FileGet(EmployeeFileNumber, EmployeeRecord, index2)
                    If EmployeeRecord.EmployeeID = OrderRecord.EmployeeID Then
                        RecordNumber = EmployeeRecord.RecordNumber
                    End If
                Next index2
                If RecordNumber <> 0 Then
                    FileGet(EmployeeFileNumber, EmployeeRecord, RecordNumber)
                    txtEmployeeName.Text = EmployeeRecord.EmployeeFirstName
                Else
                    txtEmployeeName.Text = "Unknown Employee"
                End If
                txtTableNumber.Text = OrderRecord.TableNumber
                rdbTableCleared.Checked = OrderRecord.OrderCleared
            End If
        Next index
        CreateReports()                                                 'Call procedure to populate list boxes
    End Sub

    Private Sub btnNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewOrder.Click
        txtOrderID.Text = ""                                'Clear OrderID data box
        txtDate.Text = Today.Date                           'Enter todays date in the date box
        txtEmployeeName.Text = GetEmployeeName()            'Call employee name function to get the name from the logged in ID
        CreateReports()                                     'Populate list boxes
        txtTableNumber.Text = ""                            'Clear table number
        rdbTableCleared.Checked = False                     'Uncheck table cleared radio button
        FileGet(IDFileNumber, IDRecord, OrderFileNumber)
        txtOrderID.Text = IDRecord.ID + 1                   'Create new unique ID
        cmbOpenOrders.Text = ""
    End Sub

    Private Sub MenuComboLoad()
        Dim MenuName As String
        FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Input)  'Open menu file
        cmbMenu.Items.Clear()
        Do While Not EOF(MenuFileNumber)                        'Loop through every record
            MenuName = LineInput(MenuFileNumber)                'Write menu name in combo box
            cmbMenu.Items.Add(MenuName)
        Loop
        FileClose(MenuFileNumber)                               'Close menu file
    End Sub

    Private Sub cmbMenu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMenu.SelectedIndexChanged
        Dim index, NumberOfRecords As Integer
        cmbMeal.Items.Clear()                                       'Clear combo box
        NumberOfRecords = LOF(MealFileNumber) / Len(MealRecord)
        For index = 1 To NumberOfRecords                            'Loop through every record in the meal file
            FileGet(MealFileNumber, MealRecord, index)
            If RTrim(MealRecord.Menu) = cmbMenu.Text And MealRecord.InStock = True And MealRecord.Historic = False Then
                cmbMeal.Items.Add(MealRecord.MealName)              'Add meals which aren't historic, are in stock and have the selected menu
            End If
        Next index
    End Sub

    Private Sub btnSaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ValidateData()              'Call procedure to validate data
        LoadOpenOrders()            'Call procedure to load open orders into aa combo box
    End Sub

    Private Sub ValidateData()                  'Procedure to check the data entered is valid
        Dim NumberOfOrderRecord As Integer = LOF(OrderFileNumber) / Len(OrderRecord)
        Dim valid As Boolean = True
        Dim Message As String = ""              'Strings to collect error messages
        Dim Message2 As String = ""
        Dim Message3 As String = ""
        Dim OrderSaved As Boolean = False       'Yes or no variable whether or not the order has already been created
        Dim index As Integer
        If txtOrderID.Text = "" Then            'If data entry field is empty add error message
            MsgBox("Please Press New Meal to create a new Order")
        Else
            If txtTableNumber.Text = "" Then
                Message = Message & "A Table Number" & vbNewLine
            ElseIf IsNumeric(txtTableNumber.Text) = False Or txtTableNumber.Text = 0 Then                  'Check table number is a number
                Message2 = Message2 & "The table number you entered is not a number larger than 0"
            Else
                For Each item As Short In cmbOpenOrders.Items                   'Check to see if the table number entered is a new table
                    If item = txtTableNumber.Text Then
                        For index = 1 To LOF(OrderFileNumber) / Len(OrderRecord)        'Loop through order records 
                            FileGet(OrderFileNumber, OrderRecord, index)
                            If OrderRecord.OrderCleared = False And OrderRecord.TableNumber = txtTableNumber.Text Then      'If it's an open order and the same table number as an existing order
                                If OrderRecord.OrderID <> txtOrderID.Text Then          'If the existing order isn't the same as the new order
                                    If MsgBox("This table is already in use, would you like to add this to the same table (Yes) or select a different table (No)", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then   'Check whether it should be added to a new table or part of this table.
                                        txtOrderID.Text = OrderRecord.OrderID
                                        txtDate.Text = OrderRecord.OrderDate
                                        txtEmployeeName.Text = ""
                                    Else
                                        txtTableNumber.Text = (InputBox("Please enter a table number not in use"))
                                    End If
                                End If
                            End If
                        Next index
                    End If
                Next item
            End If
            If cmbMenu.Text = "" Then Message = Message & "A Menu" & vbNewLine 'If data entry box is empty write error message
            If cmbMeal.Text = "" Then Message = Message & "A Meal" & vbNewLine
            If txtQuantity.Text = "" Then
                Message = Message & "A Quantity" & vbNewLine
            ElseIf IsNumeric(txtQuantity.Text) = False Then                 'Check quantity is a number
                Message2 = Message2 & " The quantity entered is not a number"
            ElseIf txtQuantity.Text > 10 Then
                Message3 = "Are you sure the quantity of " & txtQuantity.Text & " meals is correct?"
            End If

            If Message = "" And Message2 = "" Then                  'If Data is valid 
                If Message3 <> "" Then
                    If MsgBox(Message3, MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        valid = False
                    End If
                End If
                If valid = True Then
                    For index = 1 To NumberOfOrderRecord            'Check to see if the order has been created
                        FileGet(OrderFileNumber, OrderRecord, index)
                        If OrderRecord.OrderID = txtOrderID.Text Then
                            OrderSaved = True
                        End If
                    Next
                    If OrderSaved = False Then          'If it's a new order call a procedure to save the order
                        SaveOrder()
                    End If
                    SaveOrderItem()                     'Call procedure to save order item
                    txtQuantity.Text = ""               'Reset Quantity and meal text boxes
                    cmbMeal.Text = ""
                    CreateReports()                     'Call procedure to populate the receipt and order 
                End If
            Else                            'If error messages have no contents then don't save the message and display the error messages.
                If Message2 = "" Then
                    MsgBox("Please Enter:" & vbNewLine & Message & vbNewLine & "This Meal has not been saved")      'Creating messages which make sense
                ElseIf Message = "" Then
                    MsgBox("Some data was incorrectly entered:" & vbNewLine & Message2 & vbNewLine & "Please correct these " & vbNewLine & "This Meal has not been saved")
                Else
                    MsgBox("Please Enter:" & vbNewLine & Message & vbNewLine & "Some data was incorrectly entered:" & vbNewLine & Message2 & vbNewLine & "Please correct this " & "This Meal has not been saved")
                End If

            End If
            End If
    End Sub

    Private Sub SaveOrder()
        OrderRecord.RecordNumber = LOF(OrderFileNumber) / Len(OrderRecord) + 1          'Move data from the input boxes into an order record
        OrderRecord.OrderID = txtOrderID.Text
        OrderRecord.OrderDate = txtDate.Text
        OrderRecord.EmployeeID = CurrentEmployeeID
        OrderRecord.TableNumber = txtTableNumber.Text
        OrderRecord.OrderCleared = rdbTableCleared.Checked
        FilePut(OrderFileNumber, OrderRecord, CInt(txtOrderID.Text))                    'Save record in the order file
        IDRecord.FileNumber = OrderFileNumber                                           'Updte the Id file to contain the most recently used OrderID
        IDRecord.ID = txtOrderID.Text
        FilePut(IDFileNumber, IDRecord, OrderFileNumber)
    End Sub

    Private Sub SaveOrderItem()
        Dim MealID, Index As Integer
        Dim Price, Cost As Single
        For Index = 1 To LOF(MealFileNumber) / Len(MealRecord)      'Retreiveing MealID, Price and Cost from the meal file
            FileGet(MealFileNumber, MealRecord, Index)
            If MealRecord.MealName = cmbMeal.Text Then
                MealID = MealRecord.MealID
                Price = MealRecord.PriceCurrent
                Cost = MealRecord.CostCurrent
            End If
        Next
        OrderItemRecord.OrderID = txtOrderID.Text                   'Entering data from the meal lookup and input boxes to an orderitem record
        OrderItemRecord.MealID = MealID
        OrderItemRecord.Quantity = txtQuantity.Text
        OrderItemRecord.Price = Price
        OrderItemRecord.Cost = Cost
        Dim NumberOfOrderItemRecords As Integer = LOF(OrderItemFileNumber) / Len(OrderItemRecord)   'Calculate number of records in the order item file 
        FilePut(OrderItemFileNumber, OrderItemRecord, NumberOfOrderItemRecords + 1)                 'Place record in the order item file one place higher than the highest record
    End Sub

    Private Sub CreateReports()
        Dim Index, Index2 As Integer
        Dim MealName As String = ""
        Dim Now As Date = Date.Now.ToString("T")
        Dim OrderItemTotal As Single
        Total = 0
        lstOrder.Items.Clear()                                  'Clear listboxes
        lstReceipt.Items.Clear()
        lstOrder.Items.Add("EASTNEY TAVERN")
        lstOrder.Items.Add("")
        lstOrder.Items.Add(txtDate.Text & "   " & Now)          'Add date and current time
        lstOrder.Items.Add("")
        lstOrder.Items.Add(txtEmployeeName.Text)
        lstOrder.Items.Add("")
        lstReceipt.Items.Add("Eastney Tavern")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add(txtDate.Text & "   " & Now)
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add(txtEmployeeName.Text)
        lstReceipt.Items.Add("")
        If txtOrderID.Text <> "" Then
            FileGet(OrderFileNumber, OrderRecord, (txtOrderID.Text))        'Get current order Record
            Dim NumberOfRecords As Integer = LOF(OrderItemFileNumber) / Len(OrderItemRecord)
            For Index = 1 To NumberOfRecords                        'For every order item record
                FileGet(OrderItemFileNumber, OrderItemRecord, Index)
                If OrderRecord.OrderID = OrderItemRecord.OrderID Then       'If the orderitemd record is part of the current order record
                    For Index2 = 1 To LOF(MealFileNumber) / Len(MealRecord) 'for every meal file
                        FileGet(MealFileNumber, MealRecord, Index2)
                        If OrderItemRecord.MealID = MealRecord.MealID Then  'Find the meal record with the same mealid as the current orderID
                            OrderItemTotal = OrderItemRecord.Price * OrderItemRecord.Quantity       'Calculate total price of that meal (and quantity)
                            Total = Total + OrderItemTotal                                          'Add this to overall total
                            If MealRecord.MealName = "" Then
                                MealName = "Unknown meal"
                            Else
                                MealName = MealRecord.MealName
                            End If
                        End If
                    Next
                    lstOrder.Items.Add(OrderItemRecord.Quantity.ToString("D2") & " " & MealName)        'Enter this info into the order and receipt list box
                    lstReceipt.Items.Add(OrderItemRecord.Quantity.ToString("D2") & " " & MealName & " " & Format(OrderItemTotal, "Currency"))
                End If
            Next
            lstReceipt.Items.Add("")
            lstReceipt.Items.Add("Total                   " & Format(Total, "Currency"))        'Display total
        End If
    End Sub

    Private Sub rdbTableCleared_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTableCleared.CheckedChanged
        If rdbTableCleared.Checked = True Then
            If txtOrderID.Text <> "" Then                                   'As long as an order is selected
                If MsgBox("Are you sure table " & txtTableNumber.Text & " has been clear?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For index = 1 To (LOF(OrderFileNumber) / Len(OrderRecord))          'For every order record
                        FileGet(OrderFileNumber, OrderRecord, index)
                        If OrderRecord.OrderID = CShort(txtOrderID.Text) Then       'If the order record is th current record
                            Dim RecordPosition As Integer = index
                            OrderRecord.OrderCleared = True                         'Change the record so order cleaered is true
                            FilePut(OrderFileNumber, OrderRecord, RecordPosition)            'Resave the record
                        End If
                    Next
                    LoadOpenOrders()            'Call proced ure to load open orders
                    cmbOpenOrders.Text = ""     'Reset all input boxes to default
                    lstOrder.Items.Clear()
                    lstReceipt.Items.Clear()
                    txtDate.Text = ""
                    txtEmployeeName.Text = ""
                    txtOrderID.Text = ""
                    txtQuantity.Text = ""
                    txtTableNumber.Text = ""
                Else
                    rdbTableCleared.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub lstReceipt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReceipt.SelectedIndexChanged
        If lstReceipt.SelectedIndex < lstOrder.Items.Count Then     'Make selected lines in the receipt and order record the same
            lstOrder.SelectedIndex = lstReceipt.SelectedIndex
        End If
    End Sub

    Private Sub lstOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOrder.SelectedIndexChanged
        lstReceipt.SelectedIndex = lstOrder.SelectedIndex           'Make selected lines in the Order and Receipt record the same
    End Sub

    Private Sub btnDeleteMeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteMeal.Click
        Dim OrderItem, MealName As String
        Dim OrderID, MealID, Index, Index2 As Integer
        OrderItem = lstOrder.SelectedItem.ToString()                    'Get OrderItem from the order listbox
        If OrderItem <> "" Then
            If IsNumeric(OrderItem.Substring(0, 3)) = True Then         'If the line has numeric data
                MealName = OrderItem.Substring(3, 20)                   'Extract meal name
                OrderID = txtOrderID.Text
                For Index = 1 To LOF(MealFileNumber) / Len(MealRecord)  'For every meal record
                    FileGet(MealFileNumber, MealRecord, Index)
                    If MealRecord.MealName = MealName Then
                        MealID = MealRecord.MealID                      'Find meal record
                    End If
                Next
            End If
        Else
            MsgBox("select a meal by clicking on it in rder box or receipt box before trying to delete a meal")
        End If

        FileOpen(10, CurDir() & "/Temp.Dat", OpenMode.Random, , , Len(OrderItemRecord))     'Open temporary file
        For Index2 = 1 To LOF(OrderItemFileNumber) / Len(OrderItemRecord)                   'For every order item record
            FileGet(OrderItemFileNumber, OrderItemRecord, Index2)
            If OrderItemRecord.OrderID <> txtOrderID.Text Or MealID <> OrderItemRecord.MealID Then                              'If order item isn't part of the order you want deleted
                FilePut(10, OrderItemRecord)                'Then save record to temporary file
            End If
        Next
        FileClose(OrderItemFileNumber)                  'Close both files
        FileClose(10)
        Kill(OrderItemFilePath)                         'Delete order item file
        FileCopy(CurDir() & "/Temp.Dat", OrderItemFilePath)     'Copy temp file to order items location
        Kill(CurDir() & "/Temp.Dat")                    'Delete temp file
        FileOpen(OrderItemFileNumber, OrderItemFilePath, OpenMode.Random, , , Len(OrderItemRecord))     'Reopen ammended orderitem file
        CreateReports()         'Call procedures to create reports
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        CurrentEmployeeID = 0
        frmLogin.Show()
    End Sub

    Private Sub btnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOrder.Click
        If MsgBox("Are you sure you want to delete this order?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DeleteOrderItem()
            DeleteOrder()                                   'Call procedure to delete order
            txtOrderID.Text = ""                                'Set input boxes to default
            txtDate.Text = Today.Date
            txtEmployeeName.Text = ""
            txtTableNumber.Text = ""
            LoadOpenOrders()
            CreateReports()
        End If
    End Sub

    Sub DeleteOrderItem()
        FileOpen(10, CurDir() & "/Temp.Dat", OpenMode.Random, , , Len(OrderItemRecord))     'Open temporary file
        For Index2 = 1 To LOF(OrderItemFileNumber) / Len(OrderItemRecord)                   'For every order item record
            FileGet(OrderItemFileNumber, OrderItemRecord, Index2)
            If OrderItemRecord.OrderID <> txtOrderID.Text Then                              'If order item isn't part of the order you want deleted
                FilePut(10, OrderItemRecord)                'Then save record to temporary file
            End If
        Next
        FileClose(OrderItemFileNumber)                  'Close both files
        FileClose(10)
        Kill(OrderItemFilePath)                         'Delete order item file
        FileCopy(CurDir() & "/Temp.Dat", OrderItemFilePath)     'Copy temp file to order items location
        Kill(CurDir() & "/Temp.Dat")                    'Delete temp file
        FileOpen(OrderItemFileNumber, OrderItemFilePath, OpenMode.Random, , , Len(OrderItemRecord))     'Reopen ammended orderitem file
    End Sub

    Sub DeleteOrder()
        Dim Index, OrderRecordNumber As Integer
        OrderRecordNumber = 0
        FileOpen(10, CurDir() & "/Temp.Dat", OpenMode.Random, , , Len(OrderRecord))     'Create temporary file
        For Index = 1 To LOF(OrderFileNumber) / Len(OrderRecord)                            'For every order record
            FileGet(OrderFileNumber, OrderRecord, Index)
            If OrderRecord.OrderID <> txtOrderID.Text Then                                  'If the order record from file is not the one wanting to be deleted
                OrderRecordNumber = OrderRecordNumber + 1
                FilePut(10, OrderRecord)                                 'Save recor din temp file
            End If
        Next Index
        FileClose(OrderFileNumber)                          'Close both files
        FileClose(10)
        Kill(OrderFilePath)                                 'Delete order  file
        FileCopy(CurDir() & "/Temp.Dat", OrderFilePath)     'Copy temp file to order file location
        Kill(CurDir() & "/Temp.Dat")                        'Delete temp file
        FileOpen(OrderFileNumber, OrderFilePath, OpenMode.Random, , , Len(OrderRecord))     'Reopen ammended order file
    End Sub

    'Printing 

    Private Sub btnPrintOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOrder.Click
        If (PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            PrintDialog1.Document.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim yMargin As Integer = e.MarginBounds.Y
        Dim xMargin As Integer = e.MarginBounds.X
        Dim currentpageItemProgress As Integer = 0
        For Each item As String In lstOrder.Items
            If (currentpageItemProgress >= ItemProgress) Then
                e.Graphics.DrawString(item, lstOrder.Font, New SolidBrush(lstOrder.ForeColor), xMargin, yMargin)
                yMargin += lstOrder.Font.Size + 10
                ItemProgress += 1
                If (yMargin >= e.MarginBounds.Y + e.MarginBounds.Height And ItemProgress <= lstOrder.Items.Count) Then
                    e.HasMorePages = True
                    currentpageItemProgress = 0
                End If
            End If
            currentpageItemProgress += 1
        Next
    End Sub

    Private Sub PrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        ItemProgress = 0
    End Sub

    Private Sub btnPrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReceipt.Click
        If (PrintDialog2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            PrintDialog2.Document.Print()
        End If
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim yMargin As Integer = e.MarginBounds.Y
        Dim xMargin As Integer = e.MarginBounds.X
        Dim currentpageItemProgress As Integer = 0
        For Each item As String In lstReceipt.Items
            If (currentpageItemProgress >= ItemProgress) Then
                e.Graphics.DrawString(item, lstReceipt.Font, New SolidBrush(lstReceipt.ForeColor), xMargin, yMargin)
                yMargin += lstReceipt.Font.Size + 10
                ItemProgress += 1
                If (yMargin >= e.MarginBounds.Y + e.MarginBounds.Height And ItemProgress <= lstReceipt.Items.Count) Then
                    e.HasMorePages = True
                    currentpageItemProgress = 0
                End If
            End If
            currentpageItemProgress += 1
        Next
    End Sub

    Private Sub PrintDocument2_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument2.EndPrint
        ItemProgress = 0
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Dim AmountPaid As String
        If MsgBox("Pay with cash?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            AmountPaid = InputBox("Money Paid")
            If IsNumeric(AmountPaid) = True Then
                If CInt(AmountPaid) - Total > 0 Then
                    If MsgBox("Give £" & CInt(AmountPaid) - Total & " Change" & vbNewLine & "Has this table been cleared?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        rdbTableCleared.Checked = True
                    End If
                Else
                    MsgBox("The money given isn't enough to cover the bill" & vbNewLine & "Collect £" & Total - CInt(AmountPaid))
                End If
            Else
                MsgBox("Sorry the amount you entered was not a number")
            End If
        ElseIf MsgBox("Has this table been cleared?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            rdbTableCleared.Checked = True
        End If
    End Sub
End Class