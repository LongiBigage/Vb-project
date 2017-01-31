Imports System.Data.SqlClient
Imports System.Data

Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;integrated Security=true")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        Dim login_query As String = "SELECT * FROM techer WHERE username='" & username_tb.Text & "' AND password='" & password_tb.Text & "'"
        comm.Connection = conn
        comm.CommandText = login_query
        Dim dr As SqlDataReader = comm.ExecuteReader()
        If dr.HasRows Then
            comm.Dispose()
            conn.Close()
            home.Show()
            Hide()
        Else
            login_error_lb.Text = "Wrong Username or Password"
            login_error_lb.ForeColor = Color.Red
        End If
    End Sub
End Class