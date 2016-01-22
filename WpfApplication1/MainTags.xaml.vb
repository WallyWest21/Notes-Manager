Imports System.Threading

Public Class MainTags
    Dim DB As New DBSQLite
    Dim win_MainWindow As MainWindow
    Dim UIE As UIElementz
    Dim uc_Notes As Notes
    Public Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView
        'MyListBox.DataContext = DB.Binding.Tables("MainTags")

    End Sub

    Public Sub SelectMainTag()

    End Sub


    Private Sub Label_MouseDown(sender As Object, e As MouseButtonEventArgs)
        'MsgBox(sender.Content)
        'MsgBox(Application.Current.Windows.OfType(Of MainWindow)().First().ActualWidth)
        Application.Current.Windows.OfType(Of MainWindow)().First().sp_MainBody.Children.Clear()
        'Thread.Sleep(2000)
        'Application.Current.Windows.OfType(Of MainWindow)().First().sp_MainBody.Children.Add(uc_Notes)
        'UIE.AddUserControl(Application.Current.Windows.OfType(Of MainWindow)().First().sp_MainBody, uc_Notes)
        Application.Current.Windows.OfType(Of MainWindow)().First().SelectedMainTag()
    End Sub
End Class
