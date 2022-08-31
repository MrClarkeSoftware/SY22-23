Public Class Form1
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Label1.Text = "1
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        Label1.Text = 2"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        Dim tip As Decimal

        If RadioButton1.Checked Then
            tip = 1.15 '15 percent
        End If
        If RadioButton2.Checked Then
            tip = 1.2 '20 percent
        End If
        'Get the amount of the bill
        Dim amount As Decimal
        Decimal.TryParse(TextBox1.Text, amount) ' get the amount from the Textbox1 and put it in amount
        'Now calculate the tip using the radio buttons
        Dim total As Decimal
        total = amount * tip
        'Show the tip in the label
        Label1.Text = total.ToString("C2")
    End Sub
End Class
