Public Class frmMeal

    Private Sub frmMeal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateReport()          'Call procedure to populate list box with data
        LoadMenuCombo()         'Call procedure to fill combo box with menu names.
    End Sub

    Private Sub LoadMenuCombo()
        Dim MenuName As String
        FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Input)      'Open Menu file
        cmbMenuEnter.Items.Clear()                                  'Clear Combo box
        Do While Not EOF(MenuFileNumber)                            'Loop through menu file
            MenuName = LineInput(MenuFileNumber)                    'Read every line
            cmbMenuEnter.Items.Add(MenuName)                        'Enter them in the combo box
            cmbMenuSelector.Items.Add(MenuName)
        Loop
        FileClose(MenuFileNumber)                                   'Close menu file
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnNewMeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMeal.Click
        FileGet(IDFileNumber, IDRecord, MealFileNumber)         'Get the ID record for Meals from the ID file
        txtMealID.Text = IDRecord.ID + 1                        'Add one to the current ID
        txtMealName.Text = ""                                   'Clear data entry boxes
        cmbMenuEnter.Text = "Select A Menu"
        txtAllergyAdvice.Text = ""
        txtPrice.Text = ""
        txtCost.Text = ""
        chkInStock.Checked = True
        chkHistoric.Checked = False
        txtMealName.Focus()
    End Sub

    Private Sub btnSaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecord.Click
        ValidateData()          'Call procedure to validate data
        CreateReport()          'Call procedure to populate list box with data
    End Sub

    Private Sub ValidateData()
        If txtMealID.Text = "" Then     'If a Meal ID has't been created display an error.
            MsgBox("You must have a Meal ID before you can save a new meal." & vbNewLine & "To do this you must click the 'New Meal' button" & vbNewLine & "This meal has not been saved.")
        Else
            Dim Message As String = ""          'Messages to hold errors
            Dim Message2 As String = ""
            If Len(txtMealName.Text) > 20 Then Message2 = "The meal name is longer than 20 characters." 'Check meal name is less than 20 char
            If Len(txtAllergyAdvice.Text) > 30 Then Message2 = "The allergy advice is more than 30 characters"
            If txtMealName.Text = "" Then Message = "A meal name" & vbNewLine 'Validations to check 9if data field is empty
            If cmbMenuEnter.Text = "Select A Menu" Then Message = Message & "A menu" & vbNewLine
            If txtPrice.Text = "" Then
                Message = Message & "A Price" & vbNewLine
            ElseIf IsNumeric(txtPrice.Text) = False Then                    'Validation numbers are actual numbers
                Message2 = Message2 & "The price is not a number" & vbNewLine
            End If
            If txtCost.Text = "" Then
                Message = Message & "A Cost" & vbNewLine
            ElseIf IsNumeric(txtCost.Text) = False Then
                Message2 = Message2 & "The Cost is not a number"
            End If
            If Message = "" And Message2 = "" Then      'If no errors save data procedure is called
                SaveData()
            Else                                        'Display error message and how to correct when errors occur.
                If Message2 = "" Then
                    MsgBox("Please Enter:" & vbNewLine & Message & vbNewLine & "This Meal has not been saved")
                ElseIf Message = "" Then
                    MsgBox("Please correct these errors: " & vbNewLine & Message2 & vbNewLine & "This Meal has not been saved")
                Else
                    MsgBox("Please Enter:" & vbNewLine & Message & vbNewLine & "And correct these errors: " & vbNewLine & Message2 & vbNewLine & "This Meal has not been saved")
                End If
            End If
        End If
    End Sub

    Private Sub SaveData()
        Dim RecordNumber As Short
        Dim Save As Boolean = True
        FileGet(IDFileNumber, IDRecord, MealFileNumber)     'Get ID for meal file
        If txtMealID.Text <= IDRecord.ID Then               'Checks if ID has already been used (signifies file being updated rather than created)
            If MsgBox("Are you sure you want to update this record, the old information will be lost.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then     'Check data should be overwritten
                For index = 1 To LOF(MealFileNumber) / Len(MealRecord)
                    If txtMealID.Text = MealRecord.MealID Then
                        RecordNumber = MealRecord.RecordNumber       'Find the record number for the existing meal
                    End If
                Next
            Else
                Save = False
            End If
        Else
            RecordNumber = LOF(MealFileNumber) / Len(MealRecord) + 1        'Create a new meal ID
        End If
        If Save = True Then
            MealRecord.RecordNumber = RecordNumber              ' Enter input boxes data into meal record
            MealRecord.MealID = txtMealID.Text
            MealRecord.MealName = txtMealName.Text
            MealRecord.Menu = cmbMenuEnter.Text
            MealRecord.AllergyAdvice = txtAllergyAdvice.Text
            MealRecord.PriceCurrent = txtPrice.Text
            MealRecord.CostCurrent = txtCost.Text
            MealRecord.InStock = chkInStock.CheckState
            MealRecord.Historic = chkHistoric.CheckState
            FilePut(MealFileNumber, MealRecord, RecordNumber)   'Place record in meal File
            If txtMealID.Text = IDRecord.ID + 1 Then            'If it's a new record
                IDRecord.FileNumber = MealFileNumber
                IDRecord.ID = txtMealID.Text
                FilePut(IDFileNumber, IDRecord, MealFileNumber)     'Update largest used ID
            End If
        End If

    End Sub

    Private Sub CreateReport()
        Dim index As Integer
        lstMeals.Items.Clear()
        lstMeals.Items.Add("Meal Meal                 Menu            Cost   Price  In    Historic Allergy")            'Write table headings
        lstMeals.Items.Add("ID   Name                                               Stock          Advice")
        lstMeals.Items.Add("==========================================================================================================================")
        If LOF(MealFileNumber) / Len(MealRecord) = 0 Then       'If no meal files saved write a message saying this
            lstMeals.Items.Add("")
            lstMeals.Items.Add(" ---- No Meals ----")
        Else
            For index = 1 To LOF(MealFileNumber) / Len(MealRecord)  'If Meal records exist step through every record and enter in list box.
                FileGet(MealFileNumber, MealRecord, index)
                lstMeals.Items.Add(String.Format(MealFormat, MealRecord.MealID.ToString("D3"), MealRecord.MealName, MealRecord.Menu, Format(MealRecord.CostCurrent, "Currency"), Format(MealRecord.PriceCurrent, "Currency"), MealRecord.InStock, MealRecord.Historic, MealRecord.AllergyAdvice))
            Next index
        End If
    End Sub

    Private Sub lstMeals_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMeals.SelectedIndexChanged
        Dim RecordNumber As Short
        RecordNumber = lstMeals.SelectedIndex - 2       'Gets record number from clicking it in the list box
        If RecordNumber < 1 Then
            RecordNumber = 1
        End If
        ReadRecord(RecordNumber)        'Pass the Record number to a read record procedure.
    End Sub

    Private Sub ReadRecord(ByRef RecordNumber)
        If LOF(MealFileNumber) / Len(MealRecord) > 0 Then
            FileGet(MealFileNumber, MealRecord, RecordNumber)           'Find the record
            txtMealID.Text = MealRecord.MealID                          'Get data from the record and enter it into the data boxes.
            txtMealName.Text = MealRecord.MealName
            cmbMenuEnter.Text = MealRecord.Menu
            txtAllergyAdvice.Text = MealRecord.AllergyAdvice
            txtPrice.Text = MealRecord.PriceCurrent
            txtCost.Text = MealRecord.CostCurrent
            chkInStock.Checked = MealRecord.InStock
            chkHistoric.Checked = MealRecord.Historic
            lstMeals.SelectedIndex = RecordNumber + 2                   'change the selected line in the list box
        End If
    End Sub

    Private Sub cmbMenuSelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMenuSelector.SelectedIndexChanged
        Dim index, NumberOfRecords As Integer
        cmbMeal.Items.Clear()                                           'Clear combo box
        NumberOfRecords = LOF(MealFileNumber) / Len(MealRecord)
        For index = 1 To NumberOfRecords
            FileGet(MealFileNumber, MealRecord, index)                  'Get the last meal record
            If RTrim(MealRecord.Menu) = cmbMenuSelector.Text Then       'If the meal has the same menu
                cmbMeal.Items.Add(MealRecord.MealName)                  'Add the meal to the meal combo box
            End If
        Next index
        cmbMeal.Text = ""
    End Sub

    Private Sub cmbMeal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMeal.SelectedIndexChanged
        Dim NumberOfRecords As Integer = LOF(MealFileNumber) / Len(MealRecord)
        Dim RecordNumber As Integer
        For index = 1 To NumberOfRecords                    'Loop through every record in the meal file
            FileGet(MealFileNumber, MealRecord, index)
            If MealRecord.MealName = cmbMeal.Text Then
                RecordNumber = MealRecord.RecordNumber      'Record number of the meal selected
            End If
        Next index
        ReadRecord(RecordNumber)                            'Pass to the Read Record procedure
    End Sub

    Private Sub btnNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextRecord.Click
        Dim RecordNumber As Short = 0
        Dim NumberOfRecords, Index As Integer
        NumberOfRecords = LOF(MealFileNumber) / Len(MealRecord)
        If txtMealID.Text = "" Then
            RecordNumber = 1
        Else
            For Index = 1 To NumberOfRecords
                FileGet(MealFileNumber, MealRecord, Index)
                If MealRecord.MealID = txtMealID.Text Then          'gets the record number of the next record
                    RecordNumber = MealRecord.RecordNumber
                    If RecordNumber + 1 > NumberOfRecords Then
                        RecordNumber = NumberOfRecords
                    Else
                        RecordNumber = RecordNumber + 1
                    End If
                End If
            Next
        End If
        ReadRecord(RecordNumber)            'Passes the next record number to the ReadRecord procedure
    End Sub

    Private Sub btnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastRecord.Click
        Dim RecordNumber As Short = 0
        Dim NumberOfRecords, Index As Integer
        NumberOfRecords = LOF(MealFileNumber) / Len(MealRecord)
        If txtMealID.Text = "" Then                   'gets the record number of the next record
            RecordNumber = NumberOfRecords
        Else
            For Index = 1 To NumberOfRecords
                FileGet(MealFileNumber, MealRecord, Index)
                If MealRecord.MealID = txtMealID.Text Then
                    RecordNumber = MealRecord.RecordNumber
                    If RecordNumber - 1 < 1 Then
                        RecordNumber = 1
                    Else
                        RecordNumber = RecordNumber - 1
                    End If
                End If
            Next
        End If
        ReadRecord(RecordNumber)            'Passes the next record number to the ReadRecord procedure
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If (PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then     'Printing
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintDialog1.Document.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim yMargin As Integer = e.MarginBounds.Y
        Dim xMargin As Integer = e.MarginBounds.X
        Dim currentpageItemProgress As Integer = 0
        For Each item As String In lstMeals.Items
            If (currentpageItemProgress >= ItemProgress) Then
                e.Graphics.DrawString(item, lstMeals.Font, New SolidBrush(lstMeals.ForeColor), xMargin, yMargin)
                yMargin += lstMeals.Font.Size + 10
                ItemProgress += 1
                If (yMargin >= e.MarginBounds.Y + e.MarginBounds.Height And ItemProgress <= lstMeals.Items.Count) Then
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
End Class