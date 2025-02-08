Imports System.Collections.ObjectModel

Public Interface IMeseroService
    Property Meseros As ObservableCollection(Of IMesero)

    Sub AddMesero(mesero As IMesero)
    Sub DeleteMesero(index As Integer)
End Interface
