Public Class frmlogin

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from UserInfo")
        If dt.Rows.Count = 0 Then
            logbtn.Enabled = False
        Else
            Createbtn.Hide()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub logbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logbtn.Click
        dbconnectcode("Select * from UserInfo")

        Dim i As Integer
        Dim z As Integer
        z = dt.Rows.Count - 1
        If dt.Rows.Count = 0 Then
            MsgBox("Add username and Password", MsgBoxStyle.Exclamation)
            GoTo top
        End If
        If namtxt.Text = "" Or passtxt.Text = "" Then
            MsgBox("Fill Username and password properly", MsgBoxStyle.Information)
            GoTo top
        End If

        For i = 0 To z
            If namtxt.Text = dt.Rows(i)(1) Then
                If passtxt.Text = dt.Rows(i)(2) Then
                    username = namtxt.Text
                    frmHomeaa.Show()
                    Me.Hide()
                    GoTo top
                End If
            End If
        Next i

        MsgBox("Invalid username or Password", MsgBoxStyle.Critical)
        namtxt.Clear()
        passtxt.Clear()
top:
    End Sub

    Private Sub Closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Createbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Createbtn.Click
        AdminAc.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmUserMood.Show()

    End Sub
End Class