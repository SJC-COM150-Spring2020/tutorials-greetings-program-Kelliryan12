Public Class Greetings3


    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        ' Print greetings to listbox
        lstOut.Items.Add("Good Evening " & txtName.Text)
        lstOut.Items.Add("How are you?")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when user exits the program
        Beep()
        Application.Exit()
    End Sub


End Class
