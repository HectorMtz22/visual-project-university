
Public Class FormPIA2

    ' Clase para representar un gasto
    Private Class Gasto
        Public Property Categoria As String
        Public Property Monto As Decimal

        Public Sub New(categoria As String, monto As Decimal)
            Me.Categoria = categoria
            Me.Monto = monto
        End Sub
    End Class

    ' Lista para almacenar los gastos
    Dim gastos As New List(Of Gasto)

    Private Sub btnAgregarGasto_Click(sender As Object, e As EventArgs) Handles btnAgregarGasto.Click
        ' Obtener la información ingresada por el usuario
        Dim categoria As String = txtCategoria.Text.Trim()
        Dim monto As Decimal
        ' Verificar si se ingresó un monto válido
        If Not Decimal.TryParse(txtmonto.Text, monto) OrElse monto <= 0 Then
            MsgBox("Por favor, ingrese un monto válido.")
            Return
        End If

        ' Crear un nuevo objeto Gasto y agregarlo a la lista
        Dim nuevoGasto As New Gasto(categoria, monto)
        gastos.Add(nuevoGasto)

        ' Limpiar los campos de texto después de guardar
        LimpiarCampos()

        ' Actualizar el DataGridView con los gastos registrados 
        ActualizarDataGridView()

        ' Actualizar la suma total de los gastos 
        CalcularTotalGastos()
    End Sub

    Private Sub LimpiarCampos()

        ' Limpiar los campos de texto
        txtmonto.Clear()
    End Sub
    Private Sub ActualizarDataGridView()

        ' Limpiar el contenido actual del DataGridView
        DataGridView1.Rows.Clear()

        ' Agregar los gastos a DataGridView

        For Each gasto In gastos
            DataGridView1.Rows.Add(gasto.Categoria, gasto.Monto)
        Next
    End Sub

    Private Sub CalcularTotalGastos()

        ' Calcular la suma total de los gastos

        Dim total As Decimal = 0

        For Each gasto In gastos
            total += gasto.Monto
        Next
        ' Mostrar la suma total en el TextBox correspondiente
        txttotalgastos.Text = total.ToString("C")
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class