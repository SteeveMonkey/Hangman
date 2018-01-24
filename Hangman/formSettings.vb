Imports System.IO

Public Class formSettings
    '---- Variables ----
    'File
    ' preview
    Dim wordListPreview As String
    Dim wordsInPreview As Integer
    ' maximum preview length
    Dim wordListPreviewMaxLength As Integer = 10000
    Dim wordListPreviewMaxExceeded As Boolean
    ' selected
    Dim wordListIndex As Integer
    ' new
    Dim newWordListName As String
    Dim newWordListLocation As String

    'Other
    Dim acceptableName As Boolean
    Dim helpMessage As String
    Dim invalidFileNameChars As String
    Dim inputCanceled As Boolean


    '---- Class Subs ----
    Private Sub formSetting_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        LoadSettings()
        UpdateWordListPreview()
        VerifiySettings()
        formMainMenu.Show()
    End Sub

    Private Sub formSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable file minipulation buttons
        tblWordListsButtons.Visible = False

        'run two subs that load other parts of the settings
        LoadSettings()
        UpdateWordListsList()

        'Show the settings in the form not covered by the other two subs
        'set up/down number boxes to saved values
        nudWordSizeMin.Value = wordSizeMin
        nudWordSizeMax.Value = wordSizeMax
        'set selected radio button to to saved maximun wrong answers
        pnlMaxMistakes.Controls("rbnMax" & maxIncorrectGuesses).Select()

        btnConfirm.Select()
    End Sub

    Private Sub formSettings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateWordListsList()
        UpdateWordListPreview()
    End Sub

    Private Sub SaveSettings()
        'Write settings to file
        outFile = New System.IO.StreamWriter("settings.txt")

        outFile.WriteLine(wordListLocation)
        outFile.WriteLine(wordListName)
        outFile.WriteLine(WordListLength)
        outFile.WriteLine(wordsUsable)
        outFile.WriteLine(wordSizeMin)
        outFile.WriteLine(wordSizeMax)
        outFile.WriteLine(maxIncorrectGuesses)

        outFile.Close()
    End Sub

    Private Sub btnRestoreDefaultSettings_Click(sender As Object, e As EventArgs) Handles btnRestoreDefaultSettings.Click
        'run three subs that load other parts of the settings
        LoadSettings(True)
        UpdateWordListsList()
        UpdateWordListPreview()

        'Show the settings in the form not covered by the other three subs
        'set up/down number boxes to saved values
        nudWordSizeMin.Value = wordSizeMin
        nudWordSizeMax.Value = wordSizeMax
        'set selected radio button to to saved maximun wrong answers
        pnlMaxMistakes.Controls("rbnMax" & maxIncorrectGuesses).Select()

        btnConfirm.Select()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If invalidSettings Then
            '-If the settings are invalid, warn user and go to settings
            MsgBox("One or more settings are invalid!" & vbCrLf & "You will not be able to continue without fixing the settings!", MsgBoxStyle.Critical, "ERROR")
        Else
            SaveSettings()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        LoadSettings()
        If invalidSettings Then
            '-If the settings are invalid, warn user and go to settings
            MsgBox("One or more settings are invalid!" & vbCrLf & "You will not be able to continue without fixing the settings!", MsgBoxStyle.Critical, "ERROR")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub lstWordLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWordLists.SelectedIndexChanged
        'Update variables to selected list item
        wordListIndex = lstWordLists.SelectedIndex
        wordListName = lstWordLists.SelectedItem
        wordListLocation = "WordLists\" & wordListName & ".txt"
        UpdateWordListPreview()
    End Sub

    Private Sub nudWordSizeMin_ValueChanged(sender As Object, e As EventArgs) Handles nudWordSizeMin.ValueChanged
        'Only change Min if new value is a number
        If IsNumeric(nudWordSizeMin.Value) Then
            wordSizeMin = nudWordSizeMin.Value
            'If Min is higher than Max, set Max to new Min value
            If wordSizeMin > wordSizeMax Then
                nudWordSizeMax.Value = wordSizeMin
            End If
            UpdateWordListPreview()
        End If
    End Sub

    Private Sub nudWordSizeMax_ValueChanged(sender As Object, e As EventArgs) Handles nudWordSizeMax.ValueChanged
        'Only change Max if new value is a number
        If IsNumeric(nudWordSizeMax.Value) Then
            wordSizeMax = nudWordSizeMax.Value
            'If Max is lower than Min, set Min to new Max value
            If wordSizeMax < wordSizeMin Then
                nudWordSizeMin.Value = wordSizeMax
            End If

            UpdateWordListPreview()
        End If
    End Sub

    Private Sub UpdateWordListPreview()
        If wordListName = "" Or wordListLocation = "" Or wordListIndex = -1 Then
            invalidSettings = True
            '-If a word list is NOT selected
            txtWordListPreview.Text = "NO WORD LIST SELECTED!" & vbCrLf &
                                      "A word list must be selected!"
        Else
            '-If a word list is selected
            invalidSettings = False

            'Read file to get word list
            inFile = New System.IO.StreamReader(wordListLocation)
            'System.IO.File.WriteAllText("usableWords.txt", "")
            outFile = New System.IO.StreamWriter("usableWords.txt")

            wordsInPreview = 0
            wordListPreviewMaxExceeded = False
            wordsUsable = 0
            WordListLength = 0
            wordListPreview = ""
            eof = False
            Do Until eof
                'Read Line
                word = inFile.ReadLine
                If word = Nothing Then
                    '-Stop if line is nothing
                    eof = True
                Else
                    '-Continue if line is not nothing
                    WordListLength = WordListLength + 1

                    If word.Length >= wordSizeMin And word.Length <= wordSizeMax Then
                        '-If the word meets word length Min and Max reqirements
                        wordsUsable = wordsUsable + 1
                        outFile.WriteLine(word)
                        wordsInPreview = wordsInPreview + 1
                        If Not wordListPreviewMaxExceeded Then
                            wordListPreview = wordListPreview & word & vbCrLf
                        End If
                    End If

                    If Not wordListPreviewMaxExceeded Then
                        '-If the list is NOT longer than the set maximum

                        If wordsInPreview > wordListPreviewMaxLength Then
                            '-If the list is longer than the set maximum,
                            'eof = True
                            wordListPreviewMaxExceeded = True
                            wordListPreview = "The preview is limited to the first " & FormatNumber(wordListPreviewMaxLength, 0) & " words" & vbCrLf &
                                              vbCrLf &
                                              vbCrLf &
                                              wordListPreview
                        End If
                    End If
                End If
            Loop
            inFile.Close()
            outFile.Close()

            'Display preview
            If wordListPreviewMaxExceeded Then
                txtWordListPreview.Text = wordListPreview & vbCrLf & "+" & FormatNumber(wordsUsable - wordListPreviewMaxLength, 0) & " more words"
            Else
                If wordsUsable > 0 Then
                    txtWordListPreview.Text = wordListPreview
                Else
                    txtWordListPreview.Text = "WARNING: Game cannot be played without words!" & vbCrLf & vbCrLf & "You must make sure there are at least some words to use!"
                    invalidSettings = True
                End If
            End If
            lblWordsUsable.Text = "Usable Words: " & FormatNumber(wordsUsable, 0)
            lblWordsInFile.Text = "Words in File: " & FormatNumber(WordListLength, 0)
        End If
    End Sub


    'File Modification Buttons
    Private Sub btnCreateWordList_Click(sender As Object, e As EventArgs) Handles btnCreateWordList.Click
        '-Create a new word list
        NewFileNameFromUser("Enter the name of the new word list")
        If inputCanceled = False Then
            outFile = New System.IO.StreamWriter(newWordListLocation)
            outFile.Close()
            'File.Open(newWordListLocation, FileMode.Open)
            UpdateWordListsList()
        End If
    End Sub

    Private Sub btnCopyWordList_Click(sender As Object, e As EventArgs) Handles btnCopyWordList.Click
        '-Copy the selected word list
        NewFileNameFromUser("Enter the name for the copy of '" & wordListName & "'")
        If inputCanceled = False Then
            File.Copy(wordListLocation, newWordListLocation)
            UpdateWordListsList()
        End If
    End Sub

    Private Sub btnEditWordList_Click(sender As Object, e As EventArgs) Handles btnEditWordList.Click
        '-Edit the selected word list
        'NewFileNameFromUser()
        Process.Start(wordListLocation)
    End Sub

    Private Sub btnDeleteWordList_Click(sender As Object, e As EventArgs) Handles btnDeleteWordList.Click
        '-Delete the selected word list
        Dim msgResult = MsgBox("Are you sure you want to delete the '" & wordListName & "' word list?" & vbCrLf &
               "This can not be undone!", MsgBoxStyle.YesNo, "Confirm Deletion")
        If msgResult = MsgBoxResult.Yes Then
            File.Delete(wordListLocation)
            UpdateWordListsList()
        End If
    End Sub

    Private Sub NewFileNameFromUser(message As String)

        inputCanceled = False
        newWordListName = ""
        acceptableName = False
        Do Until acceptableName
            newWordListName = InputBox(message & vbCrLf & helpMessage, "Create Word List", newWordListName)

            helpMessage = ""
            If newWordListName = "" Then
                '-If there is no input
                inputCanceled = True
                Exit Do
            Else
                '-If there are more than 0 characters
                For Each fileName As String In My.Computer.FileSystem.GetFiles("WordLists")
                    '-Repeat for each file found in 'WordLists' folder
                    fileName = Path.GetFileNameWithoutExtension(fileName)
                    If newWordListName = fileName Then
                        '-If the user entered name matches an existing one,
                        helpMessage = "The name canot be the same as another word list"
                        Exit For
                    End If
                Next

                If helpMessage = "" Then
                    For Each invalidChar As Char In System.IO.Path.GetInvalidFileNameChars
                        '-Reapeat for each invalid character for file names

                        'InStr() outputs a number of how many times that character
                        If InStr(newWordListName, invalidChar) > 0 Then
                            helpMessage = "The name canot contain <, >, :, "", /, \, |, ? or *"
                            Exit For
                        End If
                    Next
                    If helpMessage = "" Then
                        '-If help message is still blank, then the user entered name has passed the tests
                        acceptableName = True
                        newWordListLocation = "WordLists\" & newWordListName & ".txt"
                    End If
                End If
            End If
        Loop
    End Sub

    Private Sub UpdateWordListsList()
        'Find the available word lists and display
        lstWordLists.Items.Clear()
        For Each fileName As String In My.Computer.FileSystem.GetFiles("WordLists")
            '-Repeat for each file found in 'WordLists' folder
            fileName = Path.GetFileNameWithoutExtension(fileName)
            lstWordLists.Items.Add(fileName)
        Next

        ' find the index by name
        wordListIndex = lstWordLists.FindString(wordListName)
        If wordListIndex = -1 Then
            '-If the word list doesn't exist
            txtWordListPreview.Text = "NO WORD LIST SELECTED!" & vbCrLf &
                                      "A word list must be selected!"
        Else
            '-If the word list exists
            lstWordLists.SetSelected(wordListIndex, True)
            UpdateWordListPreview()
        End If
    End Sub


    'Radial Buttons
    Private Sub ChangeRadialButtons(number As Integer)
        maxIncorrectGuesses = number
    End Sub

    Private Sub rbnMax3_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMax3.CheckedChanged
        ChangeRadialButtons(3)
    End Sub

    Private Sub rbnMax6_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMax6.CheckedChanged
        ChangeRadialButtons(6)
    End Sub

    Private Sub rbnMax8_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMax8.CheckedChanged
        ChangeRadialButtons(8)
    End Sub

    Private Sub rbnMax10_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMax10.CheckedChanged
        ChangeRadialButtons(10)
    End Sub

    Private Sub rbnMax12_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMax12.CheckedChanged
        ChangeRadialButtons(12)
    End Sub

    Private Sub rbnMax14_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMax14.CheckedChanged
        ChangeRadialButtons(14)
    End Sub

End Class