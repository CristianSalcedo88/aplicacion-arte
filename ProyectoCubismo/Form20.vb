Public Class Form20
    Dim respuesta1 As Decimal
    Dim respuesta2 As Decimal
    Dim respuesta3 As Decimal
    Dim respuesta4 As Decimal
    Dim respuestafinal As Decimal
    Dim punto1 As Decimal
    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label6.Text = 0
    End Sub

    Public Sub respuestas()
        If RadioButton2.Checked Then
            respuesta1 = 1.25
        Else
            respuesta1 = 0
        End If

        If RadioButton6.Checked Then
            respuesta2 = 1.25
        Else
            respuesta2 = 0
        End If

        If RadioButton7.Checked Then

            respuesta3 = 1.25
        Else
            respuesta3 = 0

        End If

        If TextBox1.Text = "Violin y Jarra" Or TextBox1.Text = "violin y jarra" Or TextBox1.Text = "VIOLIN Y JARRA" Then

            respuesta4 = 1.25
        Else
            respuesta4 = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call respuestas()
        If PuntoAdicional.puntoExtra = 100 Then
            punto1 = 1.25

        Else
            punto1 = 0
        End If
        respuestafinal = respuesta1 + respuesta2 + respuesta3 + respuesta4 + punto1
        If (respuestafinal = 6.25) Then
            Label6.Text = 50
        Else
            Label6.Text = respuestafinal
        End If

        If respuestafinal < 60 Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Enabled = False
            TextBox1.Enabled = False

        End If


    End Sub
End Class