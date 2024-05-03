<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormORD3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btncompletar = New System.Windows.Forms.Button()
        Me.lsttareas = New System.Windows.Forms.ListBox()
        Me.txttareas = New System.Windows.Forms.TextBox()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestionar tareas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tareas:"
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(580, 50)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(104, 39)
        Me.btnagregar.TabIndex = 2
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(580, 95)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 39)
        Me.btneliminar.TabIndex = 3
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btncompletar
        '
        Me.btncompletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompletar.Location = New System.Drawing.Point(580, 140)
        Me.btncompletar.Name = "btncompletar"
        Me.btncompletar.Size = New System.Drawing.Size(104, 37)
        Me.btncompletar.TabIndex = 4
        Me.btncompletar.Text = "Completar"
        Me.btncompletar.UseVisualStyleBackColor = True
        '
        'lsttareas
        '
        Me.lsttareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsttareas.FormattingEnabled = True
        Me.lsttareas.ItemHeight = 24
        Me.lsttareas.Location = New System.Drawing.Point(39, 128)
        Me.lsttareas.Name = "lsttareas"
        Me.lsttareas.Size = New System.Drawing.Size(460, 292)
        Me.lsttareas.TabIndex = 5
        '
        'txttareas
        '
        Me.txttareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttareas.Location = New System.Drawing.Point(39, 77)
        Me.txttareas.Multiline = True
        Me.txttareas.Name = "txttareas"
        Me.txttareas.Size = New System.Drawing.Size(262, 35)
        Me.txttareas.TabIndex = 6
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(540, 354)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(144, 31)
        Me.btn_menu.TabIndex = 15
        Me.btn_menu.Text = "Menú principal"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'FormORD3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 450)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.txttareas)
        Me.Controls.Add(Me.lsttareas)
        Me.Controls.Add(Me.btncompletar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormORD3"
        Me.Text = "FormORD3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btncompletar As Button
    Friend WithEvents lsttareas As ListBox
    Friend WithEvents txttareas As TextBox
    Friend WithEvents btn_menu As Button
End Class
