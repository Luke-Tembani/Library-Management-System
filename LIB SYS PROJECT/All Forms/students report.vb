Public Class students_report

    Private Sub students_report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students' table. You can move, or remove it, as needed.
        Me.New_StudentsTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class