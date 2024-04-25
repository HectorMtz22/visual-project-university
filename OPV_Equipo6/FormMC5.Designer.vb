<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMC5
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
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_tabla = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(684, 393)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(184, 33)
        Me.btn_menu.TabIndex = 29
        Me.btn_menu.Text = "Regresar al menú"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_verificar
        '
        Me.btn_verificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verificar.Location = New System.Drawing.Point(712, 339)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(144, 33)
        Me.btn_verificar.TabIndex = 28
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(37, 104)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_info.Size = New System.Drawing.Size(624, 27)
        Me.lbl_info.TabIndex = 27
        Me.lbl_info.Text = "Introduce un número para mostrar su tabla de multiplicar"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(144, 36)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(142, 29)
        Me.lbl_titulo.TabIndex = 26
        Me.lbl_titulo.Text = "Problema 5"
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(712, 104)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(144, 29)
        Me.txt_numero.TabIndex = 30
        '
        'txt_tabla
        '
        Me.txt_tabla.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabla.Location = New System.Drawing.Point(42, 155)
        Me.txt_tabla.Multiline = True
        Me.txt_tabla.Name = "txt_tabla"
        Me.txt_tabla.ReadOnly = True
        Me.txt_tabla.Size = New System.Drawing.Size(619, 269)
        Me.txt_tabla.TabIndex = 31
        '
        'FormMC5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 450)
        Me.Controls.Add(Me.txt_tabla)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "FormMC5"
        Me.Text = "Prob 5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_verificar As Button
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_tabla As TextBox
End Class
