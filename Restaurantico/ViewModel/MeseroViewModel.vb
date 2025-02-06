Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class MeseroViewModel
    Implements INotifyPropertyChanged
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

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged


    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

End Class
