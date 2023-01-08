Imports System
Imports System.Runtime.Intrinsics.Arm
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Namespace VBMonoGame '<==== CHANGE TO THE NAME OF YOUR PROJECT
    Public Class Game1
        Inherits Microsoft.Xna.Framework.Game

        Public Sub New()

            '   Create the Graphics Device Manager
            gdm = New GraphicsDeviceManager(Me)
            '
            '
            '   CONTENT MANAGER
            Content.RootDirectory = "Content"
            '
            '   SET BOTH TO TRUE FOR 60 FRAMES PER SECOND (FPS) 
            gdm.SynchronizeWithVerticalRetrace = True
            IsFixedTimeStep = True
            '
            '   WINDOW RESIZE
            Window.AllowUserResizing = False
            '
            '	Turn the mouse off  (SET TO True IF YOU WANT MOUSE)
            IsMouseVisible = False

            '   FULL SCREEN
            '   **** DO NOT SET THIS TO True
            '   BEFORE KEYBOARD INPUTS HAVE BEEN ADDED TO YOUR PROJECT ****
            gdm.IsFullScreen = False


        End Sub

        Dim ballTexture As Texture2D
        Dim ballPosition As Vector2
        Dim ballSpeed As Single

        Protected Overrides Sub Initialize()
            MyBase.Initialize()
            ballPosition = New Vector2(GraphicsDevice.PresentationParameters.Bounds.Width / 2,
            GraphicsDevice.PresentationParameters.Bounds.Height / 2)
            ballSpeed = 100
        End Sub

        Protected Overrides Sub LoadContent()

            '   Load FONTS
            MainFont = Content.Load(Of SpriteFont)("Arial20")

            '   Create SriteBatch
            SB = New SpriteBatch(GraphicsDevice)
            ballTexture = Content.Load(Of Texture2D)("ballTexture")
        End Sub

        Protected Overrides Sub UnloadContent()

        End Sub


        Protected Overrides Sub Update(ByVal gameTime As GameTime)
            Dim kstate As KeyboardState
            kstate = Keyboard.GetState
            If kstate.IsKeyDown(Keys.Left) Then
                ballPosition.X -= ballSpeed * gameTime.ElapsedGameTime.TotalSeconds
            End If
            If kstate.IsKeyDown(Keys.Right) Then
                ballPosition.X += ballSpeed * gameTime.ElapsedGameTime.TotalSeconds
            End If
        End Sub



        Protected Overrides Sub Draw(ByVal gameTime As GameTime)

            GraphicsDevice.Clear(Color.CornflowerBlue)

            SB.Begin()

            SB.DrawString(MainFont, "Woo Hoo! New MonoGame Project In VB.net.", New Vector2(0, 0), Color.White)
            'SB.Draw(ballTexture, New Vector2(0, 0), Color.White)
            SB.Draw(ballTexture, ballPosition, Color.White)
            SB.End()

        End Sub

    End Class
End Namespace