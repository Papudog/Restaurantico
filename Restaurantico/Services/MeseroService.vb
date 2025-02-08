Imports System.Collections.ObjectModel

Public Class MeseroService
    Implements IMeseroService

    Private Property _meseros As ObservableCollection(Of IMesero)

    Public Property Meseros As ObservableCollection(Of IMesero) Implements IMeseroService.Meseros
        Get
            If Me._meseros Is Nothing OrElse Me._meseros.Count = 0 Then
                Me._meseros = PopulateDefaultMeseros()
            End If
            Return Me._meseros
        End Get
        Set(value As ObservableCollection(Of IMesero))
            Me._meseros = value
        End Set
    End Property

    Private Function PopulateDefaultMeseros() As ObservableCollection(Of IMesero)
        Return New ObservableCollection(Of IMesero) From {
            New Mesero With {.Nombre = "Jose", .Mesas = New ObservableCollection(Of IMesa)},
            New Mesero With {.Nombre = "Rodolfo", .Mesas = New ObservableCollection(Of IMesa)},
            New Mesero With {.Nombre = "Roberto", .Mesas = New ObservableCollection(Of IMesa)},
            New Mesero With {.Nombre = "Hugo", .Mesas = New ObservableCollection(Of IMesa)},
            New Mesero With {.Nombre = "Ricardo", .Mesas = New ObservableCollection(Of IMesa)}
        }
    End Function

    Public Sub AddMesero(mesero As IMesero) Implements IMeseroService.AddMesero
        Me._meseros.Add(mesero)
    End Sub

    Public Sub DeleteMesero(index As Integer) Implements IMeseroService.DeleteMesero
        Me._meseros.RemoveAt(index)
    End Sub
End Class
