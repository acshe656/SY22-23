Public Class Form1
    Private Sub PesoButton_Click(sender As Object, e As EventArgs) Handles PesoButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim PesoButton As Decimal
        PesoButton = dollars * 20.11
        convertedtxtbx.Text = PesoButton.ToString("n2")
    End Sub

    Private Sub PoundButton_Click(sender As Object, e As EventArgs) Handles PoundButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim PoundButton As Decimal
        PoundButton = dollars * 0.85
        convertedtxtbx.Text = PoundButton.ToString("n2")
    End Sub

    Private Sub CanadianDollarButton_Click(sender As Object, e As EventArgs) Handles CDollarButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim CDollarButton As Decimal
        CDollarButton = dollars * 1.31
        convertedtxtbx.Text = CDollarButton.ToString("n2")
    End Sub

    Private Sub SwissButton_Click(sender As Object, e As EventArgs) Handles SwissButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim SwissButton As Decimal
        SwissButton = dollars * 0.98
        convertedtxtbx.Text = SwissButton.ToString("n2")
    End Sub

    Private Sub euroButton_Click(sender As Object, e As EventArgs) Handles euroButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim euroButton As Decimal
        euroButton = dollars * 1
        convertedtxtbx.Text = euroButton.ToString("n2")
    End Sub

    Private Sub YenButton_Click(sender As Object, e As EventArgs) Handles YenButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim YenButton As Decimal
        YenButton = dollars * 138.97
        convertedtxtbx.Text = YenButton.ToString("n2")
    End Sub
End Class
