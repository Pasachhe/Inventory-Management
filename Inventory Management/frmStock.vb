Public Class frmStock

    Private Sub btnOvSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStckGred.Show()
        Me.Hide()

    End Sub

    Private Sub btnamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamo.Click
        If txtitem.Text = "" Or txtquan.Text = "" Or txtrate.Text = "" Then
            MsgBox("Parameter not filled properly", MsgBoxStyle.Exclamation)
        End If
        txtamo.Text = txtrate.Text * txtquan.Text
        MsgBox("Done")
    End Sub


    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from Stock")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dbconnectcode("Select * from Stock where Item= '" & comitem.Text & "'")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub comsearch_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comitem.DropDown
        dbconnectcode("Select Item from Stock")
        comitem.Items.Clear()
        Dim k As Integer
        For k = 0 To (dt.Rows.Count - 1)
            comitem.Items.Add(dt.Rows(k)(0))
        Next
    End Sub



    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtamo.Clear()
        If Val(DataGridView1.CurrentRow.Index) = " " Then
            txtitem.Text = "O"
            txtrate.Text = "O"
            txtquan.Text = "O"
        End If
        Dim a As Integer
        a = DataGridView1.CurrentRow.Index

        txtitem.Text = DataGridView1.Item(0, a).Value
        txtrate.Text = DataGridView1.Item(1, a).Value
        txtquan.Text = DataGridView1.Item(2, a).Value
    End Sub

    Private Sub btnfull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfull.Click
        Me.Hide()
        frmStckGred.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btncan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncan.Click
        txtitem.Clear()
        txtquan.Clear()
        txtrate.Clear()

    End Sub
    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Me.Hide()
        frmStaff.Show()

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
        MsgBox("Successfully added")
        MsgBox("Paramaters Missing", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub txtquan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquan.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtquan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquan.TextChanged

    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.TextChanged

    End Sub

    Private Sub txtamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtamo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamo.TextChanged

    End Sub

    Private Sub btnup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        MsgBox("Update Successful")
        MsgBox("Select a Item or Fill the parameters Completely", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        MsgBox("Successfully deleted")
        MsgBox("Select a Item to delete", MsgBoxStyle.Exclamation)
    End Sub
End Class