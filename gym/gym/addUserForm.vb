Public Class addUserForm

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GymdataDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.GymdataDataSet.user)

    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymdataDataSet)

    End Sub
End Class