<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subject
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
        Me.subject_clear_btn = New System.Windows.Forms.Button()
        Me.subject_delete_btn = New System.Windows.Forms.Button()
        Me.subject_edit_btn = New System.Windows.Forms.Button()
        Me.subject_add_btn = New System.Windows.Forms.Button()
        Me.subject_refresh_btn = New System.Windows.Forms.Button()
        Me.subject_close_btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subjectsView = New System.Windows.Forms.DataGridView()
        Me.subject_code_txt = New System.Windows.Forms.TextBox()
        Me.subject_name_txt = New System.Windows.Forms.TextBox()
        Me.subject_id_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subject_logout_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.s_logout_btn = New System.Windows.Forms.Button()
        CType(Me.subjectsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subject_clear_btn
        '
        Me.subject_clear_btn.Location = New System.Drawing.Point(451, 160)
        Me.subject_clear_btn.Name = "subject_clear_btn"
        Me.subject_clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_clear_btn.TabIndex = 21
        Me.subject_clear_btn.Text = "Clear"
        Me.subject_clear_btn.UseVisualStyleBackColor = True
        '
        'subject_delete_btn
        '
        Me.subject_delete_btn.Location = New System.Drawing.Point(451, 131)
        Me.subject_delete_btn.Name = "subject_delete_btn"
        Me.subject_delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_delete_btn.TabIndex = 22
        Me.subject_delete_btn.Text = "Delete"
        Me.subject_delete_btn.UseVisualStyleBackColor = True
        '
        'subject_edit_btn
        '
        Me.subject_edit_btn.Location = New System.Drawing.Point(451, 97)
        Me.subject_edit_btn.Name = "subject_edit_btn"
        Me.subject_edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_edit_btn.TabIndex = 23
        Me.subject_edit_btn.Text = "Edit"
        Me.subject_edit_btn.UseVisualStyleBackColor = True
        '
        'subject_add_btn
        '
        Me.subject_add_btn.Location = New System.Drawing.Point(451, 56)
        Me.subject_add_btn.Name = "subject_add_btn"
        Me.subject_add_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_add_btn.TabIndex = 24
        Me.subject_add_btn.Text = "Add"
        Me.subject_add_btn.UseVisualStyleBackColor = True
        '
        'subject_refresh_btn
        '
        Me.subject_refresh_btn.Location = New System.Drawing.Point(520, 228)
        Me.subject_refresh_btn.Name = "subject_refresh_btn"
        Me.subject_refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_refresh_btn.TabIndex = 20
        Me.subject_refresh_btn.Text = "Refresh"
        Me.subject_refresh_btn.UseVisualStyleBackColor = True
        '
        'subject_close_btn
        '
        Me.subject_close_btn.Location = New System.Drawing.Point(520, 419)
        Me.subject_close_btn.Name = "subject_close_btn"
        Me.subject_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_close_btn.TabIndex = 19
        Me.subject_close_btn.Text = "Close"
        Me.subject_close_btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Subject Lists"
        '
        'subjectsView
        '
        Me.subjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subjectsView.Location = New System.Drawing.Point(7, 263)
        Me.subjectsView.Name = "subjectsView"
        Me.subjectsView.Size = New System.Drawing.Size(588, 150)
        Me.subjectsView.TabIndex = 17
        '
        'subject_code_txt
        '
        Me.subject_code_txt.Location = New System.Drawing.Point(185, 138)
        Me.subject_code_txt.Name = "subject_code_txt"
        Me.subject_code_txt.Size = New System.Drawing.Size(201, 20)
        Me.subject_code_txt.TabIndex = 14
        '
        'subject_name_txt
        '
        Me.subject_name_txt.Location = New System.Drawing.Point(185, 99)
        Me.subject_name_txt.Name = "subject_name_txt"
        Me.subject_name_txt.Size = New System.Drawing.Size(201, 20)
        Me.subject_name_txt.TabIndex = 15
        '
        'subject_id_txt
        '
        Me.subject_id_txt.Location = New System.Drawing.Point(185, 58)
        Me.subject_id_txt.Name = "subject_id_txt"
        Me.subject_id_txt.Size = New System.Drawing.Size(201, 20)
        Me.subject_id_txt.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Subject Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Subject Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Subject ID"
        '
        'subject_logout_btn
        '
        Me.subject_logout_btn.Location = New System.Drawing.Point(584, -29)
        Me.subject_logout_btn.Name = "subject_logout_btn"
        Me.subject_logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.subject_logout_btn.TabIndex = 10
        Me.subject_logout_btn.Text = "Logout"
        Me.subject_logout_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 57)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manage Subjects"
        '
        's_logout_btn
        '
        Me.s_logout_btn.Location = New System.Drawing.Point(518, 12)
        Me.s_logout_btn.Name = "s_logout_btn"
        Me.s_logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.s_logout_btn.TabIndex = 25
        Me.s_logout_btn.Text = "Logout"
        Me.s_logout_btn.UseVisualStyleBackColor = True
        '
        'subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 447)
        Me.Controls.Add(Me.s_logout_btn)
        Me.Controls.Add(Me.subject_clear_btn)
        Me.Controls.Add(Me.subject_delete_btn)
        Me.Controls.Add(Me.subject_edit_btn)
        Me.Controls.Add(Me.subject_add_btn)
        Me.Controls.Add(Me.subject_refresh_btn)
        Me.Controls.Add(Me.subject_close_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.subjectsView)
        Me.Controls.Add(Me.subject_code_txt)
        Me.Controls.Add(Me.subject_name_txt)
        Me.Controls.Add(Me.subject_id_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subject_logout_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "subject"
        Me.Text = "subject"
        CType(Me.subjectsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subject_clear_btn As Button
    Friend WithEvents subject_delete_btn As Button
    Friend WithEvents subject_edit_btn As Button
    Friend WithEvents subject_add_btn As Button
    Friend WithEvents subject_refresh_btn As Button
    Friend WithEvents subject_close_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents subjectsView As DataGridView
    Friend WithEvents subject_code_txt As TextBox
    Friend WithEvents subject_name_txt As TextBox
    Friend WithEvents subject_id_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents subject_logout_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents s_logout_btn As Button
End Class
