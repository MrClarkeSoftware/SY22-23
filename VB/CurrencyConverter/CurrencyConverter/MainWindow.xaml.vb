Class MainWindow
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim amt As Decimal
        Dim fRate As Decimal 'Amount of the currency 1 dollar buys
        Dim tRate As Decimal 'Amount of the currency 1 dollar buys

        Decimal.TryParse(FromtextBox.Text, amt)
        If fromCombo.Text = "Dollars" Then
            fRate = 1
        End If
        If fromCombo.Text = "Pesos" Then
            fRate = 18.4
        End If
        If fromCombo.Text = "Euros" Then
            fRate = 0.92
        End If

        If toCombo.Text = "Dollars" Then
            tRate = 1
        End If
        If toCombo.Text = "Pesos" Then
            tRate = 18.4
        End If
        If toCombo.Text = "Euros" Then
            tRate = 0.92
        End If
        TotextBox.Text = Convert(amt, fRate, tRate).ToString("N2")
    End Sub
    Function Convert(amt As Decimal, fromRate As Decimal, toRate As Decimal) As Decimal
        Return amt / fromRate * toRate
    End Function
End Class
