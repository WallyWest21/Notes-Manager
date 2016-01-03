Public Class MainWindow
    Dim DB As New DBSQLite
    Dim uc_MainTags As New MainTags
    Dim uc_Notes As New Notes
    Dim UIE As New UIElementz
    Dim win_ANN As New Add_a_new_note
    Private Sub Tblk_Home_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tblk_Home.MouseDown
        'DB.Connect()
        'uc_MainTags.SelectMainTag()
        'sp_MainBody.Children.Clear()
        'sp_MainBody.Children.Add(uc_MainTags)
        UIE.AddUserControl(sp_MainBody, uc_MainTags)
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView
        UIE.AddUserControl(sp_MainBody, uc_MainTags)
        'sp_MainBody.Children.Add(uc_MainTags)
        'MessageBox.Show("Hi")
        'sp_MainBody.Children.Add(uc_Notes)

        'btn_Cart.DataContext = uc_Notes.SelectedNotesList

    End Sub

    Private Sub btn_Cart_Click(sender As Object, e As RoutedEventArgs) Handles btn_Cart.Click
        'sp_MainBody.Children.Clear()
        'sp_MainBody.Children.Add(uc_Notes)

        Dim CtrlBinding As New Binding()
        CtrlBinding.Source = uc_Notes.MyListBox.SelectedItem
        CtrlBinding.Path = New PropertyPath("Description")

        'btn_Cart.DataContext = uc_Notes.MyListBox.SelectedItems.Count
        btn_Cart.SetBinding(btn_Cart.Content, CtrlBinding)
    End Sub
    'Private Sub Mylistbox_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 
    '    MsgBox("Hi")
    'End Sub

    Public Sub SelectedMainTag()
        sp_MainBody.Children.Add(uc_Notes)
    End Sub

    Private Sub AddNote_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles AddNote.MouseDown
        win_ANN.Show()
    End Sub
End Class
