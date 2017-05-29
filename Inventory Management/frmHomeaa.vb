Public Class frmHomeaa

    
    Private Sub User_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_ID.Click
        Me.Hide()
        AdminAc.Show()

    End Sub

    Private Sub Company_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Company.Click
        Me.Hide()
        frmCompanyReg.Show()

    End Sub

    Private Sub Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Customer.Click
        Me.Hide()
        frmCustomer.Show()

    End Sub

    Private Sub Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock.Click
        Me.Hide()
        frmStock.Show()

    End Sub

    Private Sub Vendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendor.Click
        Me.Hide()
        frmVendor.Show()

    End Sub

    Private Sub Staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Staff.Click
        Me.Hide()
        frmStaff.Show()

    End Sub

    Private Sub Salary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salary.Click
        Me.Hide()
        frmSalary.Show()

    End Sub
End Class