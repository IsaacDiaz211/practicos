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
        SuspendLayout()
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(175, 44)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(73, 20)
        LModificar.TabIndex = 0
        LModificar.Text = "modificar"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Location = New Point(63, 90)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(35, 20)
        LDNI.TabIndex = 1
        LDNI.Text = "DNI"
        ' 
        ' LNyA
        ' 
        LNyA.AutoSize = True
        LNyA.Location = New Point(22, 44)
        LNyA.Name = "LNyA"
        LNyA.Size = New Size(137, 20)
        LNyA.TabIndex = 2
        LNyA.Text = "Nombre y apellido:"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(46, 129)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(66, 20)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(48, 174)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(64, 20)
        LNombre.TabIndex = 4
        LNombre.Text = "Nombre"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(175, 87)
        TDni.Name = "TDni"
        TDni.Size = New Size(125, 27)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(175, 126)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(125, 27)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(175, 171)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(125, 27)
        TNombre.TabIndex = 7
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(22, 226)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(94, 29)
        BGuardar.TabIndex = 8
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(191, 226)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(94, 29)
        BEliminar.TabIndex = 9
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' PequeñoFormulario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 303)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TNombre)
        Controls.Add(TApellido)
        Controls.Add(TDni)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(LNyA)
        Controls.Add(LDNI)
        Controls.Add(LModificar)
        Name = "PequeñoFormulario"
        Text = "Pequeño Formulario"
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

End Class
