Public Class Checkout
    Dim uc_Notes1 As Notes
    Dim oSelectedNotes As Dictionary(Of String, Object)
    Dim CheckedOutNotes As Object
    Dim count As Integer
    Sub New(uc_Notes As Notes)

        ' This call is required by the designer.
        InitializeComponent()
        'oSelectedNotes = SelectedNotes
        ' Add any initialization after the InitializeComponent() call.
        count = uc_Notes.fctoSelectedNotes.Count


        CheckedOutNotes = From note In uc_Notes.fctoSelectedNotes
                          Select note.Value.ID, note.Value.Description, note.Value.Revision, note.Value.Createdby



    End Sub
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        'For Each note In oSelectedNotes
        '    CheckoutNotes.Add(note.Value)
        'Next
        'MyCheckoutListBox.ItemsSource = oSelectedNotes.Values.ToList()
        MsgBox(count)

        MyCheckoutListBox.ItemsSource = CheckedOutNotes
    End Sub
End Class
