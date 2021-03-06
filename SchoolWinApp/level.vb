﻿Imports System.Data.SqlClient
Imports System.Data

Public Class level
    Private Sub level_logout_btn_Click(sender As Object, e As EventArgs) Handles level_logout_btn.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub level_close_btn_Click(sender As Object, e As EventArgs) Handles level_close_btn.Click
        home.Show()
        Hide()
    End Sub

    Private Sub level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        level_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim student_query = "SELECT id as LEVEL_ID, name as LEVEL_NAME FROM [level]"
        Dim adpt As New SqlDataAdapter(student_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "level")
        levelsView.DataSource = ds.Tables(0)
        conn.Close()
        conn = Nothing
    End Sub

    Private Sub level_refresh_btn_Click(sender As Object, e As EventArgs) Handles level_refresh_btn.Click
        level_id_txt.Enabled = False
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim level_query = "SELECT id as LEVEL_ID, name as LEVEL_NAME FROM [level]"
        Dim adpt As New SqlDataAdapter(level_query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "level")
        levelsView.DataSource = ds.Tables(0)
        conn.Close()
        conn = Nothing
    End Sub

    Private Sub level_add_btn_Click(sender As Object, e As EventArgs) Handles level_add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=True;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn
        If level_name_txt.Text IsNot "" Then
            comm.CommandText = "INSERT INTO level([name]) VALUES('" & level_name_txt.Text & "')"
            Dim comm1 As SqlCommand = New SqlCommand()
            comm1.Connection = conn
            comm1.CommandText = "SELECT * FROM [level] WHERE name='" & level_name_txt.Text & "'"
            Try
                Dim total_present As Integer = comm1.ExecuteNonQuery()
                If total_present > 0 Then
                    MessageBox.Show("Duplicate Records Not Allowed")
                Else
                    Dim created As Integer = comm.ExecuteNonQuery()
                    If created > 0 Then
                        MessageBox.Show("Study Level Created")
                    Else
                        MessageBox.Show("Failed to Add New Study Level, Please Try again")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            comm1.Dispose()
            comm1 = Nothing
            comm.Dispose()
            comm = Nothing
            conn.Close()
        Else
            MessageBox.Show("Please Fill all Fields")
        End If
    End Sub


    Private Sub DataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles levelsView.CellClick
        Dim i As Integer
        i = levelsView.CurrentRow.Index
        If levelsView.Item(0, i).Value.ToString() IsNot "" Then
            level_id_txt.Text = levelsView.Item(0, i).Value
            level_name_txt.Text = levelsView.Item(1, i).Value
        Else
            MessageBox.Show("Select Row with Data")
        End If

    End Sub

    Private Sub level_delete_btn_Click(sender As Object, e As EventArgs) Handles level_delete_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand()
        comm.Connection = conn

        If levelsView.SelectedRows.Count > 0 Or level_id_txt.Text.ToString() IsNot "" Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim delete_query As String = "DELETE FROM [level] WHERE id = '" & level_id_txt.Text & "'"
            comm.CommandText = delete_query
            Dim deleted As Integer = comm.ExecuteNonQuery()
            levelsView.Rows.Remove(levelsView.SelectedRows(0))

            level_id_txt.Clear()
            level_name_txt.Clear()

            MessageBox.Show("Data Delete!!")
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
        comm.Dispose()
        comm = Nothing
        conn.Close()
    End Sub

    Private Sub level_edit_btn_Click(sender As Object, e As EventArgs) Handles level_edit_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Server=LONGIB;Database=tmt;Integrated Security=true;")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed")
        End Try
        If level_id_txt.Text.ToString() IsNot "" Then
            Dim update_query As String = "UPDATE [level] SET name='" & level_name_txt.Text & "' WHERE id='" & level_id_txt.Text & "'"
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = update_query
            Try
                Dim affected_row As Integer = comm.ExecuteNonQuery()
                If affected_row > 0 Then
                    MessageBox.Show("Data Succcessfully Updated")
                Else
                    MessageBox.Show("Failed to Update Data")
                End If
            Catch ex As Exception
                MessageBox.Show("Operation Failed")
            End Try
            comm.Dispose()
            comm = Nothing
            conn.Close()
        Else
            MessageBox.Show("Course ID is Required")
        End If
    End Sub

    Private Sub level_clear_btn_Click(sender As Object, e As EventArgs) Handles level_clear_btn.Click
        level_id_txt.Clear()
        level_name_txt.Clear()
    End Sub
End Class