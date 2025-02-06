Public Class Mesa
    Implements IMesa

    Private Property _numero As Int32
    Private Property _mesero As IMesero

    Public Property Numero As Integer Implements IMesa.Numero
        Get
            Return Me._numero
        End Get
        Set(value As Integer)
            Me._numero = value
        End Set
    End Property

    Public Property Mesero As IMesero Implements IMesa.Mesero
        Get
            Return Me._mesero
        End Get
        Set(value As IMesero)
            Me._mesero = value
        End Set
    End Property
End Class
