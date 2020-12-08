Imports System
Imports System.IO
Imports System.Collections

Public Class frmSettingsHelp

    Private Sub frmSettingsHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadMenuCombo()             'Call procedure to load combo box with menu names
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Append)         'Open menu file (to add to the end)
        MenuRecord = txtAddMenu.Text
        PrintLine(MenuFileNumber, MenuRecord)                           'Save data to menu file
        FileClose(MenuFileNumber)                                       'Close record
        txtAddMenu.Text = ""                                            'Set text box blank
        txtAddMenu.Focus()
        LoadMenuCombo()                                                 'Call procedure to load menu combo box
    End Sub

    Private Sub LoadMenuCombo()
        FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Input)          'Open Menu file to read data from
        cmbDeleteMenu.Items.Clear()                                     'clear comb box
        Do While Not EOF(MenuFileNumber)                                'For every line in the menu text file
            cmbDeleteMenu.Items.Add(LineInput(MenuFileNumber))          'Enter the line in the box
        Loop
        FileClose(MenuFileNumber)                                       'Close the menu file
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Temp As String = CurDir() & "Temp.Txt"
        Dim Deleted As Boolean = False
        Dim MenuToDelete, CurrentMenu As String
        If MsgBox("Are you sure you want to delete the '" & cmbDeleteMenu.Text & "' menu" & vbNewLine & "This menu will be deleted and it's meals will not be available." & vbNewLine & "If you deleted this menu you must edit the meal in the meal form and change it to a new menu.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Input)      'Open menu file
            FileOpen(10, Temp, OpenMode.Output)                         'Create temporary file
            Do While Not EOF(MenuFileNumber)                    'For every line in the menu file
                MenuToDelete = cmbDeleteMenu.Text
                CurrentMenu = LineInput(MenuFileNumber)
                If MenuToDelete <> CurrentMenu Then             'If the line doen't equal the menu to be deleted
                    PrintLine(10, CurrentMenu)                  'Save that line in the temporary file
                Else
                    Deleted = True
                End If
            Loop
            FileClose(MenuFileNumber)               'Close files
            FileClose(10)
            If Deleted = True Then
                Kill(MenuFilePath)                  'Delete menu file
                FileCopy(Temp, MenuFilePath)        'Replace with temporary file
                Kill(Temp)                          'Delete temporary file
            End If
            cmbDeleteMenu.Text = ""
            LoadMenuCombo()
        End If
    End Sub

    Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click
        BackUp()
    End Sub

    Private Sub BackUp()
        Dim BackUpFilePath As String
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Dim TodaysDate As String = DateTime.Now.ToString("yyyy_MM_dd-hh_mm")
            BackUpFilePath = FolderBrowserDialog1.SelectedPath & "\" & TodaysDate
            If (Not System.IO.Directory.Exists(BackUpFilePath & "\" & TodaysDate)) Then
                Directory.CreateDirectory(BackUpFilePath)
            Else
                Kill(BackUpFilePath & "\EmployeeFile.dat")
                Kill(BackUpFilePath & "\IDFile.dat")
                Kill(BackUpFilePath & "\MenuFile.txt")
                Kill(BackUpFilePath & "\OrderFile.dat")
                Kill(BackUpFilePath & "\OrderItemFile.dat")
                If (System.IO.Directory.Exists(BackUpFilePath & "\DeletedEmployeeID.txt")) Then
                    Kill(BackUpFilePath & "\DeletedEmployeeID.txt")
                End If
            End If

            FileClose(EmployeeFileNumber)
            FileClose(OrderFileNumber)
            FileClose(OrderItemFileNumber)
            FileClose(EmployeeFileNumber)
            FileClose(IDFileNumber)
            FileClose(MealFileNumber)

            FileCopy(EmployeeFilePath, (BackUpFilePath & "\EmployeeFile.dat"))
            FileCopy(IDFilePath, (BackUpFilePath & "\IDFile.dat"))
            FileCopy(MenuFilePath, (BackUpFilePath & "\MenuFile.txt"))
            FileCopy(OrderFilePath, (BackUpFilePath & "\OrderFile.dat"))
            FileCopy(OrderItemFilePath, (BackUpFilePath & "\OrderItemFile.dat"))
            FileCopy(MealFilePath, (BackUpFilePath & "\MealFile.dat"))
            If (File.Exists(DeletedEmployeeIDFilePath)) Then
                FileCopy(DeletedEmployeeIDFilePath, BackUpFilePath & "\DeletedEmployeeID.txt")
            End If
            FileOpen(MealFileNumber, MealFilePath, OpenMode.Random, , , Len(MealRecord))                'Open all files
            FileOpen(OrderFileNumber, OrderFilePath, OpenMode.Random, , , Len(OrderRecord))
            FileOpen(OrderItemFileNumber, OrderItemFilePath, OpenMode.Random, , , Len(OrderItemRecord))
            FileOpen(EmployeeFileNumber, EmployeeFilePath, OpenMode.Random, , , Len(EmployeeRecord))
            FileOpen(IDFileNumber, IDFilePath, OpenMode.Random, , , Len(IDRecord))
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim UploadFilePath As String
        If MsgBox("We suggest you backup the system before restoring it to an older date." & vbNewLine & "Would you like to backup first?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BackUp()
        End If
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Dim NumberOfSlashes As Short
            Dim Character As Char
            Dim Last16Char As String = Microsoft.VisualBasic.Strings.Right(FolderBrowserDialog1.SelectedPath, 16)
            For Each Character In Last16Char
                If Character = "_" Then
                    NumberOfSlashes = NumberOfSlashes + 1
                End If
            Next
            If NumberOfSlashes = 3 Then
                UploadFilePath = FolderBrowserDialog1.SelectedPath

                FileClose(EmployeeFileNumber)
                FileClose(OrderFileNumber)
                FileClose(OrderItemFileNumber)
                FileClose(EmployeeFileNumber)
                FileClose(IDFileNumber)
                FileClose(MealFileNumber)

                FileCopy((UploadFilePath & "\EmployeeFile.dat"), EmployeeFilePath)
                FileCopy((UploadFilePath & "\IDFile.dat"), IDFilePath)
                FileCopy((UploadFilePath & "\MenuFile.txt"), MenuFilePath)
                FileCopy((UploadFilePath & "\OrderFile.dat"), OrderFilePath)
                FileCopy((UploadFilePath & "\OrderItemFile.dat"), OrderItemFilePath)
                FileCopy((UploadFilePath & "\MealFile.dat"), MealFilePath)
                If (File.Exists(DeletedEmployeeIDFilePath)) = True Then
                    FileClose(DeletedEmployeeIDFileNumber)
                    If (File.Exists(UploadFilePath & "\DeletedEmployeeID.txt")) Then
                        FileCopy(UploadFilePath & "\DeletedEmployeeID.txt", DeletedEmployeeIDFileNumber)
                    Else
                        Kill(DeletedEmployeeIDFilePath)
                    End If
                End If
                FileOpen(MealFileNumber, MealFilePath, OpenMode.Random, , , Len(MealRecord))                'Open all files
                FileOpen(OrderFileNumber, OrderFilePath, OpenMode.Random, , , Len(OrderRecord))
                FileOpen(OrderItemFileNumber, OrderItemFilePath, OpenMode.Random, , , Len(OrderItemRecord))
                FileOpen(EmployeeFileNumber, EmployeeFilePath, OpenMode.Random, , , Len(EmployeeRecord))
                FileOpen(IDFileNumber, IDFilePath, OpenMode.Random, , , Len(IDRecord))
                LoadMenuCombo()             'Call procedure to load combo box with menu names
            Else
                MsgBox("Sorry these folders can't be uploaded as they are not the correct backedup files")
            End If
        End If
    End Sub

    Private Sub cmbDeleteFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeleteFile.SelectedIndexChanged
        If MsgBox("We suggest you backup the system before deleting any files as you won't be able to rcover them." & vbNewLine & "Would you like to backup first?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BackUp()
        End If
        Select Case cmbDeleteFile.Text
            Case "Menu"
                DeleteMenu()
            Case "Orders"
                DeleteOrders()
            Case "Orders & Employees"
                DeleteOrders()
                DeleteEmployees()
            Case "Orders & Meals"
                DeleteOrders()
                DeleteMeals()
            Case "All"
                DeleteOrders()
                DeleteEmployees()
                DeleteMeals()
                DeleteMenu()
        End Select
    End Sub

    Private Sub DeleteOrders()
        FileClose(OrderFileNumber)
        FileClose(OrderItemFileNumber)
        Kill(OrderFilePath)
        Kill(OrderItemFilePath)
        FileOpen(OrderFileNumber, OrderFilePath, OpenMode.Random, , , Len(OrderRecord))
        FileOpen(OrderItemFileNumber, OrderItemFilePath, OpenMode.Random, , , Len(OrderItemRecord))
        IDRecord.FileNumber = OrderFileNumber
        IDRecord.ID = 0
        FilePut(IDFileNumber, IDRecord, OrderFileNumber)
    End Sub

    Private Sub DeleteEmployees()
        FileClose(EmployeeFileNumber)
        Kill(EmployeeFilePath)
        If (System.IO.Directory.Exists(DeletedEmployeeIDFilePath)) Then
            Kill(DeletedEmployeeIDFilePath)
        End If
        FileOpen(EmployeeFileNumber, EmployeeFilePath, OpenMode.Random, , , Len(EmployeeRecord))
        IDRecord.FileNumber = EmployeeFileNumber
        IDRecord.ID = 0
        FilePut(IDFileNumber, IDRecord, EmployeeFileNumber)
    End Sub

    Private Sub DeleteMeals()
        FileClose(MealFileNumber)
        Kill(MealFilePath)
        FileOpen(MealFileNumber, MealFilePath, OpenMode.Random, , , Len(MealRecord))
        IDRecord.FileNumber = MealFileNumber
        IDRecord.ID = 0
        FilePut(IDFileNumber, IDRecord, MealFileNumber)
    End Sub

    Private Sub DeleteMenu()
        Kill(MenuFilePath)
        FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Append)
        FileClose(MenuFileNumber)
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSection.SelectedIndexChanged
        Dim Found As Boolean = False
        Dim Section As String = LTrim(cmbSection.Text)
        For index = 0 To lstHelpFile.Items.Count - 1
            If Found = False Then
                lstHelpFile.SelectedIndex = index
                If LTrim(lstHelpFile.SelectedItem) = Section Then
                    Found = True
                End If
            End If
        Next
    End Sub
End Class