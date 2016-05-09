Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize appliance names and min max values

        Dim applianceList As New Dictionary(Of Double, String)()

        applianceList.Add(0.11, "Refrigerator")

        cmbAppliance.DataSource = New BindingSource(applianceList, Nothing)
        cmbAppliance.DisplayMember = "Value"
        cmbAppliance.ValueMember = "Key"









        'txtCost.Text = "Test1"

        'cmbAppliance.

        'Refrigerator
        'Hair Dryer
        'Fan
        'Microwave
        'Computer
        'Television



    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Validate cost value


        ' Calculate daily cost

        ' MessageBox.Show()
        ' TODO: test to make sure key and valus work

    End Sub
End Class
