<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.manage_student_btn = New System.Windows.Forms.Button()
        Me.manage_students_exams_btn = New System.Windows.Forms.Button()
        Me.home_label = New System.Windows.Forms.Label()
        Me.manage_courses_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.manage_study_year_btn = New System.Windows.Forms.Button()
        Me.manage_subject_btn = New System.Windows.Forms.Button()
        Me.manage_examination_btn = New System.Windows.Forms.Button()
        Me.manage_study_level_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Teachers Marks Tool"
        '
        'manage_student_btn
        '
        Me.manage_student_btn.Location = New System.Drawing.Point(57, 140)
        Me.manage_student_btn.Name = "manage_student_btn"
        Me.manage_student_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_student_btn.TabIndex = 1
        Me.manage_student_btn.Text = "Manage Students"
        Me.manage_student_btn.UseVisualStyleBackColor = True
        '
        'manage_students_exams_btn
        '
        Me.manage_students_exams_btn.Location = New System.Drawing.Point(282, 140)
        Me.manage_students_exams_btn.Name = "manage_students_exams_btn"
        Me.manage_students_exams_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_students_exams_btn.TabIndex = 1
        Me.manage_students_exams_btn.Text = "Manage Students Exams"
        Me.manage_students_exams_btn.UseVisualStyleBackColor = True
        '
        'home_label
        '
        Me.home_label.AutoSize = True
        Me.home_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_label.Location = New System.Drawing.Point(315, 19)
        Me.home_label.Name = "home_label"
        Me.home_label.Size = New System.Drawing.Size(0, 25)
        Me.home_label.TabIndex = 2
        '
        'manage_courses_btn
        '
        Me.manage_courses_btn.Location = New System.Drawing.Point(493, 140)
        Me.manage_courses_btn.Name = "manage_courses_btn"
        Me.manage_courses_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_courses_btn.TabIndex = 1
        Me.manage_courses_btn.Text = "Manage Courses"
        Me.manage_courses_btn.UseVisualStyleBackColor = True
        '
        'logout_btn
        '
        Me.logout_btn.Location = New System.Drawing.Point(808, 12)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.logout_btn.TabIndex = 3
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'manage_study_year_btn
        '
        Me.manage_study_year_btn.Location = New System.Drawing.Point(57, 272)
        Me.manage_study_year_btn.Name = "manage_study_year_btn"
        Me.manage_study_year_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_study_year_btn.TabIndex = 1
        Me.manage_study_year_btn.Text = "Manage Study Years"
        Me.manage_study_year_btn.UseVisualStyleBackColor = True
        '
        'manage_subject_btn
        '
        Me.manage_subject_btn.Location = New System.Drawing.Point(282, 272)
        Me.manage_subject_btn.Name = "manage_subject_btn"
        Me.manage_subject_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_subject_btn.TabIndex = 1
        Me.manage_subject_btn.Text = "Manage Subjects"
        Me.manage_subject_btn.UseVisualStyleBackColor = True
        '
        'manage_examination_btn
        '
        Me.manage_examination_btn.Location = New System.Drawing.Point(493, 272)
        Me.manage_examination_btn.Name = "manage_examination_btn"
        Me.manage_examination_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_examination_btn.TabIndex = 1
        Me.manage_examination_btn.Text = "Manage Examination"
        Me.manage_examination_btn.UseVisualStyleBackColor = True
        '
        'manage_study_level_btn
        '
        Me.manage_study_level_btn.Location = New System.Drawing.Point(706, 140)
        Me.manage_study_level_btn.Name = "manage_study_level_btn"
        Me.manage_study_level_btn.Size = New System.Drawing.Size(177, 113)
        Me.manage_study_level_btn.TabIndex = 1
        Me.manage_study_level_btn.Text = "Manage Study Levels"
        Me.manage_study_level_btn.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 437)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.home_label)
        Me.Controls.Add(Me.manage_examination_btn)
        Me.Controls.Add(Me.manage_study_level_btn)
        Me.Controls.Add(Me.manage_courses_btn)
        Me.Controls.Add(Me.manage_subject_btn)
        Me.Controls.Add(Me.manage_students_exams_btn)
        Me.Controls.Add(Me.manage_study_year_btn)
        Me.Controls.Add(Me.manage_student_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents manage_student_btn As Button
    Friend WithEvents manage_students_exams_btn As Button
    Friend WithEvents home_label As Label
    Friend WithEvents manage_courses_btn As Button
    Friend WithEvents logout_btn As Button
    Friend WithEvents manage_study_year_btn As Button
    Friend WithEvents manage_subject_btn As Button
    Friend WithEvents manage_examination_btn As Button
    Friend WithEvents manage_study_level_btn As Button
End Class
