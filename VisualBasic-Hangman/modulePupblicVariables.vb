Module PublicVariables

    '---- Variables ----
    'File 
    'reading
    Public inFile As System.IO.StreamReader
    Public outFile As System.IO.StreamWriter
    Public eof As Boolean
    Public word As String
    ' name
    Public wordListName As String
    ' location
    Public wordListLocation As String
    ' amount of words
    Public WordListLength As Integer
    Public wordsUsable As Integer

    'Guesses
    Public maxIncorrectGuesses As Integer

    'Word length
    Public wordSizeMin As Integer
    Public wordSizeMax As Integer

    'Other
    Public invalidSettings As Boolean


    '---- Class Subs ----
    Public Sub LoadSettings(Optional restoreDefaults As Boolean = False)
        'Copy settings from file to variables
        If restoreDefaults Then
            inFile = New System.IO.StreamReader("defaultSettings.txt")
        Else
            inFile = New System.IO.StreamReader("settings.txt")
        End If

        wordListLocation = inFile.ReadLine
        wordListName = inFile.ReadLine
        WordListLength = inFile.ReadLine
        wordsUsable = inFile.ReadLine
        wordSizeMin = inFile.ReadLine
        wordSizeMax = inFile.ReadLine
        maxIncorrectGuesses = inFile.ReadLine

        inFile.Close()

        formMainMenu.lblWordList.Text = wordListName
    End Sub

    Public Sub VerifiySettings()
        If IsNumeric(WordListLength) And IsNumeric(wordsUsable) And IsNumeric(wordSizeMin) And IsNumeric(wordSizeMax) And IsNumeric(maxIncorrectGuesses) Then
            If maxIncorrectGuesses = 3 Or maxIncorrectGuesses = 6 Or maxIncorrectGuesses = 8 Or maxIncorrectGuesses = 10 Or maxIncorrectGuesses = 12 Or maxIncorrectGuesses = 14 Then
                If wordsUsable <= 0 Then
                    invalidSettings = True
                Else
                    If wordSizeMin > wordSizeMax Or wordSizeMin < 1 Then
                        invalidSettings = True
                    End If
                End If
            Else
                invalidSettings = True
            End If
        Else
            invalidSettings = True
        End If
    End Sub

End Module
