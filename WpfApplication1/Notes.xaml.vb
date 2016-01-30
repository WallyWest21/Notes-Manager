﻿Imports System.Collections.ObjectModel
Imports System.Data
Imports WpfApplication1.MainWindow

Public Class Notes
    Public clSN As New cl_SelectedNotes
    Dim DB As New DBSQLite
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)


        'Dim MyNotes As New ObservableCollection(Of
        'Dim products As DataTable = DB.Binding.Tables("Notes")
        Dim Mynotes = From note In DB.Binding.Tables("Notes").AsDataView
                      Where note("IsSelected").ToString = "False"
                      Select note


        'Where note.Field(Of Boolean)("IsSelected") = True


        MyListBox.ItemsSource = Mynotes
        'MyListBox.ItemsSource = DB.Binding.Tables("Notes").DefaultView
    End Sub
    Public SelectedNotesList As New ObservableCollection(Of cl_ListBoxNotes)
    Public SelectedNotesIDList As New List(Of String)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        If MyListBox.SelectedItems.Count > 0 Then


            SelectedNotesList = MyListBox.SelectedItems
        End If
    End Sub
    Private Sub MyListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles MyListBox.SelectionChanged
        'MyListBox.SelectionMode = SelectionMode.Multiple

        'If MyListBox.SelectedItem = True Then

        '    MsgBox("What's good??")

        'Else
        '    MsgBox("What's really good??")
        'End If

        'SelectedNotesList.Add MyListBox.SelectedItem
        'MsgBox(MyListBox.SelectedItems.Count)
        'MsgBox(MyListBox.SelectedItem.Description)
        Dim item

        Dim NoteID As String
        For Each item In MyListBox.SelectedItems


            'MsgBox(item.row.itemarray(1))
            MsgBox(MyListBox.SelectedIndex)

            'If SelectedNotesIDList.Contains(item.row.itemarray(0).ToString) Then
            '    MsgBox("It's already added")
            'Else
            '    MsgBox("Added")
            SelectedNotesIDList.Add(item.row.itemarray(0).ToString)
            'End If

        Next
        clSN.SelectedNotesCount = SelectedNotesIDList.Count
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

    Public Class cl_ListBoxNotes
        Dim Description As String, Createdby As String, Revision As String
    End Class

End Class
