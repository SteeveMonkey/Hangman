<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tblWordList = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWordList = New System.Windows.Forms.Label()
        Me.btnGoToSettings = New System.Windows.Forms.Button()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.tblWordList.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblWordList
        '
        Me.tblWordList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblWordList.AutoSize = True
        Me.tblWordList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblWordList.ColumnCount = 2
        Me.tblWordList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblWordList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblWordList.Controls.Add(Me.lblWordList, 0, 0)
        Me.tblWordList.Controls.Add(Me.btnGoToSettings, 1, 0)
        Me.tblWordList.Location = New System.Drawing.Point(146, 8)
        Me.tblWordList.Name = "tblWordList"
        Me.tblWordList.RowCount = 1
        Me.tblWordList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblWordList.Size = New System.Drawing.Size(130, 29)
        Me.tblWordList.TabIndex = 0
        '
        'lblWordList
        '
        Me.lblWordList.AutoSize = True
        Me.lblWordList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWordList.Location = New System.Drawing.Point(3, 0)
        Me.lblWordList.Name = "lblWordList"
        Me.lblWordList.Size = New System.Drawing.Size(63, 29)
        Me.lblWordList.TabIndex = 0
        Me.lblWordList.Text = "WordList.txt"
        Me.lblWordList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGoToSettings
        '
        Me.btnGoToSettings.AutoSize = True
        Me.btnGoToSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGoToSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGoToSettings.Location = New System.Drawing.Point(72, 3)
        Me.btnGoToSettings.Name = "btnGoToSettings"
        Me.btnGoToSettings.Size = New System.Drawing.Size(55, 23)
        Me.btnGoToSettings.TabIndex = 1
        Me.btnGoToSettings.Text = "Settings"
        Me.btnGoToSettings.UseVisualStyleBackColor = True
        '
        'btnStartGame
        '
        Me.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(72, 110)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(140, 40)
        Me.btnStartGame.TabIndex = 1
        Me.btnStartGame.Text = "Play Hangman"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'formMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.tblWordList)
        Me.MinimumSize = New System.Drawing.Size(200, 200)
        Me.Name = "formMainMenu"
        Me.Text = "Hangman - Main Menu"
        Me.tblWordList.ResumeLayout(False)
        Me.tblWordList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblWordList As TableLayoutPanel
    Friend WithEvents lblWordList As Label
    Friend WithEvents btnGoToSettings As Button
    Friend WithEvents btnStartGame As Button
End Class
