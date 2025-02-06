﻿Public Class PlatoPage
    Private Property _mainViewModel As PlatoViewModel

    Sub New(platoService As IPlatoService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._mainViewModel = New PlatoViewModel(platoService)
        ' Events
        AddHandler Me._mainViewModel.ShowMessage, AddressOf MessageHandler
        ' Context
        Me.DataContext = Me._mainViewModel
    End Sub

    Sub MessageHandler(message As String)
        MessageBox.Show(message)
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim nombre As String = TextNombre.Text.Trim()
            If Not nombre <> "" Then
                Throw New Exception("El nombre del plato no puede estar vacio")
            End If

            Dim precio As Double = Double.Parse(TextPrecio.Text)

            Me._mainViewModel.OnAddPlato(nombre, precio)
            Me.ClearForm()
        Catch ex As FormatException
            MessageHandler("El precio debe ser un valor numerico")
        Catch ex As Exception
            MessageHandler(ex.Message())
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim platoIndex As Int32 = ListBoxPlatos.SelectedIndex
            If platoIndex <= 0 Then
                Throw New Exception("Debe seleccionar primero un elemento")
            End If

            Me._mainViewModel.OnDeletePlato(platoIndex)
            Me.ClearForm()
        Catch ex As Exception
            MessageHandler(ex.Message())
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
