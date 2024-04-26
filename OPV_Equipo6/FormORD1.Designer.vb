<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormORD1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btnmulti = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora básica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero 2"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(173, 126)
        Me.txtnum1.Multiline = True
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(140, 31)
        Me.txtnum1.TabIndex = 4
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(173, 180)
        Me.txtnum2.Multiline = True
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(140, 31)
        Me.txtnum2.TabIndex = 5
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(69, 302)
        Me.txtresultado.Multiline = True
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(350, 35)
        Me.txtresultado.TabIndex = 6
        '
        'btnsuma
        '
        Me.btnsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsuma.Location = New System.Drawing.Point(516, 118)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(135, 31)
        Me.btnsuma.TabIndex = 7
        Me.btnsuma.Text = "Suma"
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiv.Location = New System.Drawing.Point(516, 229)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(135, 31)
        Me.btndiv.TabIndex = 8
        Me.btndiv.Text = "División"
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btnmulti
        '
        Me.btnmulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmulti.Location = New System.Drawing.Point(516, 192)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(135, 31)
        Me.btnmulti.TabIndex = 9
        Me.btnmulti.Text = "Multiplicación"
        Me.btnmulti.UseVisualStyleBackColor = True
        '
        'btnresta
        '
        Me.btnresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresta.Location = New System.Drawing.Point(516, 155)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(135, 31)
        Me.btnresta.TabIndex = 10
        Me.btnresta.Text = "Resta"
        Me.btnresta.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(507, 369)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(144, 31)
        Me.btnmenu.TabIndex = 15
        Me.btnmenu.Text = "Menú principal"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'FormORD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 450)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnresta)
        Me.Controls.Add(Me.btnmulti)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnsuma)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormORD1"
        Me.Text = "FormORD1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents btnsuma As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents btnmenu As Button
End Class
