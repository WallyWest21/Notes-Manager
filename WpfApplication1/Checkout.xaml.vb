Public Class Checkout
    Dim uc_Notes As New Notes
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = uc_Notes.fctoSelectedNotes
    End Sub
End Class
