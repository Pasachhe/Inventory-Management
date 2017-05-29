Public Class frmLedgerVendor
    Dim x As Integer
    Dim u As Integer

    Dim btot As Integer

    Private Sub LedgerVendor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        dbconnectcode("Select * from LedgerDealer where VendorID= " & x)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub LedgerDealer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblnam.Text = "Mr. " & dealname
        dbconnectcode("Select * from VendorId")
        For i = 0 To (dt.Rows.Count - 1)
            If dt.Rows(i)(1) = dealname Then
                x = dt.Rows(i)(0)
            End If
        Next
        dbconnectcode("Select * from LedgerDealer")
        If dt.Rows.Count = 0 Then
            u = 0
        Else
            dbconnectcode("Select max(LedgerID) from LedgerDealer")
            u = dt.Rows(0)(0)
        End If


    End Sub

    Private Sub comitem_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comitem.DropDown
        dbconnectcode("Select Item from Stock")
        comitem.Items.Clear()
        Dim k As Integer
        For k = 0 To (dt.Rows.Count - 1)
            comitem.Items.Add(dt.Rows(k)(0))
        Next
    End Sub


    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click
        If txtamo.Text = "" Or comitem.Text = "" Or txtrate.Text = "" Or txtquan.Text = "" Then
            MsgBox("Fill left Side Boxes before add", MsgBoxStyle.Information)
        End If
        lblrs.Text = Val(lblrs.Text) + Val(txtamo.Text)
        dbconnectcode("Select * from Stock where Item= '" & comitem.Text & "'")
        Dim k As Integer
        k = dt.Rows(0)(2)
        altertable("Update Stock set Quantity= " & k + Val(txtquan.Text) & " where Item= '" & comitem.Text & "'")

        MsgBox("Done")

    End Sub

    Private Sub btnamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamo.Click
        If txtrate.Text = "" Or txtquan.Text = "" Or comitem.Text = "" Then
            MsgBox("Fill information properly", MsgBoxStyle.Information)
        Else

            txtamo.Text = txtquan.Text * txtrate.Text
        End If
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        txtamo.Clear()
        txtquan.Clear()
        txtrate.Clear()


    End Sub

    Private Sub btnrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrec.Click
        If txtamo.Text = "" Or comitem.Text = "" Or txtrate.Text = "" Or txtquan.Text = "" Or txtFolio.Text = "" Or txtpaid.Text = "" Then
            MsgBox("Fill Every information before add", MsgBoxStyle.Information)
        End If

        dbconnectcode("Select * from LedgerDealer where VendorID= " & x)
        Dim k As Integer
        k = dt.Rows.Count
        If dt.Rows.Count = 0 Then

            btot = 0
        Else

            btot = dt.Rows(k - 1)(6)

        End If

        Dim a As String
        a = "Insert into LedgerDealer"
        a = a & " values (" & u + 1 & ", " & x & ", '" & Reg_Date.Text & "', " & txtFolio.Text & ", " & Val(lblrs.Text) & ", " & Val(txtpaid.Text) & ", " & (btot + Val(lblrs.Text) - Val(txtpaid.Text)) & ")"
        altertable(a)
        MsgBox("Successful")
        u = u + 1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        lblrs.Text = "Rs"
        comitem.Text = ""
        txtquan.Clear()
        txtrate.Clear()
        txtamo.Clear()
        txtpaid.Clear()
        txtFolio.Clear()
        Reg_Date.Text = Date.Now
    End Sub



    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        frmVendor.Show()

    End Sub


    Private Sub comitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comitem.SelectedIndexChanged

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

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtFolio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFolio.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaid.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaid.TextChanged

    End Sub
End Class