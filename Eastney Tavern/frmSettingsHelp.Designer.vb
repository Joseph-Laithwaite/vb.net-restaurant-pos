<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsHelp
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
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbDeleteMenu = New System.Windows.Forms.ComboBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtAddMenu = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstHelpFile = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbSection = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnBackUp = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnUpload = New System.Windows.Forms.Button
        Me.cmbDeleteFile = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMainMenu.Location = New System.Drawing.Point(444, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnMainMenu.TabIndex = 30
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbDeleteMenu)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtAddMenu)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 139)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu File"
        '
        'cmbDeleteMenu
        '
        Me.cmbDeleteMenu.ForeColor = System.Drawing.Color.Black
        Me.cmbDeleteMenu.FormattingEnabled = True
        Me.cmbDeleteMenu.Location = New System.Drawing.Point(77, 75)
        Me.cmbDeleteMenu.Name = "cmbDeleteMenu"
        Me.cmbDeleteMenu.Size = New System.Drawing.Size(88, 21)
        Me.cmbDeleteMenu.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(30, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAddMenu
        '
        Me.txtAddMenu.ForeColor = System.Drawing.Color.Black
        Me.txtAddMenu.Location = New System.Drawing.Point(77, 20)
        Me.txtAddMenu.Name = "txtAddMenu"
        Me.txtAddMenu.Size = New System.Drawing.Size(88, 20)
        Me.txtAddMenu.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(30, 102)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Delete Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Add Menu"
        '
        'lstHelpFile
        '
        Me.lstHelpFile.ColumnWidth = 560
        Me.lstHelpFile.FormattingEnabled = True
        Me.lstHelpFile.Items.AddRange(New Object() {"A brief introduction", "This system is a bespoke system designed for the Eastney tavern a Pub and Restaur" & _
                        "ant in Portsmouth. This ", "system focuses on the restaurant side of the business allowing the waiting staff " & _
                        "to order food from the computer ", "at the bar and the orders to be sent to the printer in the kitchen. This system w" & _
                        "orks by first entering base data for ", "employees and meals. Employees can now use the system during service to login to " & _
                        "the Orders form, hear they ", "simply enter a table number and select the meals wanted then send this to the kit" & _
                        "chen, it also calculates totals ", "and prices so the receipt can be printed off as well. It can also be used to anal" & _
                        "yse the sales of each meal as well ", "as the performance of the employees and the overall profits made.", "", "Installation and setup", "Select the setup application from the download, USB disk or CD and Click install." & _
                        " Now the application will open ", "up, as this is the first time use a message will appear and you must click OK to " & _
                        "this. The employee’s form and ", "login form will both appear, at this point you should create an employee record w" & _
                        "ith a password. Re-enter the ", "password when prompted and close the employee form. Finally enter the newly creat" & _
                        "ed employee info into the ", "login screen and you now have total access to the system.", "", "Description for the use", "", "Login", "You can get access to this system in two different ways; the first is without a p" & _
                        "assword. This is how all waiting ", "staff will log in, it’s quicker and you don’t get access to private monetary and " & _
                        "performance information. To use ", "this method you simply enter your user ID and you are logged into the orders form" & _
                        ". Alternatively, if you are an ", "administrator you can gain access to the full system by logging in using you user" & _
                        "name and password, this takes ", "you to the menu form.", "", "Menu", "From this form you can select any button, the 5 buttons on the left hand side tak" & _
                        "e you to the relevant form, the ", """Log out"" button logs you out and takes you to the Login form and finally the ""Ex" & _
                        "it"" button closes the system ", "completely.", "", "Orders", "The orders form can be loaded in two ways, the only difference is that the ""Main " & _
                        "Menu"" button is a ""Log Out"" ", "button when you logged in without a password, otherwise the functionality is the " & _
                        "same.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Creating an order", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To create a new order you first have to click the ""New Order"" button, this will " & _
                        "automatically fill the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "OrderID, Date and Employee Name as well as loading the order to be printed in th" & _
                        "e kitchen and the", "" & Global.Microsoft.VisualBasic.ChrW(9) & " receipt for the customer. Now write in the table number and use the selection b" & _
                        "oxes to enter a meal. ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Enter the quantity using the keyboard. Now press the ""Add"" button and the meal w" & _
                        "ill be added to the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "order.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Deleting a Meal" & Global.Microsoft.VisualBasic.ChrW(9), "" & Global.Microsoft.VisualBasic.ChrW(9) & "You can delete one meal from an order by selecting the meal in either the Kitche" & _
                        "n Order box or the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Customer Receipt Box. Now the meal is selected press the ""Delete Meal"" button. T" & _
                        "he meal has been ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "deleted. ", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Deleting an Order", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To delete an order you have to make sure the order selected is the one you want " & _
                        "deleted. To select a ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "different order click the selection box next to ""Open Orders"" and click the tabl" & _
                        "e number you want.", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Now all you have to do is press the ""Delete Order"" button and say yes to the que" & _
                        "ry box. The Order has ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "now been deleted.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Printing", "" & Global.Microsoft.VisualBasic.ChrW(9) & "You can print both of the data shown (Customer Report and Kitchen Order), to do " & _
                        "this you simply ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "have to click the Print buttons. The Order should be printed to the kitchen prin" & _
                        "ter and the receipt to ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "the printer next to this machine. Clicking the print button brings up a print di" & _
                        "alogue box. Here you ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "should select the printer you want to print to and click print. ", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Paying (calculating change)", "" & Global.Microsoft.VisualBasic.ChrW(9) & "After printing the receipt and the customer pays you, you can now use the ""Pay"" " & _
                        "button to calculate ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "how much change they should be given. If they have paid with cash click yes. If " & _
                        "they didn’t pay with ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "cash a box will appear asking if the table has been cleared and can now be used " & _
                        "by a different group.", "" & Global.Microsoft.VisualBasic.ChrW(9) & " Clicking yes will remove this order from the order form. If they did pay with c" & _
                        "ash then this box will ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "open, in this box you enter the total amount of money the customer paid and clic" & _
                        "k ""OK"". Finally the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "amount of change you need to give is displayed and again asks if the table has b" & _
                        "een cleared.", "", "Meals", "This form is where meals can be added or edited as well as displaying all the imp" & _
                        "ortant information such and ", "price and allergy advice. Every meal has assigned to it a menu and this can be us" & _
                        "ed to search for a specific meal ", "very quickly, using the selection boxes at the top of the form. ", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Adding a new meal", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To start adding a new meal you first have to click the ""New Meal"" button. The Me" & _
                        "alID will be ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "automatically created by the system but you have to enter the remaining data, mo" & _
                        "st of this data is ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "self explanatory but the check boxes will stop the meals being displayed as a po" & _
                        "ssible meal in the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "order form and the historic check box will remove the meal from all analysis lis" & _
                        "ts, then press save and", "" & Global.Microsoft.VisualBasic.ChrW(9) & " the meal has been saved.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Updating a Record", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To Update a Record you simply have to select a meal either by using the selectio" & _
                        "n boxes at the top, ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "clicking on it in the list box or using the ""Next Record"" and ""Last Record"" butt" & _
                        "ons. Now you simply ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "change the data you want changing and click save. After clicking save a message " & _
                        "will appear asking if ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "you’re sure you want to update the record, click ""Yes"". Now all the data is upda" & _
                        "ted.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Printing", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To print the list of meals and all it’s information you first have to click the " & _
                        """Print"" button. Now a print ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "dialogue will appear and you must select the printer and press print.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Employees", "" & Global.Microsoft.VisualBasic.ChrW(9) & "The employees form is very similar to the meal form and allows you to add, edit " & _
                        "and delete employee ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "information as well as working as an address book.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Creating a new employee record", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To create a new record you must press the ""New Employee"" button, this will creat" & _
                        "e a new and unused ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "employee ID and blank out the rest of the boxes ready for you to enter data.  At" & _
                        " this point you have to ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "decide whether or not the employee will be an administrator, if you wish it to b" & _
                        "e an administrator then", "" & Global.Microsoft.VisualBasic.ChrW(9) & "you must enter a password and click Save, this will prompt a message box asking " & _
                        "you to reenter the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "password. If you don’t want this employee to be an administrator then leave the " & _
                        "Password box blank ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "and click save, you then have to agree to the message box.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Searching", "" & Global.Microsoft.VisualBasic.ChrW(9) & "You can search for an employee using the text box at the top of the form. You ca" & _
                        "n search by entering ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "a First name, last name, full name or employeeID and simply clicking the ""Search" & _
                        """ button.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Deleting an employee", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To delete an employee you must have one selected, you can do this by searching f" & _
                        "or an employee, ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "clicking on a line in the list box or navigating through the records using the """ & _
                        "Nest Record"" & ", "" & Global.Microsoft.VisualBasic.ChrW(9) & """Last Record"" buttons. Now you have a record selected just click the ""delete Rec" & _
                        "ord"" button and ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Press the ""Yes"" button on the dialogue, which appears. The employee has been del" & _
                        "eted.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Reports", "" & Global.Microsoft.VisualBasic.ChrW(9) & "The Reports form is the form used to analyse the data and create useful reports " & _
                        "full of information ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "designed to show which meals are selling well, how employees are performing and " & _
                        "what profit has ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "been made. You can select the date range you want the report to be between using" & _
                        " the ""from Date"" ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "and ""To Date"" entry boxes. Once your desired date range has been entered (it wil" & _
                        "l automatically be ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "from the first order to the last order) you can click any of the three buttons, " & _
                        "which will then show other", "" & Global.Microsoft.VisualBasic.ChrW(9) & "buttons. These extra buttons will allow you to order the reports in different wa" & _
                        "y as well as searching for ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "a specific employee or meal by name.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Printing", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Printing a report is easily, once you’ve created your report you just click the " & _
                        """Print Report"" button in ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "the top left corner , this opens a print dialogue where you must select which pr" & _
                        "inter you want it to be ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "sent to and then click ""Print"".", "", "Settings/Help", "This is a miscellaneous sort of form, t Contains controls to add and remove menus" & _
                        ", backup and restore the ", "system as well as containing this help document.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Backup and restore", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Here you can restore or backup the system by pressing the appropriate buttons. T" & _
                        "o Backup click the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "button and select the folder you want to backup to.  A folder is created in this" & _
                        " directory, formatted ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Year_Month_Day-Hour_Minute " & Global.Microsoft.VisualBasic.ChrW(9) & "and is filled with the all the data files. A backup " & _
                        "is that simple.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "To Restore", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Click the restore button. A Message will appear asking if you want to Backup say" & _
                        "ing yes follows the ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "process above, otherwise you have to select a folder and the files are uploaded " & _
                        "to the system ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "overwriting the existing data.", "", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Adding and Removing Menus", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Adding or removing a menu is simple. To add a menu type it’s name into the ""Add " & _
                        "Menu"" text box ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "then click ""Add"". The menu is now saved." & Global.Microsoft.VisualBasic.ChrW(9) & "To delete the menu select it from the d" & _
                        "rop down box ", "" & Global.Microsoft.VisualBasic.ChrW(9) & """Delete Menu"" then click Delete. Agree to the dialogue box and the menu has now " & _
                        "been deleted."})
        Me.lstHelpFile.Location = New System.Drawing.Point(12, 165)
        Me.lstHelpFile.MaximumSize = New System.Drawing.Size(560, 250)
        Me.lstHelpFile.MinimumSize = New System.Drawing.Size(560, 250)
        Me.lstHelpFile.Name = "lstHelpFile"
        Me.lstHelpFile.Size = New System.Drawing.Size(560, 238)
        Me.lstHelpFile.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbSection)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(376, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 100)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Help File"
        '
        'cmbSection
        '
        Me.cmbSection.ForeColor = System.Drawing.Color.Black
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"A brief introduction", "", "Installation and setup", "", "Description for the use", "    Login", "    Menu", "    Orders", "    Meals" & Global.Microsoft.VisualBasic.ChrW(9), "    Settings/Help"})
        Me.cmbSection.Location = New System.Drawing.Point(32, 44)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(121, 21)
        Me.cmbSection.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Help Section"
        '
        'btnBackUp
        '
        Me.btnBackUp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackUp.ForeColor = System.Drawing.Color.Black
        Me.btnBackUp.Location = New System.Drawing.Point(17, 19)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(112, 23)
        Me.btnBackUp.TabIndex = 16
        Me.btnBackUp.Text = "Back Up"
        Me.btnBackUp.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpload.ForeColor = System.Drawing.Color.Black
        Me.btnUpload.Location = New System.Drawing.Point(17, 51)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(112, 23)
        Me.btnUpload.TabIndex = 31
        Me.btnUpload.Text = "Restore"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'cmbDeleteFile
        '
        Me.cmbDeleteFile.ForeColor = System.Drawing.Color.Black
        Me.cmbDeleteFile.FormattingEnabled = True
        Me.cmbDeleteFile.Items.AddRange(New Object() {"Menu", "Orders", "Orders & Meals", "Orders & Employees", "All"})
        Me.cmbDeleteFile.Location = New System.Drawing.Point(17, 82)
        Me.cmbDeleteFile.Name = "cmbDeleteFile"
        Me.cmbDeleteFile.Size = New System.Drawing.Size(112, 21)
        Me.cmbDeleteFile.TabIndex = 10
        Me.cmbDeleteFile.Text = "Select file to delete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBackUp)
        Me.GroupBox1.Controls.Add(Me.cmbDeleteFile)
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(213, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 117)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Handling"
        '
        'frmSettingsHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(584, 415)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstHelpFile)
        Me.Name = "frmSettingsHelp"
        Me.Text = "Eastney Tavern - Settings/Help"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstHelpFile As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtAddMenu As System.Windows.Forms.TextBox
    Friend WithEvents cmbDeleteMenu As System.Windows.Forms.ComboBox
    Friend WithEvents btnBackUp As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents cmbDeleteFile As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
