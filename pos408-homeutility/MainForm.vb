Imports System.IO

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


    ' File names
    '
    Private Const ExportFileName = "export.txt"
    Dim exportFile As StreamWriter

    Private Const RatingsFileName = "ratings.txt"
    Dim ratingsFile As StreamReader
    Dim defaultRatings() As Double = {}



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
            If Not control.Name = Me.ActiveControl.Name Then
                DisplayError(control.Name.Substring(3), "Must be a number")
            End If
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
            If Not control.Name = Me.ActiveControl.Name Then
                DisplayError(control.Name.Substring(3), "Must be a value between " + min.ToString() + " and " + max.ToString())
            End If
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


    Private Sub CheckFields()
        If cmbAppliance.SelectedIndex = 6 Then
            pnlWater.Visible = True
        Else
            pnlWater.Visible = False
        End If

        ' Default ratings
        '
        If defaultRatings.Length > 0 Then
            txtRating.Text = defaultRatings(cmbAppliance.SelectedIndex).ToString()
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

        ' Default ratings
        '
        Dim ratingsList As New List(Of Double)
        ratingsFile = File.OpenText(RatingsFileName)
        Do Until ratingsFile.EndOfStream
            ratingsList.Add(Double.Parse(ratingsFile.ReadLine()))
        Loop
        ratingsFile.Close()

        defaultRatings = ratingsList.ToArray()

        ' Initial validation
        '
        PerformValidation()

        lblTotal.Text = ""
        CheckFields()
        ResetError()
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


    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exportString As String = "Appliance" + vbTab + "Hours per day" + vbTab + "Daily Cost" + vbNewLine + _
                                     "=========" + vbTab + "=============" + vbTab + "=========="

        For Each item As ListViewItem In lsvAppliance.Items
            exportString += vbNewLine + item.SubItems(0).Text + If(item.SubItems(0).Text.Length < 8, vbTab + vbTab, vbTab) + item.SubItems(1).Text + vbTab + vbTab + item.SubItems(2).Text
        Next

        exportFile = New StreamWriter(ExportFileName, False)
        exportFile.WriteLine(exportString)
        exportFile.Close()

        lblSaved.Visible = True
        'tmrSaved.Start()
        tmrSaved.Enabled = True

    End Sub


    ' Validate all input when any textbox changes as far as the calculate button is concerned, but only display error for input out of focus
    ' TODO: introduce delay to prevent flashing
    '
    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged, txtCost.Leave, txtCost.Enter
        PerformValidation()
    End Sub
    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged, txtHours.Leave, txtHours.Enter
        PerformValidation()
    End Sub
    Private Sub txtRating_TextChanged(sender As Object, e As EventArgs) Handles txtRating.TextChanged, txtRating.Leave, txtRating.Enter
        PerformValidation()
    End Sub
    Private Sub txtWaterprice_TextChanged(sender As Object, e As EventArgs) Handles txtWaterprice.TextChanged, txtWaterprice.Leave, txtWaterprice.Enter
        PerformValidation()
    End Sub
    Private Sub txtGallons_TextChanged(sender As Object, e As EventArgs) Handles txtGallons.TextChanged, txtGallons.Leave, txtGallons.Enter
        PerformValidation()
    End Sub

    Private Sub cmbAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        CheckFields()
        PerformValidation()
    End Sub

    Private Sub tmrSaved_Tick(sender As Object, e As EventArgs) Handles tmrSaved.Tick
        lblSaved.Visible = False
        tmrSaved.Enabled = False
    End Sub
End Class
