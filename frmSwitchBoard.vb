Option Explicit On
Option Strict On
Imports System.Data.OleDb
Imports System.IO

'Project: Developing a Hotel Room Reservation Information System (HRRIS)
'Programmer: Nguyen Ngoc Xuan Y, s3536091, Semester A, 2017
'Day/Time of tutorial: Friday, 7th April
'Attribution: VB.Net Forum, Stackoverflow, MSDN website, Lecturer Slides, Tutorials Week 1-5

Public Class frmSwitchBoard
    Public Const CONNECTION_STRING As String = _
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    'Show Customer form if click on Customer button
    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        'hide the current Switchboard
        Me.Hide()

    End Sub

    'Show Booking form if click on Booking button
    Private Sub btnBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooking.Click   
        frmBooking.Show()
        'hide the current Switchboard
        Me.Hide()

    End Sub

    'Show Room form if click on Room button
    Private Sub btnRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoom.Click
        frmRoom.Show()
        'hide the current Switchboard
        Me.Hide()
    End Sub
   
    'Show Report Generate form if click on Report button
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        frmReportGenerate.Show()
        'hide the current Switchboard
        Me.Hide()
    End Sub

    'when click on About tab in Menu strip at the top left of switchboard form
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim sCommand As String
        Dim sParam As String
        Dim oSW_HTMLOutputFile As StreamReader
        Try
            oSW_HTMLOutputFile = New StreamReader(Application.StartupPath & _
                                                "\About.htm") 'Link to text file


            ' automatically load internet explorer to show the file created.
            sCommand = "IExplore.exe"
            sParam = """" & Application.StartupPath & "\About.htm"""
            System.Diagnostics.Process.Start(sCommand, sParam) 'Open about page

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf) 'Display error message if there is any
        End Try
    End Sub

    'when click on Help tab in Menu strip at the top left of switchboard form
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Dim sCommand As String
        Dim sParam As String
        Dim oSW_HTMLOutputFile As StreamReader
        Try
            oSW_HTMLOutputFile = New StreamReader(Application.StartupPath & _
                                                "\Help.htm") 'Link to text file

            ' automatically load internet explorer to show the file created.
            sCommand = "IExplore.exe"
            sParam = """" & Application.StartupPath & "\Help.htm"""
            System.Diagnostics.Process.Start(sCommand, sParam) 'Open help page

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf) 'Display error message if there is any
        End Try
    End Sub
End Class