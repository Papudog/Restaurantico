Imports System.Collections.ObjectModel

Public Class PlatoService
    Implements IPlatoService

    Private _platoList As New ObservableCollection(Of IPlato)

    Public Property Platos As ObservableCollection(Of IPlato) Implements IPlatoService.Platos
        Get
            If _platoList.Count = 0 Then
                _platoList = PopulateDefaultList()
            End If
            Return Me._platoList
        End Get
        Set(value As ObservableCollection(Of IPlato))
            _platoList = value
        End Set
    End Property

    Public Sub AddPlato(plato As IPlato) Implements IPlatoService.AddPlato
        Me.Platos.Add(plato)
    End Sub

    Public Sub DeletePlato(index As Integer) Implements IPlatoService.DeletePlato
        Me.Platos.RemoveAt(index)
    End Sub

    Private Function PopulateDefaultList() As ObservableCollection(Of IPlato)
        Return New ObservableCollection(Of IPlato) From {
            New Plato With {.Nombre = "Gallopinto", .Precio = "100"},
            New Plato With {.Nombre = "Nacatamal", .Precio = "180"},
            New Plato With {.Nombre = "Indio viejo", .Precio = "170"},
            New Plato With {.Nombre = "Quesillo", .Precio = "50"},
            New Plato With {.Nombre = "Elote", .Precio = "60"}
        }
    End Function
End Class
