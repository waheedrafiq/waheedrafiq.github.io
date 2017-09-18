Public Class Form1
    'Create a global variable. This variable will keep the 
    'position of related record.
    Dim Position As Integer

    'Create a record type. The name of the record 
    'type is given as “Person”.
    Structure Person
        Dim ID As Integer
        Dim Name As String
        Dim Surname As String
    End Structure

    'This is the function that we are using to find a last 
    'record’s number in the random file.
    Private Function FindLastRecordNo() As Integer
        Dim Temp As Person, FileNumber As Integer

        'Get the available file number.    
        FileNumber = FreeFile()

        'Open the file by using the FileOpen statement 
        'in a random mode with       
        'only read access. The name of the file 
        'will be same as the text in the  
        'TextBox1 (Textbox1 is on the “Create” tab page). 
        'Len(Temp) function is use 
        'to determine the size of record in bytes. 
        FileOpen(FileNumber, txtCreate.Text, OpenMode.Random, _
          OpenAccess.Read, , Len(Temp))

        FindLastRecordNo = 1

        'EOF() function is using to detect the end of file.
        Do While Not EOF(FileNumber)
            'FileGet() function is using to get a record from random file.
            FileGet(FileNumber, Temp, )
            FindLastRecordNo = FindLastRecordNo + 1
        Loop

        'Close the file.
        FileClose(FileNumber)
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim RecLength As Long, Employee As Person

        'Get the next available file number.
        FileNum = FreeFile()

        'Open the new random file with the FileOpen statement.
        FileOpen(FileNum, txtCreate.Text, _
          OpenMode.Random, , , Len(Employee))

        'Close the file.
        FileClose(FileNum)

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim Employee As Person, LastRecord As Integer

        'Find the last record number of random file. FindLastRecordNo() 
        'function, which is shown above, is called.
        LastRecord = FindLastRecordNo()

        FileNum = FreeFile()
        FileOpen(FileNum, TextBox1.Text, OpenMode.Random, , , Len(Employee))
        Employee.ID = Val(TextBox2.Text)
        Employee.Name = TextBox3.Text
        Employee.Surname = TextBox4.Text

        'Put the Employee record into the random file as a last record.
        FilePut(FileNum, Employee, LastRecord)

        FileClose(FileNum)

    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click

        Dim Employee As Person, Count As Integer, Temp As String
        FileNum = FreeFile()
        FileOpen(FileNum, txtCreate.Text, OpenMode.Random, , , Len(Employee))
        Count = 1
        LstOutput.Items.Clear()
        Do While Not EOF(FileNum)
            'Read the record on the position Count.
            FileGet(FileNum, Employee, Count)

            'str() function is used to convert integer to string.
            Temp = Str(Employee.ID) + "  " + Employee.Name + _
              "  " + Employee.Surname

            'Add the string into Listbox.
            LstOutput.Items.Add(Temp)
            Count = Count + 1
        Loop
        FileClose(FileNum)








    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim Employee As Person
        FileNum = FreeFile()
        FileOpen(FileNum, TextBox1.Text, _
          OpenMode.Random, , , Len(Employee))
        Do While Not EOF(FileNum)
            FileGet(FileNum, Employee, )
            If Employee.ID = Val(TextBox5.Text) Then
                'Keep the current position of record 
                'in “Position” variable to 
                'use in further use such as update or delete operations.
                Position = Loc(FileNum)

                'Change enable status for some Textboxes.
                TextBox5.Enabled = False
                TextBox6.Enabled = True
                TextBox7.Enabled = True
                Button5.Enabled = True
                Button6.Enabled = False
                Button7.Enabled = True

                'Show the Employee name and surname in the related Textboxes.
                TextBox6.Text = Employee.Name
                TextBox7.Text = Employee.Surname
                Exit Do
            End If
        Loop
        FileClose(FileNum)

    End Sub
End Class
