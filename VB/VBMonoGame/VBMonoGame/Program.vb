Imports System

Imports VBMonoGame.VBMonoGame

Public Module Program
    Sub Main()
        Using game As New Game1()
            game.Run()
        End Using
    End Sub
End Module
