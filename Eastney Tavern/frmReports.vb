Public Class frmReports
    Dim OrdersExist As Boolean = False          'Global variable to declare if the order exists

    Public Structure MealStructure              'Self assigned variable for data stored in array
        <VBFixedString(20)> Dim MealName As String
        Dim NumberOfMeals As Short
        Dim MoneyTaken As Single
        Dim Profit As Single
    End Structure

    Public Structure EmployeeStructure
        <VBFixedString(31)> Dim Name As String
        Dim NumberOfOrders As Short
        Dim NumberOfMeals As Short
        Dim MoneyTaken As Single
    End Structure

    Dim Meals((LOF(MealFileNumber) / Len(MealRecord)) + 1) As MealStructure                 'Create arrays with custom file type
    Dim Employees(LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1) As EmployeeStructure
    Dim FormatEmployeeReport As String = "{0,-32}{1,-10}{2,-10}{3,-7}"                      'Custom Formats
    Dim FormatMealsReport As String = "{0,-21}{1,-9}{2,-10}{3,-8}"

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LOF(OrderFileNumber) / Len(OrderRecord) <> 0 Then        'If orders have been taken add dates to date box (form the first order taken to the last order taken)
            FileGet(OrderFileNumber, OrderRecord, 1)
            datFromDate.MinDate = OrderRecord.OrderDate
            datToDate.MinDate = OrderRecord.OrderDate
            datFromDate.Text = OrderRecord.OrderDate
            FileGet(OrderFileNumber, OrderRecord, LOF(OrderFileNumber) / Len(OrderRecord))
            datToDate.MaxDate = OrderRecord.OrderDate
            datFromDate.MaxDate = OrderRecord.OrderDate
            datToDate.Text = OrderRecord.OrderDate
        Else                                            'If there's no orders than disable the date entry box
            datFromDate.Enabled = False
            datToDate.Enabled = False
        End If
    End Sub

    Private Sub PopulateEmployeeArray()                                         'Procedure to take data from order file and get info about each employee
        Dim index1, index2, index3, NumberOfOrders, NumberOfMeals As Integer
        Dim MoneyTaken As Double
        Dim DeletedEmployeeID As Short
        FileGet(IDFileNumber, IDRecord, EmployeeFileNumber)
        If IDRecord.ID > LOF(EmployeeFileNumber) / Len(EmployeeRecord) Then     'Checks to see if records have been deleted
            Dim UnKnownNumberOfOrders As Single = 0
            Dim UnKnownNumberOfMeals As Integer = 0
            Dim UnKnownMoneyTaken As Single = 0
            FileOpen(DeletedEmployeeIDFileNumber, DeletedEmployeeIDFilePath, OpenMode.Input)    'Open file of deleted employee IDs
            Do While Not EOF(DeletedEmployeeIDFileNumber)               'For every deleted emplyee ID
                DeletedEmployeeID = CShort(LineInput(DeletedEmployeeIDFileNumber))
                For index2 = 1 To LOF(OrderFileNumber) / Len(OrderRecord)       'Search every order record to find the deleted employee ID
                    FileGet(OrderFileNumber, OrderRecord, index2)
                    If OrderRecord.OrderDate >= CDate(datFromDate.Text) And OrderRecord.OrderDate <= CDate(datToDate.Text) And DeletedEmployeeID = OrderRecord.EmployeeID Then      'Check date of order is within inputted parammeters
                        UnKnownNumberOfOrders = UnKnownNumberOfOrders + 1
                        For index3 = 1 To LOF(OrderItemFileNumber) / Len(OrderItemRecord)
                            FileGet(OrderItemFileNumber, OrderItemRecord, index3)
                            If OrderRecord.OrderID = OrderItemRecord.OrderID Then
                                UnKnownNumberOfMeals = UnKnownNumberOfMeals + OrderItemRecord.Quantity      'Increase total unknown number of meals and unknown money taken
                                UnKnownMoneyTaken = UnKnownMoneyTaken + (OrderItemRecord.Quantity * OrderItemRecord.Price)
                            End If
                        Next index3
                    End If
                Next
            Loop
            FileClose(DeletedEmployeeIDFileNumber)      'Close deletd employee ID file
            Employees(LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1).Name = "Unknown Employee"                  'Place information created into the last position in the array
            Employees(LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1).NumberOfMeals = UnKnownNumberOfMeals
            Employees(LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1).MoneyTaken = UnKnownMoneyTaken
            Employees(LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1).NumberOfOrders = UnKnownNumberOfOrders
        End If

        For index1 = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)         'For every employee record
            NumberOfOrders = 0
            NumberOfMeals = 0
            MoneyTaken = 0
            FileGet(EmployeeFileNumber, EmployeeRecord, index1)
            For index2 = 1 To LOF(OrderFileNumber) / Len(OrderRecord)       'Loop through every order
                FileGet(OrderFileNumber, OrderRecord, index2)
                If OrderRecord.EmployeeID = EmployeeRecord.EmployeeID And OrderRecord.OrderDate >= CDate(datFromDate.Text) And OrderRecord.OrderDate <= CDate(datToDate.Text) Then  'Check order is within date parameteters
                    NumberOfOrders = NumberOfOrders + 1
                    For index3 = 1 To LOF(OrderItemFileNumber) / Len(OrderItemRecord)   'Loop through every order item
                        FileGet(OrderItemFileNumber, OrderItemRecord, index3)
                        If OrderRecord.OrderID = OrderItemRecord.OrderID Then
                            NumberOfMeals = NumberOfMeals + OrderItemRecord.Quantity                    'Total up the number of meals
                            MoneyTaken = MoneyTaken + OrderItemRecord.Quantity * OrderItemRecord.Price  'Total up the money taken
                        End If
                    Next index3
                End If
            Next index2
            Employees(index1).Name = RTrim(EmployeeRecord.EmployeeFirstName) & " " & RTrim(EmployeeRecord.EmployeeLastName)         'Add info to the employee array
            Employees(index1).NumberOfOrders = NumberOfOrders
            Employees(index1).NumberOfMeals = NumberOfMeals
            Employees(index1).MoneyTaken = MoneyTaken
        Next index1
    End Sub


    Private Sub PopluateMealArray()                                         'Procedure to take data from order file and get info about each meal
        ReDim Meals((LOF(MealFileNumber) / Len(MealRecord)) + 1)
        Dim index1, index2, index3, NumberOfMeals As Integer
        Dim Profit, MoneyTaken As Double
        For index1 = 1 To LOF(MealFileNumber) / Len(MealRecord)             'For every meal record
            NumberOfMeals = 0
            MoneyTaken = 0
            Profit = 0
            FileGet(MealFileNumber, MealRecord, index1)
            For index2 = 1 To LOF(OrderFileNumber) / Len(OrderRecord)           'Loop through every order record
                FileGet(OrderFileNumber, OrderRecord, index2)
                If OrderRecord.OrderDate >= CDate(datFromDate.Text) And OrderRecord.OrderDate <= CDate(datToDate.Text) Then     'Check order is within the date parameters
                    For index3 = 1 To LOF(OrderItemFileNumber) / Len(OrderItemRecord)       'Check every order item record
                        FileGet(OrderItemFileNumber, OrderItemRecord, index3)
                        If OrderRecord.OrderID = OrderItemRecord.OrderID And MealRecord.MealID = OrderItemRecord.MealID Then        'If it's the right order and meal 
                            NumberOfMeals = NumberOfMeals + OrderItemRecord.Quantity            'total number of meals, profit and money taken with the same Meal ID
                            Profit = Profit + (OrderItemRecord.Price - OrderItemRecord.Cost) * OrderItemRecord.Quantity
                            MoneyTaken = MoneyTaken + (OrderItemRecord.Quantity * OrderItemRecord.Price)
                        End If
                    Next index3
                End If
            Next
            If MealRecord.Historic = True And NumberOfMeals = 0 Then    'Old meals with no orders placed
                Meals(index1).MealName = ""
            Else
                Meals(index1).MealName = MealRecord.MealName
            End If
            Meals(index1).NumberOfMeals = NumberOfMeals                 'Place data into array
            Meals(index1).MoneyTaken = MoneyTaken
            Meals(index1).Profit = Profit
        Next index1
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnEmployeePerformance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeePerformance.Click
        lstReports.Items.Clear()
        If LOF(OrderFileNumber) / Len(OrderRecord) = 0 Then         'If no orders have been taken
            MsgBox("Unfortunately you can't create reports with no orders taken.")  'Display error message
        Else
            PopulateEmployeeArray()                     'Call procedure to populat employee array
            btnMealAlphabetical.Visible = False         'Hide all buttons except those relevant to employss info
            btnMealsByPopularity.Visible = False
            btnMealSearch.Visible = False
            btnByProfit.Visible = False
            btnEmployeeSearch.Visible = True
            btnEmployeesAlphabetical.Visible = True
            btnMoneyTaken.Visible = True
            btnTablesServed.Visible = True
            btnQarterly.Visible = False
            btnMonthly.Visible = False
        End If
    End Sub

    Private Sub DisplayMealList()
        Dim TotalMeals, TotalMoney, TotalProfit As Single
        lstReports.Items.Add("Meal Name            Number   Money     Profit ")     'Display column headings
        lstReports.Items.Add("                     of Meals Taken")
        lstReports.Items.Add("================================================")
        For index1 = 1 To (LOF(MealFileNumber) / Len(MealRecord)) + 1               'Loop thrugh employee array
            If Meals(index1).MealName <> "" Then
                TotalMeals = TotalMeals + Meals(index1).NumberOfMeals               'Calculate totals
                TotalMoney = TotalMoney + Meals(index1).MoneyTaken
                TotalProfit = TotalProfit + Meals(index1).Profit
                lstReports.Items.Add(String.Format(FormatMealsReport, (Meals(index1).MealName), (Meals(index1).NumberOfMeals), (Format(Meals(index1).MoneyTaken, "Currency")), (Format(Meals(index1).Profit, "Currency"))))     'display info in custom format
            End If
        Next
        lstReports.Items.Add("")
        lstReports.Items.Add(String.Format("{0,-21}{1,-9}{2,-10}{3,-10}", "Total", TotalMeals, (Format(TotalMoney, "Currency")), (Format(TotalProfit, "Currency"))))        'Display totals
    End Sub

    Private Sub btnMealAlphabetical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMealAlphabetical.Click        'Procedure reorders the meal array (A-->Z)
        Dim Temp As MealStructure
        lstReports.Items.Clear()
        For index2 = 1 To (LOF(MealFileNumber) / Len(MealRecord)) + 1           'Loop through meal array twice
            For index = 1 To (LOF(MealFileNumber) / Len(MealRecord))
                If Meals(index).MealName > Meals(index + 1).MealName Then       'If the 1st meal in the array is later in the alphabet than the second meal
                    Temp = Meals(index)                                         'Place first meal in a temporary variable
                    Meals(index) = Meals(index + 1)                             'replace frist meal with second
                    Meals(index + 1) = Temp                                     'Place temporary (1st meal) in second meal
                End If
            Next
        Next index2
        DisplayMealList()               'Call procedure to display the array
    End Sub

    Private Sub btnMealsByPopularity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMealsByPopularity.Click          'Procedure reorders the meal array (By number of meals sold)
        Dim Temp As MealStructure
        lstReports.Items.Clear()
        For index2 = 1 To (LOF(MealFileNumber) / Len(MealRecord)) + 1           'Loop through meal array twice
            For index = 1 To (LOF(MealFileNumber) / Len(MealRecord))
                If Meals(index + 1).MealName <> "" And Meals(index).NumberOfMeals < Meals(index + 1).NumberOfMeals Then 'If the 1st meal in the array is less than the second meal
                    Temp = Meals(index)                                         'Place first meal in a temporary variable
                    Meals(index) = Meals(index + 1)                             'replace frist meal with second
                    Meals(index + 1) = Temp                                     'Place temporary (1st meal) in second meal
                End If
            Next
        Next index2
        DisplayMealList()               'Call procedure to display the array
    End Sub

    Private Sub btnByProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnByProfit.Click          'Procedure reorders the meal array (By Profit)
        Dim Temp As MealStructure
        Dim NoMoreSwaps As Boolean
        lstReports.Items.Clear()
        NoMoreSwaps = True
        For index = 1 To (LOF(MealFileNumber) / Len(MealRecord)) + 1
            For index2 = 1 To (LOF(MealFileNumber) / Len(MealRecord))
                If Meals(index2).Profit < Meals(index2 + 1).Profit Then
                    Temp = Meals(index2)                                         'Place first meal in a temporary variable
                    Meals(index2) = Meals(index2 + 1)                            'Replace frist meal with second
                    Meals(index2 + 1) = Temp                                     'Place temporary (1st meal) in second meal
                End If
            Next index2
        Next index
        DisplayMealList()               'Call procedure to display the array
    End Sub

    Private Sub btnEmployeesAlphabetical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeesAlphabetical.Click          'Procedure reorders the employee array (Alphabetically)
        Dim Temp As EmployeeStructure
        lstReports.Items.Clear()
        For index2 = 1 To (LOF(EmployeeFileNumber) / Len(EmployeeRecord))
            For index = 1 To (LOF(EmployeeFileNumber) / Len(EmployeeRecord)) - 1
                If Employees(index).Name > Employees(index + 1).Name Then
                    Temp = Employees(index)                                         'Place first meal in a temporary variable
                    Employees(index) = Employees(index + 1)                         'Replace frist meal with second
                    Employees(index + 1) = Temp                                     'Place temporary (1st meal) in second meal
                End If
            Next
        Next index2
        DisplayEmployeeList()               'Call procedure to display the array
    End Sub

    Private Sub btnTablesServed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTablesServed.Click          'Procedure reorders the Employee array (By Tabbles served)
        Dim Temp As EmployeeStructure
        lstReports.Items.Clear()
        For index2 = 1 To (LOF(EmployeeFileNumber) / Len(EmployeeRecord))
            For index = 1 To (LOF(EmployeeFileNumber) / Len(EmployeeRecord)) - 1
                If Employees(index).NumberOfOrders < Employees(index + 1).NumberOfOrders Then
                    Temp = Employees(index)                                         'Place first meal in a temporary variable
                    Employees(index) = Employees(index + 1)                         'Replace frist meal with second
                    Employees(index + 1) = Temp                                     'Place temporary (1st meal) in second meal
                End If
            Next
        Next index2
        DisplayEmployeeList()               'Call procedure to display the array
    End Sub

    Private Sub btnMoneyTaken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoneyTaken.Click          'Procedure reorders the emplyee array (By Money Taken)
        Dim Temp As EmployeeStructure
        lstReports.Items.Clear()
        For index2 = 1 To (LOF(EmployeeFileNumber) / Len(EmployeeRecord))
            For index = 1 To (LOF(EmployeeFileNumber) / Len(EmployeeRecord)) - 1
                If Employees(index).MoneyTaken < Employees(index + 1).MoneyTaken Then
                    Temp = Employees(index)                                         'Place first meal in a temporary variable
                    Employees(index) = Employees(index + 1)                         'Replace frist meal with second
                    Employees(index + 1) = Temp                                     'Place temporary (1st meal) in second meal
                End If
            Next
        Next index2
        DisplayEmployeeList()               'Call procedure to display the array
    End Sub

    Private Sub DisplayEmployeeList()
        Dim TotalOrders, TotalMeals, TotalMoney As Single
        lstReports.Items.Add("Employee Name                   Number of Number of Money")       'Display column headings
        lstReports.Items.Add("                                Orders    Meals     Taken")
        lstReports.Items.Add("=============================================================")
        For index1 = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1         'For every employee in the employees array
            If Employees(index1).Name <> "" Then
                lstReports.Items.Add(String.Format(FormatEmployeeReport, (Employees(index1).Name), (Employees(index1).NumberOfOrders), (Employees(index1).NumberOfMeals), (Format(Employees(index1).MoneyTaken, "Currency"))))      'Write the information to the listbox with custom format
                TotalMeals = TotalMeals + Employees(index1).NumberOfMeals       'Keep running adding totals
                TotalMoney = TotalMoney + Employees(index1).MoneyTaken
                TotalOrders = TotalOrders + Employees(index1).NumberOfOrders
            End If
        Next
        lstReports.Items.Add("")
        lstReports.Items.Add(String.Format("{0,-32}{1,-10}{2,-10}{3,-10}", "Total", TotalOrders, TotalMeals, (Format(TotalMoney, "Currency"))))     'Display totals
    End Sub

    Private Sub btnMeals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeals.Click
        lstReports.Items.Clear()
        If LOF(OrderFileNumber) / Len(OrderRecord) = 0 Then             'If Orders haven't been taken
            MsgBox("Unfortunately you can't create reports with no orders taken.")      'Display error messag
        Else
            PopluateMealArray()                         'Call procedure to populat meal array
            btnByProfit.Visible = True                  'Hide all buttons unrelated to Meals
            btnMealAlphabetical.Visible = True
            btnMealsByPopularity.Visible = True
            btnMealSearch.Visible = True
            btnEmployeeSearch.Visible = False
            btnEmployeesAlphabetical.Visible = False
            btnMoneyTaken.Visible = False
            btnTablesServed.Visible = False
            btnQarterly.Visible = False
            btnMonthly.Visible = False
        End If
    End Sub

    Private Sub btnMealSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMealSearch.Click
        Dim SearchName As String
        Dim Found As Boolean = False
        SearchName = InputBox("Enter a Meal name to search")        'Get SearchName variable
        lstReports.Items.Clear()
        If SearchName <> "" Then
            lstReports.Items.Add("Meal Name            Number   Money    Profit")           'Display collumn headings
            lstReports.Items.Add("                     of Meals Taken")
            lstReports.Items.Add("==============================================")
            For index1 = 1 To LOF(MealFileNumber) / Len(MealRecord)         'For every Meal record compare the name to the searched name
                If SearchName.ToLower = RTrim(Meals(index1).MealName).ToLower Then              'With all letters lowercase
                    lstReports.Items.Add(String.Format(FormatMealsReport, (Meals(index1).MealName), (Meals(index1).NumberOfMeals), (Format(Meals(index1).MoneyTaken, "Currency")), (Format(Meals(index1).Profit, "Currency"))))     'If found, display meals info
                    Found = True
                Else
                    Dim FullMealName As String() = RTrim((Meals(index1).MealName)).Split(New Char() {" "c})     'Compare each word in the meal name with the searched word
                    Dim word As String
                    For Each word In FullMealName
                        If SearchName.ToLower = word.ToLower Then
                            lstReports.Items.Add(String.Format(FormatMealsReport, (Meals(index1).MealName), (Meals(index1).NumberOfMeals), (Format(Meals(index1).MoneyTaken, "Currency")), (Format(Meals(index1).Profit, "Currency"))))     'If found, display meals info
                            Found = True
                        End If
                    Next
                End If
            Next index1
        End If
        If Found = False Then           'If nothing found
            lstReports.Items.Add("")
            lstReports.Items.Add("")
            lstReports.Items.Add("Sorry no Meals were found with this name.")           'Display error message
            lstReports.Items.Add("Please check you spelt the Meal name correctly")
            lstReports.Items.Add("and that this Meal is in the system.")
        End If
    End Sub

    Private Sub btnEmployeeSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeeSearch.Click
        Dim SearchName As String
        Dim Found As Boolean = False
        lstReports.Items.Clear()
        SearchName = InputBox("Enter an Employee name to search")        'Get SearchName variable
        If SearchName <> "" Then
            lstReports.Items.Add("Employee Name                   Number of Number of Money")           'Display collumn headings
            lstReports.Items.Add("                                Orders    Meals     Taken")
            lstReports.Items.Add("=============================================================")
            For index1 = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)         'For every Meal record compare the name to the searched name
                If SearchName.ToLower = (Employees(index1).Name).ToLower Then              'With all letters lowercase
                    lstReports.Items.Add(String.Format(FormatEmployeeReport, (Employees(index1).Name), (Employees(index1).NumberOfOrders), (Employees(index1).NumberOfMeals), (Format(Employees(index1).MoneyTaken, "Currency"))))     'If found, display employees info
                    Found = True
                Else
                    Dim FullNames As String() = (Employees(index1).Name).Split(New Char() {" "c})     'Compare each word in the Employee name with the searched word
                    Dim Name As String
                    For Each Name In FullNames
                        If SearchName.ToLower = Name.ToLower Then
                            lstReports.Items.Add(String.Format(FormatEmployeeReport, (Employees(index1).Name), (Employees(index1).NumberOfOrders), (Employees(index1).NumberOfMeals), (Format(Employees(index1).MoneyTaken, "Currency"))))     'If found, display employees info
                            Found = True
                        End If
                    Next
                End If
            Next index1
            If Found = False Then           'If nothing found
                lstReports.Items.Add("")
                lstReports.Items.Add("")
                lstReports.Items.Add("Sorry no Employees were found with this name.")           'Display error message
                lstReports.Items.Add("Please check you spelt the name correctly")
                lstReports.Items.Add("and that this Employee is in the system.")
            End If
        End If
    End Sub

    Private Sub datFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datFromDate.ValueChanged
        btnEmployeeSearch.Visible = False           'Hide all sub serch buttons
        btnEmployeesAlphabetical.Visible = False
        btnMoneyTaken.Visible = False
        btnTablesServed.Visible = False
        btnByProfit.Visible = False
        btnMealAlphabetical.Visible = False
        btnMealsByPopularity.Visible = False
        btnMealSearch.Visible = False
        btnQarterly.Visible = False
        btnMonthly.Visible = False
        lstReports.Items.Clear()                    'Clear report
    End Sub

    Private Sub datToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datToDate.ValueChanged
        btnEmployeeSearch.Visible = False           'Hide all sub serch buttons
        btnEmployeesAlphabetical.Visible = False
        btnMoneyTaken.Visible = False
        btnTablesServed.Visible = False
        btnByProfit.Visible = False
        btnMealAlphabetical.Visible = False
        btnMealsByPopularity.Visible = False
        btnMealSearch.Visible = False
        btnQarterly.Visible = False
        btnMonthly.Visible = False
        lstReports.Items.Clear()                    'Clear report
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click       'Printing
        If (PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            PrintDialog1.Document.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim yMargin As Integer = e.MarginBounds.Y
        Dim xMargin As Integer = e.MarginBounds.X
        Dim currentpageItemProgress As Integer = 0
        For Each item As String In lstReports.Items
            If (currentpageItemProgress >= ItemProgress) Then
                e.Graphics.DrawString(item, lstReports.Font, New SolidBrush(lstReports.ForeColor), xMargin, yMargin)
                yMargin += lstReports.Font.Size + 10
                ItemProgress += 1
                If (yMargin >= e.MarginBounds.Y + e.MarginBounds.Height And ItemProgress <= lstReports.Items.Count) Then
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

    Private Sub btnGrossProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrossProfit.Click
        lstReports.Items.Clear()        'Cear report
        btnQarterly.Visible = True      'Hide all buttons which don;t elate to Gross proffit
        btnMonthly.Visible = True
        btnByProfit.Visible = False
        btnMealAlphabetical.Visible = False
        btnMealsByPopularity.Visible = False
        btnMealSearch.Visible = False
        btnEmployeeSearch.Visible = False
        btnEmployeesAlphabetical.Visible = False
        btnMoneyTaken.Visible = False
        btnTablesServed.Visible = False
        PopulateGrossProfitArray()      'Call procedure to populate gross proffit array
    End Sub

    Public Structure GrossProfit                'Define custom structure
        Dim Month As Short
        Dim Year As Short
        Dim MoneyTaken As Single
        Dim Profit As Single
    End Structure

    Dim Profits() As GrossProfit        'Create empty array
    Public NumberOfMonths As Integer

    Private Sub PopulateGrossProfitArray()
        Dim OrderDate As Date
        Dim index1, index3, CurrentYear, RecordMonth, RecordYear, ArrayPosition As Integer
        Dim CurrentMonth As Integer = 0
        Dim Profit, MoneyTaken As Double
        For index1 = 1 To LOF(OrderFileNumber) / Len(OrderRecord)       'for every record in the order file
            FileGet(OrderFileNumber, OrderRecord, index1)
            OrderDate = CDate(OrderRecord.OrderDate)
            If OrderRecord.OrderDate >= CDate(datFromDate.Text) And OrderRecord.OrderDate <= CDate(datToDate.Text) Then     'If order is withing the given dates
                RecordMonth = Month(OrderDate)
                RecordYear = Year(OrderDate)
                If CurrentMonth = 0 Then            'For the first month
                    CurrentMonth = RecordMonth
                    CurrentYear = RecordYear
                    ArrayPosition = 1
                End If
                If RecordMonth <> CurrentMonth Or RecordYear <> CurrentYear Then        'If the record month is not the crrent month
                    ReDim Preserve Profits(ArrayPosition)                               'Resize the array keeping the old data
                    Profits(ArrayPosition).Month = CurrentMonth                         'Place data in array
                    Profits(ArrayPosition).Year = CurrentYear
                    Profits(ArrayPosition).MoneyTaken = MoneyTaken
                    Profits(ArrayPosition).Profit = Profit
                    MoneyTaken = 0                                                      'Reset monthly variables
                    Profit = 0
                    CurrentMonth = RecordMonth                                          'update curren month/year to that of the record
                    CurrentYear = RecordYear
                    ArrayPosition = ArrayPosition + 1                                   'Increment array position by one
                End If
                For index3 = 1 To LOF(OrderItemFileNumber) / Len(OrderItemRecord)       'Loop through order item file 
                    FileGet(OrderItemFileNumber, OrderItemRecord, index3)
                    If OrderRecord.OrderID = OrderItemRecord.OrderID Then               'Find the Id in the current onth
                        Profit = Profit + (OrderItemRecord.Price - OrderItemRecord.Cost) * OrderItemRecord.Quantity     'update profit and moneytaken varuables
                        MoneyTaken = MoneyTaken + (OrderItemRecord.Quantity * OrderItemRecord.Price)
                    End If
                Next index3
            End If
            If index1 = LOF(OrderFileNumber) / Len(OrderRecord) Then        'for the last record
                ReDim Preserve Profits(ArrayPosition)
                Profits(ArrayPosition).Month = CurrentMonth                 'Save data into array
                Profits(ArrayPosition).Year = CurrentYear
                Profits(ArrayPosition).MoneyTaken = MoneyTaken
                Profits(ArrayPosition).Profit = Profit
                MoneyTaken = 0
                Profit = 0
                CurrentMonth = RecordMonth
                CurrentYear = RecordYear
                ArrayPosition = ArrayPosition + 1
            End If
        Next index1
        NumberOfMonths = ArrayPosition - 1                      'Number of months corrected to hoow many are saved in the record.
    End Sub

    Public FormatMonthlyProfit As String = "{0,-10}{1,-5}{2,-10}{3,-10}"

    Private Sub btnMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthly.Click
        Dim TotalMoney, TotalProfits As Single
        Dim MonthName As String = ""
        lstReports.Items.Clear()
        lstReports.Items.Add(String.Format(FormatMonthlyProfit, "Month", "Year", "Money", "Profits"))       'Display column tittles
        lstReports.Items.Add(String.Format("{0,20}", "Taken"))
        lstReports.Items.Add("==================================")
        For index1 = 1 To NumberOfMonths                        'Case slector to get mont nam from month number
            Select Case Profits(index1).Month
                Case 1
                    MonthName = "January"
                Case 2
                    MonthName = "February"
                Case 3
                    MonthName = "March"
                Case 4
                    MonthName = "April"
                Case 5
                    MonthName = "May"
                Case 6
                    MonthName = "June"
                Case 7
                    MonthName = "July"
                Case 8
                    MonthName = "August"
                Case 9
                    MonthName = "September"
                Case 10
                    MonthName = "October"
                Case 11
                    MonthName = "November"
                Case 12
                    MonthName = "December"
            End Select
            TotalMoney = TotalMoney + Profits(index1).MoneyTaken        'Update totals
            TotalProfits = TotalProfits + Profits(index1).Profit
            lstReports.Items.Add(String.Format(FormatMonthlyProfit, MonthName, Profits(index1).Year, (Format(Profits(index1).MoneyTaken, "Currency")), (Format(Profits(index1).Profit, "Currency"))))       'display information in custom format
        Next
        lstReports.Items.Add("")
        lstReports.Items.Add(String.Format("{0,-15}{1,-10}{2,-10}", "Total", (Format(TotalMoney, "Currency")), Format(TotalProfits, "Currency")))       'Display totals
    End Sub

    Private Sub btnQarterly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQarterly.Click
        Dim CurrentQuarter As String = ""
        Dim RecordQuarter As String = ""
        Dim Profit, MoneyTaken, TotalProfit, TotalMoney As Single
        lstReports.Items.Clear()
        lstReports.Items.Add(String.Format(FormatMonthlyProfit, "Quarter", "Year", "Money", "Profits"))     'Display tittle headings
        lstReports.Items.Add(String.Format("{0,20}", "Taken"))
        lstReports.Items.Add("==================================")
        For index1 = 1 To NumberOfMonths
            TotalProfit = TotalProfit + Profits(index1).Profit
            TotalMoney = TotalMoney + Profits(index1).MoneyTaken
            Select Case Profits(index1).Month           'Case selctor used to group every three months as a quarter
                Case 1, 2, 3
                    RecordQuarter = "First"
                Case 4, 5, 6
                    RecordQuarter = "Second"
                Case 7, 8, 9
                    RecordQuarter = "Third"
                Case 10, 11, 12
                    RecordQuarter = "Fourth"
            End Select
            If CurrentQuarter = "" Then                 'First month in array
                CurrentQuarter = RecordQuarter
            End If
            If CurrentQuarter = RecordQuarter Then      'Middle month in quarter
                Profit = Profits(index1).Profit + Profit
                MoneyTaken = Profits(index1).MoneyTaken + MoneyTaken
            Else                                        'Last month in quarter
                If index1 > 1 Then
                    lstReports.Items.Add(String.Format(FormatMonthlyProfit, CurrentQuarter, Profits(index1 - 1).Year, (Format(MoneyTaken, "Currency")), (Format(Profit, "Currency"))))
                Else
                    lstReports.Items.Add(String.Format(FormatMonthlyProfit, CurrentQuarter, Profits(index1).Year, (Format(MoneyTaken, "Currency")), (Format(Profit, "Currency"))))
                End If

                CurrentQuarter = RecordQuarter
                Profit = 0
                MoneyTaken = 0
                Profit = Profits(index1).Profit + Profit
                MoneyTaken = Profits(index1).MoneyTaken + MoneyTaken
            End If
            If index1 = NumberOfMonths Then     'Display last month even if not the last month in quarter
                lstReports.Items.Add(String.Format(FormatMonthlyProfit, CurrentQuarter, Profits(index1).Year, (Format(MoneyTaken, "Currency")), (Format(Profit, "Currency"))))
            End If
        Next
        lstReports.Items.Add("")
        lstReports.Items.Add(String.Format("{0,-15}{1,-10}{2,-10}", "Total", (Format(TotalMoney, "Currency")), Format(TotalProfit, "Currency")))        'Display totals
    End Sub
End Class

