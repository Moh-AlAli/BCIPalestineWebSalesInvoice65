'Imports AccpacCOMAPI
Public Class Touser
    Private i As Integer
    Private j As Integer
    Private Sub Touser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'os.Init("", "XX", "XX0001", "60A")
            'os.OpenWin("", "", "", SalesInvoice.compid, System.DateTime.Now, 0)
            ''os.Open("ADMIN", "ADMIN", SalesInvoice.compid, System.DateTime.Now, 0)
            'dblink = os.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadOnly)


            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("AS0003")
            'Dim ICCATds As DataSet = New DataSet("AS")
            'Dim cust As DataTable = ICCATds.Tables.Add("ASUSER")
            'Dim name As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    ICCATds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim ICCATds As New DataSet
            ICCATds = c.sainvusers("", OPCompany.compid)
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "AUDTUSER"
            icl.Name = "clidc"
            icl.HeaderText = "User Name"
            icl.Width = 150
            DGfcus.Columns.Add(icl)

            DGfcus.DataSource = ICCATds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSel.Click
        Try


            Dim c As New Clsfunct
            Dim ICCATds As New DataSet
            Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
            ICCATds = c.sainvusers(searfil, OPCompany.compid)


            'searfil = " AUDTUSER like ""%" + Txtuser.Text + "%"" "

            'arv.Browse(searfil, True)
            'Dim ICCATds As DataSet = New DataSet("AS")

            'Dim cust As DataTable = ICCATds.Tables.Add("ASUSER")
            'Dim id As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    ICCATds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim dt As DataTable = ICCATds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Salesinvoice.Txttouser.Text = dt.Rows(i)(0)
            Salesinvoice.Btduser.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DGfcus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGfcus.CellContentClick
        Try

            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("AS0003")
            'Dim searfil As String = ""

            'searfil = " AUDTUSER like ""%" + Txtuser.Text + "%"" "

            'arv.Browse(searfil, True)
            'Dim ICCATds As DataSet = New DataSet("AS")

            'Dim cust As DataTable = ICCATds.Tables.Add("ASUSER")
            'Dim id As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    ICCATds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim ICCATds As New DataSet
            Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
            ICCATds = c.sainvusers(searfil, OPCompany.compid)

            Dim dt As DataTable = ICCATds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Salesinvoice.Txttouser.Text = dt.Rows(i)(0)
            Salesinvoice.Btduser.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        Close()
        Salesinvoice.Btduser.Enabled = True
    End Sub

    Private Sub Txtcusno_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtuser.MouseLeave




        'Dim arv As AccpacView
        'arv = Salesinvoice.xdbcom.OpenView2("AS0003")
        'Dim searfil As String = ""

        'searfil = " AUDTUSER like ""%" + Txtuser.Text + "%"" "

        'arv.Browse(searfil, True)


        'Dim ICCATds As DataSet = New DataSet("AS")

        'Dim cust As DataTable = ICCATds.Tables.Add("ASUSER")
        'Dim id As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

        'cust.PrimaryKey = New DataColumn() {id}
        'Dim row As DataRow
        'row = cust.NewRow()

        'Do While arv.FilterFetch(False)

        '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

        '    row("AUDTUSER") = cid

        '    ICCATds.Tables(0).Rows.Add(row)
        '    row = cust.NewRow()

        'Loop
        Dim c As New Clsfunct
        Dim ICCATds As New DataSet
        Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
        ICCATds = c.sainvusers(searfil, OPCompany.compid)


        DGfcus.DataSource = ICCATds.Tables(0)

    End Sub



    Private Sub Txtcusno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtuser.TextChanged
        Try

            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("AS0003")
            'Dim searfil As String = ""

            'searfil = " AUDTUSER like ""%" + Txtuser.Text + "%"" "

            'arv.Browse(searfil, True)
            'Dim ICCATds As DataSet = New DataSet("AS")

            'Dim cust As DataTable = ICCATds.Tables.Add("ASUSER")
            'Dim id As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    ICCATds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim ICCATds As New DataSet
            Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
            ICCATds = c.sainvusers(searfil, OPCompany.compid)

            DGfcus.DataSource = ICCATds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Fromcust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salesinvoice.Btduser.Enabled = True
    End Sub
End Class