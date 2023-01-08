Public Class Form1
    Dim drawcolor As Color
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 1 To 16
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BorderStyle = BorderStyle.FixedSingle
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For index = 1 To 16
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BorderStyle = BorderStyle.None
        Next
    End Sub
    Sub fill(c As Color)
        For index = 1 To 16
            Controls("picturebox" & index).BackColor = c
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        drawcolor = sender.backcolor
        fill(drawcolor)
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If e.Button = MouseButtons.Right Then
            ColorDialog1.ShowDialog()
            sender.backcolor = ColorDialog1.Color
        End If
        drawcolor = sender.backcolor

    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox16.MouseMove, PictureBox5.MouseMove, PictureBox6.MouseMove, PictureBox7.MouseMove, PictureBox8.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove, PictureBox2.MouseMove, PictureBox9.MouseMove, PictureBox10.MouseMove, PictureBox11.MouseMove, PictureBox12.MouseMove, PictureBox13.MouseMove, PictureBox14.MouseMove, PictureBox15.MouseMove, PictureBox1.MouseMove
        sender.backcolor = drawcolor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button5.Click, Button4.Click
        drawcolor = sender.backcolor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For index = 1 To 8
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BackColor = drawcolor
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For index = 1 To 16
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            If index Mod 2 = 0 Then
                p.BackColor = drawcolor
            End If
        Next
    End Sub
End Class
