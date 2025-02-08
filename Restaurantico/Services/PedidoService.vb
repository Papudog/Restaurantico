Imports System.Collections.ObjectModel

Public Class PedidoService
    Implements IPedidoService

    Private Property _pedidos As New ObservableCollection(Of IPedido)

    Public Property Pedidos As ObservableCollection(Of IPedido) Implements IPedidoService.Pedidos
        Get
            Return Me._pedidos
        End Get
        Set(value As ObservableCollection(Of IPedido))
            Me._pedidos = value
        End Set
    End Property

    Public Sub AddPedido(pedidos As IPedido) Implements IPedidoService.AddPedido
        Me._pedidos.Add(pedidos)
    End Sub
End Class
