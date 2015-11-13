Public Class MainTags
    Dim DB As New DBSQLite
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView

    End Sub
    Private Sub Mylistbox_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles MyListBox.MouseDown
        MsgBox("Hi")
    End Sub
    Sub SelectMainTag()

    End Sub
End Class
