'Autor: Waheed Rafiq
'Written Date: 25/12/2013
'URL: www.waheedrafiq.com
'This program purpose is to test user spelling by define user own words.


Option Explicit On
Option Strict On

Imports System.Speech.Synthesis   ' Import the Speech API
Imports System.IO    ' Import System.IO API
Imports System      ' Import System API
Imports System.Text



Public Class frmMain


    Dim PathFinder As String = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName ' Store the system path in PathFinder
    Dim speakWord As New SpeechSynthesizer ' Declare variable speakWord as SpeechSynthesizer 
    Dim FILE_NAME As String = Application.StartupPath & "\Spelling\englishspelling.txt"
    Dim sLine As String = ""  ' Declare sLine as string variable to be use in the loop
    Dim userInput As String    ' declare UserInput as string to be use to store user value.
    Dim TextReturned As String = ""
    Dim A As New frmInputBox
    ' Dim StartMenuFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
    ' Dim StartupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

    ' testing this code



    Private Sub frmMain_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested

        System.Diagnostics.Process.Start("http://www.waheedrafiq.com/software/EnglishSpellingABC.htm")

    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        ' Hide the frmWrongSpelling form

        frmWrongSpelling.Hide()
       
        ' Testing shortcut code here

        






    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")> Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Dim WrongSpellingLocation As String = Application.StartupPath & "\Spelling\WrongSpelling.txt"
        Dim Count, CountWrongAnswer As Integer ' Count , CountWrongAnswer as Integer datatype

        ' if the file exist then execute the code below REF A1

        If System.IO.File.Exists(FILE_NAME) = True Then 'REF A1 start here
            Dim ObjReader As New System.IO.StreamReader(Application.StartupPath & "\Spelling\englishspelling.txt")

            'Class1.ObjReader = New StreamReader(Application.StartupPath & "\Spelling\englishspelling.txt") ' open the file

            speakWord.Speak("About to start spelling test")
            lblScore.Text = CStr(Val(Count.ToString))
            lblWrongScore.Text = CStr(Val(CountWrongAnswer.ToString))

            Do While ObjReader.EndOfStream = False ' Do while the reference point is not EOF


                sLine = ObjReader.ReadLine()   ' Store the value in text file to sLine
                speakWord.Speak(sLine)    ' Speak to the value store in Sline



                ' userInput = InputBox("Type your word")   ' Ask user to type what was spoken by the system.
                Class1.Cancel = False ' user has not press cancel button from the inputbox

                If A.ShowDialog("English Spelling ABC", "Enter the word spoken by the System below", "Default", TextReturned, False) = Windows.Forms.DialogResult.Cancel Or Class1.Cancel = True Then
                    ' Cancel has been pressed
                    speakWord.Speak("Spelling test has ended well done " & "You have Scored" & Count & " Right answer and got  " & CountWrongAnswer & "Wrong")
                    ObjReader.Close()

                    If CountWrongAnswer > 0 Then
                        frmWrongSpelling.Show()
                    End If

                    Exit Do


                Else
                    userInput = Class1.GUserinput

                    If sLine.ToUpper.Trim = userInput.ToUpper.Trim Then  ' value in sLine convert To uppercase and trim any spaces equal to userInput convert to uppercase and trim any spaces
                        speakWord.Speak("Well done that was the correct answer")
                        Count += 1
                        lblScore.Text = CStr(Val(Count.ToString))

                    ElseIf sLine.ToUpper.Trim <> userInput.ToUpper.Trim Then

                        'This section is for wrong spelling if wrong then add to the list of wrongSpelling.
                        speakWord.Speak("Wrong spelling")
                        CountWrongAnswer += 1
                        lblWrongScore.Text = CStr(Val(CountWrongAnswer.ToString))

                        If System.IO.File.Exists(WrongSpellingLocation) = True Then   'if the file exist then execute the conditon below

                            Dim ObjWriter As StreamWriter = File.AppendText(WrongSpellingLocation)

                            ObjWriter.WriteLine(sLine)
                            ObjWriter.Close()



                        ElseIf System.IO.File.Exists(WrongSpellingLocation) = False Then
                            System.IO.Directory.CreateDirectory("Spelling")

                            File.Create(Application.StartupPath & "\Spelling\WrongSpelling.txt").Dispose()

                            Using ObjWriter As StreamWriter = New StreamWriter(WrongSpellingLocation)

                                ObjWriter.WriteLine(sLine) ' text is been written to WrongSpelling.txt file. 
                                ObjWriter.Close()



                            End Using
                        End If


                    End If

                End If

                If ObjReader.EndOfStream = True Then ' if the objreader is end of file

                    speakWord.Speak("Spelling test has ended well done " & "You have Scored" & Count & " Right answer and got  " & CountWrongAnswer & "Wrong")
                    ObjReader.DiscardBufferedData()
                    ObjReader.BaseStream.Seek(0, SeekOrigin.Begin)
                    ObjReader.Close()
                    ' Class1.ObjReader = New StreamReader(Application.StartupPath & "\Spelling\englishspelling.txt")

                    If CountWrongAnswer > 0 Then
                        frmWrongSpelling.Show()
                    End If

                    Exit Do

                End If





            Loop
        ElseIf System.IO.File.Exists(FILE_NAME) = False Then ' if EnglishSpelling.txt is not found then display message


            MsgBox("Please Add some new words to learn ")
        End If



    End Sub

    Private Sub txtUserInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")> Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click

        ' Class1.ObjReader.Close() ' closed the Reader Stream 


        If txtUserInput.Text = "" Then
            MsgBox("Enter new words to learn")
        Else

            If System.IO.File.Exists(FILE_NAME) = True Then   'if the file exist then execute the conditon below

                Dim ObjWriter As StreamWriter = File.AppendText(FILE_NAME)

                ObjWriter.WriteLine(txtUserInput.Text)
                ObjWriter.Close()
                MsgBox("Text Appended to file")
                txtUserInput.Clear()

            ElseIf System.IO.File.Exists(FILE_NAME) = False Then

                System.IO.Directory.CreateDirectory("Spelling")
                File.Create(Application.StartupPath & "\Spelling\englishspelling.txt").Dispose()

                Using ObjWriter As StreamWriter = New StreamWriter(FILE_NAME)

                    ObjWriter.WriteLine(txtUserInput.Text)
                    ObjWriter.Close()
                    MsgBox("Text written to New file called englishspelling.txt")
                    txtUserInput.Clear()

                End Using

            End If
        End If

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit() ' Exit Application 

    End Sub

    Private Sub btnShowWrongSpelling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowWrongSpelling.Click

        frmWrongSpelling.Show() ' Display the fromWrongSpelling
        Me.Close() ' Close Spelling form 

    End Sub

    Private Sub txtUserInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserInput.KeyDown
        If e.KeyCode = Keys.Enter Then ' if user press Enter button run the command btnWrite click 

            e.SuppressKeyPress = True

            btnWrite.PerformClick()

        End If
    End Sub

    Private Sub txtUserInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserInput.KeyPress

    End Sub

    Private Sub txtUserInput_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserInput.TextChanged

    End Sub

    Private Sub lblLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked

        System.Diagnostics.Process.Start("http://www.waheedrafiq.com")


    End Sub

    Private Sub lblLinkHelp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLinkHelp.LinkClicked

        System.Diagnostics.Process.Start("http://www.waheedrafiq.com/software/EnglishSpellingABC.htm")

    End Sub
End Class
