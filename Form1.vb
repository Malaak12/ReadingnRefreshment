Imports System.Windows.Forms

Public Class Form1

    Private SubtotalDecimal, TotalDecimal, GrandTotalDecimal As Decimal
    Private CustomerCountInteger As Integer

    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_Decimal As Decimal = 2D
    Const ESPRESSO_PRICE_Decimal As Decimal = 2.25D
    Const LATTE_PRICE_Decimal As Decimal = 1.75D
    Const ICED_PRICE_Decimal As Decimal = 2.5D

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Calculate and display the current amounts and add to totals.
        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuantityInteger As Integer

        ' Find the price.
        If CappuccinoRadioButton.Checked Then
            PriceDecimal = CAPPUCCINO_PRICE_Decimal
        ElseIf EspressoRadioButton.Checked Then
            PriceDecimal = ESPRESSO_PRICE_Decimal
        ElseIf LatteRadioButton.Checked Then
            PriceDecimal = LATTE_PRICE_Decimal
        ElseIf IcedCappuccinoRadioButton.Checked OrElse IcedLatteRadioButton.Checked Then
            PriceDecimal = ICED_PRICE_Decimal
        End If

        ' Calculate the extended price and add to order total.
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            ItemAmountDecimal = PriceDecimal * QuantityInteger
            SubtotalDecimal += ItemAmountDecimal
            If TaxCheckBox.Checked Then
                TaxDecimal = CalculateTax(SubtotalDecimal)
            Else
                TaxDecimal = 0
            End If
            TotalDecimal = SubtotalDecimal + TaxDecimal
            ItemAmountTextBox.Text = ItemAmountDecimal.ToString("C")
            SubTotalTextBox.Text = SubtotalDecimal.ToString("N")
            TaxTextBox.Text = TaxDecimal.ToString("N")
            TotalTextBox.Text = TotalDecimal.ToString("C")
            ' Allow change for new order only.
            TaxCheckBox.Enabled = False
            ' Allow Clear after an order is begun.
            ClearButton.Enabled = True
            NewOrderButton.Enabled = True
        Catch ex As FormatException
            MessageBox.Show("Quantity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            QuantityTextBox.Focus()
            QuantityTextBox.SelectAll()
        End Try
    End Sub

    Private Function CalculateTax(subtotal As Decimal) As Decimal
        Return subtotal * TAX_RATE_Decimal
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CappuccinoRadioButton.Checked = True
        ItemAmountTextBox.Clear()
        QuantityTextBox.Clear()
        QuantityTextBox.Focus()
    End Sub

    Private Sub NewOrderButton_Click(sender As Object, e As EventArgs) Handles NewOrderButton.Click
        Dim response As DialogResult
        Dim message As String

        message = "Clear the current order figures?"
        response = MessageBox.Show(message, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If response = DialogResult.Yes Then
            ClearButton_Click(sender, e)
            SubTotalTextBox.Text = ""
            TaxTextBox.Text = ""
            TotalTextBox.Text = ""

            If SubtotalDecimal <> 0 Then
                GrandTotalDecimal += TotalDecimal
                CustomerCountInteger += 1
                SubtotalDecimal = 0
                TotalDecimal = 0
            End If

            TaxCheckBox.Enabled = True
            TaxCheckBox.Checked = False
            ClearButton.Enabled = False
            NewOrderButton.Enabled = False
        End If
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim AverageDecimal As Decimal
        Dim MessageString As String

        If TotalDecimal <> 0 Then
            NewOrderButton_Click(sender, e)
        End If

        If CustomerCountInteger > 0 Then
            AverageDecimal = GrandTotalDecimal / CustomerCountInteger
            MessageString = "Number of Orders:  " & CustomerCountInteger.ToString() & Environment.NewLine & Environment.NewLine &
                            "Total Sales:  " & GrandTotalDecimal.ToString("C") & Environment.NewLine & Environment.NewLine &
                            "Average Sale:  " & AverageDecimal.ToString("C")
            MessageBox.Show(MessageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageString = "No sales data to summarize."
            MessageBox.Show(MessageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FontButton_Click(sender As Object, e As EventArgs) Handles FontButton.Click
        With FontDialog1
            .Font = SubTotalTextBox.Font
            .ShowDialog()
            SubTotalTextBox.Font = .Font
            TaxTextBox.Font = .Font
            TotalTextBox.Font = .Font
        End With
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            TaxTextBox.ForeColor = .Color
            TotalTextBox.ForeColor = .Color
        End With
    End Sub

End Class