Option Explicit On
Option Strict On

' Name:        mSQL.vb
' Description: Contain SQL queries
' Author:      Y Nguyen
' Date:        3/25/2017

Module mSQL
    'Get SQL to generate report
    Public Function getSQL() As String

        'Declare variables
        Dim iSelect As Integer
        Dim sSQL As String = ""
        Dim bProceed As Boolean = True
        'Get the index of the report
        iSelect = CInt(frmReportGenerate.cboReport.SelectedIndex)
        'Choose SQL base on selected report
        sSQL = chooseSQL(iSelect)

        Return sSQL

    End Function

    'Choose SQL based on report index and input from user
    Public Function chooseSQL(ByVal index As Integer) As String

        Dim SQL As String
        Dim iSelectedCustomer As Integer
        Dim iSelectedRoom As Integer
        Dim iFromMonth As Integer
        Dim iToMonth As Integer
        Dim iFromYear As Integer
        Dim iToYear As Integer
        Dim iCurrentYear As Integer
        Select Case index

            Case 0 'If the report is 1, choose this SQL
                If frmReportGenerate.cboCustomer.SelectedIndex <> -1 Then
                    'Get the customer ID
                    iSelectedCustomer = CInt(frmReportGenerate.cboCustomer.Text.Substring(0, frmReportGenerate.cboCustomer.Text.IndexOf(" ")))
                    SQL = "SELECT top 1 B.booking_ID, B.booking_date, B.room_number, B.num_days, C.title, C.firstname, C.lastname " & _
                        "FROM booking AS B LEFT JOIN customer AS C ON B.customer_ID = C.customer_ID  " & _
                        "WHERE B.customer_ID = " & iSelectedCustomer & _
                        " ORDER BY B.booking_date DESC;"
                Else : MsgBox("Please select Customer")
                End If

            Case 1 'If the report is 2, choose this SQL

                If frmReportGenerate.cboRoom.SelectedIndex <> -1 Then
                    'Get the room number
                    iSelectedRoom = CInt(frmReportGenerate.cboRoom.Text)
                    SQL = "SELECT top 1 room_number, booking_date, total_price " & _
                        "FROM booking " & _
                        "WHERE room_number = " & iSelectedRoom & _
                        " ORDER BY booking_date DESC;"
                Else : MsgBox("Please select Room number")
                End If

            Case 2 'If the report is 3, choose this SQL

                If frmReportGenerate.cboCustomer.SelectedIndex <> -1 Then
                    If frmReportGenerate.cboFromMonth.SelectedIndex <> -1 Then
                        If frmReportGenerate.tbFromYear.Text <> "" Then
                            If frmReportGenerate.cboToMonth.SelectedIndex <> -1 Then
                                If frmReportGenerate.tbToYear.Text <> "" Then
                                    Dim oValidation As New validation
                                    Dim bIsValid As Boolean
                                    Dim bAllFieldsValid As Boolean = True
                                    Dim tt As New ToolTip()
                                    bIsValid = oValidation.monkey1(frmReportGenerate.tbFromYear.Text)
                                    If Not bIsValid Then
                                        bAllFieldsValid = False
                                        frmReportGenerate.pbFrom.Visible = True
                                    Else

                                        bIsValid = oValidation.isYearVal(frmReportGenerate.tbFromYear.Text)
                                        If Not bIsValid Then
                                            bAllFieldsValid = False
                                            frmReportGenerate.pbFrom.Visible = True


                                        Else
                                            frmReportGenerate.pbFrom.Visible = False
                                        End If
                                    End If


                                    bIsValid = oValidation.monkey1(frmReportGenerate.tbToYear.Text)
                                    If Not bIsValid Then
                                        bAllFieldsValid = False
                                        frmReportGenerate.pbTo.Visible = True
                                    Else
                                        bIsValid = oValidation.isYearVal(frmReportGenerate.tbToYear.Text)
                                        If Not bIsValid Then
                                            bAllFieldsValid = False
                                            frmReportGenerate.pbTo.Visible = True
                                        Else
                                            frmReportGenerate.pbTo.Visible = False
                                        End If
                                    End If


                                    If bAllFieldsValid Then
                                        'Get the customer ID
                                        iSelectedCustomer = CInt(frmReportGenerate.cboCustomer.Text.Substring(0, frmReportGenerate.cboCustomer.Text.IndexOf(" ")))
                                        'Get the From Month
                                        iFromMonth = CInt(frmReportGenerate.cboFromMonth.Text)
                                        'Get the From Year
                                        iFromYear = CInt(frmReportGenerate.tbFromYear.Text)
                                        'Get the To Month
                                        iToMonth = CInt(frmReportGenerate.cboToMonth.Text)
                                        'Get the To Year
                                        iToYear = CInt(frmReportGenerate.tbToYear.Text)
                                        SQL = "SELECT count(B.booking_id) as total_booking, C.title, C.firstname, C.lastname " & _
                                            "FROM booking AS B left join customer AS C ON B.customer_id = C.customer_id " & _
                                            "WHERE C.customer_id = " & iSelectedCustomer & " AND month(booking_date) >= " & iFromMonth & " AND year(booking_date) >= " & iFromYear & " AND month(booking_date) <= " & iToMonth & " AND year(booking_date) <= " & iToYear & "" & _
                                            " GROUP BY C.title, C.firstname, C.lastname;"
                                    Else
                                        'if all fields are not valid, show message box
                                        MsgBox("One of the fields was invalid")
                                    End If
                                Else : MsgBox("Please type in To Year")
                                End If
                                Else : MsgBox("Please choose To Month")
                                End If
                        Else : MsgBox("Please type in From Year")
                        End If
                    Else : MsgBox("Please choose From Month")
                    End If
                Else : MsgBox("Please choose customer")
                End If

            Case 3 'If the report is 4, choose this SQL

                If frmReportGenerate.cboFromMonth.SelectedIndex <> -1 Then
                    If frmReportGenerate.tbFromYear.Text <> "" Then
                        Dim oValidation As New validation
                        Dim bIsValid As Boolean
                        Dim bAllFieldsValid As Boolean = True
                        Dim tt As New ToolTip()
                        bIsValid = oValidation.monkey1(frmReportGenerate.tbFromYear.Text)
                        If Not bIsValid Then
                            bAllFieldsValid = False
                            frmReportGenerate.pbFrom.Visible = True
                        Else

                            bIsValid = oValidation.isYearVal(frmReportGenerate.tbFromYear.Text)
                            If Not bIsValid Then
                                bAllFieldsValid = False
                                frmReportGenerate.pbFrom.Visible = True


                            Else
                                frmReportGenerate.pbFrom.Visible = False
                            End If
                        End If



                        If bAllFieldsValid Then
                            'Get the month
                            iFromMonth = CInt(frmReportGenerate.cboFromMonth.Text)
                            'Get the year
                            iFromYear = CInt(frmReportGenerate.tbFromYear.Text)

                            SQL = "SELECT booking_id, booking_date, room_number, num_days, total_price " & _
                                        "FROM booking " & _
                                        "WHERE month(booking_date) = " & iFromMonth & " AND year(booking_date) = " & iFromYear & ";"
                        Else
                            'if all fields are not valid, show message box
                            MsgBox("One of the fields was invalid")
                        End If
                    Else : MsgBox("Please type in Year")
                    End If
                    Else : MsgBox("Please choose Month")
                    End If


            Case 4 'If the report is 5, choose this SQL

                If frmReportGenerate.cboFromMonth.SelectedIndex <> -1 Then
                    If frmReportGenerate.tbFromYear.Text <> "" Then
                        Dim oValidation As New validation
                        Dim bIsValid As Boolean
                        Dim bAllFieldsValid As Boolean = True
                        Dim tt As New ToolTip()
                        bIsValid = oValidation.monkey1(frmReportGenerate.tbFromYear.Text)
                        If Not bIsValid Then
                            bAllFieldsValid = False
                            frmReportGenerate.pbFrom.Visible = True
                        Else

                            bIsValid = oValidation.isYearVal(frmReportGenerate.tbFromYear.Text)
                            If Not bIsValid Then
                                bAllFieldsValid = False
                                frmReportGenerate.pbFrom.Visible = True


                            Else
                                frmReportGenerate.pbFrom.Visible = False
                            End If
                        End If



                        If bAllFieldsValid Then
                            'Get the month
                            iFromMonth = CInt(frmReportGenerate.cboFromMonth.Text)
                            'Get the year
                            iFromYear = CInt(frmReportGenerate.tbFromYear.Text)

                            SQL = "SELECT B.customer_id, C.title, C.firstname, C.lastname " & _
                                        "FROM booking AS B left join customer AS C ON B.customer_id = C.customer_id " & _
                                        "WHERE month(checking_date) = " & iFromMonth & " AND year(checking_date) = " & iFromYear & " " & _
                                        " GROUP BY B.customer_id, C.title, C.firstname, C.lastname;"
                        Else
                            'if all fields are not valid, show message box
                            MsgBox("One of the fields was invalid")
                        End If
                    Else : MsgBox("Please type in Year")
                    End If
                    Else : MsgBox("Please choose Month")
                    End If

            Case 5 'If the report is 6, choose this SQL
                If frmReportGenerate.cboRoom.SelectedIndex <> -1 Then
                    If frmReportGenerate.cboFromMonth.SelectedIndex <> -1 Then
                        If frmReportGenerate.tbFromYear.Text <> "" Then
                            Dim oValidation As New validation
                            Dim bIsValid As Boolean
                            Dim bAllFieldsValid As Boolean = True
                            Dim tt As New ToolTip()
                            bIsValid = oValidation.monkey1(frmReportGenerate.tbFromYear.Text)
                            If Not bIsValid Then
                                bAllFieldsValid = False
                                frmReportGenerate.pbFrom.Visible = True
                            Else

                                bIsValid = oValidation.isYearVal(frmReportGenerate.tbFromYear.Text)
                                If Not bIsValid Then
                                    bAllFieldsValid = False
                                    frmReportGenerate.pbFrom.Visible = True


                                Else
                                    frmReportGenerate.pbFrom.Visible = False
                                End If
                            End If



                            If bAllFieldsValid Then
                                'Get the room number
                                iSelectedRoom = CInt(frmReportGenerate.cboRoom.Text)
                                'Get the month
                                iFromMonth = CInt(frmReportGenerate.cboFromMonth.Text)
                                'Get the year
                                iFromYear = CInt(frmReportGenerate.tbFromYear.Text)

                                SQL = "SELECT booking_id, booking_date, num_days, total_price " & _
                                            "FROM booking " & _
                                            "WHERE room_number = " & iSelectedRoom & " AND month(booking_date) = " & iFromMonth & " AND year(booking_date) = " & iFromYear & ";"
                            Else
                                'if all fields are not valid, show message box
                                MsgBox("One of the fields was invalid")
                            End If
                        Else : MsgBox("Please type in Year")
                        End If
                        Else : MsgBox("Please choose Month")
                        End If
                Else : MsgBox("Please choose Room Number")
                End If

            Case 6 'If the report is 7, choose this SQL

                If frmReportGenerate.cboFromMonth.SelectedIndex <> -1 Then
                    If frmReportGenerate.tbFromYear.Text <> "" Then
                        Dim oValidation As New validation
                        Dim bIsValid As Boolean
                        Dim bAllFieldsValid As Boolean = True
                        Dim tt As New ToolTip()
                        bIsValid = oValidation.monkey1(frmReportGenerate.tbFromYear.Text)
                        If Not bIsValid Then
                            bAllFieldsValid = False
                            frmReportGenerate.pbFrom.Visible = True
                        Else

                            bIsValid = oValidation.isYearVal(frmReportGenerate.tbFromYear.Text)
                            If Not bIsValid Then
                                bAllFieldsValid = False
                                frmReportGenerate.pbFrom.Visible = True


                            Else
                                frmReportGenerate.pbFrom.Visible = False
                            End If
                        End If



                        If bAllFieldsValid Then
                            'Get the month
                            iFromMonth = CInt(frmReportGenerate.cboFromMonth.Text)
                            'Get the year
                            iFromYear = CInt(frmReportGenerate.tbFromYear.Text)

                            SQL = "SELECT B.booking_id, B.booking_date, B.num_days, B.total_price, B.room_number, R.type, R.price, R.num_beds, R.floor, R.description " & _
                                        "FROM booking AS B left join room AS R ON B.room_number = R.room_number " & _
                                        "WHERE month(booking_date) = " & iFromMonth & " AND year(booking_date) = " & iFromYear & " " & _
                                        "ORDER BY B.room_number;"
                        Else
                            'if all fields are not valid, show message box
                            MsgBox("One of the fields was invalid")
                        End If
                    Else : MsgBox("Please type in Year")
                    End If
                    Else : MsgBox("Please choose Month")
                    End If

            Case 7 'If the report is 8, choose this SQL
                'Get current year
                iCurrentYear = Year(Now)


                SQL = "SELECT booking_id, amount, invoice_date, MONTH(invoice_date) as MonthInvoice, YEAR(invoice_date) as YearInvoice " & _
                            "FROM invoice " & _
                            "WHERE YEAR(invoice_date) = " & CInt(iCurrentYear) & " " & _
                            "ORDER BY invoice_date;"

        End Select

        Return SQL



    End Function

End Module


