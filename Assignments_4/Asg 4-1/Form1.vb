'Adam Boswell
'RCET 0256
'ASG 4-1
'Student Math Program 

Public Class Form1
    Dim mathFun As String
    Dim score As Integer



    Sub btnCntrl()
        If NameTextBox.Text And AgeComboBox.Text And GradeComboBox.Text = "" Then
            SubmitButton.Enabled = False
            SummaryButton.Enabled = False
            ClearButton.Enabled = False
            Numb1TextBox.Enabled = False
            Numb2TextBox.Enabled = False
            AnswerTextBox.Enabled = False
        Else
            SubmitButton.Enabled = True
            SummaryButton.Enabled = True
            ClearButton.Enabled = True
            Numb1TextBox.Enabled = True
            Numb2TextBox.Enabled = True
            AnswerTextBox.Enabled = True
        End If

    End Sub



    Function Math_Function(X As Integer, Y As Integer)
        Select Case True
            Case AddRadioButton.Checked
                mathFun = X + Y
            Case SubtractRadioButton.Checked
                mathFun = X - Y
            Case MultiplyRadioButton.Checked
                mathFun = X * Y
            Case DivideRadioButton.Checked
                mathFun = X \ Y
            Case Else
                MessageBox.Show("Please select a Math Function", "There seems to be a problem Jethro")
        End Select
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Math_Function(X:=(Rnd() * 50), Y:=(Rnd() * 50))
        If AnswerTextBox.Text = mathFun Then
            MessageBox.Show("You are correct!!", "SCORE!!")
            score += 1

        End If

    End Sub
End Class
