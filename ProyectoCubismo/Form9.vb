Public Class Form9
    Dim res1 As Integer
    Dim res2 As Integer
    Dim res3 As Integer
    Dim res4 As Integer
    Dim res5 As Integer
    Dim resFinal As Integer
    Dim punto As Integer



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = 0

    End Sub
    Public Sub Contenido()
        If TextBox1.Text = "G" And TextBox2.Text = "U" And TextBox3.Text = "E" And TextBox4.Text = "R" And TextBox5.Text = "N" And TextBox6.Text = "I" And TextBox7.Text = "C" And TextBox8.Text = "A" Then
        ElseIf TextBox1.Text = "g" And TextBox2.Text = "u" And TextBox3.Text = "e" And TextBox4.Text = "r" And TextBox5.Text = "n" And TextBox6.Text = "i" And TextBox7.Text = "c" And TextBox8.Text = "a" Then
            res1 = 20
        Else
            res1 = 0

        End If
        If TextBox15.Text = "P" And TextBox16.Text = "B" And TextBox17.Text = "L" And TextBox18.Text = "O" And TextBox19.Text = "P" And TextBox20.Text = "I" And TextBox21.Text = "C" And TextBox22.Text = "A" And TextBox23.Text = "S" And TextBox24.Text = "S" And TextBox25.Text = "O" Or TextBox25.Text = "0" Then
        ElseIf TextBox15.Text = "p" And TextBox16.Text = "b" And TextBox17.Text = "l" And TextBox18.Text = "o" And TextBox19.Text = "p" And TextBox20.Text = "i" And TextBox21.Text = "c" And TextBox22.Text = "a" And TextBox23.Text = "s" And TextBox24.Text = "s" And TextBox25.Text = "o" Then
            res2 = 20
        Else
            res2 = 0

        End If
        If TextBox29.Text = "E" And TextBox30.Text = "O" And TextBox31.Text = "R" And TextBox32.Text = "G" And TextBox33.Text = "E" And TextBox34.Text = "S" And TextBox35.Text = "B" And TextBox36.Text = "R" And TextBox37.Text = "A" And TextBox38.Text = "Q" And TextBox39.Text = "U" And TextBox40.Text = "E" Then
        ElseIf TextBox29.Text = "e" And TextBox30.Text = "o" And TextBox31.Text = "r" And TextBox32.Text = "g" And TextBox33.Text = "e" And TextBox34.Text = "s" And TextBox35.Text = "b" And TextBox36.Text = "r" And TextBox37.Text = "a" And TextBox38.Text = "q" And TextBox39.Text = "u" And TextBox40.Text = "e" Then
            res3 = 20
        Else
            res3 = 0

        End If
        If TextBox9.Text = "C" And TextBox10.Text = "U" And TextBox11.Text = "B" And TextBox12.Text = "S" And TextBox13.Text = "M" And TextBox14.Text = "O" Then
        ElseIf TextBox9.Text = "c" And TextBox10.Text = "u" And TextBox11.Text = "b" And TextBox12.Text = "s" And TextBox13.Text = "m" And TextBox14.Text = "o" Then
            res4 = 20
        Else
            res4 = 0

        End If
        If TextBox28.Text = "1" And TextBox27.Text = "9" And TextBox26.Text = "7" Then
            res5 = 20
        Else
            res5 = 0

        End If

    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Contenido()

        resFinal = res1 + res2 + res3 + res4 + res5
        PuntoAdicional.puntoExtra = resFinal




        Label15.Text = resFinal

        If resFinal < 101 Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            TextBox14.Enabled = False
            TextBox15.Enabled = False
            TextBox16.Enabled = False
            TextBox17.Enabled = False
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
            TextBox21.Enabled = False
            TextBox22.Enabled = False
            TextBox23.Enabled = False
            TextBox24.Enabled = False
            TextBox25.Enabled = False
            TextBox26.Enabled = False
            TextBox27.Enabled = False
            TextBox28.Enabled = False
            TextBox29.Enabled = False
            TextBox30.Enabled = False
            TextBox31.Enabled = False
            TextBox32.Enabled = False
            TextBox33.Enabled = False
            TextBox34.Enabled = False
            TextBox35.Enabled = False
            TextBox36.Enabled = False
            TextBox37.Enabled = False
            TextBox38.Enabled = False
            TextBox39.Enabled = False
            TextBox40.Enabled = False

        End If

    End Sub
    'Function PuntoExtra()
    'resFinal = res1 + res2 + res3 + res4 + res5
    'f resFinal = 100 Then
    '   punto = 1
    'lse
    '    punto = resFinal

    'nd If





    ' MsgBox(resFinal)

    'Return punto
    'End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class