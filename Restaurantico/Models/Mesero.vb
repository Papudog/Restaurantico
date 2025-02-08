Imports System.Collections.ObjectModel

Public Class Mesero
    Implements IMesero

    Private Property _nombre As String
    Private Property _mesas As ObservableCollection(Of IMesa)

    Public Property Nombre As String Implements IMesero.Nombre
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property Mesas As ObservableCollection(Of IMesa) Implements IMesero.Mesas
        Get
            Return Me._mesas
        End Get
        Set(value As ObservableCollection(Of IMesa))
            Me._mesas = value
        End Set
    End Property
End Class
