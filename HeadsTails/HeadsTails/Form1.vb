Public Class Form1

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub tailButton_Click(sender As Object, e As EventArgs) Handles tailButton.Click
        headPictureBox.Visible = False
        tailPictureBox.Visible = True
    End Sub

    Private Sub headButton_Click(sender As Object, e As EventArgs) Handles headButton.Click
        headPictureBox.Visible = True
        tailPictureBox.Visible = False
    End Sub
End Class
