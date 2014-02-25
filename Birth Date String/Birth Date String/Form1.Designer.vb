<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dayOfWeekPromptLabel = New System.Windows.Forms.Label()
        Me.monthPromptLabel = New System.Windows.Forms.Label()
        Me.dayOfMonthPromptLabel = New System.Windows.Forms.Label()
        Me.yearPromptLabel = New System.Windows.Forms.Label()
        Me.dayOfWeekTextBox = New System.Windows.Forms.TextBox()
        Me.monthTextBox = New System.Windows.Forms.TextBox()
        Me.dayOfMonthTextBox = New System.Windows.Forms.TextBox()
        Me.yearTextBox = New System.Windows.Forms.TextBox()
        Me.dateOutputLabel = New System.Windows.Forms.Label()
        Me.showDateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dayOfWeekPromptLabel
        '
        Me.dayOfWeekPromptLabel.AutoSize = True
        Me.dayOfWeekPromptLabel.Location = New System.Drawing.Point(60, 30)
        Me.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel"
        Me.dayOfWeekPromptLabel.Size = New System.Drawing.Size(129, 13)
        Me.dayOfWeekPromptLabel.TabIndex = 0
        Me.dayOfWeekPromptLabel.Text = "Enter the day of the week"
        '
        'monthPromptLabel
        '
        Me.monthPromptLabel.AutoSize = True
        Me.monthPromptLabel.Location = New System.Drawing.Point(48, 54)
        Me.monthPromptLabel.Name = "monthPromptLabel"
        Me.monthPromptLabel.Size = New System.Drawing.Size(141, 13)
        Me.monthPromptLabel.TabIndex = 1
        Me.monthPromptLabel.Text = "Enter the name of the month"
        '
        'dayOfMonthPromptLabel
        '
        Me.dayOfMonthPromptLabel.AutoSize = True
        Me.dayOfMonthPromptLabel.Location = New System.Drawing.Point(17, 79)
        Me.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel"
        Me.dayOfMonthPromptLabel.Size = New System.Drawing.Size(172, 13)
        Me.dayOfMonthPromptLabel.TabIndex = 2
        Me.dayOfMonthPromptLabel.Text = "Enter the numeric day of the month"
        '
        'yearPromptLabel
        '
        Me.yearPromptLabel.AutoSize = True
        Me.yearPromptLabel.Location = New System.Drawing.Point(116, 104)
        Me.yearPromptLabel.Name = "yearPromptLabel"
        Me.yearPromptLabel.Size = New System.Drawing.Size(73, 13)
        Me.yearPromptLabel.TabIndex = 3
        Me.yearPromptLabel.Text = "Enter the year"
        '
        'dayOfWeekTextBox
        '
        Me.dayOfWeekTextBox.Location = New System.Drawing.Point(212, 22)
        Me.dayOfWeekTextBox.Name = "dayOfWeekTextBox"
        Me.dayOfWeekTextBox.Size = New System.Drawing.Size(175, 20)
        Me.dayOfWeekTextBox.TabIndex = 4
        '
        'monthTextBox
        '
        Me.monthTextBox.Location = New System.Drawing.Point(212, 46)
        Me.monthTextBox.Name = "monthTextBox"
        Me.monthTextBox.Size = New System.Drawing.Size(175, 20)
        Me.monthTextBox.TabIndex = 5
        '
        'dayOfMonthTextBox
        '
        Me.dayOfMonthTextBox.Location = New System.Drawing.Point(212, 71)
        Me.dayOfMonthTextBox.Name = "dayOfMonthTextBox"
        Me.dayOfMonthTextBox.Size = New System.Drawing.Size(175, 20)
        Me.dayOfMonthTextBox.TabIndex = 6
        '
        'yearTextBox
        '
        Me.yearTextBox.Location = New System.Drawing.Point(212, 96)
        Me.yearTextBox.Name = "yearTextBox"
        Me.yearTextBox.Size = New System.Drawing.Size(175, 20)
        Me.yearTextBox.TabIndex = 7
        '
        'dateOutputLabel
        '
        Me.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dateOutputLabel.Location = New System.Drawing.Point(51, 146)
        Me.dateOutputLabel.Name = "dateOutputLabel"
        Me.dateOutputLabel.Size = New System.Drawing.Size(336, 23)
        Me.dateOutputLabel.TabIndex = 8
        Me.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'showDateButton
        '
        Me.showDateButton.Location = New System.Drawing.Point(63, 198)
        Me.showDateButton.Name = "showDateButton"
        Me.showDateButton.Size = New System.Drawing.Size(75, 23)
        Me.showDateButton.TabIndex = 9
        Me.showDateButton.Text = "&Show Date"
        Me.showDateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(182, 198)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(301, 198)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 262)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.showDateButton)
        Me.Controls.Add(Me.dateOutputLabel)
        Me.Controls.Add(Me.yearTextBox)
        Me.Controls.Add(Me.dayOfMonthTextBox)
        Me.Controls.Add(Me.monthTextBox)
        Me.Controls.Add(Me.dayOfWeekTextBox)
        Me.Controls.Add(Me.yearPromptLabel)
        Me.Controls.Add(Me.dayOfMonthPromptLabel)
        Me.Controls.Add(Me.monthPromptLabel)
        Me.Controls.Add(Me.dayOfWeekPromptLabel)
        Me.Name = "Form1"
        Me.Text = "Birth Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dayOfWeekPromptLabel As System.Windows.Forms.Label
    Friend WithEvents monthPromptLabel As System.Windows.Forms.Label
    Friend WithEvents dayOfMonthPromptLabel As System.Windows.Forms.Label
    Friend WithEvents yearPromptLabel As System.Windows.Forms.Label
    Friend WithEvents dayOfWeekTextBox As System.Windows.Forms.TextBox
    Friend WithEvents monthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dayOfMonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents yearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dateOutputLabel As System.Windows.Forms.Label
    Friend WithEvents showDateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
