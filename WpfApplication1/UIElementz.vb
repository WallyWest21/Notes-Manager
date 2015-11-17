Public Class UIElementz
    Public Sub AddUserControl(ParentUI As StackPanel, ChildUI As UserControl)
        ParentUI.Children.Clear()
        ParentUI.Children.Add(ChildUI)
    End Sub
End Class
