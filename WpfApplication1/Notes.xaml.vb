Imports System.Collections.ObjectModel
Imports System.Data
Imports WpfApplication1.MainWindow

Public Class Notes
    Public clSN As New cl_SelectedNotes
    Dim DB As New DBSQLite
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)



        'Dim products As DataTable = DB.Binding.Tables("Notes")

        Dim Mynotes = From note In DB.Binding.Tables("Notes").AsDataView
                      Where note("IsSelected").ToString = "False"
                      Select note
        'Dim obsv As New ObservableCollection(Of String)(Mynotes)


        'Where note.Field(Of Boolean)("IsSelected") = True


        MyListBox.ItemsSource = Mynotes
        'MyListBox.ItemsSource = DB.Binding.Tables("Notes").DefaultView
    End Sub
    Public SelectedNotesList As New ObservableCollection(Of cl_ListBoxNotes)
    Public SelectedNotesIDList As New List(Of String)
    Public oSelectedNotes As New Dictionary(Of String, Object)

    'Public Sub New(ByRef SelectedNotes As Dictionary(Of String, Object))

    '    SelectedNotes = oSelectedNotes
    '    ' This call is required by the designer.
    '    InitializeComponent()



    '    'If MyListBox.SelectedItems.Count > 0 Then
    '    '    SelectedNotesList = MyListBox.SelectedItems
    '    'End If




    'End Sub
    Private Sub MyListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles MyListBox.SelectionChanged

        Dim tempSelectedNotes As New Dictionary(Of String, Object)







        'MyListBox.SelectionMode = SelectionMode.Multiple

        'If MyListBox.SelectedItem = True Then

        '    MsgBox("What's good??")

        'Else
        '    MsgBox("What's really good??")
        'End If

        'SelectedNotesList.Add MyListBox.SelectedItem
        'MsgBox(MyListBox.SelectedItems.Count)
        'MsgBox(MyListBox.SelectedItem.Description)
        Dim SeledctedItem As Object
        Dim Item As Object


        Dim NoteID As String
        'For Each item In MyListBox.SelectedItems

        For Each SeledctedItem In MyListBox.SelectedItems


            'MsgBox(item.row.itemarray(1))
            'MsgBox(MyListBox.SelectedIndex)

            'If SelectedNotesIDList.Contains(item.row.itemarray(0).ToString) Then
            '    MsgBox("It's already added")
            'Else
            '    MsgBox("Added")
            'SelectedNotesIDList.Add(item.row.itemarray(0).ToString)
            'End If

            Dim key As String = SeledctedItem.row.itemarray(0).ToString

            'If tempSelectedNotes.Count > 0 Then



            'If tempSelectedNotes.ContainsKey(key) Then
            '    tempSelectedNotes.Remove(key)
            'Else
            tempSelectedNotes.Add(key, SeledctedItem.row.itemarray)

            'End If

            'ElseIf tempSelectedNotes.Count = 0 Then

            'tempSelectedNotes.Add(key, SeledctedItem.row.itemarray)


            'End If
        Next


        For Each Item In MyListBox.Items
            Dim otherkey As String = Item.row.itemarray(0).ToString

            For Each temp In tempSelectedNotes

                If temp.Key = otherkey Then
                    If Not oSelectedNotes.ContainsKey(temp.Key) Then
                        oSelectedNotes.Add(otherkey, Item.row.itemarray)
                    End If
                    Exit For
                End If
                oSelectedNotes.Remove(otherkey)

            Next



        Next



        'clSN.SelectedNotesCount = SelectedNotesIDList.Count
        'For x = 0 To MyListBox.Items.Count - 1

        '    ' Determine if the item is selected.
        '    If MyListBox.SelectedIndex(x) <> -1 Then
        '        ' Deselect all items that are selected.
        '        MyListBox.SetSelected(x, False)
        '    Else
        '        ' Select all items that are not selected.
        '        MyListBox.SetSelected(x, True)
        '    End If
        'Next x



        'MyListBox.SelectedValuePath = "Createdby"
        'Dim oMyListBoxBinding As New Binding("db_Createdby")
        'MsgBox(oMyListBoxBinding.ToString)




        'For item As Integer = 0 To MyListBox.SelectedItems.Count

        '    If MyListBox.Items(item).selectedindex > -1 Then
        '        MsgBox(MyListBox.SelectedItems(item).SelectedIndex)
        '    End If

        'Next

    End Sub

    Public Function fctoSelectedNotes() As Dictionary(Of String, Object)
        Return oSelectedNotes
    End Function

    Public Class cl_ListBoxNotes
        Dim Description As String, Createdby As String, Revision As String
    End Class

End Class
