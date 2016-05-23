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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAppliance = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDaily = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.tmrValidation = New System.Windows.Forms.Timer(Me.components)
        Me.lblHours = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlHours = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlCost = New System.Windows.Forms.Panel()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlRating = New System.Windows.Forms.Panel()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtWaterprice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlWaterprice = New System.Windows.Forms.Panel()
        Me.lblWaterprice = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlGallons = New System.Windows.Forms.Panel()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pnlWater = New System.Windows.Forms.Panel()
        Me.pnlButton = New System.Windows.Forms.Panel()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.tlpListing = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.pnlHours.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.pnlCost.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.pnlRating.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlWaterprice.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.pnlGallons.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWater.SuspendLayout()
        Me.pnlButton.SuspendLayout()
        Me.pnlList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enhanced Home Utility Auditing Program"
        '
        'cmbAppliance
        '
        Me.cmbAppliance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAppliance.FormattingEnabled = True
        Me.cmbAppliance.Location = New System.Drawing.Point(142, 0)
        Me.cmbAppliance.Name = "cmbAppliance"
        Me.cmbAppliance.Size = New System.Drawing.Size(290, 24)
        Me.cmbAppliance.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(3, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(193, 29)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Appliance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Daily Cost:"
        '
        'lblDaily
        '
        Me.lblDaily.AutoSize = True
        Me.lblDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaily.Location = New System.Drawing.Point(299, 9)
        Me.lblDaily.Name = "lblDaily"
        Me.lblDaily.Size = New System.Drawing.Size(36, 16)
        Me.lblDaily.TabIndex = 0
        Me.lblDaily.Text = "$$$$"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cmbAppliance)
        Me.Panel3.Location = New System.Drawing.Point(12, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 30)
        Me.Panel3.TabIndex = 1
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.BackColor = System.Drawing.Color.Transparent
        Me.lblDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.ForeColor = System.Drawing.Color.Black
        Me.lblDebug.Location = New System.Drawing.Point(3, 3)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(36, 16)
        Me.lblDebug.TabIndex = 17
        Me.lblDebug.Text = "????"
        '
        'tmrValidation
        '
        Me.tmrValidation.Interval = 250
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.BackColor = System.Drawing.Color.LightCoral
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.Black
        Me.lblHours.Location = New System.Drawing.Point(300, 7)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(20, 16)
        Me.lblHours.TabIndex = 18
        Me.lblHours.Text = "!!!!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(561, 30)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtHours)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.pnlHours)
        Me.Panel7.Location = New System.Drawing.Point(12, 144)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(700, 30)
        Me.Panel7.TabIndex = 3
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(142, 4)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(290, 22)
        Me.txtHours.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Daily Use (hours)"
        '
        'pnlHours
        '
        Me.pnlHours.Controls.Add(Me.lblHours)
        Me.pnlHours.Controls.Add(Me.PictureBox1)
        Me.pnlHours.Location = New System.Drawing.Point(138, 0)
        Me.pnlHours.Name = "pnlHours"
        Me.pnlHours.Size = New System.Drawing.Size(561, 30)
        Me.pnlHours.TabIndex = 15
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtCost)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.pnlCost)
        Me.Panel8.Location = New System.Drawing.Point(12, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(700, 30)
        Me.Panel8.TabIndex = 0
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(142, 4)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(290, 22)
        Me.txtCost.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Price per kWh ($)"
        '
        'pnlCost
        '
        Me.pnlCost.Controls.Add(Me.lblCost)
        Me.pnlCost.Controls.Add(Me.PictureBox2)
        Me.pnlCost.Location = New System.Drawing.Point(138, 0)
        Me.pnlCost.Name = "pnlCost"
        Me.pnlCost.Size = New System.Drawing.Size(561, 30)
        Me.pnlCost.TabIndex = 15
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.LightCoral
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Black
        Me.lblCost.Location = New System.Drawing.Point(300, 7)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(20, 16)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "!!!!"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(561, 30)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtRating)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.pnlRating)
        Me.Panel5.Location = New System.Drawing.Point(12, 114)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(700, 30)
        Me.Panel5.TabIndex = 2
        '
        'txtRating
        '
        Me.txtRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRating.Location = New System.Drawing.Point(142, 4)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(290, 22)
        Me.txtRating.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Power Rating (kWh)"
        '
        'pnlRating
        '
        Me.pnlRating.Controls.Add(Me.lblRating)
        Me.pnlRating.Controls.Add(Me.PictureBox3)
        Me.pnlRating.Location = New System.Drawing.Point(138, 0)
        Me.pnlRating.Name = "pnlRating"
        Me.pnlRating.Size = New System.Drawing.Size(561, 30)
        Me.pnlRating.TabIndex = 15
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.BackColor = System.Drawing.Color.LightCoral
        Me.lblRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.ForeColor = System.Drawing.Color.Black
        Me.lblRating.Location = New System.Drawing.Point(300, 7)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(20, 16)
        Me.lblRating.TabIndex = 0
        Me.lblRating.Text = "!!!!"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(561, 30)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtWaterprice)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.pnlWaterprice)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(700, 30)
        Me.Panel4.TabIndex = 1
        '
        'txtWaterprice
        '
        Me.txtWaterprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterprice.Location = New System.Drawing.Point(142, 4)
        Me.txtWaterprice.Name = "txtWaterprice"
        Me.txtWaterprice.Size = New System.Drawing.Size(290, 22)
        Me.txtWaterprice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Price per gallon ($)"
        '
        'pnlWaterprice
        '
        Me.pnlWaterprice.Controls.Add(Me.lblWaterprice)
        Me.pnlWaterprice.Controls.Add(Me.PictureBox4)
        Me.pnlWaterprice.Location = New System.Drawing.Point(138, 0)
        Me.pnlWaterprice.Name = "pnlWaterprice"
        Me.pnlWaterprice.Size = New System.Drawing.Size(561, 30)
        Me.pnlWaterprice.TabIndex = 15
        '
        'lblWaterprice
        '
        Me.lblWaterprice.AutoSize = True
        Me.lblWaterprice.BackColor = System.Drawing.Color.LightCoral
        Me.lblWaterprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterprice.ForeColor = System.Drawing.Color.Black
        Me.lblWaterprice.Location = New System.Drawing.Point(300, 7)
        Me.lblWaterprice.Name = "lblWaterprice"
        Me.lblWaterprice.Size = New System.Drawing.Size(20, 16)
        Me.lblWaterprice.TabIndex = 18
        Me.lblWaterprice.Text = "!!!!"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(561, 30)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtGallons)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.pnlGallons)
        Me.Panel9.Location = New System.Drawing.Point(0, 30)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(700, 30)
        Me.Panel9.TabIndex = 1
        '
        'txtGallons
        '
        Me.txtGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(142, 4)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(290, 22)
        Me.txtGallons.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Water per hour (gal)"
        '
        'pnlGallons
        '
        Me.pnlGallons.Controls.Add(Me.lblGallons)
        Me.pnlGallons.Controls.Add(Me.PictureBox5)
        Me.pnlGallons.Location = New System.Drawing.Point(138, 0)
        Me.pnlGallons.Name = "pnlGallons"
        Me.pnlGallons.Size = New System.Drawing.Size(561, 30)
        Me.pnlGallons.TabIndex = 15
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.BackColor = System.Drawing.Color.LightCoral
        Me.lblGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.ForeColor = System.Drawing.Color.Black
        Me.lblGallons.Location = New System.Drawing.Point(300, 7)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(20, 16)
        Me.lblGallons.TabIndex = 18
        Me.lblGallons.Text = "!!!!"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(561, 30)
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'pnlWater
        '
        Me.pnlWater.Controls.Add(Me.Panel4)
        Me.pnlWater.Controls.Add(Me.Panel9)
        Me.pnlWater.Location = New System.Drawing.Point(12, 174)
        Me.pnlWater.Name = "pnlWater"
        Me.pnlWater.Size = New System.Drawing.Size(700, 60)
        Me.pnlWater.TabIndex = 22
        '
        'pnlButton
        '
        Me.pnlButton.BackColor = System.Drawing.SystemColors.Control
        Me.pnlButton.Controls.Add(Me.lblDaily)
        Me.pnlButton.Controls.Add(Me.Label5)
        Me.pnlButton.Controls.Add(Me.btnCalculate)
        Me.pnlButton.Location = New System.Drawing.Point(12, 234)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(700, 35)
        Me.pnlButton.TabIndex = 23
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.SystemColors.Control
        Me.pnlList.Controls.Add(Me.ListBox1)
        Me.pnlList.Controls.Add(Me.tlpListing)
        Me.pnlList.Controls.Add(Me.lblDebug)
        Me.pnlList.Location = New System.Drawing.Point(12, 269)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(700, 285)
        Me.pnlList.TabIndex = 23
        '
        'tlpListing
        '
        Me.tlpListing.ColumnCount = 3
        Me.tlpListing.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListing.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpListing.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.tlpListing.Location = New System.Drawing.Point(24, 22)
        Me.tlpListing.Name = "tlpListing"
        Me.tlpListing.RowCount = 1
        Me.tlpListing.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListing.Size = New System.Drawing.Size(494, 244)
        Me.tlpListing.TabIndex = 18
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(547, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(109, 147)
        Me.ListBox1.TabIndex = 19
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 566)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.pnlButton)
        Me.Controls.Add(Me.pnlWater)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnlHours.ResumeLayout(False)
        Me.pnlHours.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.pnlCost.ResumeLayout(False)
        Me.pnlCost.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlRating.ResumeLayout(False)
        Me.pnlRating.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlWaterprice.ResumeLayout(False)
        Me.pnlWaterprice.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlGallons.ResumeLayout(False)
        Me.pnlGallons.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWater.ResumeLayout(False)
        Me.pnlButton.ResumeLayout(False)
        Me.pnlButton.PerformLayout()
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDaily As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents tmrValidation As System.Windows.Forms.Timer
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlHours As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlCost As System.Windows.Forms.Panel
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlRating As System.Windows.Forms.Panel
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtWaterprice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlWaterprice As System.Windows.Forms.Panel
    Friend WithEvents lblWaterprice As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlGallons As System.Windows.Forms.Panel
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlWater As System.Windows.Forms.Panel
    Friend WithEvents pnlButton As System.Windows.Forms.Panel
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents tlpListing As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
