Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded

        Dim _Mike_s_Video_StoreDataSet As DBTest._Mike_s_Video_StoreDataSet = CType(Me.FindResource("_Mike_s_Video_StoreDataSet"), DBTest._Mike_s_Video_StoreDataSet)
        'Load data into the table Categories. You can modify this code as needed.
        Dim _Mike_s_Video_StoreDataSetCategoriesTableAdapter As DBTest._Mike_s_Video_StoreDataSetTableAdapters.CategoriesTableAdapter = New DBTest._Mike_s_Video_StoreDataSetTableAdapters.CategoriesTableAdapter()
        _Mike_s_Video_StoreDataSetCategoriesTableAdapter.Fill(_Mike_s_Video_StoreDataSet.Categories)
        Dim CategoriesViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("CategoriesViewSource"), System.Windows.Data.CollectionViewSource)
        CategoriesViewSource.View.MoveCurrentToFirst()
    End Sub
End Class
