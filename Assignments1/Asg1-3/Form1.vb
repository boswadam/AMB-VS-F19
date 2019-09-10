'Assignment: Asg1-3
'RCET 0265
'Adam Boswell
'Wisgom Generator Program


Public Class Form1

    Sub wisdomGen()
        Dim statementOne As String
        Dim statementTwo As String
        Dim statementThree As String
        Dim statementFour As String
        Dim statementFive As String         'Space alloted for Statements 

        Dim rndNumber As Integer            'Space alloted for Random Number Generator

        Dim randomNumber As New Random
        rndNumber = randomNumber.Next(1, 7)         'Generates random number between 1-7 for rndNumber

        statementOne = "Adam LOOOOOOVES Burritos"
        statementTwo = "Guacomole is good with burritos"
        statementThree = "Tomatoes are better from your garden"
        statementFour = "Spicy peppers make for spicy Farts"
        statementFive = "The less you do, the less you want to do"       'Statement strings are set



        If rndNumber = 1 Then
            Txbox.Text = statementOne
        ElseIf rndNumber = 2 Then
            Txbox.Text = statementTwo
        ElseIf rndNumber = 3 Then
            Txbox.Text = statementThree
        ElseIf rndNumber = 4 Then
            Txbox.Text = statementFour
        ElseIf rndNumber = 5 Then
            Txbox.Text = statementFive
        Else
            Txbox.Text = "Sensei is tired now..."        'Number generated dictates which statement the 
                                                          ' "sensai says box" will display
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wisdomGen()
        Console.Beep(4000, 40)        'Creates small cick when button is pushed

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Console.Beep(400, 40)        'Creates small cick when button is pushed
        Me.Close()
    End Sub
End Class
