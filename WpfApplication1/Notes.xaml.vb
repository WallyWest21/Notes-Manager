Public Class Notes
    Dim DB As New DBSQLite
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("Notes").DefaultView
    End Sub
End Class
