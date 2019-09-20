'Adam Boswell  
'RCET 0265
'Asg 3-3
'Inventory Program
'

Option Strict On
Option Explicit On


Public Class Inventory_Calc
    Dim startInventory As Double
    Dim endInventory As Double
    Dim cost As Double
    Dim average As Double
    Dim turnover As Double           'sets all data variable values as double so decimals wil be seen

    Dim errorMsg As String           'sets the error message variable displayed as a string

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'subroutine responsible for calculate button

        errorMsg = ""    'sets errorMSG to nothing

        If BeginningTextBox.Text = "" Then
            errorMsg = "Please fill all input boxes"
            MessageBox.Show(errorMsg, "Whoops!")
            BeginningTextBox.Select()
            BeginningTextBox.Clear()
        ElseIf EndingTextBox.Text = "" Then
            errorMsg = "Please fill all input boxes"
            MessageBox.Show(errorMsg, "Whoops!")
            EndingTextBox.Select()
            EndingTextBox.Clear()
        ElseIf CostTextBox.Text = "" Then
            errorMsg = "Please fill all input boxes"
            MessageBox.Show(errorMsg, "Whoops!")
            CostTextBox.Select()
            CostTextBox.Clear()
        Else         'Three if statements make sure all boxes are filled before trying to convert data

            Try
                startInventory = Double.Parse(BeginningTextBox.Text)
            Catch ex As Exception
                errorMsg = "Please enter a number in Beginning Inventory"
                BeginningTextBox.Select()
                BeginningTextBox.Clear()

            End Try

            Try
                endInventory = Double.Parse(EndingTextBox.Text)

            Catch ex As Exception
                errorMsg = "Please enter a number in Ending Inventory"
                EndingTextBox.Select()
                EndingTextBox.Clear()

            End Try

            Try
                cost = Double.Parse(CostTextBox.Text)
            Catch ex As Exception
                errorMsg = "Please enter a number in Cost box"
                CostTextBox.Select()
                CostTextBox.Clear()

            End Try    'Three try statements check all input data and create corresponding errorMsg


            If errorMsg <> "" Then    'If statement checks if error was thrown during previous 3 trys 
                MessageBox.Show(errorMsg, "Whoops!")   'message box pops up displaying errorMsg
            Else
                average = (startInventory + endInventory) / 2   'performs math for average
                turnover = cost / average                        'performs math for turnover

                AverageTextBox.Text = average.ToString("C")         'Converts the Double information into string as dollars information
                TurnoverTextBox.Text = turnover.ToString("G7")      'Converts double data into string number with two decomals for display


            End If

        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()     'Closes the program when Exit is clicked
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        BeginningTextBox.Clear()
        EndingTextBox.Clear()
        CostTextBox.Clear()
        TurnoverTextBox.Clear()
        AverageTextBox.Clear()           'Clears all text boxes 
        BeginningTextBox.Select()        'Puts the cursor at the beginning of the form
    End Sub


End Class
