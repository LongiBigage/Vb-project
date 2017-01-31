Imports System.Data.SqlClient
Imports System.Data

Public Class studyyear
    Private Sub year_close_btn_Click(sender As Object, e As EventArgs) Handles year_close_btn.Click
        home.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub year_clear_btn_Click(sender As Object, e As EventArgs) Handles year_clear_btn.Click
        study_year_txt.Clear()
    End Sub

    Private Sub year_add_btn_Click(sender As Object, e As EventArgs) Handles year_add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=True;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn
        comm.CommandText = "INSERT INTO study_year([name]) VALUES ('" & study_year_txt.Text & "')"
        Dim c_result As Integer = comm.ExecuteNonQuery()
        If c_result > 0 Then
            MessageBox.Show("Study Year Created")
        Else
            MessageBox.Show("Failed to Add New Study Year, Please Try again")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub year_edit_btn_Click(sender As Object, e As EventArgs) Handles year_edit_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed")
        End Try
        If year_id_text.Text.ToString() IsNot "" Then
            Dim update_query As String = "UPDATE [study_year] SET name='" & study_year_txt.Text & "' WHERE id='" & year_id_text.Text & "'"
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = update_query
            Try
                Dim affected_row As Integer = comm.ExecuteNonQuery()
                If affected_row > 0 Then
                    MessageBox.Show("Data Succcessfully Updated")
                Else
                    MessageBox.Show("Failed to Update Data")
                End If
            Catch ex As Exception
                MessageBox.Show("Operation Failed")
            End Try
            comm.Dispose()
            comm = Nothing
            conn.Close()
        Else
            MessageBox.Show("Year ID is Required")
        End If
    End Sub

    Private Sub studyyear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        year_id_text.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as YEARD_ID, name as YEAR_NAME FROM [study_year]"
        Try
            Dim adpt As New SqlDataAdapter(student_query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds, "study_year")
            yearsView.DataSource = ds.Tables(0)
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show("Operation Failed")
        End Try
    End Sub

    Private Sub year_refresh_btn_Click(sender As Object, e As EventArgs) Handles year_refresh_btn.Click
        year_id_text.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as YEARD_ID, name as YEAR_NAME FROM [study_year]"
        Try
            Dim adpt As New SqlDataAdapter(student_query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds, "study_year")
            yearsView.DataSource = ds.Tables(0)
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show("Operation Failed")
        End Try
    End Sub

    Private Sub year_delete_btn_Click(sender As Object, e As EventArgs) Handles year_delete_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn

        If yearsView.SelectedRows.Count > 0 Or year_id_text.Text.ToString() IsNot "" Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim delete_query As String = "DELETE FROM [study_year] WHERE id = '" & year_id_text.Text & "'"
            comm.CommandText = delete_query
            Dim deleted As Integer = comm.ExecuteNonQuery()
            yearsView.Rows.Remove(yearsView.SelectedRows(0))

            year_id_text.Clear()
            study_year_txt.Clear()

            MessageBox.Show("Data Delete!!")
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub



    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles yearsView.CellClick
        Dim i As Integer
        i = yearsView.CurrentRow.Index
        If yearsView.Item(0, i).Value.ToString() IsNot "" Then
            year_id_text.Text = yearsView.Item(0, i).Value
            study_year_txt.Text = yearsView.Item(1, i).Value
        Else
            MessageBox.Show("Select Row with Data")
        End If

    End Sub
End Class