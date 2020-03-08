
Imports ArialAssist

Public Class Display
    Dim m As Integer = 10
    Dim s As Integer = 0

    'The click event that handles the team name occurs this changes the text property in the display
    Public Sub UpdateHomeTeam(ByRef teamName As String)
        Me.HomeTeam.Text = teamName
    End Sub

    'Same as above, changes the away team name
    Public Sub UpdateAwayTeam(ByRef teamName As String)
        Me.AwayTeam.Text = teamName
    End Sub

    'This returns the full roster of player to the text box so that it is visible
    Public Sub UpdateHomePlayer(ByRef homeTeam As Team)
        Me.HomePlayers.Text = homeTeam.GetRoster()
    End Sub
    'Same as above except for the away team
    Public Sub UpdateAwayPlayer(ByRef awayTeam As Team)
        Me.AwayPlayers.Text = awayTeam.GetRoster()
    End Sub

    'When a bonus point is added by the scorers this updates it on the display screen
    Public Sub UpdateHomeBonus(ByRef homeTeam As Team)
        HomeBonusScore.Text = homeTeam.GetBonus()
    End Sub
    'Same as above for the away team
    Public Sub UpdateAwayBonus(ByRef awayTeam As Team)
        AwayBonusScore.Text = awayTeam.GetBonus()
    End Sub

    'Updates the score  for home team by calling the getScore method from team.vb
    Public Sub UpdateHomeScore(ByRef homeTeam As Team)
        HomeScore.Text = homeTeam.GetScore()
    End Sub
    'Same as above except for away team
    Public Sub UpdateAwayScore(ByRef awayTeam As Team)
        AwayScore.Text = awayTeam.GetScore()
    End Sub

    'Timer not actually working
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' TimerLabel.Text = m & " : " & s

    End Sub

    'Resets the away bonus text
    Friend Sub ResetAwayBonus(awayTeam As Team)
        AwayBonusScore.Text = 0
    End Sub
    'Resets the home bonus text
    Friend Sub ResetHomeBonus(homeTeam As Team)
        HomeBonusScore.Text = 0
    End Sub


End Class