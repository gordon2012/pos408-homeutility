Public Class MainForm
    ' Enhanced Home Utility Auditing Program
    '        Gordon Doskas
    '           POS/408
    '          May 23, 2016
    '        Dr. Bill Spees
    '
    ' This program calculates the daily cost of an appliance given its power
    ' rating, hours used, the price of electricity, and the gallons per hour
    ' and cost per gallon if it is a Washer. Upon calculation, The appliance,
    ' hours per day, and daily cost are added to a listing and the total is
    ' calculated. Errors are displayed next to any field where valid Double
    ' values are not entered, the hours field if it is not between 0 and 24,
    ' and the power rating field if it is not between 0 and 1.5.


    Private Const MinRating = 0
    Private Const MaxRating = 1.5

    Dim rating As Double
    Dim hours As Double
    Dim cost As Double

    Dim waterprice As Double
    Dim gallons As Double

    Dim total As Double = 0

    ' Displays validation error panel if the control's text is not a valid Double
    '
    Private Function ValidateIsNumber(control As Control, ByRef value As Double) As Boolean
        If Double.TryParse(control.Text, value) Then
            Return True
        Else
            DisplayError(control.Name.Substring(3), "Must be a number")
            Return False
        End If
    End Function

    ' Displays validation error panel if the control's text is not in a certain range
    '
    Private Function ValidateRange(control As Control, ByRef value As Double, min As Double, max As Double) As Boolean
        If Not ValidateIsNumber(control, value) Then
            Return False
        End If

        If value >= min And value <= max Then
            Return True
        Else
            DisplayError(control.Name.Substring(3), "Must be a value between " + min.ToString() + " and " + max.ToString())
            Return False
        End If
    End Function

    ' Shows the input text's validation error panel and sets its label text
    '
    Private Sub DisplayError(control As String, text As String)
        Me.Controls.Find("pnl" + control, True)(0).Visible = True
        Me.Controls.Find("lbl" + control, True)(0).Text = text
    End Sub

    ' Hides the validation error panels
    '
    Private Sub ResetError()
        pnlCost.Visible = False
        pnlRating.Visible = False
        pnlHours.Visible = False
        pnlWaterprice.Visible = False
        pnlGallons.Visible = False
    End Sub

    ' Hide a particular error panel
    '
    Private Sub ResetError(control As Control)
        control.Visible = False
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

        ' Washer validation
        '
        If cmbAppliance.SelectedIndex = 6 Then
            If Not txtWaterprice.Text = String.Empty Then
                valid = valid And ValidateIsNumber(txtWaterprice, waterprice)
            Else
                valid = False
            End If

            If Not txtGallons.Text = String.Empty Then
                valid = valid And ValidateIsNumber(txtGallons, gallons)
            Else
                valid = False
            End If
        End If

        btnCalculate.Enabled = valid
    End Sub

    ' TODO separate validation (disabling calculate button) from error labels




    Private Sub CheckFields()
        If cmbAppliance.SelectedIndex = 6 Then
            pnlWater.Visible = True
        Else
            pnlWater.Visible = False
        End If
    End Sub


    ' /******************
    '  * EVENT HANDLERS *
    '  ******************/
    '
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize appliance names
        '
        Dim applianceList() As String = {"Refrigerator", "Hair dryer", "Fan", "Microwave", "Computer", "Television", "Washer"}
        cmbAppliance.DataSource = New BindingSource(applianceList, Nothing)

        ' Initial validation
        '
        PerformValidation()

        lblTotal.Text = ""
        CheckFields()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Input has already been validated
        '
        Dim dailyCost As Double = hours * rating * cost
        If cmbAppliance.SelectedIndex = 6 Then
            dailyCost += hours * waterprice * gallons
        End If

        ' Add to listing
        '
        Dim item = New ListViewItem(cmbAppliance.SelectedItem.ToString())
        item.SubItems.Add(hours.ToString())
        item.SubItems.Add(FormatCurrency(dailyCost))
        lsvAppliance.Items.Add(item)

        ' Total
        '
        total += dailyCost
        lblTotal.Text = FormatCurrency(total)
    End Sub

    ' Validate all input when any textbox changes
    ' TODO: introduce delay to prevent flashing
    '
    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        'PerformValidation()
    End Sub
    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        'PerformValidation()
    End Sub
    Private Sub txtRating_TextChanged(sender As Object, e As EventArgs) Handles txtRating.TextChanged
        'PerformValidation()
    End Sub
    Private Sub txtWaterprice_TextChanged(sender As Object, e As EventArgs) Handles txtWaterprice.TextChanged
        'PerformValidation()
    End Sub
    Private Sub txtGallons_TextChanged(sender As Object, e As EventArgs) Handles txtGallons.TextChanged
        'PerformValidation()
    End Sub



    Private Sub cmbAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        CheckFields()
        PerformValidation()
    End Sub


    ' txtCost
    '
    Private Sub txtCost_Leave(sender As Object, e As EventArgs) Handles txtCost.Leave
        PerformValidation()
    End Sub

    Private Sub txtCost_Enter(sender As Object, e As EventArgs) Handles txtCost.Enter
        ResetError(pnlCost)
    End Sub

    ' txtRating
    '
    Private Sub txtRating_Leave(sender As Object, e As EventArgs) Handles txtRating.Leave
        PerformValidation()
    End Sub

    Private Sub txtCost_Rating(sender As Object, e As EventArgs) Handles txtRating.Enter
        ResetError(pnlRating)
    End Sub

    ' txtHours
    '
    Private Sub txtHours_Leave(sender As Object, e As EventArgs) Handles txtHours.Leave
        PerformValidation()
    End Sub

    Private Sub txtCost_Hours(sender As Object, e As EventArgs) Handles txtHours.Enter
        ResetError(pnlRating)
    End Sub






End Class
