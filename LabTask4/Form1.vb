'Connie Kawas (20DDT21F2030)
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connectionString As String = "Server=LAPTOP-5SV0KDBC;Database=SoftwareRepository;User Id=sa;Password=yoongi;"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM login WHERE username=@username And password=@password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtPassword.Text)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                Form2.Show()
            Else
                MsgBox("Unauthorized User")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class
