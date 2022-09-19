Public Class Form2
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim SQCOST As Decimal
        Integer.TryParse(TextBox1.Text, SQCOST)
        Dim Calculation As Decimal
        Calculation = 59.99 * SQCOST
        SCLabel.Text = Calculation.ToString("n2")

        Dim VQCOST As Decimal
        Integer.TryParse(TextBox2.Text, VQCOST)
        Calculation = 49.99 * VQCOST
        VCLabel.Text = Calculation.ToString("n2")

        Dim PCOST As Decimal
        Integer.TryParse(TextBox3.Text, PCOST)
        Calculation = 29.99 * PCOST
        PCLabel.Text = Calculation.ToString("n2")

        Dim MCOST As Decimal
        Integer.TryParse(TextBox4.Text, MCOST)
        Calculation = 39.99 * MCOST
        MCLabel.Text = Calculation.ToString("n2")

        Dim NCOST As Decimal
        Integer.TryParse(TextBox5.Text, NCOST)
        Calculation = 49.99 * NCOST
        NCLabel.Text = Calculation.ToString("n2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.ShowDialog()
    End Sub

    Private Sub CalButton_Click(sender As Object, e As EventArgs) Handles CalButton.Click

        TOTAL = SCLabel.Text * 59.99 + VCLabel.Text * 49.99 + PCLabel.Text * 29.99 + MCLabel.Text * 39.99 + NCLabel.Text * 49.99
        TotalTxtBx.Text = Module1.TOTAL.ToString("n2")
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class