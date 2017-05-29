Public Class frmCompanyReg

    Dim x As Integer

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtcom.Text = "" Or txtpan.Text = "" Or txtcon1.Text = "" Or txtcon2.Text = "" Then
            MsgBox("Fill the information properly", MsgBoxStyle.Information)
        End If
        Dim a As String
        If btnRegister.Text = "Register" Then
            x = 1
            a = "Insert into Company_Reg"
            a = a & " values (" & x & ", '" & txtcom.Text & "', " & txtpan.Text & ", " & txtcon1.Text & ", " & txtcon2.Text & ")"
            altertable(a)
            MsgBox("The company is successfully registered.")
        Else

            a = "Update Company_Reg set CompanyName= '" & txtcom.Text & "', " & "PanNo= " & txtpan.Text & ", " & "Contact_1= " & txtcon1.Text & ", " & "Contact_2= " & txtcon2.Text & " where CompanyID= " & 1
            altertable(a)
            MsgBox("Successfully Updated")


        End If
        txtcom.Clear()
        txtcon1.Clear()
        txtcon2.Clear()
        txtpan.Clear()
        rbtRegister.Checked = False
        rbtUpdate.Checked = False
        btnRegister.Hide()
        Label3.Show()
    End Sub

    Private Sub CompanyReg_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub CompanyReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If rbtRegister.Checked = False And rbtUpdate.Checked = False Then
            btnRegister.Hide()
            Label3.Show()
        End If
    End Sub

    Private Sub lblComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblComp.Click

    End Sub

    Private Sub rbtRegister_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtRegister.CheckedChanged
        If rbtRegister.Checked = True Then
            Label3.Hide()
            btnRegister.Text = "Register"
            btnRegister.Show()
            btnRegister.Enabled = True
            dbconnectcode("Select * from Company_Reg")
            If dt.Rows.Count > 0 Then
                btnRegister.Enabled = False
                MsgBox("A company is already registered. You are allowed to update only", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub rbtUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtUpdate.CheckedChanged
        If rbtUpdate.Checked = True Then
            Label3.Hide()
            btnRegister.Text = "Update"
            btnRegister.Show()
            btnRegister.Enabled = True
            dbconnectcode("Select * from Company_Reg")
            If dt.Rows.Count = 0 Then
                MsgBox("No company is registered.", MsgBoxStyle.Exclamation)
                btnRegister.Enabled = False
            Else
                txtcom.Text = dt.Rows(0)(1)
                txtpan.Text = dt.Rows(0)(2)
                txtcon1.Text = dt.Rows(0)(3)
                txtcon2.Text = dt.Rows(0)(4)
            End If

        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmHomeaa.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtpan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpan.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtpan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpan.TextChanged

    End Sub

    Private Sub txtcon1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcon1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtcon1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcon1.TextChanged

    End Sub

    Private Sub txtcon2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcon2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtcon2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcon2.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub BackUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem.Click
        ' Backup
        Dim saveDlg As New SaveFileDialog()
        Dim AppPath As String = My.Application.Info.DirectoryPath
        saveDlg.Title = "Select the Location"
        saveDlg.FileName = "Ooheim.mdb"
        If saveDlg.ShowDialog() = DialogResult.OK Then

            FileCopy(AppPath & "\Ooheim.mdb", saveDlg.FileName)
            'for creating backup of the database file in the location as given by the user
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        'Restore
        Dim AppPath As String = My.Application.Info.DirectoryPath
        If MessageBox.Show("Restoring the database will erase any changes you have made since you last backup. Are you sure you want to do this?", _
                   "Confirm Delete", _
                   MessageBoxButtons.OKCancel, _
                   MessageBoxIcon.Question, _
                   MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Dim openDlg As New OpenFileDialog
            Dim fname As String
            openDlg.Filter = "MSAccess Database Files(*.Mdb)|*.mdb"
            If openDlg.ShowDialog() = DialogResult.OK Then
                Dim cancel As String = Windows.Forms.DialogResult.Cancel.ToString
                If cancel <> "Cancel" Then
                    fname = openDlg.FileName
                    FileCopy(fname, AppPath & "\Ooheim.mdb")
                End If
            End If
        End If
        'to restore the backup file created by the user
    End Sub
End Class