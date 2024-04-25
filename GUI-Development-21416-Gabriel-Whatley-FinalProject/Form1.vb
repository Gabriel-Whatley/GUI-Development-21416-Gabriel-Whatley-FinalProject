'Name: Gabriel Whatley - gabriel.whatley@gmail.com
'Date: 4/24/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Final assignment that converts measurements between inch and metric based on user input and saves them to a file.

Public Class Form1

    Dim writer As System.IO.StreamWriter
    Dim input As Decimal

    Private Sub btn_save_list_Click(sender As Object, e As EventArgs) Handles btn_save_list.Click
        writer = New IO.StreamWriter("measures.txt") 'Create a writer to write the file.
        For Each item In listbox_results.Items 'iterate through the items in the listbox.
            writer.WriteLine(item) 'Write each one to a new line in the file
        Next
        writer.Close() ' Close the writer when it's done.
        lbl_save_msg.Text = String.Format("Saved {0} entries to messages.txt", listbox_results.Items.Count) 'Report the number of items that were written.
    End Sub

    Private Sub btn_clear_results_Click(sender As Object, e As EventArgs) Handles btn_clear_results.Click
        'Clear the conversion output label and reset the selection on the inch to meter radio button.
        lbl_conversion_output.Text = ""
        rdio_In_to_M.Checked = True
    End Sub

    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click

        'Check that the input is a number, if not display an error message and exit the sub. If it can be parsed, store it in Decimal variable "input".
        If Decimal.TryParse(textbox_input.Text, input) = False Then
            MsgBox("Please enter a positive decimal number.", 0, "Warning")
            Exit Sub
        End If

        'Check that the number is positive, if not display an error message and exit the sub.
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
        'If the output label isn't empty, then add the text from the output label to the listbox items.
        If lbl_conversion_output.Text IsNot "" Then
            listbox_results.Items.Add(lbl_conversion_output.Text)
        End If
    End Sub

    Private Sub btn_clear_list_Click(sender As Object, e As EventArgs) Handles btn_clear_list.Click
        'Clear the listbox items and the save message label.
        listbox_results.Items.Clear()
        lbl_save_msg.Text = ""
    End Sub

End Class
