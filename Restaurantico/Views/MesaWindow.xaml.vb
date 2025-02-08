Public Class MesaWindow

    Private Property _mesaViewModel As MesaViewModel
    Sub New(mesaService As IMesaService, meseroService As IMeseroService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._mesaViewModel = New MesaViewModel(mesaService, meseroService)
        Me.DataContext = Me._mesaViewModel
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
