﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExamenDeMedioCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Prob1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Prob2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Prob3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Prob4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Prob5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_menu = New System.Windows.Forms.Label()
        Me.lbl_mat = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_grupo = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.ExamenOrdinarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExamenDeMedioCursoToolStripMenuItem, Me.ExamenOrdinarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExamenDeMedioCursoToolStripMenuItem
        '
        Me.ExamenDeMedioCursoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Prob1ToolStripMenuItem, Me.Prob2ToolStripMenuItem, Me.Prob3ToolStripMenuItem, Me.Prob4ToolStripMenuItem, Me.Prob5ToolStripMenuItem})
        Me.ExamenDeMedioCursoToolStripMenuItem.Name = "ExamenDeMedioCursoToolStripMenuItem"
        Me.ExamenDeMedioCursoToolStripMenuItem.Size = New System.Drawing.Size(148, 20)
        Me.ExamenDeMedioCursoToolStripMenuItem.Text = "Examen de Medio Curso"
        '
        'Prob1ToolStripMenuItem
        '
        Me.Prob1ToolStripMenuItem.Name = "Prob1ToolStripMenuItem"
        Me.Prob1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Prob1ToolStripMenuItem.Text = "Prob 1"
        '
        'Prob2ToolStripMenuItem
        '
        Me.Prob2ToolStripMenuItem.Name = "Prob2ToolStripMenuItem"
        Me.Prob2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Prob2ToolStripMenuItem.Text = "Prob 2"
        '
        'Prob3ToolStripMenuItem
        '
        Me.Prob3ToolStripMenuItem.Name = "Prob3ToolStripMenuItem"
        Me.Prob3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Prob3ToolStripMenuItem.Text = "Prob 3"
        '
        'Prob4ToolStripMenuItem
        '
        Me.Prob4ToolStripMenuItem.Name = "Prob4ToolStripMenuItem"
        Me.Prob4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Prob4ToolStripMenuItem.Text = "Prob 4"
        '
        'Prob5ToolStripMenuItem
        '
        Me.Prob5ToolStripMenuItem.Name = "Prob5ToolStripMenuItem"
        Me.Prob5ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Prob5ToolStripMenuItem.Text = "Prob 5"
        '
        'lbl_menu
        '
        Me.lbl_menu.AutoSize = True
        Me.lbl_menu.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu.Location = New System.Drawing.Point(212, 53)
        Me.lbl_menu.Name = "lbl_menu"
        Me.lbl_menu.Size = New System.Drawing.Size(186, 29)
        Me.lbl_menu.TabIndex = 1
        Me.lbl_menu.Text = "Menú Principal"
        '
        'lbl_mat
        '
        Me.lbl_mat.AutoSize = True
        Me.lbl_mat.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mat.Location = New System.Drawing.Point(70, 138)
        Me.lbl_mat.Name = "lbl_mat"
        Me.lbl_mat.Size = New System.Drawing.Size(215, 27)
        Me.lbl_mat.TabIndex = 2
        Me.lbl_mat.Text = "Matrícula: 1897759"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(70, 186)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(255, 27)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre: Héctor Flores"
        '
        'lbl_grupo
        '
        Me.lbl_grupo.AutoSize = True
        Me.lbl_grupo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grupo.Location = New System.Drawing.Point(70, 238)
        Me.lbl_grupo.Name = "lbl_grupo"
        Me.lbl_grupo.Size = New System.Drawing.Size(133, 27)
        Me.lbl_grupo.TabIndex = 4
        Me.lbl_grupo.Text = "Grupo: 009"
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(466, 238)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(144, 33)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'ExamenOrdinarioToolStripMenuItem
        '
        Me.ExamenOrdinarioToolStripMenuItem.Name = "ExamenOrdinarioToolStripMenuItem"
        Me.ExamenOrdinarioToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.ExamenOrdinarioToolStripMenuItem.Text = "Examen Ordinario"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 310)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_grupo)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_mat)
        Me.Controls.Add(Me.lbl_menu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.Text = "Examen de Medio Curso"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExamenDeMedioCursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Prob1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Prob2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Prob3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Prob4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Prob5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_menu As Label
    Friend WithEvents lbl_mat As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_grupo As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents ExamenOrdinarioToolStripMenuItem As ToolStripMenuItem
End Class