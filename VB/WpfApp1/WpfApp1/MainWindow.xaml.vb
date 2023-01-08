Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub textBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox.TextChanged

    End Sub
    Dim currentKey As String
    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Debug.Print("key down")
        currentKey = e.Key.ToString
        textBox.Text = currentKey
        Select Case e.Key
            Case Key.Left
                If (Canvas.GetLeft(TargetA) > 0) Then
                    Canvas.SetLeft(TargetA, Canvas.GetLeft(TargetA) - 10)
                End If
            Case Key.Right
                If (Canvas.GetLeft(TargetA) < 1000) Then
                    Canvas.SetLeft(TargetA, Canvas.GetLeft(TargetA) + 10)
                End If

        End Select
    End Sub
End Class
