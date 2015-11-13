Class MainWindow
    Dim DB As New DBSQLite
    Dim uc_MainTags As New MainTags
    Dim uc_Notes As New Notes
    Private Sub Tblk_Home_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tblk_Home.MouseDown
        'DB.Connect()

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView

        sp_MainBody.Children.Add(uc_MainTags)
        'MessageBox.Show("Hi")
        'sp_MainBody.Children.Add(uc_Notes)
    End Sub

    Private Sub comboBox_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles comboBox.MouseDown

    End Sub
End Class
