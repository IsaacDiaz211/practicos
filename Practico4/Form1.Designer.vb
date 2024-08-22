<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario4
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        LDesde = New Label()
        LHasta = New Label()
        LListaNumeros = New Label()
        TDesde = New TextBox()
        THasta = New TextBox()
        ListBox1 = New ListBox()
        BGenerar = New Button()
        CBPares = New CheckBox()
        CBImpares = New CheckBox()
        CBPrimos = New CheckBox()
        BGrafico = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LDesde
        ' 
        LDesde.AutoSize = True
        LDesde.Location = New Point(34, 64)
        LDesde.Name = "LDesde"
        LDesde.Size = New Size(51, 20)
        LDesde.TabIndex = 0
        LDesde.Text = "Desde"
        ' 
        ' LHasta
        ' 
        LHasta.AutoSize = True
        LHasta.Location = New Point(34, 131)
        LHasta.Name = "LHasta"
        LHasta.Size = New Size(47, 20)
        LHasta.TabIndex = 1
        LHasta.Text = "Hasta"
        ' 
        ' LListaNumeros
        ' 
        LListaNumeros.AutoSize = True
        LListaNumeros.Font = New Font("Segoe UI", 15F)
        LListaNumeros.Location = New Point(301, 9)
        LListaNumeros.Name = "LListaNumeros"
        LListaNumeros.Size = New Size(210, 35)
        LListaNumeros.TabIndex = 2
        LListaNumeros.Text = "Lista de Números"
        ' 
        ' TDesde
        ' 
        TDesde.Location = New Point(115, 61)
        TDesde.Name = "TDesde"
        TDesde.Size = New Size(125, 27)
        TDesde.TabIndex = 3
        ' 
        ' THasta
        ' 
        THasta.Location = New Point(115, 128)
        THasta.Name = "THasta"
        THasta.Size = New Size(125, 27)
        THasta.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(481, 60)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(288, 224)
        ListBox1.TabIndex = 5
        ' 
        ' BGenerar
        ' 
        BGenerar.Location = New Point(277, 60)
        BGenerar.Name = "BGenerar"
        BGenerar.Size = New Size(147, 29)
        BGenerar.TabIndex = 6
        BGenerar.Text = "Generar función"
        BGenerar.UseVisualStyleBackColor = True
        ' 
        ' CBPares
        ' 
        CBPares.AutoSize = True
        CBPares.Location = New Point(277, 109)
        CBPares.Name = "CBPares"
        CBPares.Size = New Size(131, 24)
        CBPares.TabIndex = 11
        CBPares.Text = "Números pares"
        CBPares.UseVisualStyleBackColor = True
        ' 
        ' CBImpares
        ' 
        CBImpares.AutoSize = True
        CBImpares.Location = New Point(277, 139)
        CBImpares.Name = "CBImpares"
        CBImpares.Size = New Size(148, 24)
        CBImpares.TabIndex = 12
        CBImpares.Text = "Números impares"
        CBImpares.UseVisualStyleBackColor = True
        ' 
        ' CBPrimos
        ' 
        CBPrimos.AutoSize = True
        CBPrimos.Location = New Point(277, 169)
        CBPrimos.Name = "CBPrimos"
        CBPrimos.Size = New Size(141, 24)
        CBPrimos.TabIndex = 13
        CBPrimos.Text = "Números primos"
        CBPrimos.UseVisualStyleBackColor = True
        ' 
        ' BGrafico
        ' 
        BGrafico.Location = New Point(277, 218)
        BGrafico.Name = "BGrafico"
        BGrafico.Size = New Size(148, 29)
        BGrafico.TabIndex = 16
        BGrafico.Text = "Generar gráfico"
        BGrafico.UseVisualStyleBackColor = True
        ' 
        ' Chart1
        ' 
        Chart1.AllowDrop = True
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(64, 265)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(375, 290)
        Chart1.TabIndex = 17
        Chart1.Text = "Chart1"
        ' 
        ' Formulario4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 585)
        Controls.Add(Chart1)
        Controls.Add(BGrafico)
        Controls.Add(CBPrimos)
        Controls.Add(CBImpares)
        Controls.Add(CBPares)
        Controls.Add(BGenerar)
        Controls.Add(ListBox1)
        Controls.Add(THasta)
        Controls.Add(TDesde)
        Controls.Add(LListaNumeros)
        Controls.Add(LHasta)
        Controls.Add(LDesde)
        Name = "Formulario4"
        Text = "Formulario4"
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDesde As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents LListaNumeros As Label
    Friend WithEvents TDesde As TextBox
    Friend WithEvents THasta As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BGenerar As Button
    Friend WithEvents CBPares As CheckBox
    Friend WithEvents CBImpares As CheckBox
    Friend WithEvents CBPrimos As CheckBox
    Friend WithEvents BGrafico As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart

End Class
