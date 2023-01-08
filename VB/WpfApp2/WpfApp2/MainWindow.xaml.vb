Imports System.Windows.Media.Animation

Class MainWindow
    Inherits Window

    Private myStoryboard As Storyboard

        Public Sub New()
            InitializeComponent()
            Dim myPanel As StackPanel = New StackPanel()
            myPanel.Margin = New Thickness(10)
            Dim myRectangle As Rectangle = New Rectangle()
            myRectangle.Name = "myRectangle"
            Me.RegisterName(myRectangle.Name, myRectangle)
            myRectangle.Width = 100
            myRectangle.Height = 100
            myRectangle.Fill = Brushes.Blue
            Dim myDoubleAnimation As DoubleAnimation = New DoubleAnimation()
        myDoubleAnimation.From = 100.0
        myDoubleAnimation.[To] = 0.0
            myDoubleAnimation.Duration = New Duration(TimeSpan.FromSeconds(5))
            myDoubleAnimation.AutoReverse = True
            myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever
            myStoryboard = New Storyboard()
            myStoryboard.Children.Add(myDoubleAnimation)
            Storyboard.SetTargetName(myDoubleAnimation, myRectangle.Name)
        Storyboard.SetTargetProperty(myDoubleAnimation, New PropertyPath(Rectangle.HeightProperty))
        myRectangle.AddHandler(LoadedEvent, New RoutedEventHandler(AddressOf myRectangleLoaded))
        myPanel.Children.Add(myRectangle)
        Me.Content = myPanel
        End Sub

        Private Sub myRectangleLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            myStoryboard.Begin(Me)
        End Sub
    End Class

