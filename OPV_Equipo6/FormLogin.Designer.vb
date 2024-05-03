<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_mostrar_pass = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_mostrar_pass
        '
        Me.btn_mostrar_pass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_mostrar_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mostrar_pass.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar_pass.Location = New System.Drawing.Point(316, 300)
        Me.btn_mostrar_pass.Name = "btn_mostrar_pass"
        Me.btn_mostrar_pass.Size = New System.Drawing.Size(266, 33)
        Me.btn_mostrar_pass.TabIndex = 13
        Me.btn_mostrar_pass.Text = "Olvidaste tu contraseña?"
        Me.btn_mostrar_pass.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Location = New System.Drawing.Point(438, 240)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(144, 33)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "Ingresar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(394, 106)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(188, 29)
        Me.txt_user.TabIndex = 10
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(237, 106)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_user.Size = New System.Drawing.Size(94, 27)
        Me.lbl_user.TabIndex = 9
        Me.lbl_user.Text = "Usuario"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(189, 45)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(198, 29)
        Me.lbl_titulo.TabIndex = 8
        Me.lbl_titulo.Text = "Inicio de Sesión"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(237, 160)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_pass.Size = New System.Drawing.Size(136, 27)
        Me.lbl_pass.TabIndex = 13
        Me.lbl_pass.Text = "Contraseña"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(394, 160)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(188, 29)
        Me.txt_password.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OPV_Equipo6.My.Resources.Resources.hecker
        Me.PictureBox1.Location = New System.Drawing.Point(37, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(612, 371)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.btn_mostrar_pass)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_titulo)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "FormLogin"
        Me.Text = "Inicio de Sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_mostrar_pass As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_pass As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
