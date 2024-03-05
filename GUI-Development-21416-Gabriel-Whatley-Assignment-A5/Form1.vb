'Name: Gabriel Whatley
'Date : 3/2/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that calculates the price of entry for a specified number of people with a specified level of admission.
Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        textBxInput.Focus() 'Set focus on the input text box when the form is shown.
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim cost_per_person As Decimal
        Dim total_cost As Decimal
        Dim group_size As Short

        If Short.TryParse(textBxInput.Text, group_size) = False Then 'if the str can't be made a short, pop the error message and break.
            MsgBox("The input needs to be a whole number, please try again", 0, "Error")
            Exit Sub '<-- Alternate sub exit point.
        End If


        If group_size < 1 Or group_size > 20 Then 'If Group size less than 1 or more than 20, pop the error message and break.
            MsgBox("Sorry, the group size must be between 1 and 20", 0, "Error")
            Exit Sub '<-- Alternate sub exit point.
        End If

        If rdioSuperhero.Checked Then 'Determine which of the radio buttons are checked and then assign a value to the group members tickets.
            cost_per_person = 380
        ElseIf rdioAutographs.Checked Then
            cost_per_person = 270
        ElseIf rdioConvention.Checked Then
            cost_per_person = 209
        End If

        total_cost = cost_per_person * group_size 'Calculate the total cost of the group's tickets.
        lblOutput.Text() = FormatCurrency(total_cost, , , TriState.True, TriState.True) 'Format the output text to currency before writing it to the output label.
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = "" 'Clear output
        textBxInput.Clear() 'Clear Input
        rdioSuperhero.Select() 'Select first radio button
        textBxInput.Focus() 'Focus on text box
    End Sub

End Class
