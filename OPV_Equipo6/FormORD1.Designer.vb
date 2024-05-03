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
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_multi = New System.Windows.Forms.Button()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora básica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero 2"
        '
        'txtnum1
        '
        Me.txtnum1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum1.Location = New System.Drawing.Point(128, 114)
        Me.txtnum1.Multiline = True
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(140, 31)
        Me.txtnum1.TabIndex = 4
        '
        'txtnum2
        '
        Me.txtnum2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum2.Location = New System.Drawing.Point(128, 168)
        Me.txtnum2.Multiline = True
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(140, 31)
        Me.txtnum2.TabIndex = 5
        '
        'txtresultado
        '
        Me.txtresultado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresultado.Location = New System.Drawing.Point(24, 290)
        Me.txtresultado.Multiline = True
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(320, 35)
        Me.txtresultado.TabIndex = 6
        '
        'btn_suma
        '
        Me.btn_suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suma.Location = New System.Drawing.Point(291, 91)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(53, 31)
        Me.btn_suma.TabIndex = 7
        Me.btn_suma.Text = "+"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_div.Location = New System.Drawing.Point(291, 202)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(53, 31)
        Me.btn_div.TabIndex = 8
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'btn_multi
        '
        Me.btn_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multi.Location = New System.Drawing.Point(291, 165)
        Me.btn_multi.Name = "btn_multi"
        Me.btn_multi.Size = New System.Drawing.Size(53, 31)
        Me.btn_multi.TabIndex = 9
        Me.btn_multi.Text = "*"
        Me.btn_multi.UseVisualStyleBackColor = True
        '
        'btn_resta
        '
        Me.btn_resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resta.Location = New System.Drawing.Point(291, 128)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(53, 31)
        Me.btn_resta.TabIndex = 10
        Me.btn_resta.Text = "-"
        Me.btn_resta.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(124, 353)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(144, 31)
        Me.btn_menu.TabIndex = 15
        Me.btn_menu.Text = "Menú principal"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'FormORD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(382, 405)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_resta)
        Me.Controls.Add(Me.btn_multi)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_suma)
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
    Friend WithEvents btn_suma As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_multi As Button
    Friend WithEvents btn_resta As Button
    Friend WithEvents btn_menu As Button
End Class
