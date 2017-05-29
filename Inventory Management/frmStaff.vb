Public Class frmStaff


    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from StaffId")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dbconnectcode("Select * from StaffId where StaffName= '" & txtsearch.Text & "'")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim a As Integer
        a = DataGridView1.CurrentRow.Index

        txtnam.Text = DataGridView1.Item(1, a).Value Or txtnam.Text = " "
        txtadd.Text = DataGridView1.Item(2, a).Value Or txtadd.Text = " "
        txtemail.Text = DataGridView1.Item(3, a).Value Or txtemail.Text = " "
        txtph.Text = DataGridView1.Item(4, a).Value Or txtph.Text = " "
        txtstat.Text = DataGridView1.Item(5, a).Value Or txtstat.Text = " "
        txtsalary.Text = DataGridView1.Item(6, a).Value Or txtsalary.Text = " "



    End Sub


    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Me.Hide()
        frmStock.Show()

    End Sub

    Private Sub VendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorToolStripMenuItem.Click
        Me.Hide()
        frmVendor.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Hide()
        frmCustomer.Show()

    End Sub

    Private Sub StockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem1.Click
        frmStckGred.Show()

    End Sub

    Private Sub StaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem1.Click
        frmStaffGred.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        frmHomeaa.Show()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        MsgBox("Successfully Added")
        MsgBox("Parameter not fulfilled", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub btnup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        MsgBox("Update Successful")
        MsgBox("Item Not selected or Parameter not fulfilled", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub txtph_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtph.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtph_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtph.TextChanged

    End Sub

    Private Sub txtsalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalary.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtsalary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsalary.TextChanged

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        MsgBox("Successfully Deleted")
        'MsgBox("Select one information", MsgBoxStyle.Information)
    End Sub

    Private Sub txtsearch_MultilineChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.MultilineChanged
        dbconnectcode("Select * from StaffId where StaffName= '" & txtsearch.Text & "'")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

    End Sub

    'shows datas on gridview only which is entered on the txtbox
    '............................................

    ' Private Sub txtsearch_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.VisibleChanged
    '    dbconnectcode("Select * from StaffId where StaffName= '" & txtsearch.Text & "'")
    '   DataGridView1.DataSource = dt
    'End Sub
End Class