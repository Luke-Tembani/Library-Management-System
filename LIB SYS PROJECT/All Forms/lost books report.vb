Public Class lost_books_report

    Private Sub lost_books_report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books' table. You can move, or remove it, as needed.
        Me.Lost_BooksTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class