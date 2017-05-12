Option Explicit On
Option Strict On

Imports System.Data.OleDb

' Name:        CustomerController.vb
' Description: Class acting as intermediary between the customer form and customer table
'              Contains most of the CRUD business logic
' Author:      Y Nguyen 
' Date:        3/31/2017


Public Class CustomerController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    'Function to insert new customer to the database
    Public Function insert(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to the database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'Insert customer information to customer table
            oCommand.CommandText = _
                       "INSERT INTO customer (title, firstname, lastname, gender, phone, address, email, DOB) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("Title", OleDbType.VarChar, 3)
            oCommand.Parameters.Add("FirstName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("LastName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Gender", OleDbType.VarChar, 10)
            oCommand.Parameters.Add("Phone", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Address", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("DOB", OleDbType.VarChar, 255)

            oCommand.Parameters("Title").Value = CStr(htData("Title"))
            oCommand.Parameters("FirstName").Value = CStr(htData("FirstName"))
            oCommand.Parameters("LastName").Value = CStr(htData("LastName"))
            oCommand.Parameters("Gender").Value = CStr(htData("Gender"))
            oCommand.Parameters("Phone").Value = CStr(htData("Phone"))
            oCommand.Parameters("Address").Value = CStr(htData("Address"))
            oCommand.Parameters("Email").Value = CStr(htData("Email"))
            oCommand.Parameters("DOB").Value = CStr(htData("DOB"))

            oCommand.Prepare()

            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was inserted.")
            'Display notification
            MsgBox("The record was inserted.")

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

    'Function to update customer information
    Public Function update(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to the database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'update field values into customer table in database

            oCommand.CommandText = _
                   "UPDATE customer SET title = ?, firstname = ?, lastname = ?, gender = ?, phone = ?, address = ?, email = ?, DOB = ? WHERE customer_ID = ?;"

            oCommand.Parameters.Add("Title", OleDbType.VarChar, 3)
            oCommand.Parameters.Add("FirstName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("LastName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Gender", OleDbType.VarChar, 10)
            oCommand.Parameters.Add("Phone", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Address", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("DOB", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("CustomerID", OleDbType.Integer, 255)

            oCommand.Parameters("Title").Value = CStr(htData("Title"))
            oCommand.Parameters("FirstName").Value = CStr(htData("FirstName"))
            oCommand.Parameters("LastName").Value = CStr(htData("LastName"))
            oCommand.Parameters("Gender").Value = CStr(htData("Gender"))
            oCommand.Parameters("Phone").Value = CStr(htData("Phone"))
            oCommand.Parameters("Address").Value = CStr(htData("Address"))
            oCommand.Parameters("Email").Value = CStr(htData("Email"))
            oCommand.Parameters("DOB").Value = CStr(htData("DOB"))
            oCommand.Parameters("CustomerID").Value = CInt(htData("CustomerID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was updated.")
            'Display notifcation
            MsgBox("The record was updated.")

        Catch ex As Exception 'If there is any error message
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occured. The record wasn't updated.")
        Finally
            'Close connection to database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'function to delete record from customer table
    Public Function delete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'delete record from customer table in database

            oCommand.CommandText = _
                   "DELETE FROM customer WHERE customer_ID = ?;"



            oCommand.Parameters.Add("CustomerID", OleDbType.VarChar, 255)

            oCommand.Parameters("CustomerID").Value = CStr(sId)

            oCommand.Prepare()
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
            'Close connection to database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'function to find all customer in database
    Public Function findAll() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Retrieve all customer information
            oCommand.CommandText = _
                    "SELECT * FROM customer ORDER BY customer_ID;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'Insert customer information to hashtable
                htTempData = New Hashtable
                htTempData("Title") = CStr(oDataReader("title"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Gender") = CStr(oDataReader("gender"))
                htTempData("Phone") = CStr(oDataReader("phone"))
                htTempData("Address") = CStr(oDataReader("address"))
                htTempData("Email") = CStr(oDataReader("email"))
                htTempData("DOB") = CStr(oDataReader("DOB"))
                htTempData("CustomerID") = CStr(oDataReader("customer_ID"))
                lsData.Add(htTempData)
            Loop

            'Display notification
            MsgBox("All customer records were found.")

        Catch ex As Exception 'If there is any error 
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occurred. The records could not be found!")
        Finally
            'Close connection to the database
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'function to search for customer that meet searching criterias
    Public Function findById(ByVal sSQL As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'Retrieve all customer that meet searching criterias
            oCommand.CommandText = _
                "SELECT * FROM customer WHERE " & sSQL & " ;"
            
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'Write customer information to hashtable
                htTempData = New Hashtable
                htTempData("Title") = CStr(oDataReader("title"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Gender") = CStr(oDataReader("gender"))
                htTempData("Phone") = CStr(oDataReader("phone"))
                htTempData("Address") = CStr(oDataReader("address"))
                htTempData("Email") = CStr(oDataReader("email"))
                htTempData("DOB") = CStr(oDataReader("DOB"))
                htTempData("CustomerID") = CStr(oDataReader("customer_ID"))
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
