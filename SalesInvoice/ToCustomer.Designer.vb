<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tocustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tocustomer))
        Me.Butcan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGtocus = New System.Windows.Forms.DataGridView()
        Me.ButSel = New System.Windows.Forms.Button()
        Me.Txtcusno = New System.Windows.Forms.TextBox()
        CType(Me.DGtocus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Butcan
        '
        Me.Butcan.Location = New System.Drawing.Point(292, 314)
        Me.Butcan.Name = "Butcan"
        Me.Butcan.Size = New System.Drawing.Size(75, 23)
        Me.Butcan.TabIndex = 69
        Me.Butcan.Text = "Cancel"
        Me.Butcan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Customer Name"
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(107, 35)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(237, 20)
        Me.Txtname.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Customer No"
        '
        'DGtocus
        '
        Me.DGtocus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtocus.Location = New System.Drawing.Point(0, 60)
        Me.DGtocus.Name = "DGtocus"
        Me.DGtocus.Size = New System.Drawing.Size(388, 244)
        Me.DGtocus.TabIndex = 67
        '
        'ButSel
        '
        Me.ButSel.Location = New System.Drawing.Point(20, 314)
        Me.ButSel.Name = "ButSel"
        Me.ButSel.Size = New System.Drawing.Size(75, 23)
        Me.ButSel.TabIndex = 68
        Me.ButSel.Text = "Select"
        Me.ButSel.UseVisualStyleBackColor = True
        '
        'Txtcusno
        '
        Me.Txtcusno.Location = New System.Drawing.Point(108, 12)
        Me.Txtcusno.Name = "Txtcusno"
        Me.Txtcusno.Size = New System.Drawing.Size(237, 20)
        Me.Txtcusno.TabIndex = 63
        '
        'ToCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 348)
        Me.Controls.Add(Me.Butcan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGtocus)
        Me.Controls.Add(Me.ButSel)
        Me.Controls.Add(Me.Txtcusno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ToCustomer"
        Me.Text = "To Customer"
        CType(Me.DGtocus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butcan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGtocus As System.Windows.Forms.DataGridView
    Friend WithEvents ButSel As System.Windows.Forms.Button
    Friend WithEvents Txtcusno As System.Windows.Forms.TextBox
End Class
