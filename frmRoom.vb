Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing

' Name:        frmRoom.vb
' Description: Form for inserting room details into room table
' Author:      Y Nguyen
' Date:        3/25/2017

Public Class frmRoom
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    'when click on Insert button
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validation fields in room form
        Dim oValidation As New validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim tt As New ToolTip()

        'check if there is an item chosen in Availability combobox or not
        'If no then
        If cbAvai.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbAvai.Visible = True
            'display error message
            tt.SetToolTip(pbAvai, "Please select room availability in Availability combobox")
        Else
            'hide error picture
            pbAvai.Visible = False
        End If

        'check if there is an item chosen in Floor combobox or not
        'If no then
        If cbFloor.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbFloor.Visible = True
            'display error message
            tt.SetToolTip(pbFloor, "Please select floor of room in Floor combobox")
        Else
            'hide error picture
            pbFloor.Visible = False
        End If


        'check if room type is empty or not
        bIsValid = oValidation.isEmpty(tbRType.Text)
        'If room type is empty then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbRType.Visible = True
            'display error message
            tt.SetToolTip(pbRType, "Please enter room type")
        Else
            'monkey testing room type textbox
            bIsValid = oValidation.monkey1(tbRType.Text)
            'If room type value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbRType.Visible = True
                'display error message
                tt.SetToolTip(pbRType, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
            Else
                'hide error picture
                pbRType.Visible = False
            End If
        End If


        'check if room price is float or not
        bIsValid = oValidation.isDoubleVal(tbRPrice.Text)
        'If room price is not float then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbRPrice.Visible = True
            'display error message
            tt.SetToolTip(pbRPrice, "Please enter room price. It can be float number.")
        Else
            'monkey testing room price textbox
            bIsValid = oValidation.monkey1(tbRPrice.Text)
            'If room type value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbRPrice.Visible = True
                'display error message
                tt.SetToolTip(pbRPrice, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
            Else
                'hide error picture
                pbRPrice.Visible = False
            End If
        End If

        'check if num of beds is numeric or not
        bIsValid = oValidation.isNumericVal(tbBed.Text)
        'If num of beds is not numeric then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbBed.Visible = True
            'display error message
            tt.SetToolTip(pbBed, "Please enter number of beds in numeric type")
        Else
            'monkey testing num of beds textbox
            bIsValid = oValidation.monkey1(tbBed.Text)
            'If num of beds value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbBed.Visible = True
                'display error message
                tt.SetToolTip(pbBed, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
            Else
                'hide error picture
                pbBed.Visible = False
            End If
        End If

        'monkey testing description textbox
        bIsValid = oValidation.monkey2(tbDescrip.Text)
        'If description value is more than 1000 characters then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbDescrip.Visible = True
            'display error message
            tt.SetToolTip(pbDescrip, "You reach the text limits. Only allow 1000 characters. Please shortens your input.")
        Else
            'hide error picture
            pbDescrip.Visible = False
        End If

        'if all validation is done and valid, insert data to room table
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
            'assign values from room form to data of Hashtable
            Dim htData As Hashtable = New Hashtable
            htData("RNumber") = tbRNum.Text
            htData("RType") = tbRType.Text
            htData("RPrice") = tbRPrice.Text
            htData("Bed") = tbBed.Text
            htData("Avai") = cbAvai.SelectedItem.ToString
            htData("Floor") = cbFloor.SelectedItem.ToString

            'check if description textbox is null or not. 
            bIsValid = oValidation.isNullOrEmpty(tbDescrip.Text)
            'if null, assign ""  value to hashdata description 
            If bIsValid Then
                htData("Descrip") = DBNull.Value.ToString
            Else
                'else, assign inserted value of description textbox to hashdata description
                htData("Descrip") = tbDescrip.Text.Trim
            End If

            Dim oRoomController As RoomController = New RoomController
            'call insert function in room controller and run it with assigned hashdata
            Dim iNumRows = oRoomController.insert(htData)
            Debug.Print(CStr(iNumRows))
        Else
            'if all fields are not valid, show message box
            MsgBox("One of the fields was invalid")

        End If
    End Sub

    'when click on reset button, room form will be reloaded into a new form
    Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click
        Dim frm = New frmRoom
        'show new room form
        frm.Show()
        'close the current room form
        Me.Close()
    End Sub

    'if click on botton Menu, show Menu form
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        frmSwitchBoard.Show()
        'hide the current room form
        Me.Hide()
    End Sub


    'after selecting Floor, automatically generate a room number associated with floor number
    Private Sub cbFloor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFloor.SelectedIndexChanged
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            oConnection.Open()
            Dim RNum As Integer
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the highest room number in room table, where floor = value in Floor combobox
            oCommand.CommandText = _
                "Select max(room_number) as roomnum from room where floor =" & cbFloor.SelectedItem.ToString & ";"
            oCommand.Prepare()
            Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

            While RNumrd.Read
                'if that floor does not have any room number yet, generate room number as <FloorNumber>01
                If RNumrd("roomnum") Is DBNull.Value Then
                    tbRNum.Text = CStr(cbFloor.SelectedItem.ToString & "01")
                Else
                    'else, assign the value of Room Number textbox as the highest room number +1
                    RNum = CInt(RNumrd("roomnum"))
                    tbRNum.Text = CStr(RNum + 1)
                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub


    'when room form load
    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the first record in room table
            oCommand.CommandText = _
                "Select top 1 room_number, type, price, num_beds, availability, floor, description from room;"
            oCommand.Prepare()
            Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

            While RNumrd.Read
                If RNumrd("room_number") Is DBNull.Value Then

                Else
                    'then assign the values of the record result to the values of fields in Room form
                    cbFloor.Text = RNumrd.Item("floor").ToString
                    tbRNum.Text = RNumrd.Item("room_number").ToString
                    tbRType.Text = RNumrd.Item("type").ToString
                    tbRPrice.Text = RNumrd.Item("price").ToString
                    tbBed.Text = RNumrd.Item("num_beds").ToString
                    cbAvai.Text = RNumrd.Item("availability").ToString
                    tbDescrip.Text = RNumrd.Item("description").ToString

                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try

    End Sub

    'when click on View all button
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        'Clear the data grid view
        dgvResult.Rows.Clear()

        Dim oController As RoomController = New RoomController
        'execute find all function to find all records in room table
        Dim lsData = oController.findAll()
        Dim sRow As String()

        For Each room In lsData
            'then display each record as a row in datagridview
            sRow = New String() {CStr(room("RNumber")), CStr(room("Floor")), CStr(room("RType")), CStr(room("RPrice")), CStr(room("Bed")), CStr(room("Avai")), CStr(room("Descrip"))}
            dgvResult.Rows.Add(sRow)
        Next
    End Sub

    'when click |< button 
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the first record in room table
            oCommand.CommandText = _
                "Select top 1 room_number, type, price, num_beds, availability, floor, description from room ORDER BY room_number ASC;"

            oCommand.Prepare()
            Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

            While RNumrd.Read
                'if there is no record 
                If RNumrd("room_number") Is DBNull.Value Then
                    'then display the error message
                    MsgBox("No Record!")
                Else
                    'else, assign the values of the record result to the values of fields in Room form
                    cbFloor.Text = RNumrd.Item("floor").ToString
                    tbRNum.Text = RNumrd.Item("room_number").ToString
                    tbRType.Text = RNumrd.Item("type").ToString
                    tbRPrice.Text = RNumrd.Item("price").ToString
                    tbBed.Text = RNumrd.Item("num_beds").ToString
                    cbAvai.Text = RNumrd.Item("availability").ToString
                    tbDescrip.Text = RNumrd.Item("description").ToString

                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try



    End Sub

    'when click >| button
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the last record in room table
            oCommand.CommandText = _
                "Select top 1 room_number, type, price, num_beds, availability, floor, description from room ORDER BY room_number DESC;"

            oCommand.Prepare()
            Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

            While RNumrd.Read
                'if there is no record
                If RNumrd("room_number") Is DBNull.Value Then
                    'then display the error message
                    MsgBox("No Record!")
                Else
                    'else, assign the values of the record result to the values of fields in Room form
                    cbFloor.Text = RNumrd.Item("floor").ToString
                    tbRNum.Text = RNumrd.Item("room_number").ToString
                    tbRType.Text = RNumrd.Item("type").ToString
                    tbRPrice.Text = RNumrd.Item("price").ToString
                    tbBed.Text = RNumrd.Item("num_beds").ToString
                    cbAvai.Text = RNumrd.Item("availability").ToString
                    tbDescrip.Text = RNumrd.Item("description").ToString

                End If
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try


    End Sub

    'when click on Search button
     Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'open Search form
        frmSearchForm.Show()
        'set the second field as Room Type
        frmSearchForm.lblSecondCriteria.Text = "Room Type:"
        'set the first field as Room Number
        frmSearchForm.lblFirstCriteria.Text = "Room Number:"
        'set the title of Search form as Room Search
        frmSearchForm.Text = "Room Search"

    End Sub

    Private Sub populateFormFields(ByVal htdata As Hashtable)
        'assign the values of the record result to the values of fields in Room form
        cbFloor.Text = CStr(CInt(htdata("Floor")))
        tbRType.Text = CStr(htdata("RType"))
        tbRPrice.Text = CStr(CDbl(htdata("RPrice")))
        tbBed.Text = CStr(CInt(htdata("Bed")))
        cbFloor.Text = CStr(htdata("Avai"))
        tbDescrip.Text = CStr(htdata("Descrip"))

    End Sub

    'when click on > button
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'check if there is a value in Room Number textbox
        If Me.tbRNum.Text = "" Then
            'if not, ask to input room number
            MsgBox("Please input Room Number")
        Else
            'else, select the next record in the room table
            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            Try
                oConnection.Open()

                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection
                'get all records that have room number greater than the current value in room number textbox, then order them ascendingly. Finally, get the top one, that's the next record
                oCommand.CommandText = _
                    "Select top 1 room_number, type, price, num_beds, availability, floor, description from room where room_number > " & tbRNum.Text & "  ORDER BY room_number ASC;"

                oCommand.Prepare()
                Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

                While RNumrd.Read
                    'if there is no appropriate result
                    If RNumrd("room_number") Is DBNull.Value Then
                        'then show error message
                        MsgBox("No More!")
                    Else
                        'assign the values of the record result to the values of fields in Room form
                        cbFloor.Text = RNumrd.Item("floor").ToString
                        tbRNum.Text = RNumrd.Item("room_number").ToString
                        tbRType.Text = RNumrd.Item("type").ToString
                        tbRPrice.Text = RNumrd.Item("price").ToString
                        tbBed.Text = RNumrd.Item("num_beds").ToString
                        cbAvai.Text = RNumrd.Item("availability").ToString
                        tbDescrip.Text = RNumrd.Item("description").ToString

                    End If
                End While

            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                oConnection.Close()
            End Try
        End If

    End Sub

    'when click on Update button
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        'validation for fields in room form
        Dim oValidation As New validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim tt As New ToolTip()

        'check if there is an item chosen in Availability combobox or not
        'If no then
        If cbAvai.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbAvai.Visible = True
            'display error message
            tt.SetToolTip(pbAvai, "Please select room availability in Availability combobox")
        Else
            'hide error picture
            pbAvai.Visible = False
        End If

        'check if there is an item chosen in Floor combobox or not
        'If no then
        If cbFloor.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbFloor.Visible = True
            'display error message
            tt.SetToolTip(pbFloor, "Please select floor of room in Floor combobox")
        Else
            'hide error picture
            pbFloor.Visible = False
        End If


        'check if room type is empty or not
        bIsValid = oValidation.isEmpty(tbRType.Text)
        'If room type is empty then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbRType.Visible = True
            'display error message
            tt.SetToolTip(pbRType, "Please enter room type")
        Else
            'monkey testing room type textbox
            bIsValid = oValidation.monkey1(tbRType.Text)
            'If room type value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbRType.Visible = True
                'display error message
                tt.SetToolTip(pbRType, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
            Else
                'hide error picture
                pbRType.Visible = False
            End If
        End If


        'check if room price is float or not
        bIsValid = oValidation.isDoubleVal(tbRPrice.Text)
        'If room price is not float then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbRPrice.Visible = True
            'display error message
            tt.SetToolTip(pbRPrice, "Please enter room price. It can be float number.")
        Else
            'monkey testing room price textbox
            bIsValid = oValidation.monkey1(tbRPrice.Text)
            'If room type value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbRPrice.Visible = True
                'display error message
                tt.SetToolTip(pbRPrice, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
            Else
                'hide error picture
                pbRPrice.Visible = False
            End If
        End If

        'check if num of beds is numeric or not
        bIsValid = oValidation.isNumericVal(tbBed.Text)
        'If num of beds is not numeric then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbBed.Visible = True
            'display error message
            tt.SetToolTip(pbBed, "Please enter number of beds in numeric type")
        Else
            'monkey testing num of beds textbox
            bIsValid = oValidation.monkey1(tbBed.Text)
            'If num of beds value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbBed.Visible = True
                'display error message
                tt.SetToolTip(pbBed, "You reach the text limits. Only allow 80 characters. Please shortens your input.")
            Else
                'hide error picture
                pbBed.Visible = False
            End If
        End If

        'monkey testing description textbox
        bIsValid = oValidation.monkey2(tbDescrip.Text)
        'If description value is more than 1000 characters then
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbDescrip.Visible = True
            'display error message
            tt.SetToolTip(pbDescrip, "You reach the text limits. Only allow 1000 characters. Please shortens your input.")
        Else
            'hide error picture
            pbDescrip.Visible = False
        End If

        'if all validation is done and valid, update data to room table
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")

            Dim htData As Hashtable = New Hashtable
            'assign values from room form to data of Hashtable
            htData("RNumber") = tbRNum.Text
            htData("RType") = tbRType.Text
            htData("RPrice") = tbRPrice.Text
            htData("Bed") = tbBed.Text
            htData("Avai") = cbAvai.SelectedItem.ToString
            htData("Floor") = cbFloor.SelectedItem.ToString

            'check if description textbox is null or not. 
            bIsValid = oValidation.isNullOrEmpty(tbDescrip.Text)
            'if null, assign ""  value to hashdata description 
            If bIsValid Then
                htData("Descrip") = DBNull.Value.ToString
            Else
                'else, assign inserted value of description textbox to hashdata description
                htData("Descrip") = tbDescrip.Text.Trim
            End If

            Dim oRoomController As RoomController = New RoomController
            'call update function in room controller and run it with assigned hashdata
            Dim iNumRows = oRoomController.update(htData)
            Debug.Print(CStr(iNumRows))
        Else
            'if all fields are not valid, show message box
            MsgBox("One of the fields was invalid")

        End If

    End Sub

    'when click on Delete button
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'display a message box to confirm if the user really wants to delete the record or not
        If MsgBox("Do you want to delete this record?", vbYesNo) = vbYes Then
            'if yes then
            Dim oController As RoomController = New RoomController

            Dim sId = tbRNum.Text
            'run delete function in room controller and delete the record by room number
            Dim iNumRows = oController.delete(sId)

            If iNumRows = 1 Then
                'after successfully delete that record, reset room form
                Dim frm = New frmRoom
                frm.Show()
                Me.Close()
                'and display message to announce that deletion has been successfull
                MsgBox("The record was deleted. Use the find button to check ...")

            Else
                'else, display error message
                MsgBox("The record was not deleted!")

            End If
        End If


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
                'get the record in room table where room number = index value of the chosen row
                oCommand.CommandText = _
                    "Select room_number, type, price, num_beds, availability, floor, description from room where room_number = " & CType(value, String) & ";"
                oCommand.Prepare()
                Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

                While RNumrd.Read
                    If RNumrd("room_number") Is DBNull.Value Then

                    Else
                        'then, assign the values of the record result to the values of fields in Room form
                        cbFloor.Text = RNumrd.Item("floor").ToString
                        tbRNum.Text = RNumrd.Item("room_number").ToString
                        tbRType.Text = RNumrd.Item("type").ToString
                        tbRPrice.Text = RNumrd.Item("price").ToString
                        tbBed.Text = RNumrd.Item("num_beds").ToString
                        cbAvai.Text = RNumrd.Item("availability").ToString
                        tbDescrip.Text = RNumrd.Item("description").ToString

                    End If
                End While

            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                oConnection.Close()
            End Try
        End If

    End Sub

    'when click on < button
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        'check if there is a value in Room Number textbox
        If Me.tbRNum.Text = "" Then
            'if not, ask to input room number
            MsgBox("Please input Room Number")
        Else
            'else, select the previous record in the room table
            'make a new db connection
            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            Try
                'open db connection
                oConnection.Open()

                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection
                'get all records that have room number smaller than the current value in room number textbox, then order them descendingly. Finally, get the top one, that's the previous record
                oCommand.CommandText = _
                    "Select top 1 room_number, type, price, num_beds, availability, floor, description from room where room_number < " & tbRNum.Text & "  ORDER BY room_number DESC;"

                oCommand.Prepare()
                Dim RNumrd As OleDbDataReader = oCommand.ExecuteReader()

                While RNumrd.Read
                    'if there is no appropriate result
                    If RNumrd("room_number") Is DBNull.Value Then
                        'then show error message
                        MsgBox("No More!")
                    Else
                        'assign the values of the record result to the values of fields in Room form
                        cbFloor.Text = RNumrd.Item("floor").ToString
                        tbRNum.Text = RNumrd.Item("room_number").ToString
                        tbRType.Text = RNumrd.Item("type").ToString
                        tbRPrice.Text = RNumrd.Item("price").ToString
                        tbBed.Text = RNumrd.Item("num_beds").ToString
                        cbAvai.Text = RNumrd.Item("availability").ToString
                        tbDescrip.Text = RNumrd.Item("description").ToString

                    End If
                End While

            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                oConnection.Close()
            End Try
        End If

    End Sub

    'when click on Help tab in Menu strip at the top left of Room form
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

    'when click on About tab in Menu strip at the top left of Room form
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
End Class


