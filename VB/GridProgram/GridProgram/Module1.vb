Module Module1
    Function CreatePicture(picture As PictureBox, row As Integer, col As Integer) As PictureBox
        Dim p As New PictureBox
        Dim loc As New Point(row * 10, col * 10)
        p.Location = loc
        p.Size = picture.Size
        p.BackColor = picture.BackColor
        p.BorderStyle = picture.BorderStyle
        p.Top = Loc.Y
        p.Left = Loc.X
        p.Width = picture.Width
        p.Height = picture.Height
        p.BackColor = picture.BackColor
        p.SizeMode = picture.SizeMode
        If Not picture.Image Is Nothing Then
            p.Image = picture.Image
        End If
        p.Name = "Grid-" & row & "-" & col
        Debug.Print("Adding " & p.Name)
        Form1.Controls.Add(p)
        Return p
    End Function
    Public Function GetPicture(row As Integer, col As Integer) As PictureBox
        If (row <= 40 And col <= 40) Then
            Return Form1.Controls("Grid-" & row & "-" & col)
        End If
        Return Form1.PictureBox1
    End Function
End Module
