Public Class frmStaffGred

    Private Sub StaffGred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from StaffId")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dbconnectcode("Select * from StaffId where StaffName= '" & txtsearch.Text & "'")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim a As Integer
        a = DataGridView1.CurrentRow.Index

        txtnam.Text = DataGridView1.Item(1, a).Value
        txtadd.Text = DataGridView1.Item(2, a).Value
        txtemail.Text = DataGridView1.Item(3, a).Value
        txtph.Text = DataGridView1.Item(4, a).Value
        txtstat.Text = DataGridView1.Item(5, a).Value
        txtsalary.Text = DataGridView1.Item(6, a).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub txtsearch_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.Validated

    End Sub

    Private Sub txtsearch_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.VisibleChanged
        dbconnectcode("Select * from StaffId where StaffName= '" & txtsearch.Text & "'")
        DataGridView1.DataSource = dt
    End Sub
End Class