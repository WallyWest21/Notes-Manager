Public Class MainWindow
    Dim DB As New DBSQLite
    Dim uc_MainTags As New MainTags
    Dim uc_Notes As New Notes()
    Dim UIE As New UIElementz
    Dim win_ANN As New Add_a_new_note

    Dim SelectedNotes As New Dictionary(Of String, Object)
    Dim count As Integer


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

        Dim count As Integer = uc_Notes.fctoSelectedNotes.Count

        'Dim CtrlBinding As New Binding()

        'CtrlBinding.Source = uc_Notes.MyListBox.SelectedItem
        'CtrlBinding.Path = New PropertyPath("Description")
        btn_Cart.Content = "Cart (" & count & ")"

        Dim uc_Checkout As New Checkout(uc_Notes)
        UIE.AddUserControl(sp_MainBody, uc_Checkout)

        'btn_Cart.DataContext = uc_Notes.MyListBox.SelectedItems.Count
        'btn_Cart.SetBinding(btn_Cart.Content, CtrlBinding)
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

    Public Sub Update_btn_cart()
        btn_Cart.Content = "Cart (" & uc_Notes.fctoSelectedNotes.Count & ")"
    End Sub

    Private Sub StackPanel_MouseDown(sender As Object, e As MouseButtonEventArgs)

    End Sub

    Private Sub btn_Search_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles btn_Search.MouseDown
        'Dim btn_NewTag As New Button
        'btn_NewTag.Content = "LHG"

        'sp_Search.Children.Add(btn_NewTag)
        MsgBox("btn_NewTag.Content")
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As RoutedEventArgs) Handles btn_Search.Click
        Dim btn_NewTag As New Button()
        btn_NewTag.Content = tbx_Search.Text
        btn_NewTag.Background = New SolidColorBrush(Colors.WhiteSmoke)
        btn_NewTag.Margin = New Thickness(2)


        AddHandler btn_NewTag.Click, AddressOf Me.RemoveTag
        sp_Search.Children.Add(btn_NewTag)
    End Sub
    ''' <summary>
    ''' 'http://stackoverflow.com/questions/7375061/dynamic-button-click-event-handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RemoveTag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Handle your Button clicks here
        sp_Search.Children.Remove(sender)


    End Sub

    Private Sub tbx_Search_GotFocus(sender As Object, e As RoutedEventArgs) Handles tbx_Search.GotFocus
        lv_Tags.Visibility = Visibility.Visible
    End Sub

    Private Sub tbx_Search_LostFocus(sender As Object, e As RoutedEventArgs) Handles tbx_Search.LostFocus
        lv_Tags.Visibility = Visibility.Collapsed
    End Sub

    'Private Sub lv_Tags_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lb_Tags.SelectionChanged
    '    Dim btn_NewTag As New Button()
    '    btn_NewTag.Content = lb_Tags.SelectedItem.
    '    btn_NewTag.Background = New SolidColorBrush(Colors.WhiteSmoke)
    '    btn_NewTag.Margin = New Thickness(2)


    '    AddHandler btn_NewTag.Click, AddressOf Me.RemoveTag
    '    sp_Search.Children.Add(btn_NewTag)
    '    lb_Tags.Visibility = Visibility.Collapsed
    'End Sub

    Private Sub lv_Tags_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lv_Tags.SelectionChanged
        Dim btn_NewTag As New Button()
        btn_NewTag.Content = lv_Tags.SelectedValue.content
        btn_NewTag.Background = New SolidColorBrush(Colors.WhiteSmoke)
        btn_NewTag.Margin = New Thickness(2)


        AddHandler btn_NewTag.Click, AddressOf Me.RemoveTag
        sp_Search.Children.Add(btn_NewTag)
        lv_Tags.Visibility = Visibility.Collapsed
    End Sub
End Class
