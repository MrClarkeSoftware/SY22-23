Public Class Form1
    Private _Previous As System.Nullable(Of Point) = Nothing
    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        _Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If _Previous IsNot Nothing Then
            If PictureBox1.Image Is Nothing Then
                Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.Clear(Color.White)
                End Using
                PictureBox1.Image = bmp
            End If
            ' Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
            Dim c1 As New Class1()
            c1.Draw(PictureBox1.Image, e.Location)
            ' End Using
            PictureBox1.Invalidate()
            _Previous = e.Location
        End If
    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        _Previous = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
        '    g.DrawLine(Pens.Black, New Point(0, 0), New Point(100, 100))
        'End Using
        'PictureBox1.Invalidate()
        Dim c1 As New Class1()
        'c1.Draw()
    End Sub
End Class
