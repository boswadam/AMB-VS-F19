'Adam Boswell
'RCET 0265
'Asg 7-1
'


Option Strict On
Option Explicit On

Public Class Stock_Calculator
    Dim summary As New List(Of String)
    Dim stopSummary As New List(Of String)
    Private Sub clearData()
        StockSymbolTextBox.Clear()
        MondayTextBox.Clear()
        TuesdayTextBox.Clear()
        WednesdayTextBox.Clear()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        clearData()
        StockList.Items.Clear()
    End Sub

    Private Function ColumnHeaders(firstColumn As String, secondColumn As String, thirdColumn As String, fourthColumn As String) As String

        Dim columnWidth As Integer = 20
        firstColumn = "|      " & firstColumn
        secondColumn = "|      " & secondColumn
        thirdColumn = "|      " & thirdColumn
        fourthColumn = "|      " & fourthColumn

        Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
            thirdColumn.PadRight(columnWidth) & fourthColumn.PadRight(columnWidth)

    End Function
    Private Sub calculate()

        Dim errorMessage As String = ""
        Dim firstDayChange As Double
        Dim secondDayChange As Double
        Dim decision As String
        Static buy As Integer = 0
        Static sell As Integer = 0
        Static hold As Integer = 0
        'try catch statements are used to filter out bad data
        Try
            Double.Parse(WednesdayTextBox.Text)
        Catch ex As Exception
            errorMessage = "Please enter a valid Price in Wednesday." & vbNewLine & errorMessage
            WednesdayTextBox.Select()
        End Try
        Try
            Double.Parse(TuesdayTextBox.Text)
        Catch ex As Exception
            errorMessage = "Please enter a valid Price in Tuesday." & vbNewLine & errorMessage
            TuesdayTextBox.Select()
        End Try
        Try
            Double.Parse(MondayTextBox.Text)
        Catch ex As Exception
            errorMessage = "Please enter a valid Price in Monday." & vbNewLine & errorMessage
            MondayTextBox.Select()
        End Try
        If StockSymbolTextBox.Text = "" Then
            errorMessage = "Please enter the stock code you would like to calculate." & vbNewLine & errorMessage
            StockSymbolTextBox.Select()
        End If
        'if the error box is not empty it will show the errors found above
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage)
        End If

        If errorMessage = "" Then
            firstDayChange = Double.Parse(TuesdayTextBox.Text) - Double.Parse(MondayTextBox.Text)
            secondDayChange = Double.Parse(WednesdayTextBox.Text) - Double.Parse(TuesdayTextBox.Text)
            decision = CStr(HoldBuySell(firstDayChange, secondDayChange))
            'If error box is empty then no errors were found and the data is compared to produce a buy sell or hold result
            Select Case decision
                Case "Buy"
                    summary.Insert(0, ColumnHeaders(StockSymbolTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    StockList.Items.Insert(0, ColumnHeaders(StockSymbolTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    buy += 1
                Case "Sell"
                    summary.Insert(buy, ColumnHeaders(StockSymbolTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    StockList.Items.Insert(buy, ColumnHeaders(StockSymbolTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    sell += 1
                Case "Hold"
                    stopSummary.Add(ColumnHeaders(StockSymbolTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    StockList.Items.Insert((buy + sell), ColumnHeaders(StockSymbolTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
            End Select

            clearData()
        End If
    End Sub


    Private Function HoldBuySell(tuesdayChange As Double, wednesdayChange As Double) As Object
        Dim result As String
        If tuesdayChange > 0 And wednesdayChange > tuesdayChange Then
            result = "Buy"
        ElseIf tuesdayChange < 0 And wednesdayChange < tuesdayChange Then
            result = "Sell"
        Else
            result = "Hold"
        End If

        Return result
    End Function

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        calculate()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clearData()
        StockList.Items.Clear()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        calculate()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
