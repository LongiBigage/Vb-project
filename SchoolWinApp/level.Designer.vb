<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.level_logout_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.level_id_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.level_name_txt = New System.Windows.Forms.TextBox()
        Me.levelsView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.level_refresh_btn = New System.Windows.Forms.Button()
        Me.level_add_btn = New System.Windows.Forms.Button()
        Me.level_edit_btn = New System.Windows.Forms.Button()
        Me.level_delete_btn = New System.Windows.Forms.Button()
        Me.level_clear_btn = New System.Windows.Forms.Button()
        Me.level_close_btn = New System.Windows.Forms.Button()
        CType(Me.levelsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 57)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Manage Study  Levels"
        '
        'level_logout_btn
        '
        Me.level_logout_btn.Location = New System.Drawing.Point(524, 12)
        Me.level_logout_btn.Name = "level_logout_btn"
        Me.level_logout_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_logout_btn.TabIndex = 1
        Me.level_logout_btn.Text = "Logout"
        Me.level_logout_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Level ID"
        '
        'level_id_txt
        '
        Me.level_id_txt.Location = New System.Drawing.Point(167, 99)
        Me.level_id_txt.Name = "level_id_txt"
        Me.level_id_txt.Size = New System.Drawing.Size(128, 20)
        Me.level_id_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level Name"
        '
        'level_name_txt
        '
        Me.level_name_txt.Location = New System.Drawing.Point(167, 143)
        Me.level_name_txt.Name = "level_name_txt"
        Me.level_name_txt.Size = New System.Drawing.Size(210, 20)
        Me.level_name_txt.TabIndex = 3
        '
        'levelsView
        '
        Me.levelsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.levelsView.Location = New System.Drawing.Point(11, 256)
        Me.levelsView.Name = "levelsView"
        Me.levelsView.Size = New System.Drawing.Size(587, 150)
        Me.levelsView.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Levels List"
        '
        'level_refresh_btn
        '
        Me.level_refresh_btn.Location = New System.Drawing.Point(523, 214)
        Me.level_refresh_btn.Name = "level_refresh_btn"
        Me.level_refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_refresh_btn.TabIndex = 6
        Me.level_refresh_btn.Text = "Refresh"
        Me.level_refresh_btn.UseVisualStyleBackColor = True
        '
        'level_add_btn
        '
        Me.level_add_btn.Location = New System.Drawing.Point(418, 92)
        Me.level_add_btn.Name = "level_add_btn"
        Me.level_add_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_add_btn.TabIndex = 7
        Me.level_add_btn.Text = "Add"
        Me.level_add_btn.UseVisualStyleBackColor = True
        '
        'level_edit_btn
        '
        Me.level_edit_btn.Location = New System.Drawing.Point(418, 141)
        Me.level_edit_btn.Name = "level_edit_btn"
        Me.level_edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_edit_btn.TabIndex = 7
        Me.level_edit_btn.Text = "Edit"
        Me.level_edit_btn.UseVisualStyleBackColor = True
        '
        'level_delete_btn
        '
        Me.level_delete_btn.Location = New System.Drawing.Point(511, 92)
        Me.level_delete_btn.Name = "level_delete_btn"
        Me.level_delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_delete_btn.TabIndex = 7
        Me.level_delete_btn.Text = "Delete"
        Me.level_delete_btn.UseVisualStyleBackColor = True
        '
        'level_clear_btn
        '
        Me.level_clear_btn.Location = New System.Drawing.Point(511, 143)
        Me.level_clear_btn.Name = "level_clear_btn"
        Me.level_clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_clear_btn.TabIndex = 7
        Me.level_clear_btn.Text = "Clear"
        Me.level_clear_btn.UseVisualStyleBackColor = True
        '
        'level_close_btn
        '
        Me.level_close_btn.Location = New System.Drawing.Point(523, 412)
        Me.level_close_btn.Name = "level_close_btn"
        Me.level_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.level_close_btn.TabIndex = 7
        Me.level_close_btn.Text = "Close"
        Me.level_close_btn.UseVisualStyleBackColor = True
        '
        'level
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 445)
        Me.Controls.Add(Me.level_edit_btn)
        Me.Controls.Add(Me.level_close_btn)
        Me.Controls.Add(Me.level_clear_btn)
        Me.Controls.Add(Me.level_delete_btn)
        Me.Controls.Add(Me.level_add_btn)
        Me.Controls.Add(Me.level_refresh_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.levelsView)
        Me.Controls.Add(Me.level_name_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.level_id_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.level_logout_btn)
        Me.Controls.Add(Me.Label2)
        Me.Name = "level"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "level"
        CType(Me.levelsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents level_logout_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents level_id_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents level_name_txt As TextBox
    Friend WithEvents levelsView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents level_refresh_btn As Button
    Friend WithEvents level_add_btn As Button
    Friend WithEvents level_edit_btn As Button
    Friend WithEvents level_delete_btn As Button
    Friend WithEvents level_clear_btn As Button
    Friend WithEvents level_close_btn As Button
End Class
