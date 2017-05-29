<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLedgerCustomer
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
        Me.btnplus = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.comitem = New System.Windows.Forms.ComboBox
        Me.btnamo = New System.Windows.Forms.Button
        Me.txtamo = New System.Windows.Forms.TextBox
        Me.txtquan = New System.Windows.Forms.TextBox
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnback = New System.Windows.Forms.Button
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.btncancel = New System.Windows.Forms.Button
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnScreenManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnbill = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.btnrec = New System.Windows.Forms.Button
        Me.txtpaid = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnclr = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Reg_Date = New System.Windows.Forms.DateTimePicker
        Me.lblnam = New System.Windows.Forms.Label
        Me.lblrs = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnplus
        '
        Me.btnplus.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.Location = New System.Drawing.Point(230, 52)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(56, 78)
        Me.btnplus.TabIndex = 17
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnplus)
        Me.GroupBox1.Controls.Add(Me.comitem)
        Me.GroupBox1.Controls.Add(Me.btnamo)
        Me.GroupBox1.Controls.Add(Me.txtamo)
        Me.GroupBox1.Controls.Add(Me.txtquan)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 188)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'comitem
        '
        Me.comitem.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comitem.FormattingEnabled = True
        Me.comitem.Location = New System.Drawing.Point(97, 9)
        Me.comitem.Name = "comitem"
        Me.comitem.Size = New System.Drawing.Size(185, 33)
        Me.comitem.TabIndex = 15
        '
        'btnamo
        '
        Me.btnamo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.btnamo.Location = New System.Drawing.Point(9, 142)
        Me.btnamo.Name = "btnamo"
        Me.btnamo.Size = New System.Drawing.Size(90, 33)
        Me.btnamo.TabIndex = 13
        Me.btnamo.Text = "Amount"
        Me.btnamo.UseVisualStyleBackColor = True
        '
        'txtamo
        '
        Me.txtamo.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamo.Location = New System.Drawing.Point(97, 142)
        Me.txtamo.Name = "txtamo"
        Me.txtamo.Size = New System.Drawing.Size(185, 33)
        Me.txtamo.TabIndex = 10
        '
        'txtquan
        '
        Me.txtquan.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquan.Location = New System.Drawing.Point(97, 97)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(127, 33)
        Me.txtquan.TabIndex = 11
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(97, 54)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(127, 33)
        Me.txtrate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(9, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(9, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(9, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Item Out"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(563, 408)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(109, 39)
        Me.btnback.TabIndex = 60
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockToolStripMenuItem, Me.StaffToolStripMenuItem, Me.VendorToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem1.Text = "View"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VendorToolStripMenuItem.Text = "Vendor"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockToolStripMenuItem1, Me.StaffToolStripMenuItem1})
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'StockToolStripMenuItem1
        '
        Me.StockToolStripMenuItem1.Name = "StockToolStripMenuItem1"
        Me.StockToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.StockToolStripMenuItem1.Text = "Stock"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.StaffToolStripMenuItem1.Text = "Staff"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(448, 408)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(109, 39)
        Me.btncancel.TabIndex = 58
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 65
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1, Me.LockToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Home"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.OnScreenManualToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OnScreenManualToolStripMenuItem
        '
        Me.OnScreenManualToolStripMenuItem.Name = "OnScreenManualToolStripMenuItem"
        Me.OnScreenManualToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.OnScreenManualToolStripMenuItem.Text = "On Screen Manual"
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(588, 364)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(78, 34)
        Me.btnprint.TabIndex = 64
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnbill
        '
        Me.btnbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbill.Location = New System.Drawing.Point(588, 324)
        Me.btnbill.Name = "btnbill"
        Me.btnbill.Size = New System.Drawing.Size(78, 34)
        Me.btnbill.TabIndex = 63
        Me.btnbill.Text = "Bill"
        Me.btnbill.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Click CANCEL button to clear all the digits."
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(526, 252)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(147, 29)
        Me.txtFolio.TabIndex = 59
        '
        'btnrec
        '
        Me.btnrec.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrec.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnrec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrec.Location = New System.Drawing.Point(448, 325)
        Me.btnrec.Name = "btnrec"
        Me.btnrec.Size = New System.Drawing.Size(134, 74)
        Me.btnrec.TabIndex = 57
        Me.btnrec.Text = "Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transaction"
        Me.btnrec.UseVisualStyleBackColor = True
        '
        'txtpaid
        '
        Me.txtpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaid.Location = New System.Drawing.Point(526, 288)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.Size = New System.Drawing.Size(146, 31)
        Me.txtpaid.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(453, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 36)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Paid"
        '
        'btnclr
        '
        Me.btnclr.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.Location = New System.Drawing.Point(320, 352)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(118, 46)
        Me.btnclr.TabIndex = 54
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(659, 181)
        Me.DataGridView1.TabIndex = 53
        '
        'Reg_Date
        '
        Me.Reg_Date.CalendarFont = New System.Drawing.Font("Forte", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reg_Date.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reg_Date.Location = New System.Drawing.Point(460, 34)
        Me.Reg_Date.Name = "Reg_Date"
        Me.Reg_Date.Size = New System.Drawing.Size(216, 22)
        Me.Reg_Date.TabIndex = 52
        '
        'lblnam
        '
        Me.lblnam.AutoSize = True
        Me.lblnam.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnam.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblnam.Location = New System.Drawing.Point(146, 28)
        Me.lblnam.Name = "lblnam"
        Me.lblnam.Size = New System.Drawing.Size(299, 28)
        Me.lblnam.TabIndex = 49
        Me.lblnam.Text = "Mr. ........................................."
        '
        'lblrs
        '
        Me.lblrs.AutoSize = True
        Me.lblrs.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrs.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblrs.Location = New System.Drawing.Point(320, 300)
        Me.lblrs.Name = "lblrs"
        Me.lblrs.Size = New System.Drawing.Size(48, 39)
        Me.lblrs.TabIndex = 48
        Me.lblrs.Text = "Rs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(456, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 28)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Folio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Account of"
        '
        'frmLedgerCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnbill)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.btnrec)
        Me.Controls.Add(Me.txtpaid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Reg_Date)
        Me.Controls.Add(Me.lblnam)
        Me.Controls.Add(Me.lblrs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLedgerCustomer"
        Me.Text = "frmLedgerCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnplus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comitem As System.Windows.Forms.ComboBox
    Friend WithEvents btnamo As System.Windows.Forms.Button
    Friend WithEvents txtamo As System.Windows.Forms.TextBox
    Friend WithEvents txtquan As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnScreenManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnbill As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents btnrec As System.Windows.Forms.Button
    Friend WithEvents txtpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Reg_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblnam As System.Windows.Forms.Label
    Friend WithEvents lblrs As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
