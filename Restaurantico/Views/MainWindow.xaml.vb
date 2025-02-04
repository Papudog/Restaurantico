Imports System.Collections.ObjectModel

Class MainWindow
    Private Property _platoController As PlatoController
    Public Property Platos As ObservableCollection(Of IPlato)

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Controller
        Me._platoController = New PlatoController(New PlatoService)

        ' Context
        Me.Platos = GetAllPlatos()
        Me.DataContext = Me
    End Sub

    Private Sub SidebarToggle_Click(sender As Object, e As RoutedEventArgs)
        If SidebarMenu.Visibility = Visibility.Collapsed Then
            SidebarMenu.Visibility = Visibility.Visible
        Else
            SidebarMenu.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Function GetAllPlatos() As ObservableCollection(Of IPlato)
        Return _platoController.OnGetAllPlatos()
    End Function

    Private Sub ButtonGuardar_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim nombre As String = TextNombre.Text.Trim()
            If Not nombre <> "" Then
                Throw New Exception("El nombre del plato no puede estar vacio")
            End If

            Dim precio As Double = Double.Parse(TextPrecio.Text)

            Me._platoController.OnAddPlato(New Plato With {.Nombre = nombre, .Precio = precio})
            Me.ClearForm()
        Catch ex As FormatException
            MessageBox.Show("El precio debe ser un valor numerico")
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim platoIndex As Int32 = ListBoxPlatos.SelectedIndex
            If platoIndex <= 0 Then
                Throw New Exception("Debe seleccionar primero un elemento")
            End If

            Me._platoController.OnDeletePlato(platoIndex)
            Me.ClearForm()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As RoutedEventArgs)
        Me.ClearForm()
    End Sub

    Sub ClearForm()
        Me.TextNombre.Clear()
        Me.TextPrecio.Clear()
    End Sub
End Class