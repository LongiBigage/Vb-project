<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.resultView = New System.Windows.Forms.DataGridView()
        Me.student_fill_data_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.student_examination_combo = New System.Windows.Forms.ComboBox()
        Me.ExaminationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExaminationDataSet = New SchoolWinApp.examinationDataSet()
        Me.student_id_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.student_course_combo = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseDataSet = New SchoolWinApp.courseDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.student_year_combo = New System.Windows.Forms.ComboBox()
        Me.StudyyearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudyYearDataSet = New SchoolWinApp.studyYearDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.student_level_combo = New System.Windows.Forms.ComboBox()
        Me.LevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentLevelDataSet = New SchoolWinApp.studentLevelDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CourseTableAdapter = New SchoolWinApp.courseDataSetTableAdapters.courseTableAdapter()
        Me.Study_yearTableAdapter = New SchoolWinApp.studyYearDataSetTableAdapters.study_yearTableAdapter()
        Me.ExaminationTableAdapter = New SchoolWinApp.examinationDataSetTableAdapters.examinationTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.student_subject_combo = New System.Windows.Forms.ComboBox()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectDataSet = New SchoolWinApp.subjectDataSet()
        Me.SubjectTableAdapter = New SchoolWinApp.subjectDataSetTableAdapters.subjectTableAdapter()
        Me.LevelTableAdapter = New SchoolWinApp.studentLevelDataSetTableAdapters.levelTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.student_sid_record_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.student_first_name_record_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.student_last_name_record_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.student_year_record_txt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.student_level_record_txt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.student_course_record_txt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.student_examination_record_txt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.student_marks_record_txt = New System.Windows.Forms.TextBox()
        Me.student_save_record_btn = New System.Windows.Forms.Button()
        CType(Me.resultView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExaminationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExaminationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudyyearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudyYearDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentLevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'resultView
        '
        Me.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultView.Location = New System.Drawing.Point(5, 289)
        Me.resultView.Name = "resultView"
        Me.resultView.Size = New System.Drawing.Size(825, 227)
        Me.resultView.TabIndex = 0
        '
        'student_fill_data_btn
        '
        Me.student_fill_data_btn.Location = New System.Drawing.Point(753, 145)
        Me.student_fill_data_btn.Name = "student_fill_data_btn"
        Me.student_fill_data_btn.Size = New System.Drawing.Size(77, 23)
        Me.student_fill_data_btn.TabIndex = 2
        Me.student_fill_data_btn.Text = "Fill"
        Me.student_fill_data_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(743, 522)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'student_examination_combo
        '
        Me.student_examination_combo.DataSource = Me.ExaminationBindingSource
        Me.student_examination_combo.DisplayMember = "name"
        Me.student_examination_combo.FormattingEnabled = True
        Me.student_examination_combo.Location = New System.Drawing.Point(573, 145)
        Me.student_examination_combo.Name = "student_examination_combo"
        Me.student_examination_combo.Size = New System.Drawing.Size(174, 21)
        Me.student_examination_combo.TabIndex = 4
        Me.student_examination_combo.ValueMember = "id"
        '
        'ExaminationBindingSource
        '
        Me.ExaminationBindingSource.DataMember = "examination"
        Me.ExaminationBindingSource.DataSource = Me.ExaminationDataSet
        '
        'ExaminationDataSet
        '
        Me.ExaminationDataSet.DataSetName = "examinationDataSet"
        Me.ExaminationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'student_id_txt
        '
        Me.student_id_txt.Location = New System.Drawing.Point(12, 145)
        Me.student_id_txt.Name = "student_id_txt"
        Me.student_id_txt.Size = New System.Drawing.Size(105, 20)
        Me.student_id_txt.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(628, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Examination"
        '
        'student_course_combo
        '
        Me.student_course_combo.DataSource = Me.CourseBindingSource
        Me.student_course_combo.DisplayMember = "name"
        Me.student_course_combo.FormattingEnabled = True
        Me.student_course_combo.Location = New System.Drawing.Point(142, 144)
        Me.student_course_combo.Name = "student_course_combo"
        Me.student_course_combo.Size = New System.Drawing.Size(145, 21)
        Me.student_course_combo.TabIndex = 8
        Me.student_course_combo.ValueMember = "id"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "course"
        Me.CourseBindingSource.DataSource = Me.CourseDataSet
        '
        'CourseDataSet
        '
        Me.CourseDataSet.DataSetName = "courseDataSet"
        Me.CourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Course"
        '
        'student_year_combo
        '
        Me.student_year_combo.DataSource = Me.StudyyearBindingSource
        Me.student_year_combo.DisplayMember = "name"
        Me.student_year_combo.FormattingEnabled = True
        Me.student_year_combo.Location = New System.Drawing.Point(439, 145)
        Me.student_year_combo.Name = "student_year_combo"
        Me.student_year_combo.Size = New System.Drawing.Size(121, 21)
        Me.student_year_combo.TabIndex = 10
        Me.student_year_combo.ValueMember = "id"
        '
        'StudyyearBindingSource
        '
        Me.StudyyearBindingSource.DataMember = "study_year"
        Me.StudyyearBindingSource.DataSource = Me.StudyYearDataSet
        '
        'StudyYearDataSet
        '
        Me.StudyYearDataSet.DataSetName = "studyYearDataSet"
        Me.StudyYearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(467, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Study Year"
        '
        'student_level_combo
        '
        Me.student_level_combo.DataSource = Me.LevelBindingSource
        Me.student_level_combo.DisplayMember = "name"
        Me.student_level_combo.FormattingEnabled = True
        Me.student_level_combo.Location = New System.Drawing.Point(296, 86)
        Me.student_level_combo.Name = "student_level_combo"
        Me.student_level_combo.Size = New System.Drawing.Size(230, 21)
        Me.student_level_combo.TabIndex = 12
        Me.student_level_combo.ValueMember = "id"
        '
        'LevelBindingSource
        '
        Me.LevelBindingSource.DataMember = "level"
        Me.LevelBindingSource.DataSource = Me.StudentLevelDataSet
        '
        'StudentLevelDataSet
        '
        Me.StudentLevelDataSet.DataSetName = "studentLevelDataSet"
        Me.StudentLevelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Level of Study"
        '
        'logout_btn
        '
        Me.logout_btn.Location = New System.Drawing.Point(753, 18)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.logout_btn.TabIndex = 14
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(418, 28)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Students Examination Marks Management"
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'Study_yearTableAdapter
        '
        Me.Study_yearTableAdapter.ClearBeforeFill = True
        '
        'ExaminationTableAdapter
        '
        Me.ExaminationTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Subject"
        '
        'student_subject_combo
        '
        Me.student_subject_combo.DataSource = Me.SubjectBindingSource
        Me.student_subject_combo.DisplayMember = "name"
        Me.student_subject_combo.FormattingEnabled = True
        Me.student_subject_combo.Location = New System.Drawing.Point(296, 145)
        Me.student_subject_combo.Name = "student_subject_combo"
        Me.student_subject_combo.Size = New System.Drawing.Size(137, 21)
        Me.student_subject_combo.TabIndex = 17
        Me.student_subject_combo.ValueMember = "id"
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "subject"
        Me.SubjectBindingSource.DataSource = Me.SubjectDataSet
        '
        'SubjectDataSet
        '
        Me.SubjectDataSet.DataSetName = "subjectDataSet"
        Me.SubjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'LevelTableAdapter
        '
        Me.LevelTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.student_save_record_btn)
        Me.Panel1.Controls.Add(Me.student_marks_record_txt)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.student_examination_record_txt)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.student_course_record_txt)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.student_level_record_txt)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.student_year_record_txt)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.student_last_name_record_txt)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.student_first_name_record_txt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.student_sid_record_txt)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 112)
        Me.Panel1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "SID"
        '
        'student_sid_record_txt
        '
        Me.student_sid_record_txt.Location = New System.Drawing.Point(15, 27)
        Me.student_sid_record_txt.Name = "student_sid_record_txt"
        Me.student_sid_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_sid_record_txt.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "FIRST NAME"
        '
        'student_first_name_record_txt
        '
        Me.student_first_name_record_txt.Location = New System.Drawing.Point(148, 27)
        Me.student_first_name_record_txt.Name = "student_first_name_record_txt"
        Me.student_first_name_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_first_name_record_txt.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(298, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "LAST NAME"
        '
        'student_last_name_record_txt
        '
        Me.student_last_name_record_txt.Location = New System.Drawing.Point(284, 27)
        Me.student_last_name_record_txt.Name = "student_last_name_record_txt"
        Me.student_last_name_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_last_name_record_txt.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(512, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "YEAR"
        '
        'student_year_record_txt
        '
        Me.student_year_record_txt.Location = New System.Drawing.Point(481, 27)
        Me.student_year_record_txt.Name = "student_year_record_txt"
        Me.student_year_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_year_record_txt.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(685, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "LEVEL"
        '
        'student_level_record_txt
        '
        Me.student_level_record_txt.Location = New System.Drawing.Point(650, 27)
        Me.student_level_record_txt.Name = "student_level_record_txt"
        Me.student_level_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_level_record_txt.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(157, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "COURSE"
        '
        'student_course_record_txt
        '
        Me.student_course_record_txt.Location = New System.Drawing.Point(95, 80)
        Me.student_course_record_txt.Name = "student_course_record_txt"
        Me.student_course_record_txt.Size = New System.Drawing.Size(167, 20)
        Me.student_course_record_txt.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(312, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "EXAMINATION"
        '
        'student_examination_record_txt
        '
        Me.student_examination_record_txt.Location = New System.Drawing.Point(295, 80)
        Me.student_examination_record_txt.Name = "student_examination_record_txt"
        Me.student_examination_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_examination_record_txt.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(550, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "MARKS"
        '
        'student_marks_record_txt
        '
        Me.student_marks_record_txt.Location = New System.Drawing.Point(515, 77)
        Me.student_marks_record_txt.Name = "student_marks_record_txt"
        Me.student_marks_record_txt.Size = New System.Drawing.Size(114, 20)
        Me.student_marks_record_txt.TabIndex = 1
        '
        'student_save_record_btn
        '
        Me.student_save_record_btn.Location = New System.Drawing.Point(702, 64)
        Me.student_save_record_btn.Name = "student_save_record_btn"
        Me.student_save_record_btn.Size = New System.Drawing.Size(75, 45)
        Me.student_save_record_btn.TabIndex = 2
        Me.student_save_record_btn.Text = "SAVE"
        Me.student_save_record_btn.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(840, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.student_subject_combo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.student_level_combo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.student_year_combo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.student_course_combo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.student_id_txt)
        Me.Controls.Add(Me.student_examination_combo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.student_fill_data_btn)
        Me.Controls.Add(Me.resultView)
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        CType(Me.resultView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExaminationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExaminationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudyyearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudyYearDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentLevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultView As DataGridView
    Friend WithEvents student_fill_data_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents student_examination_combo As ComboBox
    Friend WithEvents student_id_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents student_course_combo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents student_year_combo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents student_level_combo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents logout_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CourseDataSet As courseDataSet
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As courseDataSetTableAdapters.courseTableAdapter
    Friend WithEvents StudyYearDataSet As studyYearDataSet
    Friend WithEvents StudyyearBindingSource As BindingSource
    Friend WithEvents Study_yearTableAdapter As studyYearDataSetTableAdapters.study_yearTableAdapter
    Friend WithEvents ExaminationDataSet As examinationDataSet
    Friend WithEvents ExaminationBindingSource As BindingSource
    Friend WithEvents ExaminationTableAdapter As examinationDataSetTableAdapters.examinationTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents student_subject_combo As ComboBox
    Friend WithEvents SubjectDataSet As subjectDataSet
    Friend WithEvents SubjectBindingSource As BindingSource
    Friend WithEvents SubjectTableAdapter As subjectDataSetTableAdapters.subjectTableAdapter
    Friend WithEvents StudentLevelDataSet As studentLevelDataSet
    Friend WithEvents LevelBindingSource As BindingSource
    Friend WithEvents LevelTableAdapter As studentLevelDataSetTableAdapters.levelTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents student_first_name_record_txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents student_sid_record_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents student_save_record_btn As Button
    Friend WithEvents student_marks_record_txt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents student_examination_record_txt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents student_course_record_txt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents student_level_record_txt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents student_year_record_txt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents student_last_name_record_txt As TextBox
    Friend WithEvents Label10 As Label
End Class
