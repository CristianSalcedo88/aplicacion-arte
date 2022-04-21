Public Class Form7
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(New Form16)
    End Sub
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelCubismo.Controls.Count > 0 Then Me.PanelCubismo.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelCubismo.Controls.Add(fh)
        Me.PanelCubismo.Tag = fh
        fh.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(New Form17)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label5.Visible = False Then
            Label5.Visible = True
        Else
            Label5.Visible = False
        End If

    End Sub
End Class