Public Class FormORD5
    Private Class Estudiante
        Public Property Matricula As String
        Public Property Nombre As String
        Public Property Edad As Integer
        Public Property Genero As String
        Public Property Escolaridad As String
    End Class

    Private estudiantes As New List(Of Estudiante)()
    Private Sub LimpiarCampos()
        TxtMatricula.Clear()
        TxtNombre.Clear()
        TxtEdad.Clear()
        CmbGenero.SelectedIndex = -1
        CmbEscolaridad.SelectedIndex = -1
    End Sub

    Private Sub ActualizarListaEstudiante()
        LstEstudiante.Items.Clear()
        For Each estudiante In estudiantes
            Dim detalleEstudiante As String = String.Format("Matrícula: {0}, Nombre: {1}, Edad: {2}, Género: {3}, Escolaridad: {4}", estudiante.Matricula, estudiante.Nombre, estudiante.Edad, estudiante.Genero, estudiante.Escolaridad)
            LstEstudiante.Items.Add(detalleEstudiante)
        Next
    End Sub




    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Obtener la información ingresada por el usuario
        Dim matricula As String = TxtMatricula.Text.Trim()
        Dim nombre As String = TxtNombre.Text.Trim()
        Dim edad As Integer
        If Not Integer.TryParse(TxtEdad.Text, edad) Then
            MessageBox.Show("Por favor, ingrese una edad válida.")
            Return
        End If
        Dim genero As String = CmbGenero.SelectedItem.ToString()
        Dim escolaridad As String = CmbEscolaridad.SelectedItem.ToString()

        ' Validar que se haya ingresado la información requerida
        If String.IsNullOrEmpty(matricula) OrElse String.IsNullOrEmpty(nombre) OrElse edad <= 0 OrElse String.IsNullOrEmpty(genero) OrElse String.IsNullOrEmpty(escolaridad) Then
            MessageBox.Show("Por favor, ingrese toda la información requerida.")
            Return
        End If

        If CmbGenero.SelectedIndex = -1 OrElse CmbEscolaridad.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una opción válida para género y escolaridad.")
            Return
        End If

        ' Crear un nuevo objeto Estudiante y agregarlo a la lista
        Dim nuevoEstudiante As New Estudiante()
        nuevoEstudiante.Matricula = matricula
        nuevoEstudiante.Nombre = nombre
        nuevoEstudiante.Edad = edad
        nuevoEstudiante.Genero = genero
        nuevoEstudiante.Escolaridad = escolaridad
        estudiantes.Add(nuevoEstudiante)

        ' Actualizar la lista y limpiar campos
        ActualizarListaEstudiante()
        LimpiarCampos()

        MessageBox.Show("Información agregada correctamente.")
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim nombre As String = TxtBuscar.Text.Trim()
        If nombre = "" Then
            MessageBox.Show("Por favor, ingrese un nombre para buscar.")
            Return
        End If

        Dim encontrado As Boolean = False
        For Each estudiante In estudiantes
            If estudiante.Nombre.ToLower() = nombre.ToLower() Then
                MessageBox.Show($"Nombre: {estudiante.Nombre}" & vbNewLine & $"Matrícula: {estudiante.Matricula}" & vbNewLine & $"Edad: {estudiante.Edad}" & vbNewLine & $"Genero: {estudiante.Genero}" & vbNewLine & $"Escolaridad: {estudiante.Escolaridad}")
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            MessageBox.Show("No se encontró ningún estudiante con ese nombre.")
        End If
    End Sub



    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim matriculaABorrar As String = TxtBuscar.Text.Trim()
        Dim estudianteABorrar As Estudiante = estudiantes.FirstOrDefault(Function(x) x.Matricula = matriculaABorrar)
        If estudianteABorrar IsNot Nothing Then
            estudiantes.Remove(estudianteABorrar)
            ActualizarListaEstudiante()
            MessageBox.Show("Registro borrado correctamente.")
        Else
            MessageBox.Show("No se encontró el estudiante con esa matrícula.")
        End If
    End Sub

    Private Sub FormORD5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Poblar el ComboBox de Género
        CmbGenero.Items.Add("Femenino")
        CmbGenero.Items.Add("Masculino")
        CmbGenero.Items.Add("No especificado")

        ' Poblar el ComboBox de Escolaridad
        CmbEscolaridad.Items.Add("Primaria")
        CmbEscolaridad.Items.Add("Secundaria")
        CmbEscolaridad.Items.Add("Preparatoria")
        CmbEscolaridad.Items.Add("Universidad")

        ' Seleccionar el primer elemento para asegurarse de que haya una selección por defecto
        CmbGenero.SelectedIndex = 0
        CmbEscolaridad.SelectedIndex = 0


    End Sub
End Class