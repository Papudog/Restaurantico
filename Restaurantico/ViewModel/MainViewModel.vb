Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class MainViewModel
    Implements INotifyPropertyChanged

    Private ReadOnly _platoService As IPlatoService
    Public Property Platos As ObservableCollection(Of IPlato)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Event ShowMessage As Action(Of String)

    Sub New(platoService As IPlatoService)
        Me._platoService = platoService
        Me._platoService.PlatoList = PopulateDefaultList()

        'Ref
        Me.Platos = _platoService.PlatoList()
    End Sub

    Sub OnAddPlato(nombre As String, precio As Double)
        Me._platoService.AddPlato(New Plato With {.Nombre = nombre, .Precio = precio})
        RaiseEvent ShowMessage($"El plato {nombre} ha sido creado con exito")
        OnPropertyChanged(NameOf(Platos))
    End Sub

    Sub OnDeletePlato(index As Int32)
        RaiseEvent ShowMessage($"El plato {_platoService.PlatoList(index).Nombre} ha sido eliminado")
        Me._platoService.DeletePlato(index)
        OnPropertyChanged(NameOf(Platos))
    End Sub

    Function PopulateDefaultList() As ObservableCollection(Of IPlato)
        Return New ObservableCollection(Of IPlato) From {
            New Plato With {.Nombre = "Gallopinto", .Precio = "100"},
            New Plato With {.Nombre = "Nacatamal", .Precio = "180"},
            New Plato With {.Nombre = "Indio viejo", .Precio = "170"},
            New Plato With {.Nombre = "Quesillo", .Precio = "50"},
            New Plato With {.Nombre = "Elote", .Precio = "60"}
        }
    End Function

    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
