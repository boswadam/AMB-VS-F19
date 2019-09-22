'Adam Boswell
'RCET 0265
'Asg 3-6
'Shipping Cost Calculator Program
'

Option Explicit On
Option Strict On

Public Class shippingCalc

    Dim lbs As Double
    Dim oz As Double
    Dim shipCost As Double
    Const rate = 0.12

    Dim ID As String
    Dim errorMsg As String



    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        errorMsg = ""
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

        If errorMsg <> "" Then
            MessageBox.Show(errorMsg, "Invalid Entry")
        Else
            shipCost = ((lbs * 16) + oz) * rate
            costTextBox.Text = shipCost.ToString("C")

        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        costTextBox.Clear()
        ozTextBox.Clear()
        lbTextBox.Clear()
        lbTextBox.Select()



    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
