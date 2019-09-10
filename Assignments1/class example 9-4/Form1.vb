'
''

Public Class Form1
    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        Label2.Text = "'Sup"
        Button1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.Enabled = False

    End Sub
End Class
