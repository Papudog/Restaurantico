Imports System.Collections.ObjectModel

Public Class PedidoViewModel
    Inherits ObservableTrigger

    Private Property _platoService As IPlatoService
    Private Property _mesaService As IMesaService
    Private Property _meseroService As IMeseroService
    Private Property _pedidoService As IPedidoService
    Private Property _tarjetaField As Grid

    Private Property _mesas As ObservableCollection(Of IMesa)
    Public Property Mesas As ObservableCollection(Of IMesa)
        Get
            Return _mesas
        End Get
        Set(value As ObservableCollection(Of IMesa))
            _mesas = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _meseros As ObservableCollection(Of IMesero)
    Public Property Meseros As ObservableCollection(Of IMesero)
        Get
            Return _meseros
        End Get
        Set(value As ObservableCollection(Of IMesero))
            _meseros = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _platos As ObservableCollection(Of IPlato)
    Public Property Platos As ObservableCollection(Of IPlato)
        Get
            Return _platos
        End Get
        Set(value As ObservableCollection(Of IPlato))
            _platos = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _selectedPlatos As ObservableCollection(Of IPlato) = New ObservableCollection(Of IPlato)
    Public Property SelectedPlatos As ObservableCollection(Of IPlato)
        Get
            Return _selectedPlatos
        End Get
        Set(value As ObservableCollection(Of IPlato))
            _selectedPlatos = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _selectedMetodo As String = "Efectivo"
    Public Property SelectedMetodo As String
        Get
            Return _selectedMetodo
        End Get
        Set(value As String)
            _selectedMetodo = value
            OnPropertyChanged()
            FieldTrigger(_tarjetaField)
        End Set
    End Property
    Private Property _selectedMesero As IMesero
    Public Property SelectedMesero As IMesero
        Get
            Return _selectedMesero
        End Get
        Set(value As IMesero)
            _selectedMesero = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _selectedMesa As IMesa
    Public Property SelectedMesa As IMesa
        Get
            Return _selectedMesa
        End Get
        Set(value As IMesa)
            _selectedMesa = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _cliente As String
    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _numeroTarjeta As String
    Public Property NumeroTarjeta As String
        Get
            Return _numeroTarjeta
        End Get
        Set(value As String)
            _numeroTarjeta = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _iva As Double
    Public Property Iva As Double
        Get
            Return _iva
        End Get
        Set(value As Double)
            _iva = value
            OnPropertyChanged()
        End Set
    End Property
    Private Property _subtotal As Double
    Public Property Subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
            OnPropertyChanged()
        End Set
    End Property

    Sub New(pedidoService As IPedidoService, platoService As IPlatoService, mesaService As IMesaService, meseroService As IMeseroService, tarjetaField As Grid)
        Me._platoService = platoService
        Me._mesaService = mesaService
        Me._meseroService = meseroService
        Me._pedidoService = pedidoService

        Me.Platos = platoService.Platos
        Me.Meseros = meseroService.Meseros
        Me.Mesas = mesaService.Mesas
        Me._tarjetaField = tarjetaField
        Me.FieldTrigger(Me._tarjetaField)
    End Sub

    Public Sub OnAddPlatoToCollection(plato As IPlato)
        Me._selectedPlatos.Add(plato)
        Me.GetSubtotal()
        Me.GetIva()
    End Sub

    Private Sub GetSubtotal()
        Me.Subtotal = Me._selectedPlatos.Aggregate(0.0, Function(acc, plato) acc + plato.Precio)
    End Sub

    Public Sub GetIva()
        Me.Iva = (Me.Subtotal * 0.15) + Me.Subtotal()
    End Sub

    Public Sub OnAddPedido()
        Try
            Me._pedidoService.AddPedido(New Pedido With {
            .Cliente = Me.Cliente,
            .Mesa = Me.SelectedMesa,
            .Mesero = Me.SelectedMesero,
            .MetodoPago = Me.SelectedMetodo,
            .NumeroTarjeta = Me.NumeroTarjeta,
            .Platos = Me.SelectedPlatos,
            .Subtotal = Me.Subtotal,
            .Iva = Me.Iva,
            .Fecha = Date.Now
        })
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FieldTrigger(field As Grid)
        Me.NumeroTarjeta = ""
        If SelectedMetodo = "Efectivo" Then
            field.Visibility = Visibility.Collapsed
        Else
            field.Visibility = Visibility.Visible
        End If
    End Sub
End Class
