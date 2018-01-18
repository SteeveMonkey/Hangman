<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSettings
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
        Me.lstWordLists = New System.Windows.Forms.ListBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.pnlMaxMistakes = New System.Windows.Forms.Panel()
        Me.rbnMax14 = New System.Windows.Forms.RadioButton()
        Me.rbnMax12 = New System.Windows.Forms.RadioButton()
        Me.rbnMax10 = New System.Windows.Forms.RadioButton()
        Me.rbnMax8 = New System.Windows.Forms.RadioButton()
        Me.rbnMax6 = New System.Windows.Forms.RadioButton()
        Me.rbnMax3 = New System.Windows.Forms.RadioButton()
        Me.lblMaxMistakes = New System.Windows.Forms.Label()
        Me.pnlWordLimit = New System.Windows.Forms.Panel()
        Me.lblWordSize = New System.Windows.Forms.Label()
        Me.lblWordsUsable = New System.Windows.Forms.Label()
        Me.nudWordSizeMax = New System.Windows.Forms.NumericUpDown()
        Me.lblWordSizeMax = New System.Windows.Forms.Label()
        Me.nudWordSizeMin = New System.Windows.Forms.NumericUpDown()
        Me.lblWordSizeMin = New System.Windows.Forms.Label()
        Me.lblWordsInFile = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtWordListPreview = New System.Windows.Forms.TextBox()
        Me.btnCreateWordList = New System.Windows.Forms.Button()
        Me.pnlWordList = New System.Windows.Forms.Panel()
        Me.tblWordListsButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCopyWordList = New System.Windows.Forms.Button()
        Me.btnDeleteWordList = New System.Windows.Forms.Button()
        Me.btnEditWordList = New System.Windows.Forms.Button()
        Me.lblWordListsButtons = New System.Windows.Forms.Label()
        Me.SplWordLists = New System.Windows.Forms.Splitter()
        Me.btnRestoreDefaultSettings = New System.Windows.Forms.Button()
        Me.pnlButtons.SuspendLayout()
        Me.pnlMaxMistakes.SuspendLayout()
        Me.pnlWordLimit.SuspendLayout()
        CType(Me.nudWordSizeMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWordSizeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWordList.SuspendLayout()
        Me.tblWordListsButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWordLists
        '
        Me.lstWordLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstWordLists.FormattingEnabled = True
        Me.lstWordLists.Location = New System.Drawing.Point(0, 0)
        Me.lstWordLists.MinimumSize = New System.Drawing.Size(100, 4)
        Me.lstWordLists.Name = "lstWordLists"
        Me.lstWordLists.Size = New System.Drawing.Size(150, 370)
        Me.lstWordLists.TabIndex = 0
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnRestoreDefaultSettings)
        Me.pnlButtons.Controls.Add(Me.pnlMaxMistakes)
        Me.pnlButtons.Controls.Add(Me.pnlWordLimit)
        Me.pnlButtons.Controls.Add(Me.lblWordsInFile)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnConfirm)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlButtons.Location = New System.Drawing.Point(484, 0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(140, 441)
        Me.pnlButtons.TabIndex = 1
        '
        'pnlMaxMistakes
        '
        Me.pnlMaxMistakes.AutoSize = True
        Me.pnlMaxMistakes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlMaxMistakes.Controls.Add(Me.rbnMax14)
        Me.pnlMaxMistakes.Controls.Add(Me.rbnMax12)
        Me.pnlMaxMistakes.Controls.Add(Me.rbnMax10)
        Me.pnlMaxMistakes.Controls.Add(Me.rbnMax8)
        Me.pnlMaxMistakes.Controls.Add(Me.rbnMax6)
        Me.pnlMaxMistakes.Controls.Add(Me.rbnMax3)
        Me.pnlMaxMistakes.Controls.Add(Me.lblMaxMistakes)
        Me.pnlMaxMistakes.Location = New System.Drawing.Point(0, 140)
        Me.pnlMaxMistakes.Name = "pnlMaxMistakes"
        Me.pnlMaxMistakes.Size = New System.Drawing.Size(122, 62)
        Me.pnlMaxMistakes.TabIndex = 10
        '
        'rbnMax14
        '
        Me.rbnMax14.AutoSize = True
        Me.rbnMax14.Location = New System.Drawing.Point(82, 42)
        Me.rbnMax14.Name = "rbnMax14"
        Me.rbnMax14.Size = New System.Drawing.Size(37, 17)
        Me.rbnMax14.TabIndex = 15
        Me.rbnMax14.TabStop = True
        Me.rbnMax14.Text = "14"
        Me.rbnMax14.UseVisualStyleBackColor = True
        '
        'rbnMax12
        '
        Me.rbnMax12.AutoSize = True
        Me.rbnMax12.Location = New System.Drawing.Point(44, 42)
        Me.rbnMax12.Name = "rbnMax12"
        Me.rbnMax12.Size = New System.Drawing.Size(37, 17)
        Me.rbnMax12.TabIndex = 14
        Me.rbnMax12.TabStop = True
        Me.rbnMax12.Text = "12"
        Me.rbnMax12.UseVisualStyleBackColor = True
        '
        'rbnMax10
        '
        Me.rbnMax10.AutoSize = True
        Me.rbnMax10.Location = New System.Drawing.Point(6, 42)
        Me.rbnMax10.Name = "rbnMax10"
        Me.rbnMax10.Size = New System.Drawing.Size(37, 17)
        Me.rbnMax10.TabIndex = 13
        Me.rbnMax10.TabStop = True
        Me.rbnMax10.Text = "10"
        Me.rbnMax10.UseVisualStyleBackColor = True
        '
        'rbnMax8
        '
        Me.rbnMax8.AutoSize = True
        Me.rbnMax8.Location = New System.Drawing.Point(82, 19)
        Me.rbnMax8.Name = "rbnMax8"
        Me.rbnMax8.Size = New System.Drawing.Size(31, 17)
        Me.rbnMax8.TabIndex = 12
        Me.rbnMax8.TabStop = True
        Me.rbnMax8.Text = "8"
        Me.rbnMax8.UseVisualStyleBackColor = True
        '
        'rbnMax6
        '
        Me.rbnMax6.AutoSize = True
        Me.rbnMax6.Location = New System.Drawing.Point(44, 19)
        Me.rbnMax6.Name = "rbnMax6"
        Me.rbnMax6.Size = New System.Drawing.Size(31, 17)
        Me.rbnMax6.TabIndex = 11
        Me.rbnMax6.TabStop = True
        Me.rbnMax6.Text = "6"
        Me.rbnMax6.UseVisualStyleBackColor = True
        '
        'rbnMax3
        '
        Me.rbnMax3.AutoSize = True
        Me.rbnMax3.Location = New System.Drawing.Point(6, 19)
        Me.rbnMax3.Name = "rbnMax3"
        Me.rbnMax3.Size = New System.Drawing.Size(31, 17)
        Me.rbnMax3.TabIndex = 10
        Me.rbnMax3.TabStop = True
        Me.rbnMax3.Text = "3"
        Me.rbnMax3.UseVisualStyleBackColor = True
        '
        'lblMaxMistakes
        '
        Me.lblMaxMistakes.AutoSize = True
        Me.lblMaxMistakes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxMistakes.Location = New System.Drawing.Point(8, 0)
        Me.lblMaxMistakes.Name = "lblMaxMistakes"
        Me.lblMaxMistakes.Size = New System.Drawing.Size(90, 16)
        Me.lblMaxMistakes.TabIndex = 9
        Me.lblMaxMistakes.Text = "Max Mistakes"
        '
        'pnlWordLimit
        '
        Me.pnlWordLimit.AutoSize = True
        Me.pnlWordLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlWordLimit.Controls.Add(Me.lblWordSize)
        Me.pnlWordLimit.Controls.Add(Me.lblWordsUsable)
        Me.pnlWordLimit.Controls.Add(Me.nudWordSizeMax)
        Me.pnlWordLimit.Controls.Add(Me.lblWordSizeMax)
        Me.pnlWordLimit.Controls.Add(Me.nudWordSizeMin)
        Me.pnlWordLimit.Controls.Add(Me.lblWordSizeMin)
        Me.pnlWordLimit.Location = New System.Drawing.Point(0, 32)
        Me.pnlWordLimit.Name = "pnlWordLimit"
        Me.pnlWordLimit.Size = New System.Drawing.Size(99, 81)
        Me.pnlWordLimit.TabIndex = 9
        '
        'lblWordSize
        '
        Me.lblWordSize.AutoSize = True
        Me.lblWordSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordSize.Location = New System.Drawing.Point(8, 0)
        Me.lblWordSize.Name = "lblWordSize"
        Me.lblWordSize.Size = New System.Drawing.Size(70, 16)
        Me.lblWordSize.TabIndex = 8
        Me.lblWordSize.Text = "Word Size"
        '
        'lblWordsUsable
        '
        Me.lblWordsUsable.AutoSize = True
        Me.lblWordsUsable.Location = New System.Drawing.Point(3, 68)
        Me.lblWordsUsable.Name = "lblWordsUsable"
        Me.lblWordsUsable.Size = New System.Drawing.Size(80, 13)
        Me.lblWordsUsable.TabIndex = 3
        Me.lblWordsUsable.Text = "Usable Words: "
        '
        'nudWordSizeMax
        '
        Me.nudWordSizeMax.Location = New System.Drawing.Point(36, 45)
        Me.nudWordSizeMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWordSizeMax.Name = "nudWordSizeMax"
        Me.nudWordSizeMax.Size = New System.Drawing.Size(60, 20)
        Me.nudWordSizeMax.TabIndex = 5
        Me.nudWordSizeMax.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblWordSizeMax
        '
        Me.lblWordSizeMax.AutoSize = True
        Me.lblWordSizeMax.Location = New System.Drawing.Point(3, 45)
        Me.lblWordSizeMax.Name = "lblWordSizeMax"
        Me.lblWordSizeMax.Size = New System.Drawing.Size(27, 13)
        Me.lblWordSizeMax.TabIndex = 7
        Me.lblWordSizeMax.Text = "Max"
        '
        'nudWordSizeMin
        '
        Me.nudWordSizeMin.Location = New System.Drawing.Point(36, 19)
        Me.nudWordSizeMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWordSizeMin.Name = "nudWordSizeMin"
        Me.nudWordSizeMin.Size = New System.Drawing.Size(60, 20)
        Me.nudWordSizeMin.TabIndex = 4
        Me.nudWordSizeMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblWordSizeMin
        '
        Me.lblWordSizeMin.AutoSize = True
        Me.lblWordSizeMin.Location = New System.Drawing.Point(3, 21)
        Me.lblWordSizeMin.Name = "lblWordSizeMin"
        Me.lblWordSizeMin.Size = New System.Drawing.Size(24, 13)
        Me.lblWordSizeMin.TabIndex = 6
        Me.lblWordSizeMin.Text = "Min"
        '
        'lblWordsInFile
        '
        Me.lblWordsInFile.AutoSize = True
        Me.lblWordsInFile.Location = New System.Drawing.Point(6, 9)
        Me.lblWordsInFile.Name = "lblWordsInFile"
        Me.lblWordsInFile.Size = New System.Drawing.Size(74, 13)
        Me.lblWordsInFile.TabIndex = 2
        Me.lblWordsInFile.Text = "Words in File: "
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(30, 408)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.Location = New System.Drawing.Point(30, 380)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 23)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "Save Changes"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtWordListPreview
        '
        Me.txtWordListPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWordListPreview.Location = New System.Drawing.Point(152, 0)
        Me.txtWordListPreview.Multiline = True
        Me.txtWordListPreview.Name = "txtWordListPreview"
        Me.txtWordListPreview.ReadOnly = True
        Me.txtWordListPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWordListPreview.Size = New System.Drawing.Size(332, 441)
        Me.txtWordListPreview.TabIndex = 2
        '
        'btnCreateWordList
        '
        Me.btnCreateWordList.AutoSize = True
        Me.btnCreateWordList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreateWordList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateWordList.Location = New System.Drawing.Point(3, 16)
        Me.btnCreateWordList.Name = "btnCreateWordList"
        Me.btnCreateWordList.Size = New System.Drawing.Size(69, 23)
        Me.btnCreateWordList.TabIndex = 3
        Me.btnCreateWordList.Text = "Create"
        Me.btnCreateWordList.UseVisualStyleBackColor = True
        '
        'pnlWordList
        '
        Me.pnlWordList.Controls.Add(Me.lstWordLists)
        Me.pnlWordList.Controls.Add(Me.tblWordListsButtons)
        Me.pnlWordList.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlWordList.Location = New System.Drawing.Point(0, 0)
        Me.pnlWordList.Name = "pnlWordList"
        Me.pnlWordList.Size = New System.Drawing.Size(150, 441)
        Me.pnlWordList.TabIndex = 4
        '
        'tblWordListsButtons
        '
        Me.tblWordListsButtons.AutoSize = True
        Me.tblWordListsButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblWordListsButtons.ColumnCount = 2
        Me.tblWordListsButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblWordListsButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblWordListsButtons.Controls.Add(Me.btnCopyWordList, 1, 1)
        Me.tblWordListsButtons.Controls.Add(Me.btnCreateWordList, 0, 1)
        Me.tblWordListsButtons.Controls.Add(Me.btnDeleteWordList, 1, 2)
        Me.tblWordListsButtons.Controls.Add(Me.btnEditWordList, 0, 2)
        Me.tblWordListsButtons.Controls.Add(Me.lblWordListsButtons, 0, 0)
        Me.tblWordListsButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblWordListsButtons.Location = New System.Drawing.Point(0, 370)
        Me.tblWordListsButtons.MinimumSize = New System.Drawing.Size(140, 0)
        Me.tblWordListsButtons.Name = "tblWordListsButtons"
        Me.tblWordListsButtons.RowCount = 3
        Me.tblWordListsButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblWordListsButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblWordListsButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblWordListsButtons.Size = New System.Drawing.Size(150, 71)
        Me.tblWordListsButtons.TabIndex = 6
        '
        'btnCopyWordList
        '
        Me.btnCopyWordList.AutoSize = True
        Me.btnCopyWordList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCopyWordList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopyWordList.Location = New System.Drawing.Point(78, 16)
        Me.btnCopyWordList.Name = "btnCopyWordList"
        Me.btnCopyWordList.Size = New System.Drawing.Size(69, 23)
        Me.btnCopyWordList.TabIndex = 7
        Me.btnCopyWordList.Text = "Copy"
        Me.btnCopyWordList.UseVisualStyleBackColor = True
        '
        'btnDeleteWordList
        '
        Me.btnDeleteWordList.AutoSize = True
        Me.btnDeleteWordList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteWordList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeleteWordList.Location = New System.Drawing.Point(78, 45)
        Me.btnDeleteWordList.Name = "btnDeleteWordList"
        Me.btnDeleteWordList.Size = New System.Drawing.Size(69, 23)
        Me.btnDeleteWordList.TabIndex = 4
        Me.btnDeleteWordList.Text = "Delete"
        Me.btnDeleteWordList.UseVisualStyleBackColor = True
        '
        'btnEditWordList
        '
        Me.btnEditWordList.AutoSize = True
        Me.btnEditWordList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditWordList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEditWordList.Location = New System.Drawing.Point(3, 45)
        Me.btnEditWordList.Name = "btnEditWordList"
        Me.btnEditWordList.Size = New System.Drawing.Size(69, 23)
        Me.btnEditWordList.TabIndex = 5
        Me.btnEditWordList.Text = "Edit List"
        Me.btnEditWordList.UseVisualStyleBackColor = True
        '
        'lblWordListsButtons
        '
        Me.lblWordListsButtons.AutoSize = True
        Me.tblWordListsButtons.SetColumnSpan(Me.lblWordListsButtons, 2)
        Me.lblWordListsButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWordListsButtons.Location = New System.Drawing.Point(3, 0)
        Me.lblWordListsButtons.Name = "lblWordListsButtons"
        Me.lblWordListsButtons.Size = New System.Drawing.Size(144, 13)
        Me.lblWordListsButtons.TabIndex = 6
        Me.lblWordListsButtons.Text = "Word List Management"
        Me.lblWordListsButtons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplWordLists
        '
        Me.SplWordLists.Location = New System.Drawing.Point(150, 0)
        Me.SplWordLists.MinExtra = 100
        Me.SplWordLists.MinSize = 140
        Me.SplWordLists.Name = "SplWordLists"
        Me.SplWordLists.Size = New System.Drawing.Size(2, 441)
        Me.SplWordLists.TabIndex = 5
        Me.SplWordLists.TabStop = False
        '
        'btnRestoreDefaultSettings
        '
        Me.btnRestoreDefaultSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRestoreDefaultSettings.Location = New System.Drawing.Point(6, 240)
        Me.btnRestoreDefaultSettings.Name = "btnRestoreDefaultSettings"
        Me.btnRestoreDefaultSettings.Size = New System.Drawing.Size(100, 23)
        Me.btnRestoreDefaultSettings.TabIndex = 11
        Me.btnRestoreDefaultSettings.Text = "Restore Defaults"
        Me.btnRestoreDefaultSettings.UseVisualStyleBackColor = True
        '
        'formSettings
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.txtWordListPreview)
        Me.Controls.Add(Me.SplWordLists)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlWordList)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "formSettings"
        Me.Text = "Hangman - Settings"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.pnlMaxMistakes.ResumeLayout(False)
        Me.pnlMaxMistakes.PerformLayout()
        Me.pnlWordLimit.ResumeLayout(False)
        Me.pnlWordLimit.PerformLayout()
        CType(Me.nudWordSizeMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWordSizeMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWordList.ResumeLayout(False)
        Me.pnlWordList.PerformLayout()
        Me.tblWordListsButtons.ResumeLayout(False)
        Me.tblWordListsButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstWordLists As ListBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtWordListPreview As TextBox
    Friend WithEvents btnCreateWordList As Button
    Friend WithEvents pnlWordList As Panel
    Friend WithEvents pnlWordLimit As Panel
    Friend WithEvents lblWordSize As Label
    Friend WithEvents nudWordSizeMax As NumericUpDown
    Friend WithEvents lblWordSizeMax As Label
    Friend WithEvents nudWordSizeMin As NumericUpDown
    Friend WithEvents lblWordSizeMin As Label
    Friend WithEvents lblWordsUsable As Label
    Friend WithEvents lblWordsInFile As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEditWordList As Button
    Friend WithEvents btnDeleteWordList As Button
    Friend WithEvents SplWordLists As Splitter
    Friend WithEvents tblWordListsButtons As TableLayoutPanel
    Friend WithEvents btnCopyWordList As Button
    Friend WithEvents lblWordListsButtons As Label
    Friend WithEvents pnlMaxMistakes As Panel
    Friend WithEvents rbnMax14 As RadioButton
    Friend WithEvents rbnMax12 As RadioButton
    Friend WithEvents rbnMax10 As RadioButton
    Friend WithEvents rbnMax8 As RadioButton
    Friend WithEvents rbnMax6 As RadioButton
    Friend WithEvents rbnMax3 As RadioButton
    Friend WithEvents lblMaxMistakes As Label
    Friend WithEvents btnRestoreDefaultSettings As Button
End Class
