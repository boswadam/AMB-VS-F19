﻿Public Class Form1

    Sub AssignString()
        'initialize the name variable to monday
        Dim weekday As String
        weekday = "Monday"
        Console.WriteLine(weekday)
    End Sub

    Sub numbers()
        Dim firstnumber As Integer
        Dim secondnumber As Integer
        Dim result As Integer
        firstnumber = 5
        secondnumber = 6
        result = firstnumber + secondnumber
        Console.WriteLine(result)

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        AssignString()

    End Sub
End Class
