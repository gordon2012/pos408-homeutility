<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAppliance = New System.Windows.Forms.ComboBox()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDaily = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home Utility Auditing Program"
        '
        'cmbAppliance
        '
        Me.cmbAppliance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAppliance.FormattingEnabled = True
        Me.cmbAppliance.Location = New System.Drawing.Point(12, 116)
        Me.cmbAppliance.Name = "cmbAppliance"
        Me.cmbAppliance.Size = New System.Drawing.Size(193, 28)
        Me.cmbAppliance.TabIndex = 1
        '
        'txtRating
        '
        Me.txtRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRating.Location = New System.Drawing.Point(235, 116)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(193, 26)
        Me.txtRating.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(235, 259)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(193, 29)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Power Rating (kW)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Appliance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hours Used Per Day"
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(467, 116)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(193, 26)
        Me.txtHours.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Daily Cost"
        '
        'txtDaily
        '
        Me.txtDaily.Enabled = False
        Me.txtDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaily.Location = New System.Drawing.Point(467, 262)
        Me.txtDaily.Name = "txtDaily"
        Me.txtDaily.ReadOnly = True
        Me.txtDaily.Size = New System.Drawing.Size(193, 26)
        Me.txtDaily.TabIndex = 9
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(12, 259)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(193, 26)
        Me.txtCost.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Price (cents)"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 347)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDaily)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(Me.cmbAppliance)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Home Utility Auditing Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDaily As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
