Imports System.Collections.ObjectModel

Public Class Notes

    Dim DB As New DBSQLite
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyListBox.ItemsSource = DB.Binding.Tables("Notes").DefaultView
    End Sub
    Public SelectedNotesList As New ObservableCollection(Of String)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        If MyListBox.SelectedItems.Count > 0 Then


            SelectedNotesList = MyListBox.SelectedItems
        End If
    End Sub
End Class
