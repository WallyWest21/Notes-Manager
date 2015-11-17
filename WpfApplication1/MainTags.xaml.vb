Public Class MainTags
    Dim DB As New DBSQLite
    Dim Mainwindow As MainWindow
    Dim UIE As UIElementz
    Dim Notes As Notes
    Public Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView

    End Sub
    Public Sub Mylistbox_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles MyListBox.MouseDown

        MsgBox("Hi")
    End Sub
    Public Sub SelectMainTag()

    End Sub

    Sub MyListBox_Selected(sender As Object, e As RoutedEventArgs)
        MsgBox("hi")
    End Sub
    Private Sub Label_MouseDown(sender As Object, e As MouseButtonEventArgs)
        MsgBox("hi Panel")

        UIE.AddUserControl(Mainwindow.sp_MainBody, Notes)

    End Sub
End Class
