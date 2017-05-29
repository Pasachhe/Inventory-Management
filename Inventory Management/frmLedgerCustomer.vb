Public Class frmLedgerCustomer
    Dim x As Integer
    Dim u As Integer
    Dim s As Integer
    Dim r As Integer
    Dim btot As Integer

    Private Sub LedgerCustomer_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dbconnectcode("Select * from LedgerCustomer where CustomerID= " & x)
        DataGridView1.DataSource = dt

    End Sub


    Private Sub LedgerCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        s = 1

        lblnam.Text = "Mr. " & dealname
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

    Private Sub btnamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamo.Click
        If txtrate.Text = "" Or txtquan.Text = "" Or comitem.Text = "" Then
            MsgBox("Fill information properly", MsgBoxStyle.Information)
        Else
            txtamo.Text = txtquan.Text * txtrate.Text
        End If
    End Sub

    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click

        If txtamo.Text = "" Or comitem.Text = "" Or txtrate.Text = "" Or txtquan.Text = "" Then
            MsgBox("Fill left Side Boxes before add", MsgBoxStyle.Information)
        End If
        lblrs.Text = Val(lblrs.Text) + Val(txtamo.Text)
        dbconnectcode("Select * from Stock where Item= '" & comitem.Text & "'")
        Dim k As Integer
        k = dt.Rows(0)(2)
        altertable("Update Stock set Quantity= " & k - Val(txtquan.Text) & " where Item = '" & comitem.Text & "'")
        altertable("Insert into Bill_Temp values ( " & s & ", '" & comitem.Text & "', " & txtrate.Text & ", " & txtquan.Text & ", " & txtamo.Text & ")")
        s = s + 1
        dbconnectcode("Select * from Bill_Record")
        If dt.Rows.Count = 0 Then
            r = 1
        Else
            dbconnectcode("Select max(SN) from Bill_Record")
            r = dt.Rows(0)(0) + 1
        End If

        altertable("Insert into Bill_Record values ( " & r & ", '" & dealname & "', '" & comitem.Text & "', " & txtrate.Text & ", " & txtquan.Text & ", " & txtamo.Text & ")")
        MsgBox("Recorded")
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        txtamo.Clear()
        txtquan.Clear()
        txtrate.Clear()
        comitem.Text = ""
    End Sub

    Private Sub btnrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrec.Click
        If txtamo.Text = "" Or comitem.Text = "" Or txtrate.Text = "" Or txtquan.Text = "" Or txtFolio.Text = "" Or txtpaid.Text = "" Then
            MsgBox("Fill Every information before add", MsgBoxStyle.Information)
        End If

        dbconnectcode("Select * from LedgerCustomer where CustomerID= " & x)
        Dim k As Integer
        k = dt.Rows.Count
        If dt.Rows.Count = 0 Then

            btot = 0
        Else

            btot = dt.Rows(k - 1)(6)

        End If

        Dim a As String
        a = "Insert into LedgerCustomer"
        a = a & " values (" & u + 1 & ", " & x & ", '" & Reg_Date.Text & "', " & txtFolio.Text & ", " & Val(lblrs.Text) & ", " & Val(txtpaid.Text) & ", " & (btot + Val(lblrs.Text) - Val(txtpaid.Text)) & ")"
        altertable(a)
        MsgBox("Successful")
        u = u + 1
        record = "Record"
        paid = txtpaid.Text
        amnt = lblrs.Text
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

        dbconnectcode("Select * from Bill_Temp")
        Dim d As Integer
        d = dt.Rows.Count
        For i = 0 To (d - 1)
            altertable("Delete from Bill_Temp where SN = " & (i + 1))
        Next
        MsgBox("Done")
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        frmCustomer.Show()

    End Sub

    Private Sub comitem_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comitem.DropDown
        dbconnectcode("Select Item from Stock")
        comitem.Items.Clear()
        Dim k As Integer
        For k = 0 To (dt.Rows.Count - 1)
            comitem.Items.Add(dt.Rows(k)(0))
        Next
    End Sub



    Private Sub lblnam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnam.Click

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
        folio = txtFolio.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbill.Click
        frmBill.Show()


    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        dbconnectcode("Select * from Bill_Temp")
        Dim d As Integer
        d = dt.Rows.Count
        For i = 0 To (d - 1)
            altertable("Delete from Bill_Temp where SN = " & (i + 1))
        Next
        MsgBox("Done")
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

    Private Sub txtpaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaid.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaid.TextChanged

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
        MsgBox("Not allowed")
    End Sub

    Private Sub txtamo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamo.TextChanged

    End Sub
End Class