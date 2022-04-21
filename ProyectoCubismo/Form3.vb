Public Class Form3
    Dim q As Integer
    Dim w As Integer
    Dim r As Integer
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size = New Size(189, 126)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(185, 122)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Size = New Size(192, 126)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(188, 122)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Timer1.Enabled = True
        PictureBox5.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer2.Enabled = True
        PictureBox6.Visible = True
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Size = New Size(136, 44)
        PictureBox3.BackgroundImage = My.Resources.salir2
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(132, 40)
        PictureBox3.BackgroundImage = My.Resources.salir1
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        q = q + 1
        PictureBox5.Location = New Point(425, 141 + q)
        If q = 200 Then
            Timer1.Enabled = False
            PictureBox5.Visible = False
            PictureBox5.Location = New Point(45, 10)
            q = 0
            Form4.Show()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        w = w + 1
        PictureBox6.Location = New Point(831, 141 + w)
        If w = 200 Then
            Timer1.Enabled = False
            PictureBox6.Visible = False
            PictureBox6.Location = New Point(45, 10)
            w = 0
            Form5.Show()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Timer3.Enabled = True
        PictureBox8.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        r = r + 1
        PictureBox8.Location = New Point(639, 141 + r)
        If r = 200 Then
            Timer3.Enabled = False
            PictureBox8.Visible = False
            PictureBox8.Location = New Point(45, 10)
            r = 0
            Form23.Show()
        End If
    End Sub
End Class