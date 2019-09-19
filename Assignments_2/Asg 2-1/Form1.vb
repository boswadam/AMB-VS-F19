'Adam Boswell
'RCET 0265
'Asg 2-5
'Address Maker Program
'

Public Class AddressMaker

    Dim Name1 As String
    Dim Name2 As String
    Dim Address As String
    Dim City As String
    Dim State As String
    Dim Zip As String           'Claims all variables as strings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConcatenateButton.Click
        Name1 = FirstNameTextBox.Text
        Name2 = LastNameTextBox.Text
        Address = StreetAddressTextBox.Text
        City = CityTextBox.Text
        State = StateTextBox.Text
        Zip = ZipMaskedTextBox1.Text          'Inputs the user information as the variables to be concatenated 

        Me.AddressLabel.Text = Name1 & " " & Name2 & vbNewLine & Address & vbNewLine & City & ", " &
                                                        State & "  " & Zip 'concatenates all strings together 

    End Sub
    Private Sub Clrbutton_Click(sender As Object, e As EventArgs) Handles Clrbutton.Click
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipMaskedTextBox1.Text = ""   'Clears all of the text boxes

        FirstNameTextBox.Select() 'places the cursor back to the first name text box

        Me.AddressLabel.Text = "Please insert address information" 'Changes address label to read this for user

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'closes the program when exit button is clicked
    End Sub


End Class
