<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMC3
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
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(487, 223)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(210, 33)
        Me.btn_menu.TabIndex = 17
        Me.btn_menu.Text = "Regresar al menú"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_verificar
        '
        Me.btn_verificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verificar.Location = New System.Drawing.Point(524, 165)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(144, 33)
        Me.btn_verificar.TabIndex = 16
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(622, 100)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 29)
        Me.txt_numero.TabIndex = 15
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(24, 102)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_info.Size = New System.Drawing.Size(555, 27)
        Me.lbl_info.TabIndex = 14
        Me.lbl_info.Text = "Teclea un numero para decirte el dia de la semana"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(113, 32)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(142, 29)
        Me.lbl_titulo.TabIndex = 13
        Me.lbl_titulo.Text = "Problema 3"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.Location = New System.Drawing.Point(33, 170)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_dia.Size = New System.Drawing.Size(0, 27)
        Me.lbl_dia.TabIndex = 18
        '
        'FormMC3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 287)
        Me.Controls.Add(Me.lbl_dia)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "FormMC3"
        Me.Text = "Prob 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_verificar As Button
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_dia As Label
End Class
