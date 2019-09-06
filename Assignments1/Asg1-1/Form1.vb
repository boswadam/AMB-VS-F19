'Assignment: asg1-1
'Name: Adam Boswell
'RCET 0265
'Hello World Assignment 


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles englishButton.Click
        Me.DaLabel.Text = "Hello World!"
        Me.englishButton.Text = "&English"
        Me.PortugueseButton.Text = "&Portuguese"
        Me.FrenchButton.Text = "&French"
        Me.ExitButton.Text = "&Exit"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FrenchButton.Click
        Me.DaLabel.Text = "Ciao Mongo!"
        Me.englishButton.Text = "&Anglais"
        Me.FrenchButton.Text = "&française"
        Me.DutchButton.Text = "&Néerlandaise"
        Me.PortugueseButton.Text = "&Portugais"
        Me.ExitButton.Text = "&Sortiet"

    End Sub

    Private Sub DutchButton_Click(sender As Object, e As EventArgs) Handles DutchButton.Click
        Me.DaLabel.Text = "Hallo Wereld!"
        Me.englishButton.Text = "&Engels"
        Me.FrenchButton.Text = "&Frans"
        Me.DutchButton.Text = "&Nederlands"
        Me.PortugueseButton.Text = "&Portugees"
        Me.ExitButton.Text = "&Uitgang"
    End Sub

    Private Sub SpanishButton_Click(sender As Object, e As EventArgs) Handles PortugueseButton.Click
        Me.DaLabel.Text = "Ola Mundo!"
        Me.PortugueseButton.Text = "&Portugese"
        Me.DutchButton.Text = "&Holandesa"
        Me.englishButton.Text = "&Ingles"
        Me.FrenchButton.Text = "&Frances"
        Me.ExitButton.Text = "&Saída"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
