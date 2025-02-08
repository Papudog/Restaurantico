Class MainWindow
    Private Property _platoService As New PlatoService()
    Private Property _meseroService As New MeseroService()
    Private Property _mesaService As New MesaService()
    Private Property _pedidoService As New PedidoService()
    Private Property _mainViewModel As MainViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._mainViewModel = New MainViewModel(Me._platoService, Me._meseroService, Me._mesaService, Me._pedidoService)
        Me.DataContext = Me._mainViewModel
    End Sub

    Private Sub PlatoWindow_Click(sender As Object, e As RoutedEventArgs)
        Dim platoPage As New PlatoWindow(Me._platoService)
        platoPage.Show()
    End Sub

    Private Sub MeseroWindow_Click(sender As Object, e As RoutedEventArgs)
        Dim meseroWindow As New MeseroWindow(Me._meseroService)
        meseroWindow.Show()
    End Sub
    Private Sub MesaWindow_Click(sender As Object, e As RoutedEventArgs)
        Dim mesaWindow As New MesaWindow(Me._mesaService, Me._meseroService)
        mesaWindow.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub PedidoWindow_Click(sender As Object, e As RoutedEventArgs)
        Dim pedidoWindow As New PedidoWindow(Me._pedidoService, Me._platoService, Me._mesaService, Me._meseroService)
        pedidoWindow.Show()
    End Sub
End Class