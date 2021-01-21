Public Class Form2


    
    Private Sub Mois_payerLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        Panel4.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Close()
        switchPanel(addUserForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(ValidationForm)
    End Sub

    Private Sub ButtonBlacklist_Click(sender As Object, e As EventArgs) Handles ButtonBlacklist.Click
        switchPanel(blacklistForm)
    End Sub
End Class