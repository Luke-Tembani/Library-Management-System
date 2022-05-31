Imports System.IO

Public Class backup

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog() = vbOK Then
                File.Copy("LIBRARY SYSTEM DATABASE 2O19.accdb", fbd.SelectedPath & "\LIBRARY SYSTEM DATABASE 2O19.accdb")
                MessageBox.Show("Backup Successful")
            End If
        Catch ex As Exception
            MessageBox.Show("Backup Failed")

        End Try
    End Sub
    

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog() = vbOK Then
                File.Delete("LIBRARY SYSTEM DATABASE 2O19.accdb")
                File.Copy(fbd.SelectedPath & "\LIBRARY SYSTEM DATABASE 2O19.accdb", "LIBRARY SYSTEM DATABASE 2O19.accdb")
                MessageBox.Show("Restore Successful")
                Application.Restart()
            End If
        Catch ex As Exception
            MessageBox.Show("Restore Failed")
        End Try

    End Sub

    Private Sub backup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class