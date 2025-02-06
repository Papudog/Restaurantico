Imports System.Collections.ObjectModel

Public Class MeseroService
    Implements IMeseroService

    Private Property _meseros As New ObservableCollection(Of IMesero)

    Private Property IMeseroService_Meseros As ObservableCollection(Of IMesero) Implements IMeseroService.Meseros
        Get
            If Me._meseros.Count = 0 Then
                Me._meseros = PopulateDefaultMeseros()
            End If
            Return Me._meseros
        End Get
        Set(value As ObservableCollection(Of IMesero))
            Me._meseros = value
        End Set
    End Property

    Public Sub AsignMesa(mesa As IMesa) Implements IMeseroService.AsignMesa
        Throw New NotImplementedException()
    End Sub

    Public Function WhichMesas() As List(Of IMesa) Implements IMeseroService.WhichMesas
        Throw New NotImplementedException()
    End Function

    Private Function PopulateDefaultMeseros() As ObservableCollection(Of IMesero)
        Return New ObservableCollection(Of IMesero) From {
            New Mesero With {.Nombre = "Jose", .Imagen = "", .Mesas = New List(Of IMesa)},
            New Mesero With {.Nombre = "Rodolfo", .Imagen = "", .Mesas = New List(Of IMesa)},
            New Mesero With {.Nombre = "Roberto", .Imagen = "", .Mesas = New List(Of IMesa)},
            New Mesero With {.Nombre = "Hugo", .Imagen = "", .Mesas = New List(Of IMesa)},
            New Mesero With {.Nombre = "Ricardo", .Imagen = "", .Mesas = New List(Of IMesa)}
        }
    End Function
End Class
