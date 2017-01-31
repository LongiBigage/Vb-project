Imports System.Data.SqlClient
Imports System.Data

Public Class courses
    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub course_close_btn_Click(sender As Object, e As EventArgs) Handles course_close_btn.Click
        home.Show()
        Hide()
    End Sub

    Private Sub course_add_btn_Click(sender As Object, e As EventArgs) Handles course_add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=True;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn
        If course_id_txt.Text IsNot "" And course_name_txt.Text IsNot "" And course_code_txt.Text IsNot "" Then
            comm.CommandText = "INSERT INTO course([name],[code]) VALUES('" & course_name_txt.Text & "','" & course_code_txt.Text & "')"
            Dim comm1 As SqlCommand = New SqlCommand()
            comm1.Connection = conn
            comm1.CommandText = "SELECT * FROM [course] WHERE name='" & course_name_txt.Text & "' AND code='" & course_code_txt.Text & "'"
            Try
                Dim total_present As Integer = comm1.ExecuteNonQuery()
                If total_present > 0 Then
                    MessageBox.Show("Duplicate Records Not Allowed")
                Else
                    Dim created As Integer = comm.ExecuteNonQuery()
                    If created > 0 Then
                        MessageBox.Show("Course Created")
                    Else
                        MessageBox.Show("Failed to Add New Course, Please Try again")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            comm1.Dispose()
            comm1 = Nothing
            comm.Dispose()
            comm = Nothing
            conn.Close()
        Else
            MessageBox.Show("Please Fill all Fields")
        End If
    End Sub

    Private Sub course_refresh_btn_Click(sender As Object, e As EventArgs) Handles course_refresh_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as COURSE_ID, name as COURSE_NAME, code as COURSE_CODE FROM [course]"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "student")
        coursesView.DataSource = ds.Tables(0)
        conn.Close()
        conn = Nothing
    End Sub

    Private Sub courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        course_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as COURSE_ID, name as COURSE_NAME,code AS COURSE_CODE FROM [course]"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "student")
        coursesView.DataSource = ds.Tables(0)
        conn.Close()
        conn = Nothing
    End Sub


    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles coursesView.CellClick
        Dim i As Integer
        i = coursesView.CurrentRow.Index
        If coursesView.Item(0, i).Value.ToString() IsNot "" Then
            course_id_txt.Text = coursesView.Item(0, i).Value
            course_name_txt.Text = coursesView.Item(1, i).Value
            course_code_txt.Text = coursesView.Item(2, i).Value
        Else
            MessageBox.Show("Select Row with Data")
        End If

    End Sub

    Private Sub course_delete_btn_Click(sender As Object, e As EventArgs) Handles course_delete_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn

        If coursesView.SelectedRows.Count > 0 Or course_id_txt.Text.ToString() IsNot "" Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim delete_query As String = "DELETE FROM [course] WHERE id = '" & course_id_txt.Text & "'"
            comm.CommandText = delete_query
            Dim deleted As Integer = comm.ExecuteNonQuery()
            coursesView.Rows.Remove(coursesView.SelectedRows(0))

            course_id_txt.Clear()
            course_name_txt.Clear()
            course_code_txt.Clear()

            MessageBox.Show("Data Delete!!")
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub course_clear_btn_Click(sender As Object, e As EventArgs) Handles course_clear_btn.Click
        course_id_txt.Clear()
        course_name_txt.Clear()
        course_code_txt.Clear()
    End Sub

    Private Sub course_edit_btn_Click(sender As Object, e As EventArgs) Handles course_edit_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed")
        End Try
        If course_id_txt.Text.ToString() IsNot "" Then
            Dim update_query As String = "UPDATE [course] SET name='" & course_name_txt.Text & "', code='" & course_code_txt.Text & "' WHERE id='" & course_id_txt.Text & "'"
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
            MessageBox.Show("Course ID is Required")
        End If
    End Sub
End Class