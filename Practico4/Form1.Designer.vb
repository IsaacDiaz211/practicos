<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PequeñoFormulario
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
        LModificar = New Label()
        LDNI = New Label()
        LNyA = New Label()
        LApellido = New Label()
        LNombre = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        Panel1 = New Panel()
        CBMastercard = New CheckBox()
        TextBox1 = New TextBox()
        CBVisa = New CheckBox()
        LTdC = New Label()
        CBNaranja = New CheckBox()
        LTelefono = New Label()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        LNuevoCliente = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(191, 17)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(73, 20)
        LModificar.TabIndex = 0
        LModificar.Text = "modificar"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Location = New Point(14, 59)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(45, 20)
        LDNI.TabIndex = 1
        LDNI.Text = "* DNI"
        ' 
        ' LNyA
        ' 
        LNyA.AutoSize = True
        LNyA.Location = New Point(14, 17)
        LNyA.Name = "LNyA"
        LNyA.Size = New Size(137, 20)
        LNyA.TabIndex = 2
        LNyA.Text = "Nombre y apellido:"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(14, 102)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(76, 20)
        LApellido.TabIndex = 3
        LApellido.Text = "* Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(16, 141)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(74, 20)
        LNombre.TabIndex = 4
        LNombre.Text = "* Nombre"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(168, 52)
        TDni.Name = "TDni"
        TDni.Size = New Size(125, 27)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(168, 95)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(125, 27)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(168, 134)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(125, 27)
        TNombre.TabIndex = 7
        ' 
        ' BGuardar
        ' 
        BGuardar.Image = My.Resources.Resources.guardar
        BGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BGuardar.Location = New Point(193, 462)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(129, 62)
        BGuardar.TabIndex = 8
        BGuardar.Text = "Guardar"
        BGuardar.TextAlign = ContentAlignment.MiddleRight
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Image = My.Resources.Resources.eliminar
        BEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BEliminar.Location = New Point(12, 461)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(129, 63)
        BEliminar.TabIndex = 9
        BEliminar.Text = "Eliminar"
        BEliminar.TextAlign = ContentAlignment.MiddleRight
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(CBMastercard)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(CBVisa)
        Panel1.Controls.Add(LTdC)
        Panel1.Controls.Add(CBNaranja)
        Panel1.Controls.Add(LTelefono)
        Panel1.Controls.Add(LNyA)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(LDNI)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(TDni)
        Panel1.Location = New Point(12, 115)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 325)
        Panel1.TabIndex = 10
        ' 
        ' CBMastercard
        ' 
        CBMastercard.AutoSize = True
        CBMastercard.Location = New Point(168, 288)
        CBMastercard.Name = "CBMastercard"
        CBMastercard.Size = New Size(105, 24)
        CBMastercard.TabIndex = 16
        CBMastercard.Text = "Mastercard"
        CBMastercard.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(168, 184)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 10
        ' 
        ' CBVisa
        ' 
        CBVisa.AutoSize = True
        CBVisa.Location = New Point(168, 258)
        CBVisa.Name = "CBVisa"
        CBVisa.Size = New Size(58, 24)
        CBVisa.TabIndex = 15
        CBVisa.Text = "Visa"
        CBVisa.UseVisualStyleBackColor = True
        ' 
        ' LTdC
        ' 
        LTdC.AutoSize = True
        LTdC.Location = New Point(14, 228)
        LTdC.Name = "LTdC"
        LTdC.Size = New Size(125, 20)
        LTdC.TabIndex = 9
        LTdC.Text = "Tarjeta de crédito"
        ' 
        ' CBNaranja
        ' 
        CBNaranja.AutoSize = True
        CBNaranja.Location = New Point(168, 228)
        CBNaranja.Name = "CBNaranja"
        CBNaranja.Size = New Size(83, 24)
        CBNaranja.TabIndex = 14
        CBNaranja.Text = "Naranja"
        CBNaranja.UseVisualStyleBackColor = True
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(23, 187)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(67, 20)
        LTelefono.TabIndex = 8
        LTelefono.Text = "Telefono"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(411, 115)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 120)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Checked = True
        RBVaron.Location = New Point(371, 256)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(68, 24)
        RBVaron.TabIndex = 12
        RBVaron.TabStop = True
        RBVaron.Text = "Varón"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(487, 252)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(68, 24)
        RBMujer.TabIndex = 13
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Image = My.Resources.Resources.salir
        BSalir.ImageAlign = ContentAlignment.MiddleLeft
        BSalir.Location = New Point(402, 461)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(129, 63)
        BSalir.TabIndex = 14
        BSalir.Text = "Salir"
        BSalir.TextAlign = ContentAlignment.MiddleRight
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' LNuevoCliente
        ' 
        LNuevoCliente.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LNuevoCliente.ForeColor = Color.Blue
        LNuevoCliente.Location = New Point(203, 46)
        LNuevoCliente.Name = "LNuevoCliente"
        LNuevoCliente.Size = New Size(219, 45)
        LNuevoCliente.TabIndex = 16
        LNuevoCliente.Text = "Nuevo Cliente"
        ' 
        ' PequeñoFormulario
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(637, 554)
        Controls.Add(LNuevoCliente)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Name = "PequeñoFormulario"
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LModificar As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNyA As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LTdC As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents CBNaranja As CheckBox
    Friend WithEvents CBVisa As CheckBox
    Friend WithEvents CBMastercard As CheckBox
    Friend WithEvents BSalir As Button
    Friend WithEvents LNuevoCliente As Label

End Class
