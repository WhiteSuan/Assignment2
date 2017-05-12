Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions
Imports System.Data.OleDb

' Name:        Validation.vb
' Description: Class containing validation methods
' Author:      Y Nguyen
' Date:        03/25/2017

Public Class validation
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment1.accdb"

    ' Function to check if value is numeric or not
    Public Function isNumericVal(ByVal strVal As String) As Boolean

        ' To handle the error when the value is not numeric
        Try
            Return IsNumeric(strVal)
        Catch ex As Exception
            Debug.Print("Error: " & ex.Message)

            Return False
        End Try

    End Function

    Public Function isDoubleVal(ByVal strVal As String) As Boolean

        ' To handle the error when the value is not numeric
        Try
            Return CBool(Double.Parse(strVal))
        Catch ex As Exception
            Debug.Print("Error: " & ex.Message)
            Return False
        End Try

    End Function
    Public Function isNullOrEmpty(ByVal strVal As String) As Boolean
        If strVal.Length > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function monkey(ByVal strVal As String) As Boolean
        If strVal.Length > 255 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function monkey1(ByVal strVal As String) As Boolean
        If strVal.Length > 80 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function monkey2(ByVal strVal As String) As Boolean
        If strVal.Length > 1000 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function isEmpty(ByVal strVal As String) As Boolean

        ' To handle the error when the value is not numeric
        If strVal.Length > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function isPhoneVal(ByVal strVal As String) As Boolean
        ' Please comment on what this line of code does!! 
        Dim pattern As Regex = New Regex("^[0-9 ]")

        ' Please comment on what this block of code does!! 
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Public Function isEmailVal(ByVal strVal As String) As Boolean
        ' Please comment on what this line of code does!! 
        Dim pattern As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        ' Please comment on what this block of code does!! 
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    ' Function to check if value is alphanumeric or not
    Public Function isYearVal(ByVal strVal As String) As Boolean
        ' Please comment on what this line of code does!! 
        Dim pattern As Regex = New Regex("(^(?:19|20)\d{2})$")

        ' Please comment on what this block of code does!! 
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If

    End Function

    

End Class
