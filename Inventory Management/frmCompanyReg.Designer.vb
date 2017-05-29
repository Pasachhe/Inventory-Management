<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyReg
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
        Me.rbtUpdate = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.BackUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.rbtRegister = New System.Windows.Forms.RadioButton
        Me.CompanyTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtcon1 = New System.Windows.Forms.TextBox
        Me.btnRegister = New System.Windows.Forms.Button
        Me.txtcon2 = New System.Windows.Forms.TextBox
        Me.txtpan = New System.Windows.Forms.TextBox
        Me.txtcom = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblComp = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtUpdate
        '
        Me.rbtUpdate.AutoSize = True
        Me.rbtUpdate.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbtUpdate.Location = New System.Drawing.Point(202, 20)
        Me.rbtUpdate.Name = "rbtUpdate"
        Me.rbtUpdate.Size = New System.Drawing.Size(102, 32)
        Me.rbtUpdate.TabIndex = 1
        Me.rbtUpdate.TabStop = True
        Me.rbtUpdate.Text = "Update"
        Me.rbtUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Harlow Solid Italic", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(105, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 61)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Ooheim"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(415, 270)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 44)
        Me.btnBack.TabIndex = 79
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(113, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Select to register or update company information!!"
        '
        'BackUpToolStripMenuItem
        '
        Me.BackUpToolStripMenuItem.Name = "BackUpToolStripMenuItem"
        Me.BackUpToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.BackUpToolStripMenuItem.Text = "Backup"
        '
        'rbtRegister
        '
        Me.rbtRegister.AutoSize = True
        Me.rbtRegister.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbtRegister.Location = New System.Drawing.Point(37, 20)
        Me.rbtRegister.Name = "rbtRegister"
        Me.rbtRegister.Size = New System.Drawing.Size(107, 32)
        Me.rbtRegister.TabIndex = 0
        Me.rbtRegister.TabStop = True
        Me.rbtRegister.Text = "Register"
        Me.rbtRegister.UseVisualStyleBackColor = True
        '
        'CompanyTransactionToolStripMenuItem
        '
        Me.CompanyTransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackUpToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.CompanyTransactionToolStripMenuItem.Name = "CompanyTransactionToolStripMenuItem"
        Me.CompanyTransactionToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.CompanyTransactionToolStripMenuItem.Text = "Company Transaction"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.rbtUpdate)
        Me.Panel1.Controls.Add(Me.rbtRegister)
        Me.Panel1.Location = New System.Drawing.Point(346, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 67)
        Me.Panel1.TabIndex = 77
        '
        'txtcon1
        '
        Me.txtcon1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcon1.Location = New System.Drawing.Point(275, 199)
        Me.txtcon1.Name = "txtcon1"
        Me.txtcon1.Size = New System.Drawing.Size(181, 31)
        Me.txtcon1.TabIndex = 76
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(557, 270)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(117, 44)
        Me.btnRegister.TabIndex = 75
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtcon2
        '
        Me.txtcon2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcon2.Location = New System.Drawing.Point(471, 199)
        Me.txtcon2.Name = "txtcon2"
        Me.txtcon2.Size = New System.Drawing.Size(181, 31)
        Me.txtcon2.TabIndex = 73
        '
        'txtpan
        '
        Me.txtpan.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpan.Location = New System.Drawing.Point(275, 162)
        Me.txtpan.Name = "txtpan"
        Me.txtpan.Size = New System.Drawing.Size(375, 31)
        Me.txtpan.TabIndex = 74
        '
        'txtcom
        '
        Me.txtcom.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcom.Location = New System.Drawing.Point(275, 124)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.Size = New System.Drawing.Size(377, 31)
        Me.txtcom.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(111, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Contact :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(111, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 28)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Pan No."
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblComp.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblComp.Location = New System.Drawing.Point(111, 124)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(158, 28)
        Me.lblComp.TabIndex = 69
        Me.lblComp.Text = "Company Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyTransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 81
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmCompanyReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 357)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcon1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtcon2)
        Me.Controls.Add(Me.txtpan)
        Me.Controls.Add(Me.txtcom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmCompanyReg"
        Me.Text = "frmCompanyReg"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbtRegister As System.Windows.Forms.RadioButton
    Friend WithEvents CompanyTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtcon1 As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtcon2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpan As System.Windows.Forms.TextBox
    Friend WithEvents txtcom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
