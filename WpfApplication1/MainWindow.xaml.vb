Public Class MainWindow
    Dim DB As New DBSQLite
    Dim uc_MainTags As New MainTags
    Dim uc_Notes As New Notes
    Dim UIE As New UIElementz
    Private Sub Tblk_Home_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tblk_Home.MouseDown
        'DB.Connect()
        'uc_MainTags.SelectMainTag()
        'sp_MainBody.Children.Clear()
        'sp_MainBody.Children.Add(uc_MainTags)

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView
        UIE.AddUserControl(sp_MainBody, uc_MainTags)
        'sp_MainBody.Children.Add(uc_MainTags)
        'MessageBox.Show("Hi")
        'sp_MainBody.Children.Add(uc_Notes)

    End Sub

    Private Sub btn_Cart_Click(sender As Object, e As RoutedEventArgs) Handles btn_Cart.Click
        sp_MainBody.Children.Clear()
        sp_MainBody.Children.Add(uc_Notes)
    End Sub
    'Private Sub Mylistbox_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 
    '    MsgBox("Hi")
    'End Sub

    Public Sub SelectedMainTag()
        sp_MainBody.Children.Add(uc_Notes)
    End Sub
End Class
