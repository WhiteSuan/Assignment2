Option Explicit On
Option Strict On

Imports System.Data.OleDb

' Name:        BookingController.vb
' Description: Class acting as intermediary between the booking form and booking table
'              Contains most of the CRUD business logic
' Author:      Y Nguyen 
' Date:        3/31/2017

Public Class BookingController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    'function to insert value to booking table
    Public Function insert(ByVal htData As Hashtable) As Integer

        'open db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            
            'insert field values into booking table in database
            oCommand.CommandText = _
                   "INSERT INTO booking (checking_date, room_number, customer_ID, num_days, num_guests, booking_date, total_price, comments) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("CDate", OleDbType.DBDate, 255)
            oCommand.Parameters.Add("RNum", OleDbType.Integer, 255)
            oCommand.Parameters.Add("CusID", OleDbType.Integer, 255)
            oCommand.Parameters.Add("NumDay", OleDbType.Integer, 255)
            oCommand.Parameters.Add("NumGuest", OleDbType.Integer, 255)
            oCommand.Parameters.Add("BDate", OleDbType.DBDate, 255)
            oCommand.Parameters.Add("Total", OleDbType.Double, 255)
            oCommand.Parameters.Add("Comment", OleDbType.LongVarChar, 5000)


            oCommand.Parameters("CDate").Value = CStr(htData("CDate"))
            oCommand.Parameters("RNum").Value = CStr(htData("RNum"))
            oCommand.Parameters("CusID").Value = CStr(htData("CusID"))
            oCommand.Parameters("NumDay").Value = CStr(htData("NumDay"))
            oCommand.Parameters("NumGuest").Value = CStr(htData("NumGuest"))
            oCommand.Parameters("BDate").Value = CStr(htData("BDate"))
            oCommand.Parameters("Total").Value = CStr(htData("Total"))
            oCommand.Parameters("Comment").Value = CStr(htData("Comment"))


            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()


            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was inserted.")
            'Display notification
            MsgBox("The record was inserted.")
            'Update room availability to No
            updateavai(CStr(htData("RNum")))
            'Create invoice for this booking
            createinvoice()

        Catch ex As Exception 'If there is any error
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occured. The record wasn't inserted.")

        Finally
            'Close connection to the database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'Function to update room availability after booking
    Public Function updateavai(ByVal strVal As String) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'Open connection to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection
        'SQL query to update room availability
        oCommand.CommandText = _
                      "UPDATE room SET availability = 'No' WHERE room_number = ?;"
        oCommand.Parameters.Add("RNum", OleDbType.Integer, 255)
        oCommand.Parameters("RNum").Value = strVal


        oCommand.Prepare()
        oCommand.ExecuteNonQuery()

    End Function

    'Function to update room availability after delete booking
    Public Function makeavai(ByVal strVal As String) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'Open connection to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection
        'SQL query to update room availability
        oCommand.CommandText = _
                      "UPDATE room SET availability = 'Yes' WHERE room_number = ?;"
        oCommand.Parameters.Add("RNum", OleDbType.Integer, 255)
        oCommand.Parameters("RNum").Value = strVal


        oCommand.Prepare()
        oCommand.ExecuteNonQuery()

    End Function

    'Function to create invoice after booking
    Public Function createinvoice() As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'Open connection to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        Dim iBookingId As Integer
        Dim dbAmount As Double

        oCommand.Connection = oConnection
        'Get the lastest booking id and its total price
        oCommand.CommandText = _
                      "select top 1 booking_id, total_price from booking order by booking_id DESC ;"


        oCommand.Prepare()
        oCommand.ExecuteNonQuery()

        Dim oDataReader = oCommand.ExecuteReader()

        While oDataReader.Read()

            iBookingId = CInt(oDataReader.Item("booking_id").ToString)
            dbAmount = CDbl(oDataReader.Item("total_price").ToString)

        End While
        oConnection.Close()
        oConnection.Open()

        'Insert into invoice table with retrieved booking id, amount and invoice date is today
        oCommand.CommandText = _
                     "INSERT INTO invoice (booking_id, amount, invoice_date) VALUES (?, ?, ?) ; "

        oCommand.Parameters.Add("BookingId", OleDbType.Integer, 255)
        oCommand.Parameters.Add("Amount", OleDbType.Double, 255)
        oCommand.Parameters.Add("InvoiceDate", OleDbType.DBDate, 255)

        oCommand.Parameters("BookingId").Value = iBookingId
        oCommand.Parameters("Amount").Value = dbAmount
        oCommand.Parameters("InvoiceDate").Value = Today.ToString("yyyy-MM-dd")

        oCommand.Prepare()
        oCommand.ExecuteNonQuery()
        oConnection.Close()

    End Function

    'Function to update invoice after update booking
    Public Function updateinvoice(ByVal iBookingId As Integer, ByVal dbAmount As Double) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'Open connection to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand

        oCommand.Connection = oConnection
        'Update invoice with information retrieved from updated booking
        oCommand.CommandText = _
                     "update invoice set amount = ?, invoice_date = ? where booking_id = " & iBookingId & ";"

        oCommand.Parameters.Add("Amount", OleDbType.Double, 255)
        oCommand.Parameters.Add("InvoiceDate", OleDbType.DBDate, 255)

        oCommand.Parameters("Amount").Value = dbAmount
        oCommand.Parameters("InvoiceDate").Value = Today.ToString("yyyy-MM-dd")

        oCommand.Prepare()
        oCommand.ExecuteNonQuery()
        oConnection.Close()

    End Function

    'Function to delete invoice when delete booking
    Public Function deleteinvoice(ByVal iBookingId As Integer) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Debug.Print("Connection string: " & oConnection.ConnectionString)
        'Open connection to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand

        oCommand.Connection = oConnection
        'Delete the invoice of the deleted booking
        oCommand.CommandText = _
                     "delete from invoice where booking_ID = " & iBookingId & ";"

        oCommand.Prepare()
        oCommand.ExecuteNonQuery()
        oConnection.Close()

    End Function

    'Function to update booking information
    Public Function update(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'insert field values into booking table in database

            oCommand.CommandText = _
                   "UPDATE booking SET checking_date = ?, room_number = ?, customer_ID = ?, num_days = ?, num_guests = ?, booking_date = ?, total_price = ?, comments = ? WHERE booking_ID = ?;"

            oCommand.Parameters.Add("CDate", OleDbType.DBDate, 255)
            oCommand.Parameters.Add("RNum", OleDbType.Integer, 255)
            oCommand.Parameters.Add("CusID", OleDbType.Integer, 255)
            oCommand.Parameters.Add("NumDay", OleDbType.Integer, 255)
            oCommand.Parameters.Add("NumGuest", OleDbType.Integer, 255)
            oCommand.Parameters.Add("BDate", OleDbType.DBDate, 255)
            oCommand.Parameters.Add("Total", OleDbType.Double, 255)
            oCommand.Parameters.Add("Comment", OleDbType.LongVarChar, 5000)
            oCommand.Parameters.Add("BookingID", OleDbType.Integer, 255)


            oCommand.Parameters("CDate").Value = CStr(htData("CDate"))
            oCommand.Parameters("RNum").Value = CStr(htData("RNum"))
            oCommand.Parameters("CusID").Value = CStr(htData("CusID"))
            oCommand.Parameters("NumDay").Value = CStr(htData("NumDay"))
            oCommand.Parameters("NumGuest").Value = CStr(htData("NumGuest"))
            oCommand.Parameters("BDate").Value = CStr(htData("BDate"))
            oCommand.Parameters("Total").Value = CStr(htData("Total"))
            oCommand.Parameters("Comment").Value = CStr(htData("Comment"))
            oCommand.Parameters("BookingID").Value = CStr(htData("BookingID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            'Display notification
            Debug.Print("The record was updated.")
            MsgBox("The record was updated.")
            'update availability of booked room
            updateavai(CStr(htData("RNum")))
            'update invoice of booking
            updateinvoice(CInt(htData("BookingID")), CDbl(htData("Total")))

        Catch ex As Exception 'If there is any error
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occured. The record wasn't updated.")
        Finally
            'Close connection to the database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'function to delete record to booking table
    Public Function delete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to the database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'delete record from booking table in database

            oCommand.CommandText = _
                   "DELETE FROM booking WHERE booking_ID = ?;"

            oCommand.Parameters.Add("BookingID", OleDbType.VarChar, 255)
            oCommand.Parameters("BookingID").Value = CStr(sId)

            oCommand.Prepare()
            makeavai(CStr(frmBooking.cbRoom.Text))
            deleteinvoice(CInt(sId))
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")
            'Display notification
            MsgBox("The record was deleted.")

        Catch ex As Exception 'If there is any error 
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occured. The record wasn't deleted.")
        Finally
            'Close connection to the database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'function to find all booking in database
    Public Function findAll() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Connection to the database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Retrieve booking information
            oCommand.CommandText = _
                    "SELECT * FROM booking ORDER BY booking_ID;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'insert booking information to hashtable
                htTempData = New Hashtable
                htTempData("CDate") = CStr(oDataReader("checking_date"))
                htTempData("RNum") = CStr(oDataReader("room_number"))
                htTempData("CusID") = CStr(oDataReader("customer_ID"))
                htTempData("NumDay") = CStr(oDataReader("num_days"))
                htTempData("NumGuest") = CStr(oDataReader("num_guests"))
                htTempData("BDate") = CStr(oDataReader("booking_date"))
                htTempData("Total") = CStr(oDataReader("total_price"))
                htTempData("Comment") = CStr(oDataReader("comments"))
                htTempData("BookingID") = CStr(oDataReader("booking_ID"))
                lsData.Add(htTempData)
            Loop
            'Display notification
            MsgBox("All booking records were found.")

        Catch ex As Exception 'If there is any error message
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occurred. The records could not be found!")
        Finally
            'Close connection to database
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'function to find booking that meet searching criterias
    Public Function findById(ByVal sSQL As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to the databas
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'Retrieve booking information that meet searching criterias
            oCommand.CommandText = _
                "SELECT * FROM booking WHERE " & sSQL & " ;"
            
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'Insert booking information to hashtable
                htTempData = New Hashtable
                htTempData("CDate") = CStr(oDataReader("checking_date"))
                htTempData("RNum") = CStr(oDataReader("room_number"))
                htTempData("CusID") = CStr(oDataReader("customer_ID"))
                htTempData("NumDay") = CStr(oDataReader("num_days"))
                htTempData("NumGuest") = CStr(oDataReader("num_guests"))
                htTempData("BDate") = CStr(oDataReader("booking_date"))
                htTempData("Total") = CStr(oDataReader("total_price"))
                htTempData("Comment") = CStr(oDataReader("comments"))
                htTempData("BookingID") = CStr(oDataReader("booking_ID"))
                lsData.Add(htTempData)
            Loop

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            'Close connection to database
            oConnection.Close()
        End Try

        Return lsData

    End Function
End Class
