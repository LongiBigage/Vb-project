<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studyyear
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.year_add_btn = New System.Windows.Forms.Button()
        Me.year_edit_btn = New System.Windows.Forms.Button()
        Me.year_delete_btn = New System.Windows.Forms.Button()
        Me.year_close_btn = New System.Windows.Forms.Button()
        Me.yearsView = New System.Windows.Forms.DataGridView()
        Me.year_clear_btn = New System.Windows.Forms.Button()
        Me.year_refresh_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.year_id_text = New System.Windows.Forms.TextBox()
        Me.study_year_txt = New System.Windows.Forms.TextBox()
        CType(Me.yearsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Study Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year"
        '
        'year_add_btn
        '
        Me.year_add_btn.Location = New System.Drawing.Point(355, 89)
        Me.year_add_btn.Name = "year_add_btn"
        Me.year_add_btn.Size = New System.Drawing.Size(75, 23)
        Me.year_add_btn.TabIndex = 4
        Me.year_add_btn.Text = "Add"
        Me.year_add_btn.UseVisualStyleBackColor = True
        '
        'year_edit_btn
        '
        Me.year_edit_btn.Location = New System.Drawing.Point(448, 91)
        Me.year_edit_btn.Name = "year_edit_btn"
        Me.year_edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.year_edit_btn.TabIndex = 4
        Me.year_edit_btn.Text = "Edit"
        Me.year_edit_btn.UseVisualStyleBackColor = True
        '
        'year_delete_btn
        '
        Me.year_delete_btn.Location = New System.Drawing.Point(355, 133)
        Me.year_delete_btn.Name = "year_delete_btn"
        Me.year_delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.year_delete_btn.TabIndex = 4
        Me.year_delete_btn.Text = "Delete"
        Me.year_delete_btn.UseVisualStyleBackColor = True
        '
        'year_close_btn
        '
        Me.year_close_btn.Location = New System.Drawing.Point(448, 379)
        Me.year_close_btn.Name = "year_close_btn"
        Me.year_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.year_close_btn.TabIndex = 4
        Me.year_close_btn.Text = "Close"
        Me.year_close_btn.UseVisualStyleBackColor = True
        '
        'yearsView
        '
        Me.yearsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yearsView.DefaultCellStyle = DataGridViewCellStyle1
        Me.yearsView.Location = New System.Drawing.Point(70, 214)
        Me.yearsView.Name = "yearsView"
        Me.yearsView.Size = New System.Drawing.Size(423, 150)
        Me.yearsView.TabIndex = 5
        '
        'year_clear_btn
        '
        Me.year_clear_btn.Location = New System.Drawing.Point(448, 133)
        Me.year_clear_btn.Name = "year_clear_btn"
        Me.year_clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.year_clear_btn.TabIndex = 4
        Me.year_clear_btn.Text = "Clear"
        Me.year_clear_btn.UseVisualStyleBackColor = True
        '
        'year_refresh_btn
        '
        Me.year_refresh_btn.Location = New System.Drawing.Point(448, 185)
        Me.year_refresh_btn.Name = "year_refresh_btn"
        Me.year_refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.year_refresh_btn.TabIndex = 6
        Me.year_refresh_btn.Text = "Refresh"
        Me.year_refresh_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Study Years"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Year ID"
        '
        'year_id_text
        '
        Me.year_id_text.Location = New System.Drawing.Point(143, 89)
        Me.year_id_text.Name = "year_id_text"
        Me.year_id_text.Size = New System.Drawing.Size(168, 20)
        Me.year_id_text.TabIndex = 3
        '
        'study_year_txt
        '
        Me.study_year_txt.Location = New System.Drawing.Point(143, 134)
        Me.study_year_txt.Name = "study_year_txt"
        Me.study_year_txt.Size = New System.Drawing.Size(168, 20)
        Me.study_year_txt.TabIndex = 3
        '
        'studyyear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 414)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.year_refresh_btn)
        Me.Controls.Add(Me.yearsView)
        Me.Controls.Add(Me.year_clear_btn)
        Me.Controls.Add(Me.year_close_btn)
        Me.Controls.Add(Me.year_delete_btn)
        Me.Controls.Add(Me.year_edit_btn)
        Me.Controls.Add(Me.year_add_btn)
        Me.Controls.Add(Me.study_year_txt)
        Me.Controls.Add(Me.year_id_text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "studyyear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studyyear"
        CType(Me.yearsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents year_add_btn As Button
    Friend WithEvents year_edit_btn As Button
    Friend WithEvents year_delete_btn As Button
    Friend WithEvents year_close_btn As Button
    Friend WithEvents yearsView As DataGridView
    Friend WithEvents year_clear_btn As Button
    Friend WithEvents year_refresh_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents year_id_text As TextBox
    Friend WithEvents study_year_txt As TextBox
End Class
