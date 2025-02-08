Imports System.Collections.ObjectModel

Public Interface IMesero
    Property Nombre As String
    Property Mesas As ObservableCollection(Of IMesa)
End Interface