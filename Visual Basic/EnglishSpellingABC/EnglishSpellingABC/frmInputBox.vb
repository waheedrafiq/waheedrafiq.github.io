'Custom Inputbox 
' Autor : Waheed Rafiq
' Date Written: 09/12/2013

Imports System.Windows.Forms



Public Class frmInputBox
    Protected m_BlankValid As Boolean = True ' Declare Variable as Protected
    Protected m_ReturnText As String = ""

    Public Overloads Function ShowDialog(ByVal TitleText As String, ByVal PromptText As String, ByVal DefaultText As String, ByRef EnteredText As String, ByVal BlankValid As Boolean) As System.Windows.Forms.DialogResult

        m_BlankValid = BlankValid ' Initialse variable 

        Me.lblInputBox.Text = PromptText
        Me.Text = TitleText
        Me.m_ReturnText = DefaultText
        Me.ShowDialog()
        EnteredText = m_ReturnText
        Return Me.DialogResult
    End Function
    Private Sub frmInputBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtInputBox.Focus() ' set the cursor focus in the text inputbox 


    End Sub

    Private Sub txtInputBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputBox.KeyDown

        If e.KeyCode = Keys.Enter Then  'if user press Enter button run the command btnWrite click 

            e.SuppressKeyPress = True

            btnOkay.PerformClick()



        End If

    End Sub

    Private Sub txtInputBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputBox.KeyPress

      



    End Sub

    Private Sub txtInputBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInputBox.TextChanged

        If Me.txtInputBox.Text = "" Then    ' if the text box is empty then assign the value m_BlankValid boolean 

            Me.btnOkay.Enabled = m_BlankValid

        Else

            Me.btnOkay.Enabled = True   ' else btn OKay is enable

        End If

    End Sub

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click




        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Class1.GUserinput = Me.txtInputBox.Text




        Me.Close()
        txtInputBox.Text = ""


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim UsrPressCancel As Boolean ' Declare variable as Boolean

        UsrPressCancel = True    ' Initialise variable

        Class1.Cancel = UsrPressCancel  ' Assign value of variable to Class.Cancel Global variable.

        Me.Close()  ' Close frmInputbox





    End Sub
End Class
