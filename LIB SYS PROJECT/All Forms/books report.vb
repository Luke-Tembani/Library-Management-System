Public Class books_report

    Private Sub books_report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books' table. You can move, or remove it, as needed.
        Me.New_BooksTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class