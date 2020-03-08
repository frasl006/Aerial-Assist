Public Class Team

    Dim name As String = ""
    Dim members(4) As String
    Dim score As Integer = 0
    Dim bonus As Integer = 0
    Dim total As Integer = 0
    Dim count As Integer = 0
    Dim roundOne As Integer = 0
    Dim roundTwo As Integer = 0
    Dim roundThree As Integer = 0

    'Set the name of the team
    Public Sub SetName(ByVal nameVal As String)
        Me.name = nameVal
    End Sub

    'Access the name of the team
    Public Function GetName()
        Return name
    End Function

    'Update the score, including the bonus pass if any
    Public Sub UpdateScore()
        Me.score = (5 + GetBonus()) + score
    End Sub

    'Access the score
    Public Function GetScore()
        Return score
    End Function

    'Update the bonus points (via passing)
    Public Sub UpdateBonus()
        Me.bonus = bonus + 1
        'Bonus point cannot exceed 3, if exceeded - reset to 0
        If (Me.bonus >= 4) Then
            bonus = 0
        End If
    End Sub

    'Access the bonus
    Public Function GetBonus()
        Return bonus
    End Function

    'A collection of variables for score each round
    Public Sub UpdateOne(ByRef round As Integer)
        Me.roundOne = round
    End Sub

    Public Sub UpdateTwo(ByRef round As Integer)
        Me.roundTwo = roundTwo
    End Sub

    Public Sub UpdateThree(ByRef round As Integer)
        Me.roundThree = roundThree
    End Sub
    'End of collection mutators

    'Accessors for round score variables
    Public Function GetRoundOne()
        Return roundOne
    End Function

    Public Function GetRoundTwo()
        Return roundTwo
    End Function

    Public Function GetRoundThree()
        Return roundThree
    End Function
    'End of collection of accessors

    'Might not be Necissary - as of 14/04 unused
    Public Sub SetTotal()
        total = score
    End Sub
    'Might not be Necissary - as of 14/04 unused
    Public Function GetTotal()
        Return total
    End Function

    'Adds team members to the members array, toAdd is the Display.Home/Away.Text 
    Public Sub AddMember(ByVal toAdd As String, ByVal indexToAddTo As Integer)
        'If the roster is full show message
        If (Not (members(4) Is Nothing)) Then
            MsgBox("Roster is Full!")
        Else
            'If not full add member to the index passed as parameter
            members(indexToAddTo) = toAdd
        End If
    End Sub

    'Returns the player at the index parameter
    Public Function GetPlayer(ByRef index As Integer)
        Return members(index)
    End Function

    'Returns the members in the team seperated by a new line (Environment.NewLine)
    Public Function GetRoster()
        Dim roster As String = String.Join(Environment.NewLine, members)
        Return roster
    End Function

    'Resets the bonus
    Public Sub ResetBonus()
        bonus = 0
    End Sub

End Class
