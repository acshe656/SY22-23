Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Integer.TryParse(TextBox1.Text, age)
        Label1.Text = age
        If age > 17 Then
            Label1.Text = "You Can Vote!"
            Me.BackColor = Color.ForestGreen
        Else
            Label1.Text = "You Can't Vote!"
            Me.BackColor = Color.DarkRed
        End If
        If CheckBox1.Checked Then
            Label1.Text = "Thanks for Donating!"
        Else
            Label1.Text = ""
        End If
    End Sub
End Class