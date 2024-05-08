<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPIA5
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
        Me.nudLongitud = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        CType(Me.nudLongitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿De cuantos digitos se creara tu contraseña?"
        '
        'nudLongitud
        '
        Me.nudLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLongitud.Location = New System.Drawing.Point(446, 13)
        Me.nudLongitud.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLongitud.Name = "nudLongitud"
        Me.nudLongitud.Size = New System.Drawing.Size(90, 31)
        Me.nudLongitud.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña creada:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(168, 60)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.Size = New System.Drawing.Size(368, 31)
        Me.txtContraseña.TabIndex = 3
        '
        'btn_generate
        '
        Me.btn_generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Location = New System.Drawing.Point(356, 115)
        Me.btn_generate.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(121, 36)
        Me.btn_generate.TabIndex = 4
        Me.btn_generate.Text = "Generar"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(38, 115)
        Me.btn_menu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(189, 36)
        Me.btn_menu.TabIndex = 5
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'FormPIA5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 173)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudLongitud)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormPIA5"
        Me.Text = "FormPIA5"
        CType(Me.nudLongitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nudLongitud As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btn_generate As Button
    Friend WithEvents btn_menu As Button
End Class
