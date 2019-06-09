Public Class frmReport
    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AndrewDataset)

    End Sub

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AndrewDataset.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.AndrewDataset.User)

    End Sub

End Class