﻿Public Class MainTags
    Dim DB As New DBSQLite
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView
    End Sub
End Class