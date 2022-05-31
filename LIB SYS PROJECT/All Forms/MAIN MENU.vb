Public Class MAIN_MENU

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to log out", "MAIN MENU", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
            LOGIN.Show()
            LOGIN.UsernameTextBox.Text = ""
            LOGIN.PasswordTextBox.Text = ""


        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        registration.Show()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        reports.Show()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        issue_and_return.Show()

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

        Dim f As New backup
        f.ShowDialog()
    End Sub

    Private Sub MAIN_MENU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class