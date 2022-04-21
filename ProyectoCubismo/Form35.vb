Public Class Form35
    Dim respuesta1 As Decimal
    Dim respuesta2 As Decimal
    Dim respuesta3 As Decimal
    Dim respuesta4 As Decimal
    Dim respuestafinal As Decimal
    Private Sub Form35_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label22.Text = 0
    End Sub
    Public Sub respuestas()
        If RadioButton3.Checked Then
            respuesta1 = 1.25
        Else
            respuesta1 = 0
        End If

        If RadioButton5.Checked Then
            respuesta2 = 1.25
        Else
            respuesta2 = 0
        End If

        If RadioButton9.Checked Then

            respuesta3 = 1.25
        Else
            respuesta3 = 0

        End If
        If RadioButton13.Checked Then

            respuesta4 = 1.25
        Else
            respuesta4 = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call respuestas()
        respuestafinal = respuesta1 + respuesta2 + respuesta3 + respuesta4

        Label22.Text = respuestafinal

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
            RadioButton10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton14.Enabled = False
            RadioButton15.Enabled = False
            RadioButton16.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class