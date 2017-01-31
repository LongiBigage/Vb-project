<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Me.components = New System.ComponentModel.Container()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.sgender = New System.Windows.Forms.ComboBox()
        Me.sphone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.saddress = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.s_add_btn = New System.Windows.Forms.Button()
        Me.s_edit_btn = New System.Windows.Forms.Button()
        Me.s_delete_btn = New System.Windows.Forms.Button()
        Me.s_clear_btn = New System.Windows.Forms.Button()
        Me.s_close_btn = New System.Windows.Forms.Button()
        Me.studentView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.add_status = New System.Windows.Forms.Label()
        Me.student_refresh_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.teacher_study_year = New System.Windows.Forms.ComboBox()
        Me.StudyyearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherStudyYearDataSet = New SchoolWinApp.teacherStudyYearDataSet()
        Me.teacher_study_course = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherCourseDataSet = New SchoolWinApp.teacherCourseDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.teacher_study_level = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Study_yearTableAdapter = New SchoolWinApp.teacherStudyYearDataSetTableAdapters.study_yearTableAdapter()
        Me.CourseTableAdapter = New SchoolWinApp.teacherCourseDataSetTableAdapters.courseTableAdapter()
        Me.TeacherLevelDataSet = New SchoolWinApp.teacherLevelDataSet()
        Me.LevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LevelTableAdapter = New SchoolWinApp.teacherLevelDataSetTableAdapters.levelTableAdapter()
        CType(Me.studentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudyyearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherStudyYearDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherCourseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherLevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(139, 45)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(213, 20)
        Me.sid.TabIndex = 2
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(139, 72)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(280, 20)
        Me.fname.TabIndex = 3
        '
        'sgender
        '
        Me.sgender.FormattingEnabled = True
        Me.sgender.Items.AddRange(New Object() {"Female", "Male"})
        Me.sgender.Location = New System.Drawing.Point(139, 131)
        Me.sgender.Name = "sgender"
        Me.sgender.Size = New System.Drawing.Size(121, 21)
        Me.sgender.TabIndex = 4
        '
        'sphone
        '
        Me.sphone.Location = New System.Drawing.Point(139, 158)
        Me.sphone.Name = "sphone"
        Me.sphone.Size = New System.Drawing.Size(213, 20)
        Me.sphone.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Phone"
        '
        'saddress
        '
        Me.saddress.Location = New System.Drawing.Point(139, 195)
        Me.saddress.Name = "saddress"
        Me.saddress.Size = New System.Drawing.Size(280, 72)
        Me.saddress.TabIndex = 11
        Me.saddress.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address"
        '
        's_add_btn
        '
        Me.s_add_btn.Location = New System.Drawing.Point(864, 35)
        Me.s_add_btn.Name = "s_add_btn"
        Me.s_add_btn.Size = New System.Drawing.Size(75, 23)
        Me.s_add_btn.TabIndex = 12
        Me.s_add_btn.Text = "Add"
        Me.s_add_btn.UseVisualStyleBackColor = True
        '
        's_edit_btn
        '
        Me.s_edit_btn.Location = New System.Drawing.Point(864, 69)
        Me.s_edit_btn.Name = "s_edit_btn"
        Me.s_edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.s_edit_btn.TabIndex = 12
        Me.s_edit_btn.Text = "Edit"
        Me.s_edit_btn.UseVisualStyleBackColor = True
        '
        's_delete_btn
        '
        Me.s_delete_btn.Location = New System.Drawing.Point(864, 98)
        Me.s_delete_btn.Name = "s_delete_btn"
        Me.s_delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.s_delete_btn.TabIndex = 12
        Me.s_delete_btn.Text = "Delete"
        Me.s_delete_btn.UseVisualStyleBackColor = True
        '
        's_clear_btn
        '
        Me.s_clear_btn.Location = New System.Drawing.Point(864, 127)
        Me.s_clear_btn.Name = "s_clear_btn"
        Me.s_clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.s_clear_btn.TabIndex = 12
        Me.s_clear_btn.Text = "Clear"
        Me.s_clear_btn.UseVisualStyleBackColor = True
        '
        's_close_btn
        '
        Me.s_close_btn.Location = New System.Drawing.Point(864, 160)
        Me.s_close_btn.Name = "s_close_btn"
        Me.s_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.s_close_btn.TabIndex = 12
        Me.s_close_btn.Text = "Close"
        Me.s_close_btn.UseVisualStyleBackColor = True
        '
        'studentView
        '
        Me.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentView.Location = New System.Drawing.Point(80, 300)
        Me.studentView.Name = "studentView"
        Me.studentView.Size = New System.Drawing.Size(825, 150)
        Me.studentView.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(57, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Students List"
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(139, 98)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(280, 20)
        Me.lname.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "First Name"
        '
        'add_status
        '
        Me.add_status.AutoSize = True
        Me.add_status.Location = New System.Drawing.Point(769, 44)
        Me.add_status.Name = "add_status"
        Me.add_status.Size = New System.Drawing.Size(0, 13)
        Me.add_status.TabIndex = 14
        '
        'student_refresh_btn
        '
        Me.student_refresh_btn.Location = New System.Drawing.Point(864, 271)
        Me.student_refresh_btn.Name = "student_refresh_btn"
        Me.student_refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.student_refresh_btn.TabIndex = 15
        Me.student_refresh_btn.Text = "Refresh"
        Me.student_refresh_btn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(501, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Study Year"
        '
        'teacher_study_year
        '
        Me.teacher_study_year.DataSource = Me.StudyyearBindingSource
        Me.teacher_study_year.DisplayMember = "name"
        Me.teacher_study_year.FormattingEnabled = True
        Me.teacher_study_year.Location = New System.Drawing.Point(566, 45)
        Me.teacher_study_year.Name = "teacher_study_year"
        Me.teacher_study_year.Size = New System.Drawing.Size(173, 21)
        Me.teacher_study_year.TabIndex = 17
        Me.teacher_study_year.ValueMember = "id"
        '
        'StudyyearBindingSource
        '
        Me.StudyyearBindingSource.DataMember = "study_year"
        Me.StudyyearBindingSource.DataSource = Me.TeacherStudyYearDataSet
        '
        'TeacherStudyYearDataSet
        '
        Me.TeacherStudyYearDataSet.DataSetName = "teacherStudyYearDataSet"
        Me.TeacherStudyYearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'teacher_study_course
        '
        Me.teacher_study_course.DataSource = Me.CourseBindingSource
        Me.teacher_study_course.DisplayMember = "name"
        Me.teacher_study_course.FormattingEnabled = True
        Me.teacher_study_course.Location = New System.Drawing.Point(566, 127)
        Me.teacher_study_course.Name = "teacher_study_course"
        Me.teacher_study_course.Size = New System.Drawing.Size(241, 21)
        Me.teacher_study_course.TabIndex = 17
        Me.teacher_study_course.ValueMember = "id"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "course"
        Me.CourseBindingSource.DataSource = Me.TeacherCourseDataSet
        '
        'TeacherCourseDataSet
        '
        Me.TeacherCourseDataSet.DataSetName = "teacherCourseDataSet"
        Me.TeacherCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(492, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Study Course"
        '
        'teacher_study_level
        '
        Me.teacher_study_level.DataSource = Me.LevelBindingSource
        Me.teacher_study_level.DisplayMember = "name"
        Me.teacher_study_level.FormattingEnabled = True
        Me.teacher_study_level.Location = New System.Drawing.Point(566, 89)
        Me.teacher_study_level.Name = "teacher_study_level"
        Me.teacher_study_level.Size = New System.Drawing.Size(241, 21)
        Me.teacher_study_level.TabIndex = 18
        Me.teacher_study_level.ValueMember = "id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(501, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Study Level"
        '
        'logout_btn
        '
        Me.logout_btn.Location = New System.Drawing.Point(864, 1)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.logout_btn.TabIndex = 19
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(391, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Student Management "
        '
        'Study_yearTableAdapter
        '
        Me.Study_yearTableAdapter.ClearBeforeFill = True
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'TeacherLevelDataSet
        '
        Me.TeacherLevelDataSet.DataSetName = "teacherLevelDataSet"
        Me.TeacherLevelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LevelBindingSource
        '
        Me.LevelBindingSource.DataMember = "level"
        Me.LevelBindingSource.DataSource = Me.TeacherLevelDataSet
        '
        'LevelTableAdapter
        '
        Me.LevelTableAdapter.ClearBeforeFill = True
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(955, 473)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.teacher_study_level)
        Me.Controls.Add(Me.teacher_study_course)
        Me.Controls.Add(Me.teacher_study_year)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.student_refresh_btn)
        Me.Controls.Add(Me.add_status)
        Me.Controls.Add(Me.studentView)
        Me.Controls.Add(Me.s_close_btn)
        Me.Controls.Add(Me.s_clear_btn)
        Me.Controls.Add(Me.s_delete_btn)
        Me.Controls.Add(Me.s_edit_btn)
        Me.Controls.Add(Me.s_add_btn)
        Me.Controls.Add(Me.saddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sphone)
        Me.Controls.Add(Me.sgender)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.sid)
        Me.Name = "Teacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        CType(Me.studentView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudyyearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherStudyYearDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherCourseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherLevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sid As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents sgender As ComboBox
    Friend WithEvents sphone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents saddress As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents s_add_btn As Button
    Friend WithEvents s_edit_btn As Button
    Friend WithEvents s_delete_btn As Button
    Friend WithEvents s_clear_btn As Button
    Friend WithEvents s_close_btn As Button
    Friend WithEvents studentView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents add_status As Label
    Friend WithEvents student_refresh_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents teacher_study_year As ComboBox
    Friend WithEvents teacher_study_course As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents teacher_study_level As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents logout_btn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TeacherStudyYearDataSet As teacherStudyYearDataSet
    Friend WithEvents StudyyearBindingSource As BindingSource
    Friend WithEvents Study_yearTableAdapter As teacherStudyYearDataSetTableAdapters.study_yearTableAdapter
    Friend WithEvents TeacherCourseDataSet As teacherCourseDataSet
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As teacherCourseDataSetTableAdapters.courseTableAdapter
    Friend WithEvents TeacherLevelDataSet As teacherLevelDataSet
    Friend WithEvents LevelBindingSource As BindingSource
    Friend WithEvents LevelTableAdapter As teacherLevelDataSetTableAdapters.levelTableAdapter
End Class
