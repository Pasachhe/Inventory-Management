Public Class frmVendor

    Private Sub frmVendor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dbconnectcode("Select * from VendorId")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Dealer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from VendorId")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        If txtadd.Text = "" Or txtemail.Text = "" Or txtnam.Text = "" Or txtphn.Text = "" Then
            MsgBox("Select an  ID First", MsgBoxStyle.Information)
        Else
            dealname = txtnam.Text
            Me.Hide()
            frmLedgerVendor.Show()
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dbconnectcode("Select * from VendorId where Name= '" & txtsearch.Text & "'")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim a As Integer
        a = DataGridView1.CurrentRow.Index

        txtnam.Text = DataGridView1.Item(1, a).Value
        txtadd.Text = DataGridView1.Item(2, a).Value
        txtphn.Text = DataGridView1.Item(3, a).Value
        txtemail.Text = DataGridView1.Item(4, a).Value
    End Sub



    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        frmHomeaa.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub LockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockToolStripMenuItem.Click

    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Me.Hide()
        frmStock.Show()

    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Me.Hide()
        frmStaff.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Hide()
        frmCustomer.Show()

    End Sub

    Private Sub StockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem1.Click
        Me.Hide()
        frmStckGred.Show()

    End Sub

    Private Sub StaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem1.Click
        Me.Hide()
        frmStaffGred.Show()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtadd.Text = "" Or txtemail.Text = "" Or txtnam.Text = "" Or txtphn.Text = "" Then
            MsgBox("Fill Vendor Information properly", MsgBoxStyle.Information)
        End If
        Dim x As Integer
        dbconnectcode("Select * from VendorId")
        If dt.Rows.Count = 0 Then
            x = 1
        Else
            dbconnectcode("Select max(ID) from VendorId")
            x = dt.Rows(0)(0) + 1
        End If
        Dim a As String
        a = "Insert into VendorId "
        a = a & "values (" & x & ", '" & txtnam.Text & "', '" & txtadd.Text & "', " & txtphn.Text & ", '" & txtemail.Text & "')"
        altertable(a)
        'adding records to the database file
        MsgBox("Successfully Added")
    End Sub

    Private Sub btnup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        If txtadd.Text = "" Or txtemail.Text = "" Or txtnam.Text = "" Or txtphn.Text = "" Then
            MsgBox("Select a ID or Fill properly", MsgBoxStyle.Information)
        End If
        dbconnectcode("Select * from VendorId where Name = '" & txtnam.Text & "'")
        Dim o As Integer
        o = dt.Rows(0)(0)
        Dim b As String
        b = "Update VendorId set Name = '" & txtnam.Text & "', Address = '" & txtadd.Text & "', PhNo = " & txtphn.Text & ", Email = '" & txtemail.Text & "' where ID = " & o
        altertable(b)
        'updates the selected record in the database
        MsgBox("Update Successful")

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtadd.Text = "" Or txtemail.Text = "" Or txtnam.Text = "" Or txtphn.Text = "" Then
            MsgBox("Select a ID", MsgBoxStyle.Information)
        End If

        dbconnectcode("Select * from VendorId where Name = '" & txtnam.Text & "'")
        Dim o As Integer
        o = dt.Rows(0)(0)
        Dim c As String
        c = "Delete from VendorId where ID = " & o
        altertable(c)
        'deletes the selected record from the database
        MsgBox("Successfully Deleted")
    End Sub

    Private Sub btncan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncan.Click
        txtadd.Clear()
        txtemail.Clear()
        txtnam.Clear()
        txtphn.Clear()
        txtsearch.Clear()

    End Sub

    Private Sub txtphn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphn.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtphn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphn.TextChanged

    End Sub
End Class