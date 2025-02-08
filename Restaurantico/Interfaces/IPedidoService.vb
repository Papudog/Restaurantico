Imports System.Collections.ObjectModel

Public Interface IPedidoService
    Property Pedidos As ObservableCollection(Of IPedido)
    Sub AddPedido(pedido As IPedido)
End Interface
