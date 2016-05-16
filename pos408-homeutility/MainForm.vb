Public Class MainForm

    ' TODO: title

    Private Function ValidateIsNumber(control As Control, ByRef value As Double) As Boolean
        If Double.TryParse(control.Text, value) Then
            Return True
        Else
            LogError(control, "ERROR: " + control.Name + " value must be a number." + vbNewLine)
            Return False
        End If
    End Function

    ' TODO
    '
    Private Sub ValidateRange()

        ' 1.5 -> 1.2-1.8 @ 20%
        ' 0.09


    End Sub

    Private Sub LogError(control As Control, text As String)
        control.ForeColor = Color.Red
        control.BackColor = Color.Black
        lblError.Text += text
        tmrError.Enabled = True
    End Sub

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

        ' Validate cost value
        ' TODO: limit rating range, hours per day, and cost based on reasonable amounts

        Dim rating As Double = 0
        Dim hours As Double = 0
        Dim cost As Double = 0

        If ValidateIsNumber(txtHours, hours) And ValidateIsNumber(txtRating, rating) And ValidateIsNumber(txtCost, cost) Then
            lblDaily.Text = FormatCurrency(rating * hours * (cost / 100))
        End If
    End Sub

    Private Sub cmbAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        txtRating.Text = cmbAppliance.SelectedValue.ToString()
    End Sub

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
