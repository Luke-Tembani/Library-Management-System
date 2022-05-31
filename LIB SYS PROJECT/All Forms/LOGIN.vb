Public Class LOGIN

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "Luke" And PasswordTextBox.Text = "Tembani" Then
            MessageBox.Show("Login Successful")
            Me.Hide()
            MAIN_MENU.Show()
        Else
            MessageBox.Show("Login Failed")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to close the application", "Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class