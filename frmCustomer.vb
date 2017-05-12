Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing

' Name:        frmCustomer.vb
' Description: Form for inserting customer details into customer table
' Author:      Y Nguyen
' Date:        3/25/2017

Public Class frmCustomer

    Public Const CONNECTION_STRING As String = _
  "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    'when click on Insert button
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'validation for fields in customer form
        Dim oValidation As New validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim tt As New ToolTip()

        'check if there is an item chosen in Title combobox or not
        'If no then
        If cbTitle.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbTitle.Visible = True
            'display error message
            tt.SetToolTip(pbTitle, "Please select title in Title combobox")
        Else
            'hide error picture
            pbTitle.Visible = False
        End If


        'check if first name is empty or not
        bIsValid = oValidation.isEmpty(tbFName.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbFName.Visible = True
            'display error message
            tt.SetToolTip(pbFName, "Please enter your first name")

        Else
            'monkey testing first name textbox
            bIsValid = oValidation.monkey1(tbFName.Text)
            'If first name value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbFName.Visible = True
                'display error message
                tt.SetToolTip(pbFName, "You reach the text limits. Only allow 80 characters. Please shortens your input.")

            Else
                'hide error picture
                pbFName.Visible = False
            End If
        End If

        'check if last name is empty or not
        bIsValid = oValidation.isEmpty(tbLName.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbLName.Visible = True
            'display error message
            tt.SetToolTip(pbLName, "Please enter your last name")

        Else
            'monkey testing last name textbox
            bIsValid = oValidation.monkey1(tbLName.Text)
            'If last name value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbLName.Visible = True
                'display error message
                tt.SetToolTip(pbLName, "You reach the text limits. Only allow 80 characters. Please shortens your input.")

            Else
                'hide error picture
                pbLName.Visible = False
            End If
        End If

        'check if address is empty or not
        bIsValid = oValidation.isEmpty(tbAddress.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbAddress.Visible = True
            'display error message
            tt.SetToolTip(pbAddress, "Please enter your address")

        Else
            'monkey testing address textbox
            bIsValid = oValidation.monkey(tbAddress.Text)
            'If address value is more than 255 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbAddress.Visible = True
                'display error message
                tt.SetToolTip(pbAddress, "You reach the text limits. Only allow 255 characters. Please shortens your input.")

            Else
                'hide error picture
                pbAddress.Visible = False
            End If
        End If

        'check if Phone value is in phone type or not
        bIsValid = oValidation.isPhoneVal(tbPhone.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbPhone.Visible = True
            'display error message
            tt.SetToolTip(pbPhone, "Please enter a phone number (only allows number and space)")
        Else
            'monkey testing phone textbox
            bIsValid = oValidation.monkey1(tbPhone.Text)
            'If phone value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbPhone.Visible = True
                'display error message
                tt.SetToolTip(pbPhone, "You reach the text limits. Only allow 80 characters. Please shortens your input.")

            Else
                'hide error picture
                pbPhone.Visible = False
            End If
        End If

        'check if Email value is in email type or not
        bIsValid = oValidation.isEmailVal(tbEmail.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbEmail.Visible = True
            'display error message
            tt.SetToolTip(pbEmail, "Your email is invalid")
        Else
            'monkey testing email textbox
            bIsValid = oValidation.monkey(tbEmail.Text)
            'If last name value is more than 255 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbEmail.Visible = True
                'display error message
                tt.SetToolTip(pbEmail, "You reach the text limits. Only allow 255 characters. Please shortens your input.")

            Else
                'hide error picture
                pbEmail.Visible = False
            End If
        End If

        'if all validation is done and valid, insert data to customer table
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")

            Dim htData As Hashtable = New Hashtable
            'assign values from customer form to data of Hashtable
            htData("Title") = cbTitle.SelectedItem.ToString
            htData("FirstName") = tbFName.Text
            htData("LastName") = tbLName.Text
            htData("Gender") = tbGender.Text
            htData("Phone") = tbPhone.Text
            htData("Address") = tbAddress.Text
            htData("Email") = tbEmail.Text
            htData("DOB") = dtDob.Value.ToString("yyyy-MM-dd")

            'insert field values into customer table in database
            Dim oCustomerController As CustomerController = New CustomerController
            'call insert function in customer controller and run it with assigned hashdata
            Dim iNumRows = oCustomerController.insert(htData)
            Debug.Print(CStr(iNumRows))

        Else
            'if all fields are not valid, show message box
            MsgBox("One of the fields was invalid")
        End If

    End Sub

    'when click on reset button, customer form will be reloaded into a new form
    Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click
        Dim frm = New frmCustomer
        'show new customer form
        frm.Show()
        'close the current customer form
        Me.Close()
    End Sub

    'if click on botton Menu, show Menu form
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        frmSwitchBoard.Show()
        'hide the current customer form
        Me.Hide()
    End Sub

    'assign Gender textbox with the value associated with Title combobox item
    Private Sub cbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTitle.SelectedIndexChanged
        'if "Mr" item chosen in Title combobox
        If cbTitle.SelectedItem.ToString = "Mr" Then
            'assign value of Gender as Male
            tbGender.Text = "Male"
        Else
            'else, assign as Female
            tbGender.Text = "Female"
        End If
    End Sub

    'when Customer form loads
    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set max date of DOB datetimepicker as today
        dtDob.MaxDate = Date.Today()
        'make a new connection to db
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            'Open db connection
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the first record in customer table
            oCommand.CommandText = _
                "Select top 1 customer_ID, title, firstname, lastname, gender, phone, address, email, DOB from customer;"
            oCommand.Prepare()
            Dim CustID As OleDbDataReader = oCommand.ExecuteReader()

            While CustID.Read
                If CustID("customer_ID") Is DBNull.Value Then

                Else
                    'then assign the values of the record result to the values of fields in Room form
                    tbCustomerId.Text = CustID.Item("customer_ID").ToString
                    cbTitle.Text = CustID.Item("title").ToString
                    tbFName.Text = CustID.Item("firstname").ToString
                    tbLName.Text = CustID.Item("lastname").ToString
                    tbGender.Text = CustID.Item("gender").ToString
                    tbPhone.Text = CustID.Item("phone").ToString
                    tbAddress.Text = CustID.Item("address").ToString
                    tbEmail.Text = CustID.Item("email").ToString
                    dtDob.Text = CustID.Item("DOB").ToString


                End If
            End While

        Catch ex As Exception
            'if there is an error in loading Customer form, show the associated error message
            Debug.Print(ex.Message)
        Finally
            'close db connection
            oConnection.Close()
        End Try

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

        Dim oController As CustomerController = New CustomerController
        'execute find all function to find all records in customer table
        Dim lsData = oController.findAll()
        Dim sRow As String()

        For Each room In lsData
            'then display each record as a row in datagridview
            sRow = New String() {CStr(room("CustomerID")), CStr(room("Title")), CStr(room("FirstName")), CStr(room("LastName")), CStr(room("Gender")), CStr(room("Phone")), CStr(room("Address")), CStr(room("Email")), CStr(room("DOB"))}
            dgvResult.Rows.Add(sRow)
        Next


    End Sub

    'when click on Update button
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        'validation for fields in customer form
        Dim oValidation As New validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim tt As New ToolTip()

        'check if there is an item chosen in Title combobox or not
        'If no then
        If cbTitle.SelectedIndex = -1 Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbTitle.Visible = True
            'display error message
            tt.SetToolTip(pbTitle, "Please select title in Title combobox")
        Else
            'hide error picture
            pbTitle.Visible = False
        End If


        'check if first name is empty or not
        bIsValid = oValidation.isEmpty(tbFName.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbFName.Visible = True
            'display error message
            tt.SetToolTip(pbFName, "Please enter your first name")

        Else
            'monkey testing first name textbox
            bIsValid = oValidation.monkey1(tbFName.Text)
            'If first name value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbFName.Visible = True
                'display error message
                tt.SetToolTip(pbFName, "You reach the text limits. Only allow 80 characters. Please shortens your input.")

            Else
                'hide error picture
                pbFName.Visible = False
            End If
        End If

        'check if last name is empty or not
        bIsValid = oValidation.isEmpty(tbLName.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbLName.Visible = True
            'display error message
            tt.SetToolTip(pbLName, "Please enter your last name")

        Else
            'monkey testing last name textbox
            bIsValid = oValidation.monkey1(tbLName.Text)
            'If last name value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbLName.Visible = True
                'display error message
                tt.SetToolTip(pbLName, "You reach the text limits. Only allow 80 characters. Please shortens your input.")

            Else
                'hide error picture
                pbLName.Visible = False
            End If
        End If

        'check if address is empty or not
        bIsValid = oValidation.isEmpty(tbAddress.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbAddress.Visible = True
            'display error message
            tt.SetToolTip(pbAddress, "Please enter your address")

        Else
            'monkey testing address textbox
            bIsValid = oValidation.monkey(tbAddress.Text)
            'If address value is more than 255 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbAddress.Visible = True
                'display error message
                tt.SetToolTip(pbAddress, "You reach the text limits. Only allow 255 characters. Please shortens your input.")

            Else
                'hide error picture
                pbAddress.Visible = False
            End If
        End If

        'check if Phone value is in phone type or not
        bIsValid = oValidation.isPhoneVal(tbPhone.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbPhone.Visible = True
            'display error message
            tt.SetToolTip(pbPhone, "Please enter a phone number (only allows number and space)")
        Else
            'monkey testing phone textbox
            bIsValid = oValidation.monkey1(tbPhone.Text)
            'If phone value is more than 80 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbPhone.Visible = True
                'display error message
                tt.SetToolTip(pbPhone, "You reach the text limits. Only allow 80 characters. Please shortens your input.")

            Else
                'hide error picture
                pbPhone.Visible = False
            End If
        End If

        'check if Email value is in email type or not
        bIsValid = oValidation.isEmailVal(tbEmail.Text)
        If Not bIsValid Then
            'all fields are not valid
            bAllFieldsValid = False
            'set error picture visible
            pbEmail.Visible = True
            'display error message
            tt.SetToolTip(pbEmail, "Your email is invalid")
        Else
            'monkey testing email textbox
            bIsValid = oValidation.monkey(tbEmail.Text)
            'If last name value is more than 255 characters then
            If Not bIsValid Then
                'all fields are not valid
                bAllFieldsValid = False
                'set error picture visible
                pbEmail.Visible = True
                'display error message
                tt.SetToolTip(pbEmail, "You reach the text limits. Only allow 255 characters. Please shortens your input.")

            Else
                'hide error picture
                pbEmail.Visible = False
            End If
        End If

        'if all validation is done and valid, update data to customer table
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")

            Dim htData As Hashtable = New Hashtable
            'assign values from customer form to data of Hashtable
            htData("Title") = cbTitle.SelectedItem.ToString
            htData("FirstName") = tbFName.Text
            htData("LastName") = tbLName.Text
            htData("Gender") = tbGender.Text
            htData("Phone") = tbPhone.Text
            htData("Address") = tbAddress.Text
            htData("Email") = tbEmail.Text
            htData("DOB") = dtDob.Value.ToString("yyyy-MM-dd")
            htData("CustomerID") = tbCustomerId.Text

            'update field values into customer table in database
            Dim oCustomerController As CustomerController = New CustomerController
            'call update function in customer controller and run it with assigned hashdata
            Dim iNumRows = oCustomerController.update(htData)
            Debug.Print(CStr(iNumRows))

        Else
            'if all fields are not valid, show message box
            MsgBox("One of the fields was invalid")
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
                'get the record in customer table where customer id = index value of the chosen row
                oCommand.CommandText = _
                    "Select customer_ID, title, firstname, lastname, gender, phone, address, email, DOB from customer where customer_ID = " & CType(value, String) & ";"
                oCommand.Prepare()
                Dim CustID As OleDbDataReader = oCommand.ExecuteReader()

                While CustID.Read
                    If CustID("customer_ID") Is DBNull.Value Then

                    Else
                        'then, assign the values of the record result to the values of fields in Customer form
                        tbCustomerId.Text = CustID.Item("customer_ID").ToString
                        cbTitle.Text = CustID.Item("title").ToString
                        tbFName.Text = CustID.Item("firstname").ToString
                        tbLName.Text = CustID.Item("lastname").ToString
                        tbGender.Text = CustID.Item("gender").ToString
                        tbPhone.Text = CustID.Item("phone").ToString
                        tbAddress.Text = CustID.Item("address").ToString
                        tbEmail.Text = CustID.Item("email").ToString
                        dtDob.Text = CustID.Item("DOB").ToString

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
        'check if there is a value in Customer ID textbox
        If Me.tbCustomerId.Text = "" Then
            'if not, ask to input customer ID
            MsgBox("Please input Customer ID")
        Else
            'else, select the previous record in the customer table
            'make a new db connection
            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            Try
                'open db connection
                oConnection.Open()

                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection
                'get all records that have customer ID smaller than the current value in customer ID textbox, then order them descendingly. Finally, get the top one, that's the previous record
                oCommand.CommandText = _
                    "Select top 1 customer_ID, title, firstname, lastname, gender, phone, address, email, DOB from customer where customer_ID < " & tbCustomerId.Text & "  ORDER BY customer_ID DESC;"

                oCommand.Prepare()
                Dim CustID As OleDbDataReader = oCommand.ExecuteReader()

                While CustID.Read
                    'if there is no appropriate result
                    If CustID("customer_ID") Is DBNull.Value Then
                        'then show error message
                        MsgBox("No More Record!")
                    Else
                        'assign the values of the record result to the values of fields in Customer form
                        tbCustomerId.Text = CustID.Item("customer_ID").ToString
                        cbTitle.Text = CustID.Item("title").ToString
                        tbFName.Text = CustID.Item("firstname").ToString
                        tbLName.Text = CustID.Item("lastname").ToString
                        tbGender.Text = CustID.Item("gender").ToString
                        tbPhone.Text = CustID.Item("phone").ToString
                        tbAddress.Text = CustID.Item("address").ToString
                        tbEmail.Text = CustID.Item("email").ToString
                        dtDob.Text = CustID.Item("DOB").ToString

                    End If
                End While

            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                oConnection.Close()
            End Try
        End If

    End Sub

    'when click on > button
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'check if there is a value in Customer ID textbox
        If Me.tbCustomerId.Text = "" Then
            'if not, ask to input Customer ID
            MsgBox("Please input Customer ID")
        Else
            'else, select the next record in the customer table
            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            Try
                oConnection.Open()

                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection
                'get all records that have customer ID greater than the current value in Customer ID textbox, then order them ascendingly. Finally, get the top one, that's the next record
                oCommand.CommandText = _
                    "Select top 1 customer_ID, title, firstname, lastname, gender, phone, address, email, DOB from customer where customer_ID > " & tbCustomerId.Text & "  ORDER BY customer_ID ASC;"

                oCommand.Prepare()
                Dim CustID As OleDbDataReader = oCommand.ExecuteReader()

                While CustID.Read
                    'if there is no appropriate result
                    If CustID("customer_ID") Is DBNull.Value Then
                        'then show error message
                        MsgBox("No More Record!")
                    Else
                        'assign the values of the record result to the values of fields in Customer form
                        tbCustomerId.Text = CustID.Item("customer_ID").ToString
                        cbTitle.Text = CustID.Item("title").ToString
                        tbFName.Text = CustID.Item("firstname").ToString
                        tbLName.Text = CustID.Item("lastname").ToString
                        tbGender.Text = CustID.Item("gender").ToString
                        tbPhone.Text = CustID.Item("phone").ToString
                        tbAddress.Text = CustID.Item("address").ToString
                        tbEmail.Text = CustID.Item("email").ToString
                        dtDob.Text = CustID.Item("DOB").ToString

                    End If
                End While

            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                'close connection
                oConnection.Close()
            End Try
        End If

    End Sub

    'when click |< button
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        'make a new db connection
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            'open db connection
            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'select the first record in customer table
            oCommand.CommandText = _
                "Select top 1 customer_ID, title, firstname, lastname, gender, phone, address, email, DOB from customer ORDER BY customer_ID ASC;"

            oCommand.Prepare()
            Dim CustID As OleDbDataReader = oCommand.ExecuteReader()

            While CustID.Read
                'if there is no record
                If CustID("customer_ID") Is DBNull.Value Then
                    MsgBox("No Record!")
                Else
                    'else, assign the values of the record result to the values of fields in Customer form
                    tbCustomerId.Text = CustID.Item("customer_ID").ToString
                    cbTitle.Text = CustID.Item("title").ToString
                    tbFName.Text = CustID.Item("firstname").ToString
                    tbLName.Text = CustID.Item("lastname").ToString
                    tbGender.Text = CustID.Item("gender").ToString
                    tbPhone.Text = CustID.Item("phone").ToString
                    tbAddress.Text = CustID.Item("address").ToString
                    tbEmail.Text = CustID.Item("email").ToString
                    dtDob.Text = CustID.Item("DOB").ToString

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
            'select the last record in customer table
            oCommand.CommandText = _
                "Select top 1 customer_ID, title, firstname, lastname, gender, phone, address, email, DOB from customer ORDER BY customer_ID DESC;"

            oCommand.Prepare()
            Dim CustID As OleDbDataReader = oCommand.ExecuteReader()

            While CustID.Read
                'if there is no record
                If CustID("customer_ID") Is DBNull.Value Then
                    MsgBox("No Record!")
                Else
                    'else, assign the values of the record result to the values of fields in Customer form
                    tbCustomerId.Text = CustID.Item("customer_ID").ToString
                    cbTitle.Text = CustID.Item("title").ToString
                    tbFName.Text = CustID.Item("firstname").ToString
                    tbLName.Text = CustID.Item("lastname").ToString
                    tbGender.Text = CustID.Item("gender").ToString
                    tbPhone.Text = CustID.Item("phone").ToString
                    tbAddress.Text = CustID.Item("address").ToString
                    tbEmail.Text = CustID.Item("email").ToString
                    dtDob.Text = CustID.Item("DOB").ToString

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
        If MsgBox("Do you want to delete this record?", vbYesNo) = vbYes Then 'Display confirmation message

        Dim oController As CustomerController = New CustomerController

        Dim sId = tbCustomerId.Text
            'run delete function in customer controller and delete the record by Customer ID
        Dim iNumRows = oController.delete(sId)

        If iNumRows = 1 Then
                'after successfully delete that record, reset customer form
            Dim frm = New frmCustomer
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

    'when click on Search button
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'open Search form
        frmSearchForm.Show()
        'set the second field as First Name
        frmSearchForm.lblSecondCriteria.Text = "First Name:"
        'set the first field as Customer ID
        frmSearchForm.lblFirstCriteria.Text = "Customer ID:"
        'set the title of Search form as Customer Search
        frmSearchForm.Text = "Customer Search"

    End Sub

End Class


