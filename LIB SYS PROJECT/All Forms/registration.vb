Public Class registration



    Private Sub New_StudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.New_StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet)

    End Sub

    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books' table. You can move, or remove it, as needed.
        Me.New_BooksTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books)
        'TODO: This line of code loads data into the 'LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students' table. You can move, or remove it, as needed.
        Me.New_StudentsTableAdapter.Fill(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        New_StudentsBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            New_StudentsBindingSource.EndEdit()
            New_StudentsTableAdapter.Update(LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students)
            MessageBox.Show("Saved")
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Do you want to borrow a book", "REGISTRATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                Me.Hide()
                issue_and_return.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error,could not save, enter all details")


        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Are you sure you want delete", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                New_StudentsBindingSource.RemoveCurrent()
                New_StudentsBindingSource.EndEdit()
                New_StudentsTableAdapter.Update(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Students)
                MessageBox.Show("Deleted")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, nothing selected for deletion")


        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        New_BooksBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            New_BooksBindingSource.EndEdit()
            New_BooksTableAdapter.Update(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books)
            MessageBox.Show("Saved")
        Catch ex As Exception
            MessageBox.Show("Error while saving, Enter all details please")

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Are you sure you want delete", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                New_BooksBindingSource.RemoveCurrent()
                New_BooksBindingSource.EndEdit()
                New_BooksTableAdapter.Update(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.New_Books)
                MessageBox.Show("Deleted")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, nothing selected for deletion")

        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub StudentIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentIDTextBox.TextChanged
        If StudentIDTextBox.TextLength = StudentIDTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If
    End Sub

    Private Sub ISBNTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISBNTextBox.TextChanged
        If ISBNTextBox.TextLength = ISBNTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If

    End Sub

    Private Sub FirstNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstNameTextBox.TextChanged
        If FirstNameTextBox.TextLength = FirstNameTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If
    End Sub

    Private Sub SurnameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurnameTextBox.TextChanged
        If SurnameTextBox.TextLength = SurnameTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If
    End Sub

    Private Sub GenderComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderComboBox.SelectedIndexChanged
      
    End Sub

    Private Sub ClassTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTextBox.TextChanged
        If ClassTextBox.TextLength = ClassTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If
    End Sub

    Private Sub BookTitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookTitleTextBox.TextChanged
        If BookTitleTextBox.TextLength = BookTitleTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If

    End Sub

    Private Sub CategoryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryTextBox.TextChanged
        If CategoryTextBox.TextLength = CategoryTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If

    End Sub

    Private Sub AuthorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorTextBox.TextChanged
        If AuthorTextBox.TextLength = AuthorTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If

    End Sub

    Private Sub EditionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditionTextBox.TextChanged
        If EditionTextBox.TextLength = EditionTextBox.MaxLength Then
            MessageBox.Show("Max Length Reached")
        End If

    End Sub
End Class











