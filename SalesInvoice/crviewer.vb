Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class crviewer
    Private rdoc As New ReportDocument
    Private conrpt As New ConnectionInfo()
    Private server As String = ""
    Private uid As String = ""
    Private pass As String = ""
    Private odbc As String = ""
    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function
    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function

    Friend Function Readconnectionstring() As String


        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\bcicon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()
        odbc = sr.ReadLine()

        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)
        odbc = Decryption(odbc, secretkey)

        Dim cons As String = "" ' = "Data Source =" & server & "; DataBase =" & Agescreen.compid & "; User Id =" & uid & "; Password =" & pass & ";"

        Return cons
    End Function
    Private Sub crviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try



            Dim cwvr As New CrystalReportViewer
            cwvr.Dock = DockStyle.Fill
            cwvr.BorderStyle = BorderStyle.None
            Me.Controls.Add(cwvr)

            If Salesinvoice.Rbsum.Checked = True Then
                rdoc.Load("reports\OESalesInvoicesSummary.rpt")
            ElseIf Salesinvoice.Rbdet.Checked = True Then
                rdoc.Load("reports\OESalesInvoicesDetailed.rpt")
            ElseIf Salesinvoice.Rbcust.Checked = True Then
                rdoc.Load("reports\OESalesInvoicesbyCustomer.rpt")
            End If

            Dim tabs As Tables = rdoc.Database.Tables
            Dim parv As New ParameterValues
            Dim dis As New ParameterDiscreteValue


            Dim fmonthnew As String = 0
            If Salesinvoice.DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & Salesinvoice.DateTimePicker1.Value.Month
            Else
                fmonthnew = Salesinvoice.DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If Salesinvoice.DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & Salesinvoice.DateTimePicker2.Value.Month
            Else
                tmonthnew = Salesinvoice.DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If Salesinvoice.DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & Salesinvoice.DateTimePicker1.Value.Day
            Else
                fdaynew = Salesinvoice.DateTimePicker1.Value.Day
            End If

            Dim tdaynew As String = 0

            If Salesinvoice.DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & Salesinvoice.DateTimePicker2.Value.Day
            Else
                tdaynew = Salesinvoice.DateTimePicker2.Value.Day
            End If

            Dim fdate As String = Salesinvoice.DateTimePicker1.Value.Year & fmonthnew & fdaynew

            Dim tdate As String = Salesinvoice.DateTimePicker2.Value.Year & tmonthnew & tdaynew


            Readconnectionstring()

            For Each TAB As CrystalDecisions.CrystalReports.Engine.Table In tabs

                Dim tablog As TableLogOnInfo = TAB.LogOnInfo
                conrpt.ServerName = odbc '"ACCPAC62" ' 
                conrpt.DatabaseName = OPCompany.compid
                conrpt.UserID = uid '"sa" '
                conrpt.Password = pass '"admin@123" '
                tablog.ConnectionInfo = conrpt
                TAB.ApplyLogOnInfo(tablog)

            Next

            Dim sec As Section
            Dim secs As Sections
            Dim rob As ReportObject
            Dim robs As ReportObjects
            Dim subrpobj As SubreportObject
            Dim subrp As ReportDocument
            Dim crSubTables As Tables
            Dim crsubtable As Table
            secs = rdoc.ReportDefinition.Sections
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
            Dim subConInfo As New ConnectionInfo
            For Each sec In secs
                robs = sec.ReportObjects
                For Each rob In robs
                    If rob.Kind = ReportObjectKind.SubreportObject Then
                        subrpobj = CType(rob, SubreportObject)
                        subrp = subrpobj.OpenSubreport(subrpobj.SubreportName)
                        Dim name As String = subrp.Name

                        If subrp.Name = "statusSubReport" Then
                            crSubTables = subrp.Database.Tables
                            For Each crsubtable In crSubTables
                                crtableLogoninfo = crsubtable.LogOnInfo
                                subConInfo.ServerName = odbc '"ACCPAC62" '
                                subConInfo.DatabaseName = OPCompany.compid
                                subConInfo.UserID = uid ' "sa" '
                                subConInfo.Password = pass '"admin@123" '
                                crtableLogoninfo.ConnectionInfo = subConInfo 'ConInfo.ConnectionInfo
                                crsubtable.ApplyLogOnInfo(crtableLogoninfo)
                            Next
                        End If


                    End If

                Next
            Next

            'If Salesinvoice.Rbdet.Checked = True Then
            rdoc.SetParameterValue("FromDate", fdate)
            rdoc.SetParameterValue("ToDate", tdate)
            rdoc.SetParameterValue("FromCustomer", Salesinvoice.txtfrmcus.Text)
            rdoc.SetParameterValue("ToCustomer", Salesinvoice.Txttocus.Text)
            rdoc.SetParameterValue("DB", OPCompany.compid)
            rdoc.SetParameterValue("Coname", OPCompany.compname)
            'Else
            '    rdoc.SetParameterValue("FromDate", fdate)
            '    rdoc.SetParameterValue("ToDate", tdate)
            '    rdoc.SetParameterValue("FromCustomer", Salesinvoice.txtfrmcus.Text)
            '    rdoc.SetParameterValue("ToCustomer", Salesinvoice.Txttocus.Text)
            '    rdoc.SetParameterValue("FromInvno", Salesinvoice.Txtfrminv.Text)
            '    rdoc.SetParameterValue("ToInvNo", Salesinvoice.Txttoinv.Text)
            '    rdoc.SetParameterValue("FromAUDTUSER", Salesinvoice.Txtfrmuser.Text)
            '    rdoc.SetParameterValue("ToAUDTUSER", Salesinvoice.Txttouser.Text)
            'End If

            cwvr.ReportSource = rdoc

        Catch ex As Exception

        End Try

    End Sub
End Class