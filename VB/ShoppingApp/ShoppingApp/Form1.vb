Public Class Form1

    Private Sub F2Button_Click(sender As Object, e As EventArgs) Handles F2Button.Click
        Form2.ShowDialog()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class
