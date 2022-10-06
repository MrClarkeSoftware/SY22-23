Imports System.Runtime.CompilerServices

Public Class Form1
    Const Speed As Integer = 10
    Dim direction As Point

    'This is where you can handle any collisions in the game
    '
    '  p1 has collided with p2
    '  you can return true to let it go through it
    '  or 
    '  you can return false to not let it go through
    '
    '  you could also do other actions like change directions or add points etc.
    Public Function Collision(p1 As PictureBox, p2 As PictureBox) As Boolean
        Debug.Print(p1.Name + " ran into " + p2.Name)

        'Any pictureboxes whose name start with TARGET that get run into will be removed
        If p2.Name.ToUpper.StartsWith("TARGET") Then 'remove targets when they are hit
            Remove(p2)
        End If

        'Any BULLET pictures will be removed when they collide
        If p1.Name.ToUpper.StartsWith("BULLET") Then
            '(don't remove them if they collide with the player - like when they start out
            If Not p2.Name.ToUpper.StartsWith("PLAYER") Then 'remove bullets when they collide with others
                Remove(p1)
            End If
        End If

        'Anything that runs into a wall will stop
        If p2.Name.ToUpper.StartsWith("WALL") Then
            Return False 'don't let anything through walls
        End If

        'if none of the above happened, let the object move
        Return True ' let it move
    End Function

    'Handle the keyboard - you could add your own keys if you wanted
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.W
                direction = New Point(0, -Speed)
                moveto(Player, 0, -Speed)
            Case Keys.S
                direction = New Point(0, Speed)
                moveto(Player, 0, Speed)
            Case Keys.A
                direction = New Point(-Speed, 0)
                moveto(Player, -Speed, 0)
            Case Keys.D
                direction = New Point(Speed, 0)
                moveto(Player, Speed, 0)
            Case Keys.Space
                'Add a ball in the direction the player is facing
                AddAt(BulletPictureBox2, New Point(60, 60), New Point(5, 5), "BALL")
        End Select
    End Sub

    'You can make items appear using a time
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '   AddAt(BulletPictureBox2, New Point(0, 0), "CHASE")
        'AddAt(BulletPictureBox2, New Point(10, 5), "FOLLOW")
        'AddAt(BulletPictureBox2, New Point(5, 15), "RANDOM")
        Dim path(3) As Point
        path(0) = New Point(15, 5)
        path(1) = New Point(10, 5)
        path(2) = New Point(-15, -5)
        path(3) = New Point(-10, -5)
        AddAt(BulletPictureBox2, New Point(20, 20), path)

    End Sub


    'Don't mess with the code below, this updates the game
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGame()
    End Sub

End Class
