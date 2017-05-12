Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name:        mReportGenerate.vb
' Description: Form for generating report
' Author:      Y Nguyen
' Date:        5/12/2017

Module mReportGenerate

    'Generate Report
    Public Function g_generateReport() As String

        Dim sSQL As String
        Dim sConnection As String
        Dim oConn_Hotels As OleDbConnection  'To instantiate Connection obj.
        Dim oCmd_Hotels As OleDbCommand      'To Instantiate a Command obj.
        Dim oDataReader As OleDbDataReader    'To instantiate a DataReader obj.
        Dim sPageText As String = ""

        'Get SQL
        sSQL = getSQL()
        Debug.WriteLine("sSql=" & sSQL)

        If sSQL <> "" Then 'If no problem in obtain SQL, then Generate report

            Try
                ' Build connection string to connect to OleDB Data provider
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Assignment1.accdb;Jet OLEDB:Database Password=MyDbPassword;"

                'Establish connection to Hotel database using the connection string
                oConn_Hotels = New OleDbConnection(sConnection)
                oConn_Hotels.Open()

                'Create a database command object using the connection object and set the SQL statement it will execute
                oCmd_Hotels = oConn_Hotels.CreateCommand()
                oCmd_Hotels.CommandText = sSQL

                'Execute SQL command and place results into a datareader 
                oDataReader = oCmd_Hotels.ExecuteReader()

                'Do Page Heading
                sPageText = selectReport(frmReportGenerate.cboReport.SelectedIndex, oDataReader)
                sPageText = sPageText & g_sHTMLFooter() & vbCrLf


            Catch ex As Exception
                'display error message if there is any
                MessageBox.Show(ex.Message)

            Finally

                'Close down various objects used.
                If Not IsNothing(oDataReader) Then oDataReader.Close()
                If Not IsNothing(oCmd_Hotels) Then oCmd_Hotels.Dispose()
                If Not IsNothing(oConn_Hotels) Then oConn_Hotels.Close()

            End Try
        End If

        Return sPageText

    End Function

    'Generate HTML header
    Public Function g_sHTMLHeader(ByVal sListName As String) As String

        Dim sHeading As String
        sHeading = "<html><head><title>HOTEL ROOM RESERVATION REPORT</title></head><body>"
        sHeading = sHeading & vbCrLf & "<center><font color=""black""><h1>HOTEL ROOM RESERVATION REPORT</h1></font></center>" & vbCrLf
        sHeading = sHeading & "<HR width= 400>" & vbCrLf
        sHeading = sHeading & vbCrLf & "<center><font color = ""blue""><h2>" & sListName & "</h2></font></center>"
        Return sHeading

    End Function

    'Generate HTML Footer
    Public Function g_sHTMLFooter() As String

        Dim sTemp As String = "</body>" & vbCrLf & "</html>"
        Return sTemp

    End Function

    'Select Report based on report index
    Public Function selectReport(ByVal iSelect As Integer, ByVal oDataReader As OleDbDataReader) As String

        'Declare variable
        Dim sPageText As String
        Dim bValid As Boolean = True
        Dim bHasRecord = False
        Select Case iSelect

            Case 0 'Report 1
                sPageText = doReport1(oDataReader, sPageText, bHasRecord)

            Case 1 'Report 2
                sPageText = doReport2(oDataReader, sPageText, bHasRecord)

            Case 2 'Report 3
                sPageText = doReport3(oDataReader, sPageText, bHasRecord)

            Case 3 'Report 4
                sPageText = doReport4(oDataReader, sPageText, bHasRecord)

            Case 4 'Report 5
                sPageText = doReport5(oDataReader, sPageText, bHasRecord)

            Case 5 'Report 6
                sPageText = doReport6(oDataReader, sPageText, bHasRecord)

            Case 6 'Report 7
                sPageText = doReport7(oDataReader, sPageText, bHasRecord)

            Case 7 'Report 8
                sPageText = doReport8(oDataReader, sPageText, bHasRecord)
        End Select

        Return sPageText

    End Function

    'Do report number 1
    Private Function doReport1(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String

        'Generate report header
        sPageText = g_sHTMLHeader("Last booking of selected Customer") & vbCrLf
        'check if there is any booking
        Do While oDataReader.Read
            If oDataReader.Item("booking_id").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If
            'If query does return result => display last booking information
            If bHasRecord = True Then

                sPageText = sPageText & "The last booking of customer " & oDataReader.Item("title").ToString & " " & oDataReader.Item("firstname").ToString & " " & oDataReader.Item("lastname").ToString & " was booked on " & oDataReader.Item("booking_date").ToString & " , Booking ID: " & oDataReader.Item("booking_ID").ToString & " , Room Number: " & oDataReader.Item("room_number").ToString & " , Duration: " & oDataReader.Item("num_days").ToString & " Day(s)."
            Else
                'If there is no booking yet, display message
                sPageText = sPageText & "There is no booking for the customer " & oDataReader.Item("title").ToString & " " & oDataReader.Item("firstname").ToString & " " & oDataReader.Item("lastname").ToString & " yet !"

            End If
        Loop

        Return sPageText
    End Function

    'Do report number 2
    Private Function doReport2(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String

        'Generate report header
        sPageText = g_sHTMLHeader("Last booking of selected Room") & vbCrLf
        'check if there is any booking
        Do While oDataReader.Read
            If oDataReader.Item("room_number").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If
            'If query does return result => display last booking information
            If bHasRecord = True Then

                sPageText = sPageText & "The last booking of room number " & " " & oDataReader.Item("room_number").ToString & " was booked on " & oDataReader.Item("booking_date").ToString & " , with the total price: " & oDataReader.Item("total_price").ToString
            Else
                'If there is no booking yet, display message
                sPageText = sPageText & "There is no booking for the room number " & oDataReader.Item("room_number").ToString & " yet !"

            End If
        Loop


        Return sPageText
    End Function

    'Do report number 3
    Private Function doReport3(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String

        'Get from date and to date
        Dim sFromDate As String = frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text
        Dim sToDate As String = frmReportGenerate.cboToMonth.Text & "/" & frmReportGenerate.tbToYear.Text
        'Generate report header
        sPageText = g_sHTMLHeader("Total number of rooms booked by a customer") & vbCrLf
        'check if there is any booking
        Do While oDataReader.Read
            If oDataReader.Item("total_booking").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If
            'If query does return result => display last booking information
            If bHasRecord = True Then

                sPageText = sPageText & "Total number of rooms booked by customer " & oDataReader.Item("title").ToString & " " & oDataReader.Item("firstname").ToString & " " & oDataReader.Item("lastname").ToString & " , from " & sFromDate & " to " & sToDate & " is " & oDataReader.Item("total_booking").ToString & " room(s)"
            Else
                'If there is no booking yet, display message
                sPageText = sPageText & "Customer " & oDataReader.Item("title").ToString & " " & oDataReader.Item("firstname").ToString & " " & oDataReader.Item("lastname").ToString & " , from " & sFromDate & " to " & sToDate & " has no booking!"

            End If
        Loop

        Return sPageText
    End Function

    'Do report number 4
    Private Function doReport4(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String
        Dim bFirstTime As Boolean = True

        'Generate report header
        sPageText = g_sHTMLHeader("List of all booking made in " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text) & vbCrLf


        Do While oDataReader.Read
            'check if there is any booking
            If oDataReader.Item("booking_id").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If

            If bHasRecord = True Then
                'If this is the first row of record
                If bFirstTime Then
                    'Set bFirstTime to false
                    bFirstTime = False
                    'start table
                    sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf
                    sPageText = sPageText & "<tr><td><b>Booking ID</b></td><td><b>Booking Date</b></td><td><b>Room Number</b></td><td><b>Number Of Days</b></td><td><b>Total Price</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("room_number").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td></tr>" & vbCrLf


                Else
                    'If not bFirstTime
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("room_number").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td></tr>" & vbCrLf


                End If

            End If
        Loop
        'Close table
        sPageText = sPageText & "</table>"

        'If there is no record
        If bHasRecord = False Then
            'Write no record message
            sPageText = sPageText & "There is no booking in " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text
        End If


        Return sPageText
    End Function

    'Do report number 5
    Private Function doReport5(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String
        Dim bFirstTime As Boolean = True

        'Generate report header
        sPageText = g_sHTMLHeader("List of all customers who are due checkin in " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text) & vbCrLf


        Do While oDataReader.Read
            'check if there is any customer due checkin
            If oDataReader.Item("customer_id").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If

            If bHasRecord = True Then
                'If this is the first row of record
                If bFirstTime Then
                    'Set bFirstTime to false
                    bFirstTime = False
                    sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf   'start table
                    sPageText = sPageText & "<tr><td><b>Customer ID</b></td><td><b>Title</b></td><td><b>First Name</b></td><td><b>Last Name</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("customer_id").ToString) & "</td><td>" & CStr(oDataReader.Item("title").ToString) & "</td><td>" & CStr(oDataReader.Item("firstname").ToString) & "</td><td>" & CStr(oDataReader.Item("lastname").ToString) & "</td><tr>" & vbCrLf


                Else
                    'If not bFirstTime
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("customer_id").ToString) & "</td><td>" & CStr(oDataReader.Item("title").ToString) & "</td><td>" & CStr(oDataReader.Item("firstname").ToString) & "</td><td>" & CStr(oDataReader.Item("lastname").ToString) & "</td><tr>" & vbCrLf

                End If

            End If
        Loop
        'Close table
        sPageText = sPageText & "</table>"

        'If there is no record
        If bHasRecord = False Then
            'Write no record message
            sPageText = sPageText & "There is no customer who is due checkin in " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text
        End If


        Return sPageText
    End Function

    'Do report number 6
    Private Function doReport6(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String
        Dim bFirstTime As Boolean = True

        'Generate report header
        sPageText = g_sHTMLHeader("List of booking(s) for room number " & frmReportGenerate.cboRoom.Text & " In " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text) & vbCrLf


        Do While oDataReader.Read
            'check if there is any booking
            If oDataReader.Item("booking_id").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If

            If bHasRecord = True Then
                'If this is the first row of record
                If bFirstTime Then
                    'Set bFirstTime to false
                    bFirstTime = False
                    sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf   'start table
                    sPageText = sPageText & "<tr><td><b>Booking ID</b></td><td><b>Booking Date</b></td><td><b>Number Of Days</b></td><td><b>Total Price</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td><tr>" & vbCrLf


                Else
                    'If not bFirstTime
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td><tr>" & vbCrLf

                End If

            End If
        Loop
        'Close table
        sPageText = sPageText & "</table>"
        'If there is no record
        If bHasRecord = False Then
            'Write no record message
            sPageText = sPageText & "There is no booking in " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text
        End If


        Return sPageText
    End Function

    'Do report number 7
    Private Function doReport7(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String
        Dim bFirstTime As Boolean = True
        Dim sPreviousValue As String
        Dim sCurrentValue As String
        'Generate report header
        sPageText = g_sHTMLHeader("List of all booking(s) in " & frmReportGenerate.cboFromMonth.Text & "/" & frmReportGenerate.tbFromYear.Text & ", broken down by Room Number:") & vbCrLf
        'start table
        sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf

        Do While oDataReader.Read
            'check if there is any booking
            If oDataReader.Item("booking_id").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If

            If bHasRecord = True Then
                'If this is the first row of record
                If bFirstTime Then
                    'Set bFirstTime to false
                    bFirstTime = False
                    'Add Room Number
                    sPageText = sPageText & "<tr><td colspan = 4 ><b>Room Number " & oDataReader.Item("room_number").ToString & ", Floor: " & oDataReader.Item("floor").ToString & ", Type: " & oDataReader.Item("type").ToString & ", Price: " & oDataReader.Item("price").ToString & ", Number of Beds: " & oDataReader.Item("num_beds").ToString & "</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td><b>Booking Id</b></td><td><b>Booking Date</b></td><td><b>Number Of Days</b></td><td><b>Total Price</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td><tr>" & vbCrLf
                    'Set previous value to the current value
                    sPreviousValue = oDataReader.Item("room_number").ToString

                Else
                    'If this is not the first row of the record, check if this room_number the same as previous value
                    sCurrentValue = oDataReader.Item("room_number").ToString
                    'If this room number is the same as previous room number, add information to table
                    If sCurrentValue = sPreviousValue Then
                        sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td><tr>" & vbCrLf
                        'Set previous room number to the current one
                        sPreviousValue = sCurrentValue
                    Else
                        'If this room number is not the same as previous one, close the current table and open new one
                        sPageText = sPageText & "</table><P>" & vbCrLf
                        sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf
                        'Add Room Number
                        sPageText = sPageText & "<tr><td colspan = 4 ><b>Room Number " & oDataReader.Item("room_number").ToString & ", Floor: " & oDataReader.Item("floor").ToString & ", Type: " & oDataReader.Item("type").ToString & ", Price: " & oDataReader.Item("price").ToString & ", Number of Beds: " & oDataReader.Item("num_beds").ToString & "</b></td></tr>" & vbCrLf
                        sPageText = sPageText & "<tr><td><b>Booking Id</b></td><td><b>Booking Date</b></td><td><b>Number Of Days</b></td><td><b>Total Price</b></td></tr>" & vbCrLf
                        sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("booking_date").ToString) & "</td><td>" & CStr(oDataReader.Item("num_days").ToString) & "</td><td>" & CStr(oDataReader.Item("total_price").ToString) & "</td><tr>" & vbCrLf
                        'Set previous Room Number to the current one
                        sPreviousValue = sCurrentValue
                    End If

                End If

            End If
        Loop
        'If there is no record
        If bHasRecord = False Then
            'Write no record message
            sPageText = sPageText & "<tr><td colspan = 4>No record</td><td></td><td></td><td></td>"
        End If
        'Close table
        sPageText = sPageText & "</table>"
        Return sPageText
    End Function

    'Do report number 8
    Private Function doReport8(ByVal oDataReader As OleDbDataReader, ByVal sPageText As String, ByVal bHasRecord As Boolean) As String
        Dim bFirstTime As Boolean = True
        Dim sPreviousValue As String
        Dim sCurrentValue As String
        'Generate report header
        sPageText = g_sHTMLHeader("List of all invoice in year" & Now.Year & ", broken down by Month:") & vbCrLf
        'start table
        sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf

        Do While oDataReader.Read
            'check if there is any booking
            If oDataReader.Item("booking_id").ToString Is DBNull.Value Then
                bHasRecord = False
            Else : bHasRecord = True
            End If

            If bHasRecord = True Then
                'If this is the first row of record
                If bFirstTime Then
                    'Set bFirstTime to false
                    bFirstTime = False
                    'Add Month
                    sPageText = sPageText & "<tr><td colspan = 4 ><b>Month " & oDataReader.Item("MonthInvoice").ToString & "</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td><b>Booking Id</b></td><td><b>Invoice Date</b></td><td><b>Amount</b></td></tr>" & vbCrLf
                    sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("invoice_date").ToString) & "</td><td>" & CStr(oDataReader.Item("amount").ToString) & "</td><tr>" & vbCrLf
                    'Set previous value to the current value
                    sPreviousValue = oDataReader.Item("MonthInvoice").ToString

                Else
                    'If this is not the first row of the record, check if this Month the same as previous value
                    sCurrentValue = oDataReader.Item("MonthInvoice").ToString
                    'If this Month is the same as previous month number, add information to table
                    If sCurrentValue = sPreviousValue Then
                        sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("invoice_date").ToString) & "</td><td>" & CStr(oDataReader.Item("amount").ToString) & "</td><tr>" & vbCrLf
                        sPreviousValue = sCurrentValue 'Set previous month to the current one
                    Else
                        'If this month is not the same as previous one, close the current table and open new one
                        sPageText = sPageText & "</table><P>" & vbCrLf
                        sPageText = sPageText & "<TABLE border = 3 align = center>" & vbCrLf
                        'Add Month
                        sPageText = sPageText & "<tr><td colspan = 4 ><b>Month " & oDataReader.Item("MonthInvoice").ToString & "</b></td></tr>" & vbCrLf
                        sPageText = sPageText & "<tr><td><b>Booking Id</b></td><td><b>Invoice Date</b></td><td><b>Amount</b></td></tr>" & vbCrLf
                        sPageText = sPageText & "<tr><td>" & CStr(oDataReader.Item("booking_id").ToString) & "</td><td>" & CStr(oDataReader.Item("invoice_date").ToString) & "</td><td>" & CStr(oDataReader.Item("amount").ToString) & "</td><tr>" & vbCrLf
                        'Set previous Month to the current one
                        sPreviousValue = sCurrentValue
                    End If

                End If

            End If
        Loop
        'If there is no record
        If bHasRecord = False Then
            'Write no record message
            sPageText = sPageText & "<tr><td colspan = 4>No record</td><td></td><td></td><td></td>"
        End If

        sPageText = sPageText & "</table>" 'Close table
        Return sPageText
    End Function
End Module

