<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomegg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomegg))
        Me.Label1 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Staff = New System.Windows.Forms.PictureBox
        Me.Stock = New System.Windows.Forms.PictureBox
        CType(Me.Staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 47)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Grid View"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LinkLabel1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(80, 415)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(73, 18)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "user mood"
        '
        'Staff
        '
        Me.Staff.Image = CType(resources.GetObject("Staff.Image"), System.Drawing.Image)
        Me.Staff.Location = New System.Drawing.Point(83, 301)
        Me.Staff.Name = "Staff"
        Me.Staff.Size = New System.Drawing.Size(199, 84)
        Me.Staff.TabIndex = 13
        Me.Staff.TabStop = False
        '
        'Stock
        '
        Me.Stock.Image = CType(resources.GetObject("Stock.Image"), System.Drawing.Image)
        Me.Stock.Location = New System.Drawing.Point(82, 175)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(199, 84)
        Me.Stock.TabIndex = 12
        Me.Stock.TabStop = False
        '
        'frmHomegg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Staff)
        Me.Controls.Add(Me.Stock)
        Me.Name = "frmHomegg"
        Me.Text = "frmHomegg"
        CType(Me.Staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Staff As System.Windows.Forms.PictureBox
    Friend WithEvents Stock As System.Windows.Forms.PictureBox
End Class
