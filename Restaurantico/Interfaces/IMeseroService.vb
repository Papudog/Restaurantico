Imports System.Collections.ObjectModel

Public Interface IMeseroService
    Property Meseros As ObservableCollection(Of IMesero)

    Sub AsignMesa(mesa As IMesa)
    Function WhichMesas() As List(Of IMesa)
End Interface
