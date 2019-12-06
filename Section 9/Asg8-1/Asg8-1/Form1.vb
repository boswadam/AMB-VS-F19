'Adam Boswell
'RCET 265
'Asg 8-1
'


Option Strict On
Option Explicit On

Public Class Form1
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim number As Single

        For i = 1 To 10
            number = Int(Rnd() * 20) - 10
            ViewableListBox.Items.Insert(0, number)
        Next
        ViewableListBox.Items.Insert(10, "_____________________________________________")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ViewableListBox.Items.Clear()
    End Sub
End Class
