<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TaxCheckBox = New System.Windows.Forms.CheckBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ItemAmountLabel = New System.Windows.Forms.Label()
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FontButton = New System.Windows.Forms.Button()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(12, 12)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "Cappuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(12, 35)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Espresso"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(12, 58)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "Latte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(12, 81)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.IcedCappuccinoRadioButton.TabIndex = 3
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Cappuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(12, 104)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.IcedLatteRadioButton.TabIndex = 4
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(12, 134)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.QuantityLabel.TabIndex = 5
        Me.QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(67, 131)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 6
        '
        'TaxCheckBox
        '
        Me.TaxCheckBox.AutoSize = True
        Me.TaxCheckBox.Location = New System.Drawing.Point(15, 157)
        Me.TaxCheckBox.Name = "TaxCheckBox"
        Me.TaxCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.TaxCheckBox.TabIndex = 7
        Me.TaxCheckBox.Text = "Calculate Tax"
        Me.TaxCheckBox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(15, 180)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 8
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(96, 180)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ItemAmountLabel
        '
        Me.ItemAmountLabel.AutoSize = True
        Me.ItemAmountLabel.Location = New System.Drawing.Point(12, 215)
        Me.ItemAmountLabel.Name = "ItemAmountLabel"
        Me.ItemAmountLabel.Size = New System.Drawing.Size(68, 13)
        Me.ItemAmountLabel.TabIndex = 10
        Me.ItemAmountLabel.Text = "Item Amount:"
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(86, 212)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.ReadOnly = True
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ItemAmountTextBox.TabIndex = 11
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Location = New System.Drawing.Point(12, 241)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(56, 13)
        Me.SubTotalLabel.TabIndex = 12
        Me.SubTotalLabel.Text = "Sub Total:"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(86, 238)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubTotalTextBox.TabIndex = 13
        '
        'TaxLabel
        '
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.Location = New System.Drawing.Point(12, 267)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(28, 13)
        Me.TaxLabel.TabIndex = 14
        Me.TaxLabel.Text = "Tax:"
        '
        'TaxTextBox
        '
        Me.TaxTextBox.Location = New System.Drawing.Point(86, 264)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TaxTextBox.TabIndex = 15
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(12, 293)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(34, 13)
        Me.TotalLabel.TabIndex = 16
        Me.TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(86, 290)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 17
        '
        'NewOrderButton
        '
        Me.NewOrderButton.Location = New System.Drawing.Point(15, 319)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.NewOrderButton.TabIndex = 18
        Me.NewOrderButton.Text = "New Order"
        Me.NewOrderButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(96, 319)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 19
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(177, 319)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FontButton
        '
        Me.FontButton.Location = New System.Drawing.Point(15, 348)
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(75, 23)
        Me.FontButton.TabIndex = 21
        Me.FontButton.Text = "Font"
        Me.FontButton.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(96, 348)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(75, 23)
        Me.ColorButton.TabIndex = 22
        Me.ColorButton.Text = "Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 453)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.FontButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.NewOrderButton)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.TaxTextBox)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.ItemAmountTextBox)
        Me.Controls.Add(Me.ItemAmountLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TaxCheckBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.IcedLatteRadioButton)
        Me.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.Controls.Add(Me.LatteRadioButton)
        Me.Controls.Add(Me.EspressoRadioButton)
        Me.Controls.Add(Me.CappuccinoRadioButton)
        Me.Name = "Form1"
        Me.Text = "R 'n R Billing_Alexander Raposo"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents CappuccinoRadioButton As RadioButton
    Friend WithEvents EspressoRadioButton As RadioButton
    Friend WithEvents LatteRadioButton As RadioButton
    Friend WithEvents IcedCappuccinoRadioButton As RadioButton
    Friend WithEvents IcedLatteRadioButton As RadioButton
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TaxCheckBox As CheckBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ItemAmountLabel As Label
    Friend WithEvents ItemAmountTextBox As TextBox
    Friend WithEvents SubTotalLabel As Label
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents TaxLabel As Label
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents NewOrderButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FontButton As Button
    Friend WithEvents ColorButton As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
