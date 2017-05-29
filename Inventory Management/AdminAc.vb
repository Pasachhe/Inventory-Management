Public Class AdminAc

    Dim x As Integer
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try


            'your code goes here
            dbconnectcode("Select * from UserInfo")
            Dim a As String
            If txtnam.Text = "" Or txtold.Text = "" Then
                MsgBox("Enter username and password")
                txtnam.Clear()
                txtold.Clear()

            Else
                a = "Insert into UserInfo"
                a = a & " values ( " & x + 1 & ", '" & txtnam.Text & "', '" & txtold.Text & "')"
                MsgBox(a)
                altertable(a)
                MsgBox("Successfully Added")
                dbconnectcode("Select * from UserInfo")
            End If
        Catch ex As Exception
            'error message
            MsgBox(ex.Message)
            End

        End Try
    End Sub


    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click

        dbconnectcode("Select * from UserInfo where UserName= '" & txtnam.Text & "'")
        If dt.Rows.Count = 0 Then
            MsgBox("The username doesn't exist")
        Else
            If txtold.Text = dt.Rows(0)(2) Then
                Dim c As String
                c = "Delete from UserInfo where UserName= '" & txtnam.Text & "'"
                altertable(c)
                MsgBox("Successfully Deleted")
                txtnam.Clear()
                txtold.Clear()
            Else
                MsgBox("Invalid password for the username")
            End If
        End If

    End Sub


    Private Sub AdminAc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from UserInfo")
        If dt.Rows.Count = 0 Then
            x = 0
        Else
            dbconnectcode("Select max(UserID) from UserInfo")

            x = dt.Rows(0)(0)
        End If
    End Sub

    Private Sub btnup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        If txtnew.Text = txtcon.Text Then
            dbconnectcode("Select * from UserInfo where UserName= '" & txtnam.Text & "'")
            If dt.Rows.Count = 0 Then
                MsgBox("The username doesn't exist")
            Else
                If txtold.Text = dt.Rows(0)(2) Then
                    Dim c As String
                    c = "Update UserInfo set UserName= '" & txtnam.Text & "', " & "UserPassword= '" & txtnew.Text & "' where UserID= " & dt.Rows(0)(0)
                    altertable(c)
                    MsgBox("Successfully Updated")
                    txtnam.Clear()
                    txtold.Clear()
                    txtnew.Clear()
                    txtcon.Clear()
                Else
                    MsgBox("Invalid password for the username")
                End If
            End If
        Else
            MsgBox("Figures mismatch for new password")
        End If
    End Sub


    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Me.Hide()
        frmStock.Show()

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


    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHomeaa.Show()

    End Sub

    Private Sub txtnam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnam.TextChanged

    End Sub
End Class