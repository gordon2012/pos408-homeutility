Public Class MainForm

    ' TODO: title



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

        Dim success As Boolean = True

        Dim rating As Double = 0
        Dim hours As Double = 0
        Dim cost As Double = 0

        ' TODO: fix later trues overwrite previous falses
        '
        success = Double.TryParse(txtRating.Text, rating)
        success = Double.TryParse(txtHours.Text, hours)
        success = Double.TryParse(txtCost.Text, cost)

        If success Then
            ' Calculate daily cost
            txtDaily.Text = FormatCurrency(rating * hours * (cost / 100))
        Else
            txtRating.Text = cmbAppliance.SelectedValue.ToString()
            txtHours.Text = ""
            txtCost.Text = ""
            txtDaily.Text = ""
        End If
    End Sub

    Private Sub cmbAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        txtRating.Text = cmbAppliance.SelectedValue.ToString()
    End Sub
End Class
