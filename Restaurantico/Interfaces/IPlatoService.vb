Imports System.Collections.ObjectModel

Public Interface IPlatoService

    Property Platos As ObservableCollection(Of IPlato)

    Sub AddPlato(plato As IPlato)
    Sub DeletePlato(index As Int32)
End Interface
