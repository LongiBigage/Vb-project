Imports System.Data.SqlClient
Imports System.Data

Public Class Student
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        student_sid_record_txt.Enabled = False
        student_first_name_record_txt.Enabled = False
        student_last_name_record_txt.Enabled = False
        student_year_record_txt.Enabled = False
        student_level_record_txt.Enabled = False
        student_examination_record_txt.Enabled = False
        student_course_record_txt.Enabled = False
        'TODO: This line of code loads data into the 'StudentLevelDataSet.level' table. You can move, or remove it, as needed.
        Me.LevelTableAdapter.Fill(Me.StudentLevelDataSet.level)
        'TODO: This line of code loads data into the 'SubjectDataSet.subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.SubjectDataSet.subject)
        'TODO: This line of code loads data into the 'ExaminationDataSet.examination' table. You can move, or remove it, as needed.
        Me.ExaminationTableAdapter.Fill(Me.ExaminationDataSet.examination)
        'TODO: This line of code loads data into the 'StudyYearDataSet.study_year' table. You can move, or remove it, as needed.
        Me.Study_yearTableAdapter.Fill(Me.StudyYearDataSet.study_year)
        'TODO: This line of code loads data into the 'CourseDataSet.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.CourseDataSet.course)
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT s.sid AS SID,s.first_name AS FIRST_NAME,s.last_name AS LAST_NAME,sy.name as YEAR,l.name as LEVEL, c.name as COURSE,e.eid AS EXAMINATION, se.marks AS MARKS FROM student s LEFT JOIN student_exam se ON se.sid=s.sid LEFT JOIN exam e ON se.eid=e.eid LEFT JOIN study_year sy ON s.year=sy.id LEFT JOIN level l ON s.level=l.id LEFT JOIN course c ON c.id=s.course"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "student")
        resultView.DataSource = ds.Tables(0)
        conn.Close()
        conn = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Hide()
    End Sub


    Private Sub DataGridView_CellChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles resultView.CellValueChanged
        Dim i As Integer
        i = resultView.CurrentRow.Index
        If resultView.Item(3, i).Value.ToString() IsNot "" Then
            MessageBox.Show("Updating data")
        Else
            Hide()
        End If
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles student_id_txt.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles student_first_name_record_txt.TextChanged, student_marks_record_txt.TextChanged, student_examination_record_txt.TextChanged, student_course_record_txt.TextChanged, student_level_record_txt.TextChanged, student_year_record_txt.TextChanged, student_last_name_record_txt.TextChanged

    End Sub


    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles resultView.CellClick
        Dim i As Integer
        i = resultView.CurrentRow.Index
        student_sid_record_txt.Text = resultView.Item(0, i).Value
        student_first_name_record_txt.Text = resultView.Item(1, i).Value
        student_last_name_record_txt.Text = resultView.Item(2, i).Value
        If resultView.Item(3, i).Value.ToString IsNot "" And resultView.Item(4, i).Value.ToString IsNot "" And resultView.Item(5, i).Value.ToString IsNot "" Then
            student_year_record_txt.Text = resultView.Item(3, i).Value
            student_level_record_txt.Text = resultView.Item(4, i).Value
            student_course_record_txt.Text = resultView.Item(5, i).Value
        End If

        If resultView.Item(6, i).Value.ToString IsNot "" Then
            student_examination_record_txt.Text = resultView.Item(6, i).Value
        End If

        If resultView.Item(7, i).Value.ToString IsNot "" Then
            student_marks_record_txt.Text = resultView.Item(7, i).Value
        End If

    End Sub
End Class