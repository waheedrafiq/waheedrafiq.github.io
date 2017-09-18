Public Class frmMain

    ' declare a global variable to hold the number to be guessed
    Private NumberToGuess As Integer
    'create a global random number generator using the .NET 'Random' class
    Dim RandomGenerator As New Random
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuessNumber.Click


        'declare a local integer variable to hold the guess
        Dim GuessedNumber As Integer
        'declare a 'static' integer to keep track of number of guesses made
        Static Dim NumberofAttempts As Integer
        'declare a local boolean variable to indicate if this guess was successful
        Dim GuessedCorrectly As Boolean = False

        'increment number of attempts made and display it

        NumberofAttempts = NumberofAttempts + 1

        lblGuessesSoFar.Text = "Number of attempts so far guess: " & NumberofAttempts & "attempts"
        'get the entered text and convert it into an Integer

        GuessedNumber = Convert.ToInt32(msktbGuessNumber.Text)
        'if the guess is correct...

        If NumberToGuess = GuessedNumber Then


            lblGuessNumber.Text = "Well Done!!" & vbCrLf & "You Guessed it in " & NumberofAttempts & "attempts" & vbCrLf & "Start Guessing Again..."
            GuessedCorrectly = True
            'otherwise, if the guess is too low
        ElseIf GuessedNumber < NumberToGuess Then
            'add number to the 'too low' list
            lstLowerValues.Items.Add(GuessedNumber)
            lblGuessNumber.Text = "Try Again" & vbCrLf & "Your guess was too LOW "
            'otherwise, if the guess is too high
        ElseIf GuessedNumber > NumberToGuess Then
            lstHigherValues.Items.Add(GuessedNumber)
            lblGuessNumber.Text = "Try Again" & vbCrLf & "Your guess was too HIGH "
        End If

        'if the guess was correct...
        If GuessedCorrectly Then
            'get the next random integer number between 0 - 100 to be guessed
            NumberToGuess = RandomGenerator.Next(0, 100)
            'clear the listboxes for next set of guesses
            lstHigherValues.Items.Clear()
            lstLowerValues.Items.Clear()
            lblGuessesSoFar.Text = "Number of attempts so far: 0"
        End If
        'clears and set focus to the number text box for next guess
        msktbGuessNumber.Clear()
        msktbGuessNumber.Focus()




    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'get the next random integer number between 0 - 100 to be guessed

        NumberToGuess = RandomGenerator.Next(0, 100)



    End Sub

    Private Sub msktbGuessNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles msktbGuessNumber.KeyPress


    End Sub



    
    Private Sub msktbGuessNumber_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles msktbGuessNumber.MaskInputRejected

    End Sub
End Class
