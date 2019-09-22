'Adam Boswell
'RCET 0265
'Asg 3-6
'Shipping Cost Calculator Program
'https://github.com/boswadam/AMB-VS-F19/tree/master/Assignments_3/Asg%203-6/Asg%203-6

Option Explicit On
Option Strict On

Public Class shippingCalc

    Dim lbs As Double
    Dim oz As Double
    Dim shipCost As Double   'Dims all my variables
    Const rate = 0.12        'sets the rate as a constant of .12

    Dim ID As String
    Dim errorMsg As String



    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        errorMsg = "" 'sets error message as blank
        Try
            lbs = Double.Parse(lbTextBox.Text)
        Catch ex As Exception
            errorMsg = "Please enter the pounds of your package as a number"
            lbTextBox.Select()
            lbTextBox.Clear()

        End Try

        Try
            oz = Double.Parse(ozTextBox.Text)
        Catch ex As Exception
            errorMsg = "Please enter the ounces of your package as a number"
            ozTextBox.Select()
            ozTextBox.Clear()

        End Try
        'Two try statements validate the data 
        If errorMsg <> "" Then
            MessageBox.Show(errorMsg, "Invalid Entry") 'If the errorMsg isnt blank a message box will display the error
        Else
            shipCost = ((lbs * 16) + oz) * rate        'If errorMsg IS blank then math is performed 
            costTextBox.Text = shipCost.ToString("C")  'Cost is then displayed in dollars

        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        costTextBox.Clear()
        ozTextBox.Clear()
        lbTextBox.Clear() 'clears all data
        lbTextBox.Select() 'puts the focus back on lbtextbox



    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()  'closes the program when exit is clicked
    End Sub

End Class
