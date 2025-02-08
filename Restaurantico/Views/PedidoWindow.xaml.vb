Imports System.Collections.ObjectModel

Public Class PedidoWindow
    Private Property _pedidoViewModel As PedidoViewModel

    Sub New(pedidoService As IPedidoService, platoService As IPlatoService, mesaService As IMesaService, meseroService As IMeseroService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._pedidoViewModel = New PedidoViewModel(pedidoService, platoService, mesaService, meseroService, TarjetaField)
        Me.DataContext = Me._pedidoViewModel
    End Sub

    Private Sub ButtonPlato_Click(sender As Object, e As RoutedEventArgs)
        Dim selectedPlato As IPlato = ListPlatos.SelectedItem
        Me._pedidoViewModel.OnAddPlatoToCollection(selectedPlato)
    End Sub

    Private Sub ButtonAddPedido_Click(sender As Object, e As RoutedEventArgs)
        Me._pedidoViewModel.OnAddPedido()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
