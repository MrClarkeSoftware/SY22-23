Module Game
    Dim n As Integer
    Dim obj As New Dictionary(Of PictureBox, action)
    Dim PlayerMoves As New Collection

    Structure action
        Dim name As String
        Dim pic As PictureBox
        Dim dir() As Point
        Dim idx As Integer
    End Structure

    Sub moveto(p As PictureBox, x As Integer, y As Integer)
        moveto(p, New Point(x, y))
    End Sub
    Sub moveto(p As PictureBox, dir As Point)
        p.Location += dir


        'Go through all objects on Form1
        For Each c In Form1.Controls
            If c.visible AndAlso Not c Is p AndAlso c.GetType Is GetType(PictureBox) Then
                'report any collisions
                If p.Bounds.IntersectsWith(c.Bounds) Then
                    If Form1.Collision(p, c) Then
                        Return
                    Else
                        p.Location -= dir
                    End If
                End If
            End If
        Next

        'Keep track of the player move for "CHASE"
        If p.Name = "Player" Then
            PlayerMoves.Add(p.Location)
        End If
    End Sub

    Sub chase(chaser As PictureBox)
        Static headstart As Integer
        headstart = headstart + 1

        If headstart > 10 AndAlso PlayerMoves.Count > 0 Then
            chaser.Location = PlayerMoves.Item(1)
            PlayerMoves.Remove(1)
        End If
    End Sub
    Sub Follow(follower As PictureBox, speed As Point)
        If Form1.Player.Location.X < follower.Location.X Then moveto(follower, -speed.X, 0)
        If Form1.Player.Location.X > follower.Location.X Then moveto(follower, speed.X, 0)
        If Form1.Player.Location.Y > follower.Location.Y Then moveto(follower, 0, speed.Y)
        If Form1.Player.Location.Y < follower.Location.Y Then moveto(follower, 0, -speed.Y)
    End Sub

    Function CreatePicture(bullet As PictureBox, loc As Point) As PictureBox
        Dim p As New PictureBox
        p.Location = loc
        p.Size = bullet.Size
        p.BackColor = bullet.BackColor
        p.Top = loc.X
        p.Left = loc.Y
        p.Width = bullet.Width
        p.Height = bullet.Height
        p.BackColor = bullet.BackColor
        p.SizeMode = bullet.SizeMode
        If Not bullet.Image Is Nothing Then
            p.Image = bullet.Image
        End If
        p.Name = bullet.Name
        Form1.Controls.Add(p)
        Return p
    End Function

    Sub AddAt(bullet As PictureBox, loc As Point, dir As Point)
        Add(CreatePicture(bullet, loc), dir)
    End Sub

    Sub AddAt(bullet As PictureBox, loc As Point, action As String)
        Add(CreatePicture(bullet, loc), loc, action)
    End Sub

    Sub AddAt(bullet As PictureBox, loc As Point, path() As Point)
        Add(CreatePicture(bullet, loc), path)
    End Sub
    Sub Add(p As PictureBox, dirs() As Point)
        Dim a As New action
        a.name = "PATTERN"
        a.dir = dirs
        a.pic = p
        obj.Add(p, a)
    End Sub
    Sub Add(p As PictureBox, dir As Point, action As String)
        Dim a As New action
        ReDim Preserve a.dir(1)
        a.dir(0) = dir
        a.name = action
        a.pic = p
        a.dir(0) = dir
        obj.Add(p, a)
    End Sub

    Sub Add(p As PictureBox, dir As Point)
        Dim a As New action
        a.dir(0) = dir
        a.pic = p
        obj.Add(p, a)
    End Sub


    Sub Remove(p As PictureBox)
        Debug.Print("Removing " & p.Name)
        p.Visible = False
        obj.Remove(p)
    End Sub
    Sub UpdateGame()
        Dim r As New Random
        Try
            For Each p In obj
                Select Case p.Value.name
                    Case "", "MOVE"
                        moveto(p.Key, p.Value.dir(0))
                    Case "CHASE"
                        chase(p.Key)
                    Case "FOLLOW"
                        Follow(p.Key, p.Value.dir(0))
                    Case "RANDOM"
                        moveto(p.Key, p.Value.dir(0) + New Point(r.Next(-10, 10), r.Next(-10, -10)))
                    Case "PATTERN"
                        Dim a As action = p.Value
                        Dim i As Integer
                        i = n Mod (UBound(a.dir) + 1)
                        moveto(p.Key, p.Value.dir(i))
                        n = (n + 1) Mod 1000
                End Select
            Next
        Catch ex As Exception

        End Try
    End Sub
End Module
