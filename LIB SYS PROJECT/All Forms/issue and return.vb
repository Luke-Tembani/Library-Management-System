Public Class issue_and_return




    Private Sub New_StudentsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.New_StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet)

    End Sub

    Private Sub issue_and_return_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books' table. You can move, or remove it, as needed.
        Me.Borrowed_BooksTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books)
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books' table. You can move, or remove it, as needed.
        Me.Lost_BooksTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books)
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books' table. You can move, or remove it, as needed.
        Me.New_BooksTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books)
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students' table. You can move, or remove it, as needed.
        Me.New_StudentsTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students)

        Timer1.Start()
        Timer2.Start()
        Label2.Visible = False

        Label3.Text = STARTUP.changelabeltext()

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim newRow As DataRow

        newRow = LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books.NewRow

        newRow.Item(0) = StudentIDTextBox.Text

        newRow.Item(1) = FirstNameComboBox.Text

        newRow.Item(2) = SurnameTextBox.Text

        newRow.Item(3) = GenderTextBox.Text
        newRow.Item(4) = ClassTextBox.Text
        newRow.Item(5) = ISBNTextBox.Text
        newRow.Item(6) = BookTitleComboBox.Text
        newRow.Item(7) = CategoryTextBox.Text
        newRow.Item(8) = AuthorTextBox.Text
        newRow.Item(9) = EditionTextBox.Text
        newRow.Item(10) = Label2.Text

        Try
            LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books.Rows.Add(newRow)

            Me.New_BooksTableAdapter.DecreaseInStock() ' query to decrease number of books in stock if a book is borrowed


            Borrowed_BooksBindingSource.EndEdit()

            Borrowed_BooksTableAdapter.Update(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books)

            MessageBox.Show("Book Issued")

        Catch ex As Exception

            MessageBox.Show("Failed To Issue Book, Check If Student doesn't have pending books")

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to return book", "ISSUE AND RETURN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Borrowed_BooksBindingSource.RemoveCurrent()
            Me.New_BooksTableAdapter.IncreaseInStock() 'query to increase number of books in stock if a book is returned
            Borrowed_BooksBindingSource.EndEdit()
            Borrowed_BooksTableAdapter.Update(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books)
            MessageBox.Show("Book Returned")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure this book has been lost", "ISSUE AND RETURN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            'code to add a new row to the lost books table
            Dim newRow As DataRow
            newRow = LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books.NewRow
            newRow.Item(0) = ISBNTextBox1.Text
            newRow.Item(1) = BookTitleTextBox.Text
            newRow.Item(2) = CategoryTextBox1.Text
            newRow.Item(3) = AuthorTextBox1.Text
            newRow.Item(4) = EditionTextBox1.Text
            newRow.Item(5) = StudentIDTextBox1.Text
            newRow.Item(6) = FirstNameTextBox.Text
            newRow.Item(7) = SurnameTextBox1.Text
            newRow.Item(8) = GenderTextBox1.Text
            newRow.Item(9) = ClassTextBox1.Text
            Try
                LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books.Rows.Add(newRow)
            Catch ex As Exception
                'code to inform librarian that no student can lose  more than two books as they are permitted to borrow one at a time
                MessageBox.Show("Error,No student can lose more than two books as they are permitted to borrow one at a time")
            End Try
            'code to remove book recorded as lost from borrowed books table
            Borrowed_BooksBindingSource.RemoveCurrent()
            Borrowed_BooksBindingSource.EndEdit()
            Borrowed_BooksTableAdapter.Update(LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books)
            'code to save book in lost books table
            Lost_BooksBindingSource.EndEdit()
            Lost_BooksTableAdapter.Update(LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books)
            MessageBox.Show("Book Recorded As Lost")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are you sure this book is about to be replaced", "ISSUE AND RETURN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then

            Me.New_BooksTableAdapter.IncreaseInStock() 'query to increase number of books in stock if a book is that was lost is replaced

            Lost_BooksBindingSource.RemoveCurrent() ' This line of code removes book that has been replaced from lost books table


            Lost_BooksBindingSource.EndEdit()  ' This line of code updates the lost books table if a book has been replaced

            Lost_BooksTableAdapter.Update(LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books)

            MessageBox.Show("Book Replaced")

        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim DatetimePicker1 As Date
        DatetimePicker1 = Date.Now
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label2.Text = Date.Now
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim search As String = "%" + TextBox1.Text + "%"
        Me.Borrowed_BooksTableAdapter.SEARCHQUERY(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Borrowed_Books, search)



    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim search As String = "%" + TextBox2.Text + "%"
        Me.Lost_BooksTableAdapter.SearchQuery(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.Lost_Books, search)

    End Sub
End Class