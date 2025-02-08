Imports System.Collections.ObjectModel

Public Class Pedido
    Implements IPedido

    Private Property _platos As ObservableCollection(Of IPlato)
    Public Property Platos As ObservableCollection(Of IPlato) Implements IPedido.Platos
        Get
            Return Me._platos
        End Get
        Set(value As ObservableCollection(Of IPlato))
            Me._platos = value
        End Set
    End Property

    Private Property _cliente As String
    Public Property Cliente As String Implements IPedido.Cliente
        Get
            Return Me._cliente
        End Get
        Set(value As String)
            Me._cliente = value
        End Set
    End Property

    Private Property _mesa As IMesa
    Public Property Mesa As IMesa Implements IPedido.Mesa
        Get
            Return Me._mesa
        End Get
        Set(value As IMesa)
            Me._mesa = value
        End Set
    End Property

    Private Property _mesero As IMesero
    Public Property Mesero As IMesero Implements IPedido.Mesero
        Get
            Return Me._mesero
        End Get
        Set(value As IMesero)
            Me._mesero = value
        End Set
    End Property

    Private Property _metodoPago As String
    Public Property MetodoPago As String Implements IPedido.MetodoPago
        Get
            Return Me._metodoPago
        End Get
        Set(value As String)
            Me._metodoPago = value
        End Set
    End Property

    Private Property _subtotal As Double
    Public Property Subtotal As Double Implements IPedido.Subtotal
        Get
            Return Me._subtotal
        End Get
        Set(value As Double)
            Me._subtotal = value
        End Set
    End Property

    Private Property _iva As Double
    Public Property Iva As Double Implements IPedido.Iva
        Get
            Return Me._iva
        End Get
        Set(value As Double)
            Me._iva = value
        End Set
    End Property

    Private Property _numeroTarjeta As String
    Public Property NumeroTarjeta As String Implements IPedido.NumeroTarjeta
        Get
            Return Me._numeroTarjeta
        End Get
        Set(value As String)
            Me._numeroTarjeta = value
        End Set
    End Property

    Private Property _fecha As Date
    Public Property Fecha As Date Implements IPedido.Fecha
        Get
            Return Me._fecha
        End Get
        Set(value As Date)
            Me._fecha = value
        End Set
    End Property
End Class
