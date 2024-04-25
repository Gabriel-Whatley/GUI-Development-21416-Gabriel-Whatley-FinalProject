'Name: Gabriel Whatley - gabriel.whatley@gmail.com
'Date: 4/24/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Final assignment that converts measurements between inch and metric based on user input and saves them to a file.

Public Class Form1

    Dim input As Decimal

    Private Sub btn_save_list_Click(sender As Object, e As EventArgs) Handles btn_save_list.Click

    End Sub

    Private Sub btn_clear_results_Click(sender As Object, e As EventArgs) Handles btn_clear_results.Click
        lbl_conversion_output.Text = ""
        rdio_In_to_M.Checked = True
    End Sub

    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click

        If Decimal.TryParse(textbox_input.Text, input) = False Then
            MsgBox("Please enter a positive decimal number.", 0, "Warning")
            Exit Sub
        End If

        If input <= 0 Then
            MsgBox("Please enter a positive decimal number.", 0, "Warning")
            Exit Sub
        End If

        'If the inches to meters radio button is checked, perform the conversion format the result as a decimal with two places and put it in a string for output. Set the output label.
        If rdio_In_to_M.Checked Then
            lbl_conversion_output.Text = String.Format("{0} inches is {1} meters", input, Math.Round(input * 0.0254, 3))
        End If

        'If the meters to inches radio button is checked, perform the conversion, format the result as a decimal with two places and put it in a string for output. Set the output label.
        If rdio_M_to_In.Checked Then
            lbl_conversion_output.Text = String.Format("{0} meters is {1} inches", input, Math.Round(input * 39.37007874, 3))
        End If

    End Sub

    Private Sub btn_save_results_Click(sender As Object, e As EventArgs) Handles btn_save_results.Click
        If lbl_conversion_output.Text IsNot "" Then
            listbox_results.Items.Add(lbl_conversion_output.Text)
        End If
    End Sub

    Private Sub btn_clear_list_Click(sender As Object, e As EventArgs) Handles btn_clear_list.Click
        listbox_results.Items.Clear()
    End Sub

End Class
