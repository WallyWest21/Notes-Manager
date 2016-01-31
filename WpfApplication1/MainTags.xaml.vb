Imports System.Threading
Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Globalization
Imports System.Collections.ObjectModel

Public Class MainTags
    Dim DB As New DBSQLite
    Dim win_MainWindow As MainWindow
    Dim UIE As UIElementz
    Dim uc_Notes As Notes
    Public obsv_Maintags As New ObservableCollection(Of DataRow)
    Public Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)

        Dim MainTags = From maintag In DB.Binding.Tables("MainTags").AsDataView
                       Select maintag

        Dim row As DataRow

        For Each row In DB.Binding.Tables("MainTags").Rows
            obsv_Maintags.Add(row)
        Next


        'MyListBox.ItemsSource = DB.Binding.Tables("MainTags").DefaultView
        MyListBox.ItemsSource = New DataView(obsv_Maintags.CopyToDataTable)



    End Sub

    Public Sub SelectMainTag()

    End Sub


    Private Sub Label_MouseDown(sender As Object, e As MouseButtonEventArgs)
        'MsgBox(sender.Content)
        'MsgBox(Application.Current.Windows.OfType(Of MainWindow)().First().ActualWidth)
        Application.Current.Windows.OfType(Of MainWindow)().First().sp_MainBody.Children.Clear()
        'Thread.Sleep(2000)
        'Application.Current.Windows.OfType(Of MainWindow)().First().sp_MainBody.Children.Add(uc_Notes)
        'UIE.AddUserControl(Application.Current.Windows.OfType(Of MainWindow)().First().sp_MainBody, uc_Notes)
        Application.Current.Windows.OfType(Of MainWindow)().First().SelectedMainTag()
    End Sub
End Class
