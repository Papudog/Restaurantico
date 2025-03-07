﻿Imports System.Collections.ObjectModel

Public Class PlatoViewModel
    Inherits ObservableTrigger

    Private ReadOnly _platoService As IPlatoService
    Private Property _selectedPlato As IPlato

    Public Property SelectedPlato As IPlato
        Get
            Return Me._selectedPlato
        End Get
        Set(value As IPlato)
            Me._selectedPlato = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Platos As ObservableCollection(Of IPlato)

    Public Event ShowMessage As Action(Of String)

    Sub New(platoService As IPlatoService)
        Me._platoService = platoService

        Me.Platos = _platoService.Platos()
    End Sub

    Sub OnAddPlato(nombre As String, precio As Double)
        Me._platoService.AddPlato(New Plato With {.Nombre = nombre, .Precio = precio})
        RaiseEvent ShowMessage($"El plato {nombre} ha sido creado con exito")
    End Sub

    Sub OnDeletePlato(index As Int32)
        RaiseEvent ShowMessage($"El plato {_platoService.Platos(index).Nombre} ha sido eliminado")
        Me._platoService.DeletePlato(index)
    End Sub
End Class
