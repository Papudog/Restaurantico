Imports System.Collections.ObjectModel

Public Class MesaService
    Implements IMesaService

    Private Property _mesas As ObservableCollection(Of IMesa)
    Public Property Mesas As ObservableCollection(Of IMesa) Implements IMesaService.Mesas
        Get
            If Me._mesas Is Nothing OrElse Me._mesas.Count = 0 Then
                Me._mesas = PopulateMesas()
            End If
            Return Me._mesas
        End Get
        Set(value As ObservableCollection(Of IMesa))
            Me._mesas = value
        End Set
    End Property

    Private Function PopulateMesas() As ObservableCollection(Of IMesa)
        Return New ObservableCollection(Of IMesa) From {
            New Mesa With {.Numero = 1, .Mesero = Nothing},
            New Mesa With {.Numero = 2, .Mesero = Nothing},
            New Mesa With {.Numero = 3, .Mesero = Nothing},
            New Mesa With {.Numero = 4, .Mesero = Nothing},
            New Mesa With {.Numero = 5, .Mesero = Nothing},
            New Mesa With {.Numero = 6, .Mesero = Nothing},
            New Mesa With {.Numero = 7, .Mesero = Nothing}
        }
    End Function

    Public Sub AssignMesero(mesa As IMesa, mesero As IMesero) Implements IMesaService.AssignMesero
        mesa.Mesero = mesero
        If mesero IsNot Nothing AndAlso Not mesero.Mesas.Contains(mesa) Then
            mesero.Mesas = mesa
        End If
    End Sub

    Public Sub UnassignMesero(mesa As IMesa) Implements IMesaService.UnassignMesero
        If mesa.Mesero IsNot Nothing Then
            mesa.Mesero.Mesas.Remove(mesa)
            mesa.Mesero = Nothing
        End If
    End Sub
End Class
