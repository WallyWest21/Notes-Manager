Imports System.Data
Imports System

Class MainWindow
    Dim DB As New DBSQLite
    Private Sub Tblk_Home_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tblk_Home.MouseDown
        'DB.Connect()

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView
    End Sub
End Class
