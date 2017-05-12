Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing

' Name:        frmCustomer.vb
' Description: Form for inserting booking details into booking table
' Author:      Y Nguyen
' Date:        3/25/2017

'References: https://www.lucidchart.com/pages/use-case-description-example-and-template-UML
'http://www.unf.edu/~broggio/cop2221/2221pseu.htm
'https://www.slideshare.net/souvagyakumarjena/dfd-14607173
'http://stackoverflow.com/questions/336210/regular-expression-for-alphanumeric-and-underscores
'Lab tasks from week 4 to week 8

Public Class frmBooking
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    'when click on Insert button
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oBookingController As BookingController = New BookingController
        'validation for fields in booking form
            Dim oValidation As New validation
            Dim bIsValid As Boolean
            Dim bAllFieldsValid As Boolean = True
            Dim tt As New ToolTip()

        'check if there is an item chosen in Room combobox or not
        'If no then
        If cbRoom.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbRoom.Visible = True
            'display error message
            tt.SetToolTip(pbRoom, "Please select room number in Room Number combobox")
        Else
            'hide error picture
            pbRoom.Visible = False
        End If

        'check if there is an item chosen in Customer ID combobox or not
        'If no then
        If cbCustomer.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbCustomer.Visible = True
            'display error message
            tt.SetToolTip(pbCustomer, "Please select customer ID in customer ID combobox")
        Else
            'hide error picture
            pbCustomer.Visible = False
        End If
        

        'check if num of days is numeric or not
        bIsValid = oValidation.isNumericVal(tbNumDay.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbNumDay.Visible = True
            'display error message
            tt.SetToolTip(pbNumDay, "Please enter number of days in numeric type")
        Else
            'monkey testing Num of days textbox
            bIsValid = oValidation.monkey1(tbNumDay.Text)
            'If Num of days value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbNumDay.Visible = True
                'display error message
                tt.SetToolTip(pbNumDay, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
                bAllFieldsValid = False
            Else
                'hide error picture
                pbNumDay.Visible = False
            End If
        End If

        'check if num of guests is numeric or not
        bIsValid = oValidation.isNumericVal(tbGuest.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbGuest.Visible = True
            'display error message
            tt.SetToolTip(pbGuest, "Please enter number of guests in numeric type")
        Else
            'monkey testing Num of Guests textbox
            bIsValid = oValidation.monkey1(tbGuest.Text)
            'If Num of guests value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbGuest.Visible = True
                'display error message
                tt.SetToolTip(pbGuest, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
                bAllFieldsValid = False
            Else
                'hide error picture
                pbGuest.Visible = False
            End If
        End If

        'monkey testing comment textbox
        bIsValid = oValidation.monkey2(tbComment.Text)
        'If comment value is more than 1000 characters then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbComment.Visible = True
            'display error message
            tt.SetToolTip(pbComment, "You reach the text limits. Only allow 1000 characters. Please shortens your input.")
        Else
            'hide error picture
            pbComment.Visible = False
        End If

        Dim Check = dtChecking.Value
        Dim Book = dtBooking.Value
        Dim t As Integer
        t = DateTime.Compare(Check, Book)
        If t < 0 Then
            'all fields are not valid
            bAllFieldsValid = False
            MsgBox("please select checking day the same or after booking date")
        End If
        'if all validation is done and valid, insert data to booking table

        If bAllFieldsValid Then
            Debug.Print("All fields are valid")

            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            Dim lsData As New List(Of Hashtable)

            Dim htData As Hashtable = New Hashtable
            'assign values from booking form to data of Hashtable
            htData("CDate") = dtBooking.Value.ToString("yyyy-MM-dd")
            htData("RNum") = cbRoom.SelectedItem.ToString
            htData("CusID") = cbCustomer.SelectedItem.ToString
            htData("NumDay") = tbNumDay.Text
            htData("NumGuest") = tbGuest.Text
            htData("BDate") = dtChecking.Value.ToString("yyyy-MM-dd")

            Dim total As String
            'check if total price has been calculated or not
            'If yes then
            If Len(tbTotal.Text) > 1 Then
                'get the number part of value of Total Price textbox
                total = Microsoft.VisualBasic.Right(tbTotal.Text, Len(tbTotal.Text) - 1)
                'and assign that part to Hashdata Total
                htData("Total") = total
            End If

            'check if comment textbox is null or not. 
            bIsValid = oValidation.isNullOrEmpty(tbComment.Text)
            'if null, insert ""  to Hashdata Comment
            If bIsValid Then
                htData("Comment") = DBNull.Value.ToString
            Else
                'else, assign value of comment field to Hashdata Comment
                htData("Comment") = tbComment.Text.Trim
            End If
            'call insert function in booking controller and run it with assigned hashdata
            Dim iNumRows = oBookingController.insert(htData)
            Debug.Print(CStr(iNumRows))

        Else
            'if all fields are not valid, show message box
            MsgBox("One of the fields was invalid")

        End If

    End Sub

    'when booking form load
    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set max date of Booking Day datetimepicker as today
        dtBooking.MaxDate = Date.Today()
        'make a new connection to db
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'Open db connection
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection
        'select all room_number in room table that still available
        oCommand.CommandText = _
            "SELECT room_number FROM room WHERE availability = 'Yes';"
        oCommand.Prepare()
        Dim oDataReader = oCommand.ExecuteReader()

        While oDataReader.Read()
            'then add the result set as items of Room combobox
            cbRoom.Items.Add(oDataReader("room_number"))
        End While
        'close db connection
        oConnection.Close()
        'open db connection
        oConnection.Open()
        oCommand.Connection = oConnection
        'select all customer ID in customer table
        oCommand.CommandText = _
            "SELECT customer_ID FROM customer;"
        oCommand.Prepare()
        Dim oDataR = oCommand.ExecuteReader()

        While oDataR.Read()
            'then add the result set as items of Customer IF combobox
            cbCustomer.Items.Add(oDataR("customer_ID"))
        End While
        'close db connection
        oConnection.Close()

        Try
            'open db connection
            oConnection.Open()
            oCommand.Connection = oConnection
            'select the first record in booking table
            oCommand.CommandText = _
                "Select top 1 booking_ID, checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments from booking;"
            oCommand.Prepare()
            Dim Booking As OleDbDataReader = oCommand.ExecuteReader()

            While Booking.Read
                If Booking("booking_ID") Is DBNull.Value Then

                Else
                    'then assign the values of the record result to the values of fields in Booking form
                    tbBookingId.Text = Booking.Item("booking_ID").ToString
                    dtChecking.Text = Booking.Item("checking_date").ToString
                    cbRoom.Text = Booking.Item("room_number").ToString
                    cbCustomer.Text = Booking.Item("customer_ID").ToString
                    tbNumDay.Text = Booking.Item("num_days").ToString
                    tbGuest.Text = Booking.Item("num_guests").ToString
                    dtBooking.Text = Booking.Item("booking_date").ToString
                    tbTotal.Text = Booking.Item("total_price").ToString
                    tbComment.Text = Booking.Item("comments").ToString


                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            'close db connection
            oConnection.Close()
        End Try

    End Sub

    'when click on reset button, booking form will be reloaded into a new form
    Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click
        'show new booking form
        Dim frm = New frmBooking
        frm.Show()
        'hide the current booking form
        Me.Hide()
    End Sub

    'if click on botton Menu, show Menu form
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        frmSwitchBoard.Show()
        'hide the current booking form
        Me.Hide()
    End Sub

    'calculate total price based on values of Num of Days and Room Price
    'if there is an inserted value in Num of Days textbox 
    Private Sub tbNumDay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNumDay.TextChanged
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            'if there is an item chosen in Room combobox then
            If Not cbRoom.SelectedIndex = -1 Then
                'open db connection
                oConnection.Open()

                Dim RPrice As Decimal
                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection
                'select price in room table where room number = value of Room combobox
                oCommand.CommandText = _
                    "Select price from room where room_number=" & cbRoom.Text & ";"
                oCommand.Prepare()
                Dim RPricerd As OleDbDataReader = oCommand.ExecuteReader()
                While RPricerd.Read
                    RPrice = CDec(RPricerd("price"))
                    'calculate total price = num of days * room price
                    tbTotal.Text = CStr("$" & (CInt(tbNumDay.Text) * RPrice))
                End While

            End If
        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            'close db connection
            oConnection.Close()
        End Try
    End Sub

    'when click on Update button
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim oBookingController As BookingController = New BookingController

        Dim oValidation As New validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim tt As New ToolTip()
        Dim bSameRoom As Boolean = False
        'make a new db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'open db connection
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection
        'select room number in booking table where booking ID = value of booking ID textbox (hidden)
        oCommand.CommandText = _
            "SELECT room_number FROM booking WHERE booking_ID = " & tbBookingId.Text & " ;"
        oCommand.Prepare()
        Dim oDataReader = oCommand.ExecuteReader()

        While oDataReader.Read()
            'if the result of room number get from db = value of Room combobox
            If oDataReader.Item("room_number").ToString = cbRoom.Text Then
                'then it's the same room
                bSameRoom = True

            End If
        End While

        'close db connection
        oConnection.Close()

        If bSameRoom = True Then 'if the same room as before, don't check for room validation

        Else

            'else,check validation of all fields
            'check if there is an item chosen in Room combobox or not
            'If no then
            If cbRoom.SelectedIndex = -1 Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbRoom.Visible = True
                'display error message
                tt.SetToolTip(pbRoom, "Please select room number in Room Number combobox")
            Else
                'hide error picture
                pbRoom.Visible = False
            End If
        End If


        'check if there is an item chosen in Customer ID combobox or not
        'If no then
        If cbCustomer.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbCustomer.Visible = True
            'display error message
            tt.SetToolTip(pbCustomer, "Please select customer ID in customer ID combobox")
        Else
            'hide error picture
            pbCustomer.Visible = False
        End If


        'check if num of days is numeric or not
        bIsValid = oValidation.isNumericVal(tbNumDay.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbNumDay.Visible = True
            'display error message
            tt.SetToolTip(pbNumDay, "Please enter number of days in numeric type")
        Else
            'monkey testing Num of days textbox
            bIsValid = oValidation.monkey1(tbNumDay.Text)
            'If Num of days value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbNumDay.Visible = True
                'display error message
                tt.SetToolTip(pbNumDay, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
                bAllFieldsValid = False
            Else
                'hide error picture
                pbNumDay.Visible = False
            End If
        End If

        'check if num of guests is numeric or not
        bIsValid = oValidation.isNumericVal(tbGuest.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbGuest.Visible = True
            'display error message
            tt.SetToolTip(pbGuest, "Please enter number of guests in numeric type")
        Else
            'monkey testing Num of Guests textbox
            bIsValid = oValidation.monkey1(tbGuest.Text)
            'If Num of guests value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbGuest.Visible = True
                'display error message
                tt.SetToolTip(pbGuest, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
                bAllFieldsValid = False
            Else
                'hide error picture
                pbGuest.Visible = False
            End If
        End If

        'monkey testing comment textbox
        bIsValid = oValidation.monkey2(tbComment.Text)
        'If comment value is more than 1000 characters then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbComment.Visible = True
            'display error message
            tt.SetToolTip(pbComment, "You reach the text limits. Only allow 1000 characters. Please shortens your input.")
        Else
            'hide error picture
            pbComment.Visible = False
        End If

        'if all validation is done and valid, update data to booking table
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")

            Dim lsData As New List(Of Hashtable)
            'assign values from booking form to data of Hashtable
            Dim htData As Hashtable = New Hashtable
            htData("CDate") = dtBooking.Value.ToString("yyyy-MM-dd")
            'if it's the same room then
            If bSameRoom = True Then
                'assign hashdata Room Number with the current text value in Room combobox
                htData("RNum") = cbRoom.Text.ToString
            Else
                'else, assign hashdata Room Number with value of the chosen item in Room combobox
                htData("RNum") = cbRoom.SelectedIndex.ToString
            End If

            htData("CusID") = cbCustomer.SelectedItem.ToString
            htData("NumDay") = tbNumDay.Text
            htData("NumGuest") = tbGuest.Text
            htData("BDate") = dtChecking.Value.ToString("yyyy-MM-dd")
            htData("BookingID") = tbBookingId.Text

            Dim total As String
            'if total price has been calculated then
            If Len(tbTotal.Text) > 1 Then
                'get the number part of total price (exclude the $)
                total = Microsoft.VisualBasic.Right(tbTotal.Text, Len(tbTotal.Text) - 1)
                'assign hashdata Total with that number part
                htData("Total") = total
            End If

            'check if comment textbox is null or not. if null, insert ""  value to comment field of booking table
            bIsValid = oValidation.isNullOrEmpty(tbComment.Text)
            'if it's null then assign Hashdata Comment with ""
            If bIsValid Then
                htData("Comment") = DBNull.Value.ToString
            Else
                'else, assign Hashdata Comment with value of Comment textbox
                htData("Comment") = tbComment.Text.Trim
            End If
            'call update function in booking controller and run it with assigned hashdata
            Dim iNumRows = oBookingController.update(htData)
            Debug.Print(CStr(iNumRows))

        Else
            'if all fields are not valid, show message box
            MsgBox("One of the fields was invalid")

        End If

    End Sub

    'when click on About tab in Menu strip at the top left of customer form
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

    'when click on Help tab in Menu strip at the top left of customer form
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

    'when click on View all button
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        'Clear the data grid view
        dgvResult.Rows.Clear()

        Dim oController As BookingController = New BookingController
        'execute find all function to find all records in booking table
        Dim lsData = oController.findAll()
        Dim sRow As String()

        For Each booking In lsData
            'then display each record as a row in datagridview
            sRow = New String() {CStr(booking("BookingID")), CStr(booking("RNum")), CStr(booking("CusID")), CStr(booking("CDate")), CStr(booking("BDate")), CStr(booking("NumDay")), CStr(booking("NumGuest")), CStr(booking("Total")), CStr(booking("Comment"))}
            dgvResult.Rows.Add(sRow)
        Next

    End Sub

    'when click on Search button
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'open Search form
        frmSearchForm.Show()
        'set the second field as Customer ID
        frmSearchForm.lblSecondCriteria.Text = "Customer ID:"
        'set the first field as Booking ID
        frmSearchForm.lblFirstCriteria.Text = "Booking ID:"
        'set the title of Search form as Booking Search
        frmSearchForm.Text = "Booking Search"

    End Sub

    'when double-click on a certain row in datagridview
    Private Sub dgvResult_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvResult.CellMouseDoubleClick
        'get index value of the chosen row
        Dim value As Object = dgvResult.Rows(e.RowIndex).Cells(0).Value
        'if there is no row in datagridview then
        If IsDBNull(value) Then
            'ask to search or view all, to display a set of results
            MsgBox("Please Search or View All first")
        Else
            'else,
            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            Try
                oConnection.Open()

                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection
                'get the record in booking table where booking id = index value of the chosen row
                oCommand.CommandText = _
                   "Select booking_ID, checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments from booking where booking_ID = " & CType(value, String) & ";"
                oCommand.Prepare()
                Dim Booking As OleDbDataReader = oCommand.ExecuteReader()

                While Booking.Read
                    If Booking("booking_ID") Is DBNull.Value Then

                    Else
                        'then, assign the values of the record result to the values of fields in Booking form
                        tbBookingId.Text = Booking.Item("booking_ID").ToString
                        dtChecking.Text = Booking.Item("checking_date").ToString
                        cbRoom.Text = Booking.Item("room_number").ToString
                        cbCustomer.Text = Booking.Item("customer_ID").ToString
                        tbNumDay.Text = Booking.Item("num_days").ToString
                        tbGuest.Text = Booking.Item("num_guests").ToString
                        dtBooking.Text = Booking.Item("booking_date").ToString
                        tbTotal.Text = Booking.Item("total_price").ToString
                        tbComment.Text = Booking.Item("comments").ToString


                    End If
                End While

            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                'close db connection
                oConnection.Close()
            End Try
        End If

    End Sub

    'when click on < button
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        'make a new db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            'open db connection
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'get all records that have booking ID smaller than the current value in booking ID textbox, then order them descendingly. Finally, get the top one, that's the previous record
            oCommand.CommandText = _
               "Select top 1 booking_ID, checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments from booking where booking_ID < " & tbBookingId.Text & " ORDER BY booking_ID DESC;"

            oCommand.Prepare()
            Dim Booking As OleDbDataReader = oCommand.ExecuteReader()

            While Booking.Read
                'if there is no appropriate result
                If Booking("booking_ID") Is DBNull.Value Then

                Else
                    'assign the values of the record result to the values of fields in Booking form
                    tbBookingId.Text = Booking.Item("booking_ID").ToString
                    dtChecking.Text = Booking.Item("checking_date").ToString
                    cbRoom.Text = Booking.Item("room_number").ToString
                    cbCustomer.Text = Booking.Item("customer_ID").ToString
                    tbNumDay.Text = Booking.Item("num_days").ToString
                    tbGuest.Text = Booking.Item("num_guests").ToString
                    dtBooking.Text = Booking.Item("booking_date").ToString
                    tbTotal.Text = Booking.Item("total_price").ToString
                    tbComment.Text = Booking.Item("comments").ToString

                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try

    End Sub

    'when click on > button
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'make a new db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            'Open db connect
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'get all records that have Booking ID greater than the current value in Booking ID textbox, then order them ascendingly. Finally, get the top one, that's the next record
            oCommand.CommandText = _
               "Select top 1 booking_ID, checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments from booking where booking_ID > " & tbBookingId.Text & " ORDER BY booking_ID ASC;"

            oCommand.Prepare()
            Dim Booking As OleDbDataReader = oCommand.ExecuteReader()

            While Booking.Read
                'if there is no appropriate result
                If Booking("booking_ID") Is DBNull.Value Then

                Else
                    'assign the values of the record result to the values of fields in Booking form
                    tbBookingId.Text = Booking.Item("booking_ID").ToString
                    dtChecking.Text = Booking.Item("checking_date").ToString
                    cbRoom.Text = Booking.Item("room_number").ToString
                    cbCustomer.Text = Booking.Item("customer_ID").ToString
                    tbNumDay.Text = Booking.Item("num_days").ToString
                    tbGuest.Text = Booking.Item("num_guests").ToString
                    dtBooking.Text = Booking.Item("booking_date").ToString
                    tbTotal.Text = Booking.Item("total_price").ToString
                    tbComment.Text = Booking.Item("comments").ToString


                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            'close connection
            oConnection.Close()
        End Try

    End Sub

    'when click |< button
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        'make a new db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            ' select the first record in booking table
            oCommand.CommandText = _
                "Select top 1 booking_ID, checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments from booking ORDER BY booking_ID ASC;"

            oCommand.Prepare()
            Dim Booking As OleDbDataReader = oCommand.ExecuteReader()

            While Booking.Read
                'if there is no record
                If Booking("booking_ID") Is DBNull.Value Then

                Else
                    'else, assign the values of the record result to the values of fields in Booking form
                    tbBookingId.Text = Booking.Item("booking_ID").ToString
                    dtChecking.Text = Booking.Item("checking_date").ToString
                    cbRoom.Text = Booking.Item("room_number").ToString
                    cbCustomer.Text = Booking.Item("customer_ID").ToString
                    tbNumDay.Text = Booking.Item("num_days").ToString
                    tbGuest.Text = Booking.Item("num_guests").ToString
                    dtBooking.Text = Booking.Item("booking_date").ToString
                    tbTotal.Text = Booking.Item("total_price").ToString
                    tbComment.Text = Booking.Item("comments").ToString


                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            'close db connection
            oConnection.Close()
        End Try



    End Sub

    'when click >| button
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        'make a new db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            'open db connection
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the last record in booking table
            oCommand.CommandText = _
                "Select top 1 booking_ID, checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments from booking ORDER BY booking_ID DESC;"

            oCommand.Prepare()
            Dim Booking As OleDbDataReader = oCommand.ExecuteReader()

            While Booking.Read
                'if there is no record
                If Booking("booking_ID") Is DBNull.Value Then

                Else
                    'else, assign the values of the record result to the values of fields in Booking form
                    tbBookingId.Text = Booking.Item("booking_ID").ToString
                    dtChecking.Text = Booking.Item("checking_date").ToString
                    cbRoom.Text = Booking.Item("room_number").ToString
                    cbCustomer.Text = Booking.Item("customer_ID").ToString
                    tbNumDay.Text = Booking.Item("num_days").ToString
                    tbGuest.Text = Booking.Item("num_guests").ToString
                    dtBooking.Text = Booking.Item("booking_date").ToString
                    tbTotal.Text = Booking.Item("total_price").ToString
                    tbComment.Text = Booking.Item("comments").ToString


                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            'close db connection
            oConnection.Close()
        End Try


    End Sub

    'when click on Delete button
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'display a message box to confirm if the user really wants to delete the record or not
        'if yes then
        If MsgBox("Do you want to delete this record?", vbYesNo) = vbYes Then

            Dim oController As BookingController = New BookingController

            Dim sId = tbBookingId.Text
            'run delete function in booking controller and delete the record by Booking ID
            Dim iNumRows = oController.delete(sId)

            If iNumRows = 1 Then
                'after successfully delete that record, reset booking form
                Dim frm = New frmBooking

                frm.Show()
                Me.Hide()
                'and display message to announce that deletion has been successfull
                Debug.Print("The record was deleted. Use the find button to check ...")
                MsgBox("The record was successfully deleted")
            Else
                'else, display error message
                Debug.Print("The record was not deleted!")
                MsgBox("The record was not deleted")

            End If

        End If


    End Sub


End Class