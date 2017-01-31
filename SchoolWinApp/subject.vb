Imports System.Data.SqlClient
Imports System.Data

Public Class subject
    Private Sub s_logout_btn_Click(sender As Object, e As EventArgs) Handles s_logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub subject_close_btn_Click(sender As Object, e As EventArgs) Handles subject_close_btn.Click
        home.Show()
        Hide()
    End Sub

    Private Sub subject_clear_btn_Click(sender As Object, e As EventArgs) Handles subject_clear_btn.Click
        subject_id_txt.Clear()
        subject_name_txt.Clear()
        subject_code_txt.Clear()
    End Sub

    Private Sub subject_delete_btn_Click(sender As Object, e As EventArgs) Handles subject_delete_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn

        If subjectsView.SelectedRows.Count > 0 Or subject_id_txt.Text.ToString() IsNot "" Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim delete_query As String = "DELETE FROM [subject] WHERE id = '" & subject_id_txt.Text & "'"
            comm.CommandText = delete_query
            Dim deleted As Integer = comm.ExecuteNonQuery()
            subjectsView.Rows.Remove(subjectsView.SelectedRows(0))

            subject_id_txt.Clear()
            subject_name_txt.Clear()
            subject_code_txt.Clear()

            MessageBox.Show("Data Delete!!")
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub subject_refresh_btn_Click(sender As Object, e As EventArgs) Handles subject_refresh_btn.Click
        subject_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim subject_query = "SELECT id as SUBJECT_ID, name as SUBJECT_NAME, code as SUJECT_CODE FROM [subject]"
        Try
            Dim adpt As New SqlDataAdapter(subject_query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds, "subject")
            subjectsView.DataSource = ds.Tables(0)
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show("Operation Failed")
        End Try
    End Sub

    Private Sub subject_edit_btn_Click(sender As Object, e As EventArgs) Handles subject_edit_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed")
        End Try
        If subject_id_txt.Text.ToString() IsNot "" Then
            Dim update_query As String = "UPDATE [subject] SET name='" & subject_name_txt.Text & "', code='" & subject_code_txt.Text & "' WHERE id='" & subject_id_txt.Text & "'"
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
            MessageBox.Show("Subject ID is Required")
        End If
    End Sub

    Private Sub subject_add_btn_Click(sender As Object, e As EventArgs) Handles subject_add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=True;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn
        comm.CommandText = "INSERT INTO subject([name],[code]) VALUES ('" & subject_name_txt.Text & "','" & subject_code_txt.Text & "')"
        Dim c_result As Integer = comm.ExecuteNonQuery()
        If c_result > 0 Then
            MessageBox.Show("Subject Created")
        Else
            MessageBox.Show("Failed to Add New Subject, Please Try again")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subject_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim subject_query = "SELECT id as SUBJECT_ID, name as SUBJECT_NAME, code as SUJECT_CODE FROM [subject]"
        Try
            Dim adpt As New SqlDataAdapter(subject_query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds, "subject")
            subjectsView.DataSource = ds.Tables(0)
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show("Operation Failed")
        End Try

    End Sub


    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles subjectsView.CellClick
        Dim i As Integer
        i = subjectsView.CurrentRow.Index
        If subjectsView.Item(0, i).Value.ToString() IsNot "" Then
            subject_id_txt.Text = subjectsView.Item(0, i).Value
            subject_name_txt.Text = subjectsView.Item(1, i).Value
            subject_code_txt.Text = subjectsView.Item(2, i).Value
        Else
            MessageBox.Show("Select Row with Data")
        End If

    End Sub
End Class