Public Class Form1
    Private Sub VenusButton_Click(sender As Object, e As EventArgs) Handles VenusButton.Click
        DisplayPictureBox.Image = VenusPicture.Image
        VenusName.Text = "Venus"
        VenusColor.Text = "White/Orange"
        VenusSize.Text = "3,760.4 mi"
        VenusDistance.Text = "66.849 million mi"
        venustemp.Text = "800-900f"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NeptuneButton_Click(sender As Object, e As EventArgs) Handles NeptuneButton.Click
        DisplayPictureBox.Image = neptunePictureBox.Image
        VenusName.Text = "Neptune"
        VenusColor.Text = "Blue"
        VenusSize.Text = "15,299 mi"
        VenusDistance.Text = "2.78 billion mi"
        venustemp.Text = "-373 degrees F."
    End Sub

    Private Sub MercuryButton_Click(sender As Object, e As EventArgs) Handles MercuryButton.Click
        DisplayPictureBox.Image = MercuryPictureBox.Image
        VenusName.Text = "Mercury"
        VenusColor.Text = "Rainbow"
        VenusSize.Text = "1,516 mi"
        VenusDistance.Text = "42.702 million mi"
        venustemp.Text = "750-800f"
    End Sub

    Private Sub SaturnButton_Click(sender As Object, e As EventArgs) Handles SaturnButton.Click
        DisplayPictureBox.Image = saturnPictureBox.Image
        VenusName.Text = "Saturn"
        VenusColor.Text = "Yellowish"
        VenusSize.Text = "36,184 mi"
        VenusDistance.Text = "916.05 million mi"
        venustemp.Text = "about -285 degrees F."
    End Sub

    Private Sub PlutoButton_Click(sender As Object, e As EventArgs) Handles PlutoButton.Click
        DisplayPictureBox.Image = PictureBox1.Image
        VenusName.Text = "Pluto"
        VenusColor.Text = "Blueish Redish Grayish"
        VenusSize.Text = "738.38 mi"
        VenusDistance.Text = "3.7 billion miles"
        venustemp.Text = "-387°F"
        plutomesage.Text = "Always the Biggest Planet in our Hearts<3"
    End Sub
End Class