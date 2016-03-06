
Class MainWindow
    Dim TokenizingControl As New TokenizingControlTester.TokenizingControl

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        'TokenizingControl.TokenTemplate = CType(FindResource("NameTokenTemplate"), DataTemplate)
        'TokenizingControl.Background = New SolidColorBrush(Colors.Crimson)
        TokenizingControl.TokenMatcher = Function(text)
                                             If text.EndsWith(";") Then
                                                 Return text.Substring(0, text.Length - 1).Trim().ToUpper()
                                                 TokenizingControl.presenter.ContentTemplate = CType(FindResource("NameTokenTemplate"), DataTemplate)
                                             Else
                                                 Return Nothing
                                             End If
                                         End Function


        sp_Main.Children.Add(TokenizingControl)

    End Sub

    Private Sub textBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox.TextChanged
        sender.width += 1
    End Sub
End Class
