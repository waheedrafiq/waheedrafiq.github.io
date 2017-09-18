Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms



Public Class frmWrongSpelling
    Dim MyArray As New ArrayList

    Dim fileLocation As String = (Application.StartupPath & "\Spelling\WrongSpelling.txt")

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click



        If System.IO.File.Exists(fileLocation) = True Then ' if the file is there then execute code 
            My.Computer.FileSystem.DeleteFile(fileLocation) ' Delete the file


            MsgBox("Wrong Spelling list has now been deleted") ' inform the user the file has now been deleted



            frmMain.Show()   ' display frmMain

            frmMain.lblScore.Text = Val(0) ' Reset the score value & Wrong Score value 
            frmMain.lblWrongScore.Text = Val(0)
            LstWrongSpelling.Items.Clear() ' clear the list box 

            Me.Close()
        ElseIf System.IO.File.Exists(fileLocation) = False Then ' if there is not file then execute the code below
            frmMain.Show() ' show frmMain 

            frmMain.lblScore.Text = Val(0) ' Reset the score value & Wrong Score value.
            frmMain.lblWrongScore.Text = Val(0)
            LstWrongSpelling.Items.Clear() ' clear the listbox
            Me.Close() ' close the Wrong Spelling form
        End If
    End Sub

    Private Sub frmWrongSpelling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WronglstLocation As String = Application.StartupPath & "\Spelling\WrongSpelling.txt"


        txtWarning.Text = "Please Print your Wrong Spelling list" & vbCrLf & "or write it on a piece of paper  to learn"

        If System.IO.File.Exists(WronglstLocation) = True Then


            Dim ObjReader As New System.IO.StreamReader(Application.StartupPath & "\Spelling\WrongSpelling.txt")

            Do While ObjReader.EndOfStream = False

                LstWrongSpelling.Items.Add(ObjReader.ReadLine())   ' Store the value in text file to sLine


            Loop

            ObjReader.Close()

        ElseIf System.IO.File.Exists(WronglstLocation) = False Then

            System.IO.Directory.CreateDirectory("Spelling")
            File.Create(Application.StartupPath & "\Spelling\WrongSpelling.txt").Dispose()

        End If



    End Sub

    Private Sub btnLoadWrong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ObjReader As New System.IO.StreamReader(Application.StartupPath & "\Spelling\WrongSpelling.txt")

        Do While ObjReader.EndOfStream = False

            LstWrongSpelling.Items.Add(ObjReader.ReadLine())   ' Store the value in text file to sLine


        Loop

        ObjReader.Close()





    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click







        'PrintDocument1.DocumentName = fileLocation

        ' PrintDocument1.PrinterSettings.Copies = 2
        PrintDocument1.Print()












    End Sub




    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim printFont As New Font("Arial", 13)
        Dim lineHeightSingle As Single = printFont.GetHeight + 2
        Dim horizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top

        Dim printLineString As String

        Dim listIndexInteger As Integer

        For listIndexInteger = 0 To Me.LstWrongSpelling.Items.Count - 1

            verticalPrintLocationSingle += lineHeightSingle

            printLineString = Me.LstWrongSpelling.Items(listIndexInteger).ToString

            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        Next listIndexInteger




    End Sub
End Class