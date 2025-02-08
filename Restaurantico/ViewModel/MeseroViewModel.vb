Imports System.Collections.ObjectModel

Public Class MeseroViewModel
    Inherits ObservableTrigger
    Private Property _meseroService As IMeseroService
    Private Property _selectedMesero As IMesero

    Public Property SelectedMesero As IMesero
        Get
            Return _selectedMesero
        End Get
        Set(value As IMesero)
            Me._selectedMesero = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Meseros As ObservableCollection(Of IMesero)

    Sub New(meseroService As IMeseroService)
        Me._meseroService = meseroService
        Me.Meseros = meseroService.Meseros
    End Sub

    Sub OnAddMesero(mesero As IMesero)
        Me._meseroService.AddMesero(mesero)
    End Sub
End Class
