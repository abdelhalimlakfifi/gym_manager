Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Username = "Admin" And Password = Root Then
            MsgBox("Welcome ", MsgBoxStyle.Information, "Message")
            Form1.Show()

        Else
            MsgBox("You enter a wrong username or password, please try again", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
End Class
