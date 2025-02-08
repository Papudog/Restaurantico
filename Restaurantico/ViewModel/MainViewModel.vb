Imports System.Collections.ObjectModel
Public Class MainViewModel
    Public Property Platos As ObservableCollection(Of IPlato)
    Public Property Meseros As ObservableCollection(Of IMesero)
    Public Property Mesas As ObservableCollection(Of IMesa)
    Public Property Pedidos As ObservableCollection(Of IPedido)

    Sub New(platoService As IPlatoService, meseroService As IMeseroService, mesaService As IMesaService, pedidoService As IPedidoService)
        Me.Platos = platoService.Platos
        Me.Meseros = meseroService.Meseros
        Me.Mesas = mesaService.Mesas
        Me.Pedidos = pedidoService.Pedidos
    End Sub
End Class
