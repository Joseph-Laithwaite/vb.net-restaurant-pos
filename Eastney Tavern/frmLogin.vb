Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Index As Integer
        FileOpen(MealFileNumber, MealFilePath, OpenMode.Random, , , Len(MealRecord))                'Open all files
        FileOpen(OrderFileNumber, OrderFilePath, OpenMode.Random, , , Len(OrderRecord))
        FileOpen(OrderItemFileNumber, OrderItemFilePath, OpenMode.Random, , , Len(OrderItemRecord))
        FileOpen(EmployeeFileNumber, EmployeeFilePath, OpenMode.Random, , , Len(EmployeeRecord))
        FileOpen(IDFileNumber, IDFilePath, OpenMode.Random, , , Len(IDRecord))
        FileOpen(MenuFileNumber, MenuFilePath, OpenMode.Append)
        FileClose(MenuFileNumber)
        If LOF(IDFileNumber) / Len(IDRecord) = 0 Then       'Set up ID file 
            For Index = 1 To IDFileNumber
                IDRecord.FileNumber = Index
                IDRecord.ID = 0
                FilePut(IDFileNumber, IDRecord, Index)
            Next
        End If
        If LOF(EmployeeFileNumber) / Len(EmployeeRecord) = 0 Then
            FirstUse = True
            frmEmployees.Show()
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim EmployeeRecordNumber As Short
        If txtPassword.Text = "" Then
            CurrentUserAdministrator = False
            If txtEmployeeID.Text = "" Then
                MsgBox("Please enter an employee ID (And password if you're an asministration)")
            ElseIf IsNumeric(txtEmployeeID.Text) = False Then
                MsgBox("Please enter a valid employee ID (with only numbers)")
            Else
                If ValidID(EmployeeRecordNumber) = True Then
                    CurrentEmployeeID = txtEmployeeID.Text
                    Me.Hide()
                    txtEmployeeID.Text = ""
                    frmOrders.Show()
                Else
                    MsgBox("Please enter a valid employee ID")
                End If
            End If
        Else
            If txtEmployeeID.Text = "" Then
                MsgBox("Please enter an employee ID")
            ElseIf ValidID(EmployeeRecordNumber) = True Then
                If ValidPassword(EmployeeRecordNumber) = True Then
                    Me.Hide()
                    CurrentUserAdministrator = True
                    CurrentEmployeeID = txtEmployeeID.Text
                    frmMenu.Show()
                Else
                    MsgBox("The Password you entered is invalid, please try again" & vbNewLine & "Remeber the password is case sensitive")
                End If
            End If
        End If
    End Sub

    Function ValidID(ByRef EmployeeRecordNumber) As Boolean
        Dim Index As Integer
        For Index = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)      'Loop through the employee file to check the ID exists.
            FileGet(EmployeeFileNumber, EmployeeRecord, Index)
            If EmployeeRecord.EmployeeID = txtEmployeeID.Text Then
                EmployeeRecordNumber = EmployeeRecord.RecordNumber
                Return True
            End If
        Next Index
    End Function

    Function ValidPassword(ByVal EmployeeRecordNumber) As Boolean
        FileGet(EmployeeFileNumber, EmployeeRecord, EmployeeRecordNumber)       'Open the record of the ID 
        If RTrim(EmployeeRecord.Password) = txtPassword.Text Then               'Compare the ID's password with what's writen.
            Return True
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End     'Quits the program
    End Sub

    Private Sub btnHack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHack.Click
        Me.Hide()
        frmMenu.Show()
        CurrentUserAdministrator = True
    End Sub

End Class
