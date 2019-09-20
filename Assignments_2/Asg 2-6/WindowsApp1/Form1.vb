'Adam Boswell
'RCET 0265
'Flag Display Program
'Asg 2-6
'

Public Class Flag_Viewer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FlagButton1.Click
        FlagViewer.Image = My.Resources._1

    End Sub

    Private Sub FlagButton2_Click(sender As Object, e As EventArgs) Handles FlagButton2.Click
        FlagViewer.Image = My.Resources._2

    End Sub

    Private Sub FlagButton3_Click(sender As Object, e As EventArgs) Handles FlagButton3.Click
        FlagViewer.Image = My.Resources._3
    End Sub

    Private Sub FlagButton4_Click(sender As Object, e As EventArgs) Handles FlagButton4.Click
        FlagViewer.Image = My.Resources._4
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class