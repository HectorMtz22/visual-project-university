<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMC1
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
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_calificacion = New System.Windows.Forms.TextBox()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(38, 96)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_info.Size = New System.Drawing.Size(327, 27)
        Me.lbl_info.TabIndex = 4
        Me.lbl_info.Text = "Introduce la nota del alumno:"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(196, 30)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(142, 29)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "Problema 1"
        '
        'txt_calificacion
        '
        Me.txt_calificacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_calificacion.Location = New System.Drawing.Point(371, 96)
        Me.txt_calificacion.Name = "txt_calificacion"
        Me.txt_calificacion.Size = New System.Drawing.Size(100, 29)
        Me.txt_calificacion.TabIndex = 5
        '
        'btn_verificar
        '
        Me.btn_verificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verificar.Location = New System.Drawing.Point(576, 26)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(144, 33)
        Me.btn_verificar.TabIndex = 6
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(510, 94)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(210, 33)
        Me.btn_menu.TabIndex = 7
        Me.btn_menu.Text = "Regresar al menú"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultado.Location = New System.Drawing.Point(314, 158)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_resultado.Size = New System.Drawing.Size(0, 27)
        Me.lbl_resultado.TabIndex = 8
        '
        'FormMC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 206)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.txt_calificacion)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "FormMC1"
        Me.Text = "Prob 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_calificacion As TextBox
    Friend WithEvents btn_verificar As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents lbl_resultado As Label
End Class
