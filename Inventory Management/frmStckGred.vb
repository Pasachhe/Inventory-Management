Public Class frmStckGred

    Private Sub StckGred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbconnectcode("Select * from Stock")
        DataGridView1.DataSource = dt
        txtam.Text = DataGridView1.Columns(3).Name
        txtrow.Text = DataGridView1.RowCount - 1

        For i As Integer = 0 To DataGridView1.RowCount - 1
            txttot.Text = Val(txttot.Text) + DataGridView1.Item(3, i).Value
        Next
    End Sub


    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmStock.Show()

    End Sub

End Class