Public Class Form1
    Dim Numb1 As Decimal
    Dim Numb2 As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles MyBase.Click, B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click, B0.Click, Bdecimal.Click
        DisplayTxtBx.Text = DisplayTxtBx.Text + sender.text
    End Sub

    Private Sub Benter_Click(sender As Object, e As EventArgs) Handles Benter.Click
        DisplayTxtBx.Clear()
    End Sub

    Private Sub Bplus_Click(sender As Object, e As EventArgs) Handles Bplus.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        oper = "+"
        DisplayTxtBx.Clear()
    End Sub

    Private Sub Bequal_Click(sender As Object, e As EventArgs) Handles Bequal.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb2)
        If oper = "+" Then
            DisplayTxtBx.Text = Numb1 + Numb2
        End If
        If oper = "-" Then
            DisplayTxtBx.Text = Numb1 - Numb2
        End If
        If oper = "/" Then
            DisplayTxtBx.Text = Numb1 / Numb2
        End If
        If oper = "*" Then
            DisplayTxtBx.Text = Numb1 * Numb2
        End If
    End Sub

    Private Sub Bminus_Click(sender As Object, e As EventArgs) Handles Bminus.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        oper = "-"
        DisplayTxtBx.Clear()
    End Sub

    Private Sub Bdivide_Click(sender As Object, e As EventArgs) Handles Bdivide.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        oper = "/"
        DisplayTxtBx.Clear()
    End Sub

    Private Sub Bmultiply_Click(sender As Object, e As EventArgs) Handles Bmultiply.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        oper = "*"
        DisplayTxtBx.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bsquareroot.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        DisplayTxtBx.Text = Math.Sqrt(Numb1)
    End Sub

    Private Sub tanbutton_Click(sender As Object, e As EventArgs) Handles tanbutton.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        DisplayTxtBx.Text = Math.Tan(Numb1)
    End Sub

    Private Sub sinebutton_Click(sender As Object, e As EventArgs) Handles sinebutton.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        DisplayTxtBx.Text = Math.Sin(Numb1)
    End Sub

    Private Sub cosbutton_Click(sender As Object, e As EventArgs) Handles cosbutton.Click
        Decimal.TryParse(DisplayTxtBx.Text, Numb1)
        DisplayTxtBx.Text = Math.Cos(Numb1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayTxtBx.Text = Math.PI
    End Sub

    Private Sub MPLUSButton_Click(sender As Object, e As EventArgs) Handles MPLUSButton.Click
        Decimal.TryParse(DisplayTxtBx.Text, mem)
    End Sub

    Private Sub MRButton_Click(sender As Object, e As EventArgs) Handles MRButton.Click
        DisplayTxtBx.Text = mem
    End Sub

    Private Sub MCButton_Click(sender As Object, e As EventArgs) Handles MCButton.Click
        mem = 0
    End Sub
End Class
