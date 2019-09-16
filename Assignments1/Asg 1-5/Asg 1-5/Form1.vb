Public Class menuApp
    'Adam Boswell
    'RCET 2056
    'Menu board program
    '


    'all subs control "menudisplay" label text except "exit button" controls form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles soupButton.Click
        Me.menuDisplay.Text = "Fresh fish eye and octopus tentacle soup" 'Controls soup of the day button
    End Sub

    Private Sub ChefButton_Click(sender As Object, e As EventArgs) Handles chefButton.Click
        Me.menuDisplay.Text = "Whole meatloaf served with bacon grilled cheese sandwich"
        'controls chef special button
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles fishButton.Click
        Me.menuDisplay.Text = "Wild caught flying fish"    'Controls fush button
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()  'EXIT button, will close program
    End Sub
End Class
