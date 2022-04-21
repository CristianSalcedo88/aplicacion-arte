Public Class Form4
    Dim x As Integer
    Dim v As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim s As Integer
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
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.Panel7.Controls.Count > 0 Then Me.Panel7.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel7.Controls.Add(fh)
        Me.Panel7.Tag = fh
        fh.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(New Form18)
        Timer4.Enabled = True
        PictureBox8.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 1
        PictureBox5.Location = New Point(45, 10 + x)
        If x = 89 Then
            Timer1.Enabled = False
            PictureBox5.Visible = False
            PictureBox5.Location = New Point(45, 10)
            x = 0
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        v = v + 1
        PictureBox6.Location = New Point(45, 10 + v)
        If v = 160 Then
            Timer2.Enabled = False
            PictureBox6.Visible = False
            PictureBox6.Location = New Point(45, 10)
            v = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        b = b + 1
        PictureBox7.Location = New Point(45, 10 + b)
        If b = 245 Then
            Timer3.Enabled = False
            PictureBox7.Visible = False
            PictureBox7.Location = New Point(45, 10)
            b = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        c = c + 1
        PictureBox8.Location = New Point(45, 10 + c)
        If c = 325 Then
            Timer4.Enabled = False
            PictureBox8.Visible = False
            PictureBox8.Location = New Point(45, 10)
            c = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        d = d + 1
        PictureBox9.Location = New Point(45, 10 + d)
        If d = 406 Then
            Timer5.Enabled = False
            PictureBox9.Visible = False
            PictureBox9.Location = New Point(45, 10)
            d = 0
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        s = s + 1
        PictureBox10.Location = New Point(45, 10 + s)
        If s = 478 Then
            Timer6.Enabled = False
            PictureBox10.Visible = False
            PictureBox10.Location = New Point(45, 10)
            s = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(New Form6)
        Timer1.Enabled = True
        PictureBox5.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(New Form25)
        Timer2.Enabled = True
        PictureBox6.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormEnPanel(New Form7)
        Timer3.Enabled = True
        PictureBox7.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormEnPanel(New Form9)
        Timer5.Enabled = True
        PictureBox9.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirFormEnPanel(New Form20)
        Timer6.Enabled = True
        PictureBox10.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class