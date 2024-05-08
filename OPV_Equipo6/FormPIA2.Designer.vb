<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPIA2
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
        Me.btnAgregarGasto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttotalgastos = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGasto.Location = New System.Drawing.Point(252, 57)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(108, 51)
        Me.btnAgregarGasto.TabIndex = 0
        Me.btnAgregarGasto.Text = "Agregar gasto"
        Me.btnAgregarGasto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categoría:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gastos:"
        '
        'txttotalgastos
        '
        Me.txttotalgastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalgastos.Location = New System.Drawing.Point(240, 421)
        Me.txttotalgastos.Multiline = True
        Me.txttotalgastos.Name = "txttotalgastos"
        Me.txttotalgastos.ReadOnly = True
        Me.txttotalgastos.Size = New System.Drawing.Size(120, 30)
        Me.txttotalgastos.TabIndex = 4
        '
        'txtmonto
        '
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(104, 42)
        Me.txtmonto.Multiline = True
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(120, 34)
        Me.txtmonto.TabIndex = 5
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.FormattingEnabled = True
        Me.txtCategoria.Items.AddRange(New Object() {"Alimentos", "Educacion", "Salud", "Ropa", "Servicios", "Transporte", "Tarjeta"})
        Me.txtCategoria.Location = New System.Drawing.Point(104, 82)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(120, 32)
        Me.txtCategoria.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.categoria, Me.monto})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(350, 273)
        Me.DataGridView1.TabIndex = 6
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(10, 422)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(131, 29)
        Me.btnmenu.TabIndex = 7
        Me.btnmenu.Text = "Menú principal"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Libro de gastos"
        '
        'categoria
        '
        Me.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.categoria.HeaderText = "Categoría"
        Me.categoria.Name = "categoria"
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        '
        'FormPIA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(372, 463)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txttotalgastos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarGasto)
        Me.Name = "FormPIA2"
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarGasto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttotalgastos As TextBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtCategoria As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
End Class
