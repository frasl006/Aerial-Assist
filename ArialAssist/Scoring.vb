Public Class sa

    Dim Display As Display = New Display
    Dim homeTeam As Team = New Team
    Dim awayTeam As Team = New Team
    Dim homeMemberCount As Integer = 0
    Dim awayMemberCount As Integer = 0
    Dim homeScoreOne As Integer = 0
    Dim homeScoreTwo As Integer = 0

    'Sets the Away team name in the display to whats typed the text box
    Private Sub HomeTeamNameSub_Click(sender As Object, ByVal e As System.EventArgs) Handles HomeTeamNameSub.Click
        Me.homeTeam.SetName(HomeTeamName.Text)
        Display.UpdateHomeTeam(homeTeam.GetName)
        HomeTeamName.ResetText()
    End Sub
    'Sets the Away team name in the display to whats typed the text box
    Private Sub AwayTeamNameSub_Click(sender As Object, ByVal e As System.EventArgs) Handles AwayTeamNameSub.Click
        Me.awayTeam.SetName(AwayTeamName.Text)
        Display.UpdateAwayTeam(awayTeam.GetName)
        AwayTeamName.ResetText()
    End Sub

    'Add the player to the team member array. AddMember is defined in Team.vb
    Private Sub HomePlayerSub_Click(sender As Object, ByVal e As EventArgs) Handles HomePlayerSub.Click
        Me.homeTeam.AddMember(HomePlayerNameBox.Text, homeMemberCount)
        Display.UpdateHomePlayer(homeTeam)
        HomePlayerNameBox.ResetText()
        'Used to determine limit of players you can add
        Me.homeMemberCount += 1
    End Sub

    'Exactly as above except for the away team
    Private Sub AwayPlayerSub_Click(sender As Object, e As EventArgs) Handles AwayPlayerSub.Click
        Me.awayTeam.AddMember(AwayPlayerNameBox.Text, awayMemberCount)
        Display.UpdateAwayPlayer(awayTeam)
        AwayPlayerNameBox.ResetText()
        Me.awayMemberCount += 1
    End Sub

    'Updates and displays the teams bonus
    Private Sub HomeBonusButton_Click(sender As Object, e As EventArgs) Handles HomeBonusButton.Click
        Me.homeTeam.UpdateBonus()
        Display.UpdateHomeBonus(homeTeam)
    End Sub

    'Updates and displays the teams bonus
    Private Sub AwayBonusButton_Click(sender As Object, e As EventArgs) Handles AwayBonusButton.Click
        Me.awayTeam.UpdateBonus()
        Display.UpdateAwayBonus(awayTeam)
    End Sub

    'Updates and displays the goal score including the bonus
    Private Sub HomeGoalButton_Click(sender As Object, e As EventArgs) Handles HomeGoalButton.Click
        'UpdateScore is defined in Team.vb
        Me.homeTeam.UpdateScore()
        'Sets the bonus to 0
        Me.homeTeam.ResetBonus()
        Display.ResetHomeBonus(homeTeam)
        'Displays the score
        Display.UpdateHomeScore(homeTeam)
    End Sub

    'Same as above just for the away team
    Private Sub AwayGoalButton_Click(sender As Object, e As EventArgs) Handles AwayGoalButton.Click
        Me.awayTeam.UpdateScore()
        Me.awayTeam.ResetBonus()
        Display.ResetAwayBonus(awayTeam)
        Display.UpdateAwayScore(awayTeam)
    End Sub

    'Reset the bonus score for the home team
    Private Sub HomeResetButton_Click(sender As Object, e As EventArgs) Handles ResetBonusButton.Click
        Me.homeTeam.ResetBonus()
        Display.ResetHomeBonus(homeTeam)
    End Sub
    'Reset the bonus score for the away team
    Private Sub AwayResetButton_Click(sender As Object, e As EventArgs) Handles AwayResetButton.Click
        Me.awayTeam.ResetBonus()
        Display.ResetAwayBonus(awayTeam)
    End Sub

    'Loads the Display screen or "Scoreboard"
    Private Sub Sa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display.Show()
        CheckRoundOne.Checked = True
        MsgBox("The standard requirements have been met, however " & Environment.NewLine &
                "with additional time more functional and robust features" & Environment.NewLine &
                "can be added." & Environment.NewLine & "" & Environment.NewLine &
                "Additional features can include and not are limited to" & Environment.NewLine &
                "-Countdown timer with Pause and Additional Time features added" & Environment.NewLine &
                "-Player penalties and penalty minutes" & Environment.NewLine &
                "-Fully encrypted Login for large events eg World Cup's, Olympics etc" & Environment.NewLine &
                "" & Environment.NewLine &
                "Arial Assit SBManager Ver.1.0 ~ Published 14/04/2019 By" & Environment.NewLine &
                "Stewart Francis", )
    End Sub

    'Starts the count down clock - Currently not active.
    Private Sub StartClock_Click(sender As Object, e As EventArgs) Handles StartClock.Click
        Display.Timer.Start()
    End Sub

    'Pauses the count down clock - Currently not active.
    Private Sub PauseClock_Click(sender As Object, e As EventArgs) Handles PauseClock.Click
        Display.Timer.Stop()
    End Sub

    'When checked, Updates the current round appropriately
    Private Sub CheckRoundOne_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRoundOne.CheckedChanged
        Display.CurrentRound.Text = 1
    End Sub
    'Updates the first period scores and changes the round text accordingly
    Private Sub CheckRoundTwo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRoundTwo.CheckedChanged
        Display.CurrentRound.Text = 2
        Display.HomeRoundOneScore.Text = Display.HomeScore.Text
        Display.AwayRoundOneScore.Text = Display.AwayScore.Text
    End Sub
    'Updates the second period scores and changes the round text accordingly
    Private Sub CheckRoundThree_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRoundThree.CheckedChanged
        Display.CurrentRound.Text = 3
        Display.HomeRoundTwoScore.Text = Display.HomeScore.Text
        Display.AwayRoundTwoScore.Text = Display.HomeScore.Text
    End Sub
    'Updates the third period scores and resets the round text
    Private Sub FinalScore_Click(sender As Object, e As EventArgs) Handles FinalScore.Click
        Display.CurrentRound.Text = "0"
        Display.HomeRoundThreeScore.Text = Display.HomeScore.Text
        Display.AwayRoundThreeScore.Text = Display.AwayScore.Text

    End Sub
    'Resets all the scores on the display but only on the display not the value in team.score
    Private Sub ResetAllScores_Click(sender As Object, e As EventArgs) Handles ResetAllScores.Click
        MsgBox("This Button does not reset the actual score of the teams only whats shown on the display.", MsgBoxStyle.Critical)
        Display.HomeScore.Text = 0
        Display.AwayScore.Text = 0
    End Sub

End Class
