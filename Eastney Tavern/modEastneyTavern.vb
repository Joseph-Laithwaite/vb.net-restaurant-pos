Module modEastneyTavern
    Public CurrentEmployeeID As Short               'Login details stored to make ordering easier
    Public CurrentUserAdministrator As Boolean
    Public FirstUse As Boolean = False

    Function GetEmployeeName() As String            'Function to return employee name from employee ID (signed in ID)
        Dim index As Integer
        For index = 1 To LOF(EmployeeFileNumber) / Len(EmployeeRecord)
            FileGet(EmployeeFileNumber, EmployeeRecord, index)
            If EmployeeRecord.EmployeeID = CurrentEmployeeID Then
                Return EmployeeRecord.EmployeeFirstName
            End If
        Next index
    End Function

    Public Structure Meal                           'User defined data type created for meals
        Dim RecordNumber As Short
        Dim MealID As Short
        <VBFixedString(20)> Dim MealName As String
        <VBFixedString(15)> Dim Menu As String
        Dim CostCurrent As Single
        Dim PriceCurrent As Single
        <VBFixedString(30)> Dim AllergyAdvice As String
        Dim InStock As Boolean
        Dim Historic As Boolean
    End Structure

    Public MealFormat As String = "{0,-5}{1,-21}{2,-16}{3,-7}{4,-7}{5,-6}{6,-9}{7,-30}" 'User defined format used to display the meal data in a list box.
    Public MealRecord As Meal                                                           'Create meal record
    Public MealFilePath As String = CurDir() & "/MealFile.dat"                          'Create meal file
    Public MealFileNumber As Short = 1                                                  'Assign an identifier for the file number (this makes it easier to code filehandling as you don't have to use numbers.

    <VBFixedString(15)> Public MenuRecord As String                                     'Create Menu text file
    Public MenuFilePath As String = CurDir() & "/MenuFile.txt"
    Public MenuFileNumber As Short = 2

    Public Structure Order                          'Create user defined Order Record
        Dim RecordNumber As Short
        Dim OrderID As Short
        Dim TableNumber As Short
        Dim OrderDate As Date
        Dim EmployeeID As Short
        Dim OrderCleared As Boolean
    End Structure

    Public OrderRecord As Order                     'Create order File
    Public OrderFilePath As String = CurDir() & "/OrderFile.dat"
    Public OrderFileNumber As Short = 3

    Public Structure OrderItem                      'Create user defined order item record
        Dim OrderID As Short
        Dim MealID As Short
        Dim Quantity As Short
        Dim Price As Single
        Dim Cost As Single
    End Structure

    Public OrderItemRecord As OrderItem             'Create order Item File
    Public OrderItemFilePath As String = CurDir() & "/OrderItemFile.dat"
    Public OrderItemFileNumber As Short = 4

    Public KitchenOrder As String = "{0,5}{1,20}"               'User defined formats for ordering form
    Public Receipt As String = "{0,3}{1,15}{2,6}{3,6}"

    Public Structure Employee                                   'Employee record user defined data type
        Dim RecordNumber As Short
        Dim EmployeeID As Short
        <VBFixedString(15)> Dim EmployeeFirstName As String
        <VBFixedString(15)> Dim EmployeeLastName As String
        <VBFixedString(11)> Dim PhoneNumber As String
        <VBFixedString(30)> Dim Email As String
        <VBFixedString(30)> Dim Address As String
        <VBFixedString(10)> Dim JobTittle As String
        Dim PayRate As Single
        <VBFixedString(15)> Dim EmergencyContactName As String
        <VBFixedString(11)> Dim EmergencyContactNumber As String
        <VBFixedString(15)> Dim Password As String
    End Structure

    Public EmployeeRecord As Employee                               'Employee record
    Public EmployeeFilePath As String = CurDir() & "/EmployeeFile.dat"
    Public EmployeeFileNumber As Short = 5
    Public EmployeeFormat As String = "{0,-9}{1,-32}{2,-12}{3,-31}{4,-31}{5,-11}{6,-6}{7,-16}{8,-14}"

    Public DeletedEmployeeIDRecord As Short                         'Record to store deleted Employee ID's (makes it easier to account for all sales in reports).
    Public DeletedEmployeeIDFilePath As String = CurDir() & "/DeletedEmployeeID.txt"
    Public DeletedEmployeeIDFileNumber As Short = 8

    Public Structure ID             'File to store the highest used ID for every file (makes sure they're all unique.
        Dim FileNumber As Short
        Dim ID As Short
    End Structure

    Public IDRecord As ID
    Public IDFilePath As String = CurDir() & "/IDFile.dat"
    Public IDFileNumber As Short = 6

    Public ItemProgress As Integer = 0          'Used for printing.

End Module
