Public Class Plato
    Implements IPlato

    Private _nombre As String
    Private _precio As Double

    Public Property Nombre As String Implements IPlato.Nombre
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property Precio As Double Implements IPlato.Precio
        Get
            Return Me._precio
        End Get
        Set(value As Double)
            Me._precio = value
        End Set
    End Property
End Class
