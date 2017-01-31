Imports System.Data.SqlClient
Imports System.Data

Public Class examination
    Private Sub examination_logout_btn_Click(sender As Object, e As EventArgs) Handles examination_logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub examination_close_btn_Click(sender As Object, e As EventArgs) Handles examination_close_btn.Click
        home.Show()
        Hide()
    End Sub


    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles examinationsView.CellClick
        Dim i As Integer
        i = examinationsView.CurrentRow.Index
        If examinationsView.Item(0, i).Value.ToString() IsNot "" Then
            examination_id_txt.Text = examinationsView.Item(0, i).Value
            examination_name_txt.Text = examinationsView.Item(1, i).Value
        Else
            MessageBox.Show("Select Row with Data")
        End If

    End Sub

    Private Sub examination_delete_btn_Click(sender As Object, e As EventArgs) Handles examination_delete_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn

        If examinationsView.SelectedRows.Count > 0 Or examination_id_txt.Text.ToString() IsNot "" Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim delete_query As String = "DELETE FROM [examination] WHERE id = '" & examination_id_txt.Text & "'"
            comm.CommandText = delete_query
            Dim deleted As Integer = comm.ExecuteNonQuery()
            examinationsView.Rows.Remove(examinationsView.SelectedRows(0))

            examination_id_txt.Clear()
            examination_name_txt.Clear()

            MessageBox.Show("Data Delete!!")
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub examination_refresh_btn_Click(sender As Object, e As EventArgs) Handles examination_refresh_btn.Click
        examination_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as EXAMINATION_ID, name as EXAMINATION_NAME FROM [examination]"
        Try
            Dim adpt As New SqlDataAdapter(student_query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds, "examination")
            examinationsView.DataSource = ds.Tables(0)
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show("Operation Failed")
        End Try
    End Sub

    Private Sub examination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        examination_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as EXAMINATION_ID, name as EXAMINATION_NAME FROM [examination]"
        Try
            Dim adpt As New SqlDataAdapter(student_query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds, "examination")
            examinationsView.DataSource = ds.Tables(0)
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show("Operation Failed")
        End Try
    End Sub

    Private Sub examination_add_btn_Click(sender As Object, e As EventArgs) Handles examination_add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=True;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn
        comm.CommandText = "INSERT INTO examination([name]) VALUES ('" & examination_name_txt.Text & "')"
        Dim c_result As Integer = comm.ExecuteNonQuery()
        If c_result > 0 Then
            MessageBox.Show("Examination Created")
        Else
            MessageBox.Show("Failed to Add New Examination, Please Try again")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub examination_clear_btn_Click(sender As Object, e As EventArgs) Handles examination_clear_btn.Click
        examination_id_txt.Clear()
        examination_name_txt.Clear()
    End Sub

    Private Sub examination_edit_btn_Click(sender As Object, e As EventArgs) Handles examination_edit_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed")
        End Try
        If examination_id_txt.Text.ToString() IsNot "" Then
            Dim update_query As String = "UPDATE [examination] SET name='" & examination_name_txt.Text & "' WHERE id='" & examination_id_txt.Text & "'"
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
End Class