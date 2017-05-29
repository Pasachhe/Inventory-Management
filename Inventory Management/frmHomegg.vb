Public Class frmHomegg
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()

        frmUserMood.Show()

    End Sub

    Private Sub Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock.Click
        frmStckGred.Show()

    End Sub

    Private Sub Staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Staff.Click
        frmStaffGred.Show()

    End Sub
End Class