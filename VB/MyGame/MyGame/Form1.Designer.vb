<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BulletPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Target = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BulletPictureBox2
        '
        Me.BulletPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BulletPictureBox2.Image = Global.MyGame.My.Resources.Resources.donut_circle
        Me.BulletPictureBox2.Location = New System.Drawing.Point(737, 137)
        Me.BulletPictureBox2.Name = "BulletPictureBox2"
        Me.BulletPictureBox2.Size = New System.Drawing.Size(38, 34)
        Me.BulletPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPictureBox2.TabIndex = 8
        Me.BulletPictureBox2.TabStop = False
        Me.BulletPictureBox2.Visible = False
        '
        'WallPictureBox3
        '
        Me.WallPictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox3.Location = New System.Drawing.Point(714, 113)
        Me.WallPictureBox3.Name = "WallPictureBox3"
        Me.WallPictureBox3.Size = New System.Drawing.Size(17, 184)
        Me.WallPictureBox3.TabIndex = 6
        Me.WallPictureBox3.TabStop = False
        '
        'WallPictureBox4
        '
        Me.WallPictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox4.Location = New System.Drawing.Point(164, 311)
        Me.WallPictureBox4.Name = "WallPictureBox4"
        Me.WallPictureBox4.Size = New System.Drawing.Size(388, 25)
        Me.WallPictureBox4.TabIndex = 5
        Me.WallPictureBox4.TabStop = False
        '
        'Target
        '
        Me.Target.Image = Global.MyGame.My.Resources.Resources.froyo_circle
        Me.Target.Location = New System.Drawing.Point(454, 86)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(43, 50)
        Me.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Target.TabIndex = 1
        Me.Target.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.MyGame.My.Resources.Resources.donut_circle
        Me.Player.Location = New System.Drawing.Point(164, 168)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(121, 72)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BulletPictureBox2)
        Me.Controls.Add(Me.WallPictureBox3)
        Me.Controls.Add(Me.WallPictureBox4)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Player)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "MyGame"
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents Target As PictureBox
    Friend WithEvents WallPictureBox4 As PictureBox
    Friend WithEvents WallPictureBox3 As PictureBox
    Friend WithEvents BulletPictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
