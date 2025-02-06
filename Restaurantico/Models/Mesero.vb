Public Class Mesero
    Implements IMesero

    Private Property _nombre As String
    Private Property _imagen As String
    Private Property _mesas As List(Of IMesa)

    Public Property Nombre As String Implements IMesero.Nombre
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property Imagen As String Implements IMesero.Imagen
        Get
            Return Me._imagen
        End Get
        Set(value As String)
            Me._imagen = value
        End Set
    End Property

    Public Property Mesas As List(Of IMesa) Implements IMesero.Mesas
        Get
            Return Me._mesas
        End Get
        Set(value As List(Of IMesa))
            Me._mesas = value
        End Set
    End Property
End Class
