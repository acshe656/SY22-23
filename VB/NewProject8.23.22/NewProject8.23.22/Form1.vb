Public Class Form1
    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Dim amount As Decimal
        Decimal.TryParse(AmtTextBx.Text, amount)
        Dim fee As Decimal
        fee = amount * 0.03
        FeeTextBox.Text = fee.ToString("n2")
        NameTxtBox.Clear()
        CCTxtBx.Clear()
        ExpDTTxtBx.Clear()
        ZipTxtBx.Clear()
        AmtTextBx.Clear()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class