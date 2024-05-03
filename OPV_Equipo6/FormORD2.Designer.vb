<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormORD2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.btnconvertir = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.rb_cel_to_far = New System.Windows.Forms.RadioButton()
        Me.rb_far_to_cel = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Unidades de medición"
        '
        'txtresultado
        '
        Me.txtresultado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresultado.Location = New System.Drawing.Point(283, 154)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.ReadOnly = True
        Me.txtresultado.Size = New System.Drawing.Size(224, 32)
        Me.txtresultado.TabIndex = 8
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.Location = New System.Drawing.Point(57, 154)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(164, 32)
        Me.txtvalor.TabIndex = 7
        '
        'btnconvertir
        '
        Me.btnconvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvertir.Location = New System.Drawing.Point(372, 221)
        Me.btnconvertir.Name = "btnconvertir"
        Me.btnconvertir.Size = New System.Drawing.Size(135, 31)
        Me.btnconvertir.TabIndex = 13
        Me.btnconvertir.Text = "Convertir"
        Me.btnconvertir.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(363, 262)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(144, 31)
        Me.btn_menu.TabIndex = 14
        Me.btn_menu.Text = "Menú principal"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'rb_cel_to_far
        '
        Me.rb_cel_to_far.AutoSize = True
        Me.rb_cel_to_far.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_cel_to_far.Location = New System.Drawing.Point(57, 226)
        Me.rb_cel_to_far.Name = "rb_cel_to_far"
        Me.rb_cel_to_far.Size = New System.Drawing.Size(207, 26)
        Me.rb_cel_to_far.TabIndex = 15
        Me.rb_cel_to_far.TabStop = True
        Me.rb_cel_to_far.Text = "Celsius -> Fahrenheit"
        Me.rb_cel_to_far.UseVisualStyleBackColor = True
        '
        'rb_far_to_cel
        '
        Me.rb_far_to_cel.AutoCheck = False
        Me.rb_far_to_cel.AutoSize = True
        Me.rb_far_to_cel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_far_to_cel.Location = New System.Drawing.Point(57, 262)
        Me.rb_far_to_cel.Name = "rb_far_to_cel"
        Me.rb_far_to_cel.Size = New System.Drawing.Size(207, 26)
        Me.rb_far_to_cel.TabIndex = 16
        Me.rb_far_to_cel.TabStop = True
        Me.rb_far_to_cel.Text = "Fahrenheit -> Celsius"
        Me.rb_far_to_cel.UseVisualStyleBackColor = True
        '
        'FormORD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 317)
        Me.Controls.Add(Me.rb_far_to_cel)
        Me.Controls.Add(Me.rb_cel_to_far)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btnconvertir)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormORD2"
        Me.Text = "FormORD2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents btnconvertir As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents rb_cel_to_far As RadioButton
    Friend WithEvents rb_far_to_cel As RadioButton
End Class
