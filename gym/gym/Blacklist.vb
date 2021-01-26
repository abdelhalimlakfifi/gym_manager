Imports System.Data.OleDb
Imports System.Data

Public Class Blacklist
    Dim connections As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alakf\Desktop\gym2\DATABASE\gymdata.accdb")

    Private Sub Blacklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim i As Integer
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            'MsgBox("loaded")
            sql = "UPDATE [user] SET today='" & Date.Today & "' WHERE ID_users > 0;"
            cmd.Connection = connections
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from [blacklist]"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connections.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from [blacklist] WHERE first_name LIKE '%" & TextBox1.Text & "%' Or last_name LIKE '%" & TextBox1.Text & "%';"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from [blacklist]"
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
End Class