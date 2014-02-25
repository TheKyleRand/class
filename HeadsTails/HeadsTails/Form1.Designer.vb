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
        Me.headButton = New System.Windows.Forms.Button()
        Me.tailButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.tailPictureBox = New System.Windows.Forms.PictureBox()
        Me.headPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.tailPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headButton
        '
        Me.headButton.Location = New System.Drawing.Point(43, 214)
        Me.headButton.Name = "headButton"
        Me.headButton.Size = New System.Drawing.Size(75, 36)
        Me.headButton.TabIndex = 0
        Me.headButton.Text = "Show Heads"
        Me.headButton.UseVisualStyleBackColor = True
        '
        'tailButton
        '
        Me.tailButton.Location = New System.Drawing.Point(221, 214)
        Me.tailButton.Name = "tailButton"
        Me.tailButton.Size = New System.Drawing.Size(75, 36)
        Me.tailButton.TabIndex = 1
        Me.tailButton.Text = "Show Tails"
        Me.tailButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(410, 214)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 36)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'tailPictureBox
        '
        Me.tailPictureBox.Image = Global.HeadsTails.My.Resources.Resources.Tails1
        Me.tailPictureBox.Location = New System.Drawing.Point(290, 44)
        Me.tailPictureBox.Name = "tailPictureBox"
        Me.tailPictureBox.Size = New System.Drawing.Size(153, 140)
        Me.tailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tailPictureBox.TabIndex = 4
        Me.tailPictureBox.TabStop = False
        Me.tailPictureBox.Visible = False
        '
        'headPictureBox
        '
        Me.headPictureBox.Image = Global.HeadsTails.My.Resources.Resources.Heads1
        Me.headPictureBox.Location = New System.Drawing.Point(43, 44)
        Me.headPictureBox.Name = "headPictureBox"
        Me.headPictureBox.Size = New System.Drawing.Size(156, 140)
        Me.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.headPictureBox.TabIndex = 3
        Me.headPictureBox.TabStop = False
        Me.headPictureBox.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 262)
        Me.Controls.Add(Me.tailPictureBox)
        Me.Controls.Add(Me.headPictureBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.tailButton)
        Me.Controls.Add(Me.headButton)
        Me.Name = "Form1"
        Me.Text = "Heads or Tails"
        CType(Me.tailPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents headButton As System.Windows.Forms.Button
    Friend WithEvents tailButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents headPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tailPictureBox As System.Windows.Forms.PictureBox

End Class
