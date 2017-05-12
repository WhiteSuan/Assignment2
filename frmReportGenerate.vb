Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO


' Name:        frmReportGenerate.vb
' Description: Form for generate reports
' Author:      Y Nguyen
' Date:        3/25/2017


Public Class frmReportGenerate
    Public Const CONNECTION_STRING As String = _
  "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"



    'retrieve information from database and add to relevent combobox
    Private Sub ReportGenerate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection
        'retrieve customer list
        oCommand.CommandText = _
            "SELECT customer_ID, title, firstname, lastname FROM customer ;"
        oCommand.Prepare()
        Dim oDataReaderCustomer = oCommand.ExecuteReader()
        Dim sCustomer As String

        'Add customer to customer combobox
        While oDataReaderCustomer.Read()
            sCustomer = CStr(oDataReaderCustomer("customer_ID")) & " " & CStr(oDataReaderCustomer("title")) & " " & CStr(oDataReaderCustomer("firstname")) & " " & CStr(oDataReaderCustomer("lastname"))
            cboCustomer.Items.Add(sCustomer)
        End While

        oConnection.Close()
        'retrieve room number list
        oConnection.Open()
        oCommand.CommandText = _
            "SELECT room_number FROM room ;"
        oCommand.Prepare()
        Dim oDataReaderRoom = oCommand.ExecuteReader()
        'Add room number to room combobox
        While oDataReaderRoom.Read()
            cboRoom.Items.Add(oDataReaderRoom("room_number"))
        End While

        'Hidden lables and comboboxes until report is selected
        lblCustomer.Visible = False
        cboCustomer.Visible = False
        lblRoom.Visible = False
        cboRoom.Visible = False
        lblToMonth.Visible = False
        lblFromMonth.Visible = False
        lblToYear.Visible = False
        lblFromYear.Visible = False
        cboFromMonth.Visible = False
        cboToMonth.Visible = False
        tbFromYear.Visible = False
        tbToYear.Visible = False
        lblMonth.Visible = False

    End Sub

    'Do report
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click

        'Declare variables
        Dim sCommand As String
        Dim sParam As String
        Dim sPage As String
        Dim oSW_HTMLOutputFile As StreamWriter


        'If a report is selected, then generate the report
        If cboReport.SelectedIndex <> -1 Then

            sPage = g_generateReport() 'Generate report

            If sPage <> "" Then 'If there is content in report, open report
                Try
                    'Link to text file
                    oSW_HTMLOutputFile = New StreamWriter(Application.StartupPath & _
                                                        "\Report.html")
                    If Not (oSW_HTMLOutputFile Is Nothing) Then  ' Write to page
                        oSW_HTMLOutputFile.Write(sPage)
                        oSW_HTMLOutputFile.Close()
                    End If

                    ' automatically load internet explorer to show the file created.
                    sCommand = "IExplore.exe"

                    If (True = rdbFirefox.Checked) Then
                        'Load Firefox if this is checked
                        sCommand = "FireFox.exe"
                        'Load Chrome if this is checked
                    ElseIf rdbChrome.Checked Then
                        sCommand = "Chrome.exe"
                    End If

                    sParam = """" & Application.StartupPath & "\Report.html"""
                    'Open report
                    System.Diagnostics.Process.Start(sCommand, sParam)

                Catch ex As Exception
                    'Display error message if there is any
                    MessageBox.Show(ex.Message & vbCrLf)
                End Try

            End If

        Else
            'No report is chosen, display error message
            MsgBox("Please select report")
        End If

    End Sub

    'Open About page
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sCommand As String
        Dim sParam As String
        Dim oSW_HTMLOutputFile As StreamReader
        Try
            'Link to text file
            oSW_HTMLOutputFile = New StreamReader(Application.StartupPath & _
                                                "\About.htm")


            ' automatically load internet explorer to show the file created.
            sCommand = "IExplore.exe"
            'Load Firefox if this is checked
            If (True = rdbFirefox.Checked) Then
                sCommand = "FireFox.exe"
                'Load Chrome if this is checked
            ElseIf rdbChrome.Checked Then
                sCommand = "Chrome.exe"
            End If

            sParam = """" & Application.StartupPath & "\About.htm"""
            'Open about page
            System.Diagnostics.Process.Start(sCommand, sParam)

        Catch ex As Exception
            'Display error message if there is any
            MessageBox.Show(ex.Message & vbCrLf)
        End Try
    End Sub

    'Open Help page
    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sCommand As String
        Dim sParam As String
        Dim oSW_HTMLOutputFile As StreamReader
        Try
            'Link to text file
            oSW_HTMLOutputFile = New StreamReader(Application.StartupPath & _
                                                "\Help.htm")


            ' automatically load internet explorer to show the file created.
            sCommand = "IExplore.exe"
            'Load Firefox if this is checked
            If (True = rdbFirefox.Checked) Then
                sCommand = "FireFox.exe"
                'Load Chrome if this is checked
            ElseIf rdbChrome.Checked Then
                sCommand = "Chrome.exe"
            End If

            sParam = """" & Application.StartupPath & "\Help.htm"""
            'Open help file
            System.Diagnostics.Process.Start(sCommand, sParam)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf) 'Display error message if there is any
        End Try
    End Sub

    'Function to show/hide relevent report parameters
    Private Sub cboReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReport.SelectedIndexChanged
        'Make relevent lables and comboboxes visible based on selected report
        If cboReport.SelectedIndex = 0 Then
            lblCustomer.Visible = True
            cboCustomer.Visible = True
            lblRoom.Visible = False
            cboRoom.Visible = False
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = False
            cboFromMonth.Visible = False
            cboToMonth.Visible = False
            tbFromYear.Visible = False
            tbToYear.Visible = False
            lblMonth.Visible = False
        End If

        If cboReport.SelectedIndex = 1 Then
            lblCustomer.Visible = False
            cboCustomer.Visible = False
            lblRoom.Visible = True
            cboRoom.Visible = True
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = False
            cboFromMonth.Visible = False
            cboToMonth.Visible = False
            tbFromYear.Visible = False
            tbToYear.Visible = False
            lblMonth.Visible = False
        End If

        If cboReport.SelectedIndex = 2 Then
            lblCustomer.Visible = True
            cboCustomer.Visible = True
            lblRoom.Visible = False
            cboRoom.Visible = False
            lblToMonth.Visible = True
            lblFromMonth.Visible = True
            lblToYear.Visible = True
            lblFromYear.Visible = True
            cboFromMonth.Visible = True
            cboToMonth.Visible = True
            tbFromYear.Visible = True
            tbToYear.Visible = True
            lblMonth.Visible = False
        End If

        If cboReport.SelectedIndex = 3 Then
            lblCustomer.Visible = False
            cboCustomer.Visible = False
            lblRoom.Visible = False
            cboRoom.Visible = False
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = True
            cboFromMonth.Visible = True
            cboToMonth.Visible = False
            tbFromYear.Visible = True
            tbToYear.Visible = False
            lblMonth.Visible = True
        End If

        If cboReport.SelectedIndex = 4 Then
            lblCustomer.Visible = False
            cboCustomer.Visible = False
            lblRoom.Visible = False
            cboRoom.Visible = False
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = True
            cboFromMonth.Visible = True
            cboToMonth.Visible = False
            tbFromYear.Visible = True
            tbToYear.Visible = False
            lblMonth.Visible = True
        End If

        If cboReport.SelectedIndex = 5 Then
            lblCustomer.Visible = False
            cboCustomer.Visible = False
            lblRoom.Visible = True
            cboRoom.Visible = True
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = True
            cboFromMonth.Visible = True
            cboToMonth.Visible = False
            tbFromYear.Visible = True
            tbToYear.Visible = False
            lblMonth.Visible = True
        End If

        If cboReport.SelectedIndex = 6 Then
            lblCustomer.Visible = False
            cboCustomer.Visible = False
            lblRoom.Visible = False
            cboRoom.Visible = False
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = True
            cboFromMonth.Visible = True
            cboToMonth.Visible = False
            tbFromYear.Visible = True
            tbToYear.Visible = False
            lblMonth.Visible = True
        End If

        If cboReport.SelectedIndex = 7 Then
            lblCustomer.Visible = False
            cboCustomer.Visible = False
            lblRoom.Visible = False
            cboRoom.Visible = False
            lblToMonth.Visible = False
            lblFromMonth.Visible = False
            lblToYear.Visible = False
            lblFromYear.Visible = False
            cboFromMonth.Visible = False
            cboToMonth.Visible = False
            tbFromYear.Visible = False
            tbToYear.Visible = False
            lblMonth.Visible = False
        End If
    End Sub


End Class
