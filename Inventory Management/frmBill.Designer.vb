<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.lblam = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblold = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblfolio = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lblcon2 = New System.Windows.Forms.Label
        Me.Lblcon1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblpaid = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblComp = New System.Windows.Forms.Label
        Me.lblpan = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lblcusto = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DatagredBill = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.DatagredBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblam
        '
        Me.lblam.AutoSize = True
        Me.lblam.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblam.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblam.Location = New System.Drawing.Point(136, 504)
        Me.lblam.Name = "lblam"
        Me.lblam.Size = New System.Drawing.Size(25, 18)
        Me.lblam.TabIndex = 90
        Me.lblam.Text = "Rs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(67, 504)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Amount :"
        '
        'lblold
        '
        Me.lblold.AutoSize = True
        Me.lblold.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblold.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblold.Location = New System.Drawing.Point(136, 529)
        Me.lblold.Name = "lblold"
        Me.lblold.Size = New System.Drawing.Size(25, 18)
        Me.lblold.TabIndex = 88
        Me.lblold.Text = "Rs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(60, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Old Due :"
        '
        'lblfolio
        '
        Me.lblfolio.AutoSize = True
        Me.lblfolio.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolio.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblfolio.Location = New System.Drawing.Point(60, 52)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(71, 18)
        Me.lblfolio.TabIndex = 86
        Me.lblfolio.Text = "Folio No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(385, 620)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Sign of solder"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(385, 592)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(53, 13)
        Me.lblname.TabIndex = 84
        Me.lblname.Text = "username"
        '
        'lblcon2
        '
        Me.lblcon2.AutoSize = True
        Me.lblcon2.Location = New System.Drawing.Point(369, 48)
        Me.lblcon2.Name = "lblcon2"
        Me.lblcon2.Size = New System.Drawing.Size(10, 13)
        Me.lblcon2.TabIndex = 83
        Me.lblcon2.Text = ":"
        '
        'Lblcon1
        '
        Me.Lblcon1.AutoSize = True
        Me.Lblcon1.Location = New System.Drawing.Point(369, 27)
        Me.Lblcon1.Name = "Lblcon1"
        Me.Lblcon1.Size = New System.Drawing.Size(10, 13)
        Me.Lblcon1.TabIndex = 82
        Me.Lblcon1.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(374, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Contact us :"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbltotal.Location = New System.Drawing.Point(379, 531)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(25, 18)
        Me.lbltotal.TabIndex = 80
        Me.lbltotal.Text = "Rs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(278, 531)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Due Amount :"
        '
        'lblpaid
        '
        Me.lblpaid.AutoSize = True
        Me.lblpaid.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaid.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblpaid.Location = New System.Drawing.Point(379, 509)
        Me.lblpaid.Name = "lblpaid"
        Me.lblpaid.Size = New System.Drawing.Size(25, 18)
        Me.lblpaid.TabIndex = 78
        Me.lblpaid.Text = "Rs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(325, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "- Paid :"
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblComp.Location = New System.Drawing.Point(71, 9)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(158, 28)
        Me.lblComp.TabIndex = 76
        Me.lblComp.Text = "Company Name"
        '
        'lblpan
        '
        Me.lblpan.AutoSize = True
        Me.lblpan.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpan.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblpan.Location = New System.Drawing.Point(159, 37)
        Me.lblpan.Name = "lblpan"
        Me.lblpan.Size = New System.Drawing.Size(61, 18)
        Me.lblpan.TabIndex = 75
        Me.lblpan.Text = "Pan No."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Forte", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(372, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 22)
        Me.DateTimePicker1.TabIndex = 74
        '
        'lblcusto
        '
        Me.lblcusto.AutoSize = True
        Me.lblcusto.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusto.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblcusto.Location = New System.Drawing.Point(118, 70)
        Me.lblcusto.Name = "lblcusto"
        Me.lblcusto.Size = New System.Drawing.Size(188, 18)
        Me.lblcusto.TabIndex = 73
        Me.lblcusto.Text = "Mr. .............................."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(57, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 18)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Sold to"
        '
        'DatagredBill
        '
        Me.DatagredBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagredBill.Location = New System.Drawing.Point(29, 94)
        Me.DatagredBill.Name = "DatagredBill"
        Me.DatagredBill.Size = New System.Drawing.Size(519, 407)
        Me.DatagredBill.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 607)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "................................................"
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 645)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblold)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblfolio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblcon2)
        Me.Controls.Add(Me.Lblcon1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblpaid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.lblpan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblcusto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DatagredBill)
        Me.Name = "frmBill"
        Me.Text = "frmBill"
        CType(Me.DatagredBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblam As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblold As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblfolio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblcon2 As System.Windows.Forms.Label
    Friend WithEvents Lblcon1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblpaid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents lblpan As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblcusto As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DatagredBill As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
