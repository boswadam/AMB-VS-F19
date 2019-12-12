'Adam Boswell
'RCET 0265
'Asg 8-2
'Dice Tracker
'https://github.com/boswadam/AMB-VS-F19/tree/master/wk3/Asg8-2

Option Explicit On
Option Strict On

Public Class Dice_Tracker

    Function rollDice() As Integer 'Returns a dice total to be compared
        Dim dice1 As Integer
        Dim dice2 As Integer
        Dim diceTotal As Integer
        dice1 = CInt(Rnd() * 5 + 1)
        dice2 = CInt(Rnd() * 5 + 1)
        diceTotal = dice1 + dice2
        Return diceTotal
    End Function

    Private Sub rollDiceButton_Click(sender As Object, e As EventArgs) Handles rollDiceButton.Click
        Dim rollCount As Integer
        Dim diceTotal As Integer
        Dim diceCase(10) As Integer
        rollCount = CInt(rollCountMaskedTextBox.Text)

        For i = 1 To rollCount      'rolls the dice for user selected number of times
            diceTotal = rollDice()

            Select Case diceTotal   'case compares dicetotal and increments to dicecase(0-10) array 
                Case 2
                    diceCase(0) += 1
                Case 3
                    diceCase(1) += 1
                Case 4
                    diceCase(2) += 1
                Case 5
                    diceCase(3) += 1
                Case 6
                    diceCase(4) += 1
                Case 7
                    diceCase(5) += 1
                Case 8
                    diceCase(6) += 1
                Case 9
                    diceCase(7) += 1
                Case 10
                    diceCase(8) += 1
                Case 11
                    diceCase(9) += 1
                Case 12
                    diceCase(10) += 1
            End Select

        Next

        listBoxViewer.Items.Add("Two dice were rolled " & CStr(rollCountMaskedTextBox.Text) & " times total.")
        listBoxViewer.Items.Add("The results of each roll were:")
        listBoxViewer.Items.Add("*~~~~~~~~~~~~~~~~~~~~~~~~~*")
        listBoxViewer.Items.Add("The number 2 was rolled " & CStr(diceCase(0)) & " times")
        listBoxViewer.Items.Add("The number 3 was rolled " & CStr(diceCase(1)) & " times")
        listBoxViewer.Items.Add("The number 4 was rolled " & CStr(diceCase(2)) & " times")
        listBoxViewer.Items.Add("The number 5 was rolled " & CStr(diceCase(3)) & " times")
        listBoxViewer.Items.Add("The number 6 was rolled " & CStr(diceCase(4)) & " times")
        listBoxViewer.Items.Add("The number 7 was rolled " & CStr(diceCase(5)) & " times")
        listBoxViewer.Items.Add("The number 8 was rolled " & CStr(diceCase(6)) & " times")
        listBoxViewer.Items.Add("The number 9 was rolled " & CStr(diceCase(7)) & " times")
        listBoxViewer.Items.Add("The number 10 was rolled " & CStr(diceCase(8)) & " times")
        listBoxViewer.Items.Add("The number 11 was rolled " & CStr(diceCase(9)) & " times")
        listBoxViewer.Items.Add("The number 12 was rolled " & CStr(diceCase(10)) & " times")
        listBoxViewer.Items.Add("*~~~~~~~~~~~~~~~~~~~~~~~~~*")


    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        listBoxViewer.Items.Clear()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
