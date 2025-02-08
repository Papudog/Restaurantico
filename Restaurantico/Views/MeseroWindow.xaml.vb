Imports System.Collections.ObjectModel

Public Class MeseroWindow

    Private Property _meseroViewModel As MeseroViewModel
    Sub New(meseroService As IMeseroService)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._meseroViewModel = New MeseroViewModel(meseroService)
        Me.DataContext = Me._meseroViewModel
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As RoutedEventArgs)

        Try
            Dim nombre As String = TextNombre.Text.Trim()
            If Not nombre <> "" Then
                Throw New Exception("El nombre del plato no puede estar vacio")
            End If

            Me._meseroViewModel.OnAddMesero(New Mesero With {.Nombre = nombre, .Mesas = New ObservableCollection(Of IMesa)})
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
