<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class courses
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
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.course_name_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.course_code_txt = New System.Windows.Forms.TextBox()
        Me.course_clear_btn = New System.Windows.Forms.Button()
        Me.course_delete_btn = New System.Windows.Forms.Button()
        Me.course_add_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.course_edit_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.course_close_btn = New System.Windows.Forms.Button()
        Me.coursesView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.course_refresh_btn = New System.Windows.Forms.Button()
        Me.course_id_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.coursesView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Courses "
        '
        'logout_btn
        '
        Me.logout_btn.Location = New System.Drawing.Point(578, 12)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.logout_btn.TabIndex = 1
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course Name"
        '
        'course_name_txt
        '
        Me.course_name_txt.Location = New System.Drawing.Point(234, 105)
        Me.course_name_txt.Name = "course_name_txt"
        Me.course_name_txt.Size = New System.Drawing.Size(235, 20)
        Me.course_name_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course Code"
        '
        'course_code_txt
        '
        Me.course_code_txt.Location = New System.Drawing.Point(234, 149)
        Me.course_code_txt.Name = "course_code_txt"
        Me.course_code_txt.Size = New System.Drawing.Size(235, 20)
        Me.course_code_txt.TabIndex = 3
        '
        'course_clear_btn
        '
        Me.course_clear_btn.Location = New System.Drawing.Point(506, 160)
        Me.course_clear_btn.Name = "course_clear_btn"
        Me.course_clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.course_clear_btn.TabIndex = 5
        Me.course_clear_btn.Text = "Clear"
        Me.course_clear_btn.UseVisualStyleBackColor = True
        '
        'course_delete_btn
        '
        Me.course_delete_btn.Location = New System.Drawing.Point(506, 131)
        Me.course_delete_btn.Name = "course_delete_btn"
        Me.course_delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.course_delete_btn.TabIndex = 6
        Me.course_delete_btn.Text = "Delete"
        Me.course_delete_btn.UseVisualStyleBackColor = True
        '
        'course_add_btn
        '
        Me.course_add_btn.Location = New System.Drawing.Point(506, 69)
        Me.course_add_btn.Name = "course_add_btn"
        Me.course_add_btn.Size = New System.Drawing.Size(75, 23)
        Me.course_add_btn.TabIndex = 4
        Me.course_add_btn.Text = "Add"
        Me.course_add_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(748, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'course_edit_btn
        '
        Me.course_edit_btn.Location = New System.Drawing.Point(506, 99)
        Me.course_edit_btn.Name = "course_edit_btn"
        Me.course_edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.course_edit_btn.TabIndex = 5
        Me.course_edit_btn.Text = "Edit"
        Me.course_edit_btn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(928, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'course_close_btn
        '
        Me.course_close_btn.Location = New System.Drawing.Point(578, 401)
        Me.course_close_btn.Name = "course_close_btn"
        Me.course_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.course_close_btn.TabIndex = 7
        Me.course_close_btn.Text = "Close"
        Me.course_close_btn.UseVisualStyleBackColor = True
        '
        'coursesView
        '
        Me.coursesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.coursesView.Location = New System.Drawing.Point(12, 245)
        Me.coursesView.Name = "coursesView"
        Me.coursesView.Size = New System.Drawing.Size(641, 150)
        Me.coursesView.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Courses"
        '
        'course_refresh_btn
        '
        Me.course_refresh_btn.Location = New System.Drawing.Point(578, 216)
        Me.course_refresh_btn.Name = "course_refresh_btn"
        Me.course_refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.course_refresh_btn.TabIndex = 10
        Me.course_refresh_btn.Text = "Refresh"
        Me.course_refresh_btn.UseVisualStyleBackColor = True
        '
        'course_id_txt
        '
        Me.course_id_txt.Location = New System.Drawing.Point(234, 68)
        Me.course_id_txt.Name = "course_id_txt"
        Me.course_id_txt.Size = New System.Drawing.Size(235, 20)
        Me.course_id_txt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Course ID"
        '
        'courses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 426)
        Me.Controls.Add(Me.course_refresh_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.coursesView)
        Me.Controls.Add(Me.course_close_btn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.course_delete_btn)
        Me.Controls.Add(Me.course_edit_btn)
        Me.Controls.Add(Me.course_add_btn)
        Me.Controls.Add(Me.course_clear_btn)
        Me.Controls.Add(Me.course_code_txt)
        Me.Controls.Add(Me.course_id_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.course_name_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "courses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "courses"
        CType(Me.coursesView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents logout_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents course_name_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents course_code_txt As TextBox
    Friend WithEvents course_clear_btn As Button
    Friend WithEvents course_delete_btn As Button
    Friend WithEvents course_add_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents course_edit_btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents course_close_btn As Button
    Friend WithEvents coursesView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents course_refresh_btn As Button
    Friend WithEvents course_id_txt As TextBox
    Friend WithEvents Label5 As Label
End Class
