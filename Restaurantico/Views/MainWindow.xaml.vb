Class MainWindow

    Private Property _platoService As New PlatoService
    Private Property _meseroService As New MeseroService

    Private Property _mainViewModel As MainViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._mainViewModel = New MainViewModel(_platoService, _meseroService)
        Me.DataContext = Me._mainViewModel
    End Sub

    Private Sub PlatosPage_Click(sender As Object, e As RoutedEventArgs)
        Dim platoPage As New PlatoWindow(Me._platoService)
        platoPage.Show()
    End Sub

    Private Sub MeseroWindow_Click(sender As Object, e As RoutedEventArgs)
        Dim meseroWindow As New MeseroWindow(Me._meseroService)
        meseroWindow.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class