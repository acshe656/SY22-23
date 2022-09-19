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
        Me.Subtotal = New System.Windows.Forms.Label()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrandTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Subtotal
        '
        Me.Subtotal.AutoSize = True
        Me.Subtotal.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotal.Location = New System.Drawing.Point(28, 116)
        Me.Subtotal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(113, 29)
        Me.Subtotal.TabIndex = 0
        Me.Subtotal.Text = "Subtotal:"
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(145, 115)
        Me.SubtotalTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.Size = New System.Drawing.Size(148, 45)
        Me.SubtotalTextBox.TabIndex = 1
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button0.Location = New System.Drawing.Point(33, 251)
        Me.Button0.Margin = New System.Windows.Forms.Padding(5)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(170, 75)
        Me.Button0.TabIndex = 2
        Me.Button0.Text = "0%"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button20.Location = New System.Drawing.Point(421, 251)
        Me.Button20.Margin = New System.Windows.Forms.Padding(5)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(170, 75)
        Me.Button20.TabIndex = 3
        Me.Button20.Text = "20%"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button15.Location = New System.Drawing.Point(227, 251)
        Me.Button15.Margin = New System.Windows.Forms.Padding(5)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(170, 75)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "15%"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button25.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button25.Location = New System.Drawing.Point(615, 251)
        Me.Button25.Margin = New System.Windows.Forms.Padding(5)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(170, 75)
        Me.Button25.TabIndex = 5
        Me.Button25.Text = "25%"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button50
        '
        Me.Button50.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button50.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button50.Location = New System.Drawing.Point(809, 251)
        Me.Button50.Margin = New System.Windows.Forms.Padding(5)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(170, 75)
        Me.Button50.TabIndex = 6
        Me.Button50.Text = "50%"
        Me.Button50.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(645, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Grand Total:"
        '
        'GrandTotal
        '
        Me.GrandTotal.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotal.Location = New System.Drawing.Point(831, 116)
        Me.GrandTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.GrandTotal.Name = "GrandTotal"
        Me.GrandTotal.Size = New System.Drawing.Size(148, 45)
        Me.GrandTotal.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sales Tax:"
        '
        'SalesTextBox
        '
        Me.SalesTextBox.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesTextBox.Location = New System.Drawing.Point(455, 116)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(148, 45)
        Me.SalesTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Location = New System.Drawing.Point(275, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add Sales Tax"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1013, 577)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SalesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrandTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.SubtotalTextBox)
        Me.Controls.Add(Me.Subtotal)
        Me.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Subtotal As Label
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents Button0 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button50 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GrandTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
