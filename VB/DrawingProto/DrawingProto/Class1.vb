Public Class Class1
    Dim m_p As Image
    Public Sub New()
        Dim bmp As New Bitmap(50, 50)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        m_p = bmp
    End Sub
    Public Sub Draw(img As Image, p As Point)
        Using g As Graphics = Graphics.FromImage(img)
            g.DrawLine(Pens.Black, p, New Point(p.X + m_p.Width, p.Y + m_p.Height))
            g.DrawLine(Pens.Black, New Point(p.X, p.Y + m_p.Height), New Point(p.X + m_p.Width, p.Y))
        End Using
    End Sub

End Class
