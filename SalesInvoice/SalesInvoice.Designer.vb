<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salesinvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salesinvoice))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rbcust = New System.Windows.Forms.RadioButton()
        Me.Rbdet = New System.Windows.Forms.RadioButton()
        Me.Rbsum = New System.Windows.Forms.RadioButton()
        Me.Gbpar = New System.Windows.Forms.GroupBox()
        Me.btfind = New System.Windows.Forms.Button()
        Me.Txttocus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bffind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmcus = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMD_OK = New System.Windows.Forms.Button()
        Me.CMD_Exit = New System.Windows.Forms.Button()
        Me.Gbinv = New System.Windows.Forms.GroupBox()
        Me.Txttoinv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtfrminv = New System.Windows.Forms.TextBox()
        Me.Gbun = New System.Windows.Forms.GroupBox()
        Me.Btduser = New System.Windows.Forms.Button()
        Me.Txttouser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bfduser = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtfrmuser = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.Gbpar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gbinv.SuspendLayout()
        Me.Gbun.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rbcust)
        Me.GroupBox3.Controls.Add(Me.Rbdet)
        Me.GroupBox3.Controls.Add(Me.Rbsum)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 62)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Layout"
        '
        'Rbcust
        '
        Me.Rbcust.AutoSize = True
        Me.Rbcust.Location = New System.Drawing.Point(228, 28)
        Me.Rbcust.Name = "Rbcust"
        Me.Rbcust.Size = New System.Drawing.Size(80, 17)
        Me.Rbcust.TabIndex = 2
        Me.Rbcust.TabStop = True
        Me.Rbcust.Text = "Customer"
        Me.Rbcust.UseVisualStyleBackColor = True
        '
        'Rbdet
        '
        Me.Rbdet.AutoSize = True
        Me.Rbdet.Location = New System.Drawing.Point(129, 28)
        Me.Rbdet.Name = "Rbdet"
        Me.Rbdet.Size = New System.Drawing.Size(58, 17)
        Me.Rbdet.TabIndex = 1
        Me.Rbdet.TabStop = True
        Me.Rbdet.Text = "Detail"
        Me.Rbdet.UseVisualStyleBackColor = True
        '
        'Rbsum
        '
        Me.Rbsum.AutoSize = True
        Me.Rbsum.Location = New System.Drawing.Point(8, 28)
        Me.Rbsum.Name = "Rbsum"
        Me.Rbsum.Size = New System.Drawing.Size(80, 17)
        Me.Rbsum.TabIndex = 0
        Me.Rbsum.TabStop = True
        Me.Rbsum.Text = "Summary"
        Me.Rbsum.UseVisualStyleBackColor = True
        '
        'Gbpar
        '
        Me.Gbpar.Controls.Add(Me.btfind)
        Me.Gbpar.Controls.Add(Me.Txttocus)
        Me.Gbpar.Controls.Add(Me.Label2)
        Me.Gbpar.Controls.Add(Me.bffind)
        Me.Gbpar.Controls.Add(Me.Label1)
        Me.Gbpar.Controls.Add(Me.txtfrmcus)
        Me.Gbpar.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Gbpar.Location = New System.Drawing.Point(12, 188)
        Me.Gbpar.Name = "Gbpar"
        Me.Gbpar.Size = New System.Drawing.Size(332, 83)
        Me.Gbpar.TabIndex = 59
        Me.Gbpar.TabStop = False
        Me.Gbpar.Text = "Customer"
        '
        'btfind
        '
        Me.btfind.BackColor = System.Drawing.SystemColors.Control
        Me.btfind.Cursor = System.Windows.Forms.Cursors.Default
        Me.btfind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btfind.Image = CType(resources.GetObject("btfind.Image"), System.Drawing.Image)
        Me.btfind.Location = New System.Drawing.Point(307, 55)
        Me.btfind.Name = "btfind"
        Me.btfind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btfind.Size = New System.Drawing.Size(17, 20)
        Me.btfind.TabIndex = 26
        Me.btfind.TabStop = False
        Me.btfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btfind.UseVisualStyleBackColor = False
        '
        'Txttocus
        '
        Me.Txttocus.Location = New System.Drawing.Point(61, 56)
        Me.Txttocus.Name = "Txttocus"
        Me.Txttocus.Size = New System.Drawing.Size(248, 20)
        Me.Txttocus.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(5, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To"
        '
        'bffind
        '
        Me.bffind.BackColor = System.Drawing.SystemColors.Control
        Me.bffind.Cursor = System.Windows.Forms.Cursors.Default
        Me.bffind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bffind.Image = CType(resources.GetObject("bffind.Image"), System.Drawing.Image)
        Me.bffind.Location = New System.Drawing.Point(307, 28)
        Me.bffind.Name = "bffind"
        Me.bffind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bffind.Size = New System.Drawing.Size(17, 20)
        Me.bffind.TabIndex = 23
        Me.bffind.TabStop = False
        Me.bffind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bffind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'txtfrmcus
        '
        Me.txtfrmcus.Location = New System.Drawing.Point(61, 29)
        Me.txtfrmcus.Name = "txtfrmcus"
        Me.txtfrmcus.Size = New System.Drawing.Size(248, 20)
        Me.txtfrmcus.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 83)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(63, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(263, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(62, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(263, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(5, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(5, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "From"
        '
        'CMD_OK
        '
        Me.CMD_OK.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_OK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMD_OK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMD_OK.Location = New System.Drawing.Point(20, 378)
        Me.CMD_OK.Name = "CMD_OK"
        Me.CMD_OK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMD_OK.Size = New System.Drawing.Size(81, 25)
        Me.CMD_OK.TabIndex = 62
        Me.CMD_OK.Text = "Print"
        Me.CMD_OK.UseVisualStyleBackColor = False
        '
        'CMD_Exit
        '
        Me.CMD_Exit.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMD_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMD_Exit.Location = New System.Drawing.Point(263, 378)
        Me.CMD_Exit.Name = "CMD_Exit"
        Me.CMD_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMD_Exit.Size = New System.Drawing.Size(81, 25)
        Me.CMD_Exit.TabIndex = 63
        Me.CMD_Exit.Text = "Exit"
        Me.CMD_Exit.UseVisualStyleBackColor = False
        '
        'Gbinv
        '
        Me.Gbinv.Controls.Add(Me.Gbun)
        Me.Gbinv.Controls.Add(Me.Txttoinv)
        Me.Gbinv.Controls.Add(Me.Label5)
        Me.Gbinv.Controls.Add(Me.Label6)
        Me.Gbinv.Controls.Add(Me.Txtfrminv)
        Me.Gbinv.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Gbinv.Location = New System.Drawing.Point(12, 272)
        Me.Gbinv.Name = "Gbinv"
        Me.Gbinv.Size = New System.Drawing.Size(332, 83)
        Me.Gbinv.TabIndex = 60
        Me.Gbinv.TabStop = False
        Me.Gbinv.Text = "Invoice"
        Me.Gbinv.Visible = False
        '
        'Txttoinv
        '
        Me.Txttoinv.Location = New System.Drawing.Point(61, 56)
        Me.Txttoinv.Name = "Txttoinv"
        Me.Txttoinv.Size = New System.Drawing.Size(248, 20)
        Me.Txttoinv.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(5, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(5, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "From"
        '
        'Txtfrminv
        '
        Me.Txtfrminv.Location = New System.Drawing.Point(61, 29)
        Me.Txtfrminv.Name = "Txtfrminv"
        Me.Txtfrminv.Size = New System.Drawing.Size(248, 20)
        Me.Txtfrminv.TabIndex = 1
        '
        'Gbun
        '
        Me.Gbun.Controls.Add(Me.Btduser)
        Me.Gbun.Controls.Add(Me.Txttouser)
        Me.Gbun.Controls.Add(Me.Label7)
        Me.Gbun.Controls.Add(Me.Bfduser)
        Me.Gbun.Controls.Add(Me.Label8)
        Me.Gbun.Controls.Add(Me.Txtfrmuser)
        Me.Gbun.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Gbun.Location = New System.Drawing.Point(0, 5)
        Me.Gbun.Name = "Gbun"
        Me.Gbun.Size = New System.Drawing.Size(332, 83)
        Me.Gbun.TabIndex = 61
        Me.Gbun.TabStop = False
        Me.Gbun.Text = "User Name"
        Me.Gbun.Visible = False
        '
        'Btduser
        '
        Me.Btduser.BackColor = System.Drawing.SystemColors.Control
        Me.Btduser.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btduser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btduser.Image = CType(resources.GetObject("Btduser.Image"), System.Drawing.Image)
        Me.Btduser.Location = New System.Drawing.Point(307, 55)
        Me.Btduser.Name = "Btduser"
        Me.Btduser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btduser.Size = New System.Drawing.Size(17, 20)
        Me.Btduser.TabIndex = 26
        Me.Btduser.TabStop = False
        Me.Btduser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btduser.UseVisualStyleBackColor = False
        '
        'Txttouser
        '
        Me.Txttouser.Location = New System.Drawing.Point(61, 56)
        Me.Txttouser.Name = "Txttouser"
        Me.Txttouser.Size = New System.Drawing.Size(248, 20)
        Me.Txttouser.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(5, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "To"
        '
        'Bfduser
        '
        Me.Bfduser.BackColor = System.Drawing.SystemColors.Control
        Me.Bfduser.Cursor = System.Windows.Forms.Cursors.Default
        Me.Bfduser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bfduser.Image = CType(resources.GetObject("Bfduser.Image"), System.Drawing.Image)
        Me.Bfduser.Location = New System.Drawing.Point(307, 28)
        Me.Bfduser.Name = "Bfduser"
        Me.Bfduser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bfduser.Size = New System.Drawing.Size(17, 20)
        Me.Bfduser.TabIndex = 23
        Me.Bfduser.TabStop = False
        Me.Bfduser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bfduser.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(5, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "From"
        '
        'Txtfrmuser
        '
        Me.Txtfrmuser.Location = New System.Drawing.Point(61, 29)
        Me.Txtfrmuser.Name = "Txtfrmuser"
        Me.Txtfrmuser.Size = New System.Drawing.Size(248, 20)
        Me.Txtfrmuser.TabIndex = 1
        '
        'Salesinvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 415)
        Me.Controls.Add(Me.Gbinv)
        Me.Controls.Add(Me.CMD_OK)
        Me.Controls.Add(Me.CMD_Exit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Gbpar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Salesinvoice"
        Me.Text = "Sales Invoice"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Gbpar.ResumeLayout(False)
        Me.Gbpar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gbinv.ResumeLayout(False)
        Me.Gbinv.PerformLayout()
        Me.Gbun.ResumeLayout(False)
        Me.Gbun.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rbdet As System.Windows.Forms.RadioButton
    Friend WithEvents Rbsum As System.Windows.Forms.RadioButton
    Friend WithEvents Gbpar As System.Windows.Forms.GroupBox
    Public WithEvents btfind As System.Windows.Forms.Button
    Friend WithEvents Txttocus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmcus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents CMD_OK As System.Windows.Forms.Button
    Public WithEvents CMD_Exit As System.Windows.Forms.Button
    Friend WithEvents Rbcust As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Gbinv As System.Windows.Forms.GroupBox
    Friend WithEvents Txttoinv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtfrminv As System.Windows.Forms.TextBox
    Public WithEvents bffind As System.Windows.Forms.Button
    Friend WithEvents Gbun As System.Windows.Forms.GroupBox
    Public WithEvents Btduser As System.Windows.Forms.Button
    Friend WithEvents Txttouser As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Bfduser As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtfrmuser As System.Windows.Forms.TextBox

End Class
