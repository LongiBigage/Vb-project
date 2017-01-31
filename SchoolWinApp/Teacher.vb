Imports System.Data.SqlClient
Imports System.Data


Public Class Teacher
    Private Sub s_close_btn_Click(sender As Object, e As EventArgs) Handles s_close_btn.Click
        home.Show()
        Hide()
    End Sub

    Private Sub s_clear_btn_Click(sender As Object, e As EventArgs) Handles s_clear_btn.Click
        'CLEAR DATA ON TEXTBOXES ON INTERFACE
        sid.Clear()
        fname.Clear()
        lname.Clear()
        sphone.Clear()
        saddress.Clear()
        sgender.Text = ""
    End Sub

    Private Sub s_add_btn_Click(sender As Object, e As EventArgs) Handles s_add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        Dim sid_f As String = sid.Text
        Dim fname_f As String = fname.Text
        Dim lname_f As String = lname.Text
        Dim sgender_f As String = sgender.Text
        Dim sphone_f As String = sphone.Text
        Dim saddress_f As String = saddress.Text
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn

        Dim add_query As String = "INSERT INTO student([sid],[first_name],[last_name],[gender],[phone],[address],[year],[level],[course]) VALUES ('" & sid.Text & "','" & fname.Text & "','" & lname.Text & "','" & sgender.Text & "','" & sphone.Text & "','" & saddress.Text & "','" & teacher_study_year.SelectedValue & "','" & teacher_study_level.SelectedValue & "','" & teacher_study_course.SelectedValue & "')"
        comm.CommandText = add_query
        Dim sdata As Integer = comm.ExecuteNonQuery()
        If sdata > 0 Then
            add_status.Text = "Saved"
            add_status.ForeColor = Color.Green
        Else
            add_status.Text = "Failed"
            add_status.ForeColor = Color.Red
        End If

        Dim student_query = "SELECT * FROM [student]"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "student")
        studentView.DataSource = ds.Tables()
        'comm.Dispose()
        'conn.Close()
    End Sub

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeacherLevelDataSet.level' table. You can move, or remove it, as needed.
        Me.LevelTableAdapter.Fill(Me.TeacherLevelDataSet.level)
        'TODO: This line of code loads data into the 'TeacherCourseDataSet.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.TeacherCourseDataSet.course)
        'TODO: This line of code loads data into the 'TeacherStudyYearDataSet.study_year' table. You can move, or remove it, as needed.
        Me.Study_yearTableAdapter.Fill(Me.TeacherStudyYearDataSet.study_year)
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT s.sid as SID, s.first_name as FIRST_NAME, s.last_name as LAST_NAME, s.gender as GENDER, s.phone as PHONE, s.address as ADDRESS, l.name as LEVEL, c.name as COURSE, sy.name as YEAR FROM student s LEFT JOIN level l ON s.level=l.id LEFT JOIN course c ON s.course=c.id LEFT JOIN study_year sy ON s.year=sy.id"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "student")
        studentView.DataSource = ds.Tables(0)
        'conn.Close()
        'conn = Nothing
    End Sub

    Private Sub student_refresh_btn_Click(sender As Object, e As EventArgs) Handles student_refresh_btn.Click
        'TODO: This line of code loads data into the 'TeacherLevelDataSet.level' table. You can move, or remove it, as needed.
        Me.LevelTableAdapter.Fill(Me.TeacherLevelDataSet.level)
        'TODO: This line of code loads data into the 'TeacherCourseDataSet.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.TeacherCourseDataSet.course)
        'TODO: This line of code loads data into the 'TeacherStudyYearDataSet.study_year' table. You can move, or remove it, as needed.
        Me.Study_yearTableAdapter.Fill(Me.TeacherStudyYearDataSet.study_year)
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT s.sid as SID, s.first_name as FIRST_NAME, s.last_name as LAST_NAME, s.gender as GENDER, s.phone as PHONE, s.address as ADDRESS, l.name as LEVEL, c.name as COURSE, sy.name as YEAR FROM student s LEFT JOIN level l ON s.level=l.id LEFT JOIN course c ON s.course=c.id LEFT JOIN study_year sy ON s.year=sy.id"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "student")
        studentView.DataSource = ds.Tables(0)
        'conn.Close()
        'conn = Nothing
    End Sub

    Private Sub s_edit_btn_Click(sender As Object, e As EventArgs) Handles s_edit_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        If sid.Text IsNot "" Then
            Dim update_query As String = "UPDATE [student] SET sid='" & sid.Text & "', first_name='" & fname.Text & "', last_name='" & lname.Text & "', gender='" & sgender.Text & "', phone='" & sphone.Text & "', address='" & saddress.Text & "' WHERE sid='" & sid.Text & "'"
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = update_query
            Dim affected_row As Integer = comm.ExecuteNonQuery()
            If affected_row > 0 Then
                MessageBox.Show("Data Succcessfully Updated")
            Else
                MessageBox.Show("Failed to Update Data")
            End If
            comm.Dispose()
            comm = Nothing
            conn.Close()
        Else
            MessageBox.Show("Student ID is Required")
        End If
    End Sub


    Private Sub s_delete_btn_Click(sender As Object, e As EventArgs) Handles s_delete_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn



        If studentView.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim delete_query As String = "DELETE FROM [student] WHERE sid = '" & studentView.SelectedRows(0).Cells(0).Value & "'"
                comm.CommandText = delete_query
            Dim deleted As Integer = comm.ExecuteNonQuery()
            studentView.Rows.Remove(studentView.SelectedRows(0))
            MessageBox.Show("Data Delete!!")

        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If

    End Sub


    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles studentView.CellClick
        Dim i As Integer
        i = studentView.CurrentRow.Index
        sid.Enabled = False
        sid.Text = studentView.Item(0, i).Value
        fname.Text = studentView.Item(1, i).Value
        lname.Text = studentView.Item(2, i).Value
        sgender.Text = studentView.Item(3, i).Value
        sphone.Text = studentView.Item(4, i).Value
        saddress.Text = studentView.Item(5, i).Value
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub
End Class