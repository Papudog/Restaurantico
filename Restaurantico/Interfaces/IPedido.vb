Imports System.Collections.ObjectModel

Public Interface IPedido
    Property Platos As ObservableCollection(Of IPlato)
    Property Cliente As String
    Property Mesa As IMesa
    Property Mesero As IMesero
    Property NumeroTarjeta As String
    Property MetodoPago As String
    Property Iva As Double
    Property Subtotal As Double
    Property Fecha As Date
End Interface
