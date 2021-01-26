Imports System.Data.OleDb
Imports System.Data

Public Class Validation
    Dim connections As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DATABASE\gymdata.accdb")
    Private Sub Validation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateBox.Format = DateTimePickerFormat.Short
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from [user]"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim n As Integer
    

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

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
            sql = "Select * from [user] WHERE first_name LIKE '%" & TextBox1.Text & "%' Or last_name LIKE '%" & TextBox1.Text & "%';"
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
        ' Dim dateE As DateTime = New DateTime(dateBox.Text)
        Dim i As Integer
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If

            sql = "UPDATE [user] SET registration_date='" & dateBox.Text & "', Uname='" & adminBox.Text & "' WHERE ID_users=" & Val(n) & ";"
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
            sql = "Select * from [user]"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connections.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim i As Integer
            sql = "DELETE * from [user] WHERE ID_users=" & Val(n) & ";"
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
            Sql = "Select * from [user]"
            cmd.Connection = connections
            cmd.CommandText = Sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connections.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from [user]"
            cmd.Connection = connections
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        n = DataGridView1.CurrentRow.Cells(0).Value
        nomBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        prenomBox.Text = DataGridView1.CurrentRow.Cells(2).Value
        sexeBox.Text = DataGridView1.CurrentRow.Cells(3).Value
        phoneBox.Text = DataGridView1.CurrentRow.Cells(4).Value
        prixBox.Text = DataGridView1.CurrentRow.Cells(5).Value
        dateBox.Text = DataGridView1.CurrentRow.Cells(6).Value
        moisBox.Text = DataGridView1.CurrentRow.Cells(7).Value
        adminBox.Text = DataGridView1.CurrentRow.Cells(8).Value
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class