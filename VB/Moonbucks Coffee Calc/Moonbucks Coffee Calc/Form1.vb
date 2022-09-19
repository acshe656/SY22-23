Public Class Form1
    Private Sub ClacButton_Click(sender As Object, e As EventArgs) Handles ClacButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(PoundsTextBox.Text, dollars)
        Dim CalcButton As Decimal
        CalcButton = dollars * 4.99
        TotalTextBox.Text = CalcButton.ToString("c3")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        ZipTextBox.Clear()
        StateTextBox.Clear()
        Regulartxtbx.Clear()
        Decaftxtbx.Clear()
        PoundsTextBox.Clear()
        TotalTextBox.Clear()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
