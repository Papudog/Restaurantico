Public Class MeseroWindow

    Private Property _meseroViewModel As MeseroViewModel
    Sub New(meseroService As IMeseroService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._meseroViewModel = New MeseroViewModel(meseroService)
        Me.DataContext = Me._meseroViewModel
    End Sub

End Class
