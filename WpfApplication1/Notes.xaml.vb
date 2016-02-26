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
    Public oSelectedNotes As New Dictionary(Of String, cl_ListBoxNotes)


    Private Sub MyListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles MyListBox.SelectionChanged

        Dim tempSelectedNotes As New Dictionary(Of String, Object)
        Dim clNotes As New cl_ListBoxNotes
        Dim SeledctedItem As Object, Item As Object

        For Each SeledctedItem In MyListBox.SelectedItems
            Dim key As String = SeledctedItem.row.itemarray(0).ToString
            tempSelectedNotes.Add(key, SeledctedItem.row.itemarray)
        Next


        For Each Item In MyListBox.Items
            clNotes = New cl_ListBoxNotes
            Dim otherkey As String = Item.row.itemarray(0).ToString

            For Each temp In tempSelectedNotes

                If temp.Key = otherkey Then
                    If Not oSelectedNotes.ContainsKey(temp.Key) Then

                        clNotes.ID = Item.row.itemarray(0).ToString
                        clNotes.Description = Item.row.itemarray(1).ToString
                        clNotes.Createdby = Item.row.itemarray(2).ToString
                        clNotes.Revision = Item.row.itemarray(3).ToString
                        clNotes.FlagNote = False
                        oSelectedNotes.Add(otherkey, clNotes)
                    End If
                    Exit For
                End If
                oSelectedNotes.Remove(otherkey)
            Next
        Next
        clNotes = Nothing
    End Sub

    Public Function fctoSelectedNotes() As Dictionary(Of String, cl_ListBoxNotes)
        Return oSelectedNotes
    End Function

    Public Class cl_ListBoxNotes
        Public Description As String, Createdby As String, Revision As String, ID As String, FlagNote As Boolean
    End Class

End Class
