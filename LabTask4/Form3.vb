'CONNIE KAWAS / 20DDT21F2030
Imports System.Data.SqlClient
Public Class Form3
    ' Define your connection string (replace with your actual connection details)
    Dim connectionString As String = "Server=LAPTOP-5SV0KDBC;Database=SoftwareRepository;User Id=sa;Password=yoongi;"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: Load data into your tables as needed
        Me.ListOfSoftwareTableAdapter.Fill(Me.SoftwareRepositoryDataSet1.ListOfSoftware)
        Me.AuthorsTableAdapter1.Fill(Me.SoftwareRepositoryDataSet1.Authors)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Using connection As SqlConnection = New SqlConnection(connectionString)
                connection.Open()

                ' Define your SQL query with parameters
                Dim query As String = "INSERT INTO authors (authorname, authorid,) VALUES (@name, @id)"
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@name", txtAuthorName.Text)
                    command.Parameters.AddWithValue("@id", txtAuthorID.Text)

                    ' Execute the query and get the number of rows affected
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    MsgBox($"{rowsAffected} data successfully inserted")

                    ' Clear textboxes after insertion
                    txtAuthorName.Clear()
                    txtAuthorID.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ' Clear textboxes
        txtAuthorName.Clear()
        txtAuthorID.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Using connection As SqlConnection = New SqlConnection(connectionString)
                connection.Open()

                ' Define your SQL query with parameters
                Dim query As String = "DELETE FROM authors WHERE authorname = @name"
                Using command As New SqlCommand(query, connection)
                    ' Add parameter to the command
                    command.Parameters.AddWithValue("@name", txtAuthorName.Text)

                    ' Execute the query
                    command.ExecuteNonQuery()

                    ' Clear textbox after deletion
                    txtAuthorName.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Try
            Using connection As SqlConnection = New SqlConnection(connectionString)
                connection.Open()

                ' Define your SQL query with INNER JOIN
                Dim query As String = "SELECT Authors.authorname, ListOfSoftware.softwarename FROM Authors " &
                                      "INNER JOIN ListOfSoftware ON Authors.authorid = ListOfSoftware.authorid"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to a DataGridView
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub
End Class

