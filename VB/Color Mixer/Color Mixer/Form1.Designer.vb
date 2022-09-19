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
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.ColorPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.ColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(211, 523)
        Me.ColorButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(192, 67)
        Me.ColorButton.TabIndex = 0
        Me.ColorButton.Text = "&View Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(633, 541)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(150, 49)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Red (0-255):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Green (0-255):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 37)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Blue (0-255):"
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(303, 91)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(245, 51)
        Me.RedTextBox.TabIndex = 5
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(303, 230)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(245, 51)
        Me.GreenTextBox.TabIndex = 6
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(303, 376)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(245, 51)
        Me.BlueTextBox.TabIndex = 7
        '
        'ColorPictureBox
        '
        Me.ColorPictureBox.Location = New System.Drawing.Point(665, 91)
        Me.ColorPictureBox.Name = "ColorPictureBox"
        Me.ColorPictureBox.Size = New System.Drawing.Size(278, 336)
        Me.ColorPictureBox.TabIndex = 8
        Me.ColorPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 627)
        Me.Controls.Add(Me.ColorPictureBox)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents ColorPictureBox As PictureBox
End Class
