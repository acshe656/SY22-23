Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim d As Decimal
        Dim s As Single
        Integer.TryParse(ATextBox.Text, n)
        Decimal.TryParse(BTextBox.Text, d)
        Single.TryParse(CTextBox.Text, s)
        Label1.Text = n
        Label2.Text = d
        Label3.Text = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
        Label3.Text = pluto
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()
        Label2.Text = venus
    End Sub
End Class
