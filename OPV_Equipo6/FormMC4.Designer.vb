<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMC4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_numeros = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_numeros
        '
        Me.lbl_numeros.AutoSize = True
        Me.lbl_numeros.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numeros.Location = New System.Drawing.Point(37, 173)
        Me.lbl_numeros.Name = "lbl_numeros"
        Me.lbl_numeros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_numeros.Size = New System.Drawing.Size(226, 27)
        Me.lbl_numeros.TabIndex = 24
        Me.lbl_numeros.Text = "(Da clic en Verificar)"
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(514, 167)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(210, 33)
        Me.btn_menu.TabIndex = 23
        Me.btn_menu.Text = "Regresar al menú"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_verificar
        '
        Me.btn_verificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verificar.Location = New System.Drawing.Point(552, 45)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(144, 33)
        Me.btn_verificar.TabIndex = 22
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(28, 105)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_info.Size = New System.Drawing.Size(432, 27)
        Me.lbl_info.TabIndex = 20
        Me.lbl_info.Text = "Números del 10 al 1 usando ciclo while"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(117, 35)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(142, 29)
        Me.lbl_titulo.TabIndex = 19
        Me.lbl_titulo.Text = "Problema 4"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(552, 103)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(144, 33)
        Me.btn_limpiar.TabIndex = 25
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'FormMC4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.lbl_numeros)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "FormMC4"
        Me.Text = "Prob 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_numeros As Label
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_verificar As Button
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents btn_limpiar As Button
End Class
