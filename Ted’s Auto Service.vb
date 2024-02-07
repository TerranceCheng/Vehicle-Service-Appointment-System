Public Class Form1
    Const SERVICE_FEE_DECIMAL As Decimal = 125D
    Const TUNE_UP_FEE_DECIMAL As Decimal = 75D
    Const TRANSMISSION_FEE_DECIMAL As Decimal = 80D
    Const W_BALANCE_FEE_DECIMAL As Decimal = 40D
    Const W_ALIGNMENT_FEE_DECIMAL As Decimal = 65D

    Private totalDecimal, discountDecimal, grandTotalDecimal As Decimal
    Private customerCountInteger As Integer

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Exit the application
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        exitButton_Click(sender, e)
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        Dim ResponseDialogResult As DialogResult

        'Confirm clear of the current order
        ResponseDialogResult = MessageBox.Show("Clear the current service figures?", "Clear service form",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)

        If ResponseDialogResult = System.Windows.Forms.DialogResult.Yes Then
            'Clear all the contents if user said yes
            customerNameTextBox.Text = ""
            carRegistrationTextBox.Text = ""
            totalTextBox.Text = ""
            orderDetailsRichTextBox.Text = ""
            serviceRadioButton.Checked = True
            payOnDayCheckBox.Checked = False
            clearButton.Enabled = False
            ClearToolStripMenuItem.Enabled = False

            'Add to the totals only if not a new order
            If totalDecimal <> 0 Then
                grandTotalDecimal += totalDecimal
                customerCountInteger += 1
                'Reset totals for the next customer
                totalDecimal = 0
            End If
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        clearButton_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim messageString, programName, programmerName, programDescription As String
        'Declare names and description to each variables
        programName = "Ted’s Auto Service"
        programmerName = "Cheng Yong Tat"
        programDescription = "This program will calculate the total 
                                amount of service for each customer, while 
                                able to clear order and display order summary."

        'Store program information into a string
        messageString = "Program Name: " & programName & ControlChars.NewLine &
                        "Programmer Name: " & programmerName & ControlChars.NewLine &
                        "Program Description: " & programDescription

        'Display program information
        MessageBox.Show(messageString, "About this program",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        'Display summary
        clearButton_Click(sender, e)

        Dim messageString As String
        Dim grandTotalString As String = grandTotalDecimal.ToString("C")

        messageString = "Total customers: " & customerCountInteger & ControlChars.NewLine &
            "Total earnings: " & grandTotalString

        MessageBox.Show(messageString, "Earnings Summary",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click

        Dim priceDecimal As Decimal
        Dim serviceNameString, orderDetailsString As String

        'Validate customerNameTextBox, if there is no input,
        'a message box will show and prompt user to enter customer name
        'then, exit current Sub
        If customerNameTextBox.Text = "" Then
            MessageBox.Show("Please enter customer name.", "Empty customer name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Validate carRegistrationTextBox, if there is no input,
        'a message box will show and prompt user to enter car registration
        'then, exit current Sub
        If carRegistrationTextBox.Text = "" Then
            MessageBox.Show("Please enter car registration.", "Empty car registration",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Assign the fees constant value to priceDecimal according to user selected radio buttons
        'Assign the radio button name to serviceNameString
        If serviceRadioButton.Checked Then
            priceDecimal = SERVICE_FEE_DECIMAL
            serviceNameString = serviceRadioButton.Text
        ElseIf tuneUpRadioButton.Checked Then
            priceDecimal = TUNE_UP_FEE_DECIMAL
            serviceNameString = tuneUpRadioButton.Text
        ElseIf transmissionServiceRadioButton.Checked Then
            priceDecimal = TRANSMISSION_FEE_DECIMAL
            serviceNameString = transmissionServiceRadioButton.Text
        ElseIf wheelBalanceRadioButton.Checked Then
            priceDecimal = W_BALANCE_FEE_DECIMAL
            serviceNameString = wheelBalanceRadioButton.Text
        ElseIf wheelAlignmentRadioButton.Checked Then
            priceDecimal = W_ALIGNMENT_FEE_DECIMAL
            serviceNameString = wheelAlignmentRadioButton.Text
        End If

        'Change the discount value according to checked status of payOnDayCheckBox
        If payOnDayCheckBox.Checked Then
            discountDecimal = 0.1D
        Else
            discountDecimal = 0
        End If

        'Calculate total due amount
        totalDecimal = priceDecimal * (1 - discountDecimal)

        'Assign customer details to current string to display it later
        orderDetailsString = customerNameTextBox.Text & ControlChars.NewLine &
                                carRegistrationTextBox.Text & ControlChars.NewLine &
                                serviceNameString

        'Display total and order details and enable clear and summary button
        totalTextBox.Text = totalDecimal.ToString("C")
        orderDetailsRichTextBox.Text = orderDetailsString
        clearButton.Enabled = True
        ClearToolStripMenuItem.Enabled = True
        summaryButton.Enabled = True
    End Sub
End Class
