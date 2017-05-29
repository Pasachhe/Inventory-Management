<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserMood
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btngue = New System.Windows.Forms.Button
        Me.btnadm = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btngue
        '
        Me.btngue.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngue.ForeColor = System.Drawing.Color.Brown
        Me.btngue.Location = New System.Drawing.Point(248, 168)
        Me.btngue.Name = "btngue"
        Me.btngue.Size = New System.Drawing.Size(101, 72)
        Me.btngue.TabIndex = 5
        Me.btngue.Text = "Guest"
        Me.btngue.UseVisualStyleBackColor = True
        '
        'btnadm
        '
        Me.btnadm.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadm.ForeColor = System.Drawing.Color.Brown
        Me.btnadm.Location = New System.Drawing.Point(248, 53)
        Me.btnadm.Name = "btnadm"
        Me.btnadm.Size = New System.Drawing.Size(101, 72)
        Me.btnadm.TabIndex = 4
        Me.btnadm.Text = "Admin"
        Me.btnadm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(6, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 79)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Login as"
        '
        'frmUserMood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 292)
        Me.Controls.Add(Me.btngue)
        Me.Controls.Add(Me.btnadm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUserMood"
        Me.Text = "frmUserMood"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btngue As System.Windows.Forms.Button
    Friend WithEvents btnadm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
