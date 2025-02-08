Imports System.Collections.ObjectModel

Public Class MesaViewModel
    Inherits ObservableTrigger

    Private Property _mesaService As IMesaService
    Private Property _selectedMesa As IMesa
    Public Property Meseros As ObservableCollection(Of IMesero)
    Public Property Mesas As ObservableCollection(Of IMesa)
    Public Property SelectedMesa As IMesa
        Get
            Return Me._selectedMesa
        End Get
        Set(value As IMesa)
            Me._selectedMesa = value
            OnPropertyChanged()
        End Set
    End Property

    Sub New(mesaService As IMesaService, meseroService As IMeseroService)
        Me._mesaService = mesaService

        Me.Mesas = mesaService.Mesas
        Me.Meseros = meseroService.Meseros
    End Sub
End Class
