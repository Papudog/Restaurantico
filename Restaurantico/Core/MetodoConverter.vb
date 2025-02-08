Imports System.Globalization

Public Class MetodoConverter
    Implements IValueConverter

    'value es el valor de la propiedad que se esta bindeando (SelectedMetodo)
    'targetType es el tipo de la propiedad que se esta bindeando en este caso Boolean
    'parameter es el valor que se pasa como parametro en el binding = "Efectivo o Tarjeta"
    'retorna True si el value es igual al parametro
    'esta funcion se ejecuta cuando se bindea la propiedad SelectedMetodo a un control es la primera que se ejecuta cuando inicializa el control
    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Return value IsNot Nothing AndAlso value.ToString = parameter.ToString
    End Function

    'value es el valor del estado del control (True o False)
    'targetType es el tipo de la propiedad que se esta bindeando en este caso String
    'parameter es el valor que se pasa como parametro en el binding = "Efectivo o Tarjeta"
    'retorna el valor del parametro si el value es True
    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        If value Then
            Return parameter
        End If
        Return Binding.DoNothing
    End Function
End Class