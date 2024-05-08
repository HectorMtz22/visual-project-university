<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPIA4
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
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btncalcularedad = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FECHA DE NACIMIENTO"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(15, 86)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(291, 27)
        Me.dtpFechaNacimiento.TabIndex = 1
        '
        'btncalcularedad
        '
        Me.btncalcularedad.Location = New System.Drawing.Point(210, 145)
        Me.btncalcularedad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncalcularedad.Name = "btncalcularedad"
        Me.btncalcularedad.Size = New System.Drawing.Size(96, 27)
        Me.btncalcularedad.TabIndex = 2
        Me.btncalcularedad.Text = "Calcular Edad"
        Me.btncalcularedad.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Location = New System.Drawing.Point(15, 145)
        Me.btn_menu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(96, 27)
        Me.btn_menu.TabIndex = 3
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'FormPIA4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(325, 192)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btncalcularedad)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormPIA4"
        Me.Text = "FormPIA4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents btncalcularedad As Button
    Friend WithEvents btn_menu As Button
End Class
