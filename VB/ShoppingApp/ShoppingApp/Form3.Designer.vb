<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Subtotal = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Complete Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grand Total:"
        '
        'Subtotal
        '
        Me.Subtotal.AutoSize = True
        Me.Subtotal.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotal.Location = New System.Drawing.Point(231, 194)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(27, 28)
        Me.Subtotal.TabIndex = 2
        Me.Subtotal.Text = "0"
        '
        'CancelButton
        '
        Me.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton.Location = New System.Drawing.Point(776, 88)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(153, 52)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel Order"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(38, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 55)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate Grand Total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(353, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 90)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CONFIRM ORDER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(986, 611)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Subtotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Subtotal As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
