Imports System.Collections.ObjectModel

Public Class PlatoService
    Implements IPlatoService

    Private _platoList As New ObservableCollection(Of IPlato)

    Public Property PlatoList As ObservableCollection(Of IPlato) Implements IPlatoService.PlatoList
        Get
            Return Me._platoList
        End Get
        Set(value As ObservableCollection(Of IPlato))
            _platoList = value
        End Set
    End Property

    Public Sub AddPlato(plato As IPlato) Implements IPlatoService.AddPlato
        Me.PlatoList.Add(plato)
    End Sub

    Public Sub DeletePlato(index As Integer) Implements IPlatoService.DeletePlato
        Me.PlatoList.RemoveAt(index)
    End Sub
End Class
