Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For row = 0 To 40
            For col = 0 To 40
                CreatePicture(PictureBox1, row, col)
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For row = 0 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Red
            Next
        Next
    End Sub
End Class
