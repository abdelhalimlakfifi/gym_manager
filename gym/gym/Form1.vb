Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connections As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alakf\Desktop\gym2\DATABASE\gymdata.accdb")

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Saisir username ou le mots de passe.", MsgBoxStyle.Exclamation)
        Else
            If connections.State = ConnectionState.Closed Then
                connections.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from admin where Uname=? and pass=?", connections)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If (count > 0) Then
                Form2.Show()
            Else
                MsgBox("didn't Work")
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.PasswordChar = Nothing Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
