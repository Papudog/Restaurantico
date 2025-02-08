Imports System.Collections.ObjectModel

Public Interface IMesaService
    Property Mesas As ObservableCollection(Of IMesa)
    Sub AssignMesero(mesa As IMesa, mesero As IMesero)
    Sub UnassignMesero(mesa As IMesa)
End Interface
