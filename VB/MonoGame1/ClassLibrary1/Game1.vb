

Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Game1
    Inherits Game
    Private WithEvents graphics As GraphicsDeviceManager
    Private WithEvents spriteBatch As SpriteBatch

    'SAMPLE DRAW
    Private t2d As Texture2D ' SPRITE TEST
    Private t2dVector As New Vector2(200, 200) ' SPRITE POSITION
    Private t2dSize As Integer = 20 ' SPRITE SIZE
    Private lastScroll As Integer = 0 'MOUSE SCROLL WHEEL TRACKING

    Private spriteFont As SpriteFont ' SPRITE FONT TEST


    Public Sub New()
        'MyBase.New()
        graphics = New GraphicsDeviceManager(Me)

        Content.RootDirectory = "Content"
    End Sub

    Protected Overrides Sub Initialize()
        MyBase.Initialize()

        Window.AllowUserResizing = True
        IsMouseVisible = True
    End Sub

    Protected Overrides Sub LoadContent()
        spriteBatch = New SpriteBatch(GraphicsDevice)

        ' CREATE SERVICES
        Services.AddService(GetType(SpriteBatch), spriteBatch)
        Services.AddService(GetType(GraphicsDeviceManager), graphics)
        ' ADDITIONAL SERVICES


        ' TOGGLE VSYNC
        Me.graphics.SynchronizeWithVerticalRetrace = True

        ' ADD START SCREENS & ASSETS
        t2d = Content.Load(Of Texture2D)("GFX/square")
        spriteFont = Content.Load(Of SpriteFont)("Fonts/Quartz_MS_10")

        'graphics.IsFullScreen = True
    End Sub

    Protected Overrides Sub UnloadContent()
        ' TODO: Unload any non ContentManager content here
    End Sub

    Public Function HandleInput(keyName As Keys) As Boolean
        If Input.Keyboard.GetState().IsKeyDown(keyName) Then Return True

        Return False
    End Function

    Public Function HandleMouseInput() As MouseState
        Return Input.Mouse.GetState()

        Return Nothing
    End Function

    Protected Overrides Sub Update(gameTime As GameTime)
        ' UPDATE YOUR GSME ELEMENTS
        MyBase.Update(gameTime)

        ' INPUT DETECTION & UPDATE
        If HandleInput(Keys.W) Then t2dVector.Y -= 3
        If HandleInput(Keys.S) Then t2dVector.Y += 3
        If HandleInput(Keys.A) Then t2dVector.X -= 3
        If HandleInput(Keys.D) Then t2dVector.X += 3

        ' SCROLL BUTTON TEST : RESIZE SPRITE
        If lastScroll <> (HandleMouseInput().ScrollWheelValue / 120) Then
            If lastScroll < (HandleMouseInput().ScrollWheelValue / 120) Then
                t2dSize += 10
            Else
                t2dSize -= 10
            End If

            lastScroll = (HandleMouseInput().ScrollWheelValue / 120)
        End If
    End Sub

    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.DarkRed)

        ' DRAW SCREENS & RESOURCES
        ' spriteBatch.Begin() ' Smooth Unscaled Graphics

        ' BEST FOR PIXEL ART & SHARP SCALING
        spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone)

        ' TEXTURE2D
        spriteBatch.Draw(t2d, New Rectangle(t2dVector.X, t2dVector.Y, t2dSize, t2dSize), Color.White)

        ' SPRITEFONT
        spriteBatch.DrawString(spriteFont, "Monogame Boilerplate - Lite" & vbCrLf &
            "Scroll Value: " & (HandleMouseInput().ScrollWheelValue / 120), New Vector2(100, 100), Color.CornflowerBlue, 0, Nothing, 2.0, Nothing, 0)

        spriteBatch.End()

        MyBase.Draw(gameTime)
    End Sub
End Class