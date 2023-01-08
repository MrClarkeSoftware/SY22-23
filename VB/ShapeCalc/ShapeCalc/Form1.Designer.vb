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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radiusTextBox = New System.Windows.Forms.TextBox()
        Me.radiusTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.circumferenceTextBox = New System.Windows.Forms.TextBox()
        Me.circleareaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sphereVolumeTextBox = New System.Windows.Forms.TextBox()
        Me.sphereSufaceTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.radiusTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(101, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(555, 349)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(547, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rectangle"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.sphereSufaceTextBox)
        Me.TabPage2.Controls.Add(Me.sphereVolumeTextBox)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.circleareaTextBox)
        Me.TabPage2.Controls.Add(Me.circumferenceTextBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.radiusTrackBar)
        Me.TabPage2.Controls.Add(Me.radiusTextBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(547, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Circle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius:"
        '
        'radiusTextBox
        '
        Me.radiusTextBox.Location = New System.Drawing.Point(96, 39)
        Me.radiusTextBox.Name = "radiusTextBox"
        Me.radiusTextBox.Size = New System.Drawing.Size(100, 26)
        Me.radiusTextBox.TabIndex = 1
        '
        'radiusTrackBar
        '
        Me.radiusTrackBar.Location = New System.Drawing.Point(96, 89)
        Me.radiusTrackBar.Name = "radiusTrackBar"
        Me.radiusTrackBar.Size = New System.Drawing.Size(104, 69)
        Me.radiusTrackBar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Circumference:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Area:"
        '
        'circumferenceTextBox
        '
        Me.circumferenceTextBox.Location = New System.Drawing.Point(153, 197)
        Me.circumferenceTextBox.Name = "circumferenceTextBox"
        Me.circumferenceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.circumferenceTextBox.TabIndex = 5
        '
        'circleareaTextBox
        '
        Me.circleareaTextBox.Location = New System.Drawing.Point(384, 194)
        Me.circleareaTextBox.Name = "circleareaTextBox"
        Me.circleareaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.circleareaTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Volume:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Surface Area:"
        '
        'sphereVolumeTextBox
        '
        Me.sphereVolumeTextBox.Location = New System.Drawing.Point(153, 248)
        Me.sphereVolumeTextBox.Name = "sphereVolumeTextBox"
        Me.sphereVolumeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.sphereVolumeTextBox.TabIndex = 9
        '
        'sphereSufaceTextBox
        '
        Me.sphereSufaceTextBox.Location = New System.Drawing.Point(384, 248)
        Me.sphereSufaceTextBox.Name = "sphereSufaceTextBox"
        Me.sphereSufaceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.sphereSufaceTextBox.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(547, 316)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cylinder"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.radiusTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents circleareaTextBox As TextBox
    Friend WithEvents circumferenceTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radiusTrackBar As TrackBar
    Friend WithEvents radiusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sphereSufaceTextBox As TextBox
    Friend WithEvents sphereVolumeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage3 As TabPage
End Class
