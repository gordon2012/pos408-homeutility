Public Class MainForm
    ' Enhanced Home Utility Auditing Program
    '        Gordon Doskas
    '           POS/408
    '          May 23, 2016
    '        Dr. Bill Spees

    ' This program calculates the daily cost of an appliance given its power
    ' rating, hours used, and the price of electricity. A sensible default
    ' value is given for each appliance that may be modified. Errors are logged
    ' if valid Double values are not entered, the hours exceeds 24 or is below
    ' 0, or the power rating is more than +/- 20% of the default.

    ' TODO: week 3 description


    Private Const MinRating = 0
    Private Const MaxRating = 1.5

    Dim rating As Double
    Dim hours As Double
    Dim cost As Double


    ' Logs an error message if the control's text is not a valid Double
    '
    Private Function ValidateIsNumber(control As Control, ByRef value As Double) As Boolean
        If Double.TryParse(control.Text, value) Then
            Return True
        Else
            LogError(control, "ERROR: " + control.Name + " value must be a number.")
            Return False
        End If
    End Function

    ' Logs an error message if the control's text is not in a certain percent range of the passed base value
    '
    Private Function ValidateRange(control As Control, ByRef value As Double, min As Double, max As Double) As Boolean
        If Not ValidateIsNumber(control, value) Then
            Return False
        End If

        If value >= min And value <= max Then
            Return True
        Else
            LogError(control, "ERROR: " + control.Name + " value must be between " + min.ToString() + " and " + max.ToString())
            Return False
        End If
    End Function

    ' Displays a log message to the log label and changes the color of it and that of the source of the error's control
    '
    Private Sub LogError(control As Control, text As String)
        control.ForeColor = Color.Red
        control.BackColor = Color.Black
        lblError.Text += text + vbNewLine
        tmrError.Enabled = True
    End Sub

    ' Clears the error log, resets colors, and clears the previous calculated daily cost
    '
    Private Sub ResetError()
        txtHours.ForeColor = Color.Black
        txtHours.BackColor = Color.White

        txtCost.ForeColor = Color.Black
        txtCost.BackColor = Color.White

        txtRating.ForeColor = Color.Black
        txtRating.BackColor = Color.White

        lblError.Text = ""
        lblDaily.Text = ""
    End Sub

    ' Resets the output, does the validation, and enables the calculate button
    ' if successful. The validation will silently fail on empty input, meaning
    ' that it will not enable the calculate button but not display an error
    '
    Private Sub PerformValidation()
        Dim valid As Boolean = True

        ResetError()

        If Not txtCost.Text = String.Empty Then
            valid = valid And ValidateIsNumber(txtCost, cost)
        Else
            valid = False
        End If

        If Not txtHours.Text = String.Empty Then
            valid = valid And ValidateRange(txtHours, hours, 0, 24)
        Else
            valid = False
        End If

        If Not txtRating.Text = String.Empty Then
            valid = valid And ValidateRange(txtRating, rating, MinRating, MaxRating)
        Else
            valid = False
        End If

        btnCalculate.Enabled = valid
    End Sub


    ' /******************
    '  * EVENT HANDLERS *
    '  ******************/
    '
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize appliance names
        '
        Dim applianceList() As String = {"Refrigerator", "Hair dryer", "Television", "Desktop computer", "Fan", "Microwave"}
        cmbAppliance.DataSource = New BindingSource(applianceList, Nothing)

        ' Initial validation
        '
        PerformValidation()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Input has already been validated
        '
        lblDaily.Text = FormatCurrency(rating * hours * cost)
    End Sub

    ' Validate all input when any textbox changes
    '
    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        PerformValidation()
    End Sub
    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        PerformValidation()
    End Sub
    Private Sub txtRating_TextChanged(sender As Object, e As EventArgs) Handles txtRating.TextChanged
        PerformValidation()
    End Sub
End Class
