Imports System.Data.OleDb
Imports System.Data
Public Class addUserForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alakf\Desktop\gym\gym_manager\DATABASE\gymdata.accdb")
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MsgBox(sexeBox.Text)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        ' Dim dateE As DateTime = New DateTime(dateBox.Text)
        Dim i As Integer
        Try
            con.Open()
            sql = "INSERT INTO [user] ( first_name, last_name, sexe, phone, prix_abonnement, registration_date, mois_payer, Uname ) VALUES ('" & nomBox.Text & "', '" & prenomBox.Text & "', '" & sexeBox.Text & "', '" & phoneBox.Text & "'," & Val(prixBox.Text) & ", '" & dateBox.Text & "'," & Val(moisBox.Text) & ", '" & adminBox.Text & "');"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If (i > 0) Then
                MsgBox("Done")
            Else
                MsgBox("yaa3la qlaawi")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub addUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dateBox.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymdataDataSet)

    End Sub
End Class