Public Class STARTUP
    Dim labeltext As String = "VENGERE HIGH SCHOOL LIBRARY SYSTEM"

    Public Function changelabeltext()

        Return labeltext

    End Function

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(8) 'speed of loading the progress bar
        Label4.Text = ProgressBar1.Value & "% Loading Modules"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            LOGIN.Show() 'code used to swith over to the login form
        End If
    End Sub

    Private Sub STARTUP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Text = changelabeltext()
    End Sub

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click
        Timer1.Start()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
    End Sub
End Class
