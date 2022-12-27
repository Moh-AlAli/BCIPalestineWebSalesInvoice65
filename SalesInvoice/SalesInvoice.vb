'Imports AccpacCOMAPI
Public Class Salesinvoice
    '   Friend compid As String = ""
    'Private acsignon As New AccpacSignonManager.AccpacSignonMgr
    'Friend mSession As New AccpacCOMAPI.AccpacSession
    'Friend xdbcom As AccpacDBLink

    Private Sub Salesinvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'mSession.Init("", "XX", "XX0001", "65A")
            'acsignon.Signon(mSession)
            'compid = mSession.CompanyID
            'xdbcom = mSession.GetDBLink(tagDBLinkTypeEnum.DBLINK_COMPANY, tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)
            'If compid = "" Then
            '    Close()
            'End If

            Txttocus.Text = "zzzzzzzzzzzzzzzzzzzzzz"
            Txttoinv.Text = "zzzzzzzzzzzzzzzzzzzzzz"
            Txttouser.Text = "zzzzzzzzzzzzzzzzzzzzzz"
            Rbsum.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
    End Sub
    Private Sub CMD_OK_Click(sender As Object, e As EventArgs) Handles CMD_OK.Click
        Try

            Dim fmonthnew As String = 0
            If DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & DateTimePicker1.Value.Month
            Else
                fmonthnew = DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & DateTimePicker2.Value.Month
            Else
                tmonthnew = DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & DateTimePicker1.Value.Day
            Else
                fdaynew = DateTimePicker1.Value.Day
            End If
            Dim tdaynew As String = 0
            If DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & DateTimePicker2.Value.Day
            Else
                tdaynew = DateTimePicker2.Value.Day
            End If

            Dim fdate As String = DateTimePicker1.Value.Year & fmonthnew & fdaynew

            Dim tdate As String = DateTimePicker2.Value.Year & tmonthnew & tdaynew

            If Trim(txtfrmcus.Text) <= Trim(Txttocus.Text) Then
                If Trim(Txtfrminv.Text) <= Trim(Txttoinv.Text) Then
                    If Trim(Txtfrmuser.Text) <= Trim(Txttouser.Text) Then
                        If fdate <= tdate Then
                            crviewer.Show()
                        Else
                            MessageBox.Show("From Date  greater than To Date")
                        End If
                    Else
                        MessageBox.Show("From User  greater than To User")
                    End If
                Else
                    MessageBox.Show("From Invoice  greater than To Invoice")
                End If
            Else
                MessageBox.Show("From Customer No greater than To Customer No")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bffind_Click(sender As Object, e As EventArgs) Handles bffind.Click
        FromCustomer.Show()
        bffind.Enabled = False
    End Sub
    Private Sub btfind_Click(sender As Object, e As EventArgs) Handles btfind.Click
        Dim f As Form = New ToCustomer
        f.Show()
        btfind.Enabled = False
    End Sub
    Private Sub CMD_Exit_Click(sender As Object, e As EventArgs) Handles CMD_Exit.Click
        Close()
    End Sub

  

    Private Sub Bfduser_Click(sender As Object, e As EventArgs) Handles Bfduser.Click
        fromuser.Show()
        Bfduser.Enabled = False
    End Sub

    Private Sub Btduser_Click(sender As Object, e As EventArgs) Handles Btduser.Click
        Touser.Show()
        Btduser.Enabled = False
    End Sub
End Class
