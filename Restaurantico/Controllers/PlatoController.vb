Imports System.Collections.ObjectModel

Public Class PlatoController
    Private _platoService As IPlatoService

    Sub New(platoService As IPlatoService)
        Me._platoService = platoService
        Me._platoService.PlatoList = Me.PopulateDefaultList()
    End Sub

    Sub OnAddPlato(plato As IPlato)
        Me._platoService.AddPlato(plato)
        MessageBox.Show("El plato " + plato.Nombre + " ha sido creado con exito")
    End Sub

    Sub OnDeletePlato(index As Int32)
        MessageBox.Show("El plato " + _platoService.PlatoList(index).Nombre + " ha sido eliminado")
        Me._platoService.DeletePlato(index)
    End Sub

    Function OnGetAllPlatos() As ObservableCollection(Of IPlato)
        Return Me._platoService.GetAllPlatos()
    End Function

    Function PopulateDefaultList() As ObservableCollection(Of IPlato)
        Return New ObservableCollection(Of IPlato) From {
            New Plato With {.Nombre = "Gallopinto", .Precio = "100"},
            New Plato With {.Nombre = "Nacatamal", .Precio = "180"},
            New Plato With {.Nombre = "Indio viejo", .Precio = "170"},
            New Plato With {.Nombre = "Quesillo", .Precio = "50"},
            New Plato With {.Nombre = "Elote", .Precio = "60"}
        }
    End Function
End Class
