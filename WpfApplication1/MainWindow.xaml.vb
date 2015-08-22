Imports System.Data
Imports System

Class MainWindow
    Dim DB As New DBSQLite
    Dim uc_MainTags As New MainTags
    Dim uc_Notes As New Notes
    Private Sub Tblk_Home_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tblk_Home.MouseDown
        'DB.Connect()

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView

        'sp_MainBody.Children.Add(uc_MainTags)
        sp_MainBody.Children.Add(uc_Notes)
    End Sub
End Class
