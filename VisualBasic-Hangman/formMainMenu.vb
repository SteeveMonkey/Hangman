Public Class formMainMenu

    Private Sub formMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub FormMainMenu_GotFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        'formSettings.Visible = True
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        VerifiySettings()

        If invalidSettings = True Then
            'If the settings are invalid, warn user and go to settings
            MsgBox("One or more settings are invalid!" & vbCrLf & "You will not be able to play until the settings are fixed!", MsgBoxStyle.Critical, "ERROR")
            btnGoToSettings_Click(Nothing, Nothing)
        Else
            'If the settings are fine, open the game
            formGame.Visible = True
            Me.Hide()
        End If
    End Sub

    Private Sub btnGoToSettings_Click(sender As Object, e As EventArgs) Handles btnGoToSettings.Click
        formSettings.Visible = True
        Me.Hide()
    End Sub

End Class
