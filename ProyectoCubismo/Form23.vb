Public Class Form23
    Dim x As Integer
    Dim v As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim s As Integer
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.Panel3.Controls.Count > 0 Then Me.Panel3.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel3.Controls.Add(fh)
        Me.Panel3.Tag = fh
        fh.Show()
    End Sub
    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(New Form33)
        Timer2.Enabled = True
        PictureBox3.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormEnPanel(New Form34)
        Timer5.Enabled = True
        PictureBox6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormEnPanel(New Form35)
        Timer6.Enabled = True
        PictureBox7.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(New Form28)
        Timer1.Enabled = True
        PictureBox2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(New Form29)
        Timer3.Enabled = True
        PictureBox4.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 1
        PictureBox2.Location = New Point(45, 10 + x)
        If x = 89 Then
            Timer1.Enabled = False
            PictureBox2.Visible = False
            PictureBox2.Location = New Point(45, 10)
            x = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        v = v + 1
        PictureBox3.Location = New Point(45, 10 + v)
        If v = 160 Then
            Timer2.Enabled = False
            PictureBox3.Visible = False
            PictureBox3.Location = New Point(45, 10)
            v = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        b = b + 1
        PictureBox4.Location = New Point(45, 10 + b)
        If b = 245 Then
            Timer3.Enabled = False
            PictureBox4.Visible = False
            PictureBox4.Location = New Point(45, 10)
            b = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        c = c + 1
        PictureBox5.Location = New Point(45, 10 + c)
        If c = 325 Then
            Timer4.Enabled = False
            PictureBox5.Visible = False
            PictureBox5.Location = New Point(45, 10)
            c = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        d = d + 1
        PictureBox6.Location = New Point(45, 10 + d)
        If d = 406 Then
            Timer5.Enabled = False
            PictureBox6.Visible = False
            PictureBox6.Location = New Point(45, 10)
            d = 0
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        s = s + 1
        PictureBox7.Location = New Point(45, 10 + s)
        If s = 478 Then
            Timer6.Enabled = False
            PictureBox7.Visible = False
            PictureBox7.Location = New Point(45, 10)
            s = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer4.Enabled = True
        PictureBox5.Visible = True
    End Sub
End Class