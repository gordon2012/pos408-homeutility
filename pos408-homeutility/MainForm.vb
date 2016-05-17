Public Class MainForm
    ' Home Utility Auditing Program
    '        Gordon Doskas
    '           POS/408
    '          May 16, 2016
    '        Dr. Bill Spees

    ' This program calculates the daily cost of an appliance given its power
    ' rating, hours used, and the price of electricity. A sensible default
    ' value is given for each appliance that may be modified. Errors are logged
    ' if valid Double values are not entered, the hours exceeds 24 or is below
    ' 0, or the power rating is more than +/- 20% of the default.


    Private Const RatingValidRange = 0.2


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
    Private Function ValidateRange(control As Control, ByRef value As Double, base As Double, range As Double) As Boolean
        'Dim value As Double

        'Double.Parse(control.Text)

        If Not ValidateIsNumber(control, value) Then
            Return False
        End If

        Dim min As Double = base - (base * range)
        Dim max As Double = base + (base * range)

        If value >= min And value <= max Then
            Return True
        Else
            LogError(control, "ERROR: " + control.Name + " value must be between " + min.ToString() + " and " + max.ToString() + ".")
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

    ' Clears the error log and resets colors
    '
    Private Sub ResetError()
        txtHours.ForeColor = Color.Black
        txtHours.BackColor = Color.White

        txtCost.ForeColor = Color.Black
        txtCost.BackColor = Color.White

        txtRating.ForeColor = Color.Black
        txtRating.BackColor = Color.White

        lblError.Text = ""
        tmrError.Enabled = False
    End Sub


    ' /******************
    '  * EVENT HANDLERS *
    '  ******************/

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize appliance names and base values from Appliancefigures.xls
        '
        Dim applianceList As New Dictionary(Of String, Double)()

        applianceList.Add("Refrigerator", 0.11)
        applianceList.Add("Hair dryer", 1.5)
        applianceList.Add("Television", 0.31)
        applianceList.Add("Desktop computer", 0.09)
        applianceList.Add("Fan", 0.2)
        applianceList.Add("Microwave(1000W)", 1.0)

        cmbAppliance.DataSource = New BindingSource(applianceList, Nothing)
        cmbAppliance.DisplayMember = "Key"
        cmbAppliance.ValueMember = "Value"

        txtRating.Text = cmbAppliance.SelectedValue.ToString()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim rating As Double = 0
        Dim hours As Double = 0
        Dim cost As Double = 0

        ' Validates all input and calculates daily cost
        '
        If ValidateRange(txtHours, hours, 12, 1) And _
            ValidateRange(txtRating, rating, Double.Parse(cmbAppliance.SelectedValue.ToString()), RatingValidRange) And _
            ValidateIsNumber(txtCost, cost) Then
            lblDaily.Text = FormatCurrency(rating * hours * (cost / 100))
        End If
    End Sub

    ' Updates the text of the rating texbox as different appliances are chosen from the combo box
    '
    Private Sub cmbAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        txtRating.Text = cmbAppliance.SelectedValue.ToString()
    End Sub

    ' Reset the error log if an input control is selected or 3 seconds elapses
    '
    Private Sub tmrError_Tick(sender As Object, e As EventArgs) Handles tmrError.Tick
        ResetError()
    End Sub

    Private Sub txtHours_Enter(sender As Object, e As EventArgs) Handles txtHours.Enter
        ResetError()
    End Sub

    Private Sub txtRating_Enter(sender As Object, e As EventArgs) Handles txtRating.Enter
        ResetError()
    End Sub

    Private Sub txtCost_Enter(sender As Object, e As EventArgs) Handles txtCost.Enter
        ResetError()
    End Sub
End Class
