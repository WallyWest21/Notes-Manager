

Public Class Checkout
    Dim CheckedOutNotes As Object
    Dim oDrawing As New CATIA_Lib.Cl_CATIA.Drawing
    Dim Drawingnotes
    Sub New(uc_Notes As Notes)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        CheckedOutNotes = From note In uc_Notes.fctoSelectedNotes
                          Select note.Value.ID, note.Value.Description, note.Value.Revision, note.Value.Createdby

        Drawingnotes = (From note In uc_Notes.fctoSelectedNotes
                        Select note.Value.Description).ToList
    End Sub
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        MyCheckoutListBox.ItemsSource = CheckedOutNotes
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)


        oDrawing.WriteNotesToDrawing(Drawingnotes)
    End Sub

    Private Sub ComboBox_Loaded(sender As Object, e As RoutedEventArgs)
        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        If oDrawing.ListOfOpenDrawingDocuments.Count > 0 Then
            cb.ItemsSource = oDrawing.ListOfOpenDrawingDocuments
        Else
            cb.Items.Add("No Open Drawing")

        End If
    End Sub
End Class
