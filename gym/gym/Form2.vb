﻿Public Class Form2
    Sub switchPanel(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        Panel4.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub ButtonBlacklist_Click(sender As Object, e As EventArgs) Handles ButtonBlacklist.Click

    End Sub

    
    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        switchPanel(addUserForm)
    End Sub
End Class