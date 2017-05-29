Public Class frmBill
    Dim x As Integer
    Dim u As Integer
    Dim s As Integer
    Dim r As Integer
    Dim btot As Integer
    Private Sub Bill_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dbconnectcode("Select * from Bill_Temp")
        DatagredBill.DataSource = dt

    End Sub
    Private Sub frmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        s = 1
        lblname.Text = "Mr." & Username
        lblcusto.Text = "Mr. " & dealname
        dbconnectcode("Select * from CustomerId")
        For i = 0 To (dt.Rows.Count - 1)
            If dt.Rows(i)(1) = dealname Then
                x = dt.Rows(i)(0)
            End If
        Next
        dbconnectcode("Select * from LedgerCustomer")
        If dt.Rows.Count = 0 Then
            u = 0
        Else
            dbconnectcode("Select max(LedgerID) from LedgerCustomer")
            u = dt.Rows(0)(0)
        End If
    End Sub
End Class