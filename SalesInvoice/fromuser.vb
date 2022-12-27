'Imports AccpacCOMAPI

Public Class fromuser
    Private i As Integer
    Private j As Integer
    Private Sub fromuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'os.Init("", "XX", "XX0001", "60A")
            'os.OpenWin("", "", "", SalesInvoice.compid, System.DateTime.Now, 0)
            ''os.Open("ADMIN", "ADMIN", SalesInvoice.compid, System.DateTime.Now, 0)
            'dblink = os.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadOnly)


            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("CS0120")
            'Dim asds As DataSet = New DataSet("AS")
            'Dim fsql As String = "Select distinct AUDTUSER as AUDITUSER from OESHDT "
            'arv.Cancel()
            'arv.Browse(fsql, True)
            'arv.InternalSet(256)



            'Dim cust As DataTable = asds.Tables.Add("ASUSER")
            'Dim name As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()
            '    row("AUDTUSER") = cid
            '    asds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'End While
            Dim c As New Clsfunct
            Dim asds As New DataSet
            asds = c.sainvusers("", OPCompany.compid)
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "AUDTUSER"
            icl.Name = "clidc"
            icl.HeaderText = "User Name"
            icl.Width = 150
            DGfcus.Columns.Add(icl)

            DGfcus.DataSource = asds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSel.Click
        Try



            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("CS0120")
            'Dim asds As DataSet = New DataSet("AS")
            'Dim fsql As String = "select distinct AUDTUSER  from oeshdt "
            'arv.Cancel()
            'arv.Browse(fsql, True)
            'arv.InternalSet(256)

            ''arv = SalesInvoice.xdbcom.OpenView2("AS0003")

            'Dim cust As DataTable = asds.Tables.Add("ASUSER")
            'Dim name As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    asds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim asds As New DataSet
            Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
            asds = c.sainvusers(searfil, OPCompany.compid)
            Dim dt As DataTable = asds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Salesinvoice.Txtfrmuser.Text = dt.Rows(i)(0)
            Salesinvoice.Bfduser.Enabled = True
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        Close()
        Salesinvoice.Bfduser.Enabled = True
    End Sub

    Private Sub Txtcusno_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtuser.MouseLeave





        'Dim arv As AccpacView
        'arv = Salesinvoice.xdbcom.OpenView2("CS0120")
        'Dim asds As DataSet = New DataSet("AS")
        'Dim fsql As String = "select distinct AUDTUSER  from oeshdt "
        'arv.Cancel()
        'arv.Browse(fsql, True)
        'arv.InternalSet(256)

        ''arv = SalesInvoice.xdbcom.OpenView2("AS0003")

        'Dim cust As DataTable = asds.Tables.Add("ASUSER")
        'Dim name As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

        'Dim row As DataRow
        'row = cust.NewRow()
        'Do While arv.FilterFetch(False)
        '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

        '    row("AUDTUSER") = cid

        '    asds.Tables(0).Rows.Add(row)
        '    row = cust.NewRow()
        Dim c As New Clsfunct
        Dim asds As New DataSet
        Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
        asds = c.sainvusers(searfil, OPCompany.compid)
        DGfcus.DataSource = asds.Tables(0)

    End Sub



    Private Sub Txtcusno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtuser.TextChanged
        Try


            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("CS0120")
            'Dim asds As DataSet = New DataSet("AS")
            'Dim fsql As String = "select distinct AUDTUSER  from oeshdt "
            'arv.Cancel()
            'arv.Browse(fsql, True)
            'arv.InternalSet(256)

            ''arv = SalesInvoice.xdbcom.OpenView2("AS0003")

            'Dim cust As DataTable = asds.Tables.Add("ASUSER")
            'Dim name As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    asds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim asds As New DataSet
            Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
            asds = c.sainvusers(searfil, OPCompany.compid)
            DGfcus.DataSource = asds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DGfcus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGfcus.CellContentClick
        Try

            'Dim arv As AccpacView
            'arv = Salesinvoice.xdbcom.OpenView2("CS0120")
            'Dim asds As DataSet = New DataSet("AS")
            'Dim fsql As String = "select distinct AUDTUSER  from oeshdt "
            'arv.Cancel()
            'arv.Browse(fsql, True)
            'arv.InternalSet(256)

            ''arv = SalesInvoice.xdbcom.OpenView2("AS0003")

            'Dim cust As DataTable = asds.Tables.Add("ASUSER")
            'Dim name As DataColumn = cust.Columns.Add("AUDTUSER", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("AUDTUSER").Value.ToString()

            '    row("AUDTUSER") = cid

            '    asds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim asds As New DataSet
            Dim searfil As String = " Where AUDTUSER like '%" & Txtuser.Text & "%'"
            asds = c.sainvusers(searfil, OPCompany.compid)
            Dim dt As DataTable = asds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Salesinvoice.Txtfrmuser.Text = dt.Rows(i)(0)
            Salesinvoice.Bfduser.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Fromcust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salesinvoice.Bfduser.Enabled = True
    End Sub
End Class