<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Display
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
        Me.components = New System.ComponentModel.Container()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.HomeTeam = New System.Windows.Forms.TextBox()
        Me.AwayTeam = New System.Windows.Forms.TextBox()
        Me.HomeScore = New System.Windows.Forms.Label()
        Me.AwayBonusScore = New System.Windows.Forms.Label()
        Me.HomeBonusScore = New System.Windows.Forms.Label()
        Me.AwayScore = New System.Windows.Forms.Label()
        Me.AwayPlayers = New System.Windows.Forms.TextBox()
        Me.HomePlayers = New System.Windows.Forms.TextBox()
        Me.RoundOne = New System.Windows.Forms.Label()
        Me.RoundThree = New System.Windows.Forms.Label()
        Me.RoundTwo = New System.Windows.Forms.Label()
        Me.HomeRoundOneScore = New System.Windows.Forms.Label()
        Me.HomeRoundThreeScore = New System.Windows.Forms.Label()
        Me.HomeRoundTwoScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentRound = New System.Windows.Forms.TextBox()
        Me.Round1 = New System.Windows.Forms.Label()
        Me.Round2 = New System.Windows.Forms.Label()
        Me.Round3 = New System.Windows.Forms.Label()
        Me.AwayRoundOneScore = New System.Windows.Forms.Label()
        Me.AwayRoundThreeScore = New System.Windows.Forms.Label()
        Me.AwayRoundTwoScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(249, 16)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(286, 91)
        Me.TimerLabel.TabIndex = 12
        Me.TimerLabel.Text = "10 : 00"
        '
        'Timer
        '
        Me.Timer.Interval = 800
        '
        'HomeTeam
        '
        Me.HomeTeam.Location = New System.Drawing.Point(79, 74)
        Me.HomeTeam.Name = "HomeTeam"
        Me.HomeTeam.Size = New System.Drawing.Size(100, 22)
        Me.HomeTeam.TabIndex = 13
        Me.HomeTeam.Text = "Team Name"
        '
        'AwayTeam
        '
        Me.AwayTeam.Location = New System.Drawing.Point(606, 74)
        Me.AwayTeam.Name = "AwayTeam"
        Me.AwayTeam.Size = New System.Drawing.Size(100, 22)
        Me.AwayTeam.TabIndex = 14
        Me.AwayTeam.Text = "Team Name"
        '
        'HomeScore
        '
        Me.HomeScore.AutoSize = True
        Me.HomeScore.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeScore.Location = New System.Drawing.Point(202, 185)
        Me.HomeScore.Name = "HomeScore"
        Me.HomeScore.Size = New System.Drawing.Size(68, 78)
        Me.HomeScore.TabIndex = 15
        Me.HomeScore.Text = "0"
        '
        'AwayBonusScore
        '
        Me.AwayBonusScore.AutoSize = True
        Me.AwayBonusScore.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayBonusScore.Location = New System.Drawing.Point(515, 185)
        Me.AwayBonusScore.Name = "AwayBonusScore"
        Me.AwayBonusScore.Size = New System.Drawing.Size(68, 78)
        Me.AwayBonusScore.TabIndex = 16
        Me.AwayBonusScore.Text = "0"
        '
        'HomeBonusScore
        '
        Me.HomeBonusScore.AutoSize = True
        Me.HomeBonusScore.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBonusScore.Location = New System.Drawing.Point(300, 185)
        Me.HomeBonusScore.Name = "HomeBonusScore"
        Me.HomeBonusScore.Size = New System.Drawing.Size(68, 78)
        Me.HomeBonusScore.TabIndex = 17
        Me.HomeBonusScore.Text = "0"
        '
        'AwayScore
        '
        Me.AwayScore.AutoSize = True
        Me.AwayScore.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayScore.Location = New System.Drawing.Point(422, 185)
        Me.AwayScore.Name = "AwayScore"
        Me.AwayScore.Size = New System.Drawing.Size(68, 78)
        Me.AwayScore.TabIndex = 18
        Me.AwayScore.Text = "0"
        '
        'AwayPlayers
        '
        Me.AwayPlayers.Location = New System.Drawing.Point(606, 119)
        Me.AwayPlayers.Multiline = True
        Me.AwayPlayers.Name = "AwayPlayers"
        Me.AwayPlayers.Size = New System.Drawing.Size(100, 134)
        Me.AwayPlayers.TabIndex = 19
        Me.AwayPlayers.Text = "Away Players"
        '
        'HomePlayers
        '
        Me.HomePlayers.Location = New System.Drawing.Point(79, 119)
        Me.HomePlayers.Multiline = True
        Me.HomePlayers.Name = "HomePlayers"
        Me.HomePlayers.Size = New System.Drawing.Size(100, 134)
        Me.HomePlayers.TabIndex = 20
        Me.HomePlayers.Text = "Home Players"
        '
        'RoundOne
        '
        Me.RoundOne.AutoSize = True
        Me.RoundOne.Location = New System.Drawing.Point(66, 315)
        Me.RoundOne.Name = "RoundOne"
        Me.RoundOne.Size = New System.Drawing.Size(62, 17)
        Me.RoundOne.TabIndex = 21
        Me.RoundOne.Text = "Round 1"
        '
        'RoundThree
        '
        Me.RoundThree.AutoSize = True
        Me.RoundThree.Location = New System.Drawing.Point(208, 315)
        Me.RoundThree.Name = "RoundThree"
        Me.RoundThree.Size = New System.Drawing.Size(62, 17)
        Me.RoundThree.TabIndex = 22
        Me.RoundThree.Text = "Round 3"
        '
        'RoundTwo
        '
        Me.RoundTwo.AutoSize = True
        Me.RoundTwo.Location = New System.Drawing.Point(134, 315)
        Me.RoundTwo.Name = "RoundTwo"
        Me.RoundTwo.Size = New System.Drawing.Size(62, 17)
        Me.RoundTwo.TabIndex = 23
        Me.RoundTwo.Text = "Round 2"
        '
        'HomeRoundOneScore
        '
        Me.HomeRoundOneScore.AutoSize = True
        Me.HomeRoundOneScore.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeRoundOneScore.Location = New System.Drawing.Point(76, 332)
        Me.HomeRoundOneScore.Name = "HomeRoundOneScore"
        Me.HomeRoundOneScore.Size = New System.Drawing.Size(42, 31)
        Me.HomeRoundOneScore.TabIndex = 24
        Me.HomeRoundOneScore.Text = "00"
        '
        'HomeRoundThreeScore
        '
        Me.HomeRoundThreeScore.AutoSize = True
        Me.HomeRoundThreeScore.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeRoundThreeScore.Location = New System.Drawing.Point(215, 332)
        Me.HomeRoundThreeScore.Name = "HomeRoundThreeScore"
        Me.HomeRoundThreeScore.Size = New System.Drawing.Size(42, 31)
        Me.HomeRoundThreeScore.TabIndex = 25
        Me.HomeRoundThreeScore.Text = "00"
        '
        'HomeRoundTwoScore
        '
        Me.HomeRoundTwoScore.AutoSize = True
        Me.HomeRoundTwoScore.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeRoundTwoScore.Location = New System.Drawing.Point(147, 332)
        Me.HomeRoundTwoScore.Name = "HomeRoundTwoScore"
        Me.HomeRoundTwoScore.Size = New System.Drawing.Size(42, 31)
        Me.HomeRoundTwoScore.TabIndex = 26
        Me.HomeRoundTwoScore.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Round No"
        '
        'CurrentRound
        '
        Me.CurrentRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentRound.Location = New System.Drawing.Point(372, 127)
        Me.CurrentRound.Name = "CurrentRound"
        Me.CurrentRound.Size = New System.Drawing.Size(39, 56)
        Me.CurrentRound.TabIndex = 28
        Me.CurrentRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Round1
        '
        Me.Round1.AutoSize = True
        Me.Round1.Location = New System.Drawing.Point(509, 315)
        Me.Round1.Name = "Round1"
        Me.Round1.Size = New System.Drawing.Size(62, 17)
        Me.Round1.TabIndex = 29
        Me.Round1.Text = "Round 1"
        '
        'Round2
        '
        Me.Round2.AutoSize = True
        Me.Round2.Location = New System.Drawing.Point(590, 315)
        Me.Round2.Name = "Round2"
        Me.Round2.Size = New System.Drawing.Size(62, 17)
        Me.Round2.TabIndex = 30
        Me.Round2.Text = "Round 2"
        '
        'Round3
        '
        Me.Round3.AutoSize = True
        Me.Round3.Location = New System.Drawing.Point(662, 315)
        Me.Round3.Name = "Round3"
        Me.Round3.Size = New System.Drawing.Size(62, 17)
        Me.Round3.TabIndex = 31
        Me.Round3.Text = "Round 3"
        '
        'AwayRoundOneScore
        '
        Me.AwayRoundOneScore.AutoSize = True
        Me.AwayRoundOneScore.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayRoundOneScore.Location = New System.Drawing.Point(518, 332)
        Me.AwayRoundOneScore.Name = "AwayRoundOneScore"
        Me.AwayRoundOneScore.Size = New System.Drawing.Size(42, 31)
        Me.AwayRoundOneScore.TabIndex = 32
        Me.AwayRoundOneScore.Text = "00"
        '
        'AwayRoundThreeScore
        '
        Me.AwayRoundThreeScore.AutoSize = True
        Me.AwayRoundThreeScore.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayRoundThreeScore.Location = New System.Drawing.Point(672, 332)
        Me.AwayRoundThreeScore.Name = "AwayRoundThreeScore"
        Me.AwayRoundThreeScore.Size = New System.Drawing.Size(42, 31)
        Me.AwayRoundThreeScore.TabIndex = 33
        Me.AwayRoundThreeScore.Text = "00"
        '
        'AwayRoundTwoScore
        '
        Me.AwayRoundTwoScore.AutoSize = True
        Me.AwayRoundTwoScore.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayRoundTwoScore.Location = New System.Drawing.Point(599, 332)
        Me.AwayRoundTwoScore.Name = "AwayRoundTwoScore"
        Me.AwayRoundTwoScore.Size = New System.Drawing.Size(42, 31)
        Me.AwayRoundTwoScore.TabIndex = 34
        Me.AwayRoundTwoScore.Text = "00"
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 381)
        Me.Controls.Add(Me.AwayRoundTwoScore)
        Me.Controls.Add(Me.AwayRoundThreeScore)
        Me.Controls.Add(Me.AwayRoundOneScore)
        Me.Controls.Add(Me.Round3)
        Me.Controls.Add(Me.Round2)
        Me.Controls.Add(Me.Round1)
        Me.Controls.Add(Me.CurrentRound)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HomeRoundTwoScore)
        Me.Controls.Add(Me.HomeRoundThreeScore)
        Me.Controls.Add(Me.HomeRoundOneScore)
        Me.Controls.Add(Me.RoundTwo)
        Me.Controls.Add(Me.RoundThree)
        Me.Controls.Add(Me.RoundOne)
        Me.Controls.Add(Me.HomePlayers)
        Me.Controls.Add(Me.AwayPlayers)
        Me.Controls.Add(Me.AwayScore)
        Me.Controls.Add(Me.HomeBonusScore)
        Me.Controls.Add(Me.AwayBonusScore)
        Me.Controls.Add(Me.HomeScore)
        Me.Controls.Add(Me.AwayTeam)
        Me.Controls.Add(Me.HomeTeam)
        Me.Controls.Add(Me.TimerLabel)
        Me.Name = "Display"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents TimerLabel As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents HomeTeam As TextBox
    Friend WithEvents AwayTeam As TextBox
    Friend WithEvents HomeScore As Label
    Friend WithEvents AwayBonusScore As Label
    Friend WithEvents HomeBonusScore As Label
    Friend WithEvents AwayScore As Label
    Friend WithEvents AwayPlayers As TextBox
    Friend WithEvents HomePlayers As TextBox
    Friend WithEvents RoundOne As Label
    Friend WithEvents RoundThree As Label
    Friend WithEvents RoundTwo As Label
    Friend WithEvents HomeRoundOneScore As Label
    Friend WithEvents HomeRoundThreeScore As Label
    Friend WithEvents HomeRoundTwoScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CurrentRound As TextBox
    Friend WithEvents Round1 As Label
    Friend WithEvents Round2 As Label
    Friend WithEvents Round3 As Label
    Friend WithEvents AwayRoundOneScore As Label
    Friend WithEvents AwayRoundThreeScore As Label
    Friend WithEvents AwayRoundTwoScore As Label
End Class
