Public Class frmSearchForm
    'When Search button clicked, build searching criterias SQL base on inputed fields
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim sSQL As String = ""
        'If this form is for search booking
        If Me.Text = "Booking Search" Then
            'If booking ID is inputted and customer ID is left blank
            If tbFirstCriteria.Text <> "" And tbSecondCriteria.Text = "" Then
                sSQL = sSQL + " booking_ID = " & tbFirstCriteria.Text & " "

            End If
            'If booking ID is left blank and customer ID is inputted
            If tbSecondCriteria.Text <> "" And tbFirstCriteria.Text = "" Then
                sSQL = sSQL + " customer_ID = " & tbSecondCriteria.Text & " "

            End If
            'If both are inputted
            If tbFirstCriteria.Text <> "" And tbSecondCriteria.Text <> "" Then
                sSQL = sSQL + " booking_ID = " & tbFirstCriteria.Text & " AND customer_ID = " & tbSecondCriteria.Text & " "

            End If
            'If none is inputted, retrieve no booking
            If tbFirstCriteria.Text = "" And tbSecondCriteria.Text = "" Then
                sSQL = " 1 = 2 "

            End If

            'Clear the data grid view
            frmBooking.dgvResult.Rows.Clear()

            Dim oController As BookingController = New BookingController
            'Call findById function from booking controller
            Dim lsData = oController.findById(sSQL)

            Dim sRow As String()
            'If there is booking that meet searching criterias
            If lsData.Count > 0 Then

                'Write to Data grid view in booking form
                For Each booking In lsData


                    'then display each record as a row in datagridview
                    sRow = New String() {CStr(booking("BookingID")), CStr(booking("RNum")), CStr(booking("CusID")), CStr(booking("CDate")), CStr(booking("BDate")), CStr(booking("NumDay")), CStr(booking("NumGuest")), CStr(booking("Total")), CStr(booking("Comment"))}
                    frmBooking.dgvResult.Rows.Add(sRow)

                Next
                'Display notification
                MsgBox("Search complete!")
                Me.Hide()
            Else
                'If there is no booking that meet searching criterias
                Debug.Print("No records were found")
                'Display error message
                MsgBox("No records were found")
                'Hide searching form and return to booking form
                Me.Hide()
            End If

            'If this form is for searching customer
        ElseIf Me.Text = "Customer Search" Then
            'If customer ID is inputted and first name is left blank
            If tbFirstCriteria.Text <> "" And tbSecondCriteria.Text = "" Then
                sSQL = sSQL + " customer_ID = " & tbFirstCriteria.Text & " "

            End If
            'If customer ID is left blank and first name is inputted
            If tbSecondCriteria.Text <> "" And tbFirstCriteria.Text = "" Then
                sSQL = sSQL + " firstname = '" & tbSecondCriteria.Text & "' "

            End If
            'If both are inputted
            If tbFirstCriteria.Text <> "" And tbSecondCriteria.Text <> "" Then
                sSQL = sSQL + " customer_ID = " & tbFirstCriteria.Text & " AND firstname = '" & tbSecondCriteria.Text & "' "

            End If
            'If none is inputted, retrive no customer
            If tbFirstCriteria.Text = "" And tbSecondCriteria.Text = "" Then
                sSQL = " 1 = 2 "

            End If

            'Clear the data grid view
            frmCustomer.dgvResult.Rows.Clear()

            Dim oController As CustomerController = New CustomerController
            'Call findbyId function from customer controller
            Dim lsData = oController.findById(sSQL)
            Dim sRow As String()
            'If there is customer that meet searching criterias
            If lsData.Count >= 0 Then

                'Write customer to Data grid view in customer form
                For Each customer In lsData

                    sRow = New String() {CStr(customer("CustomerID")), CStr(customer("Title")), CStr(customer("FirstName")), CStr(customer("LastName")), CStr(customer("Gender")), CStr(customer("Phone")), CStr(customer("Address")), CStr(customer("Email")), CStr(customer("DOB"))}
                    frmCustomer.dgvResult.Rows.Add(sRow)
                Next
                'Display notification
                MsgBox("Search complete!")
                Me.Hide()
            Else
                'If there is no customer meet searching criterias
                Debug.Print("No records were found")
                'Display error message
                MsgBox("No records were found")
                'Hide searching form and return to customer form
                Me.Hide()
            End If

            'If this form is for searching room
        ElseIf Me.Text = "Room Search" Then
            'If room number is inputted and room type is left blank
            If tbFirstCriteria.Text <> "" And tbSecondCriteria.Text = "" Then
                sSQL = sSQL + " room_number = " & tbFirstCriteria.Text & " "

            End If
            'If room number is left blank and room type is inputted
            If tbSecondCriteria.Text <> "" And tbFirstCriteria.Text = "" Then
                sSQL = sSQL + " type LIKE '%" & tbSecondCriteria.Text & "%' "

            End If
            'If both are inputted
            If tbFirstCriteria.Text <> "" And tbSecondCriteria.Text <> "" Then
                sSQL = sSQL + " room_number = " & tbFirstCriteria.Text & " AND type LIKE '%" & tbSecondCriteria.Text & "%' "

            End If
            'If none is inputted, retrieve no room
            If tbFirstCriteria.Text = "" And tbSecondCriteria.Text = "" Then
                sSQL = " 1 = 2 "

            End If

            'Clear the data grid view
            frmRoom.dgvResult.Rows.Clear()

            Dim oController As RoomController = New RoomController
            'Call findById function from Room Controller
            Dim lsData = oController.findById(sSQL)
            Dim sRow As String()

            'If there is room that meet searching criterias
            If lsData.Count > 0 Then

                'Write room information to Data Grid view in room form
                For Each room In lsData

                    sRow = New String() {CStr(room("RNumber")), CStr(room("Floor")), CStr(room("RType")), CStr(room("RPrice")), CStr(room("Bed")), CStr(room("Avai")), CStr(room("Descrip"))}
                    frmRoom.dgvResult.Rows.Add(sRow)

                Next

                'Display notification
                MsgBox("Search complete!")
                'Hide searching form and return to room form
                Me.Hide()
            Else
                'If there is no room meet searching criterias
                Debug.Print("No records were found")
                'Display error message
                MsgBox("No records were found")
                'Hide searching form and return to room form
                Me.Hide()
            End If
        End If
    End Sub
End Class