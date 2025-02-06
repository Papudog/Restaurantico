Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class MainViewModel
    Implements INotifyPropertyChanged
    Private Property _platoService As IPlatoService
    Public Property Platos As ObservableCollection(Of IPlato)

    Private Property _meseroService As IMeseroService
    Public Property Meseros As ObservableCollection(Of IMesero)


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Sub New(platoService As IPlatoService, meseroService As IMeseroService)
        Me._platoService = platoService
        Me._meseroService = meseroService

        Me.Platos = platoService.Platos
        Me.Meseros = meseroService.Meseros
    End Sub

    Protected Sub OnPropertyChange(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
