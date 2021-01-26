Imports System.Data.OleDb
Imports System.Data

Public Class AdminForm
    Dim connections As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alakf\Desktop\gym2\DATABASE\gymdata.accdb")
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select N,Uname,Nom,Prenom,Telephone from [admin]"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select N,Uname,Nom,Prenom,Telephone from [admin] WHERE Nom LIKE '%" & TextBox6.Text & "%' Or Prenom LIKE '%" & TextBox6.Text & "%' Or Uname LIKE '%" & TextBox6.Text & "%';"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connections.Close()
        End Try
    End Sub
    Dim n As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        n = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(1).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim i As Integer
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            sql = "INSERT INTO [admin] (Uname, pass, Nom,Prenom,Telephone) VALUES ('" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "');"
            cmd.Connection = connections
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If (i > 0) Then
                MsgBox("Done")
            Else
                MsgBox("not done")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select N,Uname,Nom,Prenom,Telephone from [admin] ;"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connections.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim i As Integer
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If

            sql = "DELETE * from [admin] WHERE N=" & Val(n) & ";"
            cmd.Connection = connections
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If (i > 0) Then
                MsgBox("Done")
            Else
                MsgBox("didn't work")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select N,Uname,Nom,Prenom,Telephone from [admin] ;"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connections.Close()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox5.PasswordChar = "*" Then
            TextBox5.PasswordChar = ""
        Else
            TextBox5.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class