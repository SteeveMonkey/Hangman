<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picHangingMan = New System.Windows.Forms.PictureBox()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.flpLetters = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLetterA = New System.Windows.Forms.Button()
        Me.btnLetterB = New System.Windows.Forms.Button()
        Me.btnLetterC = New System.Windows.Forms.Button()
        Me.btnLetterD = New System.Windows.Forms.Button()
        Me.btnLetterE = New System.Windows.Forms.Button()
        Me.btnLetterF = New System.Windows.Forms.Button()
        Me.btnLetterG = New System.Windows.Forms.Button()
        Me.btnLetterH = New System.Windows.Forms.Button()
        Me.btnLetterI = New System.Windows.Forms.Button()
        Me.btnLetterJ = New System.Windows.Forms.Button()
        Me.btnLetterK = New System.Windows.Forms.Button()
        Me.btnLetterL = New System.Windows.Forms.Button()
        Me.btnLetterM = New System.Windows.Forms.Button()
        Me.btnLetterN = New System.Windows.Forms.Button()
        Me.btnLetterO = New System.Windows.Forms.Button()
        Me.btnLetterP = New System.Windows.Forms.Button()
        Me.btnLetterQ = New System.Windows.Forms.Button()
        Me.btnLetterR = New System.Windows.Forms.Button()
        Me.btnLetterS = New System.Windows.Forms.Button()
        Me.btnLetterT = New System.Windows.Forms.Button()
        Me.btnLetterU = New System.Windows.Forms.Button()
        Me.btnLetterV = New System.Windows.Forms.Button()
        Me.btnLetterW = New System.Windows.Forms.Button()
        Me.btnLetterX = New System.Windows.Forms.Button()
        Me.btnLetterY = New System.Windows.Forms.Button()
        Me.btnLetterZ = New System.Windows.Forms.Button()
        Me.lblGuessesLeft = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pnlEndGame = New System.Windows.Forms.Panel()
        Me.lblEndGameMsg = New System.Windows.Forms.Label()
        CType(Me.picHangingMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpLetters.SuspendLayout()
        Me.pnlEndGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'picHangingMan
        '
        Me.picHangingMan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picHangingMan.Image = Global.VisualBasic_Hangman.My.Resources.Resources.step6
        Me.picHangingMan.ImageLocation = ""
        Me.picHangingMan.Location = New System.Drawing.Point(0, 15)
        Me.picHangingMan.Name = "picHangingMan"
        Me.picHangingMan.Size = New System.Drawing.Size(634, 446)
        Me.picHangingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHangingMan.TabIndex = 0
        Me.picHangingMan.TabStop = False
        '
        'lblWord
        '
        Me.lblWord.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblWord.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(0, 461)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(634, 100)
        Me.lblWord.TabIndex = 1
        Me.lblWord.Text = "Word to Guess"
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpLetters
        '
        Me.flpLetters.Controls.Add(Me.btnLetterA)
        Me.flpLetters.Controls.Add(Me.btnLetterB)
        Me.flpLetters.Controls.Add(Me.btnLetterC)
        Me.flpLetters.Controls.Add(Me.btnLetterD)
        Me.flpLetters.Controls.Add(Me.btnLetterE)
        Me.flpLetters.Controls.Add(Me.btnLetterF)
        Me.flpLetters.Controls.Add(Me.btnLetterG)
        Me.flpLetters.Controls.Add(Me.btnLetterH)
        Me.flpLetters.Controls.Add(Me.btnLetterI)
        Me.flpLetters.Controls.Add(Me.btnLetterJ)
        Me.flpLetters.Controls.Add(Me.btnLetterK)
        Me.flpLetters.Controls.Add(Me.btnLetterL)
        Me.flpLetters.Controls.Add(Me.btnLetterM)
        Me.flpLetters.Controls.Add(Me.btnLetterN)
        Me.flpLetters.Controls.Add(Me.btnLetterO)
        Me.flpLetters.Controls.Add(Me.btnLetterP)
        Me.flpLetters.Controls.Add(Me.btnLetterQ)
        Me.flpLetters.Controls.Add(Me.btnLetterR)
        Me.flpLetters.Controls.Add(Me.btnLetterS)
        Me.flpLetters.Controls.Add(Me.btnLetterT)
        Me.flpLetters.Controls.Add(Me.btnLetterU)
        Me.flpLetters.Controls.Add(Me.btnLetterV)
        Me.flpLetters.Controls.Add(Me.btnLetterW)
        Me.flpLetters.Controls.Add(Me.btnLetterX)
        Me.flpLetters.Controls.Add(Me.btnLetterY)
        Me.flpLetters.Controls.Add(Me.btnLetterZ)
        Me.flpLetters.Dock = System.Windows.Forms.DockStyle.Right
        Me.flpLetters.Location = New System.Drawing.Point(634, 0)
        Me.flpLetters.Name = "flpLetters"
        Me.flpLetters.Padding = New System.Windows.Forms.Padding(6)
        Me.flpLetters.Size = New System.Drawing.Size(150, 561)
        Me.flpLetters.TabIndex = 2
        '
        'btnLetterA
        '
        Me.btnLetterA.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterA.Location = New System.Drawing.Point(9, 9)
        Me.btnLetterA.Name = "btnLetterA"
        Me.btnLetterA.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterA.TabIndex = 20
        Me.btnLetterA.Text = "A"
        Me.btnLetterA.UseVisualStyleBackColor = True
        '
        'btnLetterB
        '
        Me.btnLetterB.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterB.Location = New System.Drawing.Point(55, 9)
        Me.btnLetterB.Name = "btnLetterB"
        Me.btnLetterB.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterB.TabIndex = 21
        Me.btnLetterB.Text = "B"
        Me.btnLetterB.UseVisualStyleBackColor = True
        '
        'btnLetterC
        '
        Me.btnLetterC.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterC.Location = New System.Drawing.Point(101, 9)
        Me.btnLetterC.Name = "btnLetterC"
        Me.btnLetterC.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterC.TabIndex = 22
        Me.btnLetterC.Text = "C"
        Me.btnLetterC.UseVisualStyleBackColor = True
        '
        'btnLetterD
        '
        Me.btnLetterD.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterD.Location = New System.Drawing.Point(9, 55)
        Me.btnLetterD.Name = "btnLetterD"
        Me.btnLetterD.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterD.TabIndex = 23
        Me.btnLetterD.Text = "D"
        Me.btnLetterD.UseVisualStyleBackColor = True
        '
        'btnLetterE
        '
        Me.btnLetterE.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterE.Location = New System.Drawing.Point(55, 55)
        Me.btnLetterE.Name = "btnLetterE"
        Me.btnLetterE.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterE.TabIndex = 24
        Me.btnLetterE.Text = "E"
        Me.btnLetterE.UseVisualStyleBackColor = True
        '
        'btnLetterF
        '
        Me.btnLetterF.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterF.Location = New System.Drawing.Point(101, 55)
        Me.btnLetterF.Name = "btnLetterF"
        Me.btnLetterF.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterF.TabIndex = 25
        Me.btnLetterF.Text = "F"
        Me.btnLetterF.UseVisualStyleBackColor = True
        '
        'btnLetterG
        '
        Me.btnLetterG.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterG.Location = New System.Drawing.Point(9, 101)
        Me.btnLetterG.Name = "btnLetterG"
        Me.btnLetterG.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterG.TabIndex = 26
        Me.btnLetterG.Text = "G"
        Me.btnLetterG.UseVisualStyleBackColor = True
        '
        'btnLetterH
        '
        Me.btnLetterH.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterH.Location = New System.Drawing.Point(55, 101)
        Me.btnLetterH.Name = "btnLetterH"
        Me.btnLetterH.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterH.TabIndex = 27
        Me.btnLetterH.Text = "H"
        Me.btnLetterH.UseVisualStyleBackColor = True
        '
        'btnLetterI
        '
        Me.btnLetterI.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterI.Location = New System.Drawing.Point(101, 101)
        Me.btnLetterI.Name = "btnLetterI"
        Me.btnLetterI.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterI.TabIndex = 28
        Me.btnLetterI.Text = "I"
        Me.btnLetterI.UseVisualStyleBackColor = True
        '
        'btnLetterJ
        '
        Me.btnLetterJ.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterJ.Location = New System.Drawing.Point(9, 147)
        Me.btnLetterJ.Name = "btnLetterJ"
        Me.btnLetterJ.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterJ.TabIndex = 29
        Me.btnLetterJ.Text = "J"
        Me.btnLetterJ.UseVisualStyleBackColor = True
        '
        'btnLetterK
        '
        Me.btnLetterK.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterK.Location = New System.Drawing.Point(55, 147)
        Me.btnLetterK.Name = "btnLetterK"
        Me.btnLetterK.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterK.TabIndex = 30
        Me.btnLetterK.Text = "K"
        Me.btnLetterK.UseVisualStyleBackColor = True
        '
        'btnLetterL
        '
        Me.btnLetterL.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterL.Location = New System.Drawing.Point(101, 147)
        Me.btnLetterL.Name = "btnLetterL"
        Me.btnLetterL.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterL.TabIndex = 31
        Me.btnLetterL.Text = "L"
        Me.btnLetterL.UseVisualStyleBackColor = True
        '
        'btnLetterM
        '
        Me.btnLetterM.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterM.Location = New System.Drawing.Point(9, 193)
        Me.btnLetterM.Name = "btnLetterM"
        Me.btnLetterM.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterM.TabIndex = 32
        Me.btnLetterM.Text = "M"
        Me.btnLetterM.UseVisualStyleBackColor = True
        '
        'btnLetterN
        '
        Me.btnLetterN.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterN.Location = New System.Drawing.Point(55, 193)
        Me.btnLetterN.Name = "btnLetterN"
        Me.btnLetterN.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterN.TabIndex = 33
        Me.btnLetterN.Text = "N"
        Me.btnLetterN.UseVisualStyleBackColor = True
        '
        'btnLetterO
        '
        Me.btnLetterO.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterO.Location = New System.Drawing.Point(101, 193)
        Me.btnLetterO.Name = "btnLetterO"
        Me.btnLetterO.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterO.TabIndex = 34
        Me.btnLetterO.Text = "O"
        Me.btnLetterO.UseVisualStyleBackColor = True
        '
        'btnLetterP
        '
        Me.btnLetterP.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterP.Location = New System.Drawing.Point(9, 239)
        Me.btnLetterP.Name = "btnLetterP"
        Me.btnLetterP.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterP.TabIndex = 35
        Me.btnLetterP.Text = "P"
        Me.btnLetterP.UseVisualStyleBackColor = True
        '
        'btnLetterQ
        '
        Me.btnLetterQ.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterQ.Location = New System.Drawing.Point(55, 239)
        Me.btnLetterQ.Name = "btnLetterQ"
        Me.btnLetterQ.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterQ.TabIndex = 36
        Me.btnLetterQ.Text = "Q"
        Me.btnLetterQ.UseVisualStyleBackColor = True
        '
        'btnLetterR
        '
        Me.btnLetterR.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterR.Location = New System.Drawing.Point(101, 239)
        Me.btnLetterR.Name = "btnLetterR"
        Me.btnLetterR.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterR.TabIndex = 37
        Me.btnLetterR.Text = "R"
        Me.btnLetterR.UseVisualStyleBackColor = True
        '
        'btnLetterS
        '
        Me.btnLetterS.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterS.Location = New System.Drawing.Point(9, 285)
        Me.btnLetterS.Name = "btnLetterS"
        Me.btnLetterS.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterS.TabIndex = 38
        Me.btnLetterS.Text = "S"
        Me.btnLetterS.UseVisualStyleBackColor = True
        '
        'btnLetterT
        '
        Me.btnLetterT.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterT.Location = New System.Drawing.Point(55, 285)
        Me.btnLetterT.Name = "btnLetterT"
        Me.btnLetterT.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterT.TabIndex = 39
        Me.btnLetterT.Text = "T"
        Me.btnLetterT.UseVisualStyleBackColor = True
        '
        'btnLetterU
        '
        Me.btnLetterU.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterU.Location = New System.Drawing.Point(101, 285)
        Me.btnLetterU.Name = "btnLetterU"
        Me.btnLetterU.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterU.TabIndex = 40
        Me.btnLetterU.Text = "U"
        Me.btnLetterU.UseVisualStyleBackColor = True
        '
        'btnLetterV
        '
        Me.btnLetterV.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterV.Location = New System.Drawing.Point(9, 331)
        Me.btnLetterV.Name = "btnLetterV"
        Me.btnLetterV.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterV.TabIndex = 41
        Me.btnLetterV.Text = "V"
        Me.btnLetterV.UseVisualStyleBackColor = True
        '
        'btnLetterW
        '
        Me.btnLetterW.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterW.Location = New System.Drawing.Point(55, 331)
        Me.btnLetterW.Name = "btnLetterW"
        Me.btnLetterW.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterW.TabIndex = 42
        Me.btnLetterW.Text = "W"
        Me.btnLetterW.UseVisualStyleBackColor = True
        '
        'btnLetterX
        '
        Me.btnLetterX.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterX.Location = New System.Drawing.Point(101, 331)
        Me.btnLetterX.Name = "btnLetterX"
        Me.btnLetterX.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterX.TabIndex = 43
        Me.btnLetterX.Text = "X"
        Me.btnLetterX.UseVisualStyleBackColor = True
        '
        'btnLetterY
        '
        Me.btnLetterY.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterY.Location = New System.Drawing.Point(9, 377)
        Me.btnLetterY.Name = "btnLetterY"
        Me.btnLetterY.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterY.TabIndex = 44
        Me.btnLetterY.Text = "Y"
        Me.btnLetterY.UseVisualStyleBackColor = True
        '
        'btnLetterZ
        '
        Me.btnLetterZ.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetterZ.Location = New System.Drawing.Point(55, 377)
        Me.btnLetterZ.Name = "btnLetterZ"
        Me.btnLetterZ.Size = New System.Drawing.Size(40, 40)
        Me.btnLetterZ.TabIndex = 45
        Me.btnLetterZ.Text = "Z"
        Me.btnLetterZ.UseVisualStyleBackColor = True
        '
        'lblGuessesLeft
        '
        Me.lblGuessesLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGuessesLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessesLeft.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblGuessesLeft.Location = New System.Drawing.Point(546, 24)
        Me.lblGuessesLeft.Name = "lblGuessesLeft"
        Me.lblGuessesLeft.Size = New System.Drawing.Size(78, 25)
        Me.lblGuessesLeft.TabIndex = 3
        Me.lblGuessesLeft.Text = "## / ##"
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(3, 34)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(140, 40)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play Again"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblScore.Location = New System.Drawing.Point(0, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(634, 15)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Wins: 0          Losses: 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEndGame
        '
        Me.pnlEndGame.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlEndGame.AutoSize = True
        Me.pnlEndGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlEndGame.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlEndGame.Controls.Add(Me.lblEndGameMsg)
        Me.pnlEndGame.Controls.Add(Me.btnPlay)
        Me.pnlEndGame.Location = New System.Drawing.Point(319, 242)
        Me.pnlEndGame.MinimumSize = New System.Drawing.Size(146, 0)
        Me.pnlEndGame.Name = "pnlEndGame"
        Me.pnlEndGame.Size = New System.Drawing.Size(146, 77)
        Me.pnlEndGame.TabIndex = 6
        '
        'lblEndGameMsg
        '
        Me.lblEndGameMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndGameMsg.Location = New System.Drawing.Point(3, 0)
        Me.lblEndGameMsg.Name = "lblEndGameMsg"
        Me.lblEndGameMsg.Size = New System.Drawing.Size(140, 31)
        Me.lblEndGameMsg.TabIndex = 5
        Me.lblEndGameMsg.Text = "lblEndGameMsg"
        Me.lblEndGameMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.pnlEndGame)
        Me.Controls.Add(Me.lblGuessesLeft)
        Me.Controls.Add(Me.picHangingMan)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.flpLetters)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "formGame"
        Me.Text = "Hangman"
        CType(Me.picHangingMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpLetters.ResumeLayout(False)
        Me.pnlEndGame.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picHangingMan As PictureBox
    Friend WithEvents lblWord As Label
    Friend WithEvents flpLetters As FlowLayoutPanel
    Friend WithEvents btnLetterA As Button
    Friend WithEvents btnLetterB As Button
    Friend WithEvents btnLetterC As Button
    Friend WithEvents btnLetterD As Button
    Friend WithEvents btnLetterE As Button
    Friend WithEvents btnLetterF As Button
    Friend WithEvents btnLetterG As Button
    Friend WithEvents btnLetterH As Button
    Friend WithEvents btnLetterI As Button
    Friend WithEvents btnLetterJ As Button
    Friend WithEvents btnLetterK As Button
    Friend WithEvents btnLetterL As Button
    Friend WithEvents btnLetterM As Button
    Friend WithEvents btnLetterN As Button
    Friend WithEvents btnLetterO As Button
    Friend WithEvents btnLetterP As Button
    Friend WithEvents btnLetterQ As Button
    Friend WithEvents btnLetterR As Button
    Friend WithEvents btnLetterS As Button
    Friend WithEvents btnLetterT As Button
    Friend WithEvents btnLetterU As Button
    Friend WithEvents btnLetterV As Button
    Friend WithEvents btnLetterW As Button
    Friend WithEvents btnLetterX As Button
    Friend WithEvents btnLetterY As Button
    Friend WithEvents btnLetterZ As Button
    Friend WithEvents lblGuessesLeft As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents pnlEndGame As Panel
    Friend WithEvents lblEndGameMsg As Label
End Class
