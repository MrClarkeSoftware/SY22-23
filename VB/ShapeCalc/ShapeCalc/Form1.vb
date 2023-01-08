Public Class Form1
    Private Sub radiusTrackBar_Scroll(sender As Object, e As EventArgs) Handles radiusTrackBar.Scroll
        radiusTextBox.Text = radiusTrackBar.Value
    End Sub

    Private Sub radiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles radiusTextBox.TextChanged
        Dim radius As Integer
        Integer.TryParse(radiusTextBox.Text, radius)

        circleareaTextBox.Text = circleArea(radius).ToString("N2")
        circumferenceTextBox.Text = circumference(radius).ToString("N2")
        sphereVolumeTextBox.Text = circleVolume(radius).ToString("N2")
        sphereSufaceTextBox.Text = ciclesurface(radius).ToString("N2")
    End Sub
    Function circleArea(r As Integer) As Decimal
        'Formula is pie * r squared
        Return r ^ 2 * Math.PI
    End Function
    Function circumference(r As Integer) As Decimal
        'Formula is 2*pie*r
        Return 2 * Math.PI * r
    End Function
    Function circleVolume(r As Integer) As Decimal
        'Formula is 4/3*pie*r cubed
        Return 4 / 3 * Math.PI * r ^ 3
    End Function
    Function ciclesurface(r As Integer) As Decimal
        Return 4 * Math.PI * r ^ 2
    End Function
End Class
