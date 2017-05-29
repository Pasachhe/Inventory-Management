<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeaa
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
        Me.User_ID = New System.Windows.Forms.Button
        Me.Company = New System.Windows.Forms.Button
        Me.Vendor = New System.Windows.Forms.Button
        Me.Salary = New System.Windows.Forms.Button
        Me.Staff = New System.Windows.Forms.Button
        Me.Customer = New System.Windows.Forms.Button
        Me.Stock = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'User_ID
        '
        Me.User_ID.Location = New System.Drawing.Point(252, 67)
        Me.User_ID.Name = "User_ID"
        Me.User_ID.Size = New System.Drawing.Size(84, 45)
        Me.User_ID.TabIndex = 0
        Me.User_ID.Text = "UserId"
        Me.User_ID.UseVisualStyleBackColor = True
        '
        'Company
        '
        Me.Company.Location = New System.Drawing.Point(453, 67)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(84, 45)
        Me.Company.TabIndex = 0
        Me.Company.Text = "Company"
        Me.Company.UseVisualStyleBackColor = True
        '
        'Vendor
        '
        Me.Vendor.Location = New System.Drawing.Point(603, 197)
        Me.Vendor.Name = "Vendor"
        Me.Vendor.Size = New System.Drawing.Size(84, 45)
        Me.Vendor.TabIndex = 0
        Me.Vendor.Text = "Vendor"
        Me.Vendor.UseVisualStyleBackColor = True
        '
        'Salary
        '
        Me.Salary.Location = New System.Drawing.Point(453, 303)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(84, 45)
        Me.Salary.TabIndex = 0
        Me.Salary.Text = "Salary"
        Me.Salary.UseVisualStyleBackColor = True
        '
        'Staff
        '
        Me.Staff.Location = New System.Drawing.Point(252, 303)
        Me.Staff.Name = "Staff"
        Me.Staff.Size = New System.Drawing.Size(84, 45)
        Me.Staff.TabIndex = 0
        Me.Staff.Text = "Staff"
        Me.Staff.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.Customer.Location = New System.Drawing.Point(107, 197)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(84, 45)
        Me.Customer.TabIndex = 0
        Me.Customer.Text = "Customer"
        Me.Customer.UseVisualStyleBackColor = True
        '
        'Stock
        '
        Me.Stock.Location = New System.Drawing.Point(355, 184)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(84, 45)
        Me.Stock.TabIndex = 0
        Me.Stock.Text = "Stock"
        Me.Stock.UseVisualStyleBackColor = True
        '
        'frmHomeaa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 409)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Customer)
        Me.Controls.Add(Me.Staff)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Vendor)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.User_ID)
        Me.Name = "frmHomeaa"
        Me.Text = "frmHomeaa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents User_ID As System.Windows.Forms.Button
    Friend WithEvents Company As System.Windows.Forms.Button
    Friend WithEvents Vendor As System.Windows.Forms.Button
    Friend WithEvents Salary As System.Windows.Forms.Button
    Friend WithEvents Staff As System.Windows.Forms.Button
    Friend WithEvents Customer As System.Windows.Forms.Button
    Friend WithEvents Stock As System.Windows.Forms.Button
End Class
