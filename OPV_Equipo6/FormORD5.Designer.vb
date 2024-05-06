<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormORD5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmbGenero = New System.Windows.Forms.ComboBox()
        Me.CmbEscolaridad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.LstEstudiante = New System.Windows.Forms.ListBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbGenero
        '
        Me.CmbGenero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGenero.FormattingEnabled = True
        Me.CmbGenero.Location = New System.Drawing.Point(425, 86)
        Me.CmbGenero.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbGenero.Name = "CmbGenero"
        Me.CmbGenero.Size = New System.Drawing.Size(160, 32)
        Me.CmbGenero.TabIndex = 0
        '
        'CmbEscolaridad
        '
        Me.CmbEscolaridad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEscolaridad.FormattingEnabled = True
        Me.CmbEscolaridad.Location = New System.Drawing.Point(425, 143)
        Me.CmbEscolaridad.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbEscolaridad.Name = "CmbEscolaridad"
        Me.CmbEscolaridad.Size = New System.Drawing.Size(160, 32)
        Me.CmbEscolaridad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Género"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escolaridad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Matrícula"
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMatricula.Location = New System.Drawing.Point(105, 81)
        Me.TxtMatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(132, 32)
        Me.TxtMatricula.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(105, 129)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 32)
        Me.TxtNombre.TabIndex = 8
        '
        'TxtEdad
        '
        Me.TxtEdad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.Location = New System.Drawing.Point(105, 187)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(132, 32)
        Me.TxtEdad.TabIndex = 9
        '
        'LstEstudiante
        '
        Me.LstEstudiante.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEstudiante.FormattingEnabled = True
        Me.LstEstudiante.ItemHeight = 24
        Me.LstEstudiante.Location = New System.Drawing.Point(21, 373)
        Me.LstEstudiante.Margin = New System.Windows.Forms.Padding(4)
        Me.LstEstudiante.Name = "LstEstudiante"
        Me.LstEstudiante.Size = New System.Drawing.Size(564, 244)
        Me.LstEstudiante.TabIndex = 10
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(370, 199)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(215, 35)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar Información"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(485, 280)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(100, 34)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(49, 631)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(211, 47)
        Me.BtnBorrar.TabIndex = 13
        Me.BtnBorrar.Text = "Borrar registro"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Base de datos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(105, 285)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(360, 32)
        Me.TxtBuscar.TabIndex = 16
        '
        'btn_menu
        '
        Me.btn_menu.Location = New System.Drawing.Point(350, 631)
        Me.btn_menu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(211, 47)
        Me.btn_menu.TabIndex = 17
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'FormORD5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(609, 691)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LstEstudiante)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtMatricula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbEscolaridad)
        Me.Controls.Add(Me.CmbGenero)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormORD5"
        Me.Text = "Estudiantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbGenero As ComboBox
    Friend WithEvents CmbEscolaridad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMatricula As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents LstEstudiante As ListBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents btn_menu As Button
End Class
