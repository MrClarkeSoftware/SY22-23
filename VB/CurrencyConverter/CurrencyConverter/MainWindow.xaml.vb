Class MainWindow
    Private Sub FromMenu(sender As Object, e As RoutedEventArgs)
        FromtextBox.Text = sender.header
    End Sub

    Private Sub ToMenu(sender As Object, e As RoutedEventArgs)
        TotextBox.Text = sender.header
    End Sub
    Function DollarstoPesos(dollars As Decimal) As Decimal
        Return 18.5 * dollars
    End Function
    Function PesostoDollars(pesos As Decimal) As Decimal
        Return pesos / 18.5
    End Function

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim fromAmt As Decimal
        Dim toAmt As Decimal

        Decimal.TryParse(FromtextAmount.Text, fromAmt)

        If FromtextBox.Text = "Dollars" Then
            toAmt = DollarstoPesos(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" Then
            toAmt = PesostoDollars(fromAmt)
        End If
        TotextAmount.Text = toAmt
    End Sub
End Class
