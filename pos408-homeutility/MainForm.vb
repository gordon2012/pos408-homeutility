Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize appliance names and base values from Appliancefigures.xls

        Dim applianceList As New Dictionary(Of String, Double)()

        ' applianceList.Add("Electric Wok", 1.2)
        ' applianceList.Add("Coffee maker", 0.8)
        ' applianceList.Add("Hot plate", 1.2)
        applianceList.Add("Refrigerator", 0.11)
        ' applianceList.Add("Deep freezer", 0.19)
        applianceList.Add("Hair dryer", 1.5)
        applianceList.Add("Television", 0.31)
        ' applianceList.Add("Stereo", 0.15)
        applianceList.Add("Desktop computer", 0.09)
        applianceList.Add("Fan", 0.2)
        ' applianceList.Add("Space heater", 1.5)
        ' applianceList.Add("Washing machine", 0.45)
        ' applianceList.Add("Clothes dryer", 2.7)
        ' applianceList.Add("Water heater ", 0.56)
        ' applianceList.Add("Dehumidifier", 0.76)
        applianceList.Add("Microwave(1000W)", 1.0)
        ' applianceList.Add("Toaster", 0.9)

        cmbAppliance.DataSource = New BindingSource(applianceList, Nothing)
        cmbAppliance.DisplayMember = "Key"
        cmbAppliance.ValueMember = "Value"


        txtRating.Text = cmbAppliance.SelectedValue.ToString()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Validate cost value


        ' Calculate daily cost


    End Sub

    Private Sub cmbAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        txtRating.Text = cmbAppliance.SelectedValue.ToString()

    End Sub
End Class
