Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        home_label.Text = "Welcome: " & LoginForm.username_tb.Text
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub manage_student_btn_Click(sender As Object, e As EventArgs) Handles manage_student_btn.Click
        Teacher.Show()
        Hide()
    End Sub

    Private Sub manage_students_exams_btn_Click(sender As Object, e As EventArgs) Handles manage_students_exams_btn.Click
        Student.Show()
        Hide()
    End Sub

    Private Sub manage_courses_btn_Click(sender As Object, e As EventArgs) Handles manage_courses_btn.Click
        courses.Show()
        Hide()
    End Sub


    Private Sub manage_levels_btn_Click(sender As Object, e As EventArgs) Handles manage_study_level_btn.Click
        level.Show()
        Hide()
    End Sub

    Private Sub manage_study_year_btn_Click(sender As Object, e As EventArgs) Handles manage_study_year_btn.Click
        studyyear.Show()
        Hide()
    End Sub

    Private Sub manage_subject_btn_Click(sender As Object, e As EventArgs) Handles manage_subject_btn.Click
        subject.Show()
        Hide()
    End Sub

    Private Sub manage_examination_btn_Click(sender As Object, e As EventArgs) Handles manage_examination_btn.Click
        examination.Show()
        Hide()
    End Sub
End Class