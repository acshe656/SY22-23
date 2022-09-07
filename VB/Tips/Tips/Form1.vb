Public Class Form1
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Dim dollars As Decimal
        Decimal.TryParse(SalesTextBox.Text, dollars)
        Dim Button0 As Decimal
        Button0 = dollars * 1
        GrandTotal.Text = Button0.ToString("n2")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim dollars As Decimal
        Decimal.TryParse(SalesTextBox.Text, dollars)
        Dim Button0 As Decimal
        Button0 = dollars * 1.15
        GrandTotal.Text = Button0.ToString("n2")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim dollars As Decimal
        Decimal.TryParse(SalesTextBox.Text, dollars)
        Dim Button0 As Decimal
        Button0 = dollars * 1.2
        GrandTotal.Text = Button0.ToString("n2")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim dollars As Decimal
        Decimal.TryParse(SalesTextBox.Text, dollars)
        Dim Button0 As Decimal
        Button0 = dollars * 1.25
        GrandTotal.Text = Button0.ToString("n2")
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim dollars As Decimal
        Decimal.TryParse(SalesTextBox.Text, dollars)
        Dim Button0 As Decimal
        Button0 = dollars * 1.5
        GrandTotal.Text = Button0.ToString("n2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dollars As Decimal
        Decimal.TryParse(SubtotalTextBox.Text, dollars)
        Dim Button0 As Decimal
        Button0 = dollars * 1.056
        SalesTextBox.Text = Button0.ToString("n2")
    End Sub
End Class
