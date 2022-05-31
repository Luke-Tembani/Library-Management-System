<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowers_report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet = New LIB_SYS_PROJECT.LIBRARY_SYSTEM_DATABASE_2O19DataSet()
        Me.Borrowed_BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrowed_BooksTableAdapter = New LIB_SYS_PROJECT.LIBRARY_SYSTEM_DATABASE_2O19DataSetTableAdapters.Borrowed_BooksTableAdapter()
        CType(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrowed_BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Borrowed_BooksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIB_SYS_PROJECT.borrowers report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1157, 541)
        Me.ReportViewer1.TabIndex = 0
        '
        'LIBRARY_SYSTEM_DATABASE_2O19DataSet
        '
        Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.DataSetName = "LIBRARY_SYSTEM_DATABASE_2O19DataSet"
        Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Borrowed_BooksBindingSource
        '
        Me.Borrowed_BooksBindingSource.DataMember = "Borrowed Books"
        Me.Borrowed_BooksBindingSource.DataSource = Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet
        '
        'Borrowed_BooksTableAdapter
        '
        Me.Borrowed_BooksTableAdapter.ClearBeforeFill = True
        '
        'borrowers_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 541)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "borrowers_report"
        Me.Text = "borrowers_report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LIBRARY_SYSTEM_DATABASE_2O19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrowed_BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Borrowed_BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIBRARY_SYSTEM_DATABASE_2O19DataSet As LIB_SYS_PROJECT.LIBRARY_SYSTEM_DATABASE_2O19DataSet
    Friend WithEvents Borrowed_BooksTableAdapter As LIB_SYS_PROJECT.LIBRARY_SYSTEM_DATABASE_2O19DataSetTableAdapters.Borrowed_BooksTableAdapter
End Class
