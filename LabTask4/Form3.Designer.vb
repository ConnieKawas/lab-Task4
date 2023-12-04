<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.SoftwareRepositoryDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftwareRepositoryDataSet = New LabTask4.SoftwareRepositoryDataSet()
        Me.SoftwareRepositoryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsTableAdapter = New LabTask4.SoftwareRepositoryDataSetTableAdapters.AuthorsTableAdapter()
        Me.AuthorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftwareRepositoryDataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftwareRepositoryDataSet1 = New LabTask4.SoftwareRepositoryDataSet1()
        Me.SoftwareRepositoryDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsTableAdapter1 = New LabTask4.SoftwareRepositoryDataSet1TableAdapters.AuthorsTableAdapter()
        Me.AuthorsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAuthorID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SoftwareRepositoryDataSet1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfSoftwareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfSoftwareTableAdapter = New LabTask4.SoftwareRepositoryDataSet1TableAdapters.ListOfSoftwareTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoftwareNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoftware = New System.Windows.Forms.TextBox()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.AuthorsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftwareRepositoryDataSet1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SoftwareRepositoryDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfSoftwareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SoftwareRepositoryDataSet
        '
        Me.SoftwareRepositoryDataSet.DataSetName = "SoftwareRepositoryDataSet"
        Me.SoftwareRepositoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoftwareRepositoryDataSetBindingSource
        '
        Me.SoftwareRepositoryDataSetBindingSource.DataSource = Me.SoftwareRepositoryDataSet
        Me.SoftwareRepositoryDataSetBindingSource.Position = 0
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "Authors"
        Me.AuthorsBindingSource.DataSource = Me.SoftwareRepositoryDataSetBindingSource
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'AuthorsBindingSource1
        '
        Me.AuthorsBindingSource1.DataMember = "Authors"
        Me.AuthorsBindingSource1.DataSource = Me.SoftwareRepositoryDataSet1BindingSource1
        '
        'SoftwareRepositoryDataSet1BindingSource1
        '
        Me.SoftwareRepositoryDataSet1BindingSource1.DataSource = Me.SoftwareRepositoryDataSet1
        Me.SoftwareRepositoryDataSet1BindingSource1.Position = 0
        '
        'SoftwareRepositoryDataSet1
        '
        Me.SoftwareRepositoryDataSet1.DataSetName = "SoftwareRepositoryDataSet1"
        Me.SoftwareRepositoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoftwareRepositoryDataSet1BindingSource
        '
        Me.SoftwareRepositoryDataSet1BindingSource.DataSource = Me.SoftwareRepositoryDataSet1
        Me.SoftwareRepositoryDataSet1BindingSource.Position = 0
        '
        'AuthorsTableAdapter1
        '
        Me.AuthorsTableAdapter1.ClearBeforeFill = True
        '
        'AuthorsBindingSource2
        '
        Me.AuthorsBindingSource2.DataMember = "Authors"
        Me.AuthorsBindingSource2.DataSource = Me.SoftwareRepositoryDataSet
        '
        'txtAuthorID
        '
        Me.txtAuthorID.Location = New System.Drawing.Point(192, 53)
        Me.txtAuthorID.Name = "txtAuthorID"
        Me.txtAuthorID.Size = New System.Drawing.Size(156, 26)
        Me.txtAuthorID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(49, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Author ID"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BtnSearch.Location = New System.Drawing.Point(556, 204)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 34)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Add"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BtnClear.Location = New System.Drawing.Point(556, 244)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 34)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BtnDelete.Location = New System.Drawing.Point(556, 284)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 34)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.AuthorIDDataGridViewTextBoxColumn, Me.SoftwareNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListOfSoftwareBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 229)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(491, 180)
        Me.DataGridView1.TabIndex = 5
        '
        'SoftwareRepositoryDataSet1BindingSource2
        '
        Me.SoftwareRepositoryDataSet1BindingSource2.DataSource = Me.SoftwareRepositoryDataSet1
        Me.SoftwareRepositoryDataSet1BindingSource2.Position = 0
        '
        'ListOfSoftwareBindingSource
        '
        Me.ListOfSoftwareBindingSource.DataMember = "ListOfSoftware"
        Me.ListOfSoftwareBindingSource.DataSource = Me.SoftwareRepositoryDataSet1BindingSource2
        '
        'ListOfSoftwareTableAdapter
        '
        Me.ListOfSoftwareTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'AuthorIDDataGridViewTextBoxColumn
        '
        Me.AuthorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID"
        Me.AuthorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID"
        Me.AuthorIDDataGridViewTextBoxColumn.Name = "AuthorIDDataGridViewTextBoxColumn"
        '
        'SoftwareNameDataGridViewTextBoxColumn
        '
        Me.SoftwareNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareName"
        Me.SoftwareNameDataGridViewTextBoxColumn.HeaderText = "SoftwareName"
        Me.SoftwareNameDataGridViewTextBoxColumn.Name = "SoftwareNameDataGridViewTextBoxColumn"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGreen
        Me.Label2.Location = New System.Drawing.Point(49, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Author Name"
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Location = New System.Drawing.Point(192, 111)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(156, 26)
        Me.txtAuthorName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.Location = New System.Drawing.Point(446, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Software Name"
        '
        'txtSoftware
        '
        Me.txtSoftware.Location = New System.Drawing.Point(610, 53)
        Me.txtSoftware.Name = "txtSoftware"
        Me.txtSoftware.Size = New System.Drawing.Size(156, 26)
        Me.txtSoftware.TabIndex = 10
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BtnView.Location = New System.Drawing.Point(556, 324)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 34)
        Me.BtnView.TabIndex = 11
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.AuthorIdDataGridViewTextBoxColumn1, Me.AuthorNameDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.AuthorsBindingSource5
        Me.DataGridView2.Location = New System.Drawing.Point(523, 397)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(491, 180)
        Me.DataGridView2.TabIndex = 12
        '
        'AuthorsBindingSource3
        '
        Me.AuthorsBindingSource3.DataMember = "Authors"
        Me.AuthorsBindingSource3.DataSource = Me.SoftwareRepositoryDataSet1BindingSource2
        '
        'AuthorsBindingSource4
        '
        Me.AuthorsBindingSource4.DataMember = "Authors"
        Me.AuthorsBindingSource4.DataSource = Me.SoftwareRepositoryDataSet1BindingSource2
        '
        'SoftwareRepositoryDataSet1BindingSource3
        '
        Me.SoftwareRepositoryDataSet1BindingSource3.DataSource = Me.SoftwareRepositoryDataSet1
        Me.SoftwareRepositoryDataSet1BindingSource3.Position = 0
        '
        'AuthorsBindingSource5
        '
        Me.AuthorsBindingSource5.DataMember = "Authors"
        Me.AuthorsBindingSource5.DataSource = Me.SoftwareRepositoryDataSet1BindingSource3
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'AuthorIdDataGridViewTextBoxColumn1
        '
        Me.AuthorIdDataGridViewTextBoxColumn1.DataPropertyName = "AuthorId"
        Me.AuthorIdDataGridViewTextBoxColumn1.HeaderText = "AuthorId"
        Me.AuthorIdDataGridViewTextBoxColumn1.Name = "AuthorIdDataGridViewTextBoxColumn1"
        '
        'AuthorNameDataGridViewTextBoxColumn
        '
        Me.AuthorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName"
        Me.AuthorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName"
        Me.AuthorNameDataGridViewTextBoxColumn.Name = "AuthorNameDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1083, 608)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.txtSoftware)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAuthorID)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.SoftwareRepositoryDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfSoftwareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareRepositoryDataSet1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoftwareRepositoryDataSetBindingSource As BindingSource
    Friend WithEvents SoftwareRepositoryDataSet As SoftwareRepositoryDataSet
    Friend WithEvents SoftwareRepositoryDataSetBindingSource1 As BindingSource
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents AuthorsTableAdapter As SoftwareRepositoryDataSetTableAdapters.AuthorsTableAdapter
    Friend WithEvents SoftwareRepositoryDataSet1BindingSource1 As BindingSource
    Friend WithEvents SoftwareRepositoryDataSet1 As SoftwareRepositoryDataSet1
    Friend WithEvents SoftwareRepositoryDataSet1BindingSource As BindingSource
    Friend WithEvents AuthorsBindingSource1 As BindingSource
    Friend WithEvents AuthorsTableAdapter1 As SoftwareRepositoryDataSet1TableAdapters.AuthorsTableAdapter
    Friend WithEvents AuthorsBindingSource2 As BindingSource
    Friend WithEvents txtAuthorID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SoftwareRepositoryDataSet1BindingSource2 As BindingSource
    Friend WithEvents ListOfSoftwareBindingSource As BindingSource
    Friend WithEvents ListOfSoftwareTableAdapter As SoftwareRepositoryDataSet1TableAdapters.ListOfSoftwareTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoftwareNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSoftware As TextBox
    Friend WithEvents BtnView As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents AuthorsBindingSource3 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AuthorIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AuthorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorsBindingSource5 As BindingSource
    Friend WithEvents SoftwareRepositoryDataSet1BindingSource3 As BindingSource
    Friend WithEvents AuthorsBindingSource4 As BindingSource
End Class
