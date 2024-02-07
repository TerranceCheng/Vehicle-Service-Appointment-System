<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.customerNameLabel = New System.Windows.Forms.Label()
        Me.customerNameTextBox = New System.Windows.Forms.TextBox()
        Me.carRegistrationTextBox = New System.Windows.Forms.TextBox()
        Me.carRegistrationLabel = New System.Windows.Forms.Label()
        Me.payOnDayCheckBox = New System.Windows.Forms.CheckBox()
        Me.servicesGroupBox = New System.Windows.Forms.GroupBox()
        Me.wheelAlignmentRadioButton = New System.Windows.Forms.RadioButton()
        Me.wheelBalanceRadioButton = New System.Windows.Forms.RadioButton()
        Me.transmissionServiceRadioButton = New System.Windows.Forms.RadioButton()
        Me.tuneUpRadioButton = New System.Windows.Forms.RadioButton()
        Me.serviceRadioButton = New System.Windows.Forms.RadioButton()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.orderDetailsLabel = New System.Windows.Forms.Label()
        Me.orderDetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.lineTextBox = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.servicesGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'customerNameLabel
        '
        Me.customerNameLabel.AutoSize = True
        Me.customerNameLabel.Location = New System.Drawing.Point(17, 123)
        Me.customerNameLabel.Name = "customerNameLabel"
        Me.customerNameLabel.Size = New System.Drawing.Size(116, 20)
        Me.customerNameLabel.TabIndex = 0
        Me.customerNameLabel.Text = "Customer name:"
        '
        'customerNameTextBox
        '
        Me.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.customerNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.customerNameTextBox.Location = New System.Drawing.Point(147, 120)
        Me.customerNameTextBox.Name = "customerNameTextBox"
        Me.customerNameTextBox.Size = New System.Drawing.Size(156, 27)
        Me.customerNameTextBox.TabIndex = 1
        '
        'carRegistrationTextBox
        '
        Me.carRegistrationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.carRegistrationTextBox.Location = New System.Drawing.Point(147, 153)
        Me.carRegistrationTextBox.Name = "carRegistrationTextBox"
        Me.carRegistrationTextBox.Size = New System.Drawing.Size(103, 27)
        Me.carRegistrationTextBox.TabIndex = 3
        '
        'carRegistrationLabel
        '
        Me.carRegistrationLabel.AutoSize = True
        Me.carRegistrationLabel.Location = New System.Drawing.Point(17, 156)
        Me.carRegistrationLabel.Name = "carRegistrationLabel"
        Me.carRegistrationLabel.Size = New System.Drawing.Size(114, 20)
        Me.carRegistrationLabel.TabIndex = 2
        Me.carRegistrationLabel.Text = "Car registration:"
        '
        'payOnDayCheckBox
        '
        Me.payOnDayCheckBox.AutoSize = True
        Me.payOnDayCheckBox.Location = New System.Drawing.Point(147, 216)
        Me.payOnDayCheckBox.Name = "payOnDayCheckBox"
        Me.payOnDayCheckBox.Size = New System.Drawing.Size(162, 24)
        Me.payOnDayCheckBox.TabIndex = 4
        Me.payOnDayCheckBox.Text = "Pay on day discount"
        Me.payOnDayCheckBox.UseVisualStyleBackColor = True
        '
        'servicesGroupBox
        '
        Me.servicesGroupBox.Controls.Add(Me.wheelAlignmentRadioButton)
        Me.servicesGroupBox.Controls.Add(Me.wheelBalanceRadioButton)
        Me.servicesGroupBox.Controls.Add(Me.transmissionServiceRadioButton)
        Me.servicesGroupBox.Controls.Add(Me.tuneUpRadioButton)
        Me.servicesGroupBox.Controls.Add(Me.serviceRadioButton)
        Me.servicesGroupBox.ForeColor = System.Drawing.Color.Blue
        Me.servicesGroupBox.Location = New System.Drawing.Point(320, 120)
        Me.servicesGroupBox.Name = "servicesGroupBox"
        Me.servicesGroupBox.Size = New System.Drawing.Size(205, 182)
        Me.servicesGroupBox.TabIndex = 5
        Me.servicesGroupBox.TabStop = False
        Me.servicesGroupBox.Text = "Service performed"
        '
        'wheelAlignmentRadioButton
        '
        Me.wheelAlignmentRadioButton.AutoSize = True
        Me.wheelAlignmentRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.wheelAlignmentRadioButton.Location = New System.Drawing.Point(20, 146)
        Me.wheelAlignmentRadioButton.Name = "wheelAlignmentRadioButton"
        Me.wheelAlignmentRadioButton.Size = New System.Drawing.Size(143, 24)
        Me.wheelAlignmentRadioButton.TabIndex = 4
        Me.wheelAlignmentRadioButton.TabStop = True
        Me.wheelAlignmentRadioButton.Text = "Wheel alignment"
        Me.wheelAlignmentRadioButton.UseVisualStyleBackColor = True
        '
        'wheelBalanceRadioButton
        '
        Me.wheelBalanceRadioButton.AutoSize = True
        Me.wheelBalanceRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.wheelBalanceRadioButton.Location = New System.Drawing.Point(20, 116)
        Me.wheelBalanceRadioButton.Name = "wheelBalanceRadioButton"
        Me.wheelBalanceRadioButton.Size = New System.Drawing.Size(128, 24)
        Me.wheelBalanceRadioButton.TabIndex = 3
        Me.wheelBalanceRadioButton.TabStop = True
        Me.wheelBalanceRadioButton.Text = "Wheel balance"
        Me.wheelBalanceRadioButton.UseVisualStyleBackColor = True
        '
        'transmissionServiceRadioButton
        '
        Me.transmissionServiceRadioButton.AutoSize = True
        Me.transmissionServiceRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.transmissionServiceRadioButton.Location = New System.Drawing.Point(20, 86)
        Me.transmissionServiceRadioButton.Name = "transmissionServiceRadioButton"
        Me.transmissionServiceRadioButton.Size = New System.Drawing.Size(163, 24)
        Me.transmissionServiceRadioButton.TabIndex = 2
        Me.transmissionServiceRadioButton.TabStop = True
        Me.transmissionServiceRadioButton.Text = "Transmission service"
        Me.transmissionServiceRadioButton.UseVisualStyleBackColor = True
        '
        'tuneUpRadioButton
        '
        Me.tuneUpRadioButton.AutoSize = True
        Me.tuneUpRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tuneUpRadioButton.Location = New System.Drawing.Point(20, 56)
        Me.tuneUpRadioButton.Name = "tuneUpRadioButton"
        Me.tuneUpRadioButton.Size = New System.Drawing.Size(83, 24)
        Me.tuneUpRadioButton.TabIndex = 1
        Me.tuneUpRadioButton.TabStop = True
        Me.tuneUpRadioButton.Text = "Tune up"
        Me.tuneUpRadioButton.UseVisualStyleBackColor = True
        '
        'serviceRadioButton
        '
        Me.serviceRadioButton.AutoSize = True
        Me.serviceRadioButton.Checked = True
        Me.serviceRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.serviceRadioButton.Location = New System.Drawing.Point(20, 26)
        Me.serviceRadioButton.Name = "serviceRadioButton"
        Me.serviceRadioButton.Size = New System.Drawing.Size(77, 24)
        Me.serviceRadioButton.TabIndex = 0
        Me.serviceRadioButton.TabStop = True
        Me.serviceRadioButton.Text = "Service"
        Me.serviceRadioButton.UseVisualStyleBackColor = True
        '
        'totalTextBox
        '
        Me.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalTextBox.Location = New System.Drawing.Point(147, 275)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(156, 27)
        Me.totalTextBox.TabIndex = 7
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalLabel.Location = New System.Drawing.Point(83, 278)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(48, 20)
        Me.totalLabel.TabIndex = 6
        Me.totalLabel.Text = "Total:"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(130, 341)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(116, 41)
        Me.submitButton.TabIndex = 8
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Enabled = False
        Me.summaryButton.Location = New System.Drawing.Point(270, 341)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(116, 41)
        Me.summaryButton.TabIndex = 9
        Me.summaryButton.Text = "Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Enabled = False
        Me.clearButton.Location = New System.Drawing.Point(409, 341)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(116, 41)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(409, 398)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(116, 41)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'orderDetailsLabel
        '
        Me.orderDetailsLabel.AutoSize = True
        Me.orderDetailsLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.orderDetailsLabel.ForeColor = System.Drawing.Color.Maroon
        Me.orderDetailsLabel.Location = New System.Drawing.Point(31, 437)
        Me.orderDetailsLabel.Name = "orderDetailsLabel"
        Me.orderDetailsLabel.Size = New System.Drawing.Size(103, 20)
        Me.orderDetailsLabel.TabIndex = 12
        Me.orderDetailsLabel.Text = "Order details:"
        '
        'orderDetailsRichTextBox
        '
        Me.orderDetailsRichTextBox.Location = New System.Drawing.Point(31, 460)
        Me.orderDetailsRichTextBox.Name = "orderDetailsRichTextBox"
        Me.orderDetailsRichTextBox.ReadOnly = True
        Me.orderDetailsRichTextBox.Size = New System.Drawing.Size(494, 132)
        Me.orderDetailsRichTextBox.TabIndex = 13
        Me.orderDetailsRichTextBox.Text = ""
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(157, 39)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(241, 38)
        Me.titleLabel.TabIndex = 14
        Me.titleLabel.Text = "Ted’s Auto Service"
        '
        'lineTextBox
        '
        Me.lineTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.lineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lineTextBox.Location = New System.Drawing.Point(-2, 92)
        Me.lineTextBox.Name = "lineTextBox"
        Me.lineTextBox.Size = New System.Drawing.Size(591, 1)
        Me.lineTextBox.TabIndex = 16
        Me.lineTextBox.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Enabled = False
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 618)
        Me.Controls.Add(Me.lineTextBox)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.orderDetailsRichTextBox)
        Me.Controls.Add(Me.orderDetailsLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.servicesGroupBox)
        Me.Controls.Add(Me.payOnDayCheckBox)
        Me.Controls.Add(Me.carRegistrationTextBox)
        Me.Controls.Add(Me.carRegistrationLabel)
        Me.Controls.Add(Me.customerNameTextBox)
        Me.Controls.Add(Me.customerNameLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ted’s Auto Service"
        Me.servicesGroupBox.ResumeLayout(False)
        Me.servicesGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerNameLabel As Label
    Friend WithEvents customerNameTextBox As TextBox
    Friend WithEvents carRegistrationTextBox As TextBox
    Friend WithEvents carRegistrationLabel As Label
    Friend WithEvents payOnDayCheckBox As CheckBox
    Friend WithEvents servicesGroupBox As GroupBox
    Friend WithEvents wheelAlignmentRadioButton As RadioButton
    Friend WithEvents wheelBalanceRadioButton As RadioButton
    Friend WithEvents transmissionServiceRadioButton As RadioButton
    Friend WithEvents tuneUpRadioButton As RadioButton
    Friend WithEvents serviceRadioButton As RadioButton
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents totalLabel As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents summaryButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents orderDetailsLabel As Label
    Friend WithEvents orderDetailsRichTextBox As RichTextBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents lineTextBox As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
