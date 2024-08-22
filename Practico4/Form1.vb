Imports System.Windows.Forms.DataVisualization.Charting

Public Class Formulario4

    Private Sub LListaNumeros_Click(sender As Object, e As EventArgs) Handles LListaNumeros.Click

    End Sub

    Private Sub TDesde_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TDesde.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub THasta_TextChanged(sender As Object, e As KeyPressEventArgs) Handles THasta.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BGenerar_Click(sender As Object, e As EventArgs) Handles BGenerar.Click
        If TDesde.Text = "" Or THasta.Text = "" Then
            MsgBox("Debe completar todos los campos", vbCritical, "Error")
        Else
            ListBox1.Items.Clear()
            If CBPrimos.Checked Then
                primos()
            ElseIf CBPares.Checked Then
                pares()
            Else
                impares()
            End If
        End If
    End Sub

    Private Sub pares()
        Dim desde As Int16
        Dim hasta As Int16
        desde = TDesde.Text
        hasta = THasta.Text
        While (desde <= hasta)
            If (desde Mod 2 = 0) Then

                ListBox1.Items.Add(desde)
            End If
            desde = desde + 1
        End While
    End Sub

    Private Sub impares()
        Dim desde As Int16
        Dim hasta As Int16
        desde = TDesde.Text
        hasta = THasta.Text
        While (desde <= hasta)
            If (desde Mod 2 <> 0) Then
                ListBox1.Items.Add(desde)
            End If
            desde = desde + 1
        End While
    End Sub

    Private Sub primos()

        Dim desde As Integer
        Dim hasta As Integer
        Dim divisor As Integer
        Dim esPrimo As Boolean
        desde = TDesde.Text
        hasta = THasta.Text
        While desde <= hasta
            esPrimo = True
            If desde > 2 Then

                For divisor = 2 To Math.Sqrt(desde)
                    If desde Mod divisor = 0 Then
                        esPrimo = False
                        Exit For
                    End If
                Next
            End If
            If esPrimo Then
                ListBox1.Items.Add(desde)
            End If
            desde += 1
        End While
    End Sub

    Private Sub CBPares_CheckedChanged(sender As Object, e As EventArgs) Handles CBPares.CheckedChanged
        CBImpares.Checked = False
        CBPrimos.Checked = False
        'mostrarPares = True
    End Sub

    Private Sub CBImpares_CheckedChanged(sender As Object, e As EventArgs) Handles CBImpares.CheckedChanged
        CBPares.Checked = False
        CBPrimos.Checked = False
    End Sub

    Private Sub CBPrimos_CheckedChanged(sender As Object, e As EventArgs) Handles CBPrimos.CheckedChanged
        CBImpares.Checked = False
        CBPares.Checked = False
    End Sub

    Private Sub BGrafico_Click(sender As Object, e As EventArgs) Handles BGrafico.Click

        Chart1.Series("Series1").Points.Clear()

        For Each item As String In ListBox1.Items
            Dim numero As Integer = Integer.Parse(item)
            Chart1.Series("Series1").Points.AddY(numero)
        Next
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class
