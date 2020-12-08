Public Class frmEmployees

    Private Sub frmEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateReport()
        If FirstUse = True Then
            MsgBox("Please create an administrative employee account (with a password)")
            btnMainMenu.Visible = False
            btnDeleteRecord.Visible = False
            btnLastRecord.Visible = False
            btnNextRecord.Visible = False
            grpSearch.Visible = False
            btnPrint.Visible = False
            btnClose.Visible = True
        End If
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnNewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewEmployee.Click
        FileGet(IDFileNumber, IDRecord, EmployeeFileNumber)
        txtEmployeeID.Text = IDRecord.ID + 1        'Get the next unused ID
        txtFirstName.Text = ""                      'Clear Data entry boxes
        txtLastName.Text = ""
        txtJobTittle.Text = ""
        txtPayRate.Text = ""
        txtPhoneNumber.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtECName.Text = ""
        txtECPhoneNumber.Text = ""
        txtPassword.Text = ""
        txtFirstName.Focus()
    End Sub

    Private Sub btnSaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecord.Click
        ValidateData()      'Calls the procedure to validate data
        CreateReport()      'Calls the procedure to populate the listbox
    End Sub

    Private Sub ValidateData()
        If txtEmployeeID.Text = "" Then     'If a Meal ID has't been created display an error.
            MsgBox("You must have an Employee ID before you can save a new employee." & vbNewLine & "To do this you must click the 'New Employee' button" & vbNewLine & "This employee has not been saved.")
        Else
            Dim Message As String = ""          'Messages used to create longer strings with instructions on how to make the system save data.
            Dim Message2 As String = ""
            Dim Message3 As String = ""
            If txtFirstName.Text = "" Then Message = "A First Name" & vbNewLine 'Validations to check text boxes contain data.
            If txtLastName.Text = "" Then Message = "A Last Name" & vbNewLine
            If txtJobTittle.Text = "" Then Message = "A Job Tittle " & vbNewLine
            If txtPayRate.Text = "" Then
                Message = "A Pay Rate" & vbNewLine
            ElseIf IsNumeric(txtPayRate.Text) = False Then                      'Validating the Numbers entered are actually numbers
                Message2 = Message2 & "The Pay rate isn't a number" & vbNewLine
            End If
            If txtPhoneNumber.Text = "" Then
                Message = Message & "A Phone Number" & vbNewLine
            ElseIf IsNumeric(txtPhoneNumber.Text) = False Then
                Message2 = Message2 & "The Phone Number isn't a number" & vbNewLine
            ElseIf Len(txtPhoneNumber.Text) > 13 Then
                Message3 = "The phone number you entered is not the correct length" & vbNewLine & "A phone number must be 13 numbers with no spaces"
            End If
            If txtEmail.Text = "" Then                          'Checking it has a standard email format (Contains @)
                Message = Message & "An Email" & vbNewLine
            Else
                Dim AtSign As Boolean
                Dim Character As Char
                Dim Email As String = txtEmail.Text
                For Each Character In Email
                    If Character = "@" Then
                        AtSign = True
                    End If
                Next
                If AtSign = False Then
                    Message2 = Message2 & "The email doesn't contain an @ sign" & vbNewLine
                End If
            End If
            If txtAddress.Text = "" Then Message = Message & "An Address" & vbNewLine 'Validations to check text boxes contain data.
            If txtECName.Text = "" Then Message = Message & "An Emergency Contact Name" & vbNewLine
            If txtECPhoneNumber.Text = "" Then                                                          'Validating the Numbers entered are actually numbers
                Message = Message & "An Emergency Contact Phone Number" & vbNewLine
            ElseIf IsNumeric(txtECPhoneNumber.Text) = False Then
                Message2 = Message2 & "The Emergency Phone Number isn't a number" & vbNewLine
            ElseIf Len(txtECPhoneNumber.Text) > 13 Then
                If Message3 = "" Then
                    Message3 = "The emergency phone number you entered is not the correct length" & vbNewLine & "A phone number must be 13 numbers with no spaces"
                Else
                    Message3 = "A phone number must be 13 numbers with no spaces" & vbNewLine & "both phone numbers are the wrong length"
                End If
            End If

            If Message <> "" Or Message2 <> "" Or Message3 <> "" Then         'If messages contain information some data has been entered incorrectly so won't be saved.
                If Message2 = "" And Message3 = "" Then
                    MsgBox("Please Enter:" & vbNewLine & Message & vbNewLine & "This Employee has not been saved")
                ElseIf Message = "" And Message3 = "" Then
                    MsgBox("Please Correct these mistakes:" & vbNewLine & Message2 & vbNewLine & "This Employee has not been saved")
                ElseIf Message = "" And Message2 = "" Then
                    MsgBox(Message3)
                Else
                    MsgBox("Please Enter:" & vbNewLine & Message & vbNewLine & "And Correct these mistakes:" & vbNewLine & Message2 & vbNewLine & "This Employee has not been saved" & vbNewLine & Message3)
                End If
            Else
                If txtPassword.Text = "" Then           'Checking the Password has purposefully been left out.
                    If FirstUse = True Then
                        MsgBox("This employee must be an employee. Please enter a password." & vbNewLine & "This employee has not been saved")
                    Else
                        If MsgBox("Are you sure you don't want this employee to be an administrator?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            SaveData()
                        Else
                            MsgBox("Please enter a Password")
                        End If
                    End If
                Else
                    If InputBox("Please re-enter the password") = txtPassword.Text Then         'Verifying the password entered is known by asking for it to be entered twice.
                        SaveData()
                    Else
                        If InputBox("The passwords didn't match please try again") = txtPassword.Text Then
                            SaveData()
                        Else
                            If InputBox("The passwords didn't match please try again") = txtPassword.Text Then
                                SaveData()
                            Else
                                MsgBox("Please Try again")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SaveData()
        If FirstUse = True Then
            FirstUse = False
        End If
        Dim RecordNumber As Short
        Dim Save As Boolean = True
        FileGet(IDFileNumber, IDRecord, EmployeeFileNumber)
        If txtEmployeeID.Text <= IDRecord.ID Then               'Checking whether this is a new record or updating an old record.
            If MsgBox("Are you sure you want to update this record, the old information will be lost.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then     'Checking with user they know they'll be overwriting old information.
                For index = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)
                    If txtEmployeeID.Text = EmployeeRecord.EmployeeID Then
                        RecordNumber = EmployeeRecord.RecordNumber
                    End If
                Next
            Else
                Save = False
            End If
        Else 
            RecordNumber = LOF(EmployeeFileNumber) / Len(EmployeeRecord) + 1        'If not updating then creating a new unique identifier.
        End If
        If Save = True Then
            EmployeeRecord.RecordNumber = RecordNumber                  'Move data from form into a record
            EmployeeRecord.EmployeeID = txtEmployeeID.Text
            EmployeeRecord.EmployeeFirstName = txtFirstName.Text
            EmployeeRecord.EmployeeLastName = txtLastName.Text
            EmployeeRecord.JobTittle = txtJobTittle.Text
            EmployeeRecord.PayRate = txtPayRate.Text
            EmployeeRecord.PhoneNumber = txtPhoneNumber.Text
            EmployeeRecord.Email = txtEmail.Text
            EmployeeRecord.Address = txtAddress.Text
            EmployeeRecord.EmergencyContactName = txtECName.Text
            EmployeeRecord.EmergencyContactNumber = txtECPhoneNumber.Text
            EmployeeRecord.Password = txtPassword.Text
            FilePut(EmployeeFileNumber, EmployeeRecord, RecordNumber)       'Save the record in the file
            If txtEmployeeID.Text = IDRecord.ID + 1 Then
                IDRecord.FileNumber = EmployeeFileNumber                    'Update the ID file so the last used ID is saved and therefore will not be used again.
                IDRecord.ID = txtEmployeeID.Text
                FilePut(IDFileNumber, IDRecord, EmployeeFileNumber)
            End If
        End If
    End Sub

    Private Sub CreateReport()
        Dim index As Integer
        lstEmployees.Items.Clear()
        lstEmployees.Items.Add("Employee Employee                        Phone       Email                          Address                        Job        Pay   Emergency       Emergency     ")
        lstEmployees.Items.Add("ID       Name                            Number      Address                                                       Tittle     Rate  Contact Name    Contact Number")
        lstEmployees.Items.Add("========================================================================================================================================================================")
        If LOF(EmployeeFileNumber) / Len(EmployeeRecord) = 0 Then           'If there's no employee record then this will be displayed in the list box.
            lstEmployees.Items.Add("")
            lstEmployees.Items.Add(" ---- No Employees ----")
        Else
            For index = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)  'If there's records Cycle through file entering each record as a seperate line.
                FileGet(EmployeeFileNumber, EmployeeRecord, index)
                lstEmployees.Items.Add(String.Format(EmployeeFormat, EmployeeRecord.EmployeeID.ToString("D3"), RTrim(EmployeeRecord.EmployeeFirstName) & " " & RTrim(EmployeeRecord.EmployeeLastName), EmployeeRecord.PhoneNumber, EmployeeRecord.Email, EmployeeRecord.Address, EmployeeRecord.JobTittle, Format(EmployeeRecord.PayRate, "Currency"), EmployeeRecord.EmergencyContactName, EmployeeRecord.EmergencyContactNumber))
            Next index
        End If
    End Sub

    Private Sub btnDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRecord.Click
        Dim index As Integer
        Dim CurrentRecord As Integer = 1
        Dim NumberOfRecords As Integer = LOF(EmployeeFileNumber) / Len(EmployeeRecord)
        Dim Temp As String = CurDir() & "\Temp.Dat"
        Dim Deleted As Boolean = False
        If MsgBox("Are you sure you want to delete the employee records for " & Trim(txtFirstName.Text) & " " & Trim(txtLastName.Text) & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            FileOpen(10, Temp, OpenMode.Random, , , Len(EmployeeRecord))        'Create a temporary file
            For index = 1 To NumberOfRecords
                FileGet(EmployeeFileNumber, EmployeeRecord, index)
                If EmployeeRecord.EmployeeID <> txtEmployeeID.Text Then         'Fill file with every record wi=hich isn't being deleted. (Leaving out the one wanting to be deleted)
                    EmployeeRecord.RecordNumber = CurrentRecord
                    FilePut(10, EmployeeRecord, CurrentRecord)
                    CurrentRecord = CurrentRecord + 1
                Else
                    Deleted = True
                End If
            Next index
            If Deleted = True Then
                FileClose(EmployeeFileNumber)
                FileClose(10)
                Kill(EmployeeFilePath)                  'Delete the old file
                FileCopy(Temp, EmployeeFilePath)        'copy  temporary file to the old files name
                Kill(Temp)                              'Delete Temporary File
                FileOpen(EmployeeFileNumber, EmployeeFilePath, OpenMode.Random, , , Len(EmployeeRecord))

                FileOpen(DeletedEmployeeIDFileNumber, DeletedEmployeeIDFilePath, OpenMode.Append)   'Deleted Employee records IDs are saved in a seperate file to make it easier to make reports.
                DeletedEmployeeIDRecord = txtEmployeeID.Text
                PrintLine(DeletedEmployeeIDFileNumber, DeletedEmployeeIDRecord)
                FileClose(DeletedEmployeeIDFileNumber)
            Else
                MsgBox("Sorry the Employee you tried to delete hasn't been deleted due to the Employee not existing")
            End If
            txtEmployeeID.Text = ""         'Data entry boxes are cleared as the employee has now been deleted.
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtJobTittle.Text = ""
            txtPayRate.Text = ""
            txtPhoneNumber.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
            txtECName.Text = ""
            txtECPhoneNumber.Text = ""
            txtPassword.Text = ""
            CreateReport()          'Call to update the list box without the deleted file.
        End If

    End Sub

    Private Sub lstEmployees_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmployees.SelectedIndexChanged
        Dim RecordNumber As Short
        RecordNumber = lstEmployees.SelectedIndex - 2       'This allows to click an item in the list box and the record number be found.
        If RecordNumber < 1 Then
            RecordNumber = 1
        End If
        ReadRecord(RecordNumber)        'This record number is passed to the ReadRecord procedure
    End Sub

    Private Sub ReadRecord(ByRef RecordNumber)
        If LOF(EmployeeFileNumber) / Len(EmployeeRecord) > 0 Then
            FileGet(EmployeeFileNumber, EmployeeRecord, RecordNumber)       'Open Record
            RecordNumber = EmployeeRecord.RecordNumber                      'Take data from record and place it in data boxes.
            txtEmployeeID.Text = EmployeeRecord.EmployeeID
            txtFirstName.Text = EmployeeRecord.EmployeeFirstName
            txtLastName.Text = EmployeeRecord.EmployeeLastName
            txtJobTittle.Text = EmployeeRecord.JobTittle
            txtPayRate.Text = EmployeeRecord.PayRate
            txtPhoneNumber.Text = EmployeeRecord.PhoneNumber
            txtEmail.Text = EmployeeRecord.Email
            txtAddress.Text = EmployeeRecord.Address
            txtECName.Text = EmployeeRecord.EmergencyContactName
            txtECPhoneNumber.Text = EmployeeRecord.EmergencyContactNumber
            txtPassword.Text = RTrim(EmployeeRecord.Password)
        End If
    End Sub

    Private Sub btnNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextRecord.Click
        Dim RecordNumber As Short = 0
        Dim NumberOfRecords, Index As Integer
        NumberOfRecords = LOF(EmployeeFileNumber) / Len(EmployeeRecord)
        If txtEmployeeID.Text = "" Then
            RecordNumber = 1
        Else
            For Index = 1 To NumberOfRecords
                FileGet(EmployeeFileNumber, EmployeeRecord, Index)
                If EmployeeRecord.EmployeeID = txtEmployeeID.Text Then          'gets the record number of the next record
                    RecordNumber = EmployeeRecord.RecordNumber
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
        NumberOfRecords = LOF(EmployeeFileNumber) / Len(EmployeeRecord)
        If txtEmployeeID.Text = "" Then
            RecordNumber = NumberOfRecords
        Else
            For Index = 1 To NumberOfRecords
                FileGet(EmployeeFileNumber, EmployeeRecord, Index)
                If EmployeeRecord.EmployeeID = txtEmployeeID.Text Then      'gets the record number of the next record
                    RecordNumber = EmployeeRecord.RecordNumber
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
        If (PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then         'Printing
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintDialog1.Document.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim yMargin As Integer = e.MarginBounds.Y
        Dim xMargin As Integer = 10
        Dim currentpageItemProgress As Integer = 0
        For Each item As String In lstEmployees.Items
            If (currentpageItemProgress >= ItemProgress) Then
                e.Graphics.DrawString(item, lstEmployees.Font, New SolidBrush(lstEmployees.ForeColor), xMargin, yMargin)
                yMargin += lstEmployees.Font.Size + 10
                ItemProgress += 1
                If (yMargin >= e.MarginBounds.Y + e.MarginBounds.Height And ItemProgress <= lstEmployees.Items.Count) Then
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim Recordnumber As Integer = 0
        If IsNumeric(txtSearch.Text) = True Then                            'If user is searching form an employee by searching with an ID (Number)
            For index = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)  'For every employee record
                FileGet(EmployeeFileNumber, EmployeeRecord, index)
                If txtSearch.Text = EmployeeRecord.EmployeeID Then          'When ID is found save the records record number as RecordNumber
                    Recordnumber = EmployeeRecord.RecordNumber
                End If
            Next
            If Recordnumber = 0 Then
                MsgBox("Sorry the Id you entered could not be found" & vbNewLine & "The employee may have been deleted or never created")   'If searched and no ID found display an error message
            Else
                lstEmployees.SelectedIndex = Recordnumber + 2       'Set list boxes selected index as record number +2(3 lines of tittles) a procedure reacts to this change and loads the record.
            End If
        ElseIf IsNumeric(txtSearch.Text) = False And txtSearch.Text <> "" Then                       'If employee is searched for by name
            For index = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)  'For every emplooyee record
                FileGet(EmployeeFileNumber, EmployeeRecord, index)
                If txtSearch.Text.ToLower.TrimEnd = EmployeeRecord.EmployeeFirstName.ToLower.TrimEnd Or txtSearch.Text.ToLower.TrimEnd = EmployeeRecord.EmployeeLastName.ToLower.TrimEnd Or txtSearch.Text.ToLower.TrimEnd = EmployeeRecord.EmployeeFirstName.ToLower.TrimEnd & " " & EmployeeRecord.EmployeeLastName.ToLower.TrimEnd Then
                    'Remove triling spaces and set all characters to lower case, compare firstname lastname and both names to the entered name
                    Recordnumber = EmployeeRecord.RecordNumber
                End If
            Next
            If Recordnumber = 0 Then        'If record hasn't been found display error message
                MsgBox("Sorry the Name you entered could not be found" & vbNewLine & "The employee may have been deleted or never created")
            Else
                lstEmployees.SelectedIndex = Recordnumber + 2   'If found isplay record
            End If
        Else
            MsgBox("Please enter either an ID or employee name into the search box then try again") 'If the box is empty display an error message
        End If
        txtSearch.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class