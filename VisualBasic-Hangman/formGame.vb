'  Calvin Abel
'  December 15-18, 2017
'Hangman

Public Class formGame

    '---- Variables ----
    'Guesses
    Dim incorrectGuesses As Integer
    Dim dicLetterGuessed As New Dictionary(Of Char, Boolean)
    'Word
    Dim wordToGuess As String
    Dim wordDisplay As String
    Dim wordDisplaySpaced As String
    Dim wordNumber As Integer
    'Score
    Dim losses As Integer
    Dim wins As Integer
    Dim won As Boolean
    'Other
    Dim alphabet As String = "abcdefghijklmnopqrstuvwxyz"

    Private Sub ResetDicLetterGuessed()
        Dim dicLetterGuessed As New Dictionary(Of Char, Boolean)
        dicLetterGuessed.Add("a", False)
        dicLetterGuessed.Add("b", False)
        dicLetterGuessed.Add("c", False)
        dicLetterGuessed.Add("d", False)
        dicLetterGuessed.Add("e", False)
        dicLetterGuessed.Add("f", False)
        dicLetterGuessed.Add("g", False)
        dicLetterGuessed.Add("h", False)
        dicLetterGuessed.Add("i", False)
        dicLetterGuessed.Add("j", False)
        dicLetterGuessed.Add("k", False)
        dicLetterGuessed.Add("l", False)
        dicLetterGuessed.Add("m", False)
        dicLetterGuessed.Add("n", False)
        dicLetterGuessed.Add("o", False)
        dicLetterGuessed.Add("p", False)
        dicLetterGuessed.Add("q", False)
        dicLetterGuessed.Add("r", False)
        dicLetterGuessed.Add("s", False)
        dicLetterGuessed.Add("t", False)
        dicLetterGuessed.Add("u", False)
        dicLetterGuessed.Add("v", False)
        dicLetterGuessed.Add("w", False)
        dicLetterGuessed.Add("x", False)
        dicLetterGuessed.Add("y", False)
        dicLetterGuessed.Add("z", False)
    End Sub


    '---- Class Subs ----
    Private Sub formGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewGame()
    End Sub

    Private Sub formGame_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        formMainMenu.Show()
    End Sub


    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        NewGame()
    End Sub

    Private Sub NewGame()
        Randomize()
        pnlEndGame.Visible = False

        'Reset incorrect guesses and letters guessed
        incorrectGuesses = 0
        dicLetterGuessed.Clear()
        ResetDicLetterGuessed()
        'Reacitivate all buttons
        For Each letter In UCase(alphabet)
            flpLetters.Controls("btnLetter" & UCase(letter)).Enabled = True
        Next

        'Select the hidden button
        btnPlay.Select()

        'Grab a random word from list
        wordNumber = Int(Rnd() * wordsUsable) + 1

        inFile = New System.IO.StreamReader("usableWords.txt")
        For i = 1 To wordNumber
            wordToGuess = inFile.ReadLine
        Next
        inFile.Close()

        'Print information to screen
        UpdateDisplay()
    End Sub

    Private Sub EndGame()
        'Show whole word
        For Each letter In alphabet
            dicLetterGuessed.Item(letter) = True
        Next
        UpdateDisplay()

        'Show button
        pnlEndGame.Visible = True
        btnPlay.Select()
        'Update Wins and losses and message
        lblScore.Text = "Wins: " & wins & "          Losses: " & losses
        If won Then
            lblEndGameMsg.Text = "You Won!"
        Else
            lblEndGameMsg.Text = "You Lost"
        End If
    End Sub

    Private Sub UpdateDisplay()
        'Update guess counter
        lblGuessesLeft.Text = incorrectGuesses & " / " & maxIncorrectGuesses

        'Update the word dispaly
        wordDisplay = wordToGuess
        'Replace each ungessed letter with and underscore
        For Each letter In alphabet
            '-Repeat for each character found in the alphabet string
            If dicLetterGuessed.ContainsKey(letter) = False Then
                wordDisplay = wordDisplay.Replace(letter, "_")
                wordDisplay = wordDisplay.Replace(UCase(letter), "_")
            End If
        Next
        'Add space inbetween each character
        wordDisplaySpaced = wordDisplay
        For i = 0 To (wordDisplay.Length * 2) - 1 Step 2
            wordDisplaySpaced = wordDisplaySpaced.Insert(i, " ")
        Next
        lblWord.Text = wordDisplaySpaced

        'Update the picture of the hanging man
        If maxIncorrectGuesses = 3 Then
            picHangingMan.Image = Image.FromFile("HangingMan\step" & incorrectGuesses * 2 & ".png")
        ElseIf maxIncorrectGuesses = 8 Then
            If incorrectGuesses = 7 Then
                picHangingMan.Image = Image.FromFile("HangingMan\step8.png")
            ElseIf incorrectGuesses = 8 Then
                picHangingMan.Image = Image.FromFile("HangingMan\step10.png")
            Else
                picHangingMan.Image = Image.FromFile("HangingMan\step" & incorrectGuesses & ".png")
            End If
        ElseIf maxIncorrectGuesses = 12 Then
            If incorrectGuesses = 11 Then
                picHangingMan.Image = Image.FromFile("HangingMan\step12.png")
            ElseIf incorrectGuesses = 12 Then
                picHangingMan.Image = Image.FromFile("HangingMan\step14.png")
            Else
                picHangingMan.Image = Image.FromFile("HangingMan\step" & incorrectGuesses & ".png")
            End If
        Else
            picHangingMan.Image = Image.FromFile("HangingMan\step" & incorrectGuesses & ".png")
        End If
    End Sub

    Private Sub GuessLetter(guess As Char)
        btnPlay.Select()

        '-Recives character from button
        dicLetterGuessed.Item(guess) = True
        If Not wordToGuess.Contains(guess) And Not wordToGuess.Contains(UCase(guess)) Then
            incorrectGuesses = incorrectGuesses + 1
        End If

        flpLetters.Controls("btnLetter" & UCase(guess)).Enabled = False

        UpdateDisplay()
        CheckWin()
    End Sub

    Private Sub CheckWin()
        'End game if player guessed word
        If wordToGuess = wordDisplay Then
            wins = wins + 1
            won = True
            EndGame()
        End If
        'End game if wrong gusses are at maximum
        If incorrectGuesses = maxIncorrectGuesses Then
            losses = losses + 1
            won = False
            EndGame()
        End If

    End Sub


    '---- Letter Buttons ----
    Private Sub btnLetterA_Click(sender As Object, e As EventArgs) Handles btnLetterA.Click
        guessLetter("a")
    End Sub

    Private Sub btnLetterB_Click(sender As Object, e As EventArgs) Handles btnLetterB.Click
        guessLetter("b")
    End Sub

    Private Sub btnLetterC_Click(sender As Object, e As EventArgs) Handles btnLetterC.Click
        guessLetter("c")
    End Sub

    Private Sub btnLetterD_Click(sender As Object, e As EventArgs) Handles btnLetterD.Click
        guessLetter("d")
    End Sub

    Private Sub btnLetterE_Click(sender As Object, e As EventArgs) Handles btnLetterE.Click
        guessLetter("e")
    End Sub

    Private Sub btnLetterF_Click(sender As Object, e As EventArgs) Handles btnLetterF.Click
        guessLetter("f")
    End Sub

    Private Sub btnLetterG_Click(sender As Object, e As EventArgs) Handles btnLetterG.Click
        guessLetter("g")
    End Sub

    Private Sub btnLetterQ_Click(sender As Object, e As EventArgs) Handles btnLetterQ.Click
        guessLetter("q")
    End Sub

    Private Sub btnLetterI_Click(sender As Object, e As EventArgs) Handles btnLetterI.Click
        guessLetter("i")
    End Sub

    Private Sub btnLetterJ_Click(sender As Object, e As EventArgs) Handles btnLetterJ.Click
        guessLetter("j")
    End Sub

    Private Sub btnLetterK_Click(sender As Object, e As EventArgs) Handles btnLetterK.Click
        guessLetter("k")
    End Sub

    Private Sub btnLetterL_Click(sender As Object, e As EventArgs) Handles btnLetterL.Click
        guessLetter("l")
    End Sub

    Private Sub btnLetterM_Click(sender As Object, e As EventArgs) Handles btnLetterM.Click
        guessLetter("m")
    End Sub

    Private Sub btnLetterN_Click(sender As Object, e As EventArgs) Handles btnLetterN.Click
        guessLetter("n")
    End Sub

    Private Sub btnLetterO_Click(sender As Object, e As EventArgs) Handles btnLetterO.Click
        guessLetter("o")
    End Sub

    Private Sub btnLetterP_Click(sender As Object, e As EventArgs) Handles btnLetterP.Click
        guessLetter("p")
    End Sub

    Private Sub btnLetterH_Click(sender As Object, e As EventArgs) Handles btnLetterH.Click
        guessLetter("h")
    End Sub

    Private Sub btnLetterR_Click(sender As Object, e As EventArgs) Handles btnLetterR.Click
        guessLetter("r")
    End Sub

    Private Sub btnLetterS_Click(sender As Object, e As EventArgs) Handles btnLetterS.Click
        guessLetter("s")
    End Sub

    Private Sub btnLetterT_Click(sender As Object, e As EventArgs) Handles btnLetterT.Click
        guessLetter("t")
    End Sub

    Private Sub btnLetterU_Click(sender As Object, e As EventArgs) Handles btnLetterU.Click
        guessLetter("u")
    End Sub

    Private Sub btnLetterV_Click(sender As Object, e As EventArgs) Handles btnLetterV.Click
        guessLetter("v")
    End Sub

    Private Sub btnLetterW_Click(sender As Object, e As EventArgs) Handles btnLetterW.Click
        guessLetter("w")
    End Sub

    Private Sub btnLetterX_Click(sender As Object, e As EventArgs) Handles btnLetterX.Click
        guessLetter("x")
    End Sub

    Private Sub btnLetterY_Click(sender As Object, e As EventArgs) Handles btnLetterY.Click
        guessLetter("y")
    End Sub

    Private Sub btnLetterZ_Click(sender As Object, e As EventArgs) Handles btnLetterZ.Click
        guessLetter("z")
    End Sub

End Class