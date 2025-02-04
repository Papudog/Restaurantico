Imports System.Collections.ObjectModel

Public Interface IPlatoService

    Property PlatoList As ObservableCollection(Of IPlato)

    Sub AddPlato(plato As IPlato)
    Sub DeletePlato(index As Int32)
    Function GetAllPlatos() As ObservableCollection(Of IPlato)
End Interface
