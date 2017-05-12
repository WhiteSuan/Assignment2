Option Explicit On
Option Strict On

Imports System.Data.OleDb

' Name:        RoomController.vb
' Description: Class acting as intermediary between the room form and room table
'              Contains most of the CRUD business logic
' Author:      Y Nguyen 
' Date:        3/31/2017

Public Class RoomController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    'function to insert value to room table
    Public Function insert(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'insert field values into room table in database

            oCommand.CommandText = _
                   "INSERT INTO room (room_number, type, price, num_beds, availability, floor, description) VALUES (?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("RNumber", OleDbType.Integer, 255)
            oCommand.Parameters.Add("RType", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("RPrice", OleDbType.Double, 255)
            oCommand.Parameters.Add("Bed", OleDbType.Integer, 255)
            oCommand.Parameters.Add("Avai", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Floor", OleDbType.Integer, 255)
            oCommand.Parameters.Add("Descrip", OleDbType.LongVarChar, 5000)


            oCommand.Parameters("RNumber").Value = CStr(htData("RNumber"))
            oCommand.Parameters("RType").Value = CStr(htData("RType"))
            oCommand.Parameters("RPrice").Value = CStr(htData("RPrice"))
            oCommand.Parameters("Bed").Value = CStr(htData("Bed"))
            oCommand.Parameters("Avai").Value = CStr(htData("Avai"))
            oCommand.Parameters("Floor").Value = CStr(htData("Floor"))
            oCommand.Parameters("Descrip").Value = CStr(htData("Descrip"))


            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was inserted.")

        Catch ex As Exception 'If there is any error
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occured. The record wasn't inserted.")
        Finally
            'Close connection to database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'function to update value to room table
    Public Function update(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'update field values into room table in database

            oCommand.CommandText = _
                   "UPDATE room SET type = ?, price = ?, num_beds = ?, availability = ?, floor = ?, description = ? WHERE room_number = ?;"


            oCommand.Parameters.Add("RType", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("RPrice", OleDbType.Double, 255)
            oCommand.Parameters.Add("Bed", OleDbType.Integer, 255)
            oCommand.Parameters.Add("Avai", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Floor", OleDbType.Integer, 255)
            oCommand.Parameters.Add("Descrip", OleDbType.LongVarChar, 5000)
            oCommand.Parameters.Add("RNumber", OleDbType.Integer, 255)


            oCommand.Parameters("RType").Value = CStr(htData("RType"))
            oCommand.Parameters("RPrice").Value = CDbl(htData("RPrice"))
            oCommand.Parameters("Bed").Value = CInt(htData("Bed"))
            oCommand.Parameters("Avai").Value = CStr(htData("Avai"))
            oCommand.Parameters("Floor").Value = CInt(htData("Floor"))
            oCommand.Parameters("Descrip").Value = CStr(htData("Descrip"))
            oCommand.Parameters("RNumber").Value = CInt(htData("RNumber"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was updated.")
            'Display notification
            MsgBox("The record was updated.")

        Catch ex As Exception 'If there is any error
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occured. The record wasn't updated.")
        Finally
            'Close connection to database
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'function to delete record from room table
    Public Function delete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'delete record from room table in database

            oCommand.CommandText = _
                   "DELETE FROM room WHERE room_number = ?;"


       
            oCommand.Parameters.Add("RNumber", OleDbType.Integer, 255)

            oCommand.Parameters("RNumber").Value = CInt(sId)

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))
            'Display notification
            Debug.Print("The record was deleted.")
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

    'function to find all room in database
    Public Function findAll() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Retrieve room information from database
            oCommand.CommandText = _
                    "SELECT * FROM room ORDER BY room_number;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'Write room information to hashtable
                htTempData = New Hashtable
                htTempData("RNumber") = CStr(oDataReader("room_number"))
                htTempData("RType") = CStr(oDataReader("type"))
                htTempData("RPrice") = CStr(oDataReader("price"))
                htTempData("Bed") = CStr(oDataReader("num_beds"))
                htTempData("Avai") = CStr(oDataReader("availability"))
                htTempData("Floor") = CStr(oDataReader("floor"))
                htTempData("Descrip") = CStr(oDataReader("description"))
                lsData.Add(htTempData)
            Loop
            'Display notification
            MsgBox("All room records were found.")

        Catch ex As Exception 'If there is any error
            Debug.Print("ERROR: " & ex.Message)
            'Display error message
            MsgBox("An error occurred. The records could not be found!")
        Finally
            'Close connection to database
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'function to find room that meet searching criteria
    Public Function findById(ByVal sSQL As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            'Open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'Retrieve all room information that meet searching criterias
            oCommand.CommandText = _
                "SELECT * FROM room WHERE " & sSQL & " ;"
            
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'Write room information to hashtable
                htTempData = New Hashtable
                htTempData("RNumber") = CStr(oDataReader("room_number"))
                htTempData("RType") = CStr(oDataReader("type"))
                htTempData("RPrice") = CStr(oDataReader("price"))
                htTempData("Bed") = CStr(oDataReader("num_beds"))
                htTempData("Avai") = CStr(oDataReader("availability"))
                htTempData("Floor") = CStr(oDataReader("floor"))
                htTempData("Descrip") = CStr(oDataReader("description"))
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
