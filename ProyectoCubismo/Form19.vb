Public Class Form19
    Dim res1 As Integer
    Dim res2 As Integer
    Dim res3 As Integer
    Dim res4 As Integer
    Dim res5 As Integer
    Dim resFinal As Integer

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = 0
    End Sub
    Public Sub Contenido()
        If TextBox1.Text = "F" And TextBox2.Text = "R" And TextBox3.Text = "A" And TextBox4.Text = "N" And TextBox5.Text = "C" And TextBox6.Text = "I" And TextBox7.Text = "A" Then
        ElseIf TextBox1.Text = "f" And TextBox2.Text = "r" And TextBox3.Text = "a" And TextBox4.Text = "n" And TextBox5.Text = "c" And TextBox6.Text = "i" And TextBox7.Text = "a" Then
            res1 = 20
        Else
            res1 = 0
        End If
        If TextBox8.Text = "P" And TextBox9.Text = "E" And TextBox10.Text = "R" And TextBox11.Text = "R" And TextBox12.Text = "E" And TextBox13.Text = "A" And TextBox14.Text = "U" And TextBox15.Text = "G" And TextBox16.Text = "U" And TextBox17.Text = "S" And TextBox18.Text = "T" And TextBox19.Text = "E" Then
        ElseIf TextBox8.Text = "p" And TextBox9.Text = "e" And TextBox10.Text = "r" And TextBox11.Text = "r" And TextBox12.Text = "e" And TextBox13.Text = "a" And TextBox14.Text = "u" And TextBox15.Text = "g" And TextBox16.Text = "u" And TextBox17.Text = "s" And TextBox18.Text = "t" And TextBox19.Text = "e" Then
            res2 = 20
        Else
            res2 = 0
        End If
        If TextBox27.Text = "N" And TextBox28.Text = "I" And TextBox29.Text = "B" And TextBox30.Text = "E" And TextBox31.Text = "L" Then
        ElseIf TextBox27.Text = "n" And TextBox28.Text = "i" And TextBox29.Text = "b" And TextBox30.Text = "e" And TextBox31.Text = "l" Then
            res3 = 20
        Else
            res3 = 0
        End If
        If TextBox32.Text = "I" And TextBox33.Text = "M" And TextBox34.Text = "P" And TextBox35.Text = "R" And TextBox36.Text = "E" And TextBox37.Text = "I" And TextBox38.Text = "O" And TextBox39.Text = "N" And TextBox40.Text = "I" And TextBox41.Text = "S" And TextBox42.Text = "M" And TextBox43.Text = "O" Then
        ElseIf TextBox32.Text = "i" And TextBox33.Text = "m" And TextBox34.Text = "p" And TextBox35.Text = "r" And TextBox36.Text = "e" And TextBox37.Text = "i" And TextBox38.Text = "o" And TextBox39.Text = "n" And TextBox40.Text = "i" And TextBox41.Text = "s" And TextBox42.Text = "m" And TextBox43.Text = "o" Then
            res4 = 20
        Else
            res4 = 0
        End If
        If TextBox20.Text = "E" And TextBox21.Text = "D" And TextBox22.Text = "G" And TextBox23.Text = "A" And TextBox24.Text = "D" And TextBox25.Text = "E" And TextBox26.Text = "G" And TextBox44.Text = "A" And TextBox45.Text = "S" Then
        ElseIf TextBox20.Text = "e" And TextBox21.Text = "d" And TextBox22.Text = "g" And TextBox23.Text = "a" And TextBox24.Text = "d" And TextBox25.Text = "e" And TextBox26.Text = "g" And TextBox44.Text = "a" And TextBox45.Text = "s" Then
            res5 = 20
        Else
            res5 = 0
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Contenido()
        resFinal = res1 + res2 + res3 + res4 + res5
        PuntoAdicional.PuntoExtraImpre = resFinal


        Label15.Text = resFinal
        If resFinal < 60 Then
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
            TextBox41.Enabled = False
            TextBox42.Enabled = False
            TextBox43.Enabled = False
            TextBox44.Enabled = False
            TextBox45.Enabled = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class