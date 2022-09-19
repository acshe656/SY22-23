Public Class Form1
    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        'change the ColorPictureBox's color

        'declare variables
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer

        'assign input to variables
        Integer.TryParse(RedTextBox.Text, inputRed)
        Integer.TryParse(GreenTextBox.Text, inputGreen)
        Integer.TryParse(BlueTextBox.Text, inputBlue)

        'change color
        ColorPictureBox.BackColor =
            Color.FromArgb(inputRed, inputGreen, inputBlue)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
