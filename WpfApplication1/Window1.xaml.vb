Imports System.Collections.ObjectModel


Public Class Window1
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        lst1.Add("New Item")

    End Sub

    Public lst1 As New ObservableCollection(Of String)
    Public lst2 As New ObservableCollection(Of List)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() Call.
        lst1.Add("one")
        lst1.Add("two")
        lst1.Add("three")
        listbox1.ItemsSource = lst1
    End Sub


    'Public Sub New()
    '    ' This call is required by the designer.
    '    InitializeComponent()
    '    ' Add any initialization after the InitializeComponent() call.
    '    lst2 = listbox1.SelectedItems
    'End Sub


End Class


Public Class SelectedItemToCount
    Implements IValueConverter

    Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
        If value Is Nothing Then
            Return 0
        Else
            Return value.ToString
        End If
    End Function

    Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
        Return New Object()
    End Function
End Class