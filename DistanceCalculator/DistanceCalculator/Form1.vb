'Author:        Randall Draper
'Date:          21 Feb 2014
'Purpose:       CPT115 Chapter6 
'Notes:         Will calculate the total miles of trip
'               based on users input
Option Strict On

Public Class DistanceCalculator
    'Declare and initialize variables
    Dim shoSpeed As Short
    Dim strSpeed As String
    Dim shoDays As Short
    Dim strDays As String
    Dim decHours As Decimal
    Dim decTotalMiles As Decimal = 0D
    Dim strInputMessage As String = " Enter hours that will be driven each day. Enter day"
    Dim strInputHeading As String = " Hours to drive "
    Dim strHighMessage As String = " Can not drive over 20 hours in a day. Enter day"
    Dim strNormalMessage As String = " Enter hours that will be driven each day. Enter day"
    Dim strNonNumericError As String = " Error - Enter a number for hours to drive. Enter day"
    Dim strNegativeError As String = " Error - Number must be positive. Enter day"
    'Declare and initialize loop variables
    Dim intMaxNumberOfHours As Integer = 20
    Dim intNumberOfEntries As Integer = 1
    Dim strCancelClicked As String = ""
    Dim strHours As String

    Private Property decTotalHours As Decimal
    'Validates speed input
    'display error message if not numeric Clears speed text box and 
    'days text box and puts focus back to speed text box

    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged

        If Not (txtSpeed.Text.Equals("")) Then
            If IsNumeric(txtSpeed.Text) Then
                If (CDbl(txtSpeed.Text) < 1) Then
                    MsgBox("You must enter a positive number", , "Input Error")
                    txtSpeed.Clear()
                    txtSpeed.Focus()
                    txtDays.Clear()
                Else
                    shoSpeed = Convert.ToInt16(txtSpeed.Text)
                End If

            ElseIf txtSpeed.Text.Length > 0 Then
                MsgBox("You must enter a number for MPH", , "Input Error")
                txtSpeed.Clear()
                txtSpeed.Focus()
                txtDays.Clear()

            End If
        End If

    End Sub

    'Clears text boxes and total miles label, hides list box and total miles label
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtSpeed.Clear()
        txtDays.Clear()
        intNumberOfEntries = 1
        decTotalHours = 0
        lblTotalMiles.Text = ""
        lblTotalMiles.Visible = False
        lstHours.Visible = False
        lstHours.Items.Clear()
        txtSpeed.Focus()
    End Sub
    'closes form app
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Validates days Input
    'makes lsthours visible
    'initiates input box
    'Loops until entries equal number of days
    'Calculates total miles by multiplying speed by hours
    'makes lblTotalMiles visible
    Private Sub btnHours_Click(sender As Object, e As EventArgs) Handles btnHours.Click

        If Not (txtDays.Text.Equals("")) Then
            If IsNumeric(txtDays.Text) Then
                If (CDbl(txtDays.Text) < 1) Then
                    MsgBox("you must enter a positive nuber for days", , "Input Error")
                    txtDays.Clear()
                    txtDays.Focus()
                    Exit Sub
                Else
                    shoDays = Convert.ToInt16(txtDays.Text)
                End If

            ElseIf txtDays.Text.Length > 0 Then
                MsgBox("you must enter a number for days", , "Input Error")
                txtDays.Clear()
                txtDays.Focus()
                Exit Sub
            End If
        End If
        shoDays = Convert.ToInt16(txtDays.Text)

        lstHours.Visible = True

        strHours = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do While intNumberOfEntries <= shoDays
            If IsNumeric(strHours) Then
                decHours = Convert.ToDecimal(strHours)
                If decHours > intMaxNumberOfHours Then
                    strInputMessage = strHighMessage
                ElseIf decHours < 1 Then
                    strInputMessage = strNegativeError
                ElseIf decHours > 0 And decHours <= intMaxNumberOfHours Then
                    lstHours.Items.Add(decHours)
                    decTotalHours += decHours
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries > shoDays Then
                Exit Do
            End If
            strHours = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
        Loop

        lblTotalMiles.Text = ("The total miles for the trip is: " & shoSpeed * decTotalHours)

        lblTotalMiles.Visible = True
    End Sub


End Class
