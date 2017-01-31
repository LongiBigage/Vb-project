<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class examination
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
        Me.examination_logout_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.examination_id_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.examination_name_txt = New System.Windows.Forms.TextBox()
        Me.examinationsView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.examination_close_btn = New System.Windows.Forms.Button()
        Me.examination_refresh_btn = New System.Windows.Forms.Button()
        Me.examination_add_btn = New System.Windows.Forms.Button()
        Me.examination_edit_btn = New System.Windows.Forms.Button()
        Me.examination_delete_btn = New System.Windows.Forms.Button()
        Me.examination_clear_btn = New System.Windows.Forms.Button()
        CType(Me.examinationsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Examinations"
        '
        'examination_logout_btn
        '
        Me.examination_logout_btn.Location = New System.Drawing.Point(608, 13)
        Me.examination_logout_btn.Name = "examination_logout_btn"
        Me.examination_logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_logout_btn.TabIndex = 1
        Me.examination_logout_btn.Text = "Logout"
        Me.examination_logout_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Examination ID"
        '
        'examination_id_txt
        '
        Me.examination_id_txt.Location = New System.Drawing.Point(253, 99)
        Me.examination_id_txt.Name = "examination_id_txt"
        Me.examination_id_txt.Size = New System.Drawing.Size(121, 20)
        Me.examination_id_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Examination Name"
        '
        'examination_name_txt
        '
        Me.examination_name_txt.Location = New System.Drawing.Point(253, 140)
        Me.examination_name_txt.Name = "examination_name_txt"
        Me.examination_name_txt.Size = New System.Drawing.Size(205, 20)
        Me.examination_name_txt.TabIndex = 3
        '
        'examinationsView
        '
        Me.examinationsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.examinationsView.Location = New System.Drawing.Point(38, 224)
        Me.examinationsView.Name = "examinationsView"
        Me.examinationsView.Size = New System.Drawing.Size(645, 183)
        Me.examinationsView.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Examination List"
        '
        'examination_close_btn
        '
        Me.examination_close_btn.Location = New System.Drawing.Point(608, 413)
        Me.examination_close_btn.Name = "examination_close_btn"
        Me.examination_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_close_btn.TabIndex = 6
        Me.examination_close_btn.Text = "Close"
        Me.examination_close_btn.UseVisualStyleBackColor = True
        '
        'examination_refresh_btn
        '
        Me.examination_refresh_btn.Location = New System.Drawing.Point(607, 195)
        Me.examination_refresh_btn.Name = "examination_refresh_btn"
        Me.examination_refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_refresh_btn.TabIndex = 7
        Me.examination_refresh_btn.Text = "Refresh"
        Me.examination_refresh_btn.UseVisualStyleBackColor = True
        '
        'examination_add_btn
        '
        Me.examination_add_btn.Location = New System.Drawing.Point(528, 88)
        Me.examination_add_btn.Name = "examination_add_btn"
        Me.examination_add_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_add_btn.TabIndex = 8
        Me.examination_add_btn.Text = "Add"
        Me.examination_add_btn.UseVisualStyleBackColor = True
        '
        'examination_edit_btn
        '
        Me.examination_edit_btn.Location = New System.Drawing.Point(528, 138)
        Me.examination_edit_btn.Name = "examination_edit_btn"
        Me.examination_edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_edit_btn.TabIndex = 8
        Me.examination_edit_btn.Text = "Edit"
        Me.examination_edit_btn.UseVisualStyleBackColor = True
        '
        'examination_delete_btn
        '
        Me.examination_delete_btn.Location = New System.Drawing.Point(623, 88)
        Me.examination_delete_btn.Name = "examination_delete_btn"
        Me.examination_delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_delete_btn.TabIndex = 9
        Me.examination_delete_btn.Text = "Delete"
        Me.examination_delete_btn.UseVisualStyleBackColor = True
        '
        'examination_clear_btn
        '
        Me.examination_clear_btn.Location = New System.Drawing.Point(623, 137)
        Me.examination_clear_btn.Name = "examination_clear_btn"
        Me.examination_clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.examination_clear_btn.TabIndex = 9
        Me.examination_clear_btn.Text = "Clear"
        Me.examination_clear_btn.UseVisualStyleBackColor = True
        '
        'examination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 438)
        Me.Controls.Add(Me.examination_clear_btn)
        Me.Controls.Add(Me.examination_delete_btn)
        Me.Controls.Add(Me.examination_edit_btn)
        Me.Controls.Add(Me.examination_add_btn)
        Me.Controls.Add(Me.examination_refresh_btn)
        Me.Controls.Add(Me.examination_close_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.examinationsView)
        Me.Controls.Add(Me.examination_name_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.examination_id_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.examination_logout_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "examination"
        Me.Text = "examination"
        CType(Me.examinationsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents examination_logout_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents examination_id_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents examination_name_txt As TextBox
    Friend WithEvents examinationsView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents examination_close_btn As Button
    Friend WithEvents examination_refresh_btn As Button
    Friend WithEvents examination_add_btn As Button
    Friend WithEvents examination_edit_btn As Button
    Friend WithEvents examination_delete_btn As Button
    Friend WithEvents examination_clear_btn As Button
End Class
